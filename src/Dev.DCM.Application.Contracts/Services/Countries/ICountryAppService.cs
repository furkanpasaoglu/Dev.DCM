using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Dev.DCM.Services.Countries;

public interface ICountryAppService :
    ICrudAppService<
        CountryDto,
        Guid,
        PagedAndSortedResultRequestDto,
        CreateUpdateCountryDto>
{
    
}