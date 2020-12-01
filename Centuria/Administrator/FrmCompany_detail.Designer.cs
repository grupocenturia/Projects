namespace Administrator
{
    partial class FrmCompany_detail
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
            this.ChkEnabled = new System.Windows.Forms.CheckBox();
            this.CmdSave = new System.Windows.Forms.Button();
            this.TxtTradeName = new System.Windows.Forms.TextBox();
            this.LblTradeName = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.LblCompanyName = new System.Windows.Forms.Label();
            this.CmdExit = new System.Windows.Forms.Button();
            this.LblShortName = new System.Windows.Forms.Label();
            this.TxtShortName = new System.Windows.Forms.TextBox();
            this.LblDBName = new System.Windows.Forms.Label();
            this.TxtDBName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ChkEnabled
            // 
            this.ChkEnabled.AutoSize = true;
            this.ChkEnabled.Location = new System.Drawing.Point(10, 173);
            this.ChkEnabled.Name = "ChkEnabled";
            this.ChkEnabled.Size = new System.Drawing.Size(56, 17);
            this.ChkEnabled.TabIndex = 4;
            this.ChkEnabled.Text = "Activo";
            this.ChkEnabled.UseVisualStyleBackColor = true;
            this.ChkEnabled.CheckedChanged += new System.EventHandler(this.ChkEnabled_CheckedChanged);
            // 
            // CmdSave
            // 
            this.CmdSave.Location = new System.Drawing.Point(406, 190);
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.Size = new System.Drawing.Size(80, 50);
            this.CmdSave.TabIndex = 5;
            this.CmdSave.Text = "Guardar";
            this.CmdSave.UseVisualStyleBackColor = false;
            this.CmdSave.Click += new System.EventHandler(this.CmdSave_Click);
            // 
            // TxtTradeName
            // 
            this.TxtTradeName.Location = new System.Drawing.Point(12, 64);
            this.TxtTradeName.MaxLength = 100;
            this.TxtTradeName.Name = "TxtTradeName";
            this.TxtTradeName.Size = new System.Drawing.Size(560, 20);
            this.TxtTradeName.TabIndex = 1;
            this.TxtTradeName.Click += new System.EventHandler(this.TxtTradeName_Enter);
            // 
            // LblTradeName
            // 
            this.LblTradeName.AutoSize = true;
            this.LblTradeName.Location = new System.Drawing.Point(12, 48);
            this.LblTradeName.Name = "LblTradeName";
            this.LblTradeName.Size = new System.Drawing.Size(54, 13);
            this.LblTradeName.TabIndex = 14;
            this.LblTradeName.Text = "Comercio:";
            // 
            // TxtName
            // 
            this.TxtName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtName.Location = new System.Drawing.Point(12, 25);
            this.TxtName.MaxLength = 100;
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(560, 20);
            this.TxtName.TabIndex = 0;
            this.TxtName.Click += new System.EventHandler(this.TxtName_Enter);
            // 
            // LblCompanyName
            // 
            this.LblCompanyName.AutoSize = true;
            this.LblCompanyName.Location = new System.Drawing.Point(12, 9);
            this.LblCompanyName.Name = "LblCompanyName";
            this.LblCompanyName.Size = new System.Drawing.Size(111, 13);
            this.LblCompanyName.TabIndex = 7;
            this.LblCompanyName.Text = "Nombre de compañia:";
            // 
            // CmdExit
            // 
            this.CmdExit.Location = new System.Drawing.Point(492, 190);
            this.CmdExit.Name = "CmdExit";
            this.CmdExit.Size = new System.Drawing.Size(80, 50);
            this.CmdExit.TabIndex = 6;
            this.CmdExit.Text = "Salir";
            this.CmdExit.UseVisualStyleBackColor = false;
            this.CmdExit.Click += new System.EventHandler(this.CmdExit_Click);
            // 
            // LblShortName
            // 
            this.LblShortName.AutoSize = true;
            this.LblShortName.Location = new System.Drawing.Point(12, 87);
            this.LblShortName.Name = "LblShortName";
            this.LblShortName.Size = new System.Drawing.Size(72, 13);
            this.LblShortName.TabIndex = 15;
            this.LblShortName.Text = "Nombre Corto";
            // 
            // TxtShortName
            // 
            this.TxtShortName.Location = new System.Drawing.Point(12, 103);
            this.TxtShortName.MaxLength = 100;
            this.TxtShortName.Name = "TxtShortName";
            this.TxtShortName.Size = new System.Drawing.Size(560, 20);
            this.TxtShortName.TabIndex = 2;
            this.TxtShortName.Click += new System.EventHandler(this.TxtShortName_Enter);
            // 
            // LblDBName
            // 
            this.LblDBName.AutoSize = true;
            this.LblDBName.Location = new System.Drawing.Point(12, 126);
            this.LblDBName.Name = "LblDBName";
            this.LblDBName.Size = new System.Drawing.Size(75, 13);
            this.LblDBName.TabIndex = 17;
            this.LblDBName.Text = "Base de datos";
            // 
            // TxtDBName
            // 
            this.TxtDBName.Location = new System.Drawing.Point(12, 142);
            this.TxtDBName.MaxLength = 100;
            this.TxtDBName.Name = "TxtDBName";
            this.TxtDBName.Size = new System.Drawing.Size(560, 20);
            this.TxtDBName.TabIndex = 3;
            this.TxtDBName.Click += new System.EventHandler(this.TxtDBName_Enter);
            // 
            // FrmCompany_detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 252);
            this.ControlBox = false;
            this.Controls.Add(this.TxtDBName);
            this.Controls.Add(this.LblDBName);
            this.Controls.Add(this.TxtShortName);
            this.Controls.Add(this.LblShortName);
            this.Controls.Add(this.ChkEnabled);
            this.Controls.Add(this.CmdSave);
            this.Controls.Add(this.TxtTradeName);
            this.Controls.Add(this.LblTradeName);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.LblCompanyName);
            this.Controls.Add(this.CmdExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCompany_detail";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compañia";
            this.Load += new System.EventHandler(this.FrmCompany_detail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ChkEnabled;
        private System.Windows.Forms.Button CmdSave;
        private System.Windows.Forms.TextBox TxtTradeName;
        private System.Windows.Forms.Label LblTradeName;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label LblCompanyName;
        private System.Windows.Forms.Button CmdExit;
        private System.Windows.Forms.Label LblShortName;
        private System.Windows.Forms.TextBox TxtShortName;
        private System.Windows.Forms.Label LblDBName;
        private System.Windows.Forms.TextBox TxtDBName;
    }
}