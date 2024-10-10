using System;
using System.Threading.Tasks;
using Asp.Versioning;
using Dev.DCM.Services.Cities;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp;
using Volo.Abp.Application.Dtos;

namespace Dev.DCM.Controllers;

[RemoteService]
[Area("app")]
[ControllerName("Cities")]
[Route("api/app/cities")]
public class CitiesController(ICityAppService cityAppService) : DCMController
{
    [HttpGet]
    [ProducesResponseType(typeof(PagedResultDto<CityDto>), 200)]
    public async Task<PagedResultDto<CityDto>> GetListAsync(PagedAndSortedResultRequestDto  input)
    {
        return await cityAppService.GetListAsync(input);
    }
    
    [HttpGet]
    [Route("{id:Guid}")]
    [ProducesResponseType<ProblemDetails>(400)]
    [ProducesResponseType(typeof(CityDto), 200)]
    public async Task<CityDto> GetAsync(Guid id)
    {
        return await cityAppService.GetAsync(id);
    }
    
    [HttpPost]
    [ProducesResponseType(typeof(CityDto), 201)]
    [ProducesResponseType(typeof(ProblemDetails), 400)]
    public async Task<CityDto> CreateAsync(CreateUpdateCityDto input)
    {
        return await cityAppService.CreateAsync(input);
    }
    
    [HttpPut]
    [Route("{id:Guid}")]
    [ProducesResponseType(typeof(CityDto), 200)]
    [ProducesResponseType(typeof(ProblemDetails), 400)]
    public async Task<CityDto> UpdateAsync(Guid id, CreateUpdateCityDto input)
    {
        return await cityAppService.UpdateAsync(id, input);
    }
    
    [HttpDelete]
    [Route("{id:Guid}")]
    [ProducesResponseType(200)]
    [ProducesResponseType(typeof(ProblemDetails), 400)]
    public async Task DeleteAsync(Guid id)
    {
        await cityAppService.DeleteAsync(id);
    }
}