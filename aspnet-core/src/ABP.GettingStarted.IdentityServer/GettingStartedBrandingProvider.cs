using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace ABP.GettingStarted;

[Dependency(ReplaceServices = true)]
public class GettingStartedBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "GettingStarted";
}
