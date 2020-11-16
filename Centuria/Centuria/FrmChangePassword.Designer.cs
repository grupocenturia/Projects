namespace Centuria
{
    partial class FrmChangePassword
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
            this.TxtUser = new System.Windows.Forms.TextBox();
            this.LblUser = new System.Windows.Forms.Label();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.LblPassword = new System.Windows.Forms.Label();
            this.TxtConfirm = new System.Windows.Forms.TextBox();
            this.LblConfirm = new System.Windows.Forms.Label();
            this.CmdExit = new System.Windows.Forms.Button();
            this.CmdSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtUser
            // 
            this.TxtUser.Enabled = false;
            this.TxtUser.Location = new System.Drawing.Point(12, 25);
            this.TxtUser.Name = "TxtUser";
            this.TxtUser.Size = new System.Drawing.Size(360, 20);
            this.TxtUser.TabIndex = 0;
            // 
            // LblUser
            // 
            this.LblUser.AutoSize = true;
            this.LblUser.Location = new System.Drawing.Point(12, 9);
            this.LblUser.Name = "LblUser";
            this.LblUser.Size = new System.Drawing.Size(46, 13);
            this.LblUser.TabIndex = 8;
            this.LblUser.Text = "Usuario:";
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(12, 64);
            this.TxtPassword.MaxLength = 100;
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PasswordChar = '●';
            this.TxtPassword.Size = new System.Drawing.Size(360, 20);
            this.TxtPassword.TabIndex = 1;
            this.TxtPassword.Enter += new System.EventHandler(this.TxtPassword_Enter);
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.Location = new System.Drawing.Point(12, 48);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(64, 13);
            this.LblPassword.TabIndex = 10;
            this.LblPassword.Text = "Contraseña:";
            // 
            // TxtConfirm
            // 
            this.TxtConfirm.Location = new System.Drawing.Point(12, 103);
            this.TxtConfirm.MaxLength = 100;
            this.TxtConfirm.Name = "TxtConfirm";
            this.TxtConfirm.PasswordChar = '●';
            this.TxtConfirm.Size = new System.Drawing.Size(360, 20);
            this.TxtConfirm.TabIndex = 2;
            this.TxtConfirm.Enter += new System.EventHandler(this.TxtConfirm_Enter);
            // 
            // LblConfirm
            // 
            this.LblConfirm.AutoSize = true;
            this.LblConfirm.Location = new System.Drawing.Point(12, 87);
            this.LblConfirm.Name = "LblConfirm";
            this.LblConfirm.Size = new System.Drawing.Size(110, 13);
            this.LblConfirm.TabIndex = 12;
            this.LblConfirm.Text = "Confirmar contraseña:";
            // 
            // CmdExit
            // 
            this.CmdExit.Location = new System.Drawing.Point(292, 139);
            this.CmdExit.Name = "CmdExit";
            this.CmdExit.Size = new System.Drawing.Size(80, 50);
            this.CmdExit.TabIndex = 4;
            this.CmdExit.Text = "Salir";
            this.CmdExit.UseVisualStyleBackColor = false;
            this.CmdExit.Click += new System.EventHandler(this.CmdExit_Click);
            // 
            // CmdSave
            // 
            this.CmdSave.Location = new System.Drawing.Point(206, 139);
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.Size = new System.Drawing.Size(80, 50);
            this.CmdSave.TabIndex = 3;
            this.CmdSave.Text = "Guardar";
            this.CmdSave.UseVisualStyleBackColor = false;
            this.CmdSave.Click += new System.EventHandler(this.CmdSave_Click);
            // 
            // FrmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(384, 201);
            this.ControlBox = false;
            this.Controls.Add(this.CmdExit);
            this.Controls.Add(this.CmdSave);
            this.Controls.Add(this.TxtConfirm);
            this.Controls.Add(this.LblConfirm);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.LblPassword);
            this.Controls.Add(this.TxtUser);
            this.Controls.Add(this.LblUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmChangePassword";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cambiar contraseña";
            this.Load += new System.EventHandler(this.FrmChangePassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtUser;
        private System.Windows.Forms.Label LblUser;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.TextBox TxtConfirm;
        private System.Windows.Forms.Label LblConfirm;
        private System.Windows.Forms.Button CmdExit;
        private System.Windows.Forms.Button CmdSave;
    }
}