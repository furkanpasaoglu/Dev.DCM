using System;
using System.Threading.Tasks;
using Dev.DCM.Entities.TenantDetails;
using Dev.DCM.Localization;
using Microsoft.Extensions.Localization;
using Volo.Abp;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace Dev.DCM.Services.TenantDetails;

public class TenantDetailValidationService(IRepository<TenantDetail, Guid> tenantDetailRepository, IStringLocalizer<DCMResource> l) : ITransientDependency
{
    public async Task IsTenantDetailNameUniqueAsync(string name, Guid? existingId = null)
    {
        var existingTenantDetail = await tenantDetailRepository.FirstOrDefaultAsync(c => c.Name == name);
        if (existingTenantDetail != null && existingTenantDetail.Id != existingId)
        {
            throw new UserFriendlyException(l["TenantDetailNameMustBeUnique"]);
        }
    }
}