
namespace QLDSV_TC
{
    partial class FrmQLHP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQLHP));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.lookUpEditMASV = new DevExpress.XtraEditors.LookUpEdit();
            this.bdsSINHVIEN = new System.Windows.Forms.BindingSource(this.components);
            this.qldsv_TCDataSet11 = new QLDSV_TC.QLDSV_TCDataSet1();
            this.txtMALOP = new DevExpress.XtraEditors.TextEdit();
            this.txtHOTEN = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnGhiHocPhi = new DevExpress.XtraEditors.SimpleButton();
            this.btnNopHocPhi = new DevExpress.XtraEditors.SimpleButton();
            this.SINHVIENTableAdapter = new QLDSV_TC.QLDSV_TCDataSet1TableAdapters.SINHVIENTableAdapter();
            this.SPGETCTHOCPHIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SP_GETCTHOCPHITableAdapter = new QLDSV_TC.QLDSV_TCDataSet1TableAdapters.SP_GETCTHOCPHITableAdapter();
            this.SPGETHOCPHISVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SP_GETHOCPHI_SVTableAdapter = new QLDSV_TC.QLDSV_TCDataSet1TableAdapters.SP_GETHOCPHI_SVTableAdapter();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridViewTuition = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNIENKHOA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOCKY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOCPHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPAID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNeedToPay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridViewDetailTuition = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNGAYDONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTIENDONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.spinEditSOTIENDONG = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditMASV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSINHVIEN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qldsv_TCDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMALOP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHOTEN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SPGETCTHOCPHIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SPGETHOCPHISVBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTuition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDetailTuition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditSOTIENDONG)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl1.Location = new System.Drawing.Point(0, 22);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(1457, 48);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "QUẢN LÝ SINH VIÊN ĐÓNG HỌC PHÍ";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.lookUpEditMASV);
            this.panelControl1.Controls.Add(this.txtMALOP);
            this.panelControl1.Controls.Add(this.txtHOTEN);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Location = new System.Drawing.Point(0, 63);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1032, 130);
            this.panelControl1.TabIndex = 1;
            // 
            // lookUpEditMASV
            // 
            this.lookUpEditMASV.Location = new System.Drawing.Point(72, 13);
            this.lookUpEditMASV.Name = "lookUpEditMASV";
            this.lookUpEditMASV.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditMASV.Properties.DataSource = this.bdsSINHVIEN;
            this.lookUpEditMASV.Properties.DisplayMember = "MASV";
            this.lookUpEditMASV.Properties.NullText = "Chọn mã sinh viên";
            this.lookUpEditMASV.Properties.ValueMember = "MASV";
            this.lookUpEditMASV.Size = new System.Drawing.Size(535, 28);
            this.lookUpEditMASV.TabIndex = 5;
            this.lookUpEditMASV.EditValueChanged += new System.EventHandler(this.lookUpEditMASV_EditValueChanged);
            // 
            // bdsSINHVIEN
            // 
            this.bdsSINHVIEN.DataMember = "SINHVIEN";
            this.bdsSINHVIEN.DataSource = this.qldsv_TCDataSet11;
            // 
            // qldsv_TCDataSet11
            // 
            this.qldsv_TCDataSet11.DataSetName = "QLDSV_TCDataSet1";
            this.qldsv_TCDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtMALOP
            // 
            this.txtMALOP.Enabled = false;
            this.txtMALOP.Location = new System.Drawing.Point(694, 13);
            this.txtMALOP.Name = "txtMALOP";
            this.txtMALOP.Size = new System.Drawing.Size(333, 28);
            this.txtMALOP.TabIndex = 4;
            // 
            // txtHOTEN
            // 
            this.txtHOTEN.Enabled = false;
            this.txtHOTEN.Location = new System.Drawing.Point(83, 73);
            this.txtHOTEN.Name = "txtHOTEN";
            this.txtHOTEN.Size = new System.Drawing.Size(554, 28);
            this.txtHOTEN.TabIndex = 3;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(614, 17);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(63, 19);
            this.labelControl4.TabIndex = 2;
            this.labelControl4.Text = "MÃ LỚP:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(13, 77);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(64, 19);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "HỌ TÊN:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 17);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(53, 19);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "MÃ SV:";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnThoat);
            this.panelControl2.Controls.Add(this.btnGhiHocPhi);
            this.panelControl2.Controls.Add(this.btnNopHocPhi);
            this.panelControl2.Location = new System.Drawing.Point(1038, 63);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(678, 130);
            this.panelControl2.TabIndex = 2;
            // 
            // btnThoat
            // 
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.Location = new System.Drawing.Point(470, 35);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(154, 66);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnGhiHocPhi
            // 
            this.btnGhiHocPhi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGhiHocPhi.ImageOptions.Image")));
            this.btnGhiHocPhi.Location = new System.Drawing.Point(228, 35);
            this.btnGhiHocPhi.Name = "btnGhiHocPhi";
            this.btnGhiHocPhi.Size = new System.Drawing.Size(191, 77);
            this.btnGhiHocPhi.TabIndex = 1;
            this.btnGhiHocPhi.Text = "Ghi học phí đóng";
            this.btnGhiHocPhi.Click += new System.EventHandler(this.btnGhiHocPhi_Click);
            // 
            // btnNopHocPhi
            // 
            this.btnNopHocPhi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNopHocPhi.ImageOptions.Image")));
            this.btnNopHocPhi.Location = new System.Drawing.Point(23, 35);
            this.btnNopHocPhi.Name = "btnNopHocPhi";
            this.btnNopHocPhi.Size = new System.Drawing.Size(154, 77);
            this.btnNopHocPhi.TabIndex = 0;
            this.btnNopHocPhi.Text = "Nộp học phí";
            this.btnNopHocPhi.Click += new System.EventHandler(this.btnNopHocPhi_Click);
            // 
            // SINHVIENTableAdapter
            // 
            this.SINHVIENTableAdapter.ClearBeforeFill = true;
            // 
            // SPGETCTHOCPHIBindingSource
            // 
            this.SPGETCTHOCPHIBindingSource.DataMember = "SP_GETCTHOCPHI";
            this.SPGETCTHOCPHIBindingSource.DataSource = this.qldsv_TCDataSet11;
            // 
            // SP_GETCTHOCPHITableAdapter
            // 
            this.SP_GETCTHOCPHITableAdapter.ClearBeforeFill = true;
            // 
            // SPGETHOCPHISVBindingSource
            // 
            this.SPGETHOCPHISVBindingSource.DataMember = "SP_GETHOCPHI_SV";
            this.SPGETHOCPHISVBindingSource.DataSource = this.qldsv_TCDataSet11;
            // 
            // SP_GETHOCPHI_SVTableAdapter
            // 
            this.SP_GETHOCPHI_SVTableAdapter.ClearBeforeFill = true;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.SPGETHOCPHISVBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(0, 199);
            this.gridControl1.MainView = this.gridViewTuition;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(810, 272);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewTuition});
            // 
            // gridViewTuition
            // 
            this.gridViewTuition.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNIENKHOA,
            this.colHOCKY,
            this.colHOCPHI,
            this.colPAID,
            this.colNeedToPay});
            this.gridViewTuition.GridControl = this.gridControl1;
            this.gridViewTuition.Name = "gridViewTuition";
            this.gridViewTuition.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridViewTuition_RowClick);
            // 
            // colNIENKHOA
            // 
            this.colNIENKHOA.Caption = "Niên khóa";
            this.colNIENKHOA.FieldName = "NIENKHOA";
            this.colNIENKHOA.MinWidth = 30;
            this.colNIENKHOA.Name = "colNIENKHOA";
            this.colNIENKHOA.Visible = true;
            this.colNIENKHOA.VisibleIndex = 0;
            this.colNIENKHOA.Width = 112;
            // 
            // colHOCKY
            // 
            this.colHOCKY.Caption = "Học kỳ";
            this.colHOCKY.FieldName = "HOCKY";
            this.colHOCKY.MinWidth = 30;
            this.colHOCKY.Name = "colHOCKY";
            this.colHOCKY.Visible = true;
            this.colHOCKY.VisibleIndex = 1;
            this.colHOCKY.Width = 112;
            // 
            // colHOCPHI
            // 
            this.colHOCPHI.Caption = "Học phí";
            this.colHOCPHI.FieldName = "HOCPHI";
            this.colHOCPHI.MinWidth = 30;
            this.colHOCPHI.Name = "colHOCPHI";
            this.colHOCPHI.Visible = true;
            this.colHOCPHI.VisibleIndex = 2;
            this.colHOCPHI.Width = 112;
            // 
            // colPAID
            // 
            this.colPAID.Caption = "Số tiền đã đóng";
            this.colPAID.FieldName = "PAID";
            this.colPAID.MinWidth = 30;
            this.colPAID.Name = "colPAID";
            this.colPAID.Visible = true;
            this.colPAID.VisibleIndex = 3;
            this.colPAID.Width = 112;
            // 
            // colNeedToPay
            // 
            this.colNeedToPay.Caption = "Số tiền cần đóng";
            this.colNeedToPay.FieldName = "SOTIENDADONG";
            this.colNeedToPay.MinWidth = 30;
            this.colNeedToPay.Name = "colNeedToPay";
            this.colNeedToPay.UnboundExpression = "[HOCPHI] - [PAID]";
            this.colNeedToPay.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.colNeedToPay.Visible = true;
            this.colNeedToPay.VisibleIndex = 4;
            this.colNeedToPay.Width = 112;
            // 
            // gridControl2
            // 
            this.gridControl2.DataSource = this.SPGETCTHOCPHIBindingSource;
            this.gridControl2.Location = new System.Drawing.Point(811, 199);
            this.gridControl2.MainView = this.gridViewDetailTuition;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.spinEditSOTIENDONG});
            this.gridControl2.Size = new System.Drawing.Size(905, 272);
            this.gridControl2.TabIndex = 4;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDetailTuition});
            // 
            // gridViewDetailTuition
            // 
            this.gridViewDetailTuition.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNGAYDONG,
            this.colSOTIENDONG});
            this.gridViewDetailTuition.GridControl = this.gridControl2;
            this.gridViewDetailTuition.Name = "gridViewDetailTuition";
            this.gridViewDetailTuition.ShowingEditor += new System.ComponentModel.CancelEventHandler(this.gridViewDetailTuition_ShowingEditor);
            // 
            // colNGAYDONG
            // 
            this.colNGAYDONG.Caption = "Ngày đóng";
            this.colNGAYDONG.FieldName = "NGAYDONG";
            this.colNGAYDONG.MinWidth = 30;
            this.colNGAYDONG.Name = "colNGAYDONG";
            this.colNGAYDONG.Visible = true;
            this.colNGAYDONG.VisibleIndex = 0;
            this.colNGAYDONG.Width = 112;
            // 
            // colSOTIENDONG
            // 
            this.colSOTIENDONG.Caption = "Số tiền đóng";
            this.colSOTIENDONG.ColumnEdit = this.spinEditSOTIENDONG;
            this.colSOTIENDONG.FieldName = "SOTIENDONG";
            this.colSOTIENDONG.MinWidth = 30;
            this.colSOTIENDONG.Name = "colSOTIENDONG";
            this.colSOTIENDONG.Visible = true;
            this.colSOTIENDONG.VisibleIndex = 1;
            this.colSOTIENDONG.Width = 112;
            // 
            // spinEditSOTIENDONG
            // 
            this.spinEditSOTIENDONG.AutoHeight = false;
            this.spinEditSOTIENDONG.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEditSOTIENDONG.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.spinEditSOTIENDONG.IsFloatValue = false;
            this.spinEditSOTIENDONG.Mask.EditMask = "N00";
            this.spinEditSOTIENDONG.MaxValue = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.spinEditSOTIENDONG.MinValue = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.spinEditSOTIENDONG.Name = "spinEditSOTIENDONG";
            // 
            // FrmQLHP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1714, 540);
            this.Controls.Add(this.gridControl2);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.labelControl1);
            this.Name = "FrmQLHP";
            this.Text = "FrmQLHP";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmQLHP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditMASV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSINHVIEN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qldsv_TCDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMALOP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHOTEN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SPGETCTHOCPHIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SPGETHOCPHISVBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTuition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDetailTuition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditSOTIENDONG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.TextEdit txtHOTEN;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditMASV;
        private DevExpress.XtraEditors.TextEdit txtMALOP;
        private System.Windows.Forms.BindingSource bdsSINHVIEN;
        private QLDSV_TCDataSet1TableAdapters.SINHVIENTableAdapter SINHVIENTableAdapter;
        private QLDSV_TCDataSet1 qldsv_TCDataSet11;
        private System.Windows.Forms.BindingSource SPGETCTHOCPHIBindingSource;
        private QLDSV_TCDataSet1TableAdapters.SP_GETCTHOCPHITableAdapter SP_GETCTHOCPHITableAdapter;
        private System.Windows.Forms.BindingSource SPGETHOCPHISVBindingSource;
        private QLDSV_TCDataSet1TableAdapters.SP_GETHOCPHI_SVTableAdapter SP_GETHOCPHI_SVTableAdapter;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnGhiHocPhi;
        private DevExpress.XtraEditors.SimpleButton btnNopHocPhi;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewTuition;
        private DevExpress.XtraGrid.Columns.GridColumn colNIENKHOA;
        private DevExpress.XtraGrid.Columns.GridColumn colHOCKY;
        private DevExpress.XtraGrid.Columns.GridColumn colHOCPHI;
        private DevExpress.XtraGrid.Columns.GridColumn colPAID;
        private DevExpress.XtraGrid.Columns.GridColumn colNeedToPay;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDetailTuition;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYDONG;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTIENDONG;
        public DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit spinEditSOTIENDONG;
    }
}