using HarmonyLib;
using SpaceEngineers.Game.GUI;

namespace No_News_Plugin
{
	internal class MyMainMenuPatch
	{
        [HarmonyPatch(typeof(MyGuiScreenMainMenu), "CreateRightSection")]
        public class Patch_MainMenu
        {
            public static bool Prefix()
            {
                return false;
            }
        }
    }
}