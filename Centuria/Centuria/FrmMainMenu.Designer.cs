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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainMenu));
            this.CmbCompany = new System.Windows.Forms.ComboBox();
            this.TtpAccounting = new System.Windows.Forms.ToolTip(this.components);
            this.TtpInventory = new System.Windows.Forms.ToolTip(this.components);
            this.LklAccounting = new System.Windows.Forms.LinkLabel();
            this.LblAccounting = new System.Windows.Forms.Label();
            this.LblInventory = new System.Windows.Forms.Label();
            this.LblAccountsReceivable = new System.Windows.Forms.Label();
            this.LblAccountsPayable = new System.Windows.Forms.Label();
            this.LblInvoice = new System.Windows.Forms.Label();
            this.LblPayrolleRegister = new System.Windows.Forms.Label();
            this.LblCustomers = new System.Windows.Forms.Label();
            this.LblAssets = new System.Windows.Forms.Label();
            this.PtbConfiguration = new System.Windows.Forms.PictureBox();
            this.PtbAssets = new System.Windows.Forms.PictureBox();
            this.PtbAccountsPayable = new System.Windows.Forms.PictureBox();
            this.PtbInvoice = new System.Windows.Forms.PictureBox();
            this.PtbCustomers = new System.Windows.Forms.PictureBox();
            this.LblConfiguration = new System.Windows.Forms.Label();
            this.PtbPayrolRegister = new System.Windows.Forms.PictureBox();
            this.PtbAccounting = new System.Windows.Forms.PictureBox();
            this.PtbInventory = new System.Windows.Forms.PictureBox();
            this.PtbAccountsReceivable = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PtbConfiguration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbAssets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbAccountsPayable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbInvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbPayrolRegister)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbAccounting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbAccountsReceivable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CmbCompany
            // 
            this.CmbCompany.AccessibleRole = System.Windows.Forms.AccessibleRole.ComboBox;
            this.CmbCompany.FormattingEnabled = true;
            this.CmbCompany.Items.AddRange(new object[] {
            "FMLN",
            "ARENA",
            "NUEVAS IDEAS"});
            this.CmbCompany.Location = new System.Drawing.Point(492, 97);
            this.CmbCompany.Name = "CmbCompany";
            this.CmbCompany.Size = new System.Drawing.Size(257, 21);
            this.CmbCompany.TabIndex = 0;
            // 
            // TtpAccounting
            // 
            this.TtpAccounting.IsBalloon = true;
            this.TtpAccounting.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.TtpAccounting.ToolTipTitle = "Modulo de Contabilidad";
            // 
            // TtpInventory
            // 
            this.TtpInventory.IsBalloon = true;
            this.TtpInventory.ToolTipTitle = "Modulo de Inventario";
            // 
            // LklAccounting
            // 
            this.LklAccounting.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.LklAccounting.ActiveLinkColor = System.Drawing.Color.DarkBlue;
            this.LklAccounting.AutoSize = true;
            this.LklAccounting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LklAccounting.Location = new System.Drawing.Point(296, 195);
            this.LklAccounting.Name = "LklAccounting";
            this.LklAccounting.Size = new System.Drawing.Size(0, 13);
            this.LklAccounting.TabIndex = 9;
            this.LklAccounting.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LklAccounting_LinkClicked);
            // 
            // LblAccounting
            // 
            this.LblAccounting.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.LblAccounting.AutoSize = true;
            this.LblAccounting.Location = new System.Drawing.Point(416, 142);
            this.LblAccounting.Name = "LblAccounting";
            this.LblAccounting.Size = new System.Drawing.Size(65, 13);
            this.LblAccounting.TabIndex = 10;
            this.LblAccounting.Text = "Contabilidad";
            this.LblAccounting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblInventory
            // 
            this.LblInventory.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.LblInventory.AutoSize = true;
            this.LblInventory.Location = new System.Drawing.Point(649, 142);
            this.LblInventory.Name = "LblInventory";
            this.LblInventory.Size = new System.Drawing.Size(54, 13);
            this.LblInventory.TabIndex = 11;
            this.LblInventory.Text = "Inventario";
            this.LblInventory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblAccountsReceivable
            // 
            this.LblAccountsReceivable.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.LblAccountsReceivable.AutoSize = true;
            this.LblAccountsReceivable.Location = new System.Drawing.Point(869, 142);
            this.LblAccountsReceivable.Name = "LblAccountsReceivable";
            this.LblAccountsReceivable.Size = new System.Drawing.Size(98, 13);
            this.LblAccountsReceivable.TabIndex = 12;
            this.LblAccountsReceivable.Text = "Cuentas por Cobrar";
            this.LblAccountsReceivable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblAccountsPayable
            // 
            this.LblAccountsPayable.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.LblAccountsPayable.AutoSize = true;
            this.LblAccountsPayable.Location = new System.Drawing.Point(416, 247);
            this.LblAccountsPayable.Name = "LblAccountsPayable";
            this.LblAccountsPayable.Size = new System.Drawing.Size(94, 13);
            this.LblAccountsPayable.TabIndex = 13;
            this.LblAccountsPayable.Text = "Cuentas por pagar";
            this.LblAccountsPayable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblInvoice
            // 
            this.LblInvoice.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.LblInvoice.AutoSize = true;
            this.LblInvoice.Location = new System.Drawing.Point(649, 247);
            this.LblInvoice.Name = "LblInvoice";
            this.LblInvoice.Size = new System.Drawing.Size(42, 13);
            this.LblInvoice.TabIndex = 14;
            this.LblInvoice.Text = "Invoice";
            this.LblInvoice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblInvoice.Click += new System.EventHandler(this.label1_Click);
            // 
            // LblPayrolleRegister
            // 
            this.LblPayrolleRegister.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.LblPayrolleRegister.AutoSize = true;
            this.LblPayrolleRegister.Location = new System.Drawing.Point(869, 247);
            this.LblPayrolleRegister.Name = "LblPayrolleRegister";
            this.LblPayrolleRegister.Size = new System.Drawing.Size(103, 13);
            this.LblPayrolleRegister.TabIndex = 15;
            this.LblPayrolleRegister.Text = "Registro de nóminas";
            this.LblPayrolleRegister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblCustomers
            // 
            this.LblCustomers.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.LblCustomers.AutoSize = true;
            this.LblCustomers.Location = new System.Drawing.Point(416, 349);
            this.LblCustomers.Name = "LblCustomers";
            this.LblCustomers.Size = new System.Drawing.Size(44, 13);
            this.LblCustomers.TabIndex = 16;
            this.LblCustomers.Text = "Clientes";
            this.LblCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblCustomers.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // LblAssets
            // 
            this.LblAssets.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.LblAssets.AutoSize = true;
            this.LblAssets.Location = new System.Drawing.Point(649, 349);
            this.LblAssets.Name = "LblAssets";
            this.LblAssets.Size = new System.Drawing.Size(56, 13);
            this.LblAssets.TabIndex = 17;
            this.LblAssets.Text = "Activo Fijo";
            this.LblAssets.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblAssets.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // PtbConfiguration
            // 
            this.PtbConfiguration.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.PtbConfiguration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PtbConfiguration.Image = global::Centuria.Properties.Resources.Administrator;
            this.PtbConfiguration.InitialImage = null;
            this.PtbConfiguration.Location = new System.Drawing.Point(763, 349);
            this.PtbConfiguration.Name = "PtbConfiguration";
            this.PtbConfiguration.Size = new System.Drawing.Size(100, 50);
            this.PtbConfiguration.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PtbConfiguration.TabIndex = 18;
            this.PtbConfiguration.TabStop = false;
            // 
            // PtbAssets
            // 
            this.PtbAssets.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.PtbAssets.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PtbAssets.Image = global::Centuria.Properties.Resources.Assets;
            this.PtbAssets.InitialImage = null;
            this.PtbAssets.Location = new System.Drawing.Point(543, 349);
            this.PtbAssets.Name = "PtbAssets";
            this.PtbAssets.Size = new System.Drawing.Size(100, 50);
            this.PtbAssets.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PtbAssets.TabIndex = 6;
            this.PtbAssets.TabStop = false;
            // 
            // PtbAccountsPayable
            // 
            this.PtbAccountsPayable.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.PtbAccountsPayable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PtbAccountsPayable.Image = global::Centuria.Properties.Resources.Accounts_payable1;
            this.PtbAccountsPayable.InitialImage = null;
            this.PtbAccountsPayable.Location = new System.Drawing.Point(310, 247);
            this.PtbAccountsPayable.Name = "PtbAccountsPayable";
            this.PtbAccountsPayable.Size = new System.Drawing.Size(100, 50);
            this.PtbAccountsPayable.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PtbAccountsPayable.TabIndex = 4;
            this.PtbAccountsPayable.TabStop = false;
            // 
            // PtbInvoice
            // 
            this.PtbInvoice.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.PtbInvoice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PtbInvoice.Image = global::Centuria.Properties.Resources.invoice;
            this.PtbInvoice.InitialImage = null;
            this.PtbInvoice.Location = new System.Drawing.Point(543, 247);
            this.PtbInvoice.Name = "PtbInvoice";
            this.PtbInvoice.Size = new System.Drawing.Size(100, 50);
            this.PtbInvoice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PtbInvoice.TabIndex = 3;
            this.PtbInvoice.TabStop = false;
            // 
            // PtbCustomers
            // 
            this.PtbCustomers.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.PtbCustomers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PtbCustomers.Image = global::Centuria.Properties.Resources.Customers;
            this.PtbCustomers.InitialImage = null;
            this.PtbCustomers.Location = new System.Drawing.Point(310, 349);
            this.PtbCustomers.Name = "PtbCustomers";
            this.PtbCustomers.Size = new System.Drawing.Size(100, 50);
            this.PtbCustomers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PtbCustomers.TabIndex = 2;
            this.PtbCustomers.TabStop = false;
            // 
            // LblConfiguration
            // 
            this.LblConfiguration.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.LblConfiguration.AutoSize = true;
            this.LblConfiguration.Location = new System.Drawing.Point(869, 349);
            this.LblConfiguration.Name = "LblConfiguration";
            this.LblConfiguration.Size = new System.Drawing.Size(72, 13);
            this.LblConfiguration.TabIndex = 19;
            this.LblConfiguration.Text = "Configuración";
            this.LblConfiguration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PtbPayrolRegister
            // 
            this.PtbPayrolRegister.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.PtbPayrolRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PtbPayrolRegister.Image = global::Centuria.Properties.Resources.Payroll_Register;
            this.PtbPayrolRegister.InitialImage = null;
            this.PtbPayrolRegister.Location = new System.Drawing.Point(763, 247);
            this.PtbPayrolRegister.Name = "PtbPayrolRegister";
            this.PtbPayrolRegister.Size = new System.Drawing.Size(100, 50);
            this.PtbPayrolRegister.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PtbPayrolRegister.TabIndex = 5;
            this.PtbPayrolRegister.TabStop = false;
            // 
            // PtbAccounting
            // 
            this.PtbAccounting.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.PtbAccounting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PtbAccounting.Image = global::Centuria.Properties.Resources.accounting;
            this.PtbAccounting.InitialImage = null;
            this.PtbAccounting.Location = new System.Drawing.Point(310, 142);
            this.PtbAccounting.Name = "PtbAccounting";
            this.PtbAccounting.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.PtbAccounting.Size = new System.Drawing.Size(100, 50);
            this.PtbAccounting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PtbAccounting.TabIndex = 1;
            this.PtbAccounting.TabStop = false;
            // 
            // PtbInventory
            // 
            this.PtbInventory.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.PtbInventory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PtbInventory.Image = global::Centuria.Properties.Resources.inventory;
            this.PtbInventory.InitialImage = null;
            this.PtbInventory.Location = new System.Drawing.Point(543, 142);
            this.PtbInventory.Name = "PtbInventory";
            this.PtbInventory.Size = new System.Drawing.Size(100, 50);
            this.PtbInventory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PtbInventory.TabIndex = 8;
            this.PtbInventory.TabStop = false;
            // 
            // PtbAccountsReceivable
            // 
            this.PtbAccountsReceivable.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.PtbAccountsReceivable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PtbAccountsReceivable.Image = global::Centuria.Properties.Resources.Cuentas_x_cobrar;
            this.PtbAccountsReceivable.InitialImage = null;
            this.PtbAccountsReceivable.Location = new System.Drawing.Point(763, 142);
            this.PtbAccountsReceivable.Name = "PtbAccountsReceivable";
            this.PtbAccountsReceivable.Size = new System.Drawing.Size(100, 50);
            this.PtbAccountsReceivable.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PtbAccountsReceivable.TabIndex = 7;
            this.PtbAccountsReceivable.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Centuria.Properties.Resources.ImgLogo;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(492, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // FrmMainMenu
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PtbAccountsReceivable);
            this.Controls.Add(this.PtbInventory);
            this.Controls.Add(this.PtbPayrolRegister);
            this.Controls.Add(this.LblConfiguration);
            this.Controls.Add(this.PtbConfiguration);
            this.Controls.Add(this.LblAssets);
            this.Controls.Add(this.PtbAccounting);
            this.Controls.Add(this.LblCustomers);
            this.Controls.Add(this.LblPayrolleRegister);
            this.Controls.Add(this.LblInvoice);
            this.Controls.Add(this.LblAccountsPayable);
            this.Controls.Add(this.LblAccountsReceivable);
            this.Controls.Add(this.LblInventory);
            this.Controls.Add(this.LblAccounting);
            this.Controls.Add(this.LklAccounting);
            this.Controls.Add(this.PtbAssets);
            this.Controls.Add(this.PtbAccountsPayable);
            this.Controls.Add(this.PtbInvoice);
            this.Controls.Add(this.PtbCustomers);
            this.Controls.Add(this.CmbCompany);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Name = "FrmMainMenu";
            this.Text = "Menu Principal - Centuria";
            this.Load += new System.EventHandler(this.FrmMainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PtbConfiguration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbAssets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbAccountsPayable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbInvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbPayrolRegister)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbAccounting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbAccountsReceivable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbCompany;
        private System.Windows.Forms.PictureBox PtbCustomers;
        private System.Windows.Forms.PictureBox PtbInvoice;
        private System.Windows.Forms.PictureBox PtbAccountsPayable;
        private System.Windows.Forms.PictureBox PtbAssets;
        private System.Windows.Forms.ToolTip TtpAccounting;
        private System.Windows.Forms.ToolTip TtpInventory;
        private System.Windows.Forms.LinkLabel LklAccounting;
        private System.Windows.Forms.Label LblAccounting;
        private System.Windows.Forms.Label LblInventory;
        private System.Windows.Forms.Label LblAccountsReceivable;
        private System.Windows.Forms.Label LblAccountsPayable;
        private System.Windows.Forms.Label LblInvoice;
        private System.Windows.Forms.Label LblPayrolleRegister;
        private System.Windows.Forms.Label LblCustomers;
        private System.Windows.Forms.Label LblAssets;
        private System.Windows.Forms.PictureBox PtbConfiguration;
        private System.Windows.Forms.Label LblConfiguration;
        private System.Windows.Forms.PictureBox PtbPayrolRegister;
        private System.Windows.Forms.PictureBox PtbAccounting;
        private System.Windows.Forms.PictureBox PtbInventory;
        private System.Windows.Forms.PictureBox PtbAccountsReceivable;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}