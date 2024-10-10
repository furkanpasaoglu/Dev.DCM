using Dev.DCM.Localization;
using Microsoft.Extensions.Localization;
using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Dev.DCM.Web;

[Dependency(ReplaceServices = true)]
public class DCMBrandingProvider : DefaultBrandingProvider
{
    private readonly IStringLocalizer<DCMResource> _localizer;

    public DCMBrandingProvider(IStringLocalizer<DCMResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
