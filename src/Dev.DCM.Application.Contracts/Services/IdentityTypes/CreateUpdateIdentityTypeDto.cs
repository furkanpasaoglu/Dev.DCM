using System.ComponentModel.DataAnnotations;

namespace Dev.DCM.Services.IdentityTypes;

public class CreateUpdateIdentityTypeDto
{
    [Required]
    public int No { get; set; }
    [Required]
    public string Name { get; set; } = default!;
    [Required]
    public string CountryCode { get; set; } = default!;
    [Required]
    public string TypeCode { get; set; } = default!;
    [Required]
    public string SerialNo { get; set; } = default!;
    [Required]
    public string IdentityNo { get; set; } =  default!;
}