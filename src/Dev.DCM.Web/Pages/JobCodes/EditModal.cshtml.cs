using System;
using System.Threading.Tasks;
using Dev.DCM.Services.JobCodes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Dev.DCM.Web.Pages.JobCodes;

public class EditModal : DCMPageModel
{
    [HiddenInput]
    [BindProperty(SupportsGet = true)]
    public Guid Id { get; set; }
    
    [BindProperty]
    public CreateUpdateJobCodeDto JobCode { get; set; }
    
    private readonly IJobCodeAppService _jobCodeAppService;

    public EditModal(IJobCodeAppService jobCodeAppService)
    {
        _jobCodeAppService = jobCodeAppService;
    }
    
    public async Task OnGetAsync()
    {
        var jobCodeDto = await _jobCodeAppService.GetAsync(Id);
        JobCode = ObjectMapper.Map<JobCodeDto, CreateUpdateJobCodeDto>(jobCodeDto);
    }
    
    public async Task<IActionResult> OnPostAsync()
    {
        await _jobCodeAppService.UpdateAsync(Id, JobCode);
        return NoContent();
    }
}