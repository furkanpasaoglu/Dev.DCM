using System.Threading.Tasks;
using Dev.DCM.Services.ServiceTypes;
using Microsoft.AspNetCore.Mvc;

namespace Dev.DCM.Web.Pages.ServiceTypes;

public class CreateModal(IServiceTypeAppService serviceTypeAppService) : DCMPageModel
{
    [BindProperty]
    public CreateUpdateServiceTypeDto ServiceType { get; set; }

    public void OnGet()
    {
        ServiceType = new CreateUpdateServiceTypeDto();
    }

    public async Task<IActionResult> OnPostAsync()
    {
        await serviceTypeAppService.CreateAsync(ServiceType);
        return NoContent();
    }
}