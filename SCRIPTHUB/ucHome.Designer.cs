namespace SCRIPTHUB
{
    partial class ucHome
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel3 = new Panel();
            panel6 = new Panel();
            label1 = new Label();
            btnSRCs = new PictureBox();
            panel4 = new Panel();
            panel7 = new Panel();
            label2 = new Label();
            btnDTHB = new PictureBox();
            panel5 = new Panel();
            panel8 = new Panel();
            label3 = new Label();
            btnAB = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            label4 = new Label();
            btnFirewall = new PictureBox();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnSRCs).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnDTHB).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnAB).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnFirewall).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top;
            panel3.BackColor = Color.FromArgb(35, 39, 42);
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(btnSRCs);
            panel3.Location = new Point(127, 113);
            panel3.Name = "panel3";
            panel3.Size = new Size(280, 180);
            panel3.TabIndex = 3;
            // 
            // panel6
            // 
            panel6.BackColor = Color.LightSeaGreen;
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(276, 20);
            panel6.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightSeaGreen;
            label1.Location = new Point(60, 139);
            label1.Name = "label1";
            label1.Size = new Size(145, 28);
            label1.TabIndex = 4;
            label1.Text = "Obtener SRC's";
            // 
            // btnSRCs
            // 
            btnSRCs.BackColor = Color.FromArgb(38, 38, 38);
            btnSRCs.Cursor = Cursors.Hand;
            btnSRCs.Image = Properties.Resources.icons8_descargar_100;
            btnSRCs.Location = new Point(98, 32);
            btnSRCs.Name = "btnSRCs";
            btnSRCs.Size = new Size(80, 90);
            btnSRCs.SizeMode = PictureBoxSizeMode.Zoom;
            btnSRCs.TabIndex = 3;
            btnSRCs.TabStop = false;
            btnSRCs.Click += btnSRCs_Click;
            btnSRCs.MouseLeave += btnSRCs_MouseLeave;
            btnSRCs.MouseHover += btnSRCs_MouseHover;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top;
            panel4.BackColor = Color.FromArgb(35, 39, 42);
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(panel7);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(btnDTHB);
            panel4.Location = new Point(597, 115);
            panel4.Name = "panel4";
            panel4.Size = new Size(280, 180);
            panel4.TabIndex = 6;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(78, 132, 255);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(0, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(276, 20);
            panel7.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(78, 132, 255);
            label2.Location = new Point(11, 141);
            label2.Name = "label2";
            label2.Size = new Size(256, 28);
            label2.TabIndex = 4;
            label2.Text = "Down Time - Hoja Bundle\r\n";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnDTHB
            // 
            btnDTHB.Cursor = Cursors.Hand;
            btnDTHB.Image = Properties.Resources.icons8_time_limit_64;
            btnDTHB.Location = new Point(101, 32);
            btnDTHB.Name = "btnDTHB";
            btnDTHB.Size = new Size(80, 90);
            btnDTHB.SizeMode = PictureBoxSizeMode.Zoom;
            btnDTHB.TabIndex = 3;
            btnDTHB.TabStop = false;
            btnDTHB.Click += btnDTHB_Click;
            btnDTHB.MouseLeave += btnDTHB_MouseLeave;
            btnDTHB.MouseHover += btnDTHB_MouseHover;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(35, 39, 42);
            panel5.BorderStyle = BorderStyle.Fixed3D;
            panel5.Controls.Add(panel8);
            panel5.Controls.Add(label3);
            panel5.Controls.Add(btnAB);
            panel5.Location = new Point(722, 491);
            panel5.Name = "panel5";
            panel5.Size = new Size(280, 180);
            panel5.TabIndex = 7;
            panel5.Visible = false;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(230, 0, 0);
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(0, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(276, 20);
            panel8.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(230, 0, 0);
            label3.Location = new Point(64, 141);
            label3.Name = "label3";
            label3.Size = new Size(165, 28);
            label3.TabIndex = 4;
            label3.Text = "Apagado Bonito";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAB
            // 
            btnAB.Cursor = Cursors.Hand;
            btnAB.Image = Properties.Resources.icons8_shutdown_100;
            btnAB.Location = new Point(100, 32);
            btnAB.Name = "btnAB";
            btnAB.Size = new Size(80, 90);
            btnAB.SizeMode = PictureBoxSizeMode.Zoom;
            btnAB.TabIndex = 3;
            btnAB.TabStop = false;
            btnAB.MouseLeave += btnAB_MouseLeave;
            btnAB.MouseHover += btnAB_MouseHover;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.BackColor = Color.FromArgb(35, 39, 42);
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btnFirewall);
            panel1.Location = new Point(364, 396);
            panel1.Name = "panel1";
            panel1.Size = new Size(280, 180);
            panel1.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkOrange;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(276, 20);
            panel2.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkOrange;
            label4.Location = new Point(60, 139);
            label4.Name = "label4";
            label4.Size = new Size(165, 28);
            label4.TabIndex = 4;
            label4.Text = "Romper Firewall";
            // 
            // btnFirewall
            // 
            btnFirewall.BackColor = Color.FromArgb(38, 38, 38);
            btnFirewall.Cursor = Cursors.Hand;
            btnFirewall.Image = Properties.Resources.icons8_firewall_70;
            btnFirewall.Location = new Point(98, 32);
            btnFirewall.Name = "btnFirewall";
            btnFirewall.Size = new Size(80, 90);
            btnFirewall.SizeMode = PictureBoxSizeMode.Zoom;
            btnFirewall.TabIndex = 3;
            btnFirewall.TabStop = false;
            btnFirewall.Click += btnFirewall_Click;
            btnFirewall.MouseLeave += btnFirewall_MouseLeave;
            btnFirewall.MouseHover += btnFirewall_MouseHover;
            // 
            // ucHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(232, 234, 238);
            Controls.Add(panel1);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            MinimumSize = new Size(1005, 674);
            Name = "ucHome";
            Size = new Size(1005, 674);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnSRCs).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnDTHB).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnAB).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnFirewall).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Panel panel6;
        private Label label1;
        private PictureBox btnSRCs;
        private Panel panel4;
        private Panel panel7;
        private Label label2;
        private PictureBox btnDTHB;
        private Panel panel5;
        private Panel panel8;
        private Label label3;
        private PictureBox btnAB;
        private Panel panel1;
        private Panel panel2;
        private Label label4;
        private PictureBox btnFirewall;
    }
}
