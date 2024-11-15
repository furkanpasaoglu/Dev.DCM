using Dev.DCM.Entities.JobCodes;
using System;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Dev.DCM.Services.JobCodes;

public class JobCodeAppService(IRepository<JobCode, Guid> repository, JobCodeAppValidationService jobCodeAppValidationService) :
    CrudAppService<
        JobCode,
        JobCodeDto,
        Guid,
        PagedAndSortedResultRequestDto,
        CreateUpdateJobCodeDto>(repository),
    IJobCodeAppService
{
    protected override string? GetPolicyName { get; set; } = Permissions.DCMPermissions.Types.JobCodes.Default;
    protected override string? GetListPolicyName { get; set; } = Permissions.DCMPermissions.Types.JobCodes.Default;
    protected override string? CreatePolicyName { get; set; } = Permissions.DCMPermissions.Types.JobCodes.Create;
    protected override string? UpdatePolicyName { get; set; } = Permissions.DCMPermissions.Types.JobCodes.Edit;
    protected override string? DeletePolicyName { get; set; } = Permissions.DCMPermissions.Types.JobCodes.Delete;

    public override async Task<JobCodeDto> CreateAsync(CreateUpdateJobCodeDto input)
    {
        await ValidateDtoAsync(input.No, input.Code);
        return await base.CreateAsync(input);
    }

    public override async Task<JobCodeDto> UpdateAsync(Guid id, CreateUpdateJobCodeDto input)
    {
        await ValidateDtoAsync(input.No, input.Code);
        return await base.UpdateAsync(id, input);
    }


    private async Task ValidateDtoAsync(int no, string? code)
    {
       await jobCodeAppValidationService.IsJobCodeExists(no, code);
    }


}