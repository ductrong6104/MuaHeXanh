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
    public partial class FrmAp : Form
    {
        private BindingSource bdsDiaBan;
        private BindingSource bdsXa;
        private BindingSource bdsAp;

        private DataTable dtDiaBan;
        private DataTable dtXa;
        private DataTable dtAp;


        private void loadDataDiaBan()
        {
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();

            dtDiaBan = new DataTable();
            bdsDiaBan = new BindingSource();

            string query = $"select * from DiaBan where MaDiaBan in (select MaDiaBan from Xa)";
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, Program.conn))
            {
                adapter.Fill(dtDiaBan);
            }

            bdsDiaBan.DataSource = dtDiaBan;
        }
        private void loadDataXaCuaDiaBan()
        {

            if (bdsDiaBan == null || bdsDiaBan.Count <= 0)
            {
                return;
            }

            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();

            dtXa = new DataTable();
            bdsXa = new BindingSource();

            string maDiaBan = cmbDiaBan.SelectedValue.ToString();

            string query = $"select MaXa , TenXa  from Xa where MaDiaBan = N'{maDiaBan}'";

            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, Program.conn))
            {
                adapter.Fill(dtXa);
            }

            bdsXa.DataSource = dtXa;
        }
        private void loadDataApCuaXa()
        {
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();

            dtAp = new DataTable();
            bdsAp = new BindingSource();

            string maXa = cmbXa?.SelectedValue?.ToString();

            string query = $"select MaAp as N'Mã ấp', TenAp as N'Tên ấp' from Ap where MaXa = N'{maXa}'";
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, Program.conn))
            {
                adapter.Fill(dtAp);
            }

            bdsAp.DataSource = dtAp;
            gcAp.DataSource = bdsAp;

        }
        private bool truocKhiThem()
        {
            if (bdsXa == null || bdsXa.Count <= 0)
            {
                return false;
            }
            return true;
        }
        private void sauKhiThem()
        {
            if (bdsAp == null || bdsAp.Count <= 0)
            {
                loadDataApCuaXa();
                if (bdsAp != null && bdsAp.Count > 0)
                {
                    bdsAp.Position = bdsAp.Count - 1;
                }
                return;
            }

            int index = bdsAp.Position;
            int bdsApCount = bdsAp.Count;
            loadDataApCuaXa();
            if (bdsApCount == bdsAp.Count)
            {
                bdsAp.Position = index;
            }
            else
            {
                bdsAp.Position = bdsAp.Count - 1;
            }
        }
        private bool truocKhiSua()
        {
            if (bdsAp == null || bdsAp.Current == null)
            {
                return false;
            }
            return true;
        }
        private void sauKhiSua()
        {
            if (bdsAp == null || bdsAp.Current == null)
            {
                loadDataApCuaXa();
                return;
            }
            int index = bdsAp.Position;
            loadDataApCuaXa();
            bdsAp.Position = index;
        }
        private bool truocKhiXoa()
        {
            if (bdsAp == null || bdsAp.Count <= 0)
            {
                Alert.ErrorMessageBox("Có gì nữa đâu mà xóa");
                return false;
            }

            DialogResult result = Alert.QuestionMessageBox("Xóa ấp");
            if (result != DialogResult.Yes)
            {
                return false;
            }

            return true;
        }
        private void sauKhiXoa()
        {
            int index = bdsAp.Position;
            loadDataApCuaXa();
            if (bdsAp == null || bdsAp.Count <= 0)
            {
                return;
            }
            if (bdsAp.Count <= index)
            {
                bdsAp.Position = bdsAp.Count - 1;
            }
            else
            {
                bdsAp.Position = index;
            }
        }
        private bool xoa()
        {

            try
            {
                if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
                string query = $"delete from Ap where MaAp = @MaAp";

                using (SqlCommand command = new SqlCommand(query, Program.conn))
                {
                    DataRowView drv = (DataRowView)bdsAp.Current;
                    string maAp = (string)drv["Mã ấp"];

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
        private void initComboBoxDiaBan()
        {
            cmbDiaBan.DataSource = bdsDiaBan;
            cmbDiaBan.DisplayMember = "TenDiaBan";
            cmbDiaBan.ValueMember = "MaDiaBan";

            if (bdsDiaBan == null)
                return;

            if (bdsDiaBan.Count > 1)
            {
                cmbDiaBan.SelectedIndex = bdsDiaBan.Count - 1;
                cmbDiaBan.SelectedIndex = 0;
            }
            else if(bdsDiaBan.Count == 1)
            {
                cmbDiaBan_SelectedIndexChanged(null, null);
            }
        }
        private void initComboBoxXa()
        {
            cmbXa.DataSource = bdsXa;
            cmbXa.DisplayMember = "TenXa";
            cmbXa.ValueMember = "MaXa";

            if (bdsXa == null)
                return;


            if (bdsXa.Count > 1)
            {
                cmbXa.SelectedIndex = bdsXa.Count - 1;
                cmbXa.SelectedIndex = 0;
            }
            else if (bdsDiaBan.Count == 1)
            {
                cmbXa_SelectedIndexChanged(null, null);
            }
        }
        public FrmAp()
        {
            InitializeComponent();
        }

        private void FrmAp_Load(object sender, EventArgs e)
        {
            loadDataDiaBan();
            initComboBoxDiaBan();
        }

        private void cmbDiaBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadDataXaCuaDiaBan();
            initComboBoxXa();
            if(bdsXa.Count <= 0)
                loadDataApCuaXa();
        }

        private void cmbXa_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadDataApCuaXa();
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmAp_Load(null,null);
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!truocKhiThem())
                return;

            string maDiaBan = cmbDiaBan.SelectedValue.ToString().Trim();
            string tenDiaBan = cmbDiaBan.Text.ToString().Trim();

            string maXa = cmbXa.SelectedValue.ToString().Trim();
            string tenXa = cmbXa.Text.ToString().Trim();

            object[] args = { maDiaBan, tenDiaBan, maXa, tenXa };

            FrmNhapLieuAp f = new FrmNhapLieuAp(0, args);
            f.Text = "Thêm ấp";
            f.ShowDialog(this);

            sauKhiThem();
        }

        private void btnHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!truocKhiSua())
                return;

            string maDiaBan = cmbDiaBan.SelectedValue.ToString().Trim();
            string tenDiaBan = cmbDiaBan.Text.ToString().Trim();

            string maXa = cmbXa.SelectedValue.ToString().Trim();
            string tenXa = cmbXa.Text.ToString().Trim();

            DataRowView drv = (DataRowView)bdsAp.Current;
            string maAp = (string)drv["Mã ấp"];
            string tenAp = (string)drv["Tên ấp"];

            object[] args = { maDiaBan, tenDiaBan, maXa, tenXa, maAp, tenAp };

            FrmNhapLieuAp f = new FrmNhapLieuAp(1, args);
            f.Text = "Sửa thông tin ấp";
            f.ShowDialog(this);

            sauKhiSua();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!truocKhiXoa())
                return;

            if (xoa())
            {
                sauKhiXoa();
            }
            else
            {
                Alert.ErrorMessageBox("Không thể xóa ấp được tham chiếu bởi một bảng khác.");
            }
        }
    }
}
