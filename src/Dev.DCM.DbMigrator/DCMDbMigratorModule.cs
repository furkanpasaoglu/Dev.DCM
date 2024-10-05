using Dev.DCM.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Dev.DCM.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(DCMEntityFrameworkCoreModule),
    typeof(DCMApplicationContractsModule)
    )]
public class DCMDbMigratorModule : AbpModule
{
}
