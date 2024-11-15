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

public class DistrictAppService(IRepository<District, Guid> repository, DistrictAppValidationService districtAppValidation) :
    CrudAppService<
        District,
        DistrictDto,
        Guid,
        PagedAndSortedResultRequestDto,
        CreateUpdateDistrictDto>(repository),
    IDistrictAppService
{
    protected override string GetPolicyName { get; set; } = Permissions.DCMPermissions.Locations.Districts.Default;
    protected override string GetListPolicyName { get; set; } = Permissions.DCMPermissions.Locations.Districts.Default;
    protected override string CreatePolicyName { get; set; } = Permissions.DCMPermissions.Locations.Districts.Create;
    protected override string UpdatePolicyName { get; set; } = Permissions.DCMPermissions.Locations.Districts.Edit;
    protected override string DeletePolicyName { get; set; } = Permissions.DCMPermissions.Locations.Districts.Delete;

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
        await ValidateDtoAsync(input.Name);
        return await base.CreateAsync(input);
    }

    public override async Task<DistrictDto> UpdateAsync(Guid id, CreateUpdateDistrictDto input)
    {
        await ValidateDtoAsync(input.Name);
        return await base.UpdateAsync(id, input);
    }
    private async Task ValidateDtoAsync(string name)
    {
        await districtAppValidation.IsDistrictExists(name);
    }
}