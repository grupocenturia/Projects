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
            this.LblLoginUser = new System.Windows.Forms.Label();
            this.LblloginPassword = new System.Windows.Forms.Label();
            this.TxtLoginUser = new System.Windows.Forms.TextBox();
            this.TxtLoginPassword = new System.Windows.Forms.TextBox();
            this.CmdLoginEnter = new System.Windows.Forms.Button();
            this.CmdExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblLoginUser
            // 
            this.LblLoginUser.AutoSize = true;
            this.LblLoginUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLoginUser.Location = new System.Drawing.Point(33, 126);
            this.LblLoginUser.Name = "LblLoginUser";
            this.LblLoginUser.Size = new System.Drawing.Size(86, 25);
            this.LblLoginUser.TabIndex = 1;
            this.LblLoginUser.Text = "Usuario";
            // 
            // LblloginPassword
            // 
            this.LblloginPassword.AutoSize = true;
            this.LblloginPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblloginPassword.Location = new System.Drawing.Point(33, 195);
            this.LblloginPassword.Name = "LblloginPassword";
            this.LblloginPassword.Size = new System.Drawing.Size(106, 25);
            this.LblloginPassword.TabIndex = 2;
            this.LblloginPassword.Text = "Password";
            // 
            // TxtLoginUser
            // 
            this.TxtLoginUser.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.TxtLoginUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLoginUser.Location = new System.Drawing.Point(33, 154);
            this.TxtLoginUser.Name = "TxtLoginUser";
            this.TxtLoginUser.Size = new System.Drawing.Size(318, 29);
            this.TxtLoginUser.TabIndex = 3;
            // 
            // TxtLoginPassword
            // 
            this.TxtLoginPassword.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.TxtLoginPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLoginPassword.Location = new System.Drawing.Point(33, 223);
            this.TxtLoginPassword.Name = "TxtLoginPassword";
            this.TxtLoginPassword.PasswordChar = '●';
            this.TxtLoginPassword.Size = new System.Drawing.Size(318, 29);
            this.TxtLoginPassword.TabIndex = 4;
            // 
            // CmdLoginEnter
            // 
            this.CmdLoginEnter.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.CmdLoginEnter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CmdLoginEnter.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.CmdLoginEnter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.CmdLoginEnter.Location = new System.Drawing.Point(33, 278);
            this.CmdLoginEnter.Name = "CmdLoginEnter";
            this.CmdLoginEnter.Size = new System.Drawing.Size(80, 50);
            this.CmdLoginEnter.TabIndex = 5;
            this.CmdLoginEnter.Text = "Ingresar";
            this.CmdLoginEnter.UseVisualStyleBackColor = false;
            // 
            // CmdExit
            // 
            this.CmdExit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.CmdExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CmdExit.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.CmdExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.CmdExit.Location = new System.Drawing.Point(271, 278);
            this.CmdExit.Name = "CmdExit";
            this.CmdExit.Size = new System.Drawing.Size(80, 50);
            this.CmdExit.TabIndex = 6;
            this.CmdExit.Text = "Salir";
            this.CmdExit.UseVisualStyleBackColor = false;
            this.CmdExit.Click += new System.EventHandler(this.CmdExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(33, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(318, 68);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // FrmLogin
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CmdExit);
            this.Controls.Add(this.CmdLoginEnter);
            this.Controls.Add(this.TxtLoginPassword);
            this.Controls.Add(this.TxtLoginUser);
            this.Controls.Add(this.LblloginPassword);
            this.Controls.Add(this.LblLoginUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
            this.Padding = new System.Windows.Forms.Padding(30);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar sesión";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblLoginUser;
        private System.Windows.Forms.Label LblloginPassword;
        private System.Windows.Forms.TextBox TxtLoginUser;
        private System.Windows.Forms.TextBox TxtLoginPassword;
        private System.Windows.Forms.Button CmdLoginEnter;
        private System.Windows.Forms.Button CmdExit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}