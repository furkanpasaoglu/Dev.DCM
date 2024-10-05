namespace Dev.DCM.Entities.JobCodes;

/// <summary>
/// Meslek Kodları
/// </summary>
public class JobCode : Entity<int>
{
    /// <summary>
    /// Meslek Kodu
    /// </summary>
    public string? Code { get; set; }

    
    /// <summary>
    /// Meslek Adı
    /// </summary>
    public string? Name { get; set; }
}
