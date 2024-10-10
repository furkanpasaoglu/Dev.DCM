using System;
using System.Threading.Tasks;
using Dev.DCM.Services.CustomerMovementCodes;
using Dev.DCM.Services.ServiceTypes;
using Microsoft.AspNetCore.Mvc;

namespace Dev.DCM.Web.Pages.CustomerMovementCodes;

public class EditModal : DCMPageModel
{
    [HiddenInput]
    [BindProperty(SupportsGet = true)]
    public Guid Id { get; set; }
    
    [BindProperty]
    public CreateUpdateCustomerMovementCodeDto CreateUpdateCustomerMovementCode { get; set; }
    
    private readonly ICustomerMovementCodeAppService _customerMovementCodeAppService;

    public EditModal(ICustomerMovementCodeAppService movementCodeAppService)
    {
        _customerMovementCodeAppService = movementCodeAppService;
    }


    public async Task OnGetAsync()
    {
        var createUpdateCustomerMovementCodeDto = await _customerMovementCodeAppService.GetAsync(Id);
        CreateUpdateCustomerMovementCode = ObjectMapper.Map<CustomerMovementCodeDto, CreateUpdateCustomerMovementCodeDto>(createUpdateCustomerMovementCodeDto);
    }
    
    public async Task<IActionResult> OnPostAsync()
    {
        await _customerMovementCodeAppService.UpdateAsync(Id, CreateUpdateCustomerMovementCode);
        return NoContent();
    }
}