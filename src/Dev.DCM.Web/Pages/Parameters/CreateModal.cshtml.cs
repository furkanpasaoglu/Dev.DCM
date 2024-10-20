using System.Threading.Tasks;
using Dev.DCM.Services.Parameters;
using Microsoft.AspNetCore.Mvc;

namespace Dev.DCM.Web.Pages.Parameters;

public class CreateModal(IParameterAppService parameterAppService) : DCMPageModel
{
    [BindProperty]
    public CreateUpdateParameterDto CreateUpdateParameter { get; set; }

    public void OnGet()
    {
        CreateUpdateParameter = new CreateUpdateParameterDto();
    }

    public async Task<IActionResult> OnPostAsync()
    {
        await parameterAppService.CreateAsync(CreateUpdateParameter);
        return NoContent();
    }
    
}