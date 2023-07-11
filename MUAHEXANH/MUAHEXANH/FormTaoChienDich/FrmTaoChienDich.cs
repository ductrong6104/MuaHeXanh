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
        private BindingSource bdsDiaBanConLai = new BindingSource();
        private BindingSource bdsDiaBanTrongChienDich = new BindingSource();

        private DataTable dt1;
        private DataTable dt2;
        string[] names = { "Mã", "Địa bàn" };
        private void loadData()
        {
            if (bdsChienDich.Current == null)
                return;

            DataRowView drv = ((DataRowView)(bdsChienDich.Current));
            string maChienDich = drv["MaChienDich"].ToString().Trim();
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            
            //Tải dữ liệu cho grid view địa bàn chưa có trong chiến dịch
            string sql1 = $"Exec Sp_DanhSachDiaBanChuaCoTrongChienDich '{maChienDich}'";
            this.dt1 = Program.ExecSqlDataTable(sql1);
            for (int i = 0; i < dt1.Columns.Count; i++)
            {
                dt1.Columns[i].ColumnName = names[i];
            }
            gcDiaBanChuaCo.DataSource = dt1;
            
            //Tải dữ liệu cho grid view địa bản trong chiến dịch
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            string sql2 = $"Exec Sp_DanhSachDiaBanCuaChienDich '{maChienDich}'";
            this.dt2 = Program.ExecSqlDataTable(sql2);
            for (int i = 0; i < dt2.Columns.Count; i++)
            {
                dt2.Columns[i].ColumnName = names[i];
            }
            bdsDiaBanConLai.DataSource = dt1;
            bdsDiaBanTrongChienDich.DataSource = dt2;

            gcDiaBanChuaCo.DataSource = bdsDiaBanConLai;
            gcDiaBanChienDich.DataSource = bdsDiaBanTrongChienDich;

            gvDiaBanChuaCo.Columns[0].Width = 100;
            gvDiaBanChienDich.Columns[0].Width = 100;

        }
        public FrmChienDich()
        {
            InitializeComponent();
        }

        private void FrmTaoChienDich_Load(object sender, EventArgs e)
        {
            this.chienDichTableAdapter.Connection.ConnectionString = Program.connstr;
            this.dSTaoChienDich.EnforceConstraints = false;
            this.chienDichTableAdapter.Fill(this.dSTaoChienDich.ChienDich);
            gvChienDich.Columns[0].Width = 100;
            loadData();

        }

        private void gvChienDich_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            loadData();
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
            if (bdsDiaBanConLai.Current == null) {Alert.ErrorMessageBox("Còn gì nữa đâu mà thêm"); return; }
            DataRowView dr = (DataRowView)bdsDiaBanConLai.Current;
            string maDiaBan = dr["Mã"].ToString();
            DataRowView dr1 = (DataRowView)bdsChienDich.Current;
            string maChienDich = dr1["MaChienDich"].ToString();
            int index = bdsDiaBanConLai.Position;

            bool success = false;

            try
            {
                string sql = $"DECLARE\t@return_value int\r\n\r\nEXEC\t@return_value = [dbo].[Sp_ThemChiTietChienDich]\r\n\t\t@MaChienDich = '{maChienDich}',\r\n\t\t@MaDiaBan = '{maDiaBan}'\r\n\r\nSELECT\t'Value' = @return_value";
                SqlCommand sqlCommand = new SqlCommand(sql, Program.conn);
                SqlDataReader dataReader = Program.ExecSqlDataReader(sql);
                if (dataReader == null)
                {
                    Alert.ErrorMessageBox("Lỗi");
                    return;
                }
                if (dataReader.Read())
                {
                    int stt = int.Parse(dataReader.GetValue(0).ToString());
                    if (stt != 0)
                    {
                        Alert.InfoMessageBox("Lỗi");
                    }
                    else
                    {
                        success = true;
                    }
                }
                dataReader.Close();
            }
            catch (Exception ex)
            {
                Alert.ErrorMessageBox($"Lỗi: {ex.StackTrace}");
                Program.conn.Close();
            }


            if (success)
                loadData();
        }
        private void btnXoaDiaBan_Click(object sender, EventArgs e)
        {
            if(bdsDiaBanTrongChienDich.Current == null) { Alert.ErrorMessageBox("Còn gì nữa đâu mà xóa"); return; }
            DataRowView dr = (DataRowView)bdsDiaBanTrongChienDich.Current;
            string maDiaBan = dr["Mã"].ToString();
            DataRowView dr1 = (DataRowView)bdsChienDich.Current;
            string maChienDich = dr1["MaChienDich"].ToString();
            int index = bdsDiaBanTrongChienDich.Position;

            bool success = false;

            try
            {
                string sql = $"DECLARE\t@return_value int\r\n\r\nEXEC\t@return_value = [dbo].[Sp_XoaChiTietChienDich]\r\n\t\t@MaChienDich = '{maChienDich}',\r\n\t\t@MaDiaBan = '{maDiaBan}'\r\n\r\nSELECT\t'Value' = @return_value";
                SqlCommand sqlCommand = new SqlCommand(sql, Program.conn);
                SqlDataReader dataReader = Program.ExecSqlDataReader(sql);
                if (dataReader == null)
                {
                    Alert.ErrorMessageBox("Lỗi");
                    return;
                }
                if (dataReader.Read())
                {
                    int stt = int.Parse(dataReader.GetValue(0).ToString());
                    if (stt != 0)
                    {
                        Alert.InfoMessageBox("Lỗi");
                    }
                    else
                    {
                        success = true;
                    }
                }
                dataReader.Close();
            }
            catch (Exception ex)
            {
                Alert.ErrorMessageBox($"Lỗi: {ex.StackTrace}");
                Program.conn.Close();

            }

            if (success)
                loadData();

        }
        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmTaoChienDich_Load(null,null);
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsChienDich.AddNew();
            FrmNhapLieuChienDich f = new FrmNhapLieuChienDich(bdsChienDich, chienDichTableAdapter, dSTaoChienDich, 0);
            f.ShowDialog();
        }

        private void btnHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmNhapLieuChienDich f = new FrmNhapLieuChienDich(bdsChienDich, chienDichTableAdapter, dSTaoChienDich, 1);
            f.ShowDialog();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(bdsChienDich.Count <= 0)
            {
                Alert.ErrorMessageBox("Còn gì nữa đâu mà xóa");
                return;
            }
            if(bdsDiaBanTrongChienDich.Count > 0)
            {
                Alert.ErrorMessageBox("Chiến dịch đã được phân bổ các địa bàn không thể xóa. Vui lòng xóa các địa bà được phân bổ trong chiến dịch trước");
                return;
            }

            DialogResult result = Alert.QuestionMessageBox("Xóa chiến dịch");
            if (result == DialogResult.Yes)
            {
                int index = bdsChienDich.Position - 1;
                bdsChienDich.RemoveCurrent();
                bdsChienDich.EndEdit();
                chienDichTableAdapter.Update(this.dSTaoChienDich.ChienDich);
                if (index > -1)
                    bdsChienDich.Position = index;
            }
        }
    }
}
