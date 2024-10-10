using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Dev.DCM.Services.Cities;
using Dev.DCM.Services.Countries;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Localization;
using Volo.Abp.Application.Dtos;
using Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Form;
using Volo.Abp.Localization;

namespace Dev.DCM.Web.Pages.Cities;

public class EditModal : DCMPageModel
{
    [BindProperty]
    public CityEditDetailModel CreateUpdateCity { get; set; }
    
    [HiddenInput]
    [BindProperty(SupportsGet = true)]
    public Guid Id { get; set; }
    
    public List<SelectListItem> Countries { get; set; } 
    
    private readonly ICityAppService _cityAppService;
    private readonly ICountryAppService _countryAppService;

    public EditModal(ICityAppService cityAppService, ICountryAppService countryAppService)
    {
        _cityAppService = cityAppService;
        _countryAppService = countryAppService;
    }
    
    public async Task OnGetAsync()
    {
        var createUpdateCityDto = await _cityAppService.GetAsync(Id);

        CreateUpdateCity = new CityEditDetailModel
        {
            Name = createUpdateCityDto.Name,
            Code = createUpdateCityDto.Code ?? string.Empty,
            CountryId = createUpdateCityDto.CountryId
        };
        var countries = await _countryAppService.GetListAsync(new PagedAndSortedResultRequestDto());
        Countries = countries.Items
            .Select(c => new SelectListItem(c.Name, c.Id.ToString()))
            .ToList();
    }
    
    public async Task<IActionResult> OnPostAsync()
    {
        await _cityAppService.UpdateAsync(Id, new CreateUpdateCityDto
        {
            Name = CreateUpdateCity.Name,
            Code = CreateUpdateCity.Code,
            CountryId = CreateUpdateCity.CountryId
        });
        return NoContent();
    }
    
    public class CityEditDetailModel
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