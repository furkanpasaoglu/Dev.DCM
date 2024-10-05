using Dev.DCM.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Dev.DCM.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class DCMPageModel : AbpPageModel
{
    protected DCMPageModel()
    {
        LocalizationResourceType = typeof(DCMResource);
    }
}
