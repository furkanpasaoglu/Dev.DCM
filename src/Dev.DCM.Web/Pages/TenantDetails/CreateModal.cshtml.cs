using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Dev.DCM.Services.TenantDetails;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Volo.Abp.Application.Dtos;
using Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Form;
using Volo.Abp.TenantManagement;

namespace Dev.DCM.Web.Pages.TenantDetails;

public class CreateModal(ITenantDetailAppService tenantDetailAppService, ITenantAppService tenantAppService) : DCMPageModel
{
    [BindProperty]
    public TenantDetailCreateDetailModel CreateUpdateTenantDetail { get; set; }
    public List<SelectListItem> Tenants { get; set; }
    
    public async Task OnGet()
    {
        CreateUpdateTenantDetail = new TenantDetailCreateDetailModel();
        var tenants = await tenantAppService.GetListAsync(new GetTenantsInput());
        Tenants = tenants.Items
            .Select(c => new SelectListItem(c.Name, c.Id.ToString()))
            .ToList();
        Tenants.Insert(0, new SelectListItem { Value = "", Text = L["Select"] });
    }
    
    public async Task<IActionResult> OnPostAsync()
    {
        await tenantDetailAppService.CreateAsync(new CreateUpdateTenantDetailDto
        {
            TenantId = CreateUpdateTenantDetail.TenantId,
            Name = CreateUpdateTenantDetail.Name,
            OperatorCode = CreateUpdateTenantDetail.OperatorCode,
            TaxNumber = CreateUpdateTenantDetail.TaxNumber
        });
        return NoContent();
    }
    
    public class TenantDetailCreateDetailModel
    {
        [Required(ErrorMessage = "TenantDetailNameIsRequired")]
        [Placeholder("TenantDetailNamePlaceholder")]
        [DisplayOrder(1)]
        public string Name { get; set; }
        
        [DisplayOrder(2)]
        [Required(ErrorMessage = "OperatorCodeIsRequired")]
        public string OperatorCode { get; set; }
        
        [DisplayOrder(3)]
        [Required(ErrorMessage = "TaxNumberIsRequired")]
        public string TaxNumber { get; set; }
        
        [Required(ErrorMessage = "TenantIsRequired")]
        [SelectItems(nameof(Tenants))]
        [Display(Name = "Tenant")]
        [DisplayOrder(4)]
        public Guid TenantId { get; set; }
    }
    
}