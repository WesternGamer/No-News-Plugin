using HarmonyLib;
using Sandbox.Game;
using System.Reflection;
using VRage.Plugins;

namespace NoNewsPlugin
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
            Harmony harmony = new Harmony("NoNewsPlugin");
            //Patches all patches in the plugin.
            harmony.PatchAll(Assembly.GetExecutingAssembly());
        }
        /// <summary>
        /// Unused
        /// </summary>
        public void Update()
        {
        }
    }
}
