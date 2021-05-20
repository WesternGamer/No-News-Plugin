using HarmonyLib;
using Sandbox.Game;
using VRage.Plugins;

namespace No_News_Plugin
{
    /// <summary>
    /// Where the plugin is started.
    /// </summary>
    public class Main : IPlugin
    {
        /// <summary>
        /// Unused
        /// </summary>
        public void Dispose()
        { 
        }
        /// <summary>
        /// Adds the patch of removing the DLC and News area.
        /// </summary>
        public void Init(object gameInstance)
        {
            //Starts an instance of Harmony
            Harmony harmony = new Harmony("No_News_Plugin");
            //Patches all patches in the plugin.
            harmony.PatchAll();
        }
        /// <summary>
        /// Unused
        /// </summary>
        public void Update()
        {
        }
    }
}
