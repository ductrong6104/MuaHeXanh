using DevExpress.XtraPrinting.Native;
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

namespace MUAHEXANH
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
        }

        private void frmDangNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnQuenMK_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            if (txtLogin.Text.Trim() == "" || txtPass.Text.Trim() == "")
            {
                MessageBox.Show("Login name và mật mã không để trống", "", MessageBoxButtons.OK);
                return;
            }
            Program.servername = "DESKTOP-9QNDCS8\\DUCTRONG";
            Program.mlogin = txtLogin.Text;
            Program.password = txtPass.Text;
            // ket noi toi sv phan manh// lay duoc Program.connstr
            if (Program.KetNoi() == 0) return;

            // lay 3 thong tin nay dua vao bien toan cuc trong program 
            Program.mloginDN = Program.mlogin;
            Program.passwordDN = Program.password;

            string strLenh = "";
            if (radGiangVien.Checked)
            {
                strLenh = "EXEC sp_lay_thong_tin_gv_tu_login '" + Program.mlogin + "'";
            }
            else if (radSinhVien.Checked)
            {
                strLenh = "EXEC sp_lay_thong_tin_sv_tu_login '" + Program.mlogin + "'";
            }


            // viet chuong trinh tra ve du lieu tu viec goi sp
            using(Program.myReader = Program.ExecSqlDataReader(strLenh)){
                if (Program.myReader == null) return; // khong tim thay du lieu cua sinh vien dang nhap
                Program.myReader.Read();    // doc 1 dong trong datareader, neu nhieu dong thi viet vong lap

                Program.username = Program.myReader.GetString(0); // cot dau tien la username
                if (Convert.IsDBNull(Program.username))
                {
                    MessageBox.Show("Login bạn nhập không có quyền truy cập dữ liệu\n Bạn xem lại username, password", "", MessageBoxButtons.OK);
                }
                Program.mHoten = Program.myReader.GetString(1);
                Program.mGroup = Program.myReader.GetString(2);
                // dong datareader va connect db
                Program.myReader.Close();
                Program.conn.Close();
            }
            

            
            if (Program.mGroup == "GIAMSAT" || Program.mGroup == "DOITRUONG" || Program.mGroup == "DOIPHO")
            {
                using (SqlDataReader layMaDoi = Program.ExecSqlDataReader("SELECT MADOI FROM DOI WHERE " +
                    "GIAMSAT1 = '" + Program.username
                    + "' OR GIAMSAT2='" + Program.username
                    + "' OR DOITRUONG='" + Program.username
                    + "' OR DOIPHO='" + Program.username + "'"))
                {
                    layMaDoi.Read();
                    Program.mTeam = layMaDoi.GetString(0);
                }
            }
            else if (Program.mGroup == "NHOMTRUONG")
            {
                using (SqlDataReader layMaNhom = Program.ExecSqlDataReader("SELECT MANHOM FROM NHOM WHERE " +
                    "NHOMTRUONG = '" + Program.username+ "'"))
                {
                    layMaNhom.Read();
                    Program.mNhom = layMaNhom.GetString(0);
                }
            }

            Program.frmChinh = new frmMain();
            Program.frmChinh.Show();

            // Hien thi thong tin sinh  vien
            Program.frmChinh.MA.Text = "Mã SV = " + Program.username;
            Program.frmChinh.HOTEN.Text = "Họ Tên = " + Program.mHoten;
            Program.frmChinh.NHOM.Text = "Nhóm = " + Program.mGroup;
            Program.frmChinh.TENSV.Text = "Ten sv: " + Program.servername;
            Program.frmDN.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtLogin.Text = "";
            txtPass.Text = "";
        }
    }
}
