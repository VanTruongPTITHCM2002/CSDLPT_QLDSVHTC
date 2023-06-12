
namespace QLDSV_TC
{
    partial class RpfListStudentCreditClass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RpfListStudentCreditClass));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cbKhoa = new System.Windows.Forms.ComboBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.cbNIENKHOA = new System.Windows.Forms.ComboBox();
            this.cbHOCKY = new System.Windows.Forms.ComboBox();
            this.lkMONHOC = new DevExpress.XtraEditors.LookUpEdit();
            this.nmNHOM = new System.Windows.Forms.NumericUpDown();
            this.btnPreview = new DevExpress.XtraEditors.SimpleButton();
            this.qldsV_TCDataSet = new QLDSV_TC.QLDSV_TCDataSet();
            this.bdsMONHOC = new System.Windows.Forms.BindingSource(this.components);
            this.MONHOCTableAdapter = new QLDSV_TC.QLDSV_TCDataSetTableAdapters.MONHOCTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkMONHOC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmNHOM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qldsV_TCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMONHOC)).BeginInit();
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
            this.labelControl1.Size = new System.Drawing.Size(979, 48);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "IN DANH SÁCH SINH VIÊN LỚP TÍN CHỈ";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cbKhoa);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Location = new System.Drawing.Point(1, 68);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1081, 64);
            this.panelControl1.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(352, 20);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(49, 19);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "KHOA:";
            // 
            // cbKhoa
            // 
            this.cbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKhoa.FormattingEnabled = true;
            this.cbKhoa.Location = new System.Drawing.Point(407, 17);
            this.cbKhoa.Name = "cbKhoa";
            this.cbKhoa.Size = new System.Drawing.Size(407, 27);
            this.cbKhoa.TabIndex = 1;
            this.cbKhoa.SelectedIndexChanged += new System.EventHandler(this.cbKhoa_SelectedIndexChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(223, 171);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(91, 19);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "NIÊN KHÓA:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(223, 239);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(63, 19);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "HỌC KỲ:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(223, 313);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(79, 19);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "MÔN HỌC:";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(223, 386);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(52, 19);
            this.labelControl6.TabIndex = 5;
            this.labelControl6.Text = "NHÓM:";
            // 
            // cbNIENKHOA
            // 
            this.cbNIENKHOA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNIENKHOA.FormattingEnabled = true;
            this.cbNIENKHOA.Location = new System.Drawing.Point(320, 168);
            this.cbNIENKHOA.Name = "cbNIENKHOA";
            this.cbNIENKHOA.Size = new System.Drawing.Size(307, 27);
            this.cbNIENKHOA.TabIndex = 6;
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
            this.cbHOCKY.Location = new System.Drawing.Point(320, 236);
            this.cbHOCKY.Name = "cbHOCKY";
            this.cbHOCKY.Size = new System.Drawing.Size(307, 27);
            this.cbHOCKY.TabIndex = 7;
            // 
            // lkMONHOC
            // 
            this.lkMONHOC.Location = new System.Drawing.Point(320, 309);
            this.lkMONHOC.Name = "lkMONHOC";
            this.lkMONHOC.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkMONHOC.Properties.DataSource = this.bdsMONHOC;
            this.lkMONHOC.Properties.DisplayMember = "TENMH";
            this.lkMONHOC.Properties.NullText = "Chọn môn học";
            this.lkMONHOC.Properties.ValueMember = "MAMH";
            this.lkMONHOC.Size = new System.Drawing.Size(307, 28);
            this.lkMONHOC.TabIndex = 8;
            // 
            // nmNHOM
            // 
            this.nmNHOM.Location = new System.Drawing.Point(320, 386);
            this.nmNHOM.Name = "nmNHOM";
            this.nmNHOM.Size = new System.Drawing.Size(307, 27);
            this.nmNHOM.TabIndex = 9;
            this.nmNHOM.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnPreview
            // 
            this.btnPreview.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPreview.ImageOptions.Image")));
            this.btnPreview.Location = new System.Drawing.Point(353, 425);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(181, 43);
            this.btnPreview.TabIndex = 10;
            this.btnPreview.Text = "Xem báo cáo";
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // qldsV_TCDataSet
            // 
            this.qldsV_TCDataSet.DataSetName = "QLDSV_TCDataSet";
            this.qldsV_TCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsMONHOC
            // 
            this.bdsMONHOC.AllowNew = true;
            this.bdsMONHOC.DataMember = "MONHOC";
            this.bdsMONHOC.DataSource = this.qldsV_TCDataSet;
            // 
            // MONHOCTableAdapter
            // 
            this.MONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // RpfListStudentCreditClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 480);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.nmNHOM);
            this.Controls.Add(this.lkMONHOC);
            this.Controls.Add(this.cbHOCKY);
            this.Controls.Add(this.cbNIENKHOA);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.labelControl1);
            this.Name = "RpfListStudentCreditClass";
            this.Text = "RpfListStudentCreditClass";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RpfListStudentCreditClass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkMONHOC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmNHOM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qldsV_TCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMONHOC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.ComboBox cbKhoa;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.ComboBox cbNIENKHOA;
        private System.Windows.Forms.ComboBox cbHOCKY;
        private DevExpress.XtraEditors.LookUpEdit lkMONHOC;
        private System.Windows.Forms.NumericUpDown nmNHOM;
        private DevExpress.XtraEditors.SimpleButton btnPreview;
        private QLDSV_TCDataSet qldsV_TCDataSet;
        private System.Windows.Forms.BindingSource bdsMONHOC;
        private QLDSV_TCDataSetTableAdapters.MONHOCTableAdapter MONHOCTableAdapter;
    }
}