using Dev.DCM.Entities.Branches;
using Volo.Abp.Identity;
using Volo.Abp.TenantManagement;

namespace Dev.DCM.Entities.Updaters;

/// <summary>
/// Güncelleyici
/// </summary>
public class Updater : FullAuditedEntity<Guid>
{
    /// <summary>
    /// GUNCELLEYEN_KULLANICI
    /// </summary>
    public string? UpdaterUser { get; set; }
    
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
    /// PortalUserId - Portaldan güncelleyen kullanıcı
    /// </summary>
    public Guid? UserId { get; set; }
    public IdentityUser? IdentityUser { get; set; }
}