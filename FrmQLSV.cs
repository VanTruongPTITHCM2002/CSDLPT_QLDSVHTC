using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using QLDSV_TC.Services;

namespace QLDSV_TC
{
    public partial class FrmQLSV : DevExpress.XtraEditors.XtraForm
    {
        private int positionSelectedSV = -1;
        private String classNumberSelected = "";
        private int positionSelectedClass = -1;
        private String flagMode = "";
        private Stack<Services.ProcessStore> processStoreStack = new Stack<Services.ProcessStore>();
        public FrmQLSV()
        {
            InitializeComponent();
            sqlDataSource.FillAsync();
        }

        private void pushDataToProcessStack(DataRow data)
        {
            SinhVien SV = new SinhVien(data["MASV"].ToString(),
                data["HO"].ToString(), data["TEN"].ToString(), (bool)data["PHAI"], data["DIACHI"].ToString(), data["NGAYSINH"].ToString(),
                data["MALOP"].ToString(), (bool)data["DANGHIHOC"], data["PASSWORD"].ToString());

            processStoreStack.Push(new Services.ProcessStore(flagMode, data["MASV"].ToString(), SV));
        }

        private void FrmQLSV_Load(object sender, EventArgs e)
        {

            this.LOPTableAdapter.Connection.ConnectionString = Program.connectString;
            this.LOPTableAdapter.Fill(this.qldsV_TCDataSet.LOP);

            this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connectString;
            this.SINHVIENTableAdapter.Fill(this.qldsV_TCDataSet.SINHVIEN);

            this.DANGKYTableAdapter.Connection.ConnectionString = Program.connectString;
            this.DANGKYTableAdapter.Fill(this.qldsV_TCDataSet.DANGKY);

            Program.bdsDSPM.Filter = "TENKHOA not LIKE 'Phòng kế toán%'  ";
            cbKhoa.DataSource = Program.bdsDSPM;
            cbKhoa.DisplayMember = "TENKHOA";
            cbKhoa.ValueMember = "TENSERVER";
            cbKhoa.SelectedValue = Program.servername;

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
                this.LOPTableAdapter.Connection.ConnectionString = Program.connectString;
                this.LOPTableAdapter.Fill(this.qldsV_TCDataSet.LOP);

                this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connectString;
                this.SINHVIENTableAdapter.Fill(this.qldsV_TCDataSet.SINHVIEN);

                this.DANGKYTableAdapter.Connection.ConnectionString = Program.connectString;
                this.DANGKYTableAdapter.Fill(this.qldsV_TCDataSet.DANGKY);


                processStoreStack.Clear();
                btnPhucHoi.Enabled = false;

            }
        }
        private void FrmQLSV_FormClosed(object sender, FormClosedEventArgs e)
        {
            cbKhoa.SelectedIndexChanged -= cbKhoa_SelectedIndexChanged;
        }
        private void getDataFromRowSelected()
        {
            DataRow row = gridViewStudents.GetDataRow(gridViewStudents.FocusedRowHandle);

            if (row != null)
            {
                txtMSSV.Text = row["MASV"].ToString();
                txtHo.Text = row["HO"].ToString();
                txtTen.Text = row["TEN"].ToString();
                txtNgaySinh.Text = ((DateTime)row["NGAYSINH"]).ToString("dd/MM/yyyy");
                txtDiaChi.Text = row["DIACHI"].ToString();
                txtMaLop.Text = row["MALOP"].ToString();

                if (row["PHAI"].ToString() == "True")
                {
                    rdgGT.SelectedIndex = 1;
                }
                else
                {
                    rdgGT.SelectedIndex = 0;
                }

                if (row["DANGHIHOC"].ToString() == "True")
                {
                    chkStatus.Checked = true;
                }
            }
        }

        private void gridViewStudents_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if((flagMode == "ADDSTUDENT" || flagMode == "EDITSTUDENT") && bdsSINHVIEN.Position != positionSelectedSV)
            {
                DialogResult dialog = MessageBox.Show("Bạn đang trong quá trình thay đổi thông tin bạn có muốn làm mới không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialog == DialogResult.No)
                {
                    e.Handled = true;                 
                    gridViewStudents.FocusedRowHandle = positionSelectedSV;
                    return;
                }
                else
                {
                    flagMode = "";
                    positionSelectedSV = -1;
                    btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnPhucHoi.Enabled = btnTaiLai.Enabled= cbKhoa.Enabled= true;
                    btnGhi.Enabled = false;
                    
                }
            }
            if (bdsSINHVIEN.Position != positionSelectedSV)
            {
                getDataFromRowSelected();
            }
        }
        private void reloadDataForm()
        {
            txtMSSV.Text = "";
            txtHo.Text = "";
            txtTen.Text = "";
            txtNgaySinh.Text = "";
            txtDiaChi.Text = "";
            txtMaLop.Text = "";

            rdgGT.SelectedIndex = 0;

            chkStatus.Checked = false;
        }

