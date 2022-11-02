using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using AventHub.Data;
using Volo.Abp.DependencyInjection;

namespace AventHub.EntityFrameworkCore;

public class EntityFrameworkCoreAventHubDbSchemaMigrator
    : IAventHubDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreAventHubDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the AventHubDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<AventHubDbContext>()
            .Database
            .MigrateAsync();
    }
}
