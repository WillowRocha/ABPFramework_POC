using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace ABP.GettingStarted.Data;

/* This is used if database provider does't define
 * IGettingStartedDbSchemaMigrator implementation.
 */
public class NullGettingStartedDbSchemaMigrator : IGettingStartedDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
