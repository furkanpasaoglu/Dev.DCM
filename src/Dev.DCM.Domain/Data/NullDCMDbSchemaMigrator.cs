using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Dev.DCM.Data;

/* This is used if database provider does't define
 * IDCMDbSchemaMigrator implementation.
 */
public class NullDCMDbSchemaMigrator : IDCMDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
