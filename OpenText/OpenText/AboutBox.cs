using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Diagnostics;

namespace OpenText
{
    public partial class AboutBox : Form
    {
        public AboutBox()
        {
            InitializeComponent();
            LoadVersion();

        }

        public void LoadVersion()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(assembly.Location);
            string currentVersion = versionInfo.FileVersion;

            lbVersion.Text = "Version: " + currentVersion;
        }
    }
}
