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

public class CreateModal(IDistrictAppService districtAppService, ICityAppService cityAppService) : DCMPageModel
{
    [BindProperty]
    public CreateDistrictDetailModel CreateUpdateDistrict { get; set; }
    public List<SelectListItem> Cities { get; set; } 

    public async Task OnGet()
    {
        CreateUpdateDistrict = new CreateDistrictDetailModel();
        var cities = await cityAppService.GetListAsync(new PagedAndSortedResultRequestDto());
        //İlk değeri default Seçiniz olacak şekilde ekliyoruz.
        Cities = cities.Items
            .Select(c => new SelectListItem(c.Name, c.Id.ToString()))
            .ToList();
        Cities.Insert(0, new SelectListItem { Value = "", Text = L["Select"] });
    }

    public async Task<IActionResult> OnPostAsync()
    {
        await districtAppService.CreateAsync(new CreateUpdateDistrictDto
        {
            Code = CreateUpdateDistrict.Code,
            Name = CreateUpdateDistrict.Name,
            CityId = CreateUpdateDistrict.CityId
        });
        return NoContent();
    }
    
    public class CreateDistrictDetailModel
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