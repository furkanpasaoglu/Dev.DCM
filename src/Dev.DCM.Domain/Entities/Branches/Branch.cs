using Dev.DCM.Entities.Activations;
using Dev.DCM.Entities.Updaters;

namespace Dev.DCM.Entities.Branches;

/// <summary>
/// Bayi
/// </summary>
public class Branch : FullAuditedEntity<Guid>
{
    /// <summary>
    /// Bayi Adı
    /// </summary>
    public string? BranchName { get; set; }

    /// <summary>
    /// Bayi Adresi
    /// </summary>
    public string? BranchAddress { get; set; }
    
    public ICollection<Updater> Updaters { get; set; } = new List<Updater>();
    public ICollection<Activation> Activations { get; set; } = new List<Activation>();
}