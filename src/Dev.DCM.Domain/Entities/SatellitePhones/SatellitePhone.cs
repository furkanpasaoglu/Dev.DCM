using System.ComponentModel.DataAnnotations.Schema;

namespace Dev.DCM.Entities.SatellitePhones;

/// <summary>
/// UYDU_TELEFON
/// </summary>
public class SatellitePhone : FullAuditedEntity<Guid>
{
    /// <summary>
    /// UYDU_TELEFON_SERINO
    /// </summary>
    public string? SerialNumber { get; set; }

    /// <summary>
    /// UYDU_TELEFON_IMEINO
    /// </summary>
    public string? ImeiNumber { get; set; }

    /// <summary>
    /// UYDU_TELEFON_MARKA
    /// </summary>
    public string? Brand { get; set; }

    /// <summary>
    /// UYDU_TELEFON_MODEL
    /// </summary>
    public string? Model { get; set; }

    /// <summary>
    /// UYDU_TELEFON_SIMKARTNO
    /// </summary>
    public string? SimCardNumber { get; set; }

    /// <summary>
    /// UYDU_TELEFONU_INTERNET_KULLANIMI
    /// </summary>
    public bool? IsInternetUsageActive { get; set; }

    /// <summary>
    /// Foreign Key for SatelliteServiceDetail
    /// </summary>
    [ForeignKey(nameof(Satellite))]
    public Guid SatelliteServiceDetailId { get; set; }

    /// <summary>
    /// UYDU
    /// </summary>
    public Satellite SatelliteServiceDetail { get; set; } = null!;
}
