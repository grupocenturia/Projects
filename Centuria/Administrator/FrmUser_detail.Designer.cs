namespace Administrator
{
    partial class FrmUser_detail
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
            this.CmdExit = new System.Windows.Forms.Button();
            this.LblName = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtUserName = new System.Windows.Forms.TextBox();
            this.LblUserName = new System.Windows.Forms.Label();
            this.CmdSave = new System.Windows.Forms.Button();
            this.ChkEnabled = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // CmdExit
            // 
            this.CmdExit.Location = new System.Drawing.Point(492, 119);
            this.CmdExit.Name = "CmdExit";
            this.CmdExit.Size = new System.Drawing.Size(80, 50);
            this.CmdExit.TabIndex = 4;
            this.CmdExit.Text = "Salir";
            this.CmdExit.UseVisualStyleBackColor = false;
            this.CmdExit.Click += new System.EventHandler(this.CmdExit_Click);
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(12, 9);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(47, 13);
            this.LblName.TabIndex = 5;
            this.LblName.Text = "Nombre:";
            // 
            // TxtName
            // 
            this.TxtName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtName.Location = new System.Drawing.Point(12, 25);
            this.TxtName.MaxLength = 100;
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(560, 20);
            this.TxtName.TabIndex = 0;
            this.TxtName.Enter += new System.EventHandler(this.TxtName_Enter);
            // 
            // TxtUserName
            // 
            this.TxtUserName.Location = new System.Drawing.Point(12, 64);
            this.TxtUserName.MaxLength = 100;
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.Size = new System.Drawing.Size(560, 20);
            this.TxtUserName.TabIndex = 1;
            this.TxtUserName.Enter += new System.EventHandler(this.TxtUserName_Enter);
            // 
            // LblUserName
            // 
            this.LblUserName.AutoSize = true;
            this.LblUserName.Location = new System.Drawing.Point(12, 48);
            this.LblUserName.Name = "LblUserName";
            this.LblUserName.Size = new System.Drawing.Size(46, 13);
            this.LblUserName.TabIndex = 7;
            this.LblUserName.Text = "Usuario:";
            // 
            // CmdSave
            // 
            this.CmdSave.Location = new System.Drawing.Point(406, 119);
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.Size = new System.Drawing.Size(80, 50);
            this.CmdSave.TabIndex = 3;
            this.CmdSave.Text = "Guardar";
            this.CmdSave.UseVisualStyleBackColor = false;
            this.CmdSave.Click += new System.EventHandler(this.CmdSave_Click);
            // 
            // ChkEnabled
            // 
            this.ChkEnabled.AutoSize = true;
            this.ChkEnabled.Location = new System.Drawing.Point(12, 90);
            this.ChkEnabled.Name = "ChkEnabled";
            this.ChkEnabled.Size = new System.Drawing.Size(56, 17);
            this.ChkEnabled.TabIndex = 2;
            this.ChkEnabled.Text = "Activo";
            this.ChkEnabled.UseVisualStyleBackColor = true;
            // 
            // FrmUser_detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 181);
            this.ControlBox = false;
            this.Controls.Add(this.ChkEnabled);
            this.Controls.Add(this.CmdSave);
            this.Controls.Add(this.TxtUserName);
            this.Controls.Add(this.LblUserName);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.CmdExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmUser_detail";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuario";
            this.Load += new System.EventHandler(this.FrmUser_detail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdExit;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtUserName;
        private System.Windows.Forms.Label LblUserName;
        private System.Windows.Forms.Button CmdSave;
        private System.Windows.Forms.CheckBox ChkEnabled;
    }
}