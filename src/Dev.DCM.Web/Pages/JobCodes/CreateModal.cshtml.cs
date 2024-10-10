using System.Threading.Tasks;
using Dev.DCM.Services.JobCodes;
using Microsoft.AspNetCore.Mvc;

namespace Dev.DCM.Web.Pages.JobCodes;

public class CreateModal(IJobCodeAppService jobCodeAppService) : DCMPageModel
{
    [BindProperty]
    public CreateUpdateJobCodeDto JobCode { get; set; }

    public void OnGet()
    {
        JobCode = new CreateUpdateJobCodeDto();
    }

    public async Task<IActionResult> OnPostAsync()
    {
        await jobCodeAppService.CreateAsync(JobCode);
        return NoContent();
    }
}