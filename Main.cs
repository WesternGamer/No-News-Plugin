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
        public Main()
        {
            Harmony harmony = new Harmony("No_News_Plugin");
            harmony.PatchAll();
        }
        /// <summary>
        /// Unused
        /// </summary>
        public void Dispose()
        { 
        }

        public void Init(object gameInstance)
        {
            
        }

        public void Update()
        {
        }
    }
}
