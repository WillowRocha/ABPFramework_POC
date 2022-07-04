using Volo.Abp.Settings;

namespace ABP.GettingStarted.Settings;

public class GettingStartedSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(GettingStartedSettings.MySetting1));
    }
}
