using System;
using Dev.DCM.Entities.Countries;
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
        GetPolicyName = Permissions.DCMPermissions.Countries.Default;
        GetListPolicyName = Permissions.DCMPermissions.Countries.Default;
        CreatePolicyName = Permissions.DCMPermissions.Countries.Create;
        UpdatePolicyName = Permissions.DCMPermissions.Countries.Edit;
        DeletePolicyName = Permissions.DCMPermissions.Countries.Delete;
    }
}
