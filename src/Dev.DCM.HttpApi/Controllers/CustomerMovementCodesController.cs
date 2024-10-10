using System;
using System.Threading.Tasks;
using Asp.Versioning;
using Dev.DCM.Services.CustomerMovementCodes;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp;
using Volo.Abp.Application.Dtos;

namespace Dev.DCM.Controllers;

[RemoteService]
[Area("app")]
[ControllerName("CustomerMovementCodes")]
[Route("api/app/customer-movement-codes")]
public class CustomerMovementCodesController(ICustomerMovementCodeAppService customerMovementCodeAppService)
    : DCMController
{
    [HttpGet]
    [ProducesResponseType(typeof(PagedResultDto<CustomerMovementCodeDto>), 200)]
    public async Task<PagedResultDto<CustomerMovementCodeDto>> GetListAsync(PagedAndSortedResultRequestDto input)
    {
        return await customerMovementCodeAppService.GetListAsync(input);
    }

    [HttpGet]
    [Route("{id:Guid}")]
    [ProducesResponseType<ProblemDetails>(400)]
    [ProducesResponseType(typeof(CustomerMovementCodeDto), 200)]
    public async Task<CustomerMovementCodeDto> GetAsync(Guid id)
    {
        return await customerMovementCodeAppService.GetAsync(id);
    }

    [HttpPost]
    [ProducesResponseType(typeof(CustomerMovementCodeDto), 201)]
    [ProducesResponseType(typeof(ProblemDetails), 400)]
    public async Task<CustomerMovementCodeDto> CreateAsync(CreateUpdateCustomerMovementCodeDto input)
    {
        return await customerMovementCodeAppService.CreateAsync(input);
    }

    [HttpPut]
    [Route("{id:Guid}")]
    [ProducesResponseType(typeof(CustomerMovementCodeDto), 200)]
    [ProducesResponseType(typeof(ProblemDetails), 400)]
    public async Task<CustomerMovementCodeDto> UpdateAsync(Guid id, CreateUpdateCustomerMovementCodeDto input)
    {
        return await customerMovementCodeAppService.UpdateAsync(id, input);
    }

    [HttpDelete]
    [Route("{id:Guid}")]
    [ProducesResponseType(200)]
    [ProducesResponseType(typeof(ProblemDetails), 400)]
    public async Task DeleteAsync(Guid id)
    {
        await customerMovementCodeAppService.DeleteAsync(id);
    }
}