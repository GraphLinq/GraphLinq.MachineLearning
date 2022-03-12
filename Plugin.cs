using NodeBlock.Engine;
using NodeBlock.Engine.Interop;
using NodeBlock.Engine.Interop.Plugin;
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Concurrent;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;


namespace NodeBlock.Plugin.MachineLearning
{
    public class Plugin : BasePlugin
    {

        public static bool PluginAlive = true;

        public static ServiceProvider Services;

        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        public override void Load()
        {

        }

    }
}
