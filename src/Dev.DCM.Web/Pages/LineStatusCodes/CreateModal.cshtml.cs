using System.Threading.Tasks;
using Dev.DCM.Services.LineStatusCodes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Dev.DCM.Web.Pages.LineStatusCodes;

public class CreateModal(ILineStatusCodeAppService lineStatusCodeAppService) : DCMPageModel
{
    [BindProperty]
    public CreateUpdateLineStatusCodeDto LineStatusCode { get; set; }

    public void OnGet()
    {
        LineStatusCode = new CreateUpdateLineStatusCodeDto();
    }

    public async Task<IActionResult> OnPostAsync()
    {
        await lineStatusCodeAppService.CreateAsync(LineStatusCode);
        return NoContent();
    }
}