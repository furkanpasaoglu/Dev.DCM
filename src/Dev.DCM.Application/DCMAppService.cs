using System;
using System.Collections.Generic;
using System.Text;
using Dev.DCM.Localization;
using Volo.Abp.Application.Services;

namespace Dev.DCM;

/* Inherit your application services from this class.
 */
public abstract class DCMAppService : ApplicationService
{
    protected DCMAppService()
    {
        LocalizationResource = typeof(DCMResource);
    }
}
