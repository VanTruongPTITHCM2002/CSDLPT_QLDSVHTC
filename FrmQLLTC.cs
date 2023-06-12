using DevExpress.XtraEditors;
using QLDSV_TC.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV_TC
{
    public partial class FrmQLLTC : DevExpress.XtraEditors.XtraForm
    {
        private Stack<ProcessStore> processStoreStack = new Stack<ProcessStore>();
        private String flagMode = "";
        private String SubjectNumberSelected = "";
        private int positionSelectedSubject = -1;
        private int positionSelectedCreditClass = -1;
        private String facultyCode = "";

        private void pushDataToProcessStack(DataRow data)
        {
            LopTinChi lopTinChi = new LopTinChi(Convert.ToInt32(data["MALTC"]),
               data["NIENKHOA"].ToString(), Convert.ToInt32(data["HOCKY"]), data["MAMH"].ToString(), Convert.ToInt32(data["NHOM"]),
               data["MAGV"].ToString(), data["MAKHOA"].ToString(), Convert.ToInt32(data["SOSVTOITHIEU"]), (bool)data["HUYLOP"]);

            processStoreStack.Push(new Services.ProcessStore(flagMode, data["MALTC"].ToString(), lopTinChi));
        }
        public FrmQLLTC()
        {
            InitializeComponent();
        }
        private void fillComboboxGV()
        {
            string command = "SELECT MAGV,HOTEN = HO + ' ' + TEN FROM GIANGVIEN";
            DataTable data = Program.ExecSqlDataTable(command);
            BindingSource bdsGV = new BindingSource();
            bdsGV.DataSource = data;

            lookUpEditGV.DataSource = bdsGV;
            lookUpEditGV.DisplayMember = "HOTEN";
            lookUpEditGV.ValueMember = "MAGV";

        }
        private void defaultValueInputCreditClass()
        {
            qldsV_TCDataSet.LOPTINCHI.HUYLOPColumn.DefaultValue = false;
            qldsV_TCDataSet.LOPTINCHI.MAMHColumn.DefaultValue = SubjectNumberSelected;
            qldsV_TCDataSet.LOPTINCHI.MAKHOAColumn.DefaultValue = facultyCode;
        }
        private void fillComboboxMH()
        {
            string command = "SELECT MAMH, TENMH FROM MONHOC";
            DataTable data = Program.ExecSqlDataTable(command);
            BindingSource bdsMH = new BindingSource();
            bdsMH.DataSource = data;

            lookUpEditMH.DataSource = bdsMH;
            lookUpEditMH.DisplayMember = "TENMH";
            lookUpEditMH.ValueMember = "MAMH";
        }
        private static string GetMaKhoa()
        {
            DataTable dt = Program.ExecSqlDataTable("SELECT MAKHOA FROM KHOA");
            String facultyCode = dt.Rows[0][0].ToString();

            return facultyCode;
        }
        private bool checkDataCreditClass()
        {
            DataRowView dataClass = (DataRowView)bdsLOPTINCHI[positionSelectedCreditClass];
            if (dataClass["NIENKHOA"].ToString().Trim() == "")
            {
                MessageBox.Show("Niên khóa không được để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (dataClass["HOCKY"].ToString().Trim() == "")
            {
                MessageBox.Show("Học kỳ không được để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (dataClass["NHOM"].ToString().Trim() == "")
            {
                MessageBox.Show("Nhóm phải lớn hơn 0 và không được để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (dataClass["MAGV"].ToString().Trim() == "")
            {
                MessageBox.Show("Mã giảng viên không được để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (dataClass["SOSVTOITHIEU"].ToString().Trim() == "")
            {
                MessageBox.Show("Số sinh viên tối thiểu phải lớn hơn 0 và không được để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            string query = " DECLARE @return_value INT" +

                               " EXEC @return_value = [dbo].[SP_CHECKLOPTINCHI]" +

                               " N'" + Convert.ToInt32(dataClass["MALTC"]) + "', " +

                               " N'" + dataClass["MAMH"].ToString() + "', " +

                               " N'" + dataClass["NIENKHOA"].ToString() + "', " +

                               " N'" + Convert.ToInt32(dataClass["HOCKY"]) + "', " +

                               " N'" + Convert.ToInt32(dataClass["NHOM"]) + "' " +

                               " SELECT @return_value";

            int resultMa = Program.CheckPrimaryKey(query);
            if (resultMa == -1)
            {
                MessageBox.Show("Lỗi kết nối với database.\n Vui long thử lại sau!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (resultMa == 1)
            {
                MessageBox.Show("Nhóm này đã tồn tại.\n Mời bạn nhập mã khác !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (resultMa == 2)
            {
                MessageBox.Show("Nhóm này đã tồn tại ở khoa khác.\n Mời bạn nhập mã khác !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void FrmQLLTC_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qldsV_TCDataSet.DANGKY' table. You can move, or remove it, as needed.
            this.qldsV_TCDataSet.EnforceConstraints = false;
            this.MONHOCTableAdapter.Connection.ConnectionString = Program.connectString;
            this.MONHOCTableAdapter.Fill(this.qldsV_TCDataSet.MONHOC);
            this.LOPTINCHITableAdapter.Connection.ConnectionString = Program.connectString;
            this.LOPTINCHITableAdapter.Fill(this.qldsV_TCDataSet.LOPTINCHI);

            this.DANGKYTableAdapter.Connection.ConnectionString = Program.connectString;
            this.DANGKYTableAdapter.Fill(this.qldsV_TCDataSet.DANGKY);

            fillComboboxMH();
            fillComboboxGV();
            Program.bdsDSPM.Filter = "TENKHOA not LIKE 'Phòng kế toán%'  ";
            cbKhoa.DataSource = Program.bdsDSPM;
            cbKhoa.DisplayMember = "TENKHOA";
            cbKhoa.ValueMember = "TENSERVER";
            cbKhoa.SelectedValue = Program.servername;
            facultyCode = GetMaKhoa();
            if (Program.mGroup == "PGV") cbKhoa.Enabled = true;
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
                this.MONHOCTableAdapter.Connection.ConnectionString = Program.connectString;
                this.MONHOCTableAdapter.Fill(this.qldsV_TCDataSet.MONHOC);

                this.LOPTINCHITableAdapter.Connection.ConnectionString = Program.connectString;
                this.LOPTINCHITableAdapter.Fill(this.qldsV_TCDataSet.LOPTINCHI);

                this.DANGKYTableAdapter.Connection.ConnectionString = Program.connectString;
                this.DANGKYTableAdapter.Fill(this.qldsV_TCDataSet.DANGKY);
                facultyCode = GetMaKhoa();
                processStoreStack.Clear();
                btnPhucHoi.Enabled = false;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            defaultValueInputCreditClass();

            bdsLOPTINCHI.AddNew();

            positionSelectedSubject = gridViewSubject.FocusedRowHandle;
            positionSelectedCreditClass = bdsLOPTINCHI.Count - 1;

            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnPhucHoi.Enabled = cbKhoa.Enabled = false;
            btnGhi.Enabled = true;
            flagMode = "ADDCREDITCLASS";
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            if (checkDataCreditClass())
            {
                try
                {
                    bdsLOPTINCHI.EndEdit();
                    bdsLOPTINCHI.ResetCurrentItem();

                    this.LOPTINCHITableAdapter.Connection.ConnectionString = Program.connectString;

                    DataRow row = ((DataRowView)bdsLOPTINCHI[bdsLOPTINCHI.Position]).Row;
                    this.LOPTINCHITableAdapter.Update(row);

                    if (flagMode == "ADDCREDITCLASS")
                        processStoreStack.Push(new Services.ProcessStore(flagMode, row["MALTC"].ToString()));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ghi lớp tín chỉ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                flagMode = "";
                positionSelectedCreditClass = -1;

                btnThem.Enabled = btnPhucHoi.Enabled = cbKhoa.Enabled = true;
                btnGhi.Enabled = false;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int MALTC = -1;
            if (bdsDANGKY.Count > 0)
            {
                MessageBox.Show("Không thể xóa lớp tín chỉ này vì đã có sinh viên đăng ký", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Bạn có thật sự muốn xóa lớp tín chỉ này không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                try
                {
                    DataRow data = gridViewCreditClass.GetFocusedDataRow();
                    MALTC = Convert.ToInt32(data["MALTC"]);
                    flagMode = "DELETECREDITCLASS";
                    pushDataToProcessStack(data);
                    data.Delete();

                    this.LOPTINCHITableAdapter.Connection.ConnectionString = Program.connectString;
                    this.LOPTINCHITableAdapter.Update(this.qldsV_TCDataSet.LOPTINCHI);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa lớp tín chỉ: " + ex.Message, "", MessageBoxButtons.OK);
                    this.LOPTINCHITableAdapter.Fill(this.qldsV_TCDataSet.LOPTINCHI);
                    bdsLOPTINCHI.Position = bdsLOPTINCHI.Find("MALTC", MALTC);
                    processStoreStack.Pop();
                    flagMode = "";
                    return;
                }
                btnThem.Enabled = btnPhucHoi.Enabled = true;
                btnXoa.Enabled = btnSua.Enabled = false;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            positionSelectedCreditClass = bdsLOPTINCHI.Position;
            positionSelectedSubject = gridViewSubject.FocusedRowHandle;

            flagMode = "EDITCREDITCLASS";
            DataRow data = gridViewCreditClass.GetFocusedDataRow();
            pushDataToProcessStack(data);
            btnGhi.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnPhucHoi.Enabled = cbKhoa.Enabled = false;
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            if (flagMode == "EDITCREDITCLASS" || flagMode == "ADDCRDITCLASS")
            {
                DialogResult dialog = MessageBox.Show("Bạn đang trong quá trình thay đổi thông tin bạn có muốn làm mới không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialog == DialogResult.No)
                {
                    return;
                }
                else
                {
                    flagMode = "";
                    positionSelectedCreditClass = -1;
                }
            }
            this.MONHOCTableAdapter.Connection.ConnectionString = Program.connectString;
            this.MONHOCTableAdapter.Fill(this.qldsV_TCDataSet.MONHOC);

            this.LOPTINCHITableAdapter.Connection.ConnectionString = Program.connectString;
            this.LOPTINCHITableAdapter.Fill(this.qldsV_TCDataSet.LOPTINCHI);

            this.DANGKYTableAdapter.Connection.ConnectionString = Program.connectString;
            this.DANGKYTableAdapter.Fill(this.qldsV_TCDataSet.DANGKY);

            btnThem.Enabled = cbKhoa.Enabled = true;
            btnGhi.Enabled = btnXoa.Enabled = btnSua.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (flagMode != "EDITCREDITCLASS" && flagMode != "ADDCREDITCLASS")
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

        private void btnPhucHoi_Click(object sender, EventArgs e)
        {
            if (processStoreStack.Count > 0)
            {
                Services.ProcessStore command = processStoreStack.Pop();
                int MALTC = Convert.ToInt32(command.primaryKey);
                LopTinChi lopTinChi = new LopTinChi();

                switch (command.flagMode)
                {
                    case "ADDCREDITCLASS":
                        int rowIndex = gridViewCreditClass.LocateByValue("MALTC", MALTC);

                        try
                        {
                            gridViewCreditClass.DeleteRow(rowIndex);
                            this.LOPTINCHITableAdapter.Update(this.qldsV_TCDataSet.LOPTINCHI);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi xóa lớp tín chỉ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.LOPTINCHITableAdapter.Fill(this.qldsV_TCDataSet.LOPTINCHI);
                            return;
                        }
                        break;

                    case "DELETECREDITCLASS":
                        lopTinChi = (LopTinChi)command.dataRow;
                        gridViewSubject.FocusedRowHandle = gridViewSubject.LocateByValue("MAMH", lopTinChi.MaMH);

                        try
                        {
                            bdsLOPTINCHI.AddNew();
                            gridViewCreditClass.SetFocusedRowCellValue("NIENKHOA", lopTinChi.NienKhoa);
                            gridViewCreditClass.SetFocusedRowCellValue("HOCKY", lopTinChi.HocKy);
                            gridViewCreditClass.SetFocusedRowCellValue("MAMH", lopTinChi.MaMH);
                            gridViewCreditClass.SetFocusedRowCellValue("NHOM", lopTinChi.Nhom);
                            gridViewCreditClass.SetFocusedRowCellValue("MAGV", lopTinChi.MaGV);
                            gridViewCreditClass.SetFocusedRowCellValue("MAKHOA", lopTinChi.MaKhoa);
                            gridViewCreditClass.SetFocusedRowCellValue("SOSVTOITHIEU", lopTinChi.SoSVToiThieu);
                            gridViewCreditClass.SetFocusedRowCellValue("HUYLOP", lopTinChi.HuyLop);
                            bdsLOPTINCHI.EndEdit();
                            this.LOPTINCHITableAdapter.Update(this.qldsV_TCDataSet.LOPTINCHI);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi khôi phục lớp tín chỉ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.LOPTINCHITableAdapter.Fill(this.qldsV_TCDataSet.LOPTINCHI);
                            return;
                        }
                        break;

                    default:
                        lopTinChi = (LopTinChi)command.dataRow;

                        gridViewSubject.FocusedRowHandle = gridViewSubject.LocateByValue("MAMH", lopTinChi.MaMH);
                        positionSelectedCreditClass = gridViewCreditClass.LocateByValue("MALTC", MALTC);
                        if (positionSelectedCreditClass < 0)
                        {
                            positionSelectedCreditClass = -1;
                            break;
                        }
                        gridViewCreditClass.FocusedRowHandle = positionSelectedCreditClass;

                        try
                        {
                            gridViewCreditClass.BeginUpdate();
                            gridViewCreditClass.SetRowCellValue(positionSelectedCreditClass, "NIENKHOA", lopTinChi.NienKhoa);
                            gridViewCreditClass.SetRowCellValue(positionSelectedCreditClass, "HOCKY", lopTinChi.HocKy);
                            gridViewCreditClass.SetRowCellValue(positionSelectedCreditClass, "NHOM", lopTinChi.Nhom);
                            gridViewCreditClass.SetRowCellValue(positionSelectedCreditClass, "MAGV", lopTinChi.MaGV);
                            gridViewCreditClass.SetRowCellValue(positionSelectedCreditClass, "SOSVTOITHIEU", lopTinChi.SoSVToiThieu);
                            gridViewCreditClass.SetRowCellValue(positionSelectedCreditClass, "HUYLOP", lopTinChi.HuyLop);
                            gridViewCreditClass.EndUpdate();

                            DataRow row = ((DataRowView)bdsLOPTINCHI[positionSelectedCreditClass]).Row;
                            this.LOPTINCHITableAdapter.Update(row);

                            positionSelectedCreditClass = -1;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi khôi phục lớp tín chỉ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.LOPTINCHITableAdapter.Fill(this.qldsV_TCDataSet.LOPTINCHI);
                            return;
                        }
                        break;
                }

                if (processStoreStack.Count == 0)
                    btnPhucHoi.Enabled = false;
            }
        }

        private void gridViewSubject_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if ((flagMode == "EDITCREDITCLASS" || flagMode == "ADDCREDITCLASS") && gridViewSubject.FocusedRowHandle != positionSelectedSubject)
            {
                DialogResult dialog = MessageBox.Show("Bạn đang trong quá trình chỉnh sửa thông tin bạn thật sự muốn làm mới không?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialog == DialogResult.No)
                {
                    e.Handled = true;

                    gridViewSubject.FocusedRowHandle = positionSelectedSubject;
                    gridViewCreditClass.FocusedRowHandle = positionSelectedCreditClass;

                    return;
                }
                else
                {
                    flagMode = "";
                    positionSelectedSubject = -1;
                    positionSelectedCreditClass = -1;
                }
            }

            if (gridViewSubject.FocusedRowHandle != positionSelectedSubject)
            {

              

                this.LOPTINCHITableAdapter.Connection.ConnectionString = Program.connectString;
                this.LOPTINCHITableAdapter.Fill(this.qldsV_TCDataSet.LOPTINCHI);

                this.DANGKYTableAdapter.Connection.ConnectionString = Program.connectString;
                this.DANGKYTableAdapter.Fill(this.qldsV_TCDataSet.DANGKY);
                SubjectNumberSelected = gridViewSubject.GetDataRow(gridViewSubject.FocusedRowHandle)["MAMH"].ToString();

                btnThem.Enabled = cbKhoa.Enabled = true;
                btnXoa.Enabled = btnSua.Enabled = btnGhi.Enabled = false;
            }
        }

        private void gridViewCreditClass_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if ((flagMode == "EDITCREDITCLASS" || flagMode == "ADDCREDITCLASS") && bdsLOPTINCHI.Position != positionSelectedCreditClass)
            {
                DialogResult dialog = MessageBox.Show("Bạn đang trong quá trình chỉnh sửa thông tin bạn thật sự muốn làm mới không?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialog == DialogResult.No)
                {
                    e.Handled = true;
                    gridViewCreditClass.FocusedRowHandle = positionSelectedCreditClass;
                    return;
                }
                else
                {
                    this.MONHOCTableAdapter.Connection.ConnectionString = Program.connectString;
                    this.MONHOCTableAdapter.Fill(this.qldsV_TCDataSet.MONHOC);

                    this.LOPTINCHITableAdapter.Connection.ConnectionString = Program.connectString;
                    this.LOPTINCHITableAdapter.Fill(this.qldsV_TCDataSet.LOPTINCHI);

                    this.DANGKYTableAdapter.Connection.ConnectionString = Program.connectString;
                    this.DANGKYTableAdapter.Fill(this.qldsV_TCDataSet.DANGKY);

                    flagMode = "";
                    positionSelectedCreditClass = -1;
                }
            }

            if (bdsLOPTINCHI.Position != positionSelectedCreditClass)
                btnThem.Enabled = btnSua.Enabled = cbKhoa.Enabled = true;
        }

        private void gridViewCreditClass_ShowingEditor(object sender, CancelEventArgs e)
        {
            if (bdsLOPTINCHI.Position != positionSelectedCreditClass
                || ((gridViewCreditClass.FocusedColumn.FieldName == "HUYLOP" || gridViewCreditClass.FocusedColumn.FieldName == "MAMH") && flagMode.Equals("ADDCREDITCLASS")))
                e.Cancel = true;
        }

        private void gridViewCreditClass_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            if (gridViewCreditClass.FocusedColumn.FieldName == "NIENKHOA" || gridViewCreditClass.FocusedColumn.FieldName == "NHOM"
            || gridViewCreditClass.FocusedColumn.FieldName == "MAGV" || gridViewCreditClass.FocusedColumn.FieldName == "SOSVTOITHIEU")
            {
                if (e.Value == null || e.Value.ToString().Trim().Length == 0)
                {
                    e.ErrorText = "Không được để trống ô này";
                    e.Valid = false;
                }
            }

            if (gridViewCreditClass.FocusedColumn.FieldName == "NIENKHOA")
            {
                e.Value = HandleString.RemoveAllSpaces(e.Value.ToString());

                bool match = Regex.IsMatch(e.Value.ToString().ToUpper(), "[0-9][0-9][0-9][0-9][-][0-9][0-9][0-9][0-9]");
                if (!match || e.Value.ToString().Length < 9)
                {
                    e.ErrorText = "Khóa học bạn nhập không hợp lệ \n Ví dụ: 2023-2024";
                    e.Valid = false;
                }
                else
                {
                    String[] years = e.Value.ToString().Split('-');
                    int startYear = int.Parse(years[0]);
                    int endYear = int.Parse(years[1]);

                    if (startYear > endYear)
                    {
                        e.ErrorText = "Niên khóa bạn phải có năm bắt đầu nhỏ hơn năm kết thúc";
                        e.Valid = false;
                    }

                    e.Value = e.Value.ToString().ToUpper();
                }
            }
        }
    }
}