using Dev.DCM.Entities.Cities;
using Dev.DCM.Entities.CustomerMovements;
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

namespace Dev.DCM.Services.CustomerMovementCodes
{
    public class CustomerMovementValidationService(IRepository<CustomerMovement, Guid> customeRepository, IStringLocalizer<DCMResource> L)
    {
        public async Task IsCustomerMovementCodeExists(string code, string? description)
        {
            var existing = await customeRepository.FirstOrDefaultAsync(c => c.MovementDescription == description);
            if (existing != null)
            {
                throw new UserFriendlyException(message: L["AlreadyExists"]);
            }
        }
    }
    
}
