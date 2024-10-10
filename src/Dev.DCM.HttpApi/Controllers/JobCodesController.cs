using System;
using System.Threading.Tasks;
using Asp.Versioning;
using Dev.DCM.Services.JobCodes;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp;
using Volo.Abp.Application.Dtos;

namespace Dev.DCM.Controllers;

[RemoteService]
[Area("app")]
[ControllerName("JobCodes")]
[Route("api/app/job-codes")]
public class JobCodesController(IJobCodeAppService jobCodeAppService) : DCMController
{
    [HttpGet]
    [ProducesResponseType(typeof(PagedResultDto<JobCodeDto>), 200)]
    public async Task<PagedResultDto<JobCodeDto>> GetListAsync(PagedAndSortedResultRequestDto  input)
    {
        return await jobCodeAppService.GetListAsync(input);
    }
    
    [HttpGet]
    [Route("{id:Guid}")]
    [ProducesResponseType<ProblemDetails>(400)]
    [ProducesResponseType(typeof(JobCodeDto), 200)]
    public async Task<JobCodeDto> GetAsync(Guid id)
    {
        return await jobCodeAppService.GetAsync(id);
    }
    
    [HttpPost]
    [ProducesResponseType(typeof(JobCodeDto), 201)]
    [ProducesResponseType(typeof(ProblemDetails), 400)]
    public async Task<JobCodeDto> CreateAsync(CreateUpdateJobCodeDto input)
    {
        return await jobCodeAppService.CreateAsync(input);
    }
    
    [HttpPut]
    [Route("{id:Guid}")]
    [ProducesResponseType(typeof(JobCodeDto), 200)]
    [ProducesResponseType(typeof(ProblemDetails), 400)]
    public async Task<JobCodeDto> UpdateAsync(Guid id, CreateUpdateJobCodeDto input)
    {
        return await jobCodeAppService.UpdateAsync(id, input);
    }
    
    [HttpDelete]
    [Route("{id:Guid}")]
    [ProducesResponseType(200)]
    [ProducesResponseType(typeof(ProblemDetails), 400)]
    public async Task DeleteAsync(Guid id)
    {
        await jobCodeAppService.DeleteAsync(id);
    }
}