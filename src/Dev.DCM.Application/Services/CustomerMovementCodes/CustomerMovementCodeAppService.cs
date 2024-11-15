using Dev.DCM.Entities.CustomerMovementCodes;
using System;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Dev.DCM.Services.CustomerMovementCodes;

public class CustomerMovementCodeAppService(IRepository<CustomerMovementCode, Guid> repository, CustomerMovementValidationService customerMovementValidationService) :
    CrudAppService<
        CustomerMovementCode,
        CustomerMovementCodeDto,
        Guid,
        PagedAndSortedResultRequestDto,
        CreateUpdateCustomerMovementCodeDto>(repository),
    ICustomerMovementCodeAppService
{
    protected override string GetPolicyName { get; set; } = Permissions.DCMPermissions.Types.CustomerMovementCodes.Default;
    protected override string GetListPolicyName { get; set; } = Permissions.DCMPermissions.Types.CustomerMovementCodes.Default;
    protected override string CreatePolicyName { get; set; } = Permissions.DCMPermissions.Types.CustomerMovementCodes.Create;
    protected override string UpdatePolicyName { get; set; } = Permissions.DCMPermissions.Types.CustomerMovementCodes.Edit;
    protected override string DeletePolicyName { get; set; } = Permissions.DCMPermissions.Types.CustomerMovementCodes.Delete;

    public override async Task<CustomerMovementCodeDto> CreateAsync(CreateUpdateCustomerMovementCodeDto input)
    {
        await ValidateDtoAsync(input.Code, input.Description);
        return await base.CreateAsync(input);
    }
    public override async Task<CustomerMovementCodeDto> UpdateAsync(Guid id, CreateUpdateCustomerMovementCodeDto input)
    {
        await ValidateDtoAsync(input.Code, input.Description);
        return await base.UpdateAsync(id, input);
    }
    private async Task ValidateDtoAsync(string code, string? description)
    {
        await customerMovementValidationService.IsCustomerMovementCodeExists(code, description);
    }
}