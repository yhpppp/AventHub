using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace AventHub.Data;

/* This is used if database provider does't define
 * IAventHubDbSchemaMigrator implementation.
 */
public class NullAventHubDbSchemaMigrator : IAventHubDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
