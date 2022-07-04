using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace ABP.GettingStarted;

[Dependency(ReplaceServices = true)]
public class GettingStartedBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "GettingStarted";
}
