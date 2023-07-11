using DevExpress.Xpo.DB.Helpers;
using MUAHEXANH.App;
using MUAHEXANH.DSTaoCongViecTableAdapters;
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

namespace MUAHEXANH.FrmChon
{
    public partial class FrmNhapLieuCongViec : Form
    {
        int openType;
        string maCongViec;
        DateTime startDate;
        DateTime endDate;
        public FrmNhapLieuCongViec(int openType, string maAp, string tenAp, string maCongViec, string tenCongViec, DateTime startDate, DateTime endDate)
        {
            InitializeComponent();
            this.openType = openType;
            txtMaAp.Text = maAp;
            txtTenAp.Text = tenAp;
            this.maCongViec = maCongViec;
            txtTenCongViec.Text = tenCongViec;
            this.startDate = startDate;
            this.endDate = endDate;
        }

        private void frmNhapLieuThemCongViec_Load(object sender, EventArgs e)
        {

        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(txtTenCongViec.Text?.Trim() == "")
            {
                Alert.ErrorMessageBox("Tên công việc không được để trống");
                return;
            }

            if (openType == 0)
            {
                //Open type = 0 là thêm
                if (!themCongViec())
                {
                    Alert.ErrorMessageBox("Lỗi");
                }
                else
                {
                    this.Close();
                }
            }
            else
            {
                //Open type != 0 là sửa
                if (!suaCongViec())
                {
                    Alert.ErrorMessageBox("Lỗi");
                }
                else
                {
                    this.Close();
                }
            }
        }

        private bool themCongViec()
        {
            try
            {
                if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
                string query = $"insert into CongViec(TenCV, NgayBatDau, NgayKetThuc, MaAp) Values(@TenCV, @NgayBatDau, @NgayKetThuc, @MaAp)";

                using (SqlCommand command = new SqlCommand(query, Program.conn))
                {
                    string tenCV = txtTenCongViec.Text.Trim();
                    DateTime ngayBatDau = dtpNgayBatDau.DateTime;
                    DateTime ngayKetThuc = dtpNgayKetThuc.DateTime;
                    string maAp = txtMaAp.Text.Trim();


                    command.Parameters.AddWithValue("@TenCV", tenCV);
                    command.Parameters.AddWithValue("@NgayBatDau", ngayBatDau);
                    command.Parameters.AddWithValue("@NgayKetThuc", ngayKetThuc);
                    command.Parameters.AddWithValue("@MaAp", maAp);


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
        private bool suaCongViec()
        {
            try
            {
                if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
                string query = $"UPDATE CongViec SET TenCV = @TenCV, NgayBatDau = @NgayBatDau, NgayKetThuc = @NgayKetThuc, MaAp = @MaAp WHERE MaCV = @MaCV";

                using (SqlCommand command = new SqlCommand(query, Program.conn))
                {
                    string tenCV = txtTenCongViec.Text.Trim();
                    DateTime ngayBatDau = dtpNgayBatDau.DateTime;
                    DateTime ngayKetThuc = dtpNgayKetThuc.DateTime;
                    string maAp = txtMaAp.Text.Trim();


                    command.Parameters.AddWithValue("@TenCV", tenCV);
                    command.Parameters.AddWithValue("@NgayBatDau", ngayBatDau);
                    command.Parameters.AddWithValue("@NgayKetThuc", ngayKetThuc);
                    command.Parameters.AddWithValue("@MaAp", maAp);
                    command.Parameters.AddWithValue("@MaCV", this.maCongViec);


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

        private void FrmNhapLieuCongViec_Shown(object sender, EventArgs e)
        {
            if (this.startDate == null)
            {
                dtpNgayBatDau.EditValue = DateTime.Now;

            }
            else
            {
                dtpNgayKetThuc.EditValue = this.endDate;
                dtpNgayBatDau.EditValue = this.startDate;

            }
        }

        private void dtpNgayBatDau_EditValueChanged(object sender, EventArgs e)
        {
            if(dtpNgayKetThuc.DateTime <= dtpNgayBatDau.DateTime)
                dtpNgayKetThuc.Properties.MinValue = dtpNgayBatDau.DateTime.AddDays(1);
        }
    }
}
