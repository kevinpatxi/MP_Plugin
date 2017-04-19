using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MP_Plugin
{
    public partial class PluginForm : Form
    {
        MissionPlanner.Plugin.PluginHost MP_Host;

        public PluginForm(MissionPlanner.Plugin.PluginHost Host)
        {
            this.MP_Host = Host;
            InitializeComponent();
        }
    }
}
