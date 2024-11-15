using Dev.DCM.Entities.LineStatusCodes;
using System;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Dev.DCM.Services.LineStatusCodes;

public class LineStatusCodeAppService(IRepository<LineStatusCode, Guid> repository, LineStatusCodeAppValidationService lineStatusCodeAppValidation) :
    CrudAppService<
        LineStatusCode,
        LineStatusCodeDto,
        Guid,
        PagedAndSortedResultRequestDto,
        CreateUpdateLineStatusCodeDto>(repository),
    ILineStatusCodeAppService
{
    protected override string GetPolicyName { get; set; } = Permissions.DCMPermissions.Types.LineStatusCodes.Default;
    protected override string GetListPolicyName { get; set; } = Permissions.DCMPermissions.Types.LineStatusCodes.Default;
    protected override string CreatePolicyName { get; set; } = Permissions.DCMPermissions.Types.LineStatusCodes.Create;
    protected override string UpdatePolicyName { get; set; } = Permissions.DCMPermissions.Types.LineStatusCodes.Edit;
    protected override string DeletePolicyName { get; set; } = Permissions.DCMPermissions.Types.LineStatusCodes.Delete;

    public override async Task<LineStatusCodeDto> CreateAsync(CreateUpdateLineStatusCodeDto input)
    {
        await ValidateDtoAsync(input.Code);
        return await base.CreateAsync(input);
    }



    private async Task ValidateDtoAsync(string code)
    {
        await lineStatusCodeAppValidation.IsLineStatusCodeExists(code);
    }

}