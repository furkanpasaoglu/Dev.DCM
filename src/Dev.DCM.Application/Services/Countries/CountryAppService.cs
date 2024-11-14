using System;
using System.Threading.Tasks;
using Dev.DCM.Entities.Countries;
using Volo.Abp;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Dev.DCM.Services.Countries;

public class CountryAppService :
    CrudAppService<
        Country,
        CountryDto,
        Guid,
        PagedAndSortedResultRequestDto,
        CreateUpdateCountryDto>,
    ICountryAppService
{
    public CountryAppService(IRepository<Country, Guid> repository) : base(repository)
    {
        GetPolicyName = Permissions.DCMPermissions.Locations.Countries.Default;
        GetListPolicyName = Permissions.DCMPermissions.Locations.Countries.Default;
        CreatePolicyName = Permissions.DCMPermissions.Locations.Countries.Create;
        UpdatePolicyName = Permissions.DCMPermissions.Locations.Countries.Edit;
        DeletePolicyName = Permissions.DCMPermissions.Locations.Countries.Delete;
    }

    public override async Task<CountryDto> CreateAsync(CreateUpdateCountryDto input)
    {
        await IsCountryExists(input.Name, input.Code);
        return await base.CreateAsync(input);
    }

    #region Validation

    private async Task IsCountryExists(string name, string? code)
    {
        var existing = await Repository.AnyAsync(c => c.Name == name || c.Code == name);
        if (existing)
        {
            throw new UserFriendlyException(message: L["AlreadyExists"]);
        }
    }

    #endregion
}
