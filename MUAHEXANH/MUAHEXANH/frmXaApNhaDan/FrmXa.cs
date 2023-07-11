using MUAHEXANH.App;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MUAHEXANH.FormXaAp
{
    public partial class FrmXa : Form
    {
        private BindingSource bdsDiaBan;
        private BindingSource bdsXa;
        private DataTable dtDiaBan;
        private DataTable dtXa;

        private void loadDataDiaBan()
        {
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();

            dtDiaBan = new DataTable();
            bdsDiaBan = new BindingSource();

            string query = $"select * from DiaBan";
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, Program.conn))
            {
                adapter.Fill(dtDiaBan);
            }

            bdsDiaBan.DataSource = dtDiaBan;
        }

        private void loadDataXaCuaDiaBan() {

            if (bdsDiaBan == null || bdsDiaBan.Count <= 0)
            {
                return;
            }

            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();

            dtXa = new DataTable();
            bdsXa = new BindingSource();

            string maDiaBan = cmbDiaBan.SelectedValue.ToString();

            string query = $"select MaXa as N'Mã xã', TenXa as N'Tên xã' from Xa where MaDiaBan = N'{maDiaBan}'";
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, Program.conn))
            {
                adapter.Fill(dtXa);
            }

            bdsXa.DataSource = dtXa;
            gcXa.DataSource = bdsXa;
        }

        private bool truocKhiThem()
        {
            if (bdsDiaBan == null || bdsDiaBan.Count <= 0)
            {
                return false;
            }
            return true;
        }
        private void sauKhiThem()
        {
            if (bdsXa == null || bdsXa.Count <=0)
            {
                loadDataXaCuaDiaBan();
                if(bdsXa != null && bdsXa.Count > 0)
                {
                    bdsXa.Position = bdsXa.Count - 1;
                }
                return;
            }

            int index = bdsXa.Position;
            int bdsXaCount = bdsXa.Count;
            loadDataXaCuaDiaBan();
            if(bdsXaCount == bdsXa.Count)
            {
                bdsXa.Position = index;
            }
            else
            {
                bdsXa.Position = bdsXa.Count - 1;
            }
        }
        private bool truocKhiSua()
        {
            if (bdsXa == null || bdsXa.Current == null)
            {
                return false;
            }
            return true;
        }
        private void sauKhiSua()
        {
            if(bdsXa == null || bdsXa.Current == null)
            {
                loadDataXaCuaDiaBan();
                return;
            }
            int index = bdsXa.Position;
            loadDataXaCuaDiaBan();
            bdsXa.Position = index;
        }
        private bool truocKhiXoa()
        {
            if(bdsXa == null || bdsXa.Count <= 0)
            {
                Alert.ErrorMessageBox("Có gì nữa đâu mà xóa");
                return false;
            }

            DialogResult result = Alert.QuestionMessageBox("Xóa xã");
            if (result != DialogResult.Yes)
            {
                return false;
            }

            return true;
        }
        private void sauKhiXoa()
        {
            int index = bdsXa.Position;
            loadDataXaCuaDiaBan();
            if(bdsXa == null || bdsXa.Count <= 0)
            {
                return;
            }
            if(bdsXa.Count <= index)
            {
                bdsXa.Position = bdsXa.Count - 1;
            }
            else
            {
                bdsXa.Position = index;
            }
        }
        private bool xoa()
        {
            
            try
            {
                if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
                string query = $"delete from Xa where MaXa = @MaXa";

                using (SqlCommand command = new SqlCommand(query, Program.conn))
                {
                    DataRowView drv = (DataRowView)bdsXa.Current;
                    string maXa = (string)drv["Mã xã"];

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
        private void initComboBoxDiaBan()
        {
            if(bdsDiaBan == null || bdsDiaBan.Count <= 0)
            {
                return;
            }
    
            cmbDiaBan.DataSource = bdsDiaBan;
            cmbDiaBan.DisplayMember = "TenDiaBan";
            cmbDiaBan.ValueMember = "MaDiaBan";

            if (bdsDiaBan.Count > 0)
            {
                cmbDiaBan.SelectedIndex = bdsDiaBan.Count - 1;
                cmbDiaBan.SelectedIndex = 0;
            }
        }
        
        public FrmXa()
        {
            InitializeComponent();
        }

        private void FrmXa_Load(object sender, EventArgs e)
        {
            loadDataDiaBan();
            initComboBoxDiaBan();
        }

        private void cmbDiaBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadDataXaCuaDiaBan();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //Nếu không có địa bàn thì không được thêm
            if (!truocKhiThem())
                return;
            string maDiaBan = cmbDiaBan.SelectedValue.ToString().Trim();
            string tenDiaBan = cmbDiaBan.Text.ToString().Trim();
            Form f = new FrmNhapLieuXa(0, new object[] {maDiaBan, tenDiaBan});
            f.Text = "Thêm xã";
            f.ShowDialog(this);
            //Chỉnh sửa position trong bds
            sauKhiThem();
        }

        private void btnHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //Nếu không có địa bàn thì không được thêm
            if (!truocKhiSua())
                return;

            DataRowView drv = (DataRowView)bdsXa.Current;
            string maDiaBan = cmbDiaBan.SelectedValue.ToString().Trim();
            string tenDiaBan = cmbDiaBan.Text.ToString().Trim();
            string maXa = (string)drv["Mã xã"];
            string tenXa = (string)drv["Tên xã"];


            Form f = new FrmNhapLieuXa(1, new object[] { maDiaBan, tenDiaBan, maXa, tenXa });
            f.Text = "Sửa thông tin xã";
            f.ShowDialog(this);
            //Chỉnh sửa position trong bds
            sauKhiSua();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(!truocKhiXoa())
                return;

            if (xoa())
            {
                sauKhiXoa();
            }
            else
            {
                Alert.ErrorMessageBox("Không thể xóa xã được tham chiếu bởi một bảng khác.");
            }
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmXa_Load(null, null);
        }
    }
}
