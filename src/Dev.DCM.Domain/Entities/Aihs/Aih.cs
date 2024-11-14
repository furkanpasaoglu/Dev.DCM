using Dev.DCM.Entities.Lines;

namespace Dev.DCM.Entities.Aihs;

/// <summary>
/// Aih 
/// </summary>
public class Aih  : FullAuditedEntity<Guid>
{
    /// <summary>
    /// HIZ_PROFİL
    /// </summary>
    public string? SpeedProfile { get; set; }

    /// <summary>
    /// HIZMET_SAGLAYICI
    /// </summary>
    public string? ServiceProvider { get; set; }

    /// <summary>
    /// POP_BILGI
    /// </summary>
    public string? PopInfo { get; set; }

    /// <summary>
    /// ULKE_A
    /// </summary>
    public string? CountryA { get; set; }

    /// <summary>
    /// SINIR_GECIS_NOKTASI_A
    /// </summary>
    public string? BorderCrossingPointA { get; set; }

    /// <summary>
    /// SINIR_GECIS_NOKTASI_B
    /// </summary>
    public string? BorderCrossingPointB { get; set; }

    /// <summary>
    /// DEVRE_ADLANDIRMASI
    /// </summary>
    public string? CircuitNaming { get; set; }

    /// <summary>
    /// DEVRE_GUZERGAH
    /// </summary>
    public string? CircuitRoute { get; set; }

    // Abone ve Tesise bağlı adreslerle ilgili bilgilerin tanımlanması
    /// <summary>
    /// ABONE.ADRES.TESIS_ULKE_B
    /// </summary>
    public Guid? CountryId { get; set; }
    public Country? Country { get; set; }

    /// <summary>
    /// ABONE.ADRES.TESIS_IL_B
    /// </summary>
    public Guid? CityId { get; set; }
    public City? City { get; set; }

    /// <summary>
    /// ABONE.ADRES.TESIS_ILCE_B
    /// </summary>
    public Guid? DistrictId { get; set; }
    public District? District { get; set; }

    /// <summary>
    /// ABONE.ADRES.TESIS_MAHALLE_B
    /// </summary>
    public string? SubscriberNeighborhoodB { get; set; }

    /// <summary>
    /// ABONE.ADRES.TESIS_CADDE_B
    /// </summary>
    public string? SubscriberStreetB { get; set; }

    /// <summary>
    /// ABONE.ADRES.TESIS_DIS_KAPI_NO_B
    /// </summary>
    public string? SubscriberBuildingNoB { get; set; }

    /// <summary>
    /// ABONE.ADRES.TESIS_IC_KAPI_NO_B
    /// </summary>
    public string? SubscriberApartmentNoB { get; set; }
    
    public Guid LineId { get; set; }
}