
namespace QLDSV_TC
{
    partial class FrmQLCD
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cbKhoa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnGhiDiem = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.txtHOTENGV = new DevExpress.XtraEditors.TextEdit();
            this.txtMAGV = new DevExpress.XtraEditors.TextEdit();
            this.txtMALTC = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnBatDau = new DevExpress.XtraEditors.SimpleButton();
            this.cbNHOM = new System.Windows.Forms.ComboBox();
            this.cbHOCKY = new System.Windows.Forms.ComboBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cbMONHOC = new System.Windows.Forms.ComboBox();
            this.cbNIENKHOA = new System.Windows.Forms.ComboBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.gridControlScore = new DevExpress.XtraGrid.GridControl();
            this.gridViewScore = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMASV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOTENSV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIEM_CC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSpinEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.colDIEM_GK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSpinEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.colDIEM_CK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSpinEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.colDIEM_TK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.qldsV_TCDataSet = new QLDSV_TC.QLDSV_TCDataSet();
            this.bdsDANGKY = new System.Windows.Forms.BindingSource(this.components);
            this.DANGKYTableAdapter = new QLDSV_TC.QLDSV_TCDataSetTableAdapters.DANGKYTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHOTENGV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMAGV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMALTC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qldsV_TCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDANGKY)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelControl1.Location = new System.Drawing.Point(1, 24);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(1408, 48);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "QUẢN LÝ ĐIỂM SINH VIÊN TÍN CHỈ";
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.cbKhoa);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Location = new System.Drawing.Point(1, 79);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1408, 57);
            this.panelControl1.TabIndex = 1;
            // 
            // cbKhoa
            // 
            this.cbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKhoa.FormattingEnabled = true;
            this.cbKhoa.Location = new System.Drawing.Point(509, 17);
            this.cbKhoa.Name = "cbKhoa";
            this.cbKhoa.Size = new System.Drawing.Size(361, 27);
            this.cbKhoa.TabIndex = 1;
            this.cbKhoa.SelectedIndexChanged += new System.EventHandler(this.cbKhoa_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(445, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "KHOA:";
            // 
            // panelControl2
            // 
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Controls.Add(this.btnGhiDiem);
            this.panelControl2.Controls.Add(this.panelControl3);
            this.panelControl2.Controls.Add(this.btnThoat);
            this.panelControl2.Controls.Add(this.btnBatDau);
            this.panelControl2.Controls.Add(this.cbNHOM);
            this.panelControl2.Controls.Add(this.cbHOCKY);
            this.panelControl2.Controls.Add(this.labelControl5);
            this.panelControl2.Controls.Add(this.labelControl4);
            this.panelControl2.Controls.Add(this.cbMONHOC);
            this.panelControl2.Controls.Add(this.cbNIENKHOA);
            this.panelControl2.Controls.Add(this.labelControl3);
            this.panelControl2.Controls.Add(this.labelControl2);
            this.panelControl2.Location = new System.Drawing.Point(1, 142);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1408, 100);
            this.panelControl2.TabIndex = 2;
            // 
            // btnGhiDiem
            // 
            this.btnGhiDiem.Location = new System.Drawing.Point(991, 33);
            this.btnGhiDiem.Name = "btnGhiDiem";
            this.btnGhiDiem.Size = new System.Drawing.Size(98, 48);
            this.btnGhiDiem.TabIndex = 11;
            this.btnGhiDiem.Text = "GHI ĐIỂM";
            this.btnGhiDiem.Click += new System.EventHandler(this.btnGhiDiem_Click);
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.txtHOTENGV);
            this.panelControl3.Controls.Add(this.txtMAGV);
            this.panelControl3.Controls.Add(this.txtMALTC);
            this.panelControl3.Controls.Add(this.labelControl8);
            this.panelControl3.Controls.Add(this.labelControl7);
            this.panelControl3.Controls.Add(this.labelControl6);
            this.panelControl3.Location = new System.Drawing.Point(1095, 6);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(313, 95);
            this.panelControl3.TabIndex = 10;
            // 
            // txtHOTENGV
            // 
            this.txtHOTENGV.Location = new System.Drawing.Point(101, 63);
            this.txtHOTENGV.Name = "txtHOTENGV";
            this.txtHOTENGV.Size = new System.Drawing.Size(205, 28);
            this.txtHOTENGV.TabIndex = 4;
            // 
            // txtMAGV
            // 
            this.txtMAGV.Location = new System.Drawing.Point(73, 33);
            this.txtMAGV.Name = "txtMAGV";
            this.txtMAGV.Size = new System.Drawing.Size(233, 28);
            this.txtMAGV.TabIndex = 3;
            // 
            // txtMALTC
            // 
            this.txtMALTC.Location = new System.Drawing.Point(73, 3);
            this.txtMALTC.Name = "txtMALTC";
            this.txtMALTC.Size = new System.Drawing.Size(233, 28);
            this.txtMALTC.TabIndex = 2;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(5, 67);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(90, 19);
            this.labelControl8.TabIndex = 2;
            this.labelControl8.Text = "HỌ TÊN GV:";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(5, 37);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(55, 19);
            this.labelControl7.TabIndex = 1;
            this.labelControl7.Text = "MÃ GV:";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(5, 7);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(62, 19);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "MÃ LTC:";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(863, 52);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(112, 34);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnBatDau
            // 
            this.btnBatDau.Location = new System.Drawing.Point(863, 9);
            this.btnBatDau.Name = "btnBatDau";
            this.btnBatDau.Size = new System.Drawing.Size(112, 34);
            this.btnBatDau.TabIndex = 8;
            this.btnBatDau.Text = "BẮT ĐẦU";
            this.btnBatDau.Click += new System.EventHandler(this.btnBatDau_Click);
            // 
            // cbNHOM
            // 
            this.cbNHOM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNHOM.FormattingEnabled = true;
            this.cbNHOM.Location = new System.Drawing.Point(556, 57);
            this.cbNHOM.Name = "cbNHOM";
            this.cbNHOM.Size = new System.Drawing.Size(262, 27);
            this.cbNHOM.TabIndex = 7;
            this.cbNHOM.SelectedIndexChanged += new System.EventHandler(this.cbNHOM_SelectedIndexChanged);
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
            this.cbHOCKY.Location = new System.Drawing.Point(567, 9);
            this.cbHOCKY.Name = "cbHOCKY";
            this.cbHOCKY.Size = new System.Drawing.Size(262, 27);
            this.cbHOCKY.TabIndex = 6;
            this.cbHOCKY.SelectedIndexChanged += new System.EventHandler(this.cbHOCKY_SelectedIndexChanged);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(498, 62);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(52, 19);
            this.labelControl5.TabIndex = 5;
            this.labelControl5.Text = "NHÓM:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(498, 17);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(63, 19);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "HỌC KỲ:";
            // 
            // cbMONHOC
            // 
            this.cbMONHOC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMONHOC.FormattingEnabled = true;
            this.cbMONHOC.Location = new System.Drawing.Point(127, 62);
            this.cbMONHOC.Name = "cbMONHOC";
            this.cbMONHOC.Size = new System.Drawing.Size(251, 27);
            this.cbMONHOC.TabIndex = 3;
            this.cbMONHOC.SelectedIndexChanged += new System.EventHandler(this.cbMONHOC_SelectedIndexChanged);
            // 
            // cbNIENKHOA
            // 
            this.cbNIENKHOA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNIENKHOA.FormattingEnabled = true;
            this.cbNIENKHOA.Location = new System.Drawing.Point(127, 12);
            this.cbNIENKHOA.Name = "cbNIENKHOA";
            this.cbNIENKHOA.Size = new System.Drawing.Size(251, 27);
            this.cbNIENKHOA.TabIndex = 2;
            this.cbNIENKHOA.SelectedIndexChanged += new System.EventHandler(this.cbNIENKHOA_SelectedIndexChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(30, 65);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(79, 19);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "MÔN HỌC:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(30, 15);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(91, 19);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "NIÊN KHÓA:";
            // 
            // gridControlScore
            // 
            this.gridControlScore.Location = new System.Drawing.Point(1, 240);
            this.gridControlScore.MainView = this.gridViewScore;
            this.gridControlScore.Name = "gridControlScore";
            this.gridControlScore.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemSpinEdit1,
            this.repositoryItemSpinEdit2,
            this.repositoryItemSpinEdit3});
            this.gridControlScore.Size = new System.Drawing.Size(1818, 271);
            this.gridControlScore.TabIndex = 3;
            this.gridControlScore.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewScore});
            // 
            // gridViewScore
            // 
            this.gridViewScore.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMASV,
            this.colHOTENSV,
            this.colDIEM_CC,
            this.colDIEM_GK,
            this.colDIEM_CK,
            this.colDIEM_TK});
            this.gridViewScore.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridViewScore.GridControl = this.gridControlScore;
            this.gridViewScore.Name = "gridViewScore";
            // 
            // colMASV
            // 
            this.colMASV.Caption = "Mã SV";
            this.colMASV.FieldName = "MASV";
            this.colMASV.MinWidth = 30;
            this.colMASV.Name = "colMASV";
            this.colMASV.OptionsColumn.AllowEdit = false;
            this.colMASV.OptionsColumn.ReadOnly = true;
            this.colMASV.Visible = true;
            this.colMASV.VisibleIndex = 0;
            this.colMASV.Width = 112;
            // 
            // colHOTENSV
            // 
            this.colHOTENSV.Caption = "Họ tên SV";
            this.colHOTENSV.FieldName = "HOTENSV";
            this.colHOTENSV.MinWidth = 30;
            this.colHOTENSV.Name = "colHOTENSV";
            this.colHOTENSV.OptionsColumn.AllowEdit = false;
            this.colHOTENSV.OptionsColumn.ReadOnly = true;
            this.colHOTENSV.Visible = true;
            this.colHOTENSV.VisibleIndex = 1;
            this.colHOTENSV.Width = 112;
            // 
            // colDIEM_CC
            // 
            this.colDIEM_CC.Caption = "Điểm chuyên cần";
            this.colDIEM_CC.ColumnEdit = this.repositoryItemSpinEdit1;
            this.colDIEM_CC.FieldName = "DIEM_CC";
            this.colDIEM_CC.MinWidth = 30;
            this.colDIEM_CC.Name = "colDIEM_CC";
            this.colDIEM_CC.Visible = true;
            this.colDIEM_CC.VisibleIndex = 2;
            this.colDIEM_CC.Width = 112;
            // 
            // repositoryItemSpinEdit1
            // 
            this.repositoryItemSpinEdit1.AutoHeight = false;
            this.repositoryItemSpinEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSpinEdit1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.repositoryItemSpinEdit1.Mask.EditMask = "n2";
            this.repositoryItemSpinEdit1.MaxValue = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1";
            // 
            // colDIEM_GK
            // 
            this.colDIEM_GK.Caption = "Điểm giữa kì";
            this.colDIEM_GK.ColumnEdit = this.repositoryItemSpinEdit2;
            this.colDIEM_GK.FieldName = "DIEM_GK";
            this.colDIEM_GK.MinWidth = 30;
            this.colDIEM_GK.Name = "colDIEM_GK";
            this.colDIEM_GK.Visible = true;
            this.colDIEM_GK.VisibleIndex = 3;
            this.colDIEM_GK.Width = 112;
            // 
            // repositoryItemSpinEdit2
            // 
            this.repositoryItemSpinEdit2.AutoHeight = false;
            this.repositoryItemSpinEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSpinEdit2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.repositoryItemSpinEdit2.Mask.EditMask = "n2";
            this.repositoryItemSpinEdit2.MaxValue = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.repositoryItemSpinEdit2.Name = "repositoryItemSpinEdit2";
            // 
            // colDIEM_CK
            // 
            this.colDIEM_CK.Caption = "Điểm cuối kì";
            this.colDIEM_CK.ColumnEdit = this.repositoryItemSpinEdit3;
            this.colDIEM_CK.FieldName = "DIEM_CK";
            this.colDIEM_CK.MinWidth = 30;
            this.colDIEM_CK.Name = "colDIEM_CK";
            this.colDIEM_CK.Visible = true;
            this.colDIEM_CK.VisibleIndex = 4;
            this.colDIEM_CK.Width = 112;
            // 
            // repositoryItemSpinEdit3
            // 
            this.repositoryItemSpinEdit3.AutoHeight = false;
            this.repositoryItemSpinEdit3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSpinEdit3.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.repositoryItemSpinEdit3.Mask.EditMask = "n2";
            this.repositoryItemSpinEdit3.MaxValue = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.repositoryItemSpinEdit3.Name = "repositoryItemSpinEdit3";
            // 
            // colDIEM_TK
            // 
            this.colDIEM_TK.Caption = "Điểm tổng kết";
            this.colDIEM_TK.FieldName = "colDIEM_TK";
            this.colDIEM_TK.MinWidth = 30;
            this.colDIEM_TK.Name = "colDIEM_TK";
            this.colDIEM_TK.OptionsColumn.AllowEdit = false;
            this.colDIEM_TK.OptionsColumn.ReadOnly = true;
            this.colDIEM_TK.UnboundExpression = "Round(Iif(IsNullOrEmpty([DIEM_CC]), 0, [DIEM_CC]) * 0.1 + Iif(IsNullOrEmpty([DIEM" +
    "_GK]), 0, [DIEM_GK]) * 0.3 + Iif(IsNullOrEmpty([DIEM_CK]), 0, [DIEM_CK]) * 0.6, " +
    "1)";
            this.colDIEM_TK.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.colDIEM_TK.Visible = true;
            this.colDIEM_TK.VisibleIndex = 5;
            this.colDIEM_TK.Width = 112;
            // 
            // qldsV_TCDataSet
            // 
            this.qldsV_TCDataSet.DataSetName = "QLDSV_TCDataSet";
            this.qldsV_TCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsDANGKY
            // 
            this.bdsDANGKY.DataMember = "DANGKY";
            this.bdsDANGKY.DataSource = this.qldsV_TCDataSet;
            // 
            // DANGKYTableAdapter
            // 
            this.DANGKYTableAdapter.ClearBeforeFill = true;
            // 
            // FrmQLCD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1608, 532);
            this.Controls.Add(this.gridControlScore);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.labelControl1);
            this.Name = "FrmQLCD";
            this.Text = "FrmQLCD";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmQLCD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHOTENGV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMAGV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMALTC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qldsV_TCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDANGKY)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.ComboBox cbKhoa;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.TextEdit txtHOTENGV;
        private DevExpress.XtraEditors.TextEdit txtMAGV;
        private DevExpress.XtraEditors.TextEdit txtMALTC;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnBatDau;
        private System.Windows.Forms.ComboBox cbNHOM;
        private System.Windows.Forms.ComboBox cbHOCKY;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.ComboBox cbMONHOC;
        private System.Windows.Forms.ComboBox cbNIENKHOA;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.GridControl gridControlScore;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewScore;
        private QLDSV_TCDataSet qldsV_TCDataSet;
        private System.Windows.Forms.BindingSource bdsDANGKY;
        private QLDSV_TCDataSetTableAdapters.DANGKYTableAdapter DANGKYTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colMASV;
        private DevExpress.XtraGrid.Columns.GridColumn colHOTENSV;
        private DevExpress.XtraGrid.Columns.GridColumn colDIEM_CC;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colDIEM_GK;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit2;
        private DevExpress.XtraGrid.Columns.GridColumn colDIEM_CK;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit3;
        private DevExpress.XtraGrid.Columns.GridColumn colDIEM_TK;
        private DevExpress.XtraEditors.SimpleButton btnGhiDiem;
    }
}