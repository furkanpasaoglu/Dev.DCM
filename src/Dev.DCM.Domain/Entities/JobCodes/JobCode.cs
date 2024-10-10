namespace Dev.DCM.Entities.JobCodes;

/// <summary>
/// Meslek Kodları
/// </summary>
public class JobCode : Entity<Guid>
{
    /// <summary>
    /// No
    /// </summary>
    public int No { get; set; }

    /// <summary>
    /// Meslek Kodu
    /// </summary>
    public string Code { get; set; } = null!;

    
    /// <summary>
    /// Meslek Adı
    /// </summary>
    public string Name { get; set; } = null!;
}
