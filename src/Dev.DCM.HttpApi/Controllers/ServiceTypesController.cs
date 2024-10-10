using System;
using System.Threading.Tasks;
using Asp.Versioning;
using Dev.DCM.Services.ServiceTypes;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp;
using Volo.Abp.Application.Dtos;

namespace Dev.DCM.Controllers;

[RemoteService]
[Area("app")]
[ControllerName("ServiceTypes")]
[Route("api/app/service-types")]
public class ServiceTypesController(IServiceTypeAppService serviceTypeAppService) : DCMController
{
    [HttpGet]
    [ProducesResponseType(typeof(PagedResultDto<ServiceTypeDto>), 200)]
    public async Task<PagedResultDto<ServiceTypeDto>> GetListAsync(PagedAndSortedResultRequestDto  input)
    {
        return await serviceTypeAppService.GetListAsync(input);
    }
    
    [HttpGet]
    [Route("{id:Guid}")]
    [ProducesResponseType<ProblemDetails>(400)]
    [ProducesResponseType(typeof(ServiceTypeDto), 200)]
    public async Task<ServiceTypeDto> GetAsync(Guid id)
    {
        return await serviceTypeAppService.GetAsync(id);
    }
    
    [HttpPost]
    [ProducesResponseType(typeof(ServiceTypeDto), 201)]
    [ProducesResponseType(typeof(ProblemDetails), 400)]
    public async Task<ServiceTypeDto> CreateAsync(CreateUpdateServiceTypeDto input)
    {
        return await serviceTypeAppService.CreateAsync(input);
    }
    
    [HttpPut]
    [Route("{id:Guid}")]
    [ProducesResponseType(typeof(ServiceTypeDto), 200)]
    [ProducesResponseType(typeof(ProblemDetails), 400)]
    public async Task<ServiceTypeDto> UpdateAsync(Guid id, CreateUpdateServiceTypeDto input)
    {
        return await serviceTypeAppService.UpdateAsync(id, input);
    }
    
    [HttpDelete]
    [Route("{id:Guid}")]
    [ProducesResponseType(200)]
    [ProducesResponseType(typeof(ProblemDetails), 400)]
    public async Task DeleteAsync(Guid id)
    {
        await serviceTypeAppService.DeleteAsync(id);
    }
}