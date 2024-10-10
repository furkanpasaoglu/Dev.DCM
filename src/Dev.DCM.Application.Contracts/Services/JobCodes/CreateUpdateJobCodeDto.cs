using System.ComponentModel.DataAnnotations;

namespace Dev.DCM.Services.JobCodes;

public class CreateUpdateJobCodeDto
{
    [Required]
    public int No { get; set; }

    [Required]
    public string Code { get; set; } = default!;
    
    [Required]
    public string Name { get; set; } = default!;
}