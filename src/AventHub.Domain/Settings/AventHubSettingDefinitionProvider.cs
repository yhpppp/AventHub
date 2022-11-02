using Volo.Abp.Settings;

namespace AventHub.Settings;

public class AventHubSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(AventHubSettings.MySetting1));
    }
}
