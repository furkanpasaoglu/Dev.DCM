namespace Dev.DCM.Entities.LineStatusCodes;

/// <summary>
/// Hat Durum Kodları
/// </summary>
public class LineStatusCode : Entity<int>
{
    /// <summary>
    /// Kod
    /// </summary>
    public string? Code { get; set; }

    /// <summary>
    /// Hat Durum
    /// </summary>
    public string? Status { get; set; }

    /// <summary>
    /// Hat Durum Açıklama
    /// </summary>
    public string? StatusDescription { get; set; }
}
