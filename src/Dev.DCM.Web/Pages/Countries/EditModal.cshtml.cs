using System;
using System.Threading.Tasks;
using Dev.DCM.Services.Countries;
using Microsoft.AspNetCore.Mvc;

namespace Dev.DCM.Web.Pages.Countries;

public class EditModal : DCMPageModel
{
    [HiddenInput]
    [BindProperty(SupportsGet = true)]
    public Guid Id { get; set; }
    
    [BindProperty]
    public CreateUpdateCountryDto CreateUpdateCountry { get; set; }
    
    private readonly ICountryAppService _countryAppService;

    public EditModal(ICountryAppService countryAppService)
    {
        _countryAppService = countryAppService;
    }
    
    public async Task OnGetAsync()
    {
        var createUpdateCountryDto = await _countryAppService.GetAsync(Id);
        CreateUpdateCountry = ObjectMapper.Map<CountryDto, CreateUpdateCountryDto>(createUpdateCountryDto);
    }
    
    public async Task<IActionResult> OnPostAsync()
    {
        await _countryAppService.UpdateAsync(Id, CreateUpdateCountry);
        return NoContent();
    }
    
}