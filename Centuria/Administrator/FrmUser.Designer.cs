namespace Administrator
{
    partial class FrmUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUser));
            this.GrdData = new System.Windows.Forms.DataGridView();
            this.MnuToolbar = new System.Windows.Forms.ToolStrip();
            this.CmdNew = new System.Windows.Forms.ToolStripButton();
            this.CmdEdit = new System.Windows.Forms.ToolStripButton();
            this.CmdReset = new System.Windows.Forms.ToolStripButton();
            this.CmdExit = new System.Windows.Forms.ToolStripButton();
            this.PanPrincipal = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.GrdData)).BeginInit();
            this.MnuToolbar.SuspendLayout();
            this.PanPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrdData
            // 
            this.GrdData.AllowUserToAddRows = false;
            this.GrdData.AllowUserToDeleteRows = false;
            this.GrdData.AllowUserToResizeColumns = false;
            this.GrdData.AllowUserToResizeRows = false;
            this.GrdData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.GrdData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GrdData.BackgroundColor = System.Drawing.Color.White;
            this.GrdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrdData.GridColor = System.Drawing.Color.Gray;
            this.GrdData.Location = new System.Drawing.Point(0, 0);
            this.GrdData.MultiSelect = false;
            this.GrdData.Name = "GrdData";
            this.GrdData.ReadOnly = true;
            this.GrdData.RowHeadersVisible = false;
            this.GrdData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GrdData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrdData.ShowCellErrors = false;
            this.GrdData.ShowCellToolTips = false;
            this.GrdData.ShowEditingIcon = false;
            this.GrdData.ShowRowErrors = false;
            this.GrdData.Size = new System.Drawing.Size(884, 522);
            this.GrdData.StandardTab = true;
            this.GrdData.TabIndex = 0;
            // 
            // MnuToolbar
            // 
            this.MnuToolbar.BackColor = System.Drawing.Color.White;
            this.MnuToolbar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.MnuToolbar.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.MnuToolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CmdNew,
            this.CmdEdit,
            this.CmdReset,
            this.CmdExit});
            this.MnuToolbar.Location = new System.Drawing.Point(0, 0);
            this.MnuToolbar.Name = "MnuToolbar";
            this.MnuToolbar.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.MnuToolbar.Size = new System.Drawing.Size(884, 39);
            this.MnuToolbar.TabIndex = 5;
            // 
            // CmdNew
            // 
            this.CmdNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CmdNew.Image = ((System.Drawing.Image)(resources.GetObject("CmdNew.Image")));
            this.CmdNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CmdNew.Name = "CmdNew";
            this.CmdNew.Size = new System.Drawing.Size(36, 36);
            this.CmdNew.Text = "Adicionar";
            this.CmdNew.ToolTipText = "Adicionar";
            this.CmdNew.Click += new System.EventHandler(this.CmdNew_Click);
            // 
            // CmdEdit
            // 
            this.CmdEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CmdEdit.Image = ((System.Drawing.Image)(resources.GetObject("CmdEdit.Image")));
            this.CmdEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CmdEdit.Name = "CmdEdit";
            this.CmdEdit.Size = new System.Drawing.Size(36, 36);
            this.CmdEdit.Text = "Modificar";
            this.CmdEdit.Click += new System.EventHandler(this.CmdEdit_Click);
            // 
            // CmdReset
            // 
            this.CmdReset.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CmdReset.Image = ((System.Drawing.Image)(resources.GetObject("CmdReset.Image")));
            this.CmdReset.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CmdReset.Name = "CmdReset";
            this.CmdReset.Size = new System.Drawing.Size(36, 36);
            this.CmdReset.Text = "Restablecer contraseña";
            this.CmdReset.Click += new System.EventHandler(this.CmdReset_Click);
            // 
            // CmdExit
            // 
            this.CmdExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.CmdExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CmdExit.Image = ((System.Drawing.Image)(resources.GetObject("CmdExit.Image")));
            this.CmdExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CmdExit.Name = "CmdExit";
            this.CmdExit.Size = new System.Drawing.Size(36, 36);
            this.CmdExit.Text = "Salir";
            this.CmdExit.Click += new System.EventHandler(this.CmdExit_Click);
            // 
            // PanPrincipal
            // 
            this.PanPrincipal.Controls.Add(this.GrdData);
            this.PanPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanPrincipal.Location = new System.Drawing.Point(0, 39);
            this.PanPrincipal.Name = "PanPrincipal";
            this.PanPrincipal.Size = new System.Drawing.Size(884, 522);
            this.PanPrincipal.TabIndex = 6;
            // 
            // FrmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.ControlBox = false;
            this.Controls.Add(this.PanPrincipal);
            this.Controls.Add(this.MnuToolbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmUser";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuario";
            this.Load += new System.EventHandler(this.FrmUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdData)).EndInit();
            this.MnuToolbar.ResumeLayout(false);
            this.MnuToolbar.PerformLayout();
            this.PanPrincipal.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GrdData;
        private System.Windows.Forms.ToolStrip MnuToolbar;
        private System.Windows.Forms.ToolStripButton CmdNew;
        private System.Windows.Forms.ToolStripButton CmdEdit;
        private System.Windows.Forms.ToolStripButton CmdReset;
        private System.Windows.Forms.ToolStripButton CmdExit;
        private System.Windows.Forms.Panel PanPrincipal;
    }
}