using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace TestB.Data;

/* This is used if database provider does't define
 * ITestBDbSchemaMigrator implementation.
 */
public class NullTestBDbSchemaMigrator : ITestBDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
