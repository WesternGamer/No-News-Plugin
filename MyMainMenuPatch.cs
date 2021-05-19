using HarmonyLib;
using SpaceEngineers.Game.GUI;

namespace No_News_Plugin
{
    /// <summary>
    /// Where the main menu is actually patched. Thanks to austinvaness for making this code for me!
    /// </summary>
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