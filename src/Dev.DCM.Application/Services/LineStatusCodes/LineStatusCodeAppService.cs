using Dev.DCM.Entities.LineStatusCodes;
using System;
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
}