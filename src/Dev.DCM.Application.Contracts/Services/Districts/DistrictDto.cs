using System;
using System.ComponentModel.DataAnnotations;
using Dev.DCM.Services.Cities;
using Volo.Abp.Application.Dtos;

namespace Dev.DCM.Services.Districts;

public class DistrictDto : EntityDto<Guid>
{
    public string? Code { get; set; }
    public string Name { get; set; }
    public Guid CityId { get; set; }
    public CityDto City { get; set; }
}