using Dev.DCM.Entities.Districts;
using Dev.DCM.Localization;
using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace Dev.DCM.Services.Districts
{
    public class DistrictAppValidationService (IRepository<District, Guid> repository, IStringLocalizer<DCMResource> L) : ITransientDependency
    {
        public async Task IsDistrictExists(string name)
        {
            var existing = await repository.FirstOrDefaultAsync(c => c.Name == name);
            if (existing != null)
            {
                throw new UserFriendlyException(message: L["AlreadyExists"]);
            }
        }
    }
}
