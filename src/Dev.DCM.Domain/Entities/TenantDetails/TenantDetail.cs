using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.TenantManagement;

namespace Dev.DCM.Entities.TenantDetails;

public class TenantDetail : FullAuditedEntity<Guid>
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
    
    [ForeignKey(nameof(Tenant))]
    public Guid TenantId { get; set; }
    public Tenant Tenant { get; set; } = null!;
}