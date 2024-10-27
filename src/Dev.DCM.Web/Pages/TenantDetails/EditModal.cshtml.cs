using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Dev.DCM.Services.TenantDetails;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Form;
using Volo.Abp.TenantManagement;

namespace Dev.DCM.Web.Pages.TenantDetails;

public class EditModal : DCMPageModel
{
    [BindProperty]
    public TenantDetailEditDetailModel CreateUpdateTenantDetail { get; set; }
    
    [HiddenInput]
    [BindProperty(SupportsGet = true)]
    public Guid Id { get; set; }

    public List<SelectListItem> Tenants { get; set; } 
    private readonly ITenantDetailAppService _tenantDetailAppService;
    private readonly ITenantAppService _tenantAppService;

    public EditModal(ITenantAppService tenantAppService, ITenantDetailAppService tenantDetailAppService)
    {
        _tenantAppService = tenantAppService;
        _tenantDetailAppService = tenantDetailAppService;
    }
    
    public async Task OnGetAsync()
    {
        var createUpdateTenantDetailDto = await _tenantDetailAppService.GetAsync(Id);

        CreateUpdateTenantDetail = new TenantDetailEditDetailModel
        {
            TenantId = createUpdateTenantDetailDto.TenantId,
            Name = createUpdateTenantDetailDto.Name,
            OperatorCode = createUpdateTenantDetailDto.OperatorCode,
            TaxNumber = createUpdateTenantDetailDto.TaxNumber
        };
        var tenants = await _tenantAppService.GetListAsync(new GetTenantsInput());
        Tenants = tenants.Items
            .Select(c => new SelectListItem(c.Name, c.Id.ToString()))
            .ToList();
        Tenants.Insert(0, new SelectListItem { Value = "", Text = L["Select"] });
    }
    
    public async Task<IActionResult> OnPostAsync()
    {
        await _tenantDetailAppService.UpdateAsync(Id, new CreateUpdateTenantDetailDto
        {
            TenantId = CreateUpdateTenantDetail.TenantId,
            Name = CreateUpdateTenantDetail.Name,
            OperatorCode = CreateUpdateTenantDetail.OperatorCode,
            TaxNumber = CreateUpdateTenantDetail.TaxNumber
        });
        return NoContent();
    }
    
    public class TenantDetailEditDetailModel
    {
        [Required(ErrorMessage = "TenantDetailNameIsRequired")]
        [Placeholder("TenantDetailNamePlaceholder")]
        [DisplayOrder(1)]
        public string Name { get; set; }
        
        [DisplayOrder(2)]
        public string OperatorCode { get; set; }
        
        [DisplayOrder(3)]
        public string TaxNumber { get; set; }
        
        [Required(ErrorMessage = "TenantIsRequired")]
        [SelectItems(nameof(Tenants))]
        [Display(Name = "Tenant")]
        [DisplayOrder(4)]
        public Guid TenantId { get; set; }
    }
}