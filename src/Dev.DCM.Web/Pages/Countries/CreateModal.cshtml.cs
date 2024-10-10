
using System.Threading.Tasks;
using Dev.DCM.Services.Countries;
using Microsoft.AspNetCore.Mvc;

namespace Dev.DCM.Web.Pages.Countries;

public class CreateModal(ICountryAppService countryAppService) : DCMPageModel
{
    [BindProperty]
    public CreateUpdateCountryDto CreateUpdateCountry { get; set; }

    public void OnGet()
    {
        CreateUpdateCountry = new CreateUpdateCountryDto();
    }

    public async Task<IActionResult> OnPostAsync()
    {
        await countryAppService.CreateAsync(CreateUpdateCountry);
        return NoContent();
    }
}