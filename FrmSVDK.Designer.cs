
namespace QLDSV_TC
{
    partial class FrmSVDK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSVDK));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cbHOCKY = new System.Windows.Forms.ComboBox();
            this.cbNIENKHOA = new System.Windows.Forms.ComboBox();
            this.txtHOTEN = new DevExpress.XtraEditors.TextEdit();
            this.txtMALOP = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnHuyDangKy = new DevExpress.XtraEditors.SimpleButton();
            this.btnDangKy = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.bdsDSDK = new System.Windows.Forms.BindingSource(this.components);
            this.qldsV_TCDataSet = new QLDSV_TC.QLDSV_TCDataSet();
            this.gridViewRegister = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAMH1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENMH1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNHOM1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTIET_LT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTIET_TH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOCPHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bdsDSLTC = new System.Windows.Forms.BindingSource(this.components);
            this.SP_GETDSLTC_NK_HKTableAdapter = new QLDSV_TC.QLDSV_TCDataSetTableAdapters.SP_GETDSLTC_NK_HKTableAdapter();
            this.SP_DSDK_SVTableAdapter = new QLDSV_TC.QLDSV_TCDataSetTableAdapters.SP_DSDK_SVTableAdapter();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridViewCreditClass = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNHOM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOSV = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHOTEN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMALOP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSDK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qldsV_TCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRegister)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSLTC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCreditClass)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelControl1.Location = new System.Drawing.Point(-3, 18);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(2218, 48);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ĐĂNG KÝ LỚP TÍN CHỈ";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cbHOCKY);
            this.panelControl1.Controls.Add(this.cbNIENKHOA);
            this.panelControl1.Controls.Add(this.txtHOTEN);
            this.panelControl1.Controls.Add(this.txtMALOP);
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Location = new System.Drawing.Point(-3, 123);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(899, 279);
            this.panelControl1.TabIndex = 1;
            // 
            // cbHOCKY
            // 
            this.cbHOCKY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHOCKY.FormattingEnabled = true;
            this.cbHOCKY.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cbHOCKY.Location = new System.Drawing.Point(477, 159);
            this.cbHOCKY.Margin = new System.Windows.Forms.Padding(4);
            this.cbHOCKY.Name = "cbHOCKY";
            this.cbHOCKY.Size = new System.Drawing.Size(360, 27);
            this.cbHOCKY.TabIndex = 7;
            this.cbHOCKY.SelectedIndexChanged += new System.EventHandler(this.cbHOCKY_SelectedIndexChanged);
            // 
            // cbNIENKHOA
            // 
            this.cbNIENKHOA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNIENKHOA.FormattingEnabled = true;
            this.cbNIENKHOA.Location = new System.Drawing.Point(505, 28);
            this.cbNIENKHOA.Margin = new System.Windows.Forms.Padding(4);
            this.cbNIENKHOA.Name = "cbNIENKHOA";
            this.cbNIENKHOA.Size = new System.Drawing.Size(316, 27);
            this.cbNIENKHOA.TabIndex = 6;
            this.cbNIENKHOA.SelectedIndexChanged += new System.EventHandler(this.cbNIENKHOA_SelectedIndexChanged);
            // 
            // txtHOTEN
            // 
            this.txtHOTEN.Location = new System.Drawing.Point(88, 147);
            this.txtHOTEN.Margin = new System.Windows.Forms.Padding(4);
            this.txtHOTEN.Name = "txtHOTEN";
            this.txtHOTEN.Properties.ReadOnly = true;
            this.txtHOTEN.Size = new System.Drawing.Size(280, 28);
            this.txtHOTEN.TabIndex = 5;
            // 
            // txtMALOP
            // 
            this.txtMALOP.Location = new System.Drawing.Point(88, 27);
            this.txtMALOP.Margin = new System.Windows.Forms.Padding(4);
            this.txtMALOP.Name = "txtMALOP";
            this.txtMALOP.Properties.ReadOnly = true;
            this.txtMALOP.Size = new System.Drawing.Size(280, 28);
            this.txtMALOP.TabIndex = 4;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(406, 162);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(63, 19);
            this.labelControl5.TabIndex = 3;
            this.labelControl5.Text = "HỌC KỲ:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(406, 31);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(91, 19);
            this.labelControl4.TabIndex = 2;
            this.labelControl4.Text = "NIÊN KHÓA:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(16, 154);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(64, 19);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "HỌ TÊN:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(16, 31);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(63, 19);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "MÃ LỚP:";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnThoat);
            this.panelControl2.Controls.Add(this.btnHuyDangKy);
            this.panelControl2.Controls.Add(this.btnDangKy);
            this.panelControl2.Location = new System.Drawing.Point(904, 123);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(656, 279);
            this.panelControl2.TabIndex = 2;
            // 
            // btnThoat
            // 
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.Location = new System.Drawing.Point(451, 88);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(117, 72);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnHuyDangKy
            // 
            this.btnHuyDangKy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHuyDangKy.ImageOptions.Image")));
            this.btnHuyDangKy.Location = new System.Drawing.Point(252, 88);
            this.btnHuyDangKy.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuyDangKy.Name = "btnHuyDangKy";
            this.btnHuyDangKy.Size = new System.Drawing.Size(168, 72);
            this.btnHuyDangKy.TabIndex = 1;
            this.btnHuyDangKy.Text = "HỦY ĐĂNG KÝ";
            this.btnHuyDangKy.Click += new System.EventHandler(this.btnHuyDangKy_Click);
            // 
            // btnDangKy
            // 
            this.btnDangKy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDangKy.ImageOptions.Image")));
            this.btnDangKy.Location = new System.Drawing.Point(70, 88);
            this.btnDangKy.Margin = new System.Windows.Forms.Padding(4);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(146, 72);
            this.btnDangKy.TabIndex = 0;
            this.btnDangKy.Text = "ĐĂNG KÝ";
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // gridControl2
            // 
            this.gridControl2.DataSource = this.bdsDSDK;
            this.gridControl2.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gridControl2.Location = new System.Drawing.Point(-3, 723);
            this.gridControl2.MainView = this.gridViewRegister;
            this.gridControl2.Margin = new System.Windows.Forms.Padding(4);
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(2487, 300);
            this.gridControl2.TabIndex = 4;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewRegister});
            // 
            // bdsDSDK
            // 
            this.bdsDSDK.DataMember = "SP_DSDK_SV";
            this.bdsDSDK.DataSource = this.qldsV_TCDataSet;
            // 
            // qldsV_TCDataSet
            // 
            this.qldsV_TCDataSet.DataSetName = "QLDSV_TCDataSet";
            this.qldsV_TCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridViewRegister
            // 
            this.gridViewRegister.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAMH1,
            this.colTENMH1,
            this.colNHOM1,
            this.colSOTIET_LT,
            this.colSOTIET_TH,
            this.colSTC,
            this.colHOCPHI});
            this.gridViewRegister.DetailHeight = 525;
            this.gridViewRegister.FixedLineWidth = 3;
            this.gridViewRegister.GridControl = this.gridControl2;
            this.gridViewRegister.Name = "gridViewRegister";
            this.gridViewRegister.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridViewRegister_RowClick);
            // 
            // colMAMH1
            // 
            this.colMAMH1.Caption = "Mã môn học";
            this.colMAMH1.FieldName = "MAMH";
            this.colMAMH1.MinWidth = 45;
            this.colMAMH1.Name = "colMAMH1";
            this.colMAMH1.Visible = true;
            this.colMAMH1.VisibleIndex = 0;
            this.colMAMH1.Width = 168;
            // 
            // colTENMH1
            // 
            this.colTENMH1.Caption = "Tên môn học";
            this.colTENMH1.FieldName = "TENMH";
            this.colTENMH1.MinWidth = 45;
            this.colTENMH1.Name = "colTENMH1";
            this.colTENMH1.Visible = true;
            this.colTENMH1.VisibleIndex = 1;
            this.colTENMH1.Width = 168;
            // 
            // colNHOM1
            // 
            this.colNHOM1.Caption = "Nhóm";
            this.colNHOM1.FieldName = "NHOM";
            this.colNHOM1.MinWidth = 45;
            this.colNHOM1.Name = "colNHOM1";
            this.colNHOM1.Visible = true;
            this.colNHOM1.VisibleIndex = 2;
            this.colNHOM1.Width = 168;
            // 
            // colSOTIET_LT
            // 
            this.colSOTIET_LT.Caption = "Số tiết lý thuyết";
            this.colSOTIET_LT.FieldName = "SOTIET_LT";
            this.colSOTIET_LT.MinWidth = 45;
            this.colSOTIET_LT.Name = "colSOTIET_LT";
            this.colSOTIET_LT.Visible = true;
            this.colSOTIET_LT.VisibleIndex = 3;
            this.colSOTIET_LT.Width = 168;
            // 
            // colSOTIET_TH
            // 
            this.colSOTIET_TH.Caption = "Số tiết thực hành";
            this.colSOTIET_TH.FieldName = "SOTIET_TH";
            this.colSOTIET_TH.MinWidth = 45;
            this.colSOTIET_TH.Name = "colSOTIET_TH";
            this.colSOTIET_TH.Visible = true;
            this.colSOTIET_TH.VisibleIndex = 4;
            this.colSOTIET_TH.Width = 168;
            // 
            // colSTC
            // 
            this.colSTC.Caption = "Số tín chỉ";
            this.colSTC.FieldName = "STC";
            this.colSTC.MinWidth = 45;
            this.colSTC.Name = "colSTC";
            this.colSTC.Visible = true;
            this.colSTC.VisibleIndex = 5;
            this.colSTC.Width = 168;
            // 
            // colHOCPHI
            // 
            this.colHOCPHI.Caption = "Học phí";
            this.colHOCPHI.FieldName = "HOCPHI";
            this.colHOCPHI.MinWidth = 45;
            this.colHOCPHI.Name = "colHOCPHI";
            this.colHOCPHI.Visible = true;
            this.colHOCPHI.VisibleIndex = 6;
            this.colHOCPHI.Width = 168;
            // 
            // bdsDSLTC
            // 
            this.bdsDSLTC.DataMember = "SP_GETDSLTC_NK_HK";
            this.bdsDSLTC.DataSource = this.qldsV_TCDataSet;
            // 
            // SP_GETDSLTC_NK_HKTableAdapter
            // 
            this.SP_GETDSLTC_NK_HKTableAdapter.ClearBeforeFill = true;
            // 
            // SP_DSDK_SVTableAdapter
            // 
            this.SP_DSDK_SVTableAdapter.ClearBeforeFill = true;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.bdsDSLTC;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gridControl1.Location = new System.Drawing.Point(-3, 392);
            this.gridControl1.MainView = this.gridViewCreditClass;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(4);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1886, 324);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCreditClass});
            // 
            // gridViewCreditClass
            // 
            this.gridViewCreditClass.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAMH,
            this.colTENMH,
            this.colNHOM,
            this.colHOTEN,
            this.colSOSV});
            this.gridViewCreditClass.DetailHeight = 525;
            this.gridViewCreditClass.FixedLineWidth = 3;
            this.gridViewCreditClass.GridControl = this.gridControl1;
            this.gridViewCreditClass.Name = "gridViewCreditClass";
            this.gridViewCreditClass.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridViewCreditClass_RowClick);
            // 
            // colMAMH
            // 
            this.colMAMH.Caption = "Mã môn học";
            this.colMAMH.FieldName = "MAMH";
            this.colMAMH.MinWidth = 45;
            this.colMAMH.Name = "colMAMH";
            this.colMAMH.Visible = true;
            this.colMAMH.VisibleIndex = 0;
            this.colMAMH.Width = 168;
            // 
            // colTENMH
            // 
            this.colTENMH.Caption = "Tên môn học";
            this.colTENMH.FieldName = "TENMH";
            this.colTENMH.MinWidth = 45;
            this.colTENMH.Name = "colTENMH";
            this.colTENMH.Visible = true;
            this.colTENMH.VisibleIndex = 1;
            this.colTENMH.Width = 168;
            // 
            // colNHOM
            // 
            this.colNHOM.Caption = "Nhóm";
            this.colNHOM.FieldName = "NHOM";
            this.colNHOM.MinWidth = 45;
            this.colNHOM.Name = "colNHOM";
            this.colNHOM.Visible = true;
            this.colNHOM.VisibleIndex = 2;
            this.colNHOM.Width = 168;
            // 
            // colHOTEN
            // 
            this.colHOTEN.Caption = "Họ và tên GV";
            this.colHOTEN.FieldName = "HOTEN";
            this.colHOTEN.MinWidth = 45;
            this.colHOTEN.Name = "colHOTEN";
            this.colHOTEN.Visible = true;
            this.colHOTEN.VisibleIndex = 3;
            this.colHOTEN.Width = 168;
            // 
            // colSOSV
            // 
            this.colSOSV.Caption = "Số sinh viên";
            this.colSOSV.FieldName = "SOSV";
            this.colSOSV.MinWidth = 45;
            this.colSOSV.Name = "colSOSV";
            this.colSOSV.Visible = true;
            this.colSOSV.VisibleIndex = 4;
            this.colSOSV.Width = 168;
            // 
            // FrmSVDK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1545, 700);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.gridControl2);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.labelControl1);
            this.Name = "FrmSVDK";
            this.Text = "Sinh viên đăng ký";
            this.Load += new System.EventHandler(this.FrmSVDK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHOTEN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMALOP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSDK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qldsV_TCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRegister)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSLTC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCreditClass)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.ComboBox cbHOCKY;
        private System.Windows.Forms.ComboBox cbNIENKHOA;
        private DevExpress.XtraEditors.TextEdit txtHOTEN;
        private DevExpress.XtraEditors.TextEdit txtMALOP;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewRegister;
        private QLDSV_TCDataSet qldsV_TCDataSet;
        private System.Windows.Forms.BindingSource bdsDSLTC;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnHuyDangKy;
        private DevExpress.XtraEditors.SimpleButton btnDangKy;
        private System.Windows.Forms.BindingSource bdsDSDK;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH1;
        private DevExpress.XtraGrid.Columns.GridColumn colTENMH1;
        private DevExpress.XtraGrid.Columns.GridColumn colNHOM1;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTIET_LT;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTIET_TH;
        private DevExpress.XtraGrid.Columns.GridColumn colSTC;
        private DevExpress.XtraGrid.Columns.GridColumn colHOCPHI;
        private QLDSV_TCDataSetTableAdapters.SP_GETDSLTC_NK_HKTableAdapter SP_GETDSLTC_NK_HKTableAdapter;
        private QLDSV_TCDataSetTableAdapters.SP_DSDK_SVTableAdapter SP_DSDK_SVTableAdapter;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCreditClass;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH;
        private DevExpress.XtraGrid.Columns.GridColumn colTENMH;
        private DevExpress.XtraGrid.Columns.GridColumn colNHOM;
        private DevExpress.XtraGrid.Columns.GridColumn colHOTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colSOSV;
    }
}