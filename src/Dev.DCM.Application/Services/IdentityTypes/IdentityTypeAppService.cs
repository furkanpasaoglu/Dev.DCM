using Dev.DCM.Entities.IdentityTypes;
using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Dev.DCM.Services.IdentityTypes;

public class IdentityTypeAppService :
    CrudAppService<
        IdentityType,
        IdentityTypeDto,
        Guid,
        PagedAndSortedResultRequestDto,
        CreateUpdateIdentityTypeDto>,
    IIdentityTypeAppService
{
    public IdentityTypeAppService(IRepository<IdentityType, Guid> repository) : base(repository)
    {
        GetPolicyName = Permissions.DCMPermissions.IdentityTypes.Default;
        GetListPolicyName = Permissions.DCMPermissions.IdentityTypes.Default;
        CreatePolicyName = Permissions.DCMPermissions.IdentityTypes.Create;
        UpdatePolicyName = Permissions.DCMPermissions.IdentityTypes.Edit;
        DeletePolicyName = Permissions.DCMPermissions.IdentityTypes.Delete;
    }
}