namespace Dev.DCM.Entities.ResidentialAddresses;

/// <summary>
/// ABONE_ADRES_YERLESIM
/// </summary>
public class ResidentialAddress : FullAuditedEntity<Guid>
{
    /// <summary>
    /// ABONE_ADRES_YERLESIM_IL
    /// </summary>
    public int? CityId { get; set; }
    /// <summary>
    /// İl
    /// </summary>
    public City? City { get; set; }  

    /// <summary>
    /// ABONE_ADRES_YERLESIM_ILCE
    /// </summary>
    public int DistrictId { get; set; }

    /// <summary>
    /// İlçe
    /// </summary>
    public District? District { get; set; } 

    /// <summary>
    /// ABONE_ADRES_YERLESIM_MAHALLE
    /// </summary>
    public string? Neighborhood { get; set; }

    /// <summary>
    /// ABONE_ADRES_YERLESIM_CADDE
    /// </summary>
    public string? Street { get; set; }

    /// <summary>
    /// ABONE_ADRES_YERLESIM_DIS_KAPI_NO
    /// </summary>
    public string? BuildingNumber { get; set; }

    /// <summary>
    /// ABONE_ADRES_YERLESIM_IC_KAPI_NO
    /// </summary>
    public string? ApartmentNumber { get; set; }

    /// <summary>
    /// ABONE_ADRES_YERLESIM_NO
    /// </summary>
    public string? AddressNo { get; set; }


    /// <summary>
    /// Address_Id
    /// </summary>
    public Guid AddressId { get; set; }

    /// <summary>
    /// Address
    /// </summary>
    public Address Address { get; set; } = null!;
}
