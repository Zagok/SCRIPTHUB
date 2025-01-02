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
    public partial class ucStatusPre : UserControl
    {
        public ucStatusPre()
        {
            InitializeComponent();
        }

        private async void ucStatusPre_Load(object sender, EventArgs e)
        {
            await wvPre.EnsureCoreWebView2Async(null);
            wvPre.CoreWebView2.Navigate("");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (wvPre.CoreWebView2.CanGoBack)
            {
                wvPre.CoreWebView2.GoBack();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (wvPre.CoreWebView2.CanGoForward)
            {
                wvPre.CoreWebView2.GoForward();
            }
        }
    }
}
