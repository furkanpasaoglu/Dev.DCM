using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Dev.DCM.Services.Cities;
using Dev.DCM.Services.Districts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Volo.Abp.Application.Dtos;
using Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Form;

namespace Dev.DCM.Web.Pages.Districts;

public class EditModal : DCMPageModel
{
    [HiddenInput]
    [BindProperty(SupportsGet = true)]
    public Guid Id { get; set; }
    
    [BindProperty]
    public EditDistrictDetailModel CreateUpdateDistrict { get; set; }
    
    public List<SelectListItem> Cities { get; set; } 
    
    private readonly IDistrictAppService _districtAppService;
    private readonly ICityAppService _cityAppService;

    public EditModal(IDistrictAppService districtAppService, ICityAppService cityAppService)
    {
        _districtAppService = districtAppService;
        _cityAppService = cityAppService;
    }
    
    public async Task OnGetAsync()
    {
        var createUpdateDistrictDto = await _districtAppService.GetAsync(Id);
        CreateUpdateDistrict = new EditDistrictDetailModel
        {
            Name = createUpdateDistrictDto.Name,
            Code = createUpdateDistrictDto.Code ?? string.Empty,
            CityId = createUpdateDistrictDto.CityId
        };
        var cities = await _cityAppService.GetListAsync(new PagedAndSortedResultRequestDto());
        Cities = cities.Items
            .Select(c => new SelectListItem(c.Name, c.Id.ToString()))
            .ToList();
        Cities.Insert(0, new SelectListItem { Value = "", Text = L["Select"] });
    }
    
    public async Task<IActionResult> OnPostAsync()
    {
        await _districtAppService.UpdateAsync(Id, new CreateUpdateDistrictDto
        {
            Name = CreateUpdateDistrict.Name,
            Code = CreateUpdateDistrict.Code,
            CityId = CreateUpdateDistrict.CityId
        });
        return NoContent();
    }
    
    public class EditDistrictDetailModel
    {
        [Required(ErrorMessage = "DistrictNameIsRequired")]
        [Placeholder("DistrictNamePlaceholder")]
        [DisplayOrder(1)]
        public string Name { get; set; }
        
        [DisplayOrder(2)]
        public string? Code { get; set; }
        
        [Required(ErrorMessage = "CityIsRequired")]
        [Display(Name = "City")]
        [SelectItems(nameof(Cities))]
        [DisplayOrder(3)]
        public Guid CityId { get; set; }
        
    }
}