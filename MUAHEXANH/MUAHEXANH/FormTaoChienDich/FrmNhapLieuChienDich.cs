using DevExpress.ClipboardSource.SpreadsheetML;
using DevExpress.Utils.Gesture;
using DevExpress.XtraCharts.Designer.Native;
using MUAHEXANH.App;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MUAHEXANH
{
    public partial class FrmNhapLieuChienDich : Form
    {
        private int state;
        string maChienDich;
        string tenChienDich;
        DateTime ngayBatDau, ngayKetThuc, minNgayBatDau;

        private void initData(object[] args)
        {
            try
            {
                this.maChienDich = args[0].ToString();
                this.tenChienDich = args[1].ToString();
                this.ngayBatDau = (DateTime)args[2];
                this.ngayKetThuc = (DateTime)args[3];
                this.minNgayBatDau = (DateTime)args[4];
            }
            catch (Exception ex)
            {

            }

        }

        private void loadData() {
            if (state == 0)
            {
                txtTenChienDich.Focus();
                dtpNgayPhatDong.Properties.MinValue = this.minNgayBatDau;
                dtpNgayPhatDong.DateTime = this.minNgayBatDau;
                DateTime tmp = this.minNgayBatDau.AddDays(1);
                dtpNgayKetThuc.Properties.MinValue = tmp;
                dtpNgayKetThuc.DateTime = tmp;
            }
            else
            {
                txtTenChienDich.Text = this.tenChienDich;
                dtpNgayPhatDong.Properties.MinValue = this.ngayBatDau;
                dtpNgayPhatDong.DateTime = this.ngayBatDau;
                dtpNgayKetThuc.Properties.MinValue = this.ngayBatDau.AddDays(1);
                dtpNgayKetThuc.DateTime = this.ngayKetThuc;
            }
        }
        private bool checkData()
        {
            string tenChienDich = txtTenChienDich.Text.Trim();
            if (tenChienDich == "" || dtpNgayPhatDong.DateTime == null || dtpNgayKetThuc.DateTime == null)
                return false;
            return true;
        }
        private bool luuDuLieu()
        {
            if (Program.conn.State == ConnectionState.Closed)
            {
                Program.conn.Open();
            }

            string tenChienDich = txtTenChienDich.Text.Trim();
            DateTime ngayPhatDong = dtpNgayPhatDong.DateTime;
            DateTime ngayKetThuc = dtpNgayKetThuc.DateTime;


            if (this.state == 0)
            {
                string query = "INSERT INTO ChienDich (TenChienDich, NgayPhatDong, NgayKetThuc) VALUES ( @TenChienDich, @NgayPhatDong, @NgayKetThuc)";
                using (SqlCommand command = new SqlCommand(query, Program.conn))
                {
                    command.Parameters.AddWithValue("@TenChienDich", tenChienDich);
                    command.Parameters.AddWithValue("@NgayPhatDong", ngayPhatDong);
                    command.Parameters.AddWithValue("@NgayKetThuc", ngayKetThuc);


                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        return true;
                    }
                }
            }
            else
            {
                string query = "Update ChienDich Set TenChienDich = @TenChienDich, NgayPhatDong = @NgayPhatDong, NgayKetThuc = @NgayKetThuc Where MaChienDich = @MaChienDich";
                using (SqlCommand command = new SqlCommand(query, Program.conn))
                {
                    command.Parameters.AddWithValue("@MaChienDich", this.maChienDich);
                    command.Parameters.AddWithValue("@TenChienDich", tenChienDich);
                    command.Parameters.AddWithValue("@NgayPhatDong", ngayPhatDong);
                    command.Parameters.AddWithValue("@NgayKetThuc", ngayKetThuc);


                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        return true;
                    }
                }

            }

            
            return false;
        }
        public FrmNhapLieuChienDich(object[] args, int state)
        {
            InitializeComponent();
            initData(args);
            this.state = state;
        }


        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!checkData())
            {
                Alert.ErrorMessageBox("Vui lòng nhập đầy đủ thông tin");
                return;
            }

            luuDuLieu();

            this.Close();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmNhapLieuChienDich_Shown(object sender, EventArgs e)
        {
            loadData();
        }

        private void FrmNhapLieuChienDich_Load(object sender, EventArgs e)
        {
            //loadData();
        }

        private void dtpNgayPhatDong_EditValueChanged(object sender, EventArgs e)
        {
            dtpNgayKetThuc.Properties.MinValue = dtpNgayPhatDong.DateTime.AddDays(1);
        }

    }
}
