using Photon.Hive.Plugin;
using System;
using System.Collections.Generic;

namespace MyFirstPlugin
{
    public class MyFirstPlugin : PluginBase
    {
        public override string Name => "MyFirstPlugin";
        private IPluginLogger pluginLogger;

        public override bool SetupInstance(IPluginHost host, Dictionary<string, string> config, out string errorMsg)
        {
            pluginLogger = host.CreateLogger(Name);
            return base.SetupInstance(host, config, out errorMsg);
        }

        public override void OnCreateGame(ICreateGameCallInfo info)
        {
            //a log message in a callback
            pluginLogger.InfoFormat("***************************************************");
            pluginLogger.InfoFormat("OOOOOOOOOOOOOOOOOOOOOOOOOnCreateGame {0} by user {1}", info.Request.GameId, info.UserId);
            pluginLogger.InfoFormat("***************************************************");

            info.Continue();
        }

    }
}
