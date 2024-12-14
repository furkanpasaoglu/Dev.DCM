using System.ComponentModel.DataAnnotations.Schema;

namespace Dev.DCM.Entities.AuthorizedPersons;

/// <summary>
/// KURUM_YETKILI
/// </summary>
public class AuthorizedPerson : FullAuditedEntity<Guid>
{
    /// <summary>
    /// Yetkili Adı (KURUM_YETKILI_ADI)
    /// </summary>
    public string? FirstName { get; set; }

    /// <summary>
    /// Yetkili Soyadı (KURUM_YETKILI_SOYADI)
    /// </summary>
    public string? LastName { get; set; }

    /// <summary>
    /// Yetkili TC Kimlik No (KURUM_YETKILI_TCKIMLIK_NO)
    /// </summary>
    public string? NationalId { get; set; }

    /// <summary>
    /// Yetkili Telefon (KURUM_YETKILI_TELEFON)
    /// </summary>
    public string? Phone { get; set; }

    /// <summary>
    /// KURUM_ADRES
    /// </summary>
    public string? InstitutionAddress { get; set; }

    public Guid SubscriberId { get; set; }
    public Subscriber Subscriber { get; set; }


}
