using System;
using System.Threading.Tasks;
using Dev.DCM.Entities.Countries;
using Volo.Abp;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Dev.DCM.Services.Countries;

public class CountryAppService(IRepository<Country, Guid> repository, CountryValidationService countryValidationService) :
    CrudAppService<
        Country,
        CountryDto,
        Guid,
        PagedAndSortedResultRequestDto,
        CreateUpdateCountryDto>(repository),
    ICountryAppService
{
    protected override string? GetPolicyName { get; set; } = Permissions.DCMPermissions.Locations.Countries.Default;
    protected override string? GetListPolicyName { get; set; } = Permissions.DCMPermissions.Locations.Countries.Default;
    protected override string? CreatePolicyName { get; set; } = Permissions.DCMPermissions.Locations.Countries.Create;
    protected override string? UpdatePolicyName { get; set; } = Permissions.DCMPermissions.Locations.Countries.Edit;
    protected override string? DeletePolicyName { get; set; } = Permissions.DCMPermissions.Locations.Countries.Delete;

    public override async Task<CountryDto> CreateAsync(CreateUpdateCountryDto input)
    {
        await ValidateDtoAsync(input.Name, input.Code);
        return await base.CreateAsync(input);
    }

    private async Task ValidateDtoAsync(string name, string? code)
    {
       await countryValidationService.IsCountryNameUniqueAsync(name);
    }

    public override async Task<CountryDto> UpdateAsync(Guid id, CreateUpdateCountryDto input)
    {
        await ValidateDtoAsync(input.Name, input.Code);
        return await base.UpdateAsync(id, input);
    }
}
