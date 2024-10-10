using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dev.DCM.Entities.Cities;
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
    //Override method include country name
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

   
}