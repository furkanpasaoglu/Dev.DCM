using System;
using System.ComponentModel.DataAnnotations;
using Dev.DCM.Services.Countries;

namespace Dev.DCM.Services.Cities;

public class CreateUpdateCityDto
{
    public string? Code { get; set; }  
    [Required]
    public string Name { get; set; } = string.Empty;
    [Required]
    public Guid CountryId { get; set; }
}