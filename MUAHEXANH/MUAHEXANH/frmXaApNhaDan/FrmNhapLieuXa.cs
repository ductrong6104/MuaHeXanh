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
    public partial class FrmNhapLieuXa : Form
    {
        private int openType;
        private object[] args;
        private string maXa;
        private void initData(object[] args)
        {
            //chung
            string maDiaBan = args[0].ToString();
            string tenDiaBan = args[1].ToString();
            txtMaDiaBan.Text = maDiaBan;
            txtTenDiaBan.Text = tenDiaBan;

            //Mở form để hiệu chỉnh
            if (openType != 0)
            {
                string maXa = args[2].ToString();
                string tenXa = args[3].ToString();
                txtTenXa.Text = tenXa;
                this.maXa = maXa;
            }
        }

        private void luu()
        {
            if(this.openType == 0)
            {
                if (!this.themXa())
                {
                    Alert.ErrorMessageBox("Xảy ra lỗi trong quá trình thêm.");
                    return;
                }
            }
            else
            {

                if (!this.suaXa())
                {
                    Alert.ErrorMessageBox("Xảy ra lỗi trong quá trình sửa.");
                    return;
                }
            }
            this.Close();
        }
        private bool themXa()
        {
            try
            {
                if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
                string query = $"insert into Xa(TenXa, MaDiaBan) Values(@TenXa, @MaDiaBan)";

                using (SqlCommand command = new SqlCommand(query, Program.conn))
                {
                    string tenXa = txtTenXa.Text;
                    string maDiaBan = txtMaDiaBan.Text.Trim();


                    command.Parameters.AddWithValue("@TenXa", tenXa);
                    command.Parameters.AddWithValue("@MaDiaBan", maDiaBan);

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
        private bool suaXa()
        {
            try
            {
                if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
                string query = $"update Xa set TenXa=@TenXa, MaDiaBan = @MaDiaBan where MaXa = @MaXa";

                using (SqlCommand command = new SqlCommand(query, Program.conn))
                {
                    string tenXa = txtTenXa.Text;
                    string maDiaBan = txtMaDiaBan.Text.Trim();


                    command.Parameters.AddWithValue("@TenXa", tenXa);
                    command.Parameters.AddWithValue("@MaDiaBan", maDiaBan);
                    command.Parameters.AddWithValue("@MaXa", this.maXa);


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
        
        public FrmNhapLieuXa(int openType, object[] args)
        {
            InitializeComponent();
            this.openType = openType;
            this.args = args;
        }

        private void FrmNhapLieuXa_Load(object sender, EventArgs e)
        {
            initData(this.args);
        }

        private void FrmNhapLieuXa_Shown(object sender, EventArgs e)
        {
            txtTenXa.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            luu();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
