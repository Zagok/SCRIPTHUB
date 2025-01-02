using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCRIPTHUB
{
    public partial class ucLinks : UserControl
    {
        public ucLinks()
        {
            InitializeComponent();
        }
        private void OpenUrl(string url)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            };
            Process.Start(startInfo);
        }

        private void btnTS_Click(object sender, EventArgs e)
        {

            OpenUrl("NOT AVAILABLE LINK");
        }
    }
}
