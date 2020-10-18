namespace Centuria
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.LblLogin = new System.Windows.Forms.Label();
            this.LblLoginUser = new System.Windows.Forms.Label();
            this.LblloginPassword = new System.Windows.Forms.Label();
            this.TxtLoginUser = new System.Windows.Forms.TextBox();
            this.TxtLoginPassword = new System.Windows.Forms.TextBox();
            this.CmdLoginEnter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblLogin
            // 
            this.LblLogin.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.LblLogin.AutoSize = true;
            this.LblLogin.BackColor = System.Drawing.SystemColors.Window;
            this.LblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLogin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LblLogin.Location = new System.Drawing.Point(269, 9);
            this.LblLogin.Name = "LblLogin";
            this.LblLogin.Size = new System.Drawing.Size(269, 39);
            this.LblLogin.TabIndex = 0;
            this.LblLogin.Text = "Inicio de sesión";
            this.LblLogin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LblLogin.Click += new System.EventHandler(this.LblLogin_Click);
            // 
            // LblLoginUser
            // 
            this.LblLoginUser.AutoSize = true;
            this.LblLoginUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLoginUser.Location = new System.Drawing.Point(131, 105);
            this.LblLoginUser.Name = "LblLoginUser";
            this.LblLoginUser.Size = new System.Drawing.Size(86, 25);
            this.LblLoginUser.TabIndex = 1;
            this.LblLoginUser.Text = "Usuario";
            // 
            // LblloginPassword
            // 
            this.LblloginPassword.AutoSize = true;
            this.LblloginPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblloginPassword.Location = new System.Drawing.Point(131, 168);
            this.LblloginPassword.Name = "LblloginPassword";
            this.LblloginPassword.Size = new System.Drawing.Size(106, 25);
            this.LblloginPassword.TabIndex = 2;
            this.LblloginPassword.Text = "Password";
            // 
            // TxtLoginUser
            // 
            this.TxtLoginUser.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.TxtLoginUser.Location = new System.Drawing.Point(276, 109);
            this.TxtLoginUser.Name = "TxtLoginUser";
            this.TxtLoginUser.Size = new System.Drawing.Size(195, 20);
            this.TxtLoginUser.TabIndex = 3;
            // 
            // TxtLoginPassword
            // 
            this.TxtLoginPassword.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.TxtLoginPassword.Location = new System.Drawing.Point(276, 174);
            this.TxtLoginPassword.Name = "TxtLoginPassword";
            this.TxtLoginPassword.PasswordChar = '*';
            this.TxtLoginPassword.Size = new System.Drawing.Size(195, 20);
            this.TxtLoginPassword.TabIndex = 4;
            // 
            // CmdLoginEnter
            // 
            this.CmdLoginEnter.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.CmdLoginEnter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CmdLoginEnter.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.CmdLoginEnter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.CmdLoginEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdLoginEnter.Location = new System.Drawing.Point(317, 243);
            this.CmdLoginEnter.Name = "CmdLoginEnter";
            this.CmdLoginEnter.Size = new System.Drawing.Size(113, 33);
            this.CmdLoginEnter.TabIndex = 5;
            this.CmdLoginEnter.Text = "Ingresar";
            this.CmdLoginEnter.UseVisualStyleBackColor = true;
            // 
            // FrmLogin
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(717, 328);
            this.Controls.Add(this.CmdLoginEnter);
            this.Controls.Add(this.TxtLoginPassword);
            this.Controls.Add(this.TxtLoginUser);
            this.Controls.Add(this.LblloginPassword);
            this.Controls.Add(this.LblLoginUser);
            this.Controls.Add(this.LblLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Centuria";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblLogin;
        private System.Windows.Forms.Label LblLoginUser;
        private System.Windows.Forms.Label LblloginPassword;
        private System.Windows.Forms.TextBox TxtLoginUser;
        private System.Windows.Forms.TextBox TxtLoginPassword;
        private System.Windows.Forms.Button CmdLoginEnter;
    }
}