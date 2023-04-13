using Volo.Abp.Settings;

namespace TestB.Settings;

public class TestBSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(TestBSettings.MySetting1));
    }
}
