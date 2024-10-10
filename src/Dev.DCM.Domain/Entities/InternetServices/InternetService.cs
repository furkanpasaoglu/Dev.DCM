﻿namespace Dev.DCM.Entities.InternetServices;

/// <summary>
/// ISS
/// </summary>
public class InternetService : FullAuditedEntity<Guid>
{
    /// <summary>
    /// ISS_HIZ_PROFILI
    /// </summary>
    public string? SpeedProfile { get; set; }

    /// <summary>
    /// ISS_KULLANICI_ADI
    /// </summary>
    public string? Username { get; set; }

    /// <summary>
    /// ISS_POP_BILGISI
    /// </summary>
    public string? PopInfo { get; set; }
}