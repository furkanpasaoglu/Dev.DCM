using Dev.DCM.Entities.ServiceTypes;
using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Dev.DCM.Services.ServiceTypes;

public class ServiceTypeAppService :
    CrudAppService<
        ServiceType,
        ServiceTypeDto,
        Guid,
        PagedAndSortedResultRequestDto,
        CreateUpdateServiceTypeDto>,
    IServiceTypeAppService
{
    public ServiceTypeAppService(IRepository<ServiceType, Guid> repository) : base(repository)
    {
        GetPolicyName = Permissions.DCMPermissions.ServiceTypes.Default;
        GetListPolicyName = Permissions.DCMPermissions.ServiceTypes.Default;
        CreatePolicyName = Permissions.DCMPermissions.ServiceTypes.Create;
        UpdatePolicyName = Permissions.DCMPermissions.ServiceTypes.Edit;
        DeletePolicyName = Permissions.DCMPermissions.ServiceTypes.Delete;
    }
    
}