        private void defaultValueInputSV()
        {
            qldsV_TCDataSet.SINHVIEN.DANGHIHOCColumn.DefaultValue = false;
            qldsV_TCDataSet.SINHVIEN.PHAIColumn.DefaultValue = false;
            qldsV_TCDataSet.SINHVIEN.PASSWORDColumn.DefaultValue = Program.defaultPasswordSV;
            qldsV_TCDataSet.SINHVIEN.MALOPColumn.DefaultValue = classNumberSelected;

            DevExpress.XtraEditors.Repository.RepositoryItemDateEdit dateEdit = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            dateEdit.MaxValue = DateTime.Now.AddYears(-18);
            colNGAYSINH.ColumnEdit = dateEdit;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            reloadDataForm();
            defaultValueInputSV();

            bdsSINHVIEN.AddNew();

            positionSelectedSV = bdsSINHVIEN.Count - 1;
            positionSelectedClass = gridViewClass.FocusedRowHandle;

            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnPhucHoi.Enabled = cbKhoa.Enabled = false;
            btnGhi.Enabled = true;
            flagMode = "ADDSTUDENT";
            
        }

        
        private bool checkDataSV()
        {
            DataRowView dataSV = (DataRowView)bdsSINHVIEN[positionSelectedSV];
            if (dataSV["MASV"].ToString().Trim() == "")
            {
                MessageBox.Show("Mã sinh viên không được để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (dataSV["HO"].ToString().Trim() == "")
            {
                MessageBox.Show("Họ không được thiếu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }
            if (dataSV["TEN"].ToString().Trim() == "")
            {
                MessageBox.Show("Tên không được thiếu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (dataSV["PHAI"].ToString() == "")
            {
                MessageBox.Show("Vui Lòng Chọn Phái!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (flagMode == "ADDSTUDENT")
            {
                String query = " DECLARE @return_value INT" +

                                " EXEC @return_value = [dbo].[SP_CHECKMASV]" +

                                " N'" + dataSV["MASV"].ToString().Trim() + "'" +

                                " SELECT @return_value";

                int resultMa = Program.CheckPrimaryKey(query);
                if (resultMa == -1)
                {
                    MessageBox.Show("Lỗi kết nối với database. Vui long thử lại sau!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (resultMa == 1)
                {
                    MessageBox.Show("Mã Sinh Viên đã tồn tại. Mời bạn nhập mã khác !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if (resultMa == 2)
                {
                    MessageBox.Show("Mã Sinh Viên đã tồn tại ở Khoa khác. Mời bạn nhập lại !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

            }
            return true;
        }
        private void btnGhi_Click(object sender, EventArgs e)
        {
            if (checkDataSV())
            {
                try
                {
                    bdsSINHVIEN.EndEdit();
                    bdsSINHVIEN.ResetCurrentItem();

                    this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connectString;

                    DataRow row = ((DataRowView)bdsSINHVIEN[bdsSINHVIEN.Position]).Row;
                    this.SINHVIENTableAdapter.Update(row);

                    if (flagMode == "ADDSTUDENT")
                        processStoreStack.Push(new Services.ProcessStore(flagMode, row["MASV"].ToString()));

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ghi sinh viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                flagMode = "";
                positionSelectedSV = -1;

                btnThem.Enabled = btnPhucHoi.Enabled = cbKhoa.Enabled = true;
                btnGhi.Enabled = false;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string MASV = "";

            if (bdsDANGKY.Count > 0)
            {
                MessageBox.Show("Không thể xóa nhân viên này vì sinh viên này đã đăng ký lớp tín chỉ", "Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            if(MessageBox.Show("Bạn có thật sự muốn xóa sinh viên này ?" , "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                try
                {
                    DataRow data = gridViewStudents.GetFocusedDataRow();
                    MASV = data["MASV"].ToString();
                    flagMode = "DELETESTUDENT";
                    pushDataToProcessStack(data);
                    data.Delete();

                    this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connectString;
                    this.SINHVIENTableAdapter.Update(this.qldsV_TCDataSet.SINHVIEN);

                }catch(Exception ex)
                {
                    MessageBox.Show("Lỗi xóa nhân viên" + ex.Message, "", MessageBoxButtons.OK);
                    this.SINHVIENTableAdapter.Fill(this.qldsV_TCDataSet.SINHVIEN);
                    bdsSINHVIEN.Position = bdsSINHVIEN.Find("MASV", MASV);
                    processStoreStack.Pop();
                    flagMode = "";
                    return;
                }
            }
            btnThem.Enabled = btnPhucHoi.Enabled = true;
            btnXoa.Enabled = btnSua.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            flagMode = "EDITSTUDENT";
            positionSelectedSV = bdsSINHVIEN.Position;
            positionSelectedClass = gridViewClass.FocusedRowHandle;
            DataRow data = gridViewStudents.GetFocusedDataRow();
            pushDataToProcessStack(data);

            btnGhi.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnPhucHoi.Enabled = cbKhoa.Enabled = false;
        }

        private void btnPhucHoi_Click(object sender, EventArgs e)
        {
            if(processStoreStack.Count > 0)
            {
                Services.ProcessStore command = processStoreStack.Pop();
                String MASV = command.primaryKey;
                SinhVien SV = new SinhVien();

                switch (command.flagMode)
                {
                    case "ADDSTUDENT":
                        int rowIndex = gridViewStudents.LocateByValue("MASV", MASV);

                        try
                        {
                            gridViewStudents.DeleteRow(rowIndex);
                            this.SINHVIENTableAdapter.Update(this.qldsV_TCDataSet.SINHVIEN);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi xóa sinh viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.SINHVIENTableAdapter.Fill(this.qldsV_TCDataSet.SINHVIEN);
                            return;
                        }
                        break;

                    case "DELETESTUDENT":
                        SV = (SinhVien)command.dataRow;
                        gridViewClass.FocusedRowHandle = gridViewClass.LocateByValue("MALOP", SV.MaLop);

                        try
                        {
                            bdsSINHVIEN.AddNew();

                            gridViewStudents.SetFocusedRowCellValue("MASV", SV.MaSV);
                            gridViewStudents.SetFocusedRowCellValue("HO", SV.Ho);
                            gridViewStudents.SetFocusedRowCellValue("TEN", SV.Ten);
                            gridViewStudents.SetFocusedRowCellValue("PHAI", SV.Phai);
                            gridViewStudents.SetFocusedRowCellValue("NGAYSINH", SV.NgaySinh);
                            gridViewStudents.SetFocusedRowCellValue("DIACHI", SV.DiaChi);
                            gridViewStudents.SetFocusedRowCellValue("MALOP", SV.MaLop);
                            gridViewStudents.SetFocusedRowCellValue("DANGHIHOC", SV.DangNghiHoc);
                            gridViewStudents.SetFocusedRowCellValue("PASSWORD", SV.PassWord);

                            bdsSINHVIEN.EndEdit();
                            this.SINHVIENTableAdapter.Update(this.qldsV_TCDataSet.SINHVIEN);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi khôi phục sinh viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.SINHVIENTableAdapter.Fill(this.qldsV_TCDataSet.SINHVIEN);
                            return;
                        }
                        break;

                    default:
                        SV = (SinhVien)command.dataRow;

                        gridViewClass.FocusedRowHandle = gridViewClass.LocateByValue("MALOP", SV.MaLop);
                        positionSelectedSV = gridViewStudents.LocateByValue("MASV", MASV);
                        gridViewStudents.FocusedRowHandle = positionSelectedSV;

                        try
                        {
                            gridViewStudents.BeginUpdate();
                            gridViewStudents.SetRowCellValue(positionSelectedSV, "HO", SV.Ho);
                            gridViewStudents.SetRowCellValue(positionSelectedSV, "TEN", SV.Ten);
                            gridViewStudents.SetRowCellValue(positionSelectedSV, "PHAI", SV.Phai);
                            gridViewStudents.SetRowCellValue(positionSelectedSV, "NGAYSINH", SV.NgaySinh);
                            gridViewStudents.SetRowCellValue(positionSelectedSV, "DIACHI", SV.DiaChi);
                            gridViewStudents.SetRowCellValue(positionSelectedSV, "DANGHIHOC", SV.DangNghiHoc);
                            gridViewStudents.EndUpdate();

                            DataRow row = ((DataRowView)bdsSINHVIEN[positionSelectedSV]).Row;
                            this.SINHVIENTableAdapter.Update(row);

                            positionSelectedSV = -1;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi khôi phục sinh viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.SINHVIENTableAdapter.Fill(this.qldsV_TCDataSet.SINHVIEN);
                            return;
                        }
                        break;
                }

                if (processStoreStack.Count == 0)
                    btnPhucHoi.Enabled = false;
             }
            }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            if(flagMode == "EDITSTUDENT" || flagMode == "ADDSTUDENT")
            {
                DialogResult dialog = MessageBox.Show("Bạn đang trong quá trình thay đổi thông tin bạn có muốn làm mới không?", "Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
                if (dialog == DialogResult.No)
                {
                    return;
                }
                else
                {
                    flagMode = "";
                    positionSelectedSV = -1;
                }
            }
            this.LOPTableAdapter.Connection.ConnectionString = Program.connectString;
            this.LOPTableAdapter.Fill(this.qldsV_TCDataSet.LOP);
            this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connectString;
            this.SINHVIENTableAdapter.Fill(this.qldsV_TCDataSet.SINHVIEN);

            this.DANGKYTableAdapter.Connection.ConnectionString = Program.connectString;
            this.DANGKYTableAdapter.Fill(this.qldsV_TCDataSet.DANGKY);
            reloadDataForm();
            btnThem.Enabled = cbKhoa.Enabled = true;
            btnGhi.Enabled = btnXoa.Enabled = btnSua.Enabled = false;
        }

   

        private void gridViewStudents_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            if (gridViewStudents.FocusedColumn.FieldName == "MASV")
            {
                e.Value = HandleString.RemoveAllSpaces(e.Value.ToString());

                bool match = Regex.IsMatch(e.Value.ToString().ToUpper(), "[NB][0-9][0-9][A-Z][A-Z][A-Z][A-Z][0-9][0-9][0-9]");
                if (!match || e.Value.ToString().Length != 10)
                {
                    e.ErrorText = "Mã sinh viên bạn nhập không đúng định dạng hoặc độ dài không đủ 10 kí tự \n Ví dụ: N20DCCN001";
                    e.Valid = false;
                }
                else
                {
                    e.Value = e.Value.ToString().ToUpper();
                }
            }

            if (gridViewStudents.FocusedColumn.FieldName == "HO" || gridViewStudents.FocusedColumn.FieldName == "TEN")
            {
                e.Value = HandleString.RemoveExtraSpaces(e.Value.ToString());
                if (e.Value.ToString().Trim().Length == 0)
                {
                    e.ErrorText = "Không được để trống ô này";
                    e.Valid = false;
                }
                else
                {
                    e.Value = HandleString.UppercaseString(e.Value.ToString());
                }
            }

            if (gridViewStudents.FocusedColumn.FieldName == "DIACHI")
            {
                e.Value = HandleString.RemoveExtraSpaces(e.Value.ToString());
                e.Value = HandleString.UppercaseString(e.Value.ToString());
            }
        }

        private void gridViewStudents_ShowingEditor(object sender, CancelEventArgs e)
        {
            if (bdsSINHVIEN.Position != positionSelectedSV
              || (gridViewStudents.FocusedColumn.FieldName == "MASV" && flagMode.Equals("EDITSTUDENT"))
              || (gridViewStudents.FocusedColumn.FieldName == "DANGHIHOC" && flagMode.Equals("ADDSTUDENT")))
                e.Cancel = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (flagMode != "EDITSTUDENT" && flagMode != "ADDSTUDENT")
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

        private void gridViewClass_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if ((flagMode == "EDITSTUDENT" || flagMode == "ADDSTUDENT") && gridViewClass.FocusedRowHandle != positionSelectedClass)
            {
                DialogResult dialog = MessageBox.Show("Bạn đang trong quá trình chỉnh sửa thông tin bạn thật sự muốn làm mới không?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialog == DialogResult.No)
                {
                    e.Handled = true;

                    gridViewClass.FocusedRowHandle = positionSelectedClass;
                    gridViewStudents.FocusedRowHandle = positionSelectedSV;

                    return;
                }
                else
                {
                    flagMode = "";
                    positionSelectedSV = -1;
                    positionSelectedClass = -1;
                }
            }

            if (gridViewClass.FocusedRowHandle != positionSelectedClass)
            {
               

                this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connectString;
                this.SINHVIENTableAdapter.Fill(this.qldsV_TCDataSet.SINHVIEN);

                this.DANGKYTableAdapter.Connection.ConnectionString = Program.connectString;
                this.DANGKYTableAdapter.Fill(this.qldsV_TCDataSet.DANGKY);

                classNumberSelected = gridViewClass.GetDataRow(gridViewClass.FocusedRowHandle)["MALOP"].ToString();

                btnThem.Enabled = cbKhoa.Enabled = true;
                btnXoa.Enabled = btnSua.Enabled = btnGhi.Enabled = false;
            }
        }

        private void gridViewClass_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            reloadDataForm();
        }
    }
}
