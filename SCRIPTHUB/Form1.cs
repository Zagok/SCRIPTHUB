using System;
using System.Diagnostics;
using System.Drawing.Drawing2D;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace SCRIPTHUB
{
    public partial class Form1 : Form
    {
        private bool maximized = false;
        private Rectangle normalBounds;
        public Form1()
        {
            InitializeComponent();
            normalBounds = this.Bounds;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        public int xClick = 0, yClick = 0;

        private void Form1_Load(object sender, EventArgs e)
        {

            ucHome1.BringToFront();
            tmrUTC.Enabled = true;
        }


        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)

            { xClick = e.X; yClick = e.Y; }

            else

            { this.Left = this.Left + (e.X - xClick); this.Top = this.Top + (e.Y - yClick); }
        }

        private void tmrUTC_Tick(object sender, EventArgs e)
        {
            lblUTC.Text = DateTime.UtcNow.ToString();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ucHome1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ucLinks1.BringToFront();
        }

        private void btnHMCs_Click(object sender, EventArgs e)
        {
            uchmc1.BringToFront();
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized && maximized)
            {
                int taskbarHeight = Screen.PrimaryScreen.Bounds.Height - Screen.PrimaryScreen.WorkingArea.Height;
                int taskbarWidth = Screen.PrimaryScreen.Bounds.Width - Screen.PrimaryScreen.WorkingArea.Width;
                this.Bounds = new Rectangle(new Point(0, 0), new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height));
            }
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                normalBounds = this.Bounds;
                Screen screen = Screen.FromControl(this);
                int taskbarHeight = Screen.PrimaryScreen.Bounds.Height - Screen.PrimaryScreen.WorkingArea.Height;
                int taskbarWidth = Screen.PrimaryScreen.Bounds.Width - Screen.PrimaryScreen.WorkingArea.Width;
                int maxWidth = screen.WorkingArea.Width - taskbarWidth;
                int maxHeight = screen.WorkingArea.Height - taskbarHeight;
                this.MaximumSize = new Size(maxWidth, maxHeight);
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.MaximumSize = new Size(0, 0);
                this.Bounds = normalBounds;
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnStatusDS8K_Click(object sender, EventArgs e)
        {
            ucStatusdS8k1.BringToFront();
        }

        private void btnStatusPre_Click(object sender, EventArgs e)
        {
            ucStatusPre1.BringToFront();
        }
    }
}
