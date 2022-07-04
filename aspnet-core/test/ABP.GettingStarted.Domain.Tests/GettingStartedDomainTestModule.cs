using ABP.GettingStarted.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace ABP.GettingStarted;

[DependsOn(
    typeof(GettingStartedEntityFrameworkCoreTestModule)
    )]
public class GettingStartedDomainTestModule : AbpModule
{

}
