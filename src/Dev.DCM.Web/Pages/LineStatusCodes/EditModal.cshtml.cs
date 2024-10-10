using System;
using System.Threading.Tasks;
using Dev.DCM.Services.LineStatusCodes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Dev.DCM.Web.Pages.LineStatusCodes;

public class EditModal : DCMPageModel
{
    [HiddenInput]
    [BindProperty(SupportsGet = true)]
    public Guid Id { get; set; }
    
    [BindProperty]
    public CreateUpdateLineStatusCodeDto LineStatusCode { get; set; }
    
    private readonly ILineStatusCodeAppService _lineStatusCodeAppService;

    public EditModal(ILineStatusCodeAppService lineStatusCodeAppService)
    {
        _lineStatusCodeAppService = lineStatusCodeAppService;
    }
    
    public async Task OnGetAsync()
    {
        var lineStatusCodeDto = await _lineStatusCodeAppService.GetAsync(Id);
        LineStatusCode = ObjectMapper.Map<LineStatusCodeDto, CreateUpdateLineStatusCodeDto>(lineStatusCodeDto);
    }
    
    public async Task<IActionResult> OnPostAsync()
    {
        await _lineStatusCodeAppService.UpdateAsync(Id, LineStatusCode);
        return NoContent();
    }
   
}