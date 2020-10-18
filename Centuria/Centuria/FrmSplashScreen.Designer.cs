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
            this.LblMessage = new System.Windows.Forms.Label();
            this.BgwProcess = new System.ComponentModel.BackgroundWorker();
            this.ImgSplashScreen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImgSplashScreen)).BeginInit();
            this.SuspendLayout();
            // 
            // LblMessage
            // 
            this.LblMessage.BackColor = System.Drawing.Color.Transparent;
            this.LblMessage.ForeColor = System.Drawing.Color.DimGray;
            this.LblMessage.Location = new System.Drawing.Point(12, 394);
            this.LblMessage.Name = "LblMessage";
            this.LblMessage.Size = new System.Drawing.Size(735, 20);
            this.LblMessage.TabIndex = 0;
            this.LblMessage.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.LblMessage.Visible = false;
            // 
            // BgwProcess
            // 
            this.BgwProcess.WorkerReportsProgress = true;
            this.BgwProcess.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BgwProcess_DoWork);
            this.BgwProcess.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BgwProcess_ProgressChanged);
            this.BgwProcess.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BgwProcess_RunWorkerCompleted);
            // 
            // ImgSplashScreen
            // 
            this.ImgSplashScreen.BackColor = System.Drawing.Color.Transparent;
            this.ImgSplashScreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImgSplashScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImgSplashScreen.Image = global::Centuria.Properties.Resources.GifSplashScreen;
            this.ImgSplashScreen.Location = new System.Drawing.Point(0, 0);
            this.ImgSplashScreen.Margin = new System.Windows.Forms.Padding(0);
            this.ImgSplashScreen.Name = "ImgSplashScreen";
            this.ImgSplashScreen.Size = new System.Drawing.Size(759, 423);
            this.ImgSplashScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgSplashScreen.TabIndex = 0;
            this.ImgSplashScreen.TabStop = false;
            // 
            // FrmSplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(759, 423);
            this.ControlBox = false;
            this.Controls.Add(this.LblMessage);
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
        private System.Windows.Forms.PictureBox ImgSplashScreen;
        private System.Windows.Forms.Label LblMessage;
        private System.ComponentModel.BackgroundWorker BgwProcess;
    }
}