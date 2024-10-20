using System;
using System.Threading.Tasks;
using Dev.DCM.Services.Parameters;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Dev.DCM.Web.Pages.Parameters;

public class EditModal : DCMPageModel
{
    [HiddenInput]
    [BindProperty(SupportsGet = true)]
    public Guid Id { get; set; }
    
    [BindProperty]
    public CreateUpdateParameterDto CreateUpdateParameter { get; set; }
    
    private readonly IParameterAppService _parameterAppService;

    public EditModal(IParameterAppService parameterAppService)
    {
        _parameterAppService = parameterAppService;
    }
    
    public async Task OnGetAsync()
    {
        var createUpdateParameterDto = await _parameterAppService.GetAsync(Id);
        CreateUpdateParameter = ObjectMapper.Map<ParameterDto, CreateUpdateParameterDto>(createUpdateParameterDto);
    }
    
    public async Task<IActionResult> OnPostAsync()
    {
        await _parameterAppService.UpdateAsync(Id, CreateUpdateParameter);
        return NoContent();
    }
  
}