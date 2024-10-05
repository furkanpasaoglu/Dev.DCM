using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Dev.DCM.Web;

[Dependency(ReplaceServices = true)]
public class DCMBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "DCM";
}
