using System;
using Volo.Abp.Application.Dtos;

namespace Dev.DCM.Services.ServiceTypes;

/// <summary>
///  Hizmet Tipi Dto
/// </summary>
public class ServiceTypeDto : EntityDto<Guid>
{
    public int No { get; set; }
    public string BusinessType { get; set; } = default!;
    public string InfrastructureType { get; set; } = default!;
    public string ServiceTypeValue { get; set; } = default!;
    public string ValueDescription { get; set; } = default!;
}