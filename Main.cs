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

        public void Init(object gameInstance)
        {
            MyPerGameSettings.GUI.MainMenu = typeof(MyModifiedMainMenu);
        }

        public void Update()
        {
            MyPerGameSettings.GUI.MainMenu = typeof(MyModifiedMainMenu);
        }
    }
}
