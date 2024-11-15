using System.ComponentModel.DataAnnotations.Schema;

namespace Dev.DCM.Entities.FacilityAddresses;

/// <summary>
/// ABONE_ADRES_TESIS
/// </summary>
public class FacilityAddress : FullAuditedEntity<Guid>
{
    /// <summary>
    /// ABONE_ADRES_TESIS_IL
    /// </summary>
    public string? City { get; set; }

    /// <summary>
    /// ABONE_ADRES_TESIS_ILCE
    /// </summary>
    public string? District { get; set; }

    /// <summary>
    /// ABONE_ADRES_TESIS_MAHALLE
    /// </summary>
    public string? Neighborhood { get; set; }

    /// <summary>
    /// ABONE_ADRES_TESIS_CADDE
    /// </summary>
    public string? Street { get; set; }

    /// <summary>
    /// ABONE_ADRES_TESIS_DIS_KAPI_NO
    /// </summary>
    public string? BuildingNumber { get; set; }

    /// <summary>
    /// ABONE_ADRES_TESIS_IC_KAPI_NO
    /// </summary>
    public string? ApartmentNumber { get; set; }

    /// <summary>
    /// ABONE_ADRES_TESIS_POSTA_KODU
    /// </summary>
    public string? PostalCode { get; set; }

    /// <summary>
    /// ABONE_ADRES_TESIS_ADRES_KODU
    /// </summary>
    public string? AddressCode { get; set; }


    /// <summary>
    /// Address_Id
    /// </summary>
    [ForeignKey(nameof(Address))]
    public Guid AddressId { get; set; }

    /// <summary>
    /// Address
    /// </summary>
    public Address Address { get; set; } = default!;
}
