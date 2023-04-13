using Volo.Abp.Modularity;

namespace TestB;

[DependsOn(
    typeof(TestBApplicationModule),
    typeof(TestBDomainTestModule)
    )]
public class TestBApplicationTestModule : AbpModule
{

}
