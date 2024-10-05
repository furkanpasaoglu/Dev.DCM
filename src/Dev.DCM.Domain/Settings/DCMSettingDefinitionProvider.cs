using Volo.Abp.Settings;

namespace Dev.DCM.Settings;

public class DCMSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(DCMSettings.MySetting1));
    }
}
