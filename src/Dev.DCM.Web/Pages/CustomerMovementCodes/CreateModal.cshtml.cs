using System.Threading.Tasks;
using Dev.DCM.Services.CustomerMovementCodes;
using Microsoft.AspNetCore.Mvc;

namespace Dev.DCM.Web.Pages.CustomerMovementCodes;

public class CreateModal(ICustomerMovementCodeAppService customerMovementCodeAppService) : DCMPageModel
{
    [BindProperty]
    public CreateUpdateCustomerMovementCodeDto CreateUpdateCustomerMovementCode { get; set; }

    public void OnGet()
    {
        CreateUpdateCustomerMovementCode = new CreateUpdateCustomerMovementCodeDto();
    }

    public async Task<IActionResult> OnPostAsync()
    {
        await customerMovementCodeAppService.CreateAsync(CreateUpdateCustomerMovementCode);
        return NoContent();
    }
}