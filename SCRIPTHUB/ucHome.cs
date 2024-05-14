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
    public partial class ucHome : UserControl
    {
        public ucHome()
        {
            InitializeComponent();
        }

        private void btnSRCs_Click(object sender, EventArgs e)
        {
            string downloadsPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Downloads";
            string scriptPath = downloadsPath + "\\EVENTSHMC.sh";

            // Convertir la ruta de Windows a una ruta de bash
            string scriptPathUnix = scriptPath.Replace("\\", "/").Replace("C:", "/mnt/c");

            // Verificar si el archivo
            if (System.IO.File.Exists(scriptPath))
            {
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = "bash.exe";
                startInfo.Arguments = $"\"{scriptPathUnix}\"";
                startInfo.UseShellExecute = true;

                using (Process process = new Process())
                {
                    process.StartInfo = startInfo;
                    process.Start();
                }
            }
            else
            {
                MessageBox.Show("El archivo de script no existe en la carpeta de descargas.");
            }
        }

        private void btnDTHB_Click(object sender, EventArgs e)
        {
            string downloadsPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Downloads";
            string scriptPath = downloadsPath + "\\endtest1.0.py";

            // Convertir la ruta de Windows a una ruta de bash
            string scriptPathUnix = scriptPath.Replace("\\", "/").Replace("C:", "/mnt/c");

            // Verificar si el archivo
            if (System.IO.File.Exists(scriptPath))
            {
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = "bash.exe";
                startInfo.Arguments = $"-c \"python3 '{scriptPathUnix}'; exec bash\"";
                startInfo.UseShellExecute = true;

                using (Process process = new Process())
                {
                    process.StartInfo = startInfo;
                    process.Start();
                }
            }
            else
            {
                MessageBox.Show("El archivo de script no existe en la carpeta de descargas.");
            }
        }

        private void btnSRCs_MouseHover(object sender, EventArgs e)
        {
            if (btnSRCs.Width == 80)
            {
                btnSRCs.Location = new Point(btnSRCs.Location.X - 5, btnSRCs.Location.Y);
                btnSRCs.Size = new Size(90, 100);
            }
        }

        private void btnSRCs_MouseLeave(object sender, EventArgs e)
        {
            if (btnSRCs.Width == 90)
            {
                btnSRCs.Location = new Point(btnSRCs.Location.X + 5, btnSRCs.Location.Y);
                btnSRCs.Size = new Size(80, 90);
            }
        }

        private void btnDTHB_MouseHover(object sender, EventArgs e)
        {
            if (btnDTHB.Width == 80)
            {
                btnDTHB.Location = new Point(btnDTHB.Location.X - 5, btnDTHB.Location.Y);
                btnDTHB.Size = new Size(90, 100);
            }
        }

        private void btnDTHB_MouseLeave(object sender, EventArgs e)
        {
            if (btnDTHB.Width == 90)
            {
                btnDTHB.Location = new Point(btnDTHB.Location.X + 5, btnDTHB.Location.Y);
                btnDTHB.Size = new Size(80, 90);
            }
        }

        private void btnAB_MouseHover(object sender, EventArgs e)
        {
            if (btnAB.Width == 80)
            {
                btnAB.Location = new Point(btnAB.Location.X - 5, btnAB.Location.Y);
                btnAB.Size = new Size(90, 100);
            }
        }

        private void btnAB_MouseLeave(object sender, EventArgs e)
        {
            if (btnAB.Width == 90)
            {
                btnAB.Location = new Point(btnAB.Location.X + 5, btnAB.Location.Y);
                btnAB.Size = new Size(80, 90);
            }
        }

        private void btnFirewall_Click(object sender, EventArgs e)
        {
            string downloadsPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Downloads";
            string scriptPath = downloadsPath + "\\firewall.vbs";

            // Verificar si el archivo
            if (System.IO.File.Exists(scriptPath))
            {
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = "cscript.exe";
                startInfo.Arguments = $"\"{scriptPath}\"";
                startInfo.UseShellExecute = true; // Esto permitirá que la salida se muestre en la terminal

                using (Process process = new Process())
                {
                    process.StartInfo = startInfo;
                    process.Start();
                }
            }
            else
            {
                MessageBox.Show("El archivo de script no existe en la carpeta de descargas.");
            }
        }

        private void btnFirewall_MouseHover(object sender, EventArgs e)
        {
            if (btnFirewall.Width == 80)
            {
                btnFirewall.Location = new Point(btnAB.Location.X - 5, btnAB.Location.Y);
                btnFirewall.Size = new Size(90, 100);
            }
        }

        private void btnFirewall_MouseLeave(object sender, EventArgs e)
        {
            if (btnFirewall.Width == 90)
            {
                btnFirewall.Location = new Point(btnAB.Location.X + 5, btnAB.Location.Y);
                btnFirewall.Size = new Size(80, 90);
            }
        }
    }
}
