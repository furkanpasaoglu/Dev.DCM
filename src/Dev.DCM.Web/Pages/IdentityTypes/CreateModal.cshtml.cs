using System.Threading.Tasks;
using Dev.DCM.Services.IdentityTypes;
using Microsoft.AspNetCore.Mvc;

namespace Dev.DCM.Web.Pages.IdentityTypes;

public class CreateModal(IIdentityTypeAppService identityTypeAppService) : DCMPageModel
{
    [BindProperty]
    public CreateUpdateIdentityTypeDto IdentityType { get; set; }

    public void OnGet()
    {
        IdentityType = new CreateUpdateIdentityTypeDto();
    }

    public async Task<IActionResult> OnPostAsync()
    {
        await identityTypeAppService.CreateAsync(IdentityType);
        return NoContent();
    }
   
}