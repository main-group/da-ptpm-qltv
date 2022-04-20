namespace GUI_DevExpress
{
    partial class FrmTrangChu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTrangChu));
            this.tlsTopMenu = new System.Windows.Forms.ToolStrip();
            this.btnHeThong = new System.Windows.Forms.ToolStripButton();
            this.btnThoat = new System.Windows.Forms.ToolStripButton();
            this.btnBaoCao = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.splCont = new System.Windows.Forms.SplitContainer();
            this.navMain = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.tlsTopMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splCont)).BeginInit();
            this.splCont.Panel1.SuspendLayout();
            this.splCont.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navMain)).BeginInit();
            this.SuspendLayout();
            // 
            // tlsTopMenu
            // 
            this.tlsTopMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnHeThong,
            this.toolStripSeparator1,
            this.btnBaoCao,
            this.toolStripSeparator2,
            this.btnThoat});
            this.tlsTopMenu.Location = new System.Drawing.Point(0, 0);
            this.tlsTopMenu.Name = "tlsTopMenu";
            this.tlsTopMenu.Size = new System.Drawing.Size(890, 25);
            this.tlsTopMenu.TabIndex = 0;
            this.tlsTopMenu.Text = "toolStrip1";
            // 
            // btnHeThong
            // 
            this.btnHeThong.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnHeThong.Image = ((System.Drawing.Image)(resources.GetObject("btnHeThong.Image")));
            this.btnHeThong.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHeThong.Name = "btnHeThong";
            this.btnHeThong.Size = new System.Drawing.Size(61, 22);
            this.btnHeThong.Text = "Hệ thống";
            // 
            // btnThoat
            // 
            this.btnThoat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(41, 22);
            this.btnThoat.Text = "Thoát";
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnBaoCao.Image = ((System.Drawing.Image)(resources.GetObject("btnBaoCao.Image")));
            this.btnBaoCao.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(53, 22);
            this.btnBaoCao.Text = "Báo cáo";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // splCont
            // 
            this.splCont.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splCont.Location = new System.Drawing.Point(0, 25);
            this.splCont.Name = "splCont";
            // 
            // splCont.Panel1
            // 
            this.splCont.Panel1.Controls.Add(this.navMain);
            this.splCont.Size = new System.Drawing.Size(890, 465);
            this.splCont.SplitterDistance = 201;
            this.splCont.TabIndex = 1;
            // 
            // navMain
            // 
            this.navMain.ActiveGroup = this.navBarGroup1;
            this.navMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navMain.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1});
            this.navMain.Location = new System.Drawing.Point(0, 0);
            this.navMain.Name = "navMain";
            this.navMain.Size = new System.Drawing.Size(201, 465);
            this.navMain.TabIndex = 0;
            this.navMain.Text = "navBarControl1";
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "navBarGroup1";
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // FrmTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 490);
            this.Controls.Add(this.splCont);
            this.Controls.Add(this.tlsTopMenu);
            this.Name = "FrmTrangChu";
            this.Text = "FrmTrangChu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmTrangChu_FormClosing);
            this.Load += new System.EventHandler(this.FrmTrangChu_Load);
            this.tlsTopMenu.ResumeLayout(false);
            this.tlsTopMenu.PerformLayout();
            this.splCont.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splCont)).EndInit();
            this.splCont.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tlsTopMenu;
        private System.Windows.Forms.ToolStripButton btnHeThong;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnBaoCao;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnThoat;
        private System.Windows.Forms.SplitContainer splCont;
        private DevExpress.XtraNavBar.NavBarControl navMain;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
    }
}