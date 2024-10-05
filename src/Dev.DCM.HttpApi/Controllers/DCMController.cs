using Dev.DCM.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Dev.DCM.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class DCMController : AbpControllerBase
{
    protected DCMController()
    {
        LocalizationResource = typeof(DCMResource);
    }
}
