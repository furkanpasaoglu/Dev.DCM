using System.Threading.Tasks;

namespace Dev.DCM.Data;

public interface IDCMDbSchemaMigrator
{
    Task MigrateAsync();
}
