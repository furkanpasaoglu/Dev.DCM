using Dev.DCM.Entities.Lines;

namespace Dev.DCM.Entities.Satellites;

/// <summary>
/// UYDU
/// </summary>
public class Satellite : FullAuditedEntity<Guid>
{
    /// <summary>
    /// UYDU_ONCEKI_HAT_NUMARASI
    /// </summary>
    public string? PreviousSatelliteLineNumber { get; set; }

    /// <summary>
    /// UYDU_DONDURULMA_TARIHI
    /// </summary>
    public DateTime? FrozenDate { get; set; }

    /// <summary>
    /// UYDU_KISITLAMA_TARIHI
    /// </summary>
    public DateTime? RestrictionDate { get; set; }

    /// <summary>
    /// UYDU_YURTDISI_AKTIF
    /// </summary>
    public bool? IsInternationalActive { get; set; }

    /// <summary>
    /// UYDU_SESLI_ARAMA_AKTIF
    /// </summary>
    public bool? IsVoiceCallActive { get; set; }

    /// <summary>
    /// UYDU_REHBER_AKTIF
    /// </summary>
    public bool? IsDirectoryActive { get; set; }

    /// <summary>
    /// UYDU_CLIR_OZELLIGI_AKTIF
    /// </summary>
    public bool? IsClirFeatureActive { get; set; }

    /// <summary>
    /// UYDU_DATA_AKTIF
    /// </summary>
    public bool IsDataActive { get; set; }

    /// <summary>
    /// UYDU_UYDU_ADI
    /// </summary>
    public string? SatelliteName { get; set; }

    /// <summary>
    /// UYDU_TERMINAL_ID
    /// </summary>
    public string? TerminalId { get; set; }

    /// <summary>
    /// UYDU_ENLEM_BILGISI
    /// </summary>
    public string? Latitude { get; set; }

    /// <summary>
    /// UYDU_BOYLAM_BILGISI
    /// </summary>
    public string? Longitude { get; set; }

    /// <summary>
    /// UYDU_HIZ_PROFILI
    /// </summary>
    public string? SpeedProfile { get; set; }

    /// <summary>
    /// UYDU_POP_BILGISI
    /// </summary>
    public string? PopInfo { get; set; }

    /// <summary>
    /// UYDU_REMOTE_BILGISI
    /// </summary>
    public string? RemoteInfo { get; set; }

    /// <summary>
    /// UYDU_ANAUYDU_FIRMA
    /// </summary>
    public string? MainSatelliteCompany { get; set; }

    /// <summary>
    /// UYDU_UYDUTELEFON_NO
    /// </summary>
    public string? SatellitePhoneNumber { get; set; }

    /// <summary>
    /// UYDU_ALFANUMERIK_BASLIK
    /// </summary>
    public string? AlphanumericTitle { get; set; }

    /// <summary>
    /// UYDU_TELEFON
    /// </summary>
    public ICollection<SatellitePhone>? SatellitePhones { get; set; } = new List<SatellitePhone>();
    
    public Guid LineId { get; set; }
}
