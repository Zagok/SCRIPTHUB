namespace SCRIPTHUB
{
    partial class ucHMC
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
            wvHMC = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)wvHMC).BeginInit();
            SuspendLayout();
            // 
            // wvHMC
            // 
            wvHMC.AllowExternalDrop = true;
            wvHMC.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            wvHMC.CreationProperties = null;
            wvHMC.DefaultBackgroundColor = Color.FromArgb(232, 234, 238);
            wvHMC.Location = new Point(0, 0);
            wvHMC.Name = "wvHMC";
            wvHMC.Size = new Size(1005, 674);
            wvHMC.TabIndex = 0;
            wvHMC.ZoomFactor = 1D;
            // 
            // ucHMC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(232, 234, 238);
            Controls.Add(wvHMC);
            Name = "ucHMC";
            Size = new Size(1005, 674);
            Load += ucHMC_Load;
            ((System.ComponentModel.ISupportInitialize)wvHMC).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 wvHMC;
    }
}
