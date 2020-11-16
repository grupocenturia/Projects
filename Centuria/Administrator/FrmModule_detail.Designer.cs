
namespace Administrator
{
    partial class FrmModule_detail
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
            this.TxtDescription = new System.Windows.Forms.TextBox();
            this.LblDescription = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.LblName = new System.Windows.Forms.Label();
            this.CmdExit = new System.Windows.Forms.Button();
            this.TxtExecutable = new System.Windows.Forms.TextBox();
            this.LblExecutable = new System.Windows.Forms.Label();
            this.ImgLogo = new System.Windows.Forms.PictureBox();
            this.LblLogo = new System.Windows.Forms.Label();
            this.CmdLogo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ImgLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // ChkEnabled
            // 
            this.ChkEnabled.AutoSize = true;
            this.ChkEnabled.Location = new System.Drawing.Point(12, 150);
            this.ChkEnabled.Name = "ChkEnabled";
            this.ChkEnabled.Size = new System.Drawing.Size(56, 17);
            this.ChkEnabled.TabIndex = 3;
            this.ChkEnabled.Text = "Activo";
            this.ChkEnabled.UseVisualStyleBackColor = true;
            // 
            // CmdSave
            // 
            this.CmdSave.Location = new System.Drawing.Point(406, 179);
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.Size = new System.Drawing.Size(80, 50);
            this.CmdSave.TabIndex = 5;
            this.CmdSave.Text = "Guardar";
            this.CmdSave.UseVisualStyleBackColor = false;
            this.CmdSave.Click += new System.EventHandler(this.CmdSave_Click);
            // 
            // TxtDescription
            // 
            this.TxtDescription.Location = new System.Drawing.Point(12, 64);
            this.TxtDescription.Multiline = true;
            this.TxtDescription.Name = "TxtDescription";
            this.TxtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtDescription.Size = new System.Drawing.Size(474, 41);
            this.TxtDescription.TabIndex = 1;
            this.TxtDescription.Enter += new System.EventHandler(this.TxtDescription_Enter);
            // 
            // LblDescription
            // 
            this.LblDescription.AutoSize = true;
            this.LblDescription.Location = new System.Drawing.Point(12, 48);
            this.LblDescription.Name = "LblDescription";
            this.LblDescription.Size = new System.Drawing.Size(66, 13);
            this.LblDescription.TabIndex = 14;
            this.LblDescription.Text = "Descripción:";
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
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(12, 9);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(47, 13);
            this.LblName.TabIndex = 13;
            this.LblName.Text = "Nombre:";
            // 
            // CmdExit
            // 
            this.CmdExit.Location = new System.Drawing.Point(492, 179);
            this.CmdExit.Name = "CmdExit";
            this.CmdExit.Size = new System.Drawing.Size(80, 50);
            this.CmdExit.TabIndex = 6;
            this.CmdExit.Text = "Salir";
            this.CmdExit.UseVisualStyleBackColor = false;
            this.CmdExit.Click += new System.EventHandler(this.CmdExit_Click);
            // 
            // TxtExecutable
            // 
            this.TxtExecutable.Location = new System.Drawing.Point(12, 124);
            this.TxtExecutable.MaxLength = 100;
            this.TxtExecutable.Name = "TxtExecutable";
            this.TxtExecutable.Size = new System.Drawing.Size(474, 20);
            this.TxtExecutable.TabIndex = 2;
            this.TxtExecutable.Enter += new System.EventHandler(this.TxtExecutable_Enter);
            // 
            // LblExecutable
            // 
            this.LblExecutable.AutoSize = true;
            this.LblExecutable.Location = new System.Drawing.Point(12, 108);
            this.LblExecutable.Name = "LblExecutable";
            this.LblExecutable.Size = new System.Drawing.Size(60, 13);
            this.LblExecutable.TabIndex = 16;
            this.LblExecutable.Text = "Ejecutable:";
            // 
            // ImgLogo
            // 
            this.ImgLogo.Location = new System.Drawing.Point(492, 64);
            this.ImgLogo.Name = "ImgLogo";
            this.ImgLogo.Size = new System.Drawing.Size(80, 80);
            this.ImgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgLogo.TabIndex = 17;
            this.ImgLogo.TabStop = false;
            // 
            // LblLogo
            // 
            this.LblLogo.AutoSize = true;
            this.LblLogo.Location = new System.Drawing.Point(492, 48);
            this.LblLogo.Name = "LblLogo";
            this.LblLogo.Size = new System.Drawing.Size(34, 13);
            this.LblLogo.TabIndex = 18;
            this.LblLogo.Text = "Logo:";
            // 
            // CmdLogo
            // 
            this.CmdLogo.Location = new System.Drawing.Point(12, 179);
            this.CmdLogo.Name = "CmdLogo";
            this.CmdLogo.Size = new System.Drawing.Size(80, 50);
            this.CmdLogo.TabIndex = 4;
            this.CmdLogo.Text = "Cambiar logo";
            this.CmdLogo.UseVisualStyleBackColor = false;
            this.CmdLogo.Click += new System.EventHandler(this.CmdLogo_Click);
            // 
            // FrmModule_detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 241);
            this.ControlBox = false;
            this.Controls.Add(this.CmdLogo);
            this.Controls.Add(this.LblLogo);
            this.Controls.Add(this.ImgLogo);
            this.Controls.Add(this.TxtExecutable);
            this.Controls.Add(this.LblExecutable);
            this.Controls.Add(this.ChkEnabled);
            this.Controls.Add(this.CmdSave);
            this.Controls.Add(this.TxtDescription);
            this.Controls.Add(this.LblDescription);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.CmdExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmModule_detail";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Módulo";
            this.Load += new System.EventHandler(this.FrmModule_detail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImgLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ChkEnabled;
        private System.Windows.Forms.Button CmdSave;
        private System.Windows.Forms.TextBox TxtDescription;
        private System.Windows.Forms.Label LblDescription;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Button CmdExit;
        private System.Windows.Forms.TextBox TxtExecutable;
        private System.Windows.Forms.Label LblExecutable;
        private System.Windows.Forms.PictureBox ImgLogo;
        private System.Windows.Forms.Label LblLogo;
        private System.Windows.Forms.Button CmdLogo;
    }
}