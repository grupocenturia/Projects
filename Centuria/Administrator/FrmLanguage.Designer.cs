namespace Administrator
{
    partial class FrmLanguage
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
            this.CmdEdit = new System.Windows.Forms.Button();
            this.CmdNew = new System.Windows.Forms.Button();
            this.GrdData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GrdData)).BeginInit();
            this.SuspendLayout();
            // 
            // CmdExit
            // 
            this.CmdExit.Location = new System.Drawing.Point(1183, 764);
            this.CmdExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CmdExit.Name = "CmdExit";
            this.CmdExit.Size = new System.Drawing.Size(120, 77);
            this.CmdExit.TabIndex = 3;
            this.CmdExit.Text = "Salir";
            this.CmdExit.UseVisualStyleBackColor = false;
            this.CmdExit.Click += new System.EventHandler(this.CmdExit_Click);
            // 
            // CmdEdit
            // 
            this.CmdEdit.Location = new System.Drawing.Point(142, 764);
            this.CmdEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CmdEdit.Name = "CmdEdit";
            this.CmdEdit.Size = new System.Drawing.Size(120, 77);
            this.CmdEdit.TabIndex = 2;
            this.CmdEdit.Text = "Modificar";
            this.CmdEdit.UseVisualStyleBackColor = false;
            this.CmdEdit.Click += new System.EventHandler(this.CmdEdit_Click);
            // 
            // CmdNew
            // 
            this.CmdNew.Location = new System.Drawing.Point(13, 764);
            this.CmdNew.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CmdNew.Name = "CmdNew";
            this.CmdNew.Size = new System.Drawing.Size(120, 77);
            this.CmdNew.TabIndex = 1;
            this.CmdNew.Text = "Adicionar";
            this.CmdNew.UseVisualStyleBackColor = false;
            this.CmdNew.Click += new System.EventHandler(this.CmdNew_Click);
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
            this.GrdData.GridColor = System.Drawing.Color.Gray;
            this.GrdData.Location = new System.Drawing.Point(18, 18);
            this.GrdData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GrdData.MultiSelect = false;
            this.GrdData.Name = "GrdData";
            this.GrdData.ReadOnly = true;
            this.GrdData.RowHeadersVisible = false;
            this.GrdData.RowHeadersWidth = 62;
            this.GrdData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GrdData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrdData.ShowCellErrors = false;
            this.GrdData.ShowCellToolTips = false;
            this.GrdData.ShowEditingIcon = false;
            this.GrdData.ShowRowErrors = false;
            this.GrdData.Size = new System.Drawing.Size(1290, 740);
            this.GrdData.StandardTab = true;
            this.GrdData.TabIndex = 0;
           
            // 
            // FrmLanguage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1326, 863);
            this.ControlBox = false;
            this.Controls.Add(this.CmdExit);
            this.Controls.Add(this.CmdEdit);
            this.Controls.Add(this.CmdNew);
            this.Controls.Add(this.GrdData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLanguage";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lenguaje";
            this.Load += new System.EventHandler(this.FrmLanguage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CmdExit;
        private System.Windows.Forms.Button CmdEdit;
        private System.Windows.Forms.Button CmdNew;
        private System.Windows.Forms.DataGridView GrdData;
    }
}
