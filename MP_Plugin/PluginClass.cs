/*
This is a sample plugin frame work
 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MissionPlanner;

namespace MP_Plugin
{
    public class PluginClass : MissionPlanner.Plugin.Plugin
    {
        public override string Name
        {
            get { return "Plugin Name"; }
        }

        public override string Version
        {
            get { return System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString(); }
        }

        public override string Author
        {
            get { return "Author Name"; }
        }

        public override bool Init()
        {
            return true;
        }

        public override bool Loaded()
        {
            MissionPlanner.Plugin.PluginHost Host = new MissionPlanner.Plugin.PluginHost();
            PluginForm Plugin_UI = new PluginForm(Host);
            Plugin_UI.Show();
            return true;
        }


        public override bool Exit()
        {
            return true;
        }
    }
}
