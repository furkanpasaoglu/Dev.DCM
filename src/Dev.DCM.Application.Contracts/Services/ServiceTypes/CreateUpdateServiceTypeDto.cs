using System.ComponentModel.DataAnnotations;

namespace Dev.DCM.Services.ServiceTypes;

/// <summary>
///  Hizmet Tipi Oluştur ve Güncelle
/// </summary>
public class CreateUpdateServiceTypeDto
{
    [Required]
    public int No { get; set; }

    [Required]
    public string BusinessType { get; set; } = default!;
    
    [Required]
    public string InfrastructureType { get; set; } = default!;
    
    [Required]
    public string ServiceTypeValue { get; set; } = default!;
    
    [Required]
    public string ValueDescription { get; set; } = default!;

    [Required] public bool IsActive { get; set; } = false;
}