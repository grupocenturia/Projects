namespace Centuria
{
    partial class FrmSettings
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
            this.CmdSave = new System.Windows.Forms.Button();
            this.CmdExit = new System.Windows.Forms.Button();
            this.LblServer = new System.Windows.Forms.Label();
            this.TxtServer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CmdSave
            // 
            this.CmdSave.Location = new System.Drawing.Point(406, 79);
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.Size = new System.Drawing.Size(80, 50);
            this.CmdSave.TabIndex = 1;
            this.CmdSave.Text = "Guardar";
            this.CmdSave.UseVisualStyleBackColor = false;
            this.CmdSave.Click += new System.EventHandler(this.CmdSave_Click);
            // 
            // CmdExit
            // 
            this.CmdExit.Location = new System.Drawing.Point(492, 79);
            this.CmdExit.Name = "CmdExit";
            this.CmdExit.Size = new System.Drawing.Size(80, 50);
            this.CmdExit.TabIndex = 2;
            this.CmdExit.Text = "Salir";
            this.CmdExit.UseVisualStyleBackColor = false;
            this.CmdExit.Click += new System.EventHandler(this.CmdExit_Click);
            // 
            // LblServer
            // 
            this.LblServer.AutoSize = true;
            this.LblServer.Location = new System.Drawing.Point(12, 9);
            this.LblServer.Name = "LblServer";
            this.LblServer.Size = new System.Drawing.Size(49, 13);
            this.LblServer.TabIndex = 6;
            this.LblServer.Text = "Servidor:";
            // 
            // TxtServer
            // 
            this.TxtServer.Location = new System.Drawing.Point(12, 25);
            this.TxtServer.MaxLength = 200;
            this.TxtServer.Name = "TxtServer";
            this.TxtServer.Size = new System.Drawing.Size(560, 20);
            this.TxtServer.TabIndex = 0;
            this.TxtServer.Enter += new System.EventHandler(this.TxtServer_Enter);
            // 
            // FrmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 141);
            this.ControlBox = false;
            this.Controls.Add(this.TxtServer);
            this.Controls.Add(this.LblServer);
            this.Controls.Add(this.CmdExit);
            this.Controls.Add(this.CmdSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSettings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuración";
            this.Load += new System.EventHandler(this.FrmSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button CmdSave;
        private System.Windows.Forms.Button CmdExit;
        private System.Windows.Forms.Label LblServer;
        private System.Windows.Forms.TextBox TxtServer;
    }
}