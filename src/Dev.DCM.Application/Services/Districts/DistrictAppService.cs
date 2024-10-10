using System;
using Dev.DCM.Entities.Districts;
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
}