using MUAHEXANH.App;
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

namespace MUAHEXANH.FormXaAp
{
    public partial class FrmNhapLieuAp : Form
    {
        private int openType;
        private object[] args;
        private string maAp;
        private void initData(object[] args)
        {
            //chung
            string maDiaBan = args[0].ToString();
            string tenDiaBan = args[1].ToString();
            string maXa = args[2].ToString();
            string tenXa = args[3].ToString();

            txtMaDiaBan.Text = maDiaBan;
            txtTenDiaBan.Text = tenDiaBan;
            txtMaXa.Text = maXa;
            txtTenXa.Text = tenXa;

            //Mở form để hiệu chỉnh
            if (openType != 0)
            {
                string maAp = args[4].ToString();
                string tenAp = args[5].ToString();

                txtTenAp.Text = tenAp;
                this.maAp = maAp;
            }
        }

        private void luu()
        {
            if (this.openType == 0)
            {
                if (!this.themAp())
                {
                    Alert.ErrorMessageBox("Xảy ra lỗi trong quá trình thêm.");
                    return;
                }
            }
            else
            {

                if (!this.suaAp())
                {
                    Alert.ErrorMessageBox("Xảy ra lỗi trong quá trình sửa.");
                    return;
                }
            }
            this.Close();
        }
        private bool themAp()
        {
            try
            {
                if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
                string query = $"insert into Ap(TenAp, MaXa) Values(@TenAp, @MaXa)";

                using (SqlCommand command = new SqlCommand(query, Program.conn))
                {
                    string tenAp = txtTenAp.Text;
                    string maXa = txtMaXa.Text.Trim();


                    command.Parameters.AddWithValue("@TenAp", tenAp);
                    command.Parameters.AddWithValue("@MaXa", maXa);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        private bool suaAp()
        {
            try
            {
                if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
                string query = $"update Ap set TenAp=@TenAp where MaAp = @MaAp";

                using (SqlCommand command = new SqlCommand(query, Program.conn))
                {
                    string tenAp = txtTenAp.Text;


                    command.Parameters.AddWithValue("@TenAp", tenAp);
                    command.Parameters.AddWithValue("@MaAp", this.maAp);


                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public FrmNhapLieuAp(int openType, object[] args)
        {
            InitializeComponent();
            this.openType = openType;
            this.args = args;
        }

        private void FrmNhapLieuAp_Load(object sender, EventArgs e)
        {
            initData(this.args);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            luu();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmNhapLieuAp_Shown(object sender, EventArgs e)
        {
            txtTenAp.Focus();
        }
    }
}
