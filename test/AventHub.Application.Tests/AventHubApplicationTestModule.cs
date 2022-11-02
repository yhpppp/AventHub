using Volo.Abp.Modularity;

namespace AventHub;

[DependsOn(
    typeof(AventHubApplicationModule),
    typeof(AventHubDomainTestModule)
    )]
public class AventHubApplicationTestModule : AbpModule
{

}
