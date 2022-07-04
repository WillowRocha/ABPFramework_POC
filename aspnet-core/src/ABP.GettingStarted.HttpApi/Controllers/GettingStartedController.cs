using ABP.GettingStarted.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace ABP.GettingStarted.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class GettingStartedController : AbpControllerBase
{
    protected GettingStartedController()
    {
        LocalizationResource = typeof(GettingStartedResource);
    }
}
