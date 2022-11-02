using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace AventHub;

[Dependency(ReplaceServices = true)]
public class AventHubBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "AventHub";
}
