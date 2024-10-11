using System;
using System.ComponentModel.DataAnnotations;

namespace Dev.DCM.Services.Districts;

public class CreateUpdateDistrictDto
{
    public string? Code { get; set; } 
    [Required]
    public string Name { get; set; }
    [Required]
    public Guid CityId { get; set; }
}