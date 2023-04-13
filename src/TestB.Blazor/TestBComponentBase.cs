using TestB.Localization;
using Volo.Abp.AspNetCore.Components;

namespace TestB.Blazor;

public abstract class TestBComponentBase : AbpComponentBase
{
    protected TestBComponentBase()
    {
        LocalizationResource = typeof(TestBResource);
    }
}
