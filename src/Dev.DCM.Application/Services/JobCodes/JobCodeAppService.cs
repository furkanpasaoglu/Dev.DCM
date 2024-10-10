using Dev.DCM.Entities.JobCodes;
using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Dev.DCM.Services.JobCodes;

public class JobCodeAppService :
    CrudAppService<
        JobCode,
        JobCodeDto,
        Guid,
        PagedAndSortedResultRequestDto,
        CreateUpdateJobCodeDto>,
    IJobCodeAppService
{
    public JobCodeAppService(IRepository<JobCode, Guid> repository) : base(repository)
    {
        GetPolicyName = Permissions.DCMPermissions.JobCodes.Default;
        GetListPolicyName = Permissions.DCMPermissions.JobCodes.Default;
        CreatePolicyName = Permissions.DCMPermissions.JobCodes.Create;
        UpdatePolicyName = Permissions.DCMPermissions.JobCodes.Edit;
        DeletePolicyName = Permissions.DCMPermissions.JobCodes.Delete;
    }
}