namespace Centuria
{
    partial class FrmSplashScreen
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TmrExit = new System.Windows.Forms.Timer(this.components);
            this.ImgSplashScreen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImgSplashScreen)).BeginInit();
            this.SuspendLayout();
            // 
            // TmrExit
            // 
            this.TmrExit.Interval = 6000;
            this.TmrExit.Tick += new System.EventHandler(this.TmrExit_Tick);
            // 
            // ImgSplashScreen
            // 
            this.ImgSplashScreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImgSplashScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImgSplashScreen.Image = global::Centuria.Properties.Resources.GifSplashScreen;
            this.ImgSplashScreen.Location = new System.Drawing.Point(0, 0);
            this.ImgSplashScreen.Name = "ImgSplashScreen";
            this.ImgSplashScreen.Size = new System.Drawing.Size(444, 244);
            this.ImgSplashScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgSplashScreen.TabIndex = 0;
            this.ImgSplashScreen.TabStop = false;
            // 
            // FrmSplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(444, 244);
            this.ControlBox = false;
            this.Controls.Add(this.ImgSplashScreen);
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSplashScreen";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmSplashScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImgSplashScreen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer TmrExit;
        private System.Windows.Forms.PictureBox ImgSplashScreen;
    }
}