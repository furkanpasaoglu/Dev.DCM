using System;
using System.Threading.Tasks;
using Asp.Versioning;
using Dev.DCM.Services.TenantDetails;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp;
using Volo.Abp.Application.Dtos;

namespace Dev.DCM.Controllers;

[RemoteService]
[Area("app")]
[ControllerName("TenantDetails")]
[Route("api/app/tenant-details")]
public class TenantDetailsController(ITenantDetailAppService tenantDetailAppService) : DCMController
{
    [HttpGet]
    [ProducesResponseType(typeof(PagedResultDto<TenantDetailDto>), 200)]
    public async Task<PagedResultDto<TenantDetailDto>> GetListAsync(PagedAndSortedResultRequestDto  input)
    {
        return await tenantDetailAppService.GetListAsync(input);
    }
    
    [HttpGet]
    [Route("{id:Guid}")]
    [ProducesResponseType<ProblemDetails>(400)]
    [ProducesResponseType(typeof(TenantDetailDto), 200)]
    public async Task<TenantDetailDto> GetAsync(Guid id)
    {
        return await tenantDetailAppService.GetAsync(id);
    }
    
    [HttpPost]
    [ProducesResponseType(typeof(TenantDetailDto), 201)]
    [ProducesResponseType(typeof(ProblemDetails), 400)]
    public async Task<TenantDetailDto> CreateAsync(CreateUpdateTenantDetailDto input)
    {
        return await tenantDetailAppService.CreateAsync(input);
    }
    
    [HttpPut]
    [Route("{id:Guid}")]
    [ProducesResponseType(typeof(TenantDetailDto), 200)]
    [ProducesResponseType(typeof(ProblemDetails), 400)]
    public async Task<TenantDetailDto> UpdateAsync(Guid id, CreateUpdateTenantDetailDto input)
    {
        return await tenantDetailAppService.UpdateAsync(id, input);
    }
    
    [HttpDelete]
    [Route("{id:Guid}")]
    [ProducesResponseType(200)]
    [ProducesResponseType(typeof(ProblemDetails), 400)]
    public async Task DeleteAsync(Guid id)
    {
        await tenantDetailAppService.DeleteAsync(id);
    }
}