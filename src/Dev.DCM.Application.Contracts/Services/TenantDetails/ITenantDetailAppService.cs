using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Dev.DCM.Services.TenantDetails;

public interface ITenantDetailAppService :
    ICrudAppService<
        TenantDetailDto,
        Guid,
        PagedAndSortedResultRequestDto,
        CreateUpdateTenantDetailDto>
{
}