using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dev.DCM.Entities.Cities;
using Volo.Abp;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Dev.DCM.Services.Cities;

public class CityAppService :
    CrudAppService<
        City,
        CityDto,
        Guid,
        PagedAndSortedResultRequestDto,
        CreateUpdateCityDto>,
    ICityAppService
{
    public CityAppService(IRepository<City, Guid> repository) : base(repository)
    {
        GetPolicyName = Permissions.DCMPermissions.Cities.Default;
        GetListPolicyName = Permissions.DCMPermissions.Cities.Default;
        CreatePolicyName = Permissions.DCMPermissions.Cities.Create;
        UpdatePolicyName = Permissions.DCMPermissions.Cities.Edit;
        DeletePolicyName = Permissions.DCMPermissions.Cities.Delete;
    }
    public override async Task<PagedResultDto<CityDto>> GetListAsync(PagedAndSortedResultRequestDto input)
    {
        var queryable = await Repository.WithDetailsAsync(c => c.Country);
        var totalCount = await AsyncExecuter.CountAsync(queryable);
        var items = await AsyncExecuter.ToListAsync(queryable.PageBy(input));
        
        return new PagedResultDto<CityDto>(
            totalCount,
            ObjectMapper.Map<List<City>, List<CityDto>>(items)
        );
    }
    
    public override async Task<CityDto> CreateAsync(CreateUpdateCityDto input)
    {
        await IsCityExists(input.Name);
        return await base.CreateAsync(input);
    }


    #region Validation

    /// <summary>
    /// Şehir adı veritabanında mevcut mu kontrolü yapar.
    /// </summary>
    /// <param name="name"> Şehir adı</param>
    /// <exception cref="UserFriendlyException"> Şehir adı veritabanında mevcut ise fırlatılır.</exception>
    private async Task IsCityExists(string name)
    {
        var existing = await Repository.AnyAsync(c => c.Name == name);
        if (!existing)
        {
            throw new UserFriendlyException(message: L["AlreadyExists"]);
        }
    }

    #endregion
    
}