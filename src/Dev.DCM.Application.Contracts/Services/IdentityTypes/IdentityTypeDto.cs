using System;
using Volo.Abp.Application.Dtos;

namespace Dev.DCM.Services.IdentityTypes;

/// <summary>
/// Kimlik Tipleri DTO
/// </summary>
public class IdentityTypeDto : EntityDto<Guid>
{
    public int No { get; set; }
    public string Name { get; set; } = default!;
    public string CountryCode { get; set; } = default!;
    public string TypeCode { get; set; } = default!;
    public string SerialNo { get; set; } = default!;
    public string IdentityNo { get; set; } =  default!;
}