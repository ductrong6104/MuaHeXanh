using DevExpress.Xpo.DB.Helpers;
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

namespace MUAHEXANH
{
    public partial class FrmChienDich : Form
    {
        private BindingSource bdsChienDich = new BindingSource();
        private BindingSource bdsDiaBanConLai = new BindingSource();
        private BindingSource bdsDiaBanTrongChienDich = new BindingSource();

        private DataTable dtChienDich;
        private DataTable dtDiaBanChuaCo;
        private DataTable dtDiaBanDaCo;
        string[] names = { "Mã", "Địa bàn" };
        
        private void loadDataChienDich()
        {
            dtChienDich = Program.ExecSqlDataTable("select * from ChienDich");
            bdsChienDich.DataSource = dtChienDich;
            gcChienDich.DataSource = bdsChienDich;
        }

        private void loadDataDiaBanChienDich()
        {
            if (bdsChienDich.Current == null)
                return;
            DataRowView drv = (DataRowView)bdsChienDich.Current;
            string _maChienDich = drv["MaChienDich"].ToString();

            string query = $"SELECT * FROM DiaBan  WHERE MaDiaBan IN (SELECT MaDiaBan FROM ChiTietChienDich WHERE MaChienDich = N'{_maChienDich}')";
            dtDiaBanDaCo = Program.ExecSqlDataTable(query);
            bdsDiaBanTrongChienDich.DataSource= dtDiaBanDaCo;
            gcDiaBanChienDich.DataSource = bdsDiaBanTrongChienDich;

            string query2 = $"SELECT * FROM DiaBan  WHERE MaDiaBan NOT IN (SELECT MaDiaBan FROM ChiTietChienDich WHERE MaChienDich = N'{_maChienDich}')";
            dtDiaBanChuaCo = Program.ExecSqlDataTable(query2);
            bdsDiaBanConLai.DataSource = dtDiaBanChuaCo;
            gcDiaBanChuaCo.DataSource = bdsDiaBanConLai;
        }

        private void sauKhiThem()
        {
            try
            {
                int _c = bdsChienDich.Count;
                int _i = bdsChienDich.Position;
                loadDataChienDich();
                if (_c == bdsChienDich.Count)
                {
                    bdsChienDich.Position = _i;
                }
                else
                {
                    bdsChienDich.Position = bdsChienDich.Count - 1;
                }
            }
            catch (Exception ex)
            {

            }
        }
       
        private void sauKhiSua()
        {
            int _i = bdsChienDich.Position;
            loadDataChienDich();
            if(bdsChienDich.Count > 0)
            {
                bdsChienDich.Position = _i;
            }
        }
         public FrmChienDich()
        {
            InitializeComponent();
        }

        private void FrmTaoChienDich_Load(object sender, EventArgs e)
        {
            loadDataChienDich();
            loadDataDiaBanChienDich();
        }

        private void gvChienDich_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            loadDataDiaBanChienDich();
        }

        private void gvDiaBanChuaCo_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            btnThemDiaBan.Enabled = true;
            btnXoaDiaBan.Enabled = false;
        }

        private void gvDiaBanChienDich_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            btnXoaDiaBan.Enabled =true;
            btnThemDiaBan.Enabled = false;
        }

        private void btnThemDiaBan_Click(object sender, EventArgs e)
        {
            if(bdsChienDich.Current == null)
            {
                return;
            }
            if (bdsDiaBanConLai.Current == null) { Alert.ErrorMessageBox("Còn gì nữa đâu mà thêm"); return; }
            DataRowView dr = (DataRowView)bdsDiaBanConLai.Current;
            string maDiaBan = dr["MaDiaBan"].ToString();
            DataRowView dr1 = (DataRowView)bdsChienDich.Current;
            string maChienDich = dr1["MaChienDich"].ToString();
            int index = bdsDiaBanConLai.Position;
            bool success = false;

            if(Program.conn.State == ConnectionState.Closed)
            {
                Program.conn.Open();
            }

            string query = "INSERT INTO ChiTietChienDich (MaDiaBan, MaChienDich) VALUES (@MaDiaBan, @MaChienDich)";

            using (SqlCommand command = new SqlCommand(query, Program.conn))
            {
                command.Parameters.AddWithValue("@MaDiaBan", maDiaBan); 
                command.Parameters.AddWithValue("@MaChienDich", maChienDich); 

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    success = true;
                }
            }


            if (success)
            {
                loadDataDiaBanChienDich();
                if(bdsDiaBanConLai.Count > index)
                {
                    bdsDiaBanConLai.Position = index;
                }
                else
                {
                    bdsDiaBanConLai.Position = bdsDiaBanConLai.Count - 1;
                }
            }
        }
        private void btnXoaDiaBan_Click(object sender, EventArgs e)
        {

            if (bdsChienDich.Current == null)
            {
                return;
            }
            if (bdsDiaBanTrongChienDich.Current == null) { Alert.ErrorMessageBox("Còn gì nữa đâu mà xóa"); return; }
            DataRowView dr = (DataRowView)bdsDiaBanTrongChienDich.Current;
            string maDiaBan = dr["MaDiaBan"].ToString();
            DataRowView dr1 = (DataRowView)bdsChienDich.Current;
            string maChienDich = dr1["MaChienDich"].ToString();
            int index = bdsDiaBanTrongChienDich.Position;
            bool success = false;

            if (Program.conn.State == ConnectionState.Closed)
            {
                Program.conn.Open();
            }

            string query = "DELETE FROM ChiTietChienDich WHERE MaDiaBan = @MaDiaBan AND MaChienDich = @MaChienDich";

            using (SqlCommand command = new SqlCommand(query, Program.conn))
            {
                command.Parameters.AddWithValue("@MaDiaBan", maDiaBan);
                command.Parameters.AddWithValue("@MaChienDich", maChienDich);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    success = true;
                }
            }


            if (success)
            {
                loadDataDiaBanChienDich();
                if (bdsDiaBanTrongChienDich.Count > index)
                {
                    bdsDiaBanTrongChienDich.Position = index;
                }
                else
                {
                    bdsDiaBanTrongChienDich.Position = bdsDiaBanConLai.Count - 1;
                }
            }

        }
        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmTaoChienDich_Load(null,null);
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DateTime minNgayBatDau;
            if (bdsChienDich.Current == null)
                minNgayBatDau = DateTime.Now;
            else
                minNgayBatDau = dtChienDich.AsEnumerable()
                                     .Max(row => row.Field<DateTime>("NgayKetThuc"));

            int state = 0;
            string maChienDich = "";
            string tenChienDich = "";
            DateTime ngayPhatDong = DateTime.Now;
            DateTime ngayKetThuc = DateTime.Now;

            object[] args = new object[] { maChienDich, tenChienDich, ngayPhatDong, ngayKetThuc, minNgayBatDau};

            FrmNhapLieuChienDich f = new FrmNhapLieuChienDich(args, state);
            f.Text = "Thêm chiến dịch";
            f.ShowDialog(this);
            sauKhiThem();
        }

        private void btnHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsChienDich.Current == null)
            {
                return;
            }

            DataRowView drv = (DataRowView)bdsChienDich.Current;

            int state = 1;
            string maChienDich = drv["MaChienDich"].ToString();
            string tenChienDich = drv["TenChienDich"].ToString();
            DateTime ngayPhatDong = (DateTime)drv["NgayPhatDong"];
            DateTime ngayKetThuc = (DateTime)drv["NgayKetThuc"];
            DateTime minNgayBatDau = ngayPhatDong;


            object[] args = new object[] { maChienDich, tenChienDich, ngayPhatDong, ngayKetThuc, minNgayBatDau };

            FrmNhapLieuChienDich f = new FrmNhapLieuChienDich(args, state);
            f.Text = "Hiệu chỉnh chiến dịch";
            f.ShowDialog(this);
            sauKhiSua();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsChienDich.Current == null)
            {
                Alert.ErrorMessageBox("Còn gì nữa đâu mà xóa");
                return;
            }
            if (bdsDiaBanTrongChienDich.Count > 0)
            {
                Alert.ErrorMessageBox("Chiến dịch đã được phân bổ các địa bàn không thể xóa. Vui lòng xóa các địa bà được phân bổ trong chiến dịch trước");
                return;
            }

            DialogResult result = Alert.QuestionMessageBox("Xóa chiến dịch");
            if (result == DialogResult.Yes)
            {
                if (Program.conn.State == ConnectionState.Closed)
                {
                    Program.conn.Open();
                }

                DataRowView dr1 = (DataRowView)bdsChienDich.Current;
                string maChienDich = dr1["MaChienDich"].ToString();

                string query = "Delete from ChienDich where MaChienDich = @MaChienDich";

                using (SqlCommand command = new SqlCommand(query, Program.conn))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@MaChienDich", maChienDich);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            FrmTaoChienDich_Load(null, null);
                        }
                    }

                    catch (Exception ex)
                    {
                        Alert.ErrorMessageBox("Chiến dịch đã có đội");
                    }
                   
                }
            }
        }
    }
}
