using TestB.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace TestB.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class TestBController : AbpControllerBase
{
    protected TestBController()
    {
        LocalizationResource = typeof(TestBResource);
    }
}
