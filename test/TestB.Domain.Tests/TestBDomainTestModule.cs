using TestB.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace TestB;

[DependsOn(
    typeof(TestBEntityFrameworkCoreTestModule)
    )]
public class TestBDomainTestModule : AbpModule
{

}
