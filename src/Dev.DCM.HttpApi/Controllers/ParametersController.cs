using System;
using System.Threading.Tasks;
using Asp.Versioning;
using Dev.DCM.Services.Parameters;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp;
using Volo.Abp.Application.Dtos;

namespace Dev.DCM.Controllers;

[RemoteService]
[Area("app")]
[ControllerName("Parameters")]
[Route("api/app/parameters")]
public class ParametersController (IParameterAppService parameterAppService): DCMController
{
    [HttpGet]
    [ProducesResponseType(typeof(PagedResultDto<ParameterDto>), 200)]
    public async Task<PagedResultDto<ParameterDto>> GetListAsync(PagedAndSortedResultRequestDto input)
    {
        return await parameterAppService.GetListAsync(input);
    }
    
    [HttpGet]
    [Route("{id:Guid}")]
    [ProducesResponseType<ProblemDetails>(400)]
    [ProducesResponseType(typeof(ParameterDto), 200)]
    public async Task<ParameterDto> GetAsync(Guid id)
    {
        return await parameterAppService.GetAsync(id);
    }
    
    [HttpPost]
    [ProducesResponseType(typeof(ParameterDto), 201)]
    [ProducesResponseType(typeof(ProblemDetails), 400)]
    public async Task<ParameterDto> CreateAsync(CreateUpdateParameterDto input)
    {
        return await parameterAppService.CreateAsync(input);
    }
    
    [HttpPut]
    [Route("{id:Guid}")]
    [ProducesResponseType(typeof(ParameterDto), 200)]
    [ProducesResponseType(typeof(ProblemDetails), 400)]
    public async Task<ParameterDto> UpdateAsync(Guid id, CreateUpdateParameterDto input)
    {
        return await parameterAppService.UpdateAsync(id, input);
    }
    
    [HttpDelete]
    [Route("{id:Guid}")]
    [ProducesResponseType(200)]
    [ProducesResponseType(typeof(ProblemDetails), 400)]
    public async Task DeleteAsync(Guid id)
    {
        await parameterAppService.DeleteAsync(id);
    }
}