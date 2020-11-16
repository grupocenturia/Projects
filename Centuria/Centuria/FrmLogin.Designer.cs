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
            this.LblUserName = new System.Windows.Forms.Label();
            this.LblPassword = new System.Windows.Forms.Label();
            this.TxtUserName = new System.Windows.Forms.TextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.CmdEnter = new System.Windows.Forms.Button();
            this.CmdExit = new System.Windows.Forms.Button();
            this.ImgLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImgLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // LblUserName
            // 
            this.LblUserName.AutoSize = true;
            this.LblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUserName.Location = new System.Drawing.Point(33, 130);
            this.LblUserName.Name = "LblUserName";
            this.LblUserName.Size = new System.Drawing.Size(79, 24);
            this.LblUserName.TabIndex = 1;
            this.LblUserName.Text = "Usuario:";
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPassword.Location = new System.Drawing.Point(33, 189);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(111, 24);
            this.LblPassword.TabIndex = 2;
            this.LblPassword.Text = "Contraseña:";
            // 
            // TxtUserName
            // 
            this.TxtUserName.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.TxtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUserName.Location = new System.Drawing.Point(33, 157);
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.Size = new System.Drawing.Size(318, 29);
            this.TxtUserName.TabIndex = 0;
            this.TxtUserName.Enter += new System.EventHandler(this.TxtUserName_Enter);
            // 
            // TxtPassword
            // 
            this.TxtPassword.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.TxtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPassword.Location = new System.Drawing.Point(33, 216);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PasswordChar = '●';
            this.TxtPassword.Size = new System.Drawing.Size(318, 29);
            this.TxtPassword.TabIndex = 1;
            this.TxtPassword.Enter += new System.EventHandler(this.TxtPassword_Enter);
            // 
            // CmdEnter
            // 
            this.CmdEnter.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.CmdEnter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CmdEnter.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.CmdEnter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.CmdEnter.Location = new System.Drawing.Point(33, 278);
            this.CmdEnter.Name = "CmdEnter";
            this.CmdEnter.Size = new System.Drawing.Size(80, 50);
            this.CmdEnter.TabIndex = 2;
            this.CmdEnter.Text = "Ingresar";
            this.CmdEnter.UseVisualStyleBackColor = false;
            this.CmdEnter.Click += new System.EventHandler(this.CmdEnter_Click);
            // 
            // CmdExit
            // 
            this.CmdExit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.CmdExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CmdExit.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.CmdExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.CmdExit.Location = new System.Drawing.Point(271, 278);
            this.CmdExit.Name = "CmdExit";
            this.CmdExit.Size = new System.Drawing.Size(80, 50);
            this.CmdExit.TabIndex = 3;
            this.CmdExit.Text = "Salir";
            this.CmdExit.UseVisualStyleBackColor = false;
            this.CmdExit.Click += new System.EventHandler(this.CmdExit_Click);
            // 
            // ImgLogo
            // 
            this.ImgLogo.Image = global::Centuria.Properties.Resources.ImgLogo;
            this.ImgLogo.Location = new System.Drawing.Point(33, 33);
            this.ImgLogo.Name = "ImgLogo";
            this.ImgLogo.Size = new System.Drawing.Size(318, 70);
            this.ImgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgLogo.TabIndex = 7;
            this.ImgLogo.TabStop = false;
            // 
            // FrmLogin
            // 
            this.AcceptButton = this.CmdEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.ControlBox = false;
            this.Controls.Add(this.ImgLogo);
            this.Controls.Add(this.CmdExit);
            this.Controls.Add(this.CmdEnter);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtUserName);
            this.Controls.Add(this.LblPassword);
            this.Controls.Add(this.LblUserName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
            this.Padding = new System.Windows.Forms.Padding(30);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar sesión";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImgLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblUserName;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.TextBox TxtUserName;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Button CmdEnter;
        private System.Windows.Forms.Button CmdExit;
        private System.Windows.Forms.PictureBox ImgLogo;
    }
}