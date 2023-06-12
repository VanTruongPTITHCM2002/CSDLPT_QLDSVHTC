﻿using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace QLDSV_TC
{
    static class Program
    {
        public static SqlConnection connect = new SqlConnection();// Hỗ trợ kết nối database
        public static String connectString;
        public static String connstr_publisher = "Data Source=LAPTOP-ICKBRAQN\\MSSQLSERVER02;Initial Catalog=QLDSV_TC;Integrated Security=True";
        public static String servername = "";
        public static BindingSource bdsDSPM = new BindingSource();
        public static String database = "QLDSV_TC";
        public static String mLogin;
        public static String mPassword;
        public static String mLoginDN;
        public static String mPasswordDN;
        public static String mLoginSV = "";
        public static String mPasswordSV = "";
        public static String mUserName;
        public static String mName;
        public static String mGroup;
        public static String remotelogin = "HTKN";
        public static String remotepassword = "1";
        public static String defaultPasswordSV = "";
        public static SqlDataReader myReader; // Đoc dữ liệu 1 chiều
        public static FrmLogin frmLogin;
        public static FrmMain frmMain;
        public static FrmQLSV frmQLSV;
        public static FrmQLLH frmQLLH;
        public static FrmQLMH frmQLMH;
        public static FrmQLLTC frmQLLTC;
        public static FrmQLCD frmQLCD;
        public static FrmQLHP frmQLHP;
        public static FrmSVDK frmSVDK;
        public static FrmTTK frmTTK;
        public static RpfListCreditClass rpfListCreditClass;
        public static RpfListStudentCreditClass rpfListStudentCredit;
        public static RpfScoresCreditClass rpfScoresCreditClass;
        public static RpfStudentScores rpfStudentScores;
        public static RpfListPayTuitionOfClass rpfListPayTuition;
        public static RpfFinalScoresOfClass RpfFinalScoresOfClass;
        public static int mPhongBan;
        public static int hocPhi = 550000;
        public static bool KetNoi()
        {
            if (Program.connect.State == ConnectionState.Open) Program.connect.Close();
            try
            {
                Program.connectString = "Data Source=" + Program.servername + ";Initial Catalog=" + Program.database + ";User ID=" +
                      Program.mLogin + ";password=" + Program.mPassword;
               
                Program.connect.ConnectionString = Program.connectString;
                Program.connect.Open();
                return true;
            }

            catch (Exception e)
            {
                Console.WriteLine(Program.servername);
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nBạn xem lại user name và password.\n " + e.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
              
                return false;
            }
        }
        
        public static DataTable ExecSqlDataTable(String cmd)
        {
            DataTable dt = new DataTable();
            if (Program.connect.State == ConnectionState.Closed)
                Program.connect.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, Program.connect);
            da.Fill(dt);
            Program.connect.Close();
            return dt;
        }
        
        public static SqlDataReader ExecSqlDataReader(String cmd)
        {
            SqlDataReader myReader;
            SqlCommand sqlcmd = new SqlCommand(cmd, Program.connect);
            sqlcmd.CommandType = CommandType.Text;
            if (Program.connect.State == ConnectionState.Closed)
                Program.connect.Open();
            try
            {
                myReader = sqlcmd.ExecuteReader();
                return myReader;
            }catch(Exception e)
            {
                Program.connect.Close();
                MessageBox.Show(e.Message);
                return null;
            }
        }

        public static DataTable ExecSqlQuery(String cmd, String connectionstring)
        {
            DataTable dt = new DataTable();
            if (Program.connect.State == ConnectionState.Closed)
                Program.connect.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, connect);
            da.Fill(dt);
            Program.connect.Close();
            return dt;
        }

        public static void ExecSqlNonQuery(String cmd)
        {
            SqlCommand sqlcmd = new SqlCommand(cmd, Program.connect);
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.CommandTimeout = 600;
            if (Program.connect.State == ConnectionState.Closed)
                Program.connect.Open();
            try
            {
                sqlcmd.ExecuteNonQuery(); //conn.Close()
                MessageBox.Show("Thao tác thành công!!", "", MessageBoxButtons.OK);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            finally
            {
                Program.connect.Close();
            }

        }

        public static int CheckPrimaryKey(String query)
        {
            SqlDataReader dataReader = Program.ExecSqlDataReader(query);
            if (dataReader == null)
                return -1;

            dataReader.Read();
            int result = dataReader.GetInt32(0);
            dataReader.Close();
            return result;
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            frmLogin = new FrmLogin();
            Application.Run(frmLogin);
            
        }
    }
}
