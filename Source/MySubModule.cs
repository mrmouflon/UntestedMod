using TaleWorlds.Core;
using TaleWorlds.MountAndBlade;
using TaleWorlds.CampaignSystem;
using TaleWorlds.Library;

namespace UntestedMod
{
    public class MySubModule : MBSubModuleBase
    {
        protected override void OnGameStart(Game game, IGameStarter gameStarter)
        {
            if (game.GameType is Campaign && gameStarter is CampaignGameStarter campaignGameStarter)
            {
                campaignGameStarter.LoadGameTexts(BasePath.Name + "Modules/UntestedMod/ModuleData/untested_strings.xml");
            }
        }
    }
}
