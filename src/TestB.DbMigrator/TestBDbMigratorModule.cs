using TestB.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace TestB.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(TestBEntityFrameworkCoreModule),
    typeof(TestBApplicationContractsModule)
    )]
public class TestBDbMigratorModule : AbpModule
{

}
