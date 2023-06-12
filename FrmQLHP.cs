﻿using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV_TC
{
    public partial class FrmQLHP : DevExpress.XtraEditors.XtraForm
    {
        private String maSV;
        private int positionSelectedDetailTuition = -1;
        public FrmQLHP()
        {
            InitializeComponent();
        }

        private bool checkDataInput()
        {
            DataRowView data = (DataRowView)SPGETCTHOCPHIBindingSource[positionSelectedDetailTuition];
            if (data["NGAYDONG"].ToString().Trim() == "")
            {
                MessageBox.Show("Ngày đóng không được để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (data["SOTIENDONG"].ToString().Trim() == "")
            {
                MessageBox.Show("Số tiền đóng không được để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
        private void fillTableTuition()
        {
            try
            {
               
                this.SP_GETHOCPHI_SVTableAdapter.Connection.ConnectionString = Program.connectString;
                this.SP_GETHOCPHI_SVTableAdapter.Fill(this.qldsv_TCDataSet11.SP_GETHOCPHI_SV, maSV);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void fillTableDetailTuition()
        {
            try
            {
                String nienKhoa = gridViewTuition.GetFocusedDataRow()["NIENKHOA"].ToString();
                int hocKy = Convert.ToInt32(gridViewTuition.GetFocusedDataRow()["HOCKY"]);

                this.SP_GETCTHOCPHITableAdapter.Connection.ConnectionString = Program.connectString;
                this.SP_GETCTHOCPHITableAdapter.Fill(this.qldsv_TCDataSet11.SP_GETCTHOCPHI, maSV, nienKhoa, hocKy);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void defaultValueInputCTHP()
        {
            int needToPay = Convert.ToInt32(gridViewTuition.GetFocusedDataRow()["HOCPHI"])- Convert.ToInt32(gridViewTuition.GetFocusedDataRow()["PAID"]);
            DevExpress.XtraEditors.Repository.RepositoryItemDateEdit dateEdit = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            dateEdit.MaxValue = DateTime.Now.AddYears(0);
            colNGAYDONG.ColumnEdit = dateEdit;

            spinEditSOTIENDONG.MaxValue = needToPay;
        }
        private void FrmQLHP_Load(object sender, EventArgs e)
        {
            this.qldsv_TCDataSet11.EnforceConstraints = false;
            this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connectString;
            this.SINHVIENTableAdapter.Fill(this.qldsv_TCDataSet11.SINHVIEN);
        }

        private void lookUpEditMASV_EditValueChanged(object sender, EventArgs e)
        {
            maSV = lookUpEditMASV.Text;
            txtHOTEN.Text = lookUpEditMASV.GetColumnValue("HO").ToString() + " " + lookUpEditMASV.GetColumnValue("TEN").ToString();
            txtMALOP.Text = lookUpEditMASV.GetColumnValue("MALOP").ToString();
            fillTableTuition();
            if(gridViewTuition.RowCount == 0)
            {
                btnNopHocPhi.Enabled = false;
            }
            while (gridViewDetailTuition.RowCount > 0)
                gridViewDetailTuition.DeleteRow(0);
        }

        private void gridViewTuition_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {

            if (Convert.ToInt32(gridViewTuition.GetFocusedDataRow()["HOCPHI"]) == Convert.ToInt32(gridViewTuition.GetFocusedDataRow()["PAID"]))
                btnNopHocPhi.Enabled = false;
            else
                btnNopHocPhi.Enabled = true;

            fillTableDetailTuition();
        }

        private void gridViewDetailTuition_ShowingEditor(object sender, CancelEventArgs e)
        {
            if (SPGETCTHOCPHIBindingSource.Position != positionSelectedDetailTuition)
                e.Cancel = true;
        }

        private void btnNopHocPhi_Click(object sender, EventArgs e)
        {
            defaultValueInputCTHP();

            SPGETCTHOCPHIBindingSource.AddNew();
            positionSelectedDetailTuition = SPGETCTHOCPHIBindingSource.Count - 1;

            btnNopHocPhi.Enabled = false;
            btnGhiHocPhi.Enabled = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if(btnGhiHocPhi.Enabled == true)
            {
                DialogResult dialog = MessageBox.Show("Bạn đang trong quá trình chỉnh sửa thông tin học phí của sinh viên", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialog == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }

        private void btnGhiHocPhi_Click(object sender, EventArgs e)
        {
            if (checkDataInput())
            {
                int money = Convert.ToInt32(gridViewDetailTuition.GetFocusedDataRow()["SOTIENDONG"]);


                DialogResult dialog =
                    MessageBox.Show("Bạn cần kiểm tra trước khi thanh toán:" +
                    "\n\nMSSV: " + maSV +
                    "\n\nHọ và tên: " + txtHOTEN.Text +
                    "\n\nSố tiền thanh toán: " + String.Format("{0:n0}", money) + " VND"
                    , "Thông báo!", MessageBoxButtons.YesNo);

                if (dialog == DialogResult.Yes)
                {
                    if (Program.connect.State == ConnectionState.Closed) Program.connect.Open();

                    String nienKhoa = gridViewTuition.GetFocusedDataRow()["NIENKHOA"].ToString();
                    int hocKy = Convert.ToInt32(gridViewTuition.GetFocusedDataRow()["HOCKY"]);
                    DateTime dateTime = Convert.ToDateTime(gridViewDetailTuition.GetFocusedDataRow()["NGAYDONG"]);

                    String spString = "dbo.SP_PAY_TUITION";
                    SqlCommand command = Program.connect.CreateCommand();
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = spString;
                    command.Parameters.Add("@MASV", SqlDbType.NChar).Value = maSV;
                    command.Parameters.Add("@NIENKHOA", SqlDbType.NChar).Value = nienKhoa;
                    command.Parameters.Add("@HOCKY", SqlDbType.Int).Value = hocKy;
                    command.Parameters.Add("@NGAYDONG", SqlDbType.DateTime).Value = dateTime;
                    command.Parameters.Add("@SOTIENDONG", SqlDbType.Int).Value = money;

                    command.ExecuteNonQuery();
                    Program.connect.Close();

                    fillTableTuition();
                    fillTableDetailTuition();
                }
                else
                {
                    SPGETCTHOCPHIBindingSource.RemoveCurrent();
                    SPGETCTHOCPHIBindingSource.CancelEdit();
                    MessageBox.Show("Thao tác thanh toán đã hủy!", "Thông báo!", MessageBoxButtons.OK);
                }

                positionSelectedDetailTuition = -1;
                btnNopHocPhi.Enabled = btnGhiHocPhi.Enabled = false;
            }
        }
    }
}