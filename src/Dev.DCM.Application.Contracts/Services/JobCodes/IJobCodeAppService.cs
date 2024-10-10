using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Dev.DCM.Services.JobCodes;

public interface IJobCodeAppService :
    ICrudAppService<
        JobCodeDto,
        Guid,
        PagedAndSortedResultRequestDto,
        CreateUpdateJobCodeDto>
{
    
}