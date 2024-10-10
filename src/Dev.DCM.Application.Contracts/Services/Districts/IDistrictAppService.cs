using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Dev.DCM.Services.Districts;

public interface IDistrictAppService :
    ICrudAppService<
        DistrictDto,
        Guid,
        PagedAndSortedResultRequestDto,
        CreateUpdateDistrictDto>
{
    
}