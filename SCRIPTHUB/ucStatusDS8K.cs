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
    public partial class ucStatusDS8K : UserControl
    {
        public ucStatusDS8K()
        {
            InitializeComponent();
        }

        private async void ucStatusDS8K_Load(object sender, EventArgs e)
        {
            await wvDS8K.EnsureCoreWebView2Async(null);
            wvDS8K.CoreWebView2.Navigate("");
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (wvDS8K.CoreWebView2.CanGoForward)
            {
                wvDS8K.CoreWebView2.GoForward();
            }
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            if (wvDS8K.CoreWebView2.CanGoBack)
            {
                wvDS8K.CoreWebView2.GoBack();
            }
        }
    }
}
