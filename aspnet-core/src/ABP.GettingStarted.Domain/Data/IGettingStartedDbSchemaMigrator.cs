using System.Threading.Tasks;

namespace ABP.GettingStarted.Data;

public interface IGettingStartedDbSchemaMigrator
{
    Task MigrateAsync();
}
