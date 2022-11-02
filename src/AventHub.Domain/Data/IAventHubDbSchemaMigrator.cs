using System.Threading.Tasks;

namespace AventHub.Data;

public interface IAventHubDbSchemaMigrator
{
    Task MigrateAsync();
}
