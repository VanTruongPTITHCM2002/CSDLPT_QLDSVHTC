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
    public partial class FrmQLCD : DevExpress.XtraEditors.XtraForm
    {
        private int selectedIndexNIENKHOA = -1;
        private DataTable filteredData;
        private int CreditClassNumber = -1;
        private DataTable dataScore;
        public FrmQLCD()
        {
            InitializeComponent();
        }
        private void fillDataTableScore()
        {
            String cmd = "EXEC SP_LAY_DSSV_DANGKY '" + CreditClassNumber + "'";
            dataScore = Program.ExecSqlDataTable(cmd);
            this.gridControlScore.DataSource = dataScore;
            
            if(this.gridViewScore.RowCount > 0)
            {
                btnGhiDiem.Enabled = true;
                btnBatDau.Enabled = cbKhoa.Enabled = false;

                gridViewScore.OptionsBehavior.ReadOnly = false;
                gridViewScore.OptionsBehavior.Editable = true;
            }
            else
            {
                btnGhiDiem.Enabled = false;
                btnBatDau.Enabled = cbKhoa.Enabled = true;
            }
        }

        private void fillComboboxNienKhoa()
        {
            String command = "SELECT DISTINCT(NIENKHOA) FROM LOPTINCHI WHERE HUYLOP = 0";
            DataTable data = Program.ExecSqlDataTable(command);
            cbNIENKHOA.DataSource = data;
            cbNIENKHOA.DisplayMember = "NIENKHOA";
            cbNIENKHOA.ValueMember = "NIENKHOA";
        }
        private void fillComboboxMonHoc()
        {
            String command = "EXEC SP_GETMONHOC_NK_HK '" + cbNIENKHOA.Text + "', " + cbHOCKY.Text;
            DataTable data = Program.ExecSqlDataTable(command);
            cbMONHOC.DataSource = data;
            cbMONHOC.DisplayMember = "TENMH";
            cbMONHOC.ValueMember = "MAMH";

            if (cbMONHOC.Items.Count > 0)
            {
                cbMONHOC.SelectedIndex = -1; cbMONHOC.SelectedIndex = 0;
            }
        }
        private void fillComboboxNhom()
        {
            String command = "EXEC SP_GETNHOM_NK_HK_MH '" + cbNIENKHOA.Text + "', " + cbHOCKY.Text + ", '" + cbMONHOC.SelectedValue + "'";
            filteredData = Program.ExecSqlDataTable(command);
            cbNHOM.DataSource = filteredData;
            cbNHOM.DisplayMember = "NHOM";
            cbNHOM.ValueMember = "NHOM";
        }
        private void refreshCombobox()
        {
            cbHOCKY.SelectedIndex = -1;
            cbMONHOC.SelectedIndex = -1;
            cbNHOM.SelectedIndex = -1;
        }
        private void refreshInformation()
        {
            txtMALTC.Text = "";
            txtHOTENGV.Text = "";
            txtMAGV.Text = "";

            this.gridControlScore.DataSource = null;

            selectedIndexNIENKHOA = -1;
            filteredData = new DataTable();
            CreditClassNumber = -1;

            btnBatDau.Enabled = btnGhiDiem.Enabled = false;
        }

        private void FrmQLCD_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qldsV_TCDataSet.DANGKY' table. You can move, or remove it, as needed.
            this.qldsV_TCDataSet.EnforceConstraints = false;
            fillComboboxNienKhoa();
            Program.bdsDSPM.Filter = "TENKHOA not LIKE 'Phòng kế toán%'";
            cbKhoa.DataSource = Program.bdsDSPM;
            cbKhoa.DisplayMember = "TENKHOA";
            cbKhoa.ValueMember = "TENSERVER";
            cbKhoa.SelectedValue = Program.servername;

            if (Program.mGroup == "PGV")
                cbKhoa.Enabled = true;
        }

        private void cbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbKhoa.SelectedValue.ToString() == "System.Data.DataRowView")
                return;
            Program.servername = cbKhoa.SelectedValue.ToString();

            if (cbKhoa.SelectedIndex != Program.mPhongBan)
            {
                Program.mLogin = Program.remotelogin;
                Program.mPassword = Program.remotepassword;
            }
            else
            {
                Program.mLogin = Program.mLoginDN;
                Program.mPassword = Program.mPasswordDN;
            }

            if (!Program.KetNoi())
            {
                MessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);
                return;
            }
            else
            {
                fillComboboxNienKhoa();

                refreshCombobox();
                refreshInformation();
            }
        }

        private void cbMONHOC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMONHOC.SelectedIndex != -1)
            {
                fillComboboxNhom();

                cbNHOM.Enabled = true;
            }
            else
            {
                cbNHOM.DataSource = null;
                cbNHOM.Enabled = false;
            }
        }

        private void cbNIENKHOA_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectedIndexNIENKHOA != cbNIENKHOA.SelectedIndex)
            {
                selectedIndexNIENKHOA = cbNIENKHOA.SelectedIndex;
                refreshCombobox();
            }
        }

        private void cbHOCKY_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbHOCKY.SelectedIndex != -1)
            {
                fillComboboxMonHoc();

                if (cbMONHOC.Items.Count > 0)
                {
                    cbMONHOC.Enabled = true;
                }
                else
                {
                    cbMONHOC.DataSource = null;
                    cbMONHOC.Enabled = false;

                    cbNHOM.DataSource = null;
                    cbNHOM.Enabled = false;
                }
            }
            else
            {
                cbMONHOC.DataSource = null;
                cbMONHOC.Enabled = false;
            }
        }

        private void cbNHOM_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbNHOM.SelectedIndex != -1)
            {
                btnGhiDiem.Enabled = true;
            }
            else
            {
                btnBatDau.Enabled = false;
            }
        }

        private void btnBatDau_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView(filteredData);
            dv.RowFilter = "NHOM = " + cbNHOM.SelectedValue;
            CreditClassNumber = Convert.ToInt32(dv.ToTable().Rows[0]["MALTC"]);

            txtMALTC.Text = CreditClassNumber.ToString();
            txtMAGV.Text = dv.ToTable().Rows[0]["MAGV"].ToString().Trim();
            txtHOTENGV.Text = dv.ToTable().Rows[0]["HOTEN"].ToString();

            fillDataTableScore();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (btnGhiDiem.Enabled == true)
            {
                this.Close();
            }
            else
            {
                DialogResult dialog = MessageBox.Show("Bạn đang trong quá trình chỉnh sửa thông tin bạn thật sự muốn thoát không?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialog == DialogResult.Yes)
                {
                    this.Close();
                }
            }
        }

        private void btnGhiDiem_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("MALTC", typeof(int));
            dt.Columns.Add("MASV", typeof(String));
            dt.Columns.Add("DIEM_CC", typeof(int));
            dt.Columns.Add("DIEM_GK", typeof(float));
            dt.Columns.Add("DIEM_CK", typeof(float));
            for (int i = 0; i < dataScore.Rows.Count; i++)
            {
                dt.Rows.Add(CreditClassNumber, dataScore.Rows[i]["MASV"], dataScore.Rows[i]["DIEM_CC"],
                dataScore.Rows[i]["DIEM_GK"], dataScore.Rows[i]["DIEM_CK"]);
            }

            SqlParameter para = new SqlParameter();
            para.SqlDbType = SqlDbType.Structured;
            para.TypeName = "dbo.TYPE_DANGKY";
            para.ParameterName = "@DIEMTHI";
            para.Value = dt;
            Program.KetNoi();

            try
            {
                SqlCommand sqlcmd = new SqlCommand("SP_UPDATE_DIEM", Program.connect);
                sqlcmd.Parameters.Clear();
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.Add(para);
                sqlcmd.ExecuteNonQuery();

                MessageBox.Show("Ghi điểm thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ghi điểm thất bại\n" + ex.Message, "", MessageBoxButtons.OK);
            }

            gridViewScore.OptionsBehavior.ReadOnly = true;
            gridViewScore.OptionsBehavior.Editable = false;

            btnGhiDiem.Enabled = false;
            btnBatDau.Enabled = cbKhoa.Enabled = true;
        }
    }
}