using Microsoft.Extensions.DependencyInjection;
using NodeBlock.Engine.Interop.Plugin;


namespace NodeBlock.Plugin.MachineLearning
{
    public class Plugin : BasePlugin
    {

        public static bool PluginAlive = true;

        public static ServiceProvider Services;

        private static readonly NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        public override void Load()
        {

        }

    }
}
