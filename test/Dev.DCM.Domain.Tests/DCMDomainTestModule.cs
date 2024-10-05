using Volo.Abp.Modularity;

namespace Dev.DCM;

[DependsOn(
    typeof(DCMDomainModule),
    typeof(DCMTestBaseModule)
)]
public class DCMDomainTestModule : AbpModule
{

}
