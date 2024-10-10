using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Dev.DCM.Services.CustomerMovementCodes;

public interface ICustomerMovementCodeAppService :
    ICrudAppService<
        CustomerMovementCodeDto,
        Guid,
        PagedAndSortedResultRequestDto,
        CreateUpdateCustomerMovementCodeDto>
{
    
}