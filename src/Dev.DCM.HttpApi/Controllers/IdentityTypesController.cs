using System;
using System.Threading.Tasks;
using Asp.Versioning;
using Dev.DCM.Services.IdentityTypes;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp;
using Volo.Abp.Application.Dtos;

namespace Dev.DCM.Controllers;

[RemoteService]
[Area("app")]
[ControllerName("IdentityTypes")]
[Route("api/app/identity-types")]
public class IdentityTypesController(IIdentityTypeAppService identityTypeAppService) : DCMController
{
    [HttpGet]
    [ProducesResponseType(typeof(PagedResultDto<IdentityTypeDto>), 200)]
    public async Task<PagedResultDto<IdentityTypeDto>> GetListAsync(PagedAndSortedResultRequestDto  input)
    {
        return await identityTypeAppService.GetListAsync(input);
    }
    
    [HttpGet]
    [Route("{id:Guid}")]
    [ProducesResponseType<ProblemDetails>(400)]
    [ProducesResponseType(typeof(IdentityTypeDto), 200)]
    public async Task<IdentityTypeDto> GetAsync(Guid id)
    {
        return await identityTypeAppService.GetAsync(id);
    }
    
    [HttpPost]
    [ProducesResponseType(typeof(IdentityTypeDto), 201)]
    [ProducesResponseType(typeof(ProblemDetails), 400)]
    public async Task<IdentityTypeDto> CreateAsync(CreateUpdateIdentityTypeDto input)
    {
        return await identityTypeAppService.CreateAsync(input);
    }
    
    [HttpPut]
    [Route("{id:Guid}")]
    [ProducesResponseType(typeof(IdentityTypeDto), 200)]
    [ProducesResponseType(typeof(ProblemDetails), 400)]
    public async Task<IdentityTypeDto> UpdateAsync(Guid id, CreateUpdateIdentityTypeDto input)
    {
        return await identityTypeAppService.UpdateAsync(id, input);
    }
    
    [HttpDelete]
    [Route("{id:Guid}")]
    [ProducesResponseType(200)]
    [ProducesResponseType(typeof(ProblemDetails), 400)]
    public async Task DeleteAsync(Guid id)
    {
        await identityTypeAppService.DeleteAsync(id);
    }
}