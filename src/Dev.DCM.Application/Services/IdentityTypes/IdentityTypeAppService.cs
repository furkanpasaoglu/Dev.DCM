using Dev.DCM.Entities.IdentityTypes;
using System;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Dev.DCM.Services.IdentityTypes;

public class IdentityTypeAppService(IRepository<IdentityType, Guid> repository,IdentityTypeValidation identityTypeValidation ) :
    CrudAppService<
        IdentityType,
        IdentityTypeDto,
        Guid,
        PagedAndSortedResultRequestDto,
        CreateUpdateIdentityTypeDto>(repository),
    IIdentityTypeAppService
{
    protected override string GetPolicyName { get; set; } = Permissions.DCMPermissions.Types.IdentityTypes.Default;
    protected override string GetListPolicyName { get; set; } = Permissions.DCMPermissions.Types.IdentityTypes.Default;
    protected override string CreatePolicyName { get; set; } = Permissions.DCMPermissions.Types.IdentityTypes.Create;
    protected override string UpdatePolicyName { get; set; } = Permissions.DCMPermissions.Types.IdentityTypes.Edit;
    protected override string DeletePolicyName { get; set; } = Permissions.DCMPermissions.Types.IdentityTypes.Delete;

    public override async Task<IdentityTypeDto> CreateAsync(CreateUpdateIdentityTypeDto input)
    {
        await ValidateDtoAsync(input);
        return await base.CreateAsync(input);
    }

    public override async Task<IdentityTypeDto> UpdateAsync(Guid id, CreateUpdateIdentityTypeDto input)
    {
        await ValidateDtoAsync(input);
        return await base.UpdateAsync(id, input);
    }

    public async Task ValidateDtoAsync(CreateUpdateIdentityTypeDto input)
    {
        await identityTypeValidation.IsIdentityTypeExists(input.No);
    }
}