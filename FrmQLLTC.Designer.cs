
namespace QLDSV_TC
{
    partial class FrmQLLTC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQLLTC));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cbKhoa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.qldsV_TCDataSet = new QLDSV_TC.QLDSV_TCDataSet();
            this.bdsMONHOC = new System.Windows.Forms.BindingSource(this.components);
            this.MONHOCTableAdapter = new QLDSV_TC.QLDSV_TCDataSetTableAdapters.MONHOCTableAdapter();
            this.bdsLOPTINCHI = new System.Windows.Forms.BindingSource(this.components);
            this.LOPTINCHITableAdapter = new QLDSV_TC.QLDSV_TCDataSetTableAdapters.LOPTINCHITableAdapter();
            this.bdsDANGKY = new System.Windows.Forms.BindingSource(this.components);
            this.DANGKYTableAdapter = new QLDSV_TC.QLDSV_TCDataSetTableAdapters.DANGKYTableAdapter();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridViewSubject = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTIET_LT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTIET_TH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridViewCreditClass = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNIENKHOA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOCKY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbHOCKY = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.colMAMH1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lookUpEditMH = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colNHOM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.spinEditNHOM = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.colMAGV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lookUpEditGV = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colSOSVTOITHIEU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.spinEditSOSV = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.colHUYLOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKHOA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnTaiLai = new DevExpress.XtraEditors.SimpleButton();
            this.btnGhi = new DevExpress.XtraEditors.SimpleButton();
            this.btnPhucHoi = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qldsV_TCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMONHOC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLOPTINCHI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDANGKY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSubject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCreditClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbHOCKY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditMH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditNHOM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditSOSV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelControl1.Location = new System.Drawing.Point(1, 13);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(1465, 48);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "QUẢN LÝ LỚP TÍN CHỈ";
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.cbKhoa);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Location = new System.Drawing.Point(1, 68);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1465, 57);
            this.panelControl1.TabIndex = 1;
            // 
            // cbKhoa
            // 
            this.cbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKhoa.FormattingEnabled = true;
            this.cbKhoa.Location = new System.Drawing.Point(597, 13);
            this.cbKhoa.Name = "cbKhoa";
            this.cbKhoa.Size = new System.Drawing.Size(342, 27);
            this.cbKhoa.TabIndex = 1;
            this.cbKhoa.SelectedIndexChanged += new System.EventHandler(this.cbKhoa_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(533, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "KHOA:";
            // 
            // qldsV_TCDataSet
            // 
            this.qldsV_TCDataSet.DataSetName = "QLDSV_TCDataSet";
            this.qldsV_TCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsMONHOC
            // 
            this.bdsMONHOC.DataMember = "MONHOC";
            this.bdsMONHOC.DataSource = this.qldsV_TCDataSet;
            // 
            // MONHOCTableAdapter
            // 
            this.MONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // bdsLOPTINCHI
            // 
            this.bdsLOPTINCHI.DataMember = "FK_LOPTINCHI_MONHOC";
            this.bdsLOPTINCHI.DataSource = this.bdsMONHOC;
            // 
            // LOPTINCHITableAdapter
            // 
            this.LOPTINCHITableAdapter.ClearBeforeFill = true;
            // 
            // bdsDANGKY
            // 
            this.bdsDANGKY.DataMember = "FK_DANGKY_LOPTINCHI";
            this.bdsDANGKY.DataSource = this.bdsLOPTINCHI;
            // 
            // DANGKYTableAdapter
            // 
            this.DANGKYTableAdapter.ClearBeforeFill = true;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.bdsMONHOC;
            this.gridControl1.Location = new System.Drawing.Point(12, 131);
            this.gridControl1.MainView = this.gridViewSubject;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(870, 236);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewSubject});
            // 
            // gridViewSubject
            // 
            this.gridViewSubject.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAMH,
            this.colTENMH,
            this.colSOTIET_LT,
            this.colSOTIET_TH});
            this.gridViewSubject.GridControl = this.gridControl1;
            this.gridViewSubject.Name = "gridViewSubject";
            this.gridViewSubject.OptionsBehavior.Editable = false;
            this.gridViewSubject.OptionsBehavior.ReadOnly = true;
            this.gridViewSubject.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridViewSubject_RowClick);
            // 
            // colMAMH
            // 
            this.colMAMH.Caption = "MÃ MÔN HỌC";
            this.colMAMH.FieldName = "MAMH";
            this.colMAMH.MinWidth = 30;
            this.colMAMH.Name = "colMAMH";
            this.colMAMH.Visible = true;
            this.colMAMH.VisibleIndex = 0;
            this.colMAMH.Width = 112;
            // 
            // colTENMH
            // 
            this.colTENMH.Caption = "TÊN MÔN HỌC";
            this.colTENMH.FieldName = "TENMH";
            this.colTENMH.MinWidth = 30;
            this.colTENMH.Name = "colTENMH";
            this.colTENMH.Visible = true;
            this.colTENMH.VisibleIndex = 1;
            this.colTENMH.Width = 112;
            // 
            // colSOTIET_LT
            // 
            this.colSOTIET_LT.Caption = "SỐ TIẾT LÝ THUYẾT";
            this.colSOTIET_LT.FieldName = "SOTIET_LT";
            this.colSOTIET_LT.MinWidth = 30;
            this.colSOTIET_LT.Name = "colSOTIET_LT";
            this.colSOTIET_LT.Visible = true;
            this.colSOTIET_LT.VisibleIndex = 2;
            this.colSOTIET_LT.Width = 112;
            // 
            // colSOTIET_TH
            // 
            this.colSOTIET_TH.Caption = "SỐ TIẾT THỰC HÀNH";
            this.colSOTIET_TH.FieldName = "SOTIET_TH";
            this.colSOTIET_TH.MinWidth = 30;
            this.colSOTIET_TH.Name = "colSOTIET_TH";
            this.colSOTIET_TH.Visible = true;
            this.colSOTIET_TH.VisibleIndex = 3;
            this.colSOTIET_TH.Width = 112;
            // 
            // gridControl2
            // 
            this.gridControl2.DataSource = this.bdsLOPTINCHI;
            this.gridControl2.Location = new System.Drawing.Point(888, 131);
            this.gridControl2.MainView = this.gridViewCreditClass;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.lookUpEditGV,
            this.lookUpEditMH,
            this.cbHOCKY,
            this.spinEditNHOM,
            this.spinEditSOSV});
            this.gridControl2.Size = new System.Drawing.Size(1027, 236);
            this.gridControl2.TabIndex = 3;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCreditClass});
            // 
            // gridViewCreditClass
            // 
            this.gridViewCreditClass.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNIENKHOA,
            this.colHOCKY,
            this.colMAMH1,
            this.colNHOM,
            this.colMAGV,
            this.colSOSVTOITHIEU,
            this.colHUYLOP,
            this.colKHOA});
            this.gridViewCreditClass.GridControl = this.gridControl2;
            this.gridViewCreditClass.Name = "gridViewCreditClass";
            this.gridViewCreditClass.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridViewCreditClass_RowClick);
            this.gridViewCreditClass.ShowingEditor += new System.ComponentModel.CancelEventHandler(this.gridViewCreditClass_ShowingEditor);
            this.gridViewCreditClass.ValidatingEditor += new DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventHandler(this.gridViewCreditClass_ValidatingEditor);
            // 
            // colNIENKHOA
            // 
            this.colNIENKHOA.Caption = "NIÊN KHÓA";
            this.colNIENKHOA.FieldName = "NIENKHOA";
            this.colNIENKHOA.MinWidth = 30;
            this.colNIENKHOA.Name = "colNIENKHOA";
            this.colNIENKHOA.Visible = true;
            this.colNIENKHOA.VisibleIndex = 0;
            this.colNIENKHOA.Width = 112;
            // 
            // colHOCKY
            // 
            this.colHOCKY.Caption = "HỌC KỲ";
            this.colHOCKY.ColumnEdit = this.cbHOCKY;
            this.colHOCKY.FieldName = "HOCKY";
            this.colHOCKY.MinWidth = 30;
            this.colHOCKY.Name = "colHOCKY";
            this.colHOCKY.Visible = true;
            this.colHOCKY.VisibleIndex = 1;
            this.colHOCKY.Width = 112;
            // 
            // cbHOCKY
            // 
            this.cbHOCKY.AutoHeight = false;
            this.cbHOCKY.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbHOCKY.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cbHOCKY.Name = "cbHOCKY";
            this.cbHOCKY.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // colMAMH1
            // 
            this.colMAMH1.Caption = "MÃ MÔN HỌC";
            this.colMAMH1.ColumnEdit = this.lookUpEditMH;
            this.colMAMH1.FieldName = "MAMH";
            this.colMAMH1.MinWidth = 30;
            this.colMAMH1.Name = "colMAMH1";
            this.colMAMH1.Visible = true;
            this.colMAMH1.VisibleIndex = 2;
            this.colMAMH1.Width = 112;
            // 
            // lookUpEditMH
            // 
            this.lookUpEditMH.AutoHeight = false;
            this.lookUpEditMH.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditMH.Name = "lookUpEditMH";
            // 
            // colNHOM
            // 
            this.colNHOM.Caption = "NHÓM";
            this.colNHOM.ColumnEdit = this.spinEditNHOM;
            this.colNHOM.FieldName = "NHOM";
            this.colNHOM.MinWidth = 30;
            this.colNHOM.Name = "colNHOM";
            this.colNHOM.Visible = true;
            this.colNHOM.VisibleIndex = 3;
            this.colNHOM.Width = 112;
            // 
            // spinEditNHOM
            // 
            this.spinEditNHOM.AutoHeight = false;
            this.spinEditNHOM.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEditNHOM.IsFloatValue = false;
            this.spinEditNHOM.Mask.EditMask = "N00";
            this.spinEditNHOM.MaxValue = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.spinEditNHOM.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinEditNHOM.Name = "spinEditNHOM";
            // 
            // colMAGV
            // 
            this.colMAGV.ColumnEdit = this.lookUpEditGV;
            this.colMAGV.FieldName = "MAGV";
            this.colMAGV.MinWidth = 30;
            this.colMAGV.Name = "colMAGV";
            this.colMAGV.Visible = true;
            this.colMAGV.VisibleIndex = 4;
            this.colMAGV.Width = 112;
            // 
            // lookUpEditGV
            // 
            this.lookUpEditGV.AutoHeight = false;
            this.lookUpEditGV.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditGV.Name = "lookUpEditGV";
            this.lookUpEditGV.NullText = "Vui lòng chọn giảng viên";
            // 
            // colSOSVTOITHIEU
            // 
            this.colSOSVTOITHIEU.ColumnEdit = this.spinEditSOSV;
            this.colSOSVTOITHIEU.FieldName = "SOSVTOITHIEU";
            this.colSOSVTOITHIEU.MinWidth = 30;
            this.colSOSVTOITHIEU.Name = "colSOSVTOITHIEU";
            this.colSOSVTOITHIEU.Visible = true;
            this.colSOSVTOITHIEU.VisibleIndex = 5;
            this.colSOSVTOITHIEU.Width = 112;
            // 
            // spinEditSOSV
            // 
            this.spinEditSOSV.AutoHeight = false;
            this.spinEditSOSV.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEditSOSV.IsFloatValue = false;
            this.spinEditSOSV.Mask.EditMask = "N00";
            this.spinEditSOSV.MaxValue = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.spinEditSOSV.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinEditSOSV.Name = "spinEditSOSV";
            // 
            // colHUYLOP
            // 
            this.colHUYLOP.FieldName = "HUYLOP";
            this.colHUYLOP.MinWidth = 30;
            this.colHUYLOP.Name = "colHUYLOP";
            this.colHUYLOP.Visible = true;
            this.colHUYLOP.VisibleIndex = 6;
            this.colHUYLOP.Width = 112;
            // 
            // colKHOA
            // 
            this.colKHOA.Caption = "KHOA";
            this.colKHOA.FieldName = "MAKHOA";
            this.colKHOA.MinWidth = 30;
            this.colKHOA.Name = "colKHOA";
            this.colKHOA.Width = 112;
            // 
            // panelControl2
            // 
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Controls.Add(this.btnThoat);
            this.panelControl2.Controls.Add(this.btnTaiLai);
            this.panelControl2.Controls.Add(this.btnGhi);
            this.panelControl2.Controls.Add(this.btnPhucHoi);
            this.panelControl2.Controls.Add(this.btnSua);
            this.panelControl2.Controls.Add(this.btnXoa);
            this.panelControl2.Controls.Add(this.btnThem);
            this.panelControl2.Location = new System.Drawing.Point(1, 396);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1465, 100);
            this.panelControl2.TabIndex = 4;
            // 
            // btnThoat
            // 
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.Location = new System.Drawing.Point(1176, 17);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(150, 71);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnTaiLai
            // 
            this.btnTaiLai.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTaiLai.ImageOptions.Image")));
            this.btnTaiLai.Location = new System.Drawing.Point(989, 17);
            this.btnTaiLai.Name = "btnTaiLai";
            this.btnTaiLai.Size = new System.Drawing.Size(154, 71);
            this.btnTaiLai.TabIndex = 5;
            this.btnTaiLai.Text = "Tải lại";
            this.btnTaiLai.Click += new System.EventHandler(this.btnTaiLai_Click);
            // 
            // btnGhi
            // 
            this.btnGhi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.Image")));
            this.btnGhi.Location = new System.Drawing.Point(797, 17);
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.Size = new System.Drawing.Size(142, 70);
            this.btnGhi.TabIndex = 4;
            this.btnGhi.Text = "Ghi";
            this.btnGhi.Click += new System.EventHandler(this.btnGhi_Click);
            // 
            // btnPhucHoi
            // 
            this.btnPhucHoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPhucHoi.ImageOptions.Image")));
            this.btnPhucHoi.Location = new System.Drawing.Point(612, 17);
            this.btnPhucHoi.Name = "btnPhucHoi";
            this.btnPhucHoi.Size = new System.Drawing.Size(143, 71);
            this.btnPhucHoi.TabIndex = 3;
            this.btnPhucHoi.Text = "Phục hồi";
            this.btnPhucHoi.Click += new System.EventHandler(this.btnPhucHoi_Click);
            // 
            // btnSua
            // 
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.Location = new System.Drawing.Point(426, 17);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(143, 71);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.Location = new System.Drawing.Point(231, 17);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(140, 71);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.Location = new System.Drawing.Point(56, 17);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(140, 71);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // FrmQLLTC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1464, 512);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.gridControl2);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.labelControl1);
            this.Name = "FrmQLLTC";
            this.Text = "FrmQLLTC";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmQLLTC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qldsV_TCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMONHOC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLOPTINCHI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDANGKY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSubject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCreditClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbHOCKY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditMH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditNHOM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditSOSV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.ComboBox cbKhoa;
        private System.Windows.Forms.Label label1;
        private QLDSV_TCDataSet qldsV_TCDataSet;
        private System.Windows.Forms.BindingSource bdsMONHOC;
        private QLDSV_TCDataSetTableAdapters.MONHOCTableAdapter MONHOCTableAdapter;
        private System.Windows.Forms.BindingSource bdsLOPTINCHI;
        private QLDSV_TCDataSetTableAdapters.LOPTINCHITableAdapter LOPTINCHITableAdapter;
        private System.Windows.Forms.BindingSource bdsDANGKY;
        private QLDSV_TCDataSetTableAdapters.DANGKYTableAdapter DANGKYTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH;
        private DevExpress.XtraGrid.Columns.GridColumn colTENMH;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTIET_LT;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTIET_TH;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCreditClass;
        private DevExpress.XtraGrid.Columns.GridColumn colNIENKHOA;
        private DevExpress.XtraGrid.Columns.GridColumn colHOCKY;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH1;
        private DevExpress.XtraGrid.Columns.GridColumn colNHOM;
        private DevExpress.XtraGrid.Columns.GridColumn colMAGV;
        private DevExpress.XtraGrid.Columns.GridColumn colSOSVTOITHIEU;
        private DevExpress.XtraGrid.Columns.GridColumn colHUYLOP;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnTaiLai;
        private DevExpress.XtraEditors.SimpleButton btnGhi;
        private DevExpress.XtraEditors.SimpleButton btnPhucHoi;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox cbHOCKY;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lookUpEditMH;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit spinEditNHOM;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lookUpEditGV;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit spinEditSOSV;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewSubject;
        private DevExpress.XtraGrid.Columns.GridColumn colKHOA;
    }
}