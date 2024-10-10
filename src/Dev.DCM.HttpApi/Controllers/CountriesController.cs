using System;
using System.Threading.Tasks;
using Asp.Versioning;
using Dev.DCM.Services.Countries;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp;
using Volo.Abp.Application.Dtos;

namespace Dev.DCM.Controllers;

[RemoteService]
[Area("app")]
[ControllerName("Countries")]
[Route("api/app/countries")]
public class CountriesController(ICountryAppService countryAppService) : DCMController
{
    [HttpGet]
    [ProducesResponseType(typeof(PagedResultDto<CountryDto>), 200)]
    public async Task<PagedResultDto<CountryDto>> GetListAsync(PagedAndSortedResultRequestDto  input)
    {
        return await countryAppService.GetListAsync(input);
    }
    
    [HttpGet]
    [Route("{id:Guid}")]
    [ProducesResponseType<ProblemDetails>(400)]
    [ProducesResponseType(typeof(CountryDto), 200)]
    public async Task<CountryDto> GetAsync(Guid id)
    {
        return await countryAppService.GetAsync(id);
    }
    
    [HttpPost]
    [ProducesResponseType(typeof(CountryDto), 201)]
    [ProducesResponseType(typeof(ProblemDetails), 400)]
    public async Task<CountryDto> CreateAsync(CreateUpdateCountryDto input)
    {
        return await countryAppService.CreateAsync(input);
    }
    
    [HttpPut]
    [Route("{id:Guid}")]
    [ProducesResponseType(typeof(CountryDto), 200)]
    [ProducesResponseType(typeof(ProblemDetails), 400)]
    public async Task<CountryDto> UpdateAsync(Guid id, CreateUpdateCountryDto input)
    {
        return await countryAppService.UpdateAsync(id, input);
    }
    
    [HttpDelete]
    [Route("{id:Guid}")]
    [ProducesResponseType(200)]
    [ProducesResponseType(typeof(ProblemDetails), 400)]
    public async Task DeleteAsync(Guid id)
    {
        await countryAppService.DeleteAsync(id);
    }
}