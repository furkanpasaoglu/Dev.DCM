using System.Linq;
using System.Threading.Tasks;
using Dev.DCM.Services.Cities;
using Dev.DCM.Services.Countries;
using Dev.DCM.Web.Extensions;
using Dev.DCM.Web.ViewModels.Cities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Volo.Abp.Application.Dtos;

namespace Dev.DCM.Web.Pages.Cities;

public class CreateModal(ICityAppService cityAppService, ICountryAppService countryAppService): DCMPageModel
{
    [BindProperty]
    public CityEditViewModel CityEditViewModel { get; set; } = new();

    public async Task OnGet()
    {
        var countries = await countryAppService.GetListAsync(new PagedAndSortedResultRequestDto());
        CityEditViewModel.Countries = countries.Items
            .Select(c => new SelectListItem(c.Name, c.Id.ToString()))
            .ToList();
        CityEditViewModel.Countries.AddSelectOption(L["Select"]);
    }

    public async Task<IActionResult> OnPostAsync()
    {
        await cityAppService.CreateAsync(new CreateUpdateCityDto
        {
            Code = CityEditViewModel.Code,
            Name = CityEditViewModel.Name,
            CountryId = CityEditViewModel.CountryId
        });
        return NoContent();
    }
}