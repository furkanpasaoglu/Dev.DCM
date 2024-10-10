using System.ComponentModel.DataAnnotations;

namespace Dev.DCM.Services.LineStatusCodes;

public class CreateUpdateLineStatusCodeDto
{
    [Required]
    public string Code { get; set; } = default!;
    
    [Required]
    public string Status { get; set; } = default!;
    
    [Required]
    public string StatusDescription { get; set; } = default!;
}