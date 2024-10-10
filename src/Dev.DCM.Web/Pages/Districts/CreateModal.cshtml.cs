using System.Threading.Tasks;
using Dev.DCM.Services.Districts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Dev.DCM.Web.Pages.Districts;

public class CreateModal(IDistrictAppService districtAppService) : DCMPageModel
{
    [BindProperty]
    public CreateUpdateDistrictDto CreateUpdateDistrict { get; set; }

    public void OnGet()
    {
        CreateUpdateDistrict = new CreateUpdateDistrictDto();
    }

    public async Task<IActionResult> OnPostAsync()
    {
        await districtAppService.CreateAsync(CreateUpdateDistrict);
        return NoContent();
    }
}