using Dev.DCM.Entities.LineStatusCodes;
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

namespace Dev.DCM.Services.LineStatusCodes
{
    public class LineStatusCodeAppValidationService(IRepository<LineStatusCode, Guid> repository,IStringLocalizer<DCMResource>L) : ITransientDependency
    {


        public async Task IsLineStatusCodeExists(string code)
        {
            var lineStatusCode = await repository.FirstOrDefaultAsync(x => x.Code == code);
            if (lineStatusCode != null)
            {
                throw new UserFriendlyException(L["AlreadyExists"]);
            }
        }
    }
}
