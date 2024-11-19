using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Identity;

namespace Dev.DCM.Entities.UserDetails;

/// <summary>
/// Kullanıcı Detayları
/// </summary>
public class UserDetail : FullAuditedEntity<Guid>
{
    //Tc Kimlik No
    public string? IdentityNumber { get; set; }
    
    //Doğum Tarihi
    public DateTime? BirthDate { get; set; }
    
    //Telefon Numarası
    public string? PhoneNumber { get; set; }
    
    // IdentityUser Id
    [ForeignKey(nameof(User))]
    public Guid UserId { get; set; }
    public IdentityUser User { get; set; }
}