﻿using DevExpress.XtraEditors;
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
    public partial class FrmQLMH : DevExpress.XtraEditors.XtraForm
    {
        private String flagMode = "";
        private int positionSelectedSubject = -1;
        private Stack<ProcessStore> processStoreStack = new Stack<ProcessStore>();
        public FrmQLMH()
        {
            InitializeComponent();
        }

        private void FrmQLMH_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qldsV_TCDataSet.LOPTINCHI' table. You can move, or remove it, as needed.
            this.MONHOCTableAdapter.Connection.ConnectionString = Program.connectString;
            this.MONHOCTableAdapter.Fill(this.qldsV_TCDataSet.MONHOC);

            this.LOPTINCHITableAdapter.Connection.ConnectionString = Program.connectString;
            this.LOPTINCHITableAdapter.Fill(this.qldsV_TCDataSet.LOPTINCHI);
            this.qldsV_TCDataSet.EnforceConstraints = false;

        }
        private void pushDataToProcessStack(DataRow data)
        {
            MonHoc monHoc = new MonHoc(data["MAMH"].ToString(), data["TENMH"].ToString()
                , (Int32)data["SOTIET_LT"], (Int32)data["SOTIET_TH"]);

            processStoreStack.Push(new Services.ProcessStore(flagMode, data["MAMH"].ToString(), monHoc));
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            bdsMONHOC.AddNew();

            gridViewSubject.SetFocusedRowCellValue("SOTIET_LT", 0);
            gridViewSubject.SetFocusedRowCellValue("SOTIET_TH", 0);
            this.positionSelectedSubject = bdsMONHOC.Count - 1;

            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnPhucHoi.Enabled = false;
            b.Enabled = true;

            flagMode = "ADDSUBJECT";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            positionSelectedSubject = gridViewSubject.FocusedRowHandle;

            flagMode = "EDITSUBJECT";

            DataRow data = gridViewSubject.GetFocusedDataRow();
            pushDataToProcessStack(data);

            b.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnPhucHoi.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            String MAMH = "";
            if (bdsLOPTINCHI.Count > 0)
            {
                MessageBox.Show("Không thể môn học này vì môn học đã đăng ký lớp tín chỉ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Bạn có thật sự muốn xóa môn học này ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                try
                {
                    DataRow data = gridViewSubject.GetFocusedDataRow();
                    MAMH = data["MAMH"].ToString();

                    flagMode = "DELETESUBJECT";
                    pushDataToProcessStack(data);

                    data.Delete();

                    this.MONHOCTableAdapter.Connection.ConnectionString = Program.connectString;
                    this.MONHOCTableAdapter.Update(this.qldsV_TCDataSet.MONHOC);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa môn học: " + ex.Message, "", MessageBoxButtons.OK);

                    this.MONHOCTableAdapter.Fill(this.qldsV_TCDataSet.MONHOC);
                    bdsMONHOC.Position = bdsMONHOC.Find("MALOP", MAMH);

                    processStoreStack.Pop();
                    flagMode = "";
                    return;
                }

                btnThem.Enabled = btnPhucHoi.Enabled = true;
                btnXoa.Enabled = btnSua.Enabled = false;
            }
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            if (checkDataSubject())
            {
                try
                {
                    bdsMONHOC.EndEdit();
                    bdsMONHOC.ResetCurrentItem();

                    this.MONHOCTableAdapter.Connection.ConnectionString = Program.connectString;

                    DataRow row = ((DataRowView)bdsMONHOC[bdsMONHOC.Position]).Row;
                    this.MONHOCTableAdapter.Update(row);

                    if (flagMode == "ADDSUBJECT")
                        processStoreStack.Push(new Services.ProcessStore(flagMode, row["MAMH"].ToString()));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ghi môn học: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                flagMode = "";
                positionSelectedSubject = -1;

                btnThem.Enabled = btnPhucHoi.Enabled = true;
                b.Enabled = false;
            }
        }

        private bool checkDataSubject()
        {
            DataRowView dataClass = (DataRowView)bdsMONHOC[positionSelectedSubject];
            if (dataClass["MAMH"].ToString().Trim() == "")
            {
                MessageBox.Show("Mã môn học không được để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (dataClass["TENMH"].ToString().Trim() == "")
            {
                MessageBox.Show("Tên môn học không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (dataClass["SOTIET_LT"].ToString().Trim() == "")
            {
                MessageBox.Show("Số tiết lý thuyết không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (dataClass["SOTIET_TH"].ToString() == "")
            {
                MessageBox.Show("Số tiết thực hành không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (((Int32)dataClass["SOTIET_LT"] + (Int32)dataClass["SOTIET_TH"]) % 15 != 0)
            {
                MessageBox.Show("Số tiết lý thuyết cộng số tiết thực hành phải là bội số của 15!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (flagMode == "ADDSUBJECT")
            {
                string query = " DECLARE @return_value INT" +

                               " EXEC @return_value = [dbo].[SP_CHECKMAMH]" +

                               " N'" + dataClass["MAMH"].ToString().Trim() + "' " +

                               " SELECT @return_value";

                int resultMa = Program.CheckPrimaryKey(query);
                if (resultMa == -1)
                {
                    MessageBox.Show("Lỗi kết nối với database.\n Vui long thử lại sau!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (resultMa == 1)
                {
                    MessageBox.Show("Mã môn học đã tồn tại.\n Mời bạn nhập mã khác !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            if (flagMode == "ADDSUBJECT" || flagMode == "EDITSUBJECT")
            {
                string query = " DECLARE @return_value INT" +

                               " EXEC @return_value = [dbo].[SP_CHECKTENMH]" +

                               " N'" + dataClass["MAMH"].ToString() + "', " +

                               " N'" + dataClass["TENMH"].ToString() + "' " +

                               " SELECT @return_value";

                int resultMa = Program.CheckPrimaryKey(query);
                if (resultMa == -1)
                {
                    MessageBox.Show("Lỗi kết nối với database.\n Vui long thử lại sau!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (resultMa == 1)
                {
                    MessageBox.Show("Tên môn học đã tồn tại.\n Mời bạn nhập mã khác !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            return true;
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            if (flagMode == "EDITSUBJECT" || flagMode == "ADDSUBJECT")
            {
                DialogResult dialog = MessageBox.Show("Bạn đang trong quá trình chỉnh sửa thông tin bạn thật sự muốn làm mới không?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialog == DialogResult.No)
                {
                    return;
                }
                else
                {
                    flagMode = "";
                    positionSelectedSubject = -1;
                }
            }
            this.MONHOCTableAdapter.Connection.ConnectionString = Program.connectString;
            this.MONHOCTableAdapter.Fill(this.qldsV_TCDataSet.MONHOC);

            this.LOPTINCHITableAdapter.Connection.ConnectionString = Program.connectString;
            this.LOPTINCHITableAdapter.Fill(this.qldsV_TCDataSet.LOPTINCHI);
            btnThem.Enabled = true;
            b.Enabled = btnXoa.Enabled = btnSua.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (flagMode != "EDITSUBJECT" && flagMode != "ADDSUBJECT")
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
                String MAMH = command.primaryKey;
                MonHoc monHoc = new MonHoc();

                switch (command.flagMode)
                {
                    case "ADDSUBJECT":
                        int rowIndex = gridViewSubject.LocateByValue("MAMH", MAMH);

                        try
                        {
                            gridViewSubject.DeleteRow(rowIndex);
                            this.MONHOCTableAdapter.Update(this.qldsV_TCDataSet.MONHOC);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi xóa môn học: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.MONHOCTableAdapter.Fill(this.qldsV_TCDataSet.MONHOC);
                            return;
                        }
                        break;

                    case "DELETESUBJECT":
                        monHoc = (MonHoc)command.dataRow;

                        try
                        {
                            bdsMONHOC.AddNew();

                            gridViewSubject.SetFocusedRowCellValue("MAMH", monHoc.MaMH);
                            gridViewSubject.SetFocusedRowCellValue("TENMH", monHoc.TenMH);
                            gridViewSubject.SetFocusedRowCellValue("SOTIET_LT", monHoc.SoTietLyThuyet);
                            gridViewSubject.SetFocusedRowCellValue("SOTIET_TH", monHoc.SoTietThucHanh);

                            bdsMONHOC.EndEdit();
                            this.MONHOCTableAdapter.Update(this.qldsV_TCDataSet.MONHOC);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi khôi phục môn học: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.MONHOCTableAdapter.Fill(this.qldsV_TCDataSet.MONHOC);
                            return;
                        }
                        break;

                    default:
                        monHoc = (MonHoc)command.dataRow;

                        positionSelectedSubject = gridViewSubject.LocateByValue("MAMH", monHoc.MaMH);
                        gridViewSubject.FocusedRowHandle = positionSelectedSubject;

                        try
                        {
                            gridViewSubject.BeginUpdate();
                            gridViewSubject.SetRowCellValue(positionSelectedSubject, "TENMH", monHoc.TenMH);
                            gridViewSubject.SetRowCellValue(positionSelectedSubject, "SOTIET_LT", monHoc.SoTietLyThuyet);
                            gridViewSubject.SetRowCellValue(positionSelectedSubject, "SOTIET_TH", monHoc.SoTietThucHanh);
                            gridViewSubject.EndUpdate();

                            DataRow row = ((DataRowView)bdsMONHOC[positionSelectedSubject]).Row;
                            this.MONHOCTableAdapter.Update(row);

                            positionSelectedSubject = -1;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi khôi phục môn học: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.MONHOCTableAdapter.Fill(this.qldsV_TCDataSet.MONHOC);
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
            if ((flagMode == "EDITSUBJECT" || flagMode == "ADDSUBJECT") && gridViewSubject.FocusedRowHandle != positionSelectedSubject)
            {
                DialogResult dialog = MessageBox.Show("Bạn đang trong quá trình chỉnh sửa thông tin bạn thật sự muốn làm mới không?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialog == DialogResult.No)
                {
                    gridViewSubject.FocusedRowHandle = positionSelectedSubject;
                    return;
                }
                else
                {
                    flagMode = "";
                    positionSelectedSubject = -1;
                }
            }
            btnXoa.Enabled = btnSua.Enabled = true;
        }

        private void gridViewSubject_ShowingEditor(object sender, CancelEventArgs e)
        {

            if (bdsMONHOC.Position != positionSelectedSubject
                || (gridViewSubject.FocusedColumn.FieldName == "MAMH" && flagMode.Equals("EDITCLASS")))
                e.Cancel = true;
        }

        private void gridViewSubject_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            if (gridViewSubject.FocusedColumn.FieldName == "MAMH")
            {
                e.Value = HandleString.RemoveAllSpaces(e.Value.ToString());

                bool match = Regex.IsMatch(e.Value.ToString(), @"^[a-zA-Z0-9]+$");
                if (!match || e.Value.ToString().Length > 10)
                {
                    e.ErrorText = "Mã lớp bạn nhập chứa ký tự đặc biệt hoặc độ dài quá 10 kí tự\n Ví dụ: KTLT";
                    e.Valid = false;
                }
                else
                {
                    e.Value = e.Value.ToString().ToUpper();
                }
            }

            if (gridViewSubject.FocusedColumn.FieldName == "TENMH")
            {
                if (e.Value.ToString().Trim().Length == 0)
                {
                    e.ErrorText = "Không được để trống ô này";
                    e.Valid = false;
                }
            }

            if (gridViewSubject.FocusedColumn.FieldName == "TENMH")
            {
                e.Value = HandleString.RemoveExtraSpaces(e.Value.ToString());
                e.Value = HandleString.UpperFirstCharInString(e.Value.ToString().ToLower());
            }
        }

      
    }
    
}