using System;
using System.Collections.Generic;
using System.Text;
using ABP.GettingStarted.Localization;
using Volo.Abp.Application.Services;

namespace ABP.GettingStarted;

/* Inherit your application services from this class.
 */
public abstract class GettingStartedAppService : ApplicationService
{
    protected GettingStartedAppService()
    {
        LocalizationResource = typeof(GettingStartedResource);
    }
}
