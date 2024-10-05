using Dev.DCM.Localization;
using Volo.Abp.AspNetCore.Components;

namespace Dev.DCM.Blazor.WebApp.Client;

public abstract class DCMComponentBase : AbpComponentBase
{
    protected DCMComponentBase()
    {
        LocalizationResource = typeof(DCMResource);
    }
}
