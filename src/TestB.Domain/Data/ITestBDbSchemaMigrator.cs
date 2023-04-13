using System.Threading.Tasks;

namespace TestB.Data;

public interface ITestBDbSchemaMigrator
{
    Task MigrateAsync();
}
