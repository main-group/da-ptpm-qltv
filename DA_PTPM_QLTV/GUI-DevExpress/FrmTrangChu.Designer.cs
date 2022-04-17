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
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnDocGia = new DevExpress.XtraBars.BarButtonItem();
            this.btnSach = new DevExpress.XtraBars.BarButtonItem();
            this.rbpDanhMuc = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.grcDSTheLoai = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcDSTheLoai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btnDocGia,
            this.btnSach});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ribbon.MaxItemId = 3;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rbpDanhMuc});
            this.ribbon.Size = new System.Drawing.Size(1027, 143);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btnDocGia
            // 
            this.btnDocGia.Caption = "Độc giả";
            this.btnDocGia.Glyph = ((System.Drawing.Image)(resources.GetObject("btnDocGia.Glyph")));
            this.btnDocGia.Id = 1;
            this.btnDocGia.Name = "btnDocGia";
            // 
            // btnSach
            // 
            this.btnSach.Caption = "Sách";
            this.btnSach.Glyph = ((System.Drawing.Image)(resources.GetObject("btnSach.Glyph")));
            this.btnSach.Id = 2;
            this.btnSach.Name = "btnSach";
            // 
            // rbpDanhMuc
            // 
            this.rbpDanhMuc.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.rbpDanhMuc.Name = "rbpDanhMuc";
            this.rbpDanhMuc.Text = "Danh mục";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDocGia);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnSach);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 586);
            this.ribbonStatusBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1027, 31);
            // 
            // grcDSTheLoai
            // 
            this.grcDSTheLoai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcDSTheLoai.Location = new System.Drawing.Point(0, 143);
            this.grcDSTheLoai.MainView = this.gridView1;
            this.grcDSTheLoai.MenuManager = this.ribbon;
            this.grcDSTheLoai.Name = "grcDSTheLoai";
            this.grcDSTheLoai.Size = new System.Drawing.Size(1027, 443);
            this.grcDSTheLoai.TabIndex = 2;
            this.grcDSTheLoai.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grcDSTheLoai;
            this.gridView1.Name = "gridView1";
            // 
            // FrmTrangChu
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 617);
            this.Controls.Add(this.grcDSTheLoai);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmTrangChu";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Trang chủ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmTrangChu_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcDSTheLoai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbpDanhMuc;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btnDocGia;
        private DevExpress.XtraBars.BarButtonItem btnSach;
        private DevExpress.XtraGrid.GridControl grcDSTheLoai;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}