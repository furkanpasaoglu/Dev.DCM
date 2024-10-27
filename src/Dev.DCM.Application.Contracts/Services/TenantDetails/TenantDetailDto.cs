using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.TenantManagement;

namespace Dev.DCM.Services.TenantDetails;

public class TenantDetailDto : EntityDto<Guid>
{
    /// <summary>
    /// Operatör Kodu
    /// </summary>
    public string OperatorCode { get; set; } = null!;
    
    /// <summary>
    /// Vergi Kimlik Numarası
    /// </summary>
    public string TaxNumber { get; set; }= null!;
    
    /// <summary>
    /// Firmaya ait ad
    /// </summary>
    public string Name { get; set; } = null!;
    
    public Guid TenantId { get; set; }
    public TenantDto Tenant { get; set; } = null!;
}