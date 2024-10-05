using Volo.Abp.Modularity;

namespace Dev.DCM;

/* Inherit from this class for your domain layer tests. */
public abstract class DCMDomainTestBase<TStartupModule> : DCMTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
