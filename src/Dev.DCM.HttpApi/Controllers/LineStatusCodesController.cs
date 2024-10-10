using System;
using System.Threading.Tasks;
using Asp.Versioning;
using Dev.DCM.Services.LineStatusCodes;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp;
using Volo.Abp.Application.Dtos;

namespace Dev.DCM.Controllers;

[RemoteService]
[Area("app")]
[ControllerName("LineStatusCodes")]
[Route("api/app/line-status-codes")]
public class LineStatusCodesController(ILineStatusCodeAppService lineStatusCodeAppService) : DCMController
{
    [HttpGet]
    [ProducesResponseType(typeof(PagedResultDto<LineStatusCodeDto>), 200)]
    public async Task<PagedResultDto<LineStatusCodeDto>> GetListAsync(PagedAndSortedResultRequestDto  input)
    {
        return await lineStatusCodeAppService.GetListAsync(input);
    }
    
    [HttpGet]
    [Route("{id:Guid}")]
    [ProducesResponseType<ProblemDetails>(400)]
    [ProducesResponseType(typeof(LineStatusCodeDto), 200)]
    public async Task<LineStatusCodeDto> GetAsync(Guid id)
    {
        return await lineStatusCodeAppService.GetAsync(id);
    }
    
    [HttpPost]
    [ProducesResponseType(typeof(LineStatusCodeDto), 201)]
    [ProducesResponseType(typeof(ProblemDetails), 400)]
    public async Task<LineStatusCodeDto> CreateAsync(CreateUpdateLineStatusCodeDto input)
    {
        return await lineStatusCodeAppService.CreateAsync(input);
    }
    
    [HttpPut]
    [Route("{id:Guid}")]
    [ProducesResponseType(typeof(LineStatusCodeDto), 200)]
    [ProducesResponseType(typeof(ProblemDetails), 400)]
    public async Task<LineStatusCodeDto> UpdateAsync(Guid id, CreateUpdateLineStatusCodeDto input)
    {
        return await lineStatusCodeAppService.UpdateAsync(id, input);
    }
    
    [HttpDelete]
    [Route("{id:Guid}")]
    [ProducesResponseType(200)]
    [ProducesResponseType(typeof(ProblemDetails), 400)]
    public async Task DeleteAsync(Guid id)
    {
        await lineStatusCodeAppService.DeleteAsync(id);
    }
}