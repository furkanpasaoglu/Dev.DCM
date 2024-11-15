using System;
using System.Threading.Tasks;
using Dev.DCM.Entities.ServiceTypes;
using Dev.DCM.Localization;
using Microsoft.Extensions.Localization;
using Volo.Abp;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace Dev.DCM.Services.ServiceTypes;

public class ServiceTypeValidationService(IRepository<ServiceType, Guid> serviceTypeRepository, IStringLocalizer<DCMResource> l) : ITransientDependency
{
    /// <summary>
    /// Servis tipinin benzersiz olup olmadığını kontrol eder.
    /// </summary>
    /// <param name="no"> Servis tipi no</param>
    /// <param name="serviceTypeValue"> Servis tipi değeri</param>
    /// <param name="existingId"> Mevcut servis tipi id'si</param>
    /// <returns> Servis tipi benzersiz ise true, değilse false döner.</returns>
    public async Task IsServiceTypeExistsAsync(int no, string serviceTypeValue, Guid? existingId = null)
    {
        var existingServiceType = await serviceTypeRepository.FirstOrDefaultAsync(c => c.No == no || c.ServiceTypeValue == serviceTypeValue);
        if (existingServiceType != null && existingServiceType.Id != existingId)
        {
            throw new UserFriendlyException(l["ServiceTypeMustBeUnique"]);
        }
    }
    
}