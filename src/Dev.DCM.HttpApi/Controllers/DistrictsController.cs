using System;
using System.Threading.Tasks;
using Asp.Versioning;
using Dev.DCM.Services.Districts;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp;
using Volo.Abp.Application.Dtos;

namespace Dev.DCM.Controllers;

[RemoteService]
[Area("app")]
[ControllerName("Districts")]
[Route("api/app/districts")]
public class DistrictsController(IDistrictAppService districtAppService) : DCMController
{
    [HttpGet]
    [ProducesResponseType(typeof(PagedResultDto<DistrictDto>), 200)]
    public async Task<PagedResultDto<DistrictDto>> GetListAsync(PagedAndSortedResultRequestDto input)
    {
        return await districtAppService.GetListAsync(input);
    }
    
    [HttpGet]
    [Route("{id:Guid}")]
    [ProducesResponseType<ProblemDetails>(400)]
    [ProducesResponseType(typeof(DistrictDto), 200)]
    public async Task<DistrictDto> GetAsync(Guid id)
    {
        return await districtAppService.GetAsync(id);
    }
    
    [HttpPost]
    [ProducesResponseType(typeof(DistrictDto), 201)]
    [ProducesResponseType(typeof(ProblemDetails), 400)]
    public async Task<DistrictDto> CreateAsync(CreateUpdateDistrictDto input)
    {
        return await districtAppService.CreateAsync(input);
    }
    
    [HttpPut]
    [Route("{id:Guid}")]
    [ProducesResponseType(typeof(DistrictDto), 200)]
    [ProducesResponseType(typeof(ProblemDetails), 400)]
    public async Task<DistrictDto> UpdateAsync(Guid id, CreateUpdateDistrictDto input)
    {
        return await districtAppService.UpdateAsync(id, input);
    }
    
    [HttpDelete]
    [Route("{id:Guid}")]
    [ProducesResponseType(200)]
    [ProducesResponseType(typeof(ProblemDetails), 400)]
    public async Task DeleteAsync(Guid id)
    {
        await districtAppService.DeleteAsync(id);
    }
}