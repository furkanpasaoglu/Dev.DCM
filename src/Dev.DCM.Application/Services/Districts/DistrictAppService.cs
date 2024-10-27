using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dev.DCM.Entities.Districts;
using Volo.Abp;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Dev.DCM.Services.Districts;

public class DistrictAppService :
    CrudAppService<
        District,
        DistrictDto,
        Guid,
        PagedAndSortedResultRequestDto,
        CreateUpdateDistrictDto>,
    IDistrictAppService
{
    public DistrictAppService(IRepository<District, Guid> repository) : base(repository)
    {
        GetPolicyName = Permissions.DCMPermissions.Districts.Default;
        GetListPolicyName = Permissions.DCMPermissions.Districts.Default;
        CreatePolicyName = Permissions.DCMPermissions.Districts.Create;
        UpdatePolicyName = Permissions.DCMPermissions.Districts.Edit;
        DeletePolicyName = Permissions.DCMPermissions.Districts.Delete;
    }

    public override async Task<PagedResultDto<DistrictDto>> GetListAsync(PagedAndSortedResultRequestDto input)
    {
        var queryable = await Repository.WithDetailsAsync(c => c.City);
        var totalCount = await AsyncExecuter.CountAsync(queryable);
        var items = await AsyncExecuter.ToListAsync(queryable.PageBy(input));
        
        return new PagedResultDto<DistrictDto>(
            totalCount,
            ObjectMapper.Map<List<District>, List<DistrictDto>>(items)
        );
    }

    public override async Task<DistrictDto> CreateAsync(CreateUpdateDistrictDto input)
    {
        await IsDistrictExists(input.Name);
        return await base.CreateAsync(input);
    }
    
    #region Validation

    private async Task IsDistrictExists(string name)
    {
        var existing = await Repository.AnyAsync(c => c.Name == name);
        if (!existing)
        {
            throw new UserFriendlyException(message: L["AlreadyExists"]);
        }
    }

    #endregion
}