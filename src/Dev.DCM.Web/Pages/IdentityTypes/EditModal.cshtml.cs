using System;
using System.Threading.Tasks;
using Dev.DCM.Services.IdentityTypes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Dev.DCM.Web.Pages.IdentityTypes;

public class EditModal : DCMPageModel
{
    [HiddenInput]
    [BindProperty(SupportsGet = true)]
    public Guid Id { get; set; }
    
    [BindProperty]
    public CreateUpdateIdentityTypeDto IdentityType { get; set; }
    
    private readonly IIdentityTypeAppService _identityTypeAppService;

    public EditModal(IIdentityTypeAppService identityTypeAppService)
    {
        _identityTypeAppService = identityTypeAppService;
    }
    
    public async Task OnGetAsync()
    {
        var identityTypeDto = await _identityTypeAppService.GetAsync(Id);
        IdentityType = ObjectMapper.Map<IdentityTypeDto, CreateUpdateIdentityTypeDto>(identityTypeDto);
    }
    
    public async Task<IActionResult> OnPostAsync()
    {
        await _identityTypeAppService.UpdateAsync(Id, IdentityType);
        return NoContent();
    }
   
}