namespace SCRIPTHUB
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel2 = new Panel();
            btnMaximize = new PictureBox();
            lblUTC = new Label();
            label1 = new Label();
            btnMinimize = new PictureBox();
            btnExit = new PictureBox();
            label5 = new Label();
            label4 = new Label();
            slideBar = new Panel();
            btnStatusPre = new Button();
            btnStatusDS8K = new Button();
            btnHMCs = new Button();
            button1 = new Button();
            btnHome = new Button();
            tmrUTC = new System.Windows.Forms.Timer(components);
            ucLinks1 = new ucLinks();
            ucHome1 = new ucHome();
            uchmc1 = new ucHMC();
            ucStatusdS8k1 = new ucStatusDS8K();
            ucStatusPre1 = new ucStatusPre();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnMaximize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnExit).BeginInit();
            slideBar.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(23, 24, 28);
            panel2.Controls.Add(btnMaximize);
            panel2.Controls.Add(lblUTC);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btnMinimize);
            panel2.Controls.Add(btnExit);
            panel2.Dock = DockStyle.Top;
            panel2.ForeColor = Color.White;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1289, 46);
            panel2.TabIndex = 0;
            panel2.MouseMove += panel2_MouseMove;
            // 
            // btnMaximize
            // 
            btnMaximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximize.BackColor = Color.Transparent;
            btnMaximize.Cursor = Cursors.Hand;
            btnMaximize.Image = Properties.Resources.icons8_full_screen_100;
            btnMaximize.Location = new Point(1202, 7);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(30, 30);
            btnMaximize.SizeMode = PictureBoxSizeMode.Zoom;
            btnMaximize.TabIndex = 12;
            btnMaximize.TabStop = false;
            btnMaximize.Click += btnMaximize_Click;
            // 
            // lblUTC
            // 
            lblUTC.AutoSize = true;
            lblUTC.BackColor = Color.Transparent;
            lblUTC.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUTC.ForeColor = Color.FromArgb(192, 192, 0);
            lblUTC.Location = new Point(64, 9);
            lblUTC.Name = "lblUTC";
            lblUTC.Size = new Size(24, 28);
            lblUTC.TabIndex = 11;
            lblUTC.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(192, 192, 0);
            label1.Location = new Point(6, 9);
            label1.Name = "label1";
            label1.Size = new Size(69, 28);
            label1.TabIndex = 7;
            label1.Text = "UTC - ";
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.BackColor = Color.Transparent;
            btnMinimize.Cursor = Cursors.Hand;
            btnMinimize.Image = Properties.Resources.Minimize2;
            btnMinimize.Location = new Point(1156, 7);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(30, 30);
            btnMinimize.SizeMode = PictureBoxSizeMode.Zoom;
            btnMinimize.TabIndex = 3;
            btnMinimize.TabStop = false;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit.BackColor = Color.Transparent;
            btnExit.Cursor = Cursors.Hand;
            btnExit.Image = Properties.Resources.Exit2;
            btnExit.Location = new Point(1247, 7);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(30, 30);
            btnExit.SizeMode = PictureBoxSizeMode.Zoom;
            btnExit.TabIndex = 2;
            btnExit.TabStop = false;
            btnExit.Click += btnExit_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(25, 13);
            label5.Name = "label5";
            label5.Size = new Size(173, 28);
            label5.TabIndex = 5;
            label5.Text = "IBM - DS8K TEST";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("IBM Plex Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(549, 745);
            label4.Name = "label4";
            label4.Size = new Size(450, 27);
            label4.TabIndex = 5;
            label4.Text = "Author - Ing. Carlos Antonio Zambrano Gómez";
            // 
            // slideBar
            // 
            slideBar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            slideBar.BackColor = Color.FromArgb(35, 39, 42);
            slideBar.Controls.Add(btnStatusPre);
            slideBar.Controls.Add(btnStatusDS8K);
            slideBar.Controls.Add(btnHMCs);
            slideBar.Controls.Add(button1);
            slideBar.Controls.Add(label5);
            slideBar.Controls.Add(btnHome);
            slideBar.Location = new Point(0, 46);
            slideBar.MinimumSize = new Size(50, 726);
            slideBar.Name = "slideBar";
            slideBar.Size = new Size(230, 726);
            slideBar.TabIndex = 7;
            // 
            // btnStatusPre
            // 
            btnStatusPre.BackColor = Color.FromArgb(35, 39, 42);
            btnStatusPre.FlatAppearance.BorderSize = 0;
            btnStatusPre.FlatStyle = FlatStyle.Flat;
            btnStatusPre.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStatusPre.ForeColor = Color.Transparent;
            btnStatusPre.Image = Properties.Resources.icons8_indicador_de_progreso_30;
            btnStatusPre.ImageAlign = ContentAlignment.MiddleLeft;
            btnStatusPre.Location = new Point(0, 568);
            btnStatusPre.Name = "btnStatusPre";
            btnStatusPre.Padding = new Padding(6, 0, 0, 0);
            btnStatusPre.Size = new Size(230, 52);
            btnStatusPre.TabIndex = 11;
            btnStatusPre.Text = "      STATUS PRETEST";
            btnStatusPre.TextAlign = ContentAlignment.MiddleLeft;
            btnStatusPre.UseVisualStyleBackColor = false;
            btnStatusPre.Click += btnStatusPre_Click;
            // 
            // btnStatusDS8K
            // 
            btnStatusDS8K.BackColor = Color.FromArgb(35, 39, 42);
            btnStatusDS8K.FlatAppearance.BorderSize = 0;
            btnStatusDS8K.FlatStyle = FlatStyle.Flat;
            btnStatusDS8K.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStatusDS8K.ForeColor = Color.Transparent;
            btnStatusDS8K.Image = Properties.Resources.icons8_status_30;
            btnStatusDS8K.ImageAlign = ContentAlignment.MiddleLeft;
            btnStatusDS8K.Location = new Point(0, 460);
            btnStatusDS8K.Name = "btnStatusDS8K";
            btnStatusDS8K.Padding = new Padding(6, 0, 0, 0);
            btnStatusDS8K.Size = new Size(230, 52);
            btnStatusDS8K.TabIndex = 10;
            btnStatusDS8K.Text = "       STATUS DS8K";
            btnStatusDS8K.TextAlign = ContentAlignment.MiddleLeft;
            btnStatusDS8K.UseVisualStyleBackColor = false;
            btnStatusDS8K.Click += btnStatusDS8K_Click;
            // 
            // btnHMCs
            // 
            btnHMCs.BackColor = Color.FromArgb(35, 39, 42);
            btnHMCs.FlatAppearance.BorderSize = 0;
            btnHMCs.FlatStyle = FlatStyle.Flat;
            btnHMCs.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHMCs.ForeColor = Color.Transparent;
            btnHMCs.Image = Properties.Resources.icons8_imac_30_1_;
            btnHMCs.ImageAlign = ContentAlignment.MiddleLeft;
            btnHMCs.Location = new Point(0, 353);
            btnHMCs.Name = "btnHMCs";
            btnHMCs.Padding = new Padding(6, 0, 0, 0);
            btnHMCs.Size = new Size(230, 52);
            btnHMCs.TabIndex = 9;
            btnHMCs.Text = "             HMC";
            btnHMCs.TextAlign = ContentAlignment.MiddleLeft;
            btnHMCs.UseVisualStyleBackColor = false;
            btnHMCs.Click += btnHMCs_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(35, 39, 42);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Transparent;
            button1.Image = Properties.Resources.icons8_external_link_30;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(0, 252);
            button1.Name = "button1";
            button1.Padding = new Padding(8, 0, 0, 0);
            button1.Size = new Size(230, 52);
            button1.TabIndex = 8;
            button1.Text = "            LINKS";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.FromArgb(35, 39, 42);
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHome.ForeColor = Color.Transparent;
            btnHome.Image = Properties.Resources.Home30px;
            btnHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnHome.Location = new Point(0, 147);
            btnHome.Name = "btnHome";
            btnHome.Padding = new Padding(5, 0, 0, 0);
            btnHome.Size = new Size(230, 52);
            btnHome.TabIndex = 8;
            btnHome.Text = "            HOME";
            btnHome.TextAlign = ContentAlignment.MiddleLeft;
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // tmrUTC
            // 
            tmrUTC.Interval = 1;
            tmrUTC.Tick += tmrUTC_Tick;
            // 
            // ucLinks1
            // 
            ucLinks1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ucLinks1.AutoScroll = true;
            ucLinks1.BackColor = Color.FromArgb(232, 234, 238);
            ucLinks1.Location = new Point(258, 68);
            ucLinks1.MinimumSize = new Size(1005, 674);
            ucLinks1.Name = "ucLinks1";
            ucLinks1.Size = new Size(1005, 674);
            ucLinks1.TabIndex = 9;
            // 
            // ucHome1
            // 
            ucHome1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ucHome1.BackColor = Color.FromArgb(232, 234, 238);
            ucHome1.Location = new Point(258, 68);
            ucHome1.MinimumSize = new Size(1005, 674);
            ucHome1.Name = "ucHome1";
            ucHome1.Size = new Size(1005, 674);
            ucHome1.TabIndex = 11;
            // 
            // uchmc1
            // 
            uchmc1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            uchmc1.BackColor = Color.FromArgb(232, 234, 238);
            uchmc1.Location = new Point(258, 68);
            uchmc1.Name = "uchmc1";
            uchmc1.Size = new Size(1005, 674);
            uchmc1.TabIndex = 12;
            // 
            // ucStatusdS8k1
            // 
            ucStatusdS8k1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ucStatusdS8k1.BackColor = Color.FromArgb(232, 234, 238);
            ucStatusdS8k1.Location = new Point(258, 68);
            ucStatusdS8k1.Name = "ucStatusdS8k1";
            ucStatusdS8k1.Size = new Size(1005, 674);
            ucStatusdS8k1.TabIndex = 13;
            // 
            // ucStatusPre1
            // 
            ucStatusPre1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ucStatusPre1.BackColor = Color.FromArgb(232, 234, 238);
            ucStatusPre1.Location = new Point(258, 68);
            ucStatusPre1.Name = "ucStatusPre1";
            ucStatusPre1.Size = new Size(1005, 674);
            ucStatusPre1.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(182, 183, 187);
            ClientSize = new Size(1289, 772);
            Controls.Add(ucStatusPre1);
            Controls.Add(ucStatusdS8k1);
            Controls.Add(uchmc1);
            Controls.Add(ucHome1);
            Controls.Add(label4);
            Controls.Add(slideBar);
            Controls.Add(panel2);
            Controls.Add(ucLinks1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Scripts HUB";
            Load += Form1_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnMaximize).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnExit).EndInit();
            slideBar.ResumeLayout(false);
            slideBar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel2;
        private PictureBox btnExit;
        private PictureBox btnMinimize;
        private Label label5;
        private Label label4;
        private Panel slideBar;
        private Button btnHome;
        private Button button1;
        private Label label1;
        private Label lblUTC;
        private System.Windows.Forms.Timer tmrUTC;
        private ucLinks ucLinks1;
        private Button btnHMCs;
        private PictureBox btnMaximize;
        private ucHome ucHome1;
        private ucHMC uchmc1;
        private Button btnStatusPre;
        private Button btnStatusDS8K;
        private ucStatusDS8K ucStatusdS8k1;
        private ucStatusPre ucStatusPre1;
    }
}
