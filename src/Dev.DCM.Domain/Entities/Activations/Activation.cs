using Dev.DCM.Entities.Branches;
using Volo.Abp.Identity;
using Volo.Abp.TenantManagement;

namespace Dev.DCM.Entities.Activations;

/// <summary>
/// Aktivasyon
/// </summary>
public class Activation : FullAuditedEntity<Guid>
{
    /// <summary>
    /// AKTIVASYON_KULLANICI
    /// </summary>
    public string? ActivationUser { get; set; }
    
    /// <summary>
    /// BranchId - Güncellemeyi yapan bayi (Foreign Key)
    /// </summary>
    public Guid? BranchId { get; set; }
    
    /// <summary>
    /// Güncelleyen Bayi - Relation
    /// </summary>
    public Branch? Branch { get; set; } // Bayi ile ilişki

    /// <summary>
    /// TenantId - Çoklu tenant desteği için
    /// </summary>
    public Guid? TenantId { get; set; }
    public Tenant? Tenant { get; set; }

    /// <summary>
    /// PortalUserId - Portaldan aktivasyon işlemini yapan kullanıcı
    /// </summary>
    public Guid? PortalUserId { get; set; }
    public IdentityUser? IdentityUser { get; set; }
    
}