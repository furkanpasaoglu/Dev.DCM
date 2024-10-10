using System;
using System.Threading.Tasks;
using Dev.DCM.Services.ServiceTypes;
using Microsoft.AspNetCore.Mvc;

namespace Dev.DCM.Web.Pages.ServiceTypes;

public class EditModal : DCMPageModel
{
    [HiddenInput]
    [BindProperty(SupportsGet = true)]
    public Guid Id { get; set; }
    
    [BindProperty]
    public CreateUpdateServiceTypeDto ServiceType { get; set; }
    
    private readonly IServiceTypeAppService _serviceTypeAppService;

    public EditModal(IServiceTypeAppService serviceTypeAppService)
    {
        _serviceTypeAppService = serviceTypeAppService;
    }


    public async Task OnGetAsync()
    {
        var serviceTypeDto = await _serviceTypeAppService.GetAsync(Id);
        ServiceType = ObjectMapper.Map<ServiceTypeDto, CreateUpdateServiceTypeDto>(serviceTypeDto);
    }
    
    public async Task<IActionResult> OnPostAsync()
    {
        await _serviceTypeAppService.UpdateAsync(Id, ServiceType);
        return NoContent();
    }
}