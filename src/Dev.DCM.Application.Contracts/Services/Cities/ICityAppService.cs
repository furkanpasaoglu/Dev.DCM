using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Dev.DCM.Services.Cities;

public interface ICityAppService :
    ICrudAppService<
        CityDto,
        Guid,
        PagedAndSortedResultRequestDto,
        CreateUpdateCityDto>
{
}