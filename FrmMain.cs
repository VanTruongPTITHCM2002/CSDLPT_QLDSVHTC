using DevExpress.XtraBars;
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
    public partial class FrmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        //Kiểm tra sự tồn tại của form con
        private void PhanQuyen()
        {
            String role = Program.mGroup;
            if (role == "PGV" || role == "KHOA")
            {
                 btnQLSV.Enabled = btnQLLH.Enabled = btnQLMH.Enabled = 
                btnQLLTC.Enabled = btnQLCD.Enabled = btnDK.Enabled = true;
            }
            else if (role == "PKT")
            {
                btnQLHP.Enabled = btnDK.Enabled = true;
            }
            else
            {
                btnSVDK.Enabled = true;
            }
        }
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == ftype)
                {
                    return f;
                }
            }
            return null;
        }

        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnLogout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn đăng xuất không?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialog == DialogResult.Yes)
            {
                foreach (Form frm in this.MdiChildren)
                {
                    frm.Close();
                }

                Program.frmMain.Dispose();
                Program.frmLogin.Visible = true;
                Program.bdsDSPM.RemoveFilter();
                Program.frmLogin.loadData();
            }
        }

        private void btnQLSV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = CheckExists(typeof(FrmQLSV));
            if (form != null) form.Activate();
            else
            {
                Program.frmQLSV = new FrmQLSV();
                Program.frmQLSV.MdiParent = this;
                Program.frmQLSV.Show();
            }
        }

        private void btnQLLH_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = CheckExists(typeof(FrmQLLH));
            if (form != null) form.Activate();
            else
            {
                Program.frmQLLH = new FrmQLLH();
                Program.frmQLLH.MdiParent = this;
                Program.frmQLLH.Show();
            }
        }

        private void btnQLMH_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = CheckExists(typeof(FrmQLMH));
            if (form != null) form.Activate();
            else
            {
                Program.frmQLMH = new FrmQLMH();
                Program.frmQLMH.MdiParent = this;
                Program.frmQLMH.Show();
            }
        }

        private void btnQLLTC_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = CheckExists(typeof(FrmQLLTC));
            if (form != null) form.Activate();
            else
            {
                Program.frmQLLTC = new FrmQLLTC();
                Program.frmQLLTC.MdiParent = this;
                Program.frmQLLTC.Show();
            }
        }

        private void btnQLCD_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = CheckExists(typeof(FrmQLCD));
            if (form != null) form.Activate();
            else
            {
                Program.frmQLCD = new FrmQLCD();
                Program.frmQLCD.MdiParent = this;
                Program.frmQLCD.Show();
            }
        }

        private void btnQLHP_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = CheckExists(typeof(FrmQLHP));
            if (form != null) form.Activate();
            else
            {
                Program.frmQLHP = new FrmQLHP();
                Program.frmQLHP.MdiParent = this;
                Program.frmQLHP.Show();
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            PhanQuyen();
        }

        private void btnSVDK_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = CheckExists(typeof(FrmSVDK));
            if (form != null) form.Activate();
            else
            {
                Program.frmSVDK = new FrmSVDK();
                Program.frmSVDK.MdiParent = this;
                Program.frmSVDK.Show();
            }
        }

        private void btnDK_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = CheckExists(typeof(FrmTTK));
            if (form != null) form.Activate();
            else
            {
                Program.frmTTK = new FrmTTK();
                Program.frmTTK.MdiParent = this;
                Program.frmTTK.Show();
            }
        }

        private void btnINDSLTC_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = CheckExists(typeof(RpfListCreditClass));
            if (form != null) form.Activate();
            else
            {
                Program.rpfListCreditClass = new RpfListCreditClass();
                Program.rpfListCreditClass.MdiParent = this;
                Program.rpfListCreditClass.Show();
            }
        }

        private void btnINDSSVDKLTC_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = CheckExists(typeof(RpfListStudentCreditClass));
            if (form != null) form.Activate();
            else
            {
                Program.rpfListStudentCredit = new RpfListStudentCreditClass();
                Program.rpfListStudentCredit.MdiParent = this;
                Program.rpfListStudentCredit.Show();
            }
        }

        private void btnBĐMHLTC_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = CheckExists(typeof(RpfScoresCreditClass));
            if (form != null) form.Activate();
            else
            {
                Program.rpfScoresCreditClass = new RpfScoresCreditClass();
                Program.rpfScoresCreditClass.MdiParent = this;
                Program.rpfScoresCreditClass.Show();
            }
        }

        private void btnPhieuDiem_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = CheckExists(typeof(RpfStudentScores));
            if (form != null) form.Activate();
            else
            {
                Program.rpfStudentScores = new RpfStudentScores();
                Program.rpfStudentScores.MdiParent = this;
                Program.rpfStudentScores.Show();
            }
        }

        private void btnDSDHP_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = CheckExists(typeof(RpfListPayTuitionOfClass));
            if (form != null) form.Activate();
            else
            {
                Program.rpfListPayTuition = new RpfListPayTuitionOfClass();
                Program.rpfListPayTuition.MdiParent = this;
                Program.rpfListPayTuition.Show();
            }
        }

        private void btnBDTK_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form form = CheckExists(typeof(RpfFinalScoresOfClass));
            if (form != null) form.Activate();
            else
            {
                Program.RpfFinalScoresOfClass = new RpfFinalScoresOfClass();
                Program.RpfFinalScoresOfClass.MdiParent = this;
                Program.RpfFinalScoresOfClass.Show();
            }
        }
    }
}