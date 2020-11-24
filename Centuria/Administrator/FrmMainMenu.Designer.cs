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
            this.OptStore = new System.Windows.Forms.ToolStripMenuItem();
            this.OptAction = new System.Windows.Forms.ToolStripMenuItem();
            this.BarStatus = new System.Windows.Forms.StatusStrip();
            this.LblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.OptOptionType = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuMainMenu.SuspendLayout();
            this.BarStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // MnuMainMenu
            // 
            this.MnuMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuSettings});
            this.MnuMainMenu.Location = new System.Drawing.Point(0, 0);
            this.MnuMainMenu.Name = "MnuMainMenu";
            this.MnuMainMenu.Size = new System.Drawing.Size(884, 24);
            this.MnuMainMenu.TabIndex = 0;
            this.MnuMainMenu.Text = "menuStrip1";
            // 
            // MnuSettings
            // 
            this.MnuSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OptUser,
            this.OptModule,
            this.OptProfile,
            this.OptStore,
            this.OptAction,
            this.OptOptionType});
            this.MnuSettings.Name = "MnuSettings";
            this.MnuSettings.Size = new System.Drawing.Size(95, 20);
            this.MnuSettings.Text = "Configuración";
            // 
            // OptUser
            // 
            this.OptUser.Name = "OptUser";
            this.OptUser.Size = new System.Drawing.Size(180, 22);
            this.OptUser.Text = "Usuario";
            this.OptUser.Click += new System.EventHandler(this.OptUser_Click);
            // 
            // OptModule
            // 
            this.OptModule.Name = "OptModule";
            this.OptModule.Size = new System.Drawing.Size(180, 22);
            this.OptModule.Text = "Módulo";
            this.OptModule.Click += new System.EventHandler(this.OptModule_Click);
            // 
            // OptProfile
            // 
            this.OptProfile.Name = "OptProfile";
            this.OptProfile.Size = new System.Drawing.Size(180, 22);
            this.OptProfile.Text = "Perfil";
            this.OptProfile.Click += new System.EventHandler(this.OptProfile_Click);
            // 
            // OptStore
            // 
            this.OptStore.Name = "OptStore";
            this.OptStore.Size = new System.Drawing.Size(180, 22);
            this.OptStore.Text = "Sucursal";
            this.OptStore.Click += new System.EventHandler(this.OptStore_Click);
            // 
            // OptAction
            // 
            this.OptAction.Name = "OptAction";
            this.OptAction.Size = new System.Drawing.Size(180, 22);
            this.OptAction.Text = "Acciones para Log";
            this.OptAction.Click += new System.EventHandler(this.OptAction_Click);
            // 
            // BarStatus
            // 
            this.BarStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LblStatus});
            this.BarStatus.Location = new System.Drawing.Point(0, 539);
            this.BarStatus.Name = "BarStatus";
            this.BarStatus.Size = new System.Drawing.Size(884, 22);
            this.BarStatus.TabIndex = 1;
            // 
            // LblStatus
            // 
            this.LblStatus.BackColor = System.Drawing.Color.Transparent;
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // OptOptionType
            // 
            this.OptOptionType.Name = "OptOptionType";
            this.OptOptionType.Size = new System.Drawing.Size(180, 22);
            this.OptOptionType.Text = "Opciones";
            this.OptOptionType.Click += new System.EventHandler(this.OptOptionType_Click);
            // 
            // FrmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.BarStatus);
            this.Controls.Add(this.MnuMainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MnuMainMenu;
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
        private System.Windows.Forms.ToolStripMenuItem OptStore;
        private System.Windows.Forms.ToolStripMenuItem OptAction;
        private System.Windows.Forms.ToolStripMenuItem OptOptionType;
    }
}

