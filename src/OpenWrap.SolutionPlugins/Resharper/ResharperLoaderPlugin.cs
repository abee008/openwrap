using System;
using System.Collections.Generic;

namespace OpenWrap.VisualStudio.Resharper
{
    public class ResharperLoaderPlugin : IDisposable
    {
        static readonly IDictionary<Version, string> VersionToLoaders = new Dictionary<Version, string>
        {
            { new Version("4.5.1288.2"), "OpenWrap.Resharper.PluginManager, OpenWrap.Resharper.v450" },
            { new Version("5.0.1659.36"), "OpenWrap.Resharper.PluginManager, OpenWrap.Resharper.v500" },
            { new Version("5.1.1727.12"), "OpenWrap.Resharper.PluginManager, OpenWrap.Resharper.v510" }
        };
        public ResharperLoaderPlugin()
        {
            var vsAppDomain = AppDomain.CurrentDomain.GetData("openwrap.shell.appdomain") as AppDomain;
            Console.WriteLine("AppDomain found = " + vsAppDomain != null);
            if (vsAppDomain == null) return;
            
         }
        public void Dispose()
        {
            
        }
    }
}