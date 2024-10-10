using System;
using Dev.DCM.Services.Countries;
using Volo.Abp.Application.Dtos;

namespace Dev.DCM.Services.Cities;

public class CityDto  : EntityDto<Guid>
{
    public string? Code { get; set; }  
    public string Name { get; set; } = null!;
    public Guid CountryId { get; set; }
    public CountryDto Country { get; set; }
}