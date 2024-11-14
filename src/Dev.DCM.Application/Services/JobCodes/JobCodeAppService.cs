using Dev.DCM.Entities.JobCodes;
using System;
using System.Threading.Tasks;
using Volo.Abp;
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
        GetPolicyName = Permissions.DCMPermissions.Types.JobCodes.Default;
        GetListPolicyName = Permissions.DCMPermissions.Types.JobCodes.Default;
        CreatePolicyName = Permissions.DCMPermissions.Types.JobCodes.Create;
        UpdatePolicyName = Permissions.DCMPermissions.Types.JobCodes.Edit;
        DeletePolicyName = Permissions.DCMPermissions.Types.JobCodes.Delete;
    }

    public override async Task<JobCodeDto> CreateAsync(CreateUpdateJobCodeDto input)
    {
        await IsJobCodeExists(input.No, input.Code);
        return await base.CreateAsync(input);
    }
    
    #region Validation

    private async Task IsJobCodeExists(int no, string? code)
    {
        var existing = await Repository.AnyAsync(c => c.No == no || c.Code == code);
        if (existing)
        {
            throw new UserFriendlyException(message: L["AlreadyExists"]);
        }
    }

    #endregion
}