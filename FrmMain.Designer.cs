
namespace QLDSV_TC
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnQLSV = new DevExpress.XtraBars.BarButtonItem();
            this.btnQLLH = new DevExpress.XtraBars.BarButtonItem();
            this.btnQLMH = new DevExpress.XtraBars.BarButtonItem();
            this.btnQLLTC = new DevExpress.XtraBars.BarButtonItem();
            this.btnQLCD = new DevExpress.XtraBars.BarButtonItem();
            this.btnQLHP = new DevExpress.XtraBars.BarButtonItem();
            this.btnSVDK = new DevExpress.XtraBars.BarButtonItem();
            this.btnINDSLTC = new DevExpress.XtraBars.BarButtonItem();
            this.btnINDSSVDKLTC = new DevExpress.XtraBars.BarButtonItem();
            this.btnBĐMHLTC = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhieuDiem = new DevExpress.XtraBars.BarButtonItem();
            this.btnDSDHP = new DevExpress.XtraBars.BarButtonItem();
            this.btnBDTK = new DevExpress.XtraBars.BarButtonItem();
            this.btnDK = new DevExpress.XtraBars.BarButtonItem();
            this.btnLogout = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statuslblMa = new System.Windows.Forms.ToolStripStatusLabel();
            this.statuslblHoten = new System.Windows.Forms.ToolStripStatusLabel();
            this.statuslblNhom = new System.Windows.Forms.ToolStripStatusLabel();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.btnQLSV,
            this.btnQLLH,
            this.btnQLMH,
            this.btnQLLTC,
            this.btnQLCD,
            this.btnQLHP,
            this.btnSVDK,
            this.btnINDSLTC,
            this.btnINDSSVDKLTC,
            this.btnBĐMHLTC,
            this.btnPhieuDiem,
            this.btnDSDHP,
            this.btnBDTK,
            this.btnDK,
            this.btnLogout});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ribbon.MaxItemId = 17;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonPage3});
            this.ribbon.Size = new System.Drawing.Size(1222, 244);
            // 
            // btnQLSV
            // 
            this.btnQLSV.Caption = "SINH VIÊN";
            this.btnQLSV.Enabled = false;
            this.btnQLSV.Id = 1;
            this.btnQLSV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnQLSV.ImageOptions.Image")));
            this.btnQLSV.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnQLSV.ImageOptions.LargeImage")));
            this.btnQLSV.Name = "btnQLSV";
            this.btnQLSV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnQLSV_ItemClick);
            // 
            // btnQLLH
            // 
            this.btnQLLH.Caption = "LỚP";
            this.btnQLLH.Enabled = false;
            this.btnQLLH.Id = 2;
            this.btnQLLH.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnQLLH.ImageOptions.Image")));
            this.btnQLLH.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnQLLH.ImageOptions.LargeImage")));
            this.btnQLLH.Name = "btnQLLH";
            this.btnQLLH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnQLLH_ItemClick);
            // 
            // btnQLMH
            // 
            this.btnQLMH.Caption = "MÔN HỌC";
            this.btnQLMH.Enabled = false;
            this.btnQLMH.Id = 3;
            this.btnQLMH.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnQLMH.ImageOptions.Image")));
            this.btnQLMH.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnQLMH.ImageOptions.LargeImage")));
            this.btnQLMH.Name = "btnQLMH";
            this.btnQLMH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnQLMH_ItemClick);
            // 
            // btnQLLTC
            // 
            this.btnQLLTC.Caption = "LỚP TÍN CHỈ";
            this.btnQLLTC.Enabled = false;
            this.btnQLLTC.Id = 4;
            this.btnQLLTC.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnQLLTC.ImageOptions.Image")));
            this.btnQLLTC.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnQLLTC.ImageOptions.LargeImage")));
            this.btnQLLTC.Name = "btnQLLTC";
            this.btnQLLTC.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnQLLTC_ItemClick);
            // 
            // btnQLCD
            // 
            this.btnQLCD.Caption = "ĐIỂM";
            this.btnQLCD.Enabled = false;
            this.btnQLCD.Id = 5;
            this.btnQLCD.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnQLCD.ImageOptions.Image")));
            this.btnQLCD.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnQLCD.ImageOptions.LargeImage")));
            this.btnQLCD.Name = "btnQLCD";
            this.btnQLCD.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnQLCD_ItemClick);
            // 
            // btnQLHP
            // 
            this.btnQLHP.Caption = "HỌC PHÍ";
            this.btnQLHP.Enabled = false;
            this.btnQLHP.Id = 6;
            this.btnQLHP.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnQLHP.ImageOptions.Image")));
            this.btnQLHP.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnQLHP.ImageOptions.LargeImage")));
            this.btnQLHP.Name = "btnQLHP";
            this.btnQLHP.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnQLHP_ItemClick);
            // 
            // btnSVDK
            // 
            this.btnSVDK.Caption = "ĐĂNG KÝ";
            this.btnSVDK.Enabled = false;
            this.btnSVDK.Id = 7;
            this.btnSVDK.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSVDK.ImageOptions.Image")));
            this.btnSVDK.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSVDK.ImageOptions.LargeImage")));
            this.btnSVDK.Name = "btnSVDK";
            this.btnSVDK.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSVDK_ItemClick);
            // 
            // btnINDSLTC
            // 
            this.btnINDSLTC.Caption = "DS LỚP TÍN CHỈ";
            this.btnINDSLTC.Id = 8;
            this.btnINDSLTC.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnINDSLTC.ImageOptions.Image")));
            this.btnINDSLTC.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnINDSLTC.ImageOptions.LargeImage")));
            this.btnINDSLTC.Name = "btnINDSLTC";
            this.btnINDSLTC.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnINDSLTC.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnINDSLTC_ItemClick);
            // 
            // btnINDSSVDKLTC
            // 
            this.btnINDSSVDKLTC.Caption = "DSSV ĐK LỚP TC";
            this.btnINDSSVDKLTC.Id = 9;
            this.btnINDSSVDKLTC.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnINDSSVDKLTC.ImageOptions.Image")));
            this.btnINDSSVDKLTC.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnINDSSVDKLTC.ImageOptions.LargeImage")));
            this.btnINDSSVDKLTC.Name = "btnINDSSVDKLTC";
            this.btnINDSSVDKLTC.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnINDSSVDKLTC.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnINDSSVDKLTC_ItemClick);
            // 
            // btnBĐMHLTC
            // 
            this.btnBĐMHLTC.Caption = "BẢNG ĐIỂM MH LỚP TC";
            this.btnBĐMHLTC.Id = 10;
            this.btnBĐMHLTC.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBĐMHLTC.ImageOptions.Image")));
            this.btnBĐMHLTC.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnBĐMHLTC.ImageOptions.LargeImage")));
            this.btnBĐMHLTC.Name = "btnBĐMHLTC";
            this.btnBĐMHLTC.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnBĐMHLTC.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBĐMHLTC_ItemClick);
            // 
            // btnPhieuDiem
            // 
            this.btnPhieuDiem.Caption = "PHIẾU ĐIỂM";
            this.btnPhieuDiem.Id = 11;
            this.btnPhieuDiem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPhieuDiem.ImageOptions.Image")));
            this.btnPhieuDiem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPhieuDiem.ImageOptions.LargeImage")));
            this.btnPhieuDiem.Name = "btnPhieuDiem";
            this.btnPhieuDiem.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnPhieuDiem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhieuDiem_ItemClick);
            // 
            // btnDSDHP
            // 
            this.btnDSDHP.Caption = "DS ĐÓNG HP";
            this.btnDSDHP.Id = 12;
            this.btnDSDHP.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDSDHP.ImageOptions.Image")));
            this.btnDSDHP.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDSDHP.ImageOptions.LargeImage")));
            this.btnDSDHP.Name = "btnDSDHP";
            this.btnDSDHP.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnDSDHP.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDSDHP_ItemClick);
            // 
            // btnBDTK
            // 
            this.btnBDTK.Caption = "BẢNG ĐIỂM TỔNG KẾT";
            this.btnBDTK.Id = 13;
            this.btnBDTK.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBDTK.ImageOptions.Image")));
            this.btnBDTK.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnBDTK.ImageOptions.LargeImage")));
            this.btnBDTK.Name = "btnBDTK";
            this.btnBDTK.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnBDTK.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBDTK_ItemClick);
            // 
            // btnDK
            // 
            this.btnDK.Caption = "ĐĂNG KÝ";
            this.btnDK.Enabled = false;
            this.btnDK.Id = 14;
            this.btnDK.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDK.ImageOptions.Image")));
            this.btnDK.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDK.ImageOptions.LargeImage")));
            this.btnDK.Name = "btnDK";
            this.btnDK.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDK_ItemClick);
            // 
            // btnLogout
            // 
            this.btnLogout.Caption = "ĐĂNG XUẤT";
            this.btnLogout.Id = 15;
            this.btnLogout.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.ImageOptions.Image")));
            this.btnLogout.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLogout.ImageOptions.LargeImage")));
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLogout_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage1.ImageOptions.Image")));
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "QUẢN TRỊ";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnQLSV);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnQLLH);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnQLMH);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnQLLTC);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnQLCD);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnQLHP);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnSVDK);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "QUẢN LÝ CHUNG";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPage2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage2.ImageOptions.Image")));
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "BÁO CÁO";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnINDSLTC);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnINDSSVDKLTC);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnBĐMHLTC);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnPhieuDiem);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnDSDHP);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnBDTK);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "QUẢN LÝ BÁO CÁO";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.ribbonPage3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage3.ImageOptions.Image")));
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "HỆ THỐNG";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnDK);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnLogout);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "QUẢN LÝ HỆ THỐNG";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statuslblMa,
            this.statuslblHoten,
            this.statuslblNhom});
            this.statusStrip1.Location = new System.Drawing.Point(0, 534);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1222, 32);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statuslblMa
            // 
            this.statuslblMa.Name = "statuslblMa";
            this.statuslblMa.Size = new System.Drawing.Size(44, 25);
            this.statuslblMa.Text = "MÃ:";
            // 
            // statuslblHoten
            // 
            this.statuslblHoten.Name = "statuslblHoten";
            this.statuslblHoten.Size = new System.Drawing.Size(106, 25);
            this.statuslblHoten.Text = "HỌ VÀ TÊN:";
            // 
            // statuslblNhom
            // 
            this.statuslblNhom.Name = "statuslblNhom";
            this.statuslblNhom.Size = new System.Drawing.Size(72, 25);
            this.statuslblNhom.Text = "NHÓM:";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 566);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "FrmMain";
            this.Ribbon = this.ribbon;
            this.Text = "Trang chủ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnQLSV;
        private DevExpress.XtraBars.BarButtonItem btnQLLH;
        private DevExpress.XtraBars.BarButtonItem btnQLMH;
        private DevExpress.XtraBars.BarButtonItem btnQLLTC;
        private DevExpress.XtraBars.BarButtonItem btnQLCD;
        private DevExpress.XtraBars.BarButtonItem btnQLHP;
        private DevExpress.XtraBars.BarButtonItem btnSVDK;
        private DevExpress.XtraBars.BarButtonItem btnINDSLTC;
        private DevExpress.XtraBars.BarButtonItem btnINDSSVDKLTC;
        private DevExpress.XtraBars.BarButtonItem btnBĐMHLTC;
        private DevExpress.XtraBars.BarButtonItem btnPhieuDiem;
        private DevExpress.XtraBars.BarButtonItem btnDSDHP;
        private DevExpress.XtraBars.BarButtonItem btnBDTK;
        private DevExpress.XtraBars.BarButtonItem btnDK;
        private DevExpress.XtraBars.BarButtonItem btnLogout;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel statuslblMa;
        public System.Windows.Forms.ToolStripStatusLabel statuslblHoten;
        public System.Windows.Forms.ToolStripStatusLabel statuslblNhom;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
    }
}