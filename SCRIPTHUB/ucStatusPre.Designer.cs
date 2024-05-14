namespace SCRIPTHUB
{
    partial class ucStatusPre
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
            btnNext = new Button();
            panel1 = new Panel();
            btnBack = new Button();
            wvPre = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)wvPre).BeginInit();
            SuspendLayout();
            // 
            // btnNext
            // 
            btnNext.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNext.BackColor = Color.FromArgb(23, 24, 28);
            btnNext.FlatAppearance.BorderSize = 0;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNext.ForeColor = Color.FromArgb(192, 192, 0);
            btnNext.Image = Properties.Resources.icons8_gira_a_la_derecha_30;
            btnNext.ImageAlign = ContentAlignment.MiddleRight;
            btnNext.Location = new Point(852, 0);
            btnNext.Name = "btnNext";
            btnNext.Padding = new Padding(5, 0, 0, 0);
            btnNext.Size = new Size(153, 38);
            btnNext.TabIndex = 15;
            btnNext.Text = "GO NEXT";
            btnNext.TextAlign = ContentAlignment.MiddleLeft;
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(23, 24, 28);
            panel1.Location = new Point(150, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(703, 38);
            panel1.TabIndex = 14;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(23, 24, 28);
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.FromArgb(192, 192, 0);
            btnBack.Image = Properties.Resources.icons8_gira_a_la_izquierda_30;
            btnBack.ImageAlign = ContentAlignment.MiddleLeft;
            btnBack.Location = new Point(0, 0);
            btnBack.Name = "btnBack";
            btnBack.Padding = new Padding(5, 0, 0, 0);
            btnBack.Size = new Size(153, 38);
            btnBack.TabIndex = 13;
            btnBack.Text = "      GO BACK";
            btnBack.TextAlign = ContentAlignment.MiddleLeft;
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // wvPre
            // 
            wvPre.AllowExternalDrop = true;
            wvPre.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            wvPre.CreationProperties = null;
            wvPre.DefaultBackgroundColor = Color.White;
            wvPre.Location = new Point(0, 38);
            wvPre.Name = "wvPre";
            wvPre.Size = new Size(1005, 636);
            wvPre.TabIndex = 12;
            wvPre.ZoomFactor = 1D;
            // 
            // ucStatusPre
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(232, 234, 238);
            Controls.Add(btnNext);
            Controls.Add(panel1);
            Controls.Add(btnBack);
            Controls.Add(wvPre);
            Name = "ucStatusPre";
            Size = new Size(1005, 674);
            Load += ucStatusPre_Load;
            ((System.ComponentModel.ISupportInitialize)wvPre).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnNext;
        private Panel panel1;
        private Button btnBack;
        private Microsoft.Web.WebView2.WinForms.WebView2 wvPre;
    }
}
