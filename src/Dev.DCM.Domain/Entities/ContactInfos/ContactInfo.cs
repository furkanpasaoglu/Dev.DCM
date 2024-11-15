using System.ComponentModel.DataAnnotations.Schema;

namespace Dev.DCM.Entities.ContactInfos;

/// <summary>
/// ABONE_ADRES_IRTIBAT
/// </summary>
public class ContactInfo : FullAuditedEntity<Guid>
{
    /// <summary>
    /// ABONE_ADRES_IRTIBAT_TEL_NO_1
    /// </summary>
    public string? ContactPhoneNumber1 { get; set; }

    /// <summary>
    /// ABONE_ADRES_IRTIBAT_TEL_NO_2
    /// </summary>
    public string? ContactPhoneNumber2 { get; set; }

    /// <summary>
    /// Address_Id
    /// </summary>
    [ForeignKey(nameof(Address))]
    public Guid AddressId { get; set; }

    /// <summary>
    /// Address
    /// </summary>
    public Address? Address { get; set; } 
}
