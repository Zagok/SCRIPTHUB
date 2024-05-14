namespace SCRIPTHUB
{
    partial class ucStatusDS8K
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
            wvDS8K = new Microsoft.Web.WebView2.WinForms.WebView2();
            btnBack = new Button();
            panel1 = new Panel();
            btnNext = new Button();
            ((System.ComponentModel.ISupportInitialize)wvDS8K).BeginInit();
            SuspendLayout();
            // 
            // wvDS8K
            // 
            wvDS8K.AllowExternalDrop = true;
            wvDS8K.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            wvDS8K.CreationProperties = null;
            wvDS8K.DefaultBackgroundColor = Color.White;
            wvDS8K.Location = new Point(0, 38);
            wvDS8K.Name = "wvDS8K";
            wvDS8K.Size = new Size(1005, 636);
            wvDS8K.TabIndex = 0;
            wvDS8K.ZoomFactor = 1D;
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
            btnBack.TabIndex = 9;
            btnBack.Text = "      GO BACK";
            btnBack.TextAlign = ContentAlignment.MiddleLeft;
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click_1;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(23, 24, 28);
            panel1.Location = new Point(150, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(703, 38);
            panel1.TabIndex = 10;
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
            btnNext.TabIndex = 11;
            btnNext.Text = "GO NEXT";
            btnNext.TextAlign = ContentAlignment.MiddleLeft;
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // ucStatusDS8K
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(232, 234, 238);
            Controls.Add(btnNext);
            Controls.Add(panel1);
            Controls.Add(btnBack);
            Controls.Add(wvDS8K);
            Name = "ucStatusDS8K";
            Size = new Size(1005, 674);
            Load += ucStatusDS8K_Load;
            ((System.ComponentModel.ISupportInitialize)wvDS8K).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 wvDS8K;
        private Button btnBack;
        private Panel panel1;
        private Button btnNext;
    }
}
