using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Dev.DCM.Services.Cities;
using Dev.DCM.Services.Countries;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Volo.Abp.Application.Dtos;
using Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Form;

namespace Dev.DCM.Web.Pages.Cities;

public class CreateModal(ICityAppService cityAppService, ICountryAppService countryAppService): DCMPageModel
{
    [BindProperty]
    public CityCreateDetailModel CreateUpdateCity { get; set; }
    public List<SelectListItem> Countries { get; set; } 

    public async Task OnGet()
    {
        CreateUpdateCity = new CityCreateDetailModel();
        var countries = await countryAppService.GetListAsync(new PagedAndSortedResultRequestDto());
        Countries = countries.Items
            .Select(c => new SelectListItem(c.Name, c.Id.ToString()))
            .ToList();
        Countries.Insert(0, new SelectListItem { Value = "", Text = L["Select"] });
    }

    public async Task<IActionResult> OnPostAsync()
    {
        await cityAppService.CreateAsync(new CreateUpdateCityDto
        {
            Code = CreateUpdateCity.Code,
            Name = CreateUpdateCity.Name,
            CountryId = CreateUpdateCity.CountryId
        });
        return NoContent();
    }
    
    public class CityCreateDetailModel
    {
        [Required(ErrorMessage = "CityNameIsRequired")]
        [Placeholder("CityNamePlaceholder")]
        [DisplayOrder(1)]
        public string Name { get; set; }
        
        [DisplayOrder(2)]
        public string? Code { get; set; }
        
        [Required(ErrorMessage = "CountryIsRequired")]
        [SelectItems(nameof(Countries))]
        [Display(Name = "Country")]
        [DisplayOrder(3)]
        public Guid CountryId { get; set; }

    }
}