using Volo.Abp.Modularity;

namespace Dev.DCM;

public abstract class DCMApplicationTestBase<TStartupModule> : DCMTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
