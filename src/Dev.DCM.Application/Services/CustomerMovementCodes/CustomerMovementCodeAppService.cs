using Dev.DCM.Entities.CustomerMovementCodes;
using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Dev.DCM.Services.CustomerMovementCodes;

public class CustomerMovementCodeAppService :
    CrudAppService<
        CustomerMovementCode,
        CustomerMovementCodeDto,
        Guid,
        PagedAndSortedResultRequestDto,
        CreateUpdateCustomerMovementCodeDto>,
    ICustomerMovementCodeAppService
{
    public CustomerMovementCodeAppService(IRepository<CustomerMovementCode, Guid> repository) : base(repository)
    {
        GetPolicyName = Permissions.DCMPermissions.CustomerMovementCodes.Default;
        GetListPolicyName = Permissions.DCMPermissions.CustomerMovementCodes.Default;
        CreatePolicyName = Permissions.DCMPermissions.CustomerMovementCodes.Create;
        UpdatePolicyName = Permissions.DCMPermissions.CustomerMovementCodes.Edit;
        DeletePolicyName = Permissions.DCMPermissions.CustomerMovementCodes.Delete;
    }
}