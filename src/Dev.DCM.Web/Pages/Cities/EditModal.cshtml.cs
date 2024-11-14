using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Dev.DCM.Services.Cities;
using Dev.DCM.Services.Countries;
using Dev.DCM.Web.Extensions;
using Dev.DCM.Web.ViewModels.Cities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Localization;
using Volo.Abp.Application.Dtos;
using Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Form;
using Volo.Abp.Localization;

namespace Dev.DCM.Web.Pages.Cities;

public class EditModal(ICityAppService cityAppService, ICountryAppService countryAppService)  : DCMPageModel
{
    [BindProperty(SupportsGet = true)]
    public CityEditViewModel CityEditViewModel { get; set; } = new();

    public async Task OnGetAsync()
    {
        if (CityEditViewModel.Id.HasValue)
        {
            // Update işlemi: Şehri Id'ye göre al
            var createUpdateCityDto = await cityAppService.GetAsync(CityEditViewModel.Id.Value);

            CityEditViewModel = new CityEditViewModel
            {
                Id = createUpdateCityDto.Id,
                Name = createUpdateCityDto.Name,
                Code = createUpdateCityDto.Code ?? string.Empty,
                CountryId = createUpdateCityDto.CountryId
            };
        }
       
        var countries = await countryAppService.GetListAsync(new PagedAndSortedResultRequestDto());
        CityEditViewModel.Countries = countries.Items
            .Select(c => new SelectListItem(c.Name, c.Id.ToString()))
            .ToList();
        CityEditViewModel.Countries.AddSelectOption(L["Select"]);
    }
    
    public async Task<IActionResult> OnPostAsync()
    {
        if (CityEditViewModel.Id.HasValue)
        {
            // Update işlemi: Şehir verisini güncelliyoruz
            await cityAppService.UpdateAsync(CityEditViewModel.Id.Value, new CreateUpdateCityDto
            {
                Name = CityEditViewModel.Name,
                Code = CityEditViewModel.Code,
                CountryId = CityEditViewModel.CountryId
            });
        }
        return NoContent();
    }
}