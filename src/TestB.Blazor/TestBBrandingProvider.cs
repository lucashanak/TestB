using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace TestB.Blazor;

[Dependency(ReplaceServices = true)]
public class TestBBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "TestB";
}
