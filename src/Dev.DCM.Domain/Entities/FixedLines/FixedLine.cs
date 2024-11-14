using Dev.DCM.Entities.Lines;

namespace Dev.DCM.Entities.FixedLines;

/// <summary>
/// SABIT
/// </summary>
public class FixedLine : FullAuditedEntity<Guid>
{
    /// <summary>
    /// SABIT_ONCEKI_HAT_NUMARASI
    /// </summary>
    public string? PreviousFixedLineNumber { get; set; }

    /// <summary>
    /// SABIT_DONDURULMA_TARIHI
    /// </summary>
    public DateTime? FrozenDate { get; set; }

    /// <summary>
    /// SABIT_KISITLAMA_TARIHI
    /// </summary>
    public DateTime? RestrictionDate { get; set; }

    /// <summary>
    /// SABIT_YURTDISI_AKTIF
    /// </summary>
    public bool? IsInternationalActive { get; set; }

    /// <summary>
    /// SABIT_SESLI_ARAMA_AKTIF
    /// </summary>
    public bool? IsVoiceCallActive { get; set; }

    /// <summary>
    /// SABIT_REHBER_AKTIF
    /// </summary>
    public bool? IsDirectoryActive { get; set; }

    /// <summary>
    /// SABIT_CLIR_OZELLIGI_AKTIF
    /// </summary>
    public bool? IsClirFeatureActive { get; set; }

    /// <summary>
    /// SABIT_DATA_AKTIF
    /// </summary>
    public bool? IsDataActive { get; set; }

    /// <summary>
    /// SABIT_SEHIRLERARASI_AKTIF
    /// </summary>
    public bool? IsIntercityCallActive { get; set; }

    /// <summary>
    /// SABIT_SANTRAL_BINASI
    /// </summary>
    public string? CentralBuilding { get; set; }

    /// <summary>
    /// SABIT_SANTRAL_TIPI
    /// </summary>
    public string? CentralType { get; set; }

    /// <summary>
    /// SABIT_SEBEKE_HIZMET_NUMARASI
    /// </summary>
    public string? NetworkServiceNumber { get; set; }

    /// <summary>
    /// SABIT_PILOT_NUMARA
    /// </summary>
    public string? PilotNumber { get; set; }

    /// <summary>
    /// SABIT_DDI_HIZMET_NUMARASI
    /// </summary>
    public string? DdiServiceNumber { get; set; }

    /// <summary>
    /// SABIT_GORUNEN_NUMARA
    /// </summary>
    public string? VisibleNumber { get; set; }

    /// <summary>
    /// SABIT_REFERANS_NO
    /// </summary>
    public string? ReferenceNumber { get; set; }

    /// <summary>
    /// SABIT_EV_ISYERI
    /// </summary>
    public string? HomeOrOffice { get; set; }

    /// <summary>
    /// SABIT_ABONE_ID
    /// </summary>
    public string? SubscriberId { get; set; }

    /// <summary>
    /// SABIT_SERVIS_NUMARASI
    /// </summary>
    public string? ServiceNumber { get; set; }

    /// <summary>
    /// SABIT_DAHILI_NO
    /// </summary>
    public string? InternalNumber { get; set; }

    /// <summary>
    /// SABIT_ALFANUMERIK_BASLIK
    /// </summary>
    public string? AlphanumericTitle { get; set; }
    
    
    public Guid LineId { get; set; }
}
