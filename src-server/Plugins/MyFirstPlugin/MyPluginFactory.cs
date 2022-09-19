using Photon.Hive.Plugin;


namespace MyFirstPlugin
{
    class MyPluginFactory : PluginFactoryBase
    {
        public override IGamePlugin CreatePlugin(string pluginName)
        {
            return new MyFirstPlugin();
        }
    }
}
