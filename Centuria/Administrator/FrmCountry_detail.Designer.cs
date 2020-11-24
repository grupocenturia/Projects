namespace Administrator
{
    partial class FrmCountry_detail
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
            this.TxtIsoCode = new System.Windows.Forms.TextBox();
            this.LblIsoCode = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.LblName = new System.Windows.Forms.Label();
            this.CmdExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ChkEnabled
            // 
            this.ChkEnabled.AutoSize = true;
            this.ChkEnabled.Location = new System.Drawing.Point(12, 96);
            this.ChkEnabled.Name = "ChkEnabled";
            this.ChkEnabled.Size = new System.Drawing.Size(56, 17);
            this.ChkEnabled.TabIndex = 2;
            this.ChkEnabled.Text = "Activo";
            this.ChkEnabled.UseVisualStyleBackColor = true;
            // 
            // CmdSave
            // 
            this.CmdSave.Location = new System.Drawing.Point(406, 125);
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.Size = new System.Drawing.Size(80, 50);
            this.CmdSave.TabIndex = 3;
            this.CmdSave.Text = "Guardar";
            this.CmdSave.UseVisualStyleBackColor = false;
            this.CmdSave.Click += new System.EventHandler(this.CmdSave_Click);
            // 
            // TxtIsoCode
            // 
            this.TxtIsoCode.Location = new System.Drawing.Point(12, 70);
            this.TxtIsoCode.MaxLength = 100;
            this.TxtIsoCode.Name = "TxtIsoCode";
            this.TxtIsoCode.Size = new System.Drawing.Size(560, 20);
            this.TxtIsoCode.TabIndex = 1;
//            this.TxtIsoCode.TextChanged += new System.EventHandler(this.TxtIsoCode_TextChanged);
            // 
            // LblIsoCode
            // 
            this.LblIsoCode.AutoSize = true;
            this.LblIsoCode.Location = new System.Drawing.Point(12, 54);
            this.LblIsoCode.Name = "LblIsoCode";
            this.LblIsoCode.Size = new System.Drawing.Size(43, 13);
            this.LblIsoCode.TabIndex = 14;
            this.LblIsoCode.Text = "Codigo:";
            // 
            // TxtName
            // 
            this.TxtName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtName.Location = new System.Drawing.Point(12, 31);
            this.TxtName.MaxLength = 100;
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(560, 20);
            this.TxtName.TabIndex = 0;
//            this.TxtName.TextChanged += new System.EventHandler(this.TxtName_TextChanged);
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(12, 15);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(47, 13);
            this.LblName.TabIndex = 13;
            this.LblName.Text = "Nombre:";
            // 
            // CmdExit
            // 
            this.CmdExit.Location = new System.Drawing.Point(492, 125);
            this.CmdExit.Name = "CmdExit";
            this.CmdExit.Size = new System.Drawing.Size(80, 50);
            this.CmdExit.TabIndex = 4;
            this.CmdExit.Text = "Salir";
            this.CmdExit.UseVisualStyleBackColor = false;
            this.CmdExit.Click += new System.EventHandler(this.CmdExit_Click);
            // 
            // FrmCountry_detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 181);
            this.ControlBox = false;
            this.Controls.Add(this.ChkEnabled);
            this.Controls.Add(this.CmdSave);
            this.Controls.Add(this.TxtIsoCode);
            this.Controls.Add(this.LblIsoCode);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.CmdExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCountry_detail";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "País";
            this.Load += new System.EventHandler(this.FrmCountry_detail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ChkEnabled;
        private System.Windows.Forms.Button CmdSave;
        private System.Windows.Forms.TextBox TxtIsoCode;
        private System.Windows.Forms.Label LblIsoCode;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Button CmdExit;
    }
}
