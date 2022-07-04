using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ABP.GettingStarted.Data;
using Volo.Abp.DependencyInjection;

namespace ABP.GettingStarted.EntityFrameworkCore;

public class EntityFrameworkCoreGettingStartedDbSchemaMigrator
    : IGettingStartedDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreGettingStartedDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the GettingStartedDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<GettingStartedDbContext>()
            .Database
            .MigrateAsync();
    }
}
