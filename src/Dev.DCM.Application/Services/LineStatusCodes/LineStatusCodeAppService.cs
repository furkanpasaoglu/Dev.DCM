using Dev.DCM.Entities.LineStatusCodes;
using System;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Dev.DCM.Services.LineStatusCodes;

public class LineStatusCodeAppService :
    CrudAppService<
        LineStatusCode,
        LineStatusCodeDto,
        Guid,
        PagedAndSortedResultRequestDto,
        CreateUpdateLineStatusCodeDto>,
    ILineStatusCodeAppService
{
    public LineStatusCodeAppService(IRepository<LineStatusCode, Guid> repository) : base(repository)
    {
        GetPolicyName = Permissions.DCMPermissions.LineStatusCodes.Default;
        GetListPolicyName = Permissions.DCMPermissions.LineStatusCodes.Default;
        CreatePolicyName = Permissions.DCMPermissions.LineStatusCodes.Create;
        UpdatePolicyName = Permissions.DCMPermissions.LineStatusCodes.Edit;
        DeletePolicyName = Permissions.DCMPermissions.LineStatusCodes.Delete;
    }

    public override async Task<LineStatusCodeDto> CreateAsync(CreateUpdateLineStatusCodeDto input)
    {
        await IsLineStatusCodeExists(input.Code);
        return await base.CreateAsync(input);
    }

    #region Validation

    private async Task IsLineStatusCodeExists(string code)
    {
        var existing = await Repository.AnyAsync(c =>c.Code == code);
        if (!existing)
        {
            throw new UserFriendlyException(message: L["AlreadyExists"]);
        }
    }

    #endregion
}