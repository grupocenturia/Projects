namespace Administrator
{
    partial class FrmCurrency_detail
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
            this.TxtSymbol = new System.Windows.Forms.TextBox();
            this.LblSymbol = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ChkEnabled
            // 
            this.ChkEnabled.AutoSize = true;
            this.ChkEnabled.Location = new System.Drawing.Point(15, 138);
            this.ChkEnabled.Name = "ChkEnabled";
            this.ChkEnabled.Size = new System.Drawing.Size(56, 17);
            this.ChkEnabled.TabIndex = 17;
            this.ChkEnabled.Text = "Activo";
            this.ChkEnabled.UseVisualStyleBackColor = true;
            // 
            // CmdSave
            // 
            this.CmdSave.Location = new System.Drawing.Point(406, 171);
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.Size = new System.Drawing.Size(80, 50);
            this.CmdSave.TabIndex = 18;
            this.CmdSave.Text = "Guardar";
            this.CmdSave.UseVisualStyleBackColor = false;
            this.CmdSave.Click += new System.EventHandler(this.CmdSave_Click);
            // 
            // TxtIsoCode
            // 
            this.TxtIsoCode.Location = new System.Drawing.Point(12, 65);
            this.TxtIsoCode.MaxLength = 100;
            this.TxtIsoCode.Name = "TxtIsoCode";
            this.TxtIsoCode.Size = new System.Drawing.Size(560, 20);
            this.TxtIsoCode.TabIndex = 16;
            // 
            // LblIsoCode
            // 
            this.LblIsoCode.AutoSize = true;
            this.LblIsoCode.Location = new System.Drawing.Point(12, 49);
            this.LblIsoCode.Name = "LblIsoCode";
            this.LblIsoCode.Size = new System.Drawing.Size(43, 13);
            this.LblIsoCode.TabIndex = 21;
            this.LblIsoCode.Text = "Codigo:";
            // 
            // TxtName
            // 
            this.TxtName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtName.Location = new System.Drawing.Point(12, 26);
            this.TxtName.MaxLength = 100;
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(560, 20);
            this.TxtName.TabIndex = 15;
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(12, 10);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(47, 13);
            this.LblName.TabIndex = 20;
            this.LblName.Text = "Nombre:";
            // 
            // CmdExit
            // 
            this.CmdExit.Location = new System.Drawing.Point(492, 171);
            this.CmdExit.Name = "CmdExit";
            this.CmdExit.Size = new System.Drawing.Size(80, 50);
            this.CmdExit.TabIndex = 19;
            this.CmdExit.Text = "Salir";
            this.CmdExit.UseVisualStyleBackColor = false;
            this.CmdExit.Click += new System.EventHandler(this.CmdExit_Click);
            // 
            // TxtSymbol
            // 
            this.TxtSymbol.Location = new System.Drawing.Point(12, 104);
            this.TxtSymbol.MaxLength = 100;
            this.TxtSymbol.Name = "TxtSymbol";
            this.TxtSymbol.Size = new System.Drawing.Size(115, 20);
            this.TxtSymbol.TabIndex = 22;
            // 
            // LblSymbol
            // 
            this.LblSymbol.AutoSize = true;
            this.LblSymbol.Location = new System.Drawing.Point(12, 88);
            this.LblSymbol.Name = "LblSymbol";
            this.LblSymbol.Size = new System.Drawing.Size(48, 17);
            this.LblSymbol.TabIndex = 23;
            this.LblSymbol.Text = "Símbolo:";
            this.LblSymbol.UseCompatibleTextRendering = true;
            // 
            // FrmCurrency_detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 233);
            this.ControlBox = false;
            this.Controls.Add(this.TxtSymbol);
            this.Controls.Add(this.LblSymbol);
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
            this.Name = "FrmCurrency_detail";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Moneda";
            this.Load += new System.EventHandler(this.FrmCurrency_detail_Load);
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
        private System.Windows.Forms.TextBox TxtSymbol;
        private System.Windows.Forms.Label LblSymbol;
    }
}
