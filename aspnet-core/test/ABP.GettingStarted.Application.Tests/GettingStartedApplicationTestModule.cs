using Volo.Abp.Modularity;

namespace ABP.GettingStarted;

[DependsOn(
    typeof(GettingStartedApplicationModule),
    typeof(GettingStartedDomainTestModule)
    )]
public class GettingStartedApplicationTestModule : AbpModule
{

}
