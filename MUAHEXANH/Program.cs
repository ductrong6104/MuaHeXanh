﻿using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MUAHEXANH.App;
using System.Threading;

namespace MUAHEXANH
{
    static class Program
    {
        #region Manh
        public static string progress;
        #endregion
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static SqlConnection conn = new SqlConnection();
        public static String connstr;
        // ket noi toi side chu
        public static String connstr_publisher = "Data Source=DESKTOP-9QNDCS8\\DUCTRONG;Initial Catalog=TTCS_MUAHEXANH;Integrated Security=True";

        // doc du lieu tu database
        public static SqlDataReader myReader;
        public static String servername = "";
        public static String username = "";
        // bien toan cuc login khi login
        public static String mlogin = "";
        // bien toan cuc pass khi login
        public static String password = "";

        public static String database = "TTCS_MUAHEXANH";
        

        public static String mloginDN = "";
        public static String passwordDN = "";
        public static String mGroup = "";
        public static String mHoten = "";
        // tam thoi mac dinh chien dich hien tai luc dang nhap la CD01
        public static String maChienDich = "CD01";
        public static String tenChienDich = "Mùa hè xanh";
        public static int mKhoa = 0;
        public static String mTeam = "";
        public static String mNhom = "";
        //Mã ấp được chọn khi mở form chọn mã ấp
        public static String maApDuocChon = null;
        //Tên backup device
        public static String backupDeviceName = null;

        public static BindingSource bds_dspm = new BindingSource(); // giu danh sach phan manh khi dang nhap
        public static frmMain frmChinh; // de su dung doi tuong frmChinh trong cac form khac (vi du form dang nhap voi form main trao doi du lieu voi nhau)
        public static frmDangNhap frmDN;

        public static int KetNoi()
        {
            // neu dang mo ket noi toi database, mo lan nua se bao loi => neu no dang mo-> ta dong -> mo lai
            if (Program.conn != null && Program.conn.State == ConnectionState.Open)
                Program.conn.Close();
            try
            {
                // mo ket noi tu bien khai bao trong program
                Program.connstr = "Data Source =" + Program.servername +
                                    ";Initial Catalog =" + Program.database +
                                    ";User ID=" + Program.mlogin +
                                    ";password=" + Program.password;
                Program.conn.ConnectionString = Program.connstr;
                Program.conn.Open();
                return 1;
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối tới cơ sở dữ liệu.\nBạn xem lại tên server, tên CSDL!!");
                return 0;
            }
        }

        public static SqlDataReader ExecSqlDataReader(String strLenh)
        {
            SqlDataReader myReader;
            // goi sp, goi view nen su dung sqlCommand
            SqlCommand sqlcmd = new SqlCommand(strLenh, Program.conn);
            // cac dong lenh truy van la text nen chon kieu command la text
            sqlcmd.CommandType = CommandType.Text;
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            try
            {
                myReader = sqlcmd.ExecuteReader();
                return myReader;
            }
            catch (SqlException ex)
            {
                Program.conn.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public static DataTable ExecSqlDataTable(String cmd)
        {
            DataTable dt = new DataTable();
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, Program.conn);
            da.Fill(dt);
            Program.conn.Close();
            return dt;
        }

        public static int ExecSqlNonQuery(String cmd)
        {
            SqlCommand sqlcmd = new SqlCommand(cmd, Program.conn);
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.CommandTimeout = 600; // 600s
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            try
            {
                sqlcmd.ExecuteNonQuery();
                Program.conn.Close();
                return 0;
            }
            catch (SqlException ex)
            {
                Program.conn.Close();
                return ex.State; // chuoi bao loi raiserror từ sql 
            }
        }
        public static void SetEnableOfButton(Form frm, Boolean Active)
        {

            foreach (Control ctl in frm.Controls)
                if ((ctl) is Button)
                    ctl.Enabled = Active;
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmDN = new frmDangNhap();
            //dev row
            connstr = "Data Source=PDM;Initial Catalog=TTCS_MUAHEXANH;Persist Security Info=True;User ID=sa;Password=1";
            conn = new SqlConnection(connstr);
            Application.Run(new FrmTaoChienDich());
        }
    }
}
