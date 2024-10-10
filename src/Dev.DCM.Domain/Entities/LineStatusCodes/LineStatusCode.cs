namespace Dev.DCM.Entities.LineStatusCodes;

/// <summary>
/// Hat Durum Kodları
/// </summary>
public class LineStatusCode : Entity<Guid>
{
    /// <summary>
    /// Kod
    /// </summary>
    public string Code { get; set; } = null!;

    /// <summary>
    /// Hat Durum
    /// </summary>
    public string Status { get; set; } = null!;

    /// <summary>
    /// Hat Durum Açıklama
    /// </summary>
    public string StatusDescription { get; set; } = null!;
}
