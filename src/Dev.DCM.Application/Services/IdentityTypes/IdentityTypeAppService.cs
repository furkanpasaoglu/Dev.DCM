using Dev.DCM.Entities.IdentityTypes;
using System;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Dev.DCM.Services.IdentityTypes;

public class IdentityTypeAppService :
    CrudAppService<
        IdentityType,
        IdentityTypeDto,
        Guid,
        PagedAndSortedResultRequestDto,
        CreateUpdateIdentityTypeDto>,
    IIdentityTypeAppService
{
    public IdentityTypeAppService(IRepository<IdentityType, Guid> repository) : base(repository)
    {
        GetPolicyName = Permissions.DCMPermissions.Types.IdentityTypes.Default;
        GetListPolicyName = Permissions.DCMPermissions.Types.IdentityTypes.Default;
        CreatePolicyName = Permissions.DCMPermissions.Types.IdentityTypes.Create;
        UpdatePolicyName = Permissions.DCMPermissions.Types.IdentityTypes.Edit;
        DeletePolicyName = Permissions.DCMPermissions.Types.IdentityTypes.Delete;
    }

    public override async Task<IdentityTypeDto> CreateAsync(CreateUpdateIdentityTypeDto input)
    {
        await IsIdentityTypeExists(input.No);
        return await base.CreateAsync(input);
    }

    #region Validation

    private async Task IsIdentityTypeExists(int no)
    {
        var existing = await Repository.AnyAsync(c => c.No == no);
        if (existing)
        {
            throw new UserFriendlyException(message: L["AlreadyExists"]);
        }
    }

    #endregion
}