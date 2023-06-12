using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV_TC
{
    public partial class RpfFinalScoresOfClass : DevExpress.XtraEditors.XtraForm
    {
        private bool checkData()
        {
            if (lkLOP.EditValue == null)
            {
                MessageBox.Show("Lớp không được bỏ trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        public RpfFinalScoresOfClass()
        {
            InitializeComponent();
        }

        private void RpfFinalScoresOfClass_Load(object sender, EventArgs e)
        {
            this.qldsV_TCDataSet.EnforceConstraints = false;
            this.LOPTableAdapter.Fill(this.qldsV_TCDataSet.LOP);

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
                this.LOPTableAdapter.Connection.ConnectionString = Program.connectString;
                this.LOPTableAdapter.Fill(this.qldsV_TCDataSet.LOP);
            }
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {

            /*if (checkData())
            {
                String classCode = lkLOP.EditValue.ToString();
                String className = lkLOP.GetColumnValue("TENLOP").ToString();
                String courseYear = lkLOP.GetColumnValue("KHOAHOC").ToString();
                String facultyName = cbKhoa.Text;

                XrptFinalScoresOfClass xrpt = new XrptFinalScoresOfClass(classCode);

                xrpt.xrlblFaculty.Text = facultyName;
                xrpt.xrlblClassName.Text = className;
                xrpt.xrlblCourseYear.Text = courseYear;

                ReportPrintTool printTool = new ReportPrintTool(xrpt);
                printTool.ShowPreviewDialog();
            }*/
        }
    }
}