using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace TestB;

[Dependency(ReplaceServices = true)]
public class TestBBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "TestB";
}
