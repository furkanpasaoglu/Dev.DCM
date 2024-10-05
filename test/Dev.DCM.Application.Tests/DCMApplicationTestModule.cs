using Volo.Abp.Modularity;

namespace Dev.DCM;

[DependsOn(
    typeof(DCMApplicationModule),
    typeof(DCMDomainTestModule)
)]
public class DCMApplicationTestModule : AbpModule
{

}
