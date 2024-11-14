using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dev.DCM.Entities.Cities;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Dev.DCM.Services.Cities;

public class CityAppService(IRepository<City, Guid> repository, CityValidationService cityValidationService)
    : CrudAppService<
            City,
            CityDto,
            Guid,
            PagedAndSortedResultRequestDto,
            CreateUpdateCityDto>(repository),
        ICityAppService
{
    protected override string? GetPolicyName { get; set; } = Permissions.DCMPermissions.Locations.Cities.Default;
    protected override string? GetListPolicyName { get; set; } = Permissions.DCMPermissions.Locations.Cities.Default;
    protected override string? CreatePolicyName { get; set; } = Permissions.DCMPermissions.Locations.Cities.Create;
    protected override string? UpdatePolicyName { get; set; } = Permissions.DCMPermissions.Locations.Cities.Edit;
    protected override string? DeletePolicyName { get; set; } = Permissions.DCMPermissions.Locations.Cities.Delete;
    
    public override async Task<PagedResultDto<CityDto>> GetListAsync(PagedAndSortedResultRequestDto input)
    {
        var queryable = await Repository.WithDetailsAsync(c => c.Country);
        var totalCount = await AsyncExecuter.CountAsync(queryable);
        var items = await AsyncExecuter.ToListAsync(
            queryable.PageBy(input)
                .OrderBy(c => c.Name)
        );
        
        return new PagedResultDto<CityDto>(
            totalCount,
            ObjectMapper.Map<List<City>, List<CityDto>>(items)
        );
    }
    private async Task ValidateDtoAsync(CreateUpdateCityDto input, Guid? existingId = null)
    {
        await cityValidationService.IsCityNameUniqueAsync(input.Name, existingId);
    }
    public override async Task<CityDto> CreateAsync(CreateUpdateCityDto input)
    {
        await ValidateDtoAsync(input);
        return await base.CreateAsync(input);
    }
    public override async Task<CityDto> UpdateAsync(Guid id, CreateUpdateCityDto input)
    {
        await ValidateDtoAsync(input);
        return await base.UpdateAsync(id, input);
    }
}