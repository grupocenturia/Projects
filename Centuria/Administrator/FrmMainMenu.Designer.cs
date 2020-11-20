namespace Administrator
{
    partial class FrmMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainMenu));
            this.MnuMainMenu = new System.Windows.Forms.MenuStrip();
            this.MnuSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.OptUser = new System.Windows.Forms.ToolStripMenuItem();
            this.OptModule = new System.Windows.Forms.ToolStripMenuItem();
            this.OptProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.BarStatus = new System.Windows.Forms.StatusStrip();
            this.LblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.OptLanguage = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuMainMenu.SuspendLayout();
            this.BarStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // MnuMainMenu
            // 
            this.MnuMainMenu.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.MnuMainMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MnuMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuSettings});
            this.MnuMainMenu.Location = new System.Drawing.Point(0, 0);
            this.MnuMainMenu.Name = "MnuMainMenu";
            this.MnuMainMenu.Size = new System.Drawing.Size(1326, 35);
            this.MnuMainMenu.TabIndex = 0;
            this.MnuMainMenu.Text = "menuStrip1";
            // 
            // MnuSettings
            // 
            this.MnuSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OptUser,
            this.OptModule,
            this.OptProfile,
            this.OptLanguage});
            this.MnuSettings.Name = "MnuSettings";
            this.MnuSettings.Size = new System.Drawing.Size(139, 29);
            this.MnuSettings.Text = "Configuración";
            // 
            // OptUser
            // 
            this.OptUser.Name = "OptUser";
            this.OptUser.Size = new System.Drawing.Size(270, 34);
            this.OptUser.Text = "Usuario";
            this.OptUser.Click += new System.EventHandler(this.OptUser_Click);
            // 
            // OptModule
            // 
            this.OptModule.Name = "OptModule";
            this.OptModule.Size = new System.Drawing.Size(270, 34);
            this.OptModule.Text = "Módulo";
            this.OptModule.Click += new System.EventHandler(this.OptModule_Click);
            // 
            // OptProfile
            // 
            this.OptProfile.Name = "OptProfile";
            this.OptProfile.Size = new System.Drawing.Size(270, 34);
            this.OptProfile.Text = "Perfil";
            this.OptProfile.Click += new System.EventHandler(this.OptProfile_Click);
            // 
            // BarStatus
            // 
            this.BarStatus.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.BarStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LblStatus});
            this.BarStatus.Location = new System.Drawing.Point(0, 841);
            this.BarStatus.Name = "BarStatus";
            this.BarStatus.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.BarStatus.Size = new System.Drawing.Size(1326, 22);
            this.BarStatus.TabIndex = 1;
            // 
            // LblStatus
            // 
            this.LblStatus.BackColor = System.Drawing.Color.Transparent;
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(0, 15);
            // 
            // OptLanguage
            // 
            this.OptLanguage.Name = "OptLanguage";
            this.OptLanguage.Size = new System.Drawing.Size(270, 34);
            this.OptLanguage.Text = "Lenguaje";
            this.OptLanguage.Click += new System.EventHandler(this.OptLanguage_Click);
            // 
            // FrmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1326, 863);
            this.Controls.Add(this.BarStatus);
            this.Controls.Add(this.MnuMainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MnuMainMenu;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMainMenu_Load);
            this.MnuMainMenu.ResumeLayout(false);
            this.MnuMainMenu.PerformLayout();
            this.BarStatus.ResumeLayout(false);
            this.BarStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MnuMainMenu;
        private System.Windows.Forms.ToolStripMenuItem MnuSettings;
        private System.Windows.Forms.ToolStripMenuItem OptUser;
        private System.Windows.Forms.StatusStrip BarStatus;
        private System.Windows.Forms.ToolStripStatusLabel LblStatus;
        private System.Windows.Forms.ToolStripMenuItem OptModule;
        private System.Windows.Forms.ToolStripMenuItem OptProfile;
        private System.Windows.Forms.ToolStripMenuItem OptLanguage;
    }
}

