namespace Administrator
{
    partial class FrmMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainMenu));
            this.BarStatus = new System.Windows.Forms.StatusStrip();
            this.LblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.PanPrincipal = new System.Windows.Forms.SplitContainer();
            this.PanMenu = new System.Windows.Forms.SplitContainer();
            this.LblModule = new System.Windows.Forms.Label();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.LblSearch = new System.Windows.Forms.Label();
            this.ImgModule = new System.Windows.Forms.PictureBox();
            this.PanOption = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.PanDetail = new System.Windows.Forms.SplitContainer();
            this.LblTitle = new System.Windows.Forms.Label();
            this.BarStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanPrincipal)).BeginInit();
            this.PanPrincipal.Panel1.SuspendLayout();
            this.PanPrincipal.Panel2.SuspendLayout();
            this.PanPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanMenu)).BeginInit();
            this.PanMenu.Panel1.SuspendLayout();
            this.PanMenu.Panel2.SuspendLayout();
            this.PanMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgModule)).BeginInit();
            this.PanOption.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanDetail)).BeginInit();
            this.PanDetail.Panel1.SuspendLayout();
            this.PanDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // BarStatus
            // 
            this.BarStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LblStatus});
            this.BarStatus.Location = new System.Drawing.Point(0, 539);
            this.BarStatus.Name = "BarStatus";
            this.BarStatus.Size = new System.Drawing.Size(884, 22);
            this.BarStatus.TabIndex = 1;
            // 
            // LblStatus
            // 
            this.LblStatus.BackColor = System.Drawing.Color.Transparent;
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // PanPrincipal
            // 
            this.PanPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanPrincipal.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.PanPrincipal.IsSplitterFixed = true;
            this.PanPrincipal.Location = new System.Drawing.Point(0, 0);
            this.PanPrincipal.Name = "PanPrincipal";
            // 
            // PanPrincipal.Panel1
            // 
            this.PanPrincipal.Panel1.Controls.Add(this.PanMenu);
            this.PanPrincipal.Panel1.Padding = new System.Windows.Forms.Padding(10, 10, 0, 10);
            this.PanPrincipal.Panel1MinSize = 200;
            // 
            // PanPrincipal.Panel2
            // 
            this.PanPrincipal.Panel2.Controls.Add(this.PanDetail);
            this.PanPrincipal.Panel2.Padding = new System.Windows.Forms.Padding(0, 10, 10, 10);
            this.PanPrincipal.Size = new System.Drawing.Size(884, 539);
            this.PanPrincipal.SplitterDistance = 200;
            this.PanPrincipal.TabIndex = 2;
            this.PanPrincipal.TabStop = false;
            // 
            // PanMenu
            // 
            this.PanMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanMenu.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.PanMenu.IsSplitterFixed = true;
            this.PanMenu.Location = new System.Drawing.Point(10, 10);
            this.PanMenu.Name = "PanMenu";
            this.PanMenu.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // PanMenu.Panel1
            // 
            this.PanMenu.Panel1.Controls.Add(this.LblModule);
            this.PanMenu.Panel1.Controls.Add(this.TxtSearch);
            this.PanMenu.Panel1.Controls.Add(this.LblSearch);
            this.PanMenu.Panel1.Controls.Add(this.ImgModule);
            this.PanMenu.Panel1MinSize = 140;
            // 
            // PanMenu.Panel2
            // 
            this.PanMenu.Panel2.AutoScroll = true;
            this.PanMenu.Panel2.Controls.Add(this.PanOption);
            this.PanMenu.Size = new System.Drawing.Size(190, 519);
            this.PanMenu.SplitterDistance = 140;
            this.PanMenu.TabIndex = 0;
            this.PanMenu.TabStop = false;
            // 
            // LblModule
            // 
            this.LblModule.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblModule.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(106)))), ((int)(((byte)(169)))));
            this.LblModule.Location = new System.Drawing.Point(2, 53);
            this.LblModule.Name = "LblModule";
            this.LblModule.Size = new System.Drawing.Size(185, 51);
            this.LblModule.TabIndex = 10;
            this.LblModule.Text = "ADMINISTRADOR";
            this.LblModule.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TxtSearch
            // 
            this.TxtSearch.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TxtSearch.Location = new System.Drawing.Point(0, 120);
            this.TxtSearch.MaxLength = 30;
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(190, 20);
            this.TxtSearch.TabIndex = 0;
            // 
            // LblSearch
            // 
            this.LblSearch.AutoSize = true;
            this.LblSearch.Location = new System.Drawing.Point(3, 104);
            this.LblSearch.Name = "LblSearch";
            this.LblSearch.Size = new System.Drawing.Size(78, 13);
            this.LblSearch.TabIndex = 9;
            this.LblSearch.Text = "Buscar opción:";
            // 
            // ImgModule
            // 
            this.ImgModule.Dock = System.Windows.Forms.DockStyle.Top;
            this.ImgModule.Image = global::Administrator.Properties.Resources.Administrator;
            this.ImgModule.Location = new System.Drawing.Point(0, 0);
            this.ImgModule.Name = "ImgModule";
            this.ImgModule.Size = new System.Drawing.Size(190, 50);
            this.ImgModule.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgModule.TabIndex = 8;
            this.ImgModule.TabStop = false;
            // 
            // PanOption
            // 
            this.PanOption.AutoScroll = true;
            this.PanOption.Controls.Add(this.button1);
            this.PanOption.Controls.Add(this.button2);
            this.PanOption.Controls.Add(this.button3);
            this.PanOption.Controls.Add(this.button4);
            this.PanOption.Controls.Add(this.button5);
            this.PanOption.Controls.Add(this.button6);
            this.PanOption.Controls.Add(this.button7);
            this.PanOption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanOption.Location = new System.Drawing.Point(0, 0);
            this.PanOption.Name = "PanOption";
            this.PanOption.Size = new System.Drawing.Size(190, 375);
            this.PanOption.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Configuración";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 49);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 40);
            this.button2.TabIndex = 1;
            this.button2.Text = "Usuario";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(3, 95);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(160, 40);
            this.button3.TabIndex = 2;
            this.button3.Text = "Módulo";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DimGray;
            this.button4.Location = new System.Drawing.Point(3, 141);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(160, 40);
            this.button4.TabIndex = 3;
            this.button4.Text = "Registros";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(3, 187);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(160, 40);
            this.button5.TabIndex = 4;
            this.button5.Text = "Perfil";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.DimGray;
            this.button6.Location = new System.Drawing.Point(3, 233);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(160, 40);
            this.button6.TabIndex = 5;
            this.button6.Text = "Reportes";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(3, 279);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(160, 40);
            this.button7.TabIndex = 6;
            this.button7.Text = "Bitácora";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // PanDetail
            // 
            this.PanDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanDetail.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.PanDetail.IsSplitterFixed = true;
            this.PanDetail.Location = new System.Drawing.Point(0, 10);
            this.PanDetail.Name = "PanDetail";
            this.PanDetail.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // PanDetail.Panel1
            // 
            this.PanDetail.Panel1.Controls.Add(this.LblTitle);
            this.PanDetail.Panel1MinSize = 20;
            this.PanDetail.Size = new System.Drawing.Size(670, 519);
            this.PanDetail.SplitterDistance = 25;
            this.PanDetail.TabIndex = 0;
            this.PanDetail.TabStop = false;
            // 
            // LblTitle
            // 
            this.LblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.Location = new System.Drawing.Point(0, 0);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(670, 25);
            this.LblTitle.TabIndex = 10;
            // 
            // FrmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.PanPrincipal);
            this.Controls.Add(this.BarStatus);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "FrmMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMainMenu_Load);
            this.BarStatus.ResumeLayout(false);
            this.BarStatus.PerformLayout();
            this.PanPrincipal.Panel1.ResumeLayout(false);
            this.PanPrincipal.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PanPrincipal)).EndInit();
            this.PanPrincipal.ResumeLayout(false);
            this.PanMenu.Panel1.ResumeLayout(false);
            this.PanMenu.Panel1.PerformLayout();
            this.PanMenu.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PanMenu)).EndInit();
            this.PanMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImgModule)).EndInit();
            this.PanOption.ResumeLayout(false);
            this.PanDetail.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PanDetail)).EndInit();
            this.PanDetail.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip BarStatus;
        private System.Windows.Forms.ToolStripStatusLabel LblStatus;
        private System.Windows.Forms.SplitContainer PanPrincipal;
        private System.Windows.Forms.SplitContainer PanMenu;
        private System.Windows.Forms.PictureBox ImgModule;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.Label LblSearch;
        private System.Windows.Forms.Label LblModule;
        private System.Windows.Forms.FlowLayoutPanel PanOption;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.SplitContainer PanDetail;
        private System.Windows.Forms.Label LblTitle;
    }
}

