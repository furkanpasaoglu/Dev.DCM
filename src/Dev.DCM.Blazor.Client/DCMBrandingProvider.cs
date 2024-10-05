using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Dev.DCM.Blazor.Client;

[Dependency(ReplaceServices = true)]
public class DCMBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "DCM";
}
