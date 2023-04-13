using System;
using System.Collections.Generic;
using System.Text;
using TestB.Localization;
using Volo.Abp.Application.Services;

namespace TestB;

/* Inherit your application services from this class.
 */
public abstract class TestBAppService : ApplicationService
{
    protected TestBAppService()
    {
        LocalizationResource = typeof(TestBResource);
    }
}
