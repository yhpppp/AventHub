using AventHub.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace AventHub;

[DependsOn(
    typeof(AventHubEntityFrameworkCoreTestModule)
    )]
public class AventHubDomainTestModule : AbpModule
{

}
