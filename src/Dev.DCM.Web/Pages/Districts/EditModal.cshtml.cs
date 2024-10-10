using System;
using System.Threading.Tasks;
using Dev.DCM.Services.Districts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Dev.DCM.Web.Pages.Districts;

public class EditModal : DCMPageModel
{
    [HiddenInput]
    [BindProperty(SupportsGet = true)]
    public Guid Id { get; set; }
    
    [BindProperty]
    public CreateUpdateDistrictDto CreateUpdateDistrict { get; set; }
    
    private readonly IDistrictAppService _districtAppService;

    public EditModal(IDistrictAppService districtAppService)
    {
        _districtAppService = districtAppService;
    }
    
    public async Task OnGetAsync()
    {
        var createUpdateDistrictDto = await _districtAppService.GetAsync(Id);
        CreateUpdateDistrict = ObjectMapper.Map<DistrictDto, CreateUpdateDistrictDto>(createUpdateDistrictDto);
    }
    
    public async Task<IActionResult> OnPostAsync()
    {
        await _districtAppService.UpdateAsync(Id, CreateUpdateDistrict);
        return NoContent();
    }
}