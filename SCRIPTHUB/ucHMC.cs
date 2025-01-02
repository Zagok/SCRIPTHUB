using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCRIPTHUB
{
    public partial class ucHMC : UserControl
    {
        public ucHMC()
        {
            InitializeComponent();
        }

        private async void ucHMC_Load(object sender, EventArgs e)
        {
            await wvHMC.EnsureCoreWebView2Async(null);
            wvHMC.CoreWebView2.Navigate("");
            
        }
    }
}
