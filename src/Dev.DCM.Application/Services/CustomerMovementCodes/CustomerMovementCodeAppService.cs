using Dev.DCM.Entities.CustomerMovementCodes;
using System;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Dev.DCM.Services.CustomerMovementCodes;

public class CustomerMovementCodeAppService :
    CrudAppService<
        CustomerMovementCode,
        CustomerMovementCodeDto,
        Guid,
        PagedAndSortedResultRequestDto,
        CreateUpdateCustomerMovementCodeDto>,
    ICustomerMovementCodeAppService
{
    public CustomerMovementCodeAppService(IRepository<CustomerMovementCode, Guid> repository) : base(repository)
    {
        GetPolicyName = Permissions.DCMPermissions.Types.CustomerMovementCodes.Default;
        GetListPolicyName = Permissions.DCMPermissions.Types.CustomerMovementCodes.Default;
        CreatePolicyName = Permissions.DCMPermissions.Types.CustomerMovementCodes.Create;
        UpdatePolicyName = Permissions.DCMPermissions.Types.CustomerMovementCodes.Edit;
        DeletePolicyName = Permissions.DCMPermissions.Types.CustomerMovementCodes.Delete;
    }

    public override async Task<CustomerMovementCodeDto> CreateAsync(CreateUpdateCustomerMovementCodeDto input)
    {
        await IsCustomerMovementCodeExists(input.Code, input.Description);
        return await base.CreateAsync(input);
    }
    
    #region Validation

    private async Task IsCustomerMovementCodeExists(string code, string? description)
    {
        var existing = await Repository.AnyAsync(c => c.Code == code || c.Description == description);
        if (existing)
        {
            throw new UserFriendlyException(message: L["AlreadyExists"]);
        }
    }

    #endregion
}