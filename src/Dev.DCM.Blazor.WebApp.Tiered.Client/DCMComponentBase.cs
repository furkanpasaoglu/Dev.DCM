using Dev.DCM.Localization;
using Volo.Abp.AspNetCore.Components;

namespace Dev.DCM.Blazor.WebApp.Tiered.Client;

public abstract class DCMComponentBase : AbpComponentBase
{
    protected DCMComponentBase()
    {
        LocalizationResource = typeof(DCMResource);
    }
}
