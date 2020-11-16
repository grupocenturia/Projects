namespace Centuria
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
            this.PanLogo = new System.Windows.Forms.SplitContainer();
            this.LnkChangePassword = new System.Windows.Forms.LinkLabel();
            this.ImgLogo = new System.Windows.Forms.PictureBox();
            this.PanCompany = new System.Windows.Forms.SplitContainer();
            this.CmbCompany = new System.Windows.Forms.ComboBox();
            this.LblCompany = new System.Windows.Forms.Label();
            this.PanModule = new System.Windows.Forms.FlowLayoutPanel();
            this.BarStatus = new System.Windows.Forms.StatusStrip();
            this.LblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.PanLogo)).BeginInit();
            this.PanLogo.Panel1.SuspendLayout();
            this.PanLogo.Panel2.SuspendLayout();
            this.PanLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanCompany)).BeginInit();
            this.PanCompany.Panel1.SuspendLayout();
            this.PanCompany.Panel2.SuspendLayout();
            this.PanCompany.SuspendLayout();
            this.BarStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanLogo
            // 
            this.PanLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanLogo.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.PanLogo.IsSplitterFixed = true;
            this.PanLogo.Location = new System.Drawing.Point(0, 0);
            this.PanLogo.MinimumSize = new System.Drawing.Size(200, 200);
            this.PanLogo.Name = "PanLogo";
            this.PanLogo.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // PanLogo.Panel1
            // 
            this.PanLogo.Panel1.Controls.Add(this.LnkChangePassword);
            this.PanLogo.Panel1.Controls.Add(this.ImgLogo);
            this.PanLogo.Panel1.Padding = new System.Windows.Forms.Padding(10);
            this.PanLogo.Panel1MinSize = 90;
            // 
            // PanLogo.Panel2
            // 
            this.PanLogo.Panel2.Controls.Add(this.PanCompany);
            this.PanLogo.Size = new System.Drawing.Size(884, 561);
            this.PanLogo.SplitterDistance = 90;
            this.PanLogo.TabIndex = 0;
            this.PanLogo.TabStop = false;
            // 
            // LnkChangePassword
            // 
            this.LnkChangePassword.AutoSize = true;
            this.LnkChangePassword.Dock = System.Windows.Forms.DockStyle.Right;
            this.LnkChangePassword.Location = new System.Drawing.Point(773, 10);
            this.LnkChangePassword.Name = "LnkChangePassword";
            this.LnkChangePassword.Size = new System.Drawing.Size(101, 13);
            this.LnkChangePassword.TabIndex = 0;
            this.LnkChangePassword.TabStop = true;
            this.LnkChangePassword.Text = "Cambiar contraseña";
            this.LnkChangePassword.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.LnkChangePassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkChangePassword_LinkClicked);
            // 
            // ImgLogo
            // 
            this.ImgLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImgLogo.Image = global::Centuria.Properties.Resources.ImgLogo;
            this.ImgLogo.Location = new System.Drawing.Point(10, 10);
            this.ImgLogo.Name = "ImgLogo";
            this.ImgLogo.Size = new System.Drawing.Size(864, 70);
            this.ImgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgLogo.TabIndex = 8;
            this.ImgLogo.TabStop = false;
            // 
            // PanCompany
            // 
            this.PanCompany.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanCompany.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.PanCompany.IsSplitterFixed = true;
            this.PanCompany.Location = new System.Drawing.Point(0, 0);
            this.PanCompany.Name = "PanCompany";
            this.PanCompany.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // PanCompany.Panel1
            // 
            this.PanCompany.Panel1.Controls.Add(this.CmbCompany);
            this.PanCompany.Panel1.Controls.Add(this.LblCompany);
            this.PanCompany.Panel1.Padding = new System.Windows.Forms.Padding(10);
            this.PanCompany.Panel1MinSize = 80;
            // 
            // PanCompany.Panel2
            // 
            this.PanCompany.Panel2.Controls.Add(this.PanModule);
            this.PanCompany.Panel2.Padding = new System.Windows.Forms.Padding(10);
            this.PanCompany.Size = new System.Drawing.Size(884, 467);
            this.PanCompany.SplitterDistance = 80;
            this.PanCompany.TabIndex = 0;
            this.PanCompany.TabStop = false;
            // 
            // CmbCompany
            // 
            this.CmbCompany.BackColor = System.Drawing.Color.White;
            this.CmbCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbCompany.FormattingEnabled = true;
            this.CmbCompany.Location = new System.Drawing.Point(244, 35);
            this.CmbCompany.Name = "CmbCompany";
            this.CmbCompany.Size = new System.Drawing.Size(400, 24);
            this.CmbCompany.TabIndex = 1;
            this.CmbCompany.SelectedIndexChanged += new System.EventHandler(this.CmbCompany_SelectedIndexChanged);
            // 
            // LblCompany
            // 
            this.LblCompany.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCompany.Location = new System.Drawing.Point(10, 10);
            this.LblCompany.Name = "LblCompany";
            this.LblCompany.Size = new System.Drawing.Size(864, 22);
            this.LblCompany.TabIndex = 2;
            this.LblCompany.Text = "Seleccione empresa";
            this.LblCompany.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanModule
            // 
            this.PanModule.AutoScroll = true;
            this.PanModule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanModule.Location = new System.Drawing.Point(10, 10);
            this.PanModule.Name = "PanModule";
            this.PanModule.Padding = new System.Windows.Forms.Padding(10);
            this.PanModule.Size = new System.Drawing.Size(864, 363);
            this.PanModule.TabIndex = 0;
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
            // FrmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.BarStatus);
            this.Controls.Add(this.PanLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "FrmMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMainMenu_FormClosing);
            this.Load += new System.EventHandler(this.FrmMainMenu_Load);
            this.Resize += new System.EventHandler(this.FrmMainMenu_Resize);
            this.PanLogo.Panel1.ResumeLayout(false);
            this.PanLogo.Panel1.PerformLayout();
            this.PanLogo.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PanLogo)).EndInit();
            this.PanLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImgLogo)).EndInit();
            this.PanCompany.Panel1.ResumeLayout(false);
            this.PanCompany.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PanCompany)).EndInit();
            this.PanCompany.ResumeLayout(false);
            this.BarStatus.ResumeLayout(false);
            this.BarStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer PanLogo;
        private System.Windows.Forms.PictureBox ImgLogo;
        private System.Windows.Forms.SplitContainer PanCompany;
        private System.Windows.Forms.Label LblCompany;
        private System.Windows.Forms.ComboBox CmbCompany;
        private System.Windows.Forms.FlowLayoutPanel PanModule;
        private System.Windows.Forms.LinkLabel LnkChangePassword;
        private System.Windows.Forms.StatusStrip BarStatus;
        private System.Windows.Forms.ToolStripStatusLabel LblStatus;
    }
}