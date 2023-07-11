using DevExpress.Xpo.DB.Helpers;
using MUAHEXANH.App;
using MUAHEXANH.FrmChon;
using System;
using System.Collections;
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
    public partial class FrmCongViec : Form
    {
        private String maDoi;
        private DataTable dtAp;
        private DataTable dtCongViec;
        private DataTable dtPhanCong;

        private BindingSource bdsAp;
        private BindingSource bdsCongViec;
        private BindingSource bdsPhanCong;

        private String maXa = null;

        public FrmCongViec()
        {
            InitializeComponent();
            initMaXa();
            
        }
        private void initCombobox()
        {
            cmbChonAp.DataSource = bdsAp;
            cmbChonAp.DisplayMember = "TenAp";
            cmbChonAp.ValueMember = "MaAp";

            if (bdsAp.Count > 0)
            {
                cmbChonAp.SelectedIndex = bdsAp.Count - 1;
                cmbChonAp.SelectedIndex = 0;
            }

        }
        private void loadDataCongViec()
        {
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();

            dtCongViec = new DataTable();
            bdsCongViec = new BindingSource();

            string maAp = cmbChonAp.SelectedValue.ToString();

            string query = $"select MaCV, TenCV, NgayBatDau, NgayKetThuc from CongViec Where MaAp = N'{maAp}'";
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, Program.conn))
            {
                adapter.Fill(dtCongViec);
            }

            string[] names = { "Mã", "Tên", "Ngày bắt đầu", "Ngày kết thúc" };
            for (int i = 0; i < dtCongViec.Columns.Count; i++)
            {
                dtCongViec.Columns[i].ColumnName = names[i];
            }

            bdsCongViec.DataSource = dtCongViec;
            gcCongViec.DataSource = bdsCongViec;
        }

        private void initMaXa()
        {
            string query = "SELECT MaXa FROM Doi WHERE MaDoi = @MaDoi";
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            using (SqlCommand command = new SqlCommand(query, Program.conn))
            {
                command.Parameters.AddWithValue("@MaDoi", Program.mTeam); // Ví dụ: giá trị cho madoi

                object xaValue = command.ExecuteScalar();

                if (xaValue != null)
                {
                     this.maXa = xaValue.ToString();
                }
                else
                {
                    this.maXa = null;
                }
            }
        }
        private void initDataAp()
        {
            dtAp = new DataTable();
            bdsAp = new BindingSource();

            string query = $"select MaAp, TenAp from Ap where MaXa = N'{this.maXa}'";
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, Program.conn))
            {
                adapter.Fill(dtAp);
            }

            bdsAp.DataSource = dtAp;
        }

        private void loadDataPhanCong()
        {
            DataRowView drv = (DataRowView)bdsCongViec.Current;
            string maCongViec = drv["Mã"].ToString();

            dtPhanCong = new DataTable();
            bdsPhanCong = new BindingSource();

            string query = $"select * from PhanCong where MaCV = N'{maCongViec}'";
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, Program.conn))
            {
                adapter.Fill(dtPhanCong);
            }

            bdsPhanCong.DataSource = dtPhanCong;
        }

        private void frmTaoCongViec_Load(object sender, EventArgs e)
        {
            if (this.maXa != null)
            {
                initDataAp();
                initCombobox();
            }
            else
            {
                Alert.ErrorMessageBox("Không thể tìm thấy mã xã");
                this.Close();
            }
            
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(bdsCongViec == null)
            {
                Alert.ErrorMessageBox("Không có ấp để thêm công việc");
                return;

            }

            string maAp = cmbChonAp.SelectedValue.ToString().Trim();
            string tenAp = cmbChonAp.Text;

            FrmNhapLieuCongViec f = new FrmNhapLieuCongViec(0, maAp, tenAp, null, null, DateTime.Now, DateTime.Now) ;
            f.ShowDialog();

            int cvCount = bdsCongViec.Count;
            int index = bdsCongViec != null ? bdsCongViec.Position : 0;
            loadDataCongViec();
            if(bdsCongViec.Count > 0 && cvCount < bdsCongViec.Count)
            {
                bdsCongViec.Position = bdsCongViec.Count -1 ;
            }

        }

        private void btnHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(bdsCongViec == null || bdsCongViec.Count <= 0)
            {
                Alert.ErrorMessageBox("Vui lòng chọn công việc");
                return;
            }

            DataRowView drv = (DataRowView)bdsCongViec.Current;
            string maCongViec = drv["Mã"].ToString();
            string tenCongViec = drv["Tên"].ToString();
            DateTime ngayBatDau = (DateTime)drv["Ngày bắt đầu"];
            DateTime ngayKetThuc = (DateTime)drv["Ngày kết thúc"];

            string maAp = cmbChonAp.SelectedValue.ToString().Trim();
            string tenAp = cmbChonAp.Text;


            FrmNhapLieuCongViec f = new FrmNhapLieuCongViec(1, maAp, tenAp, maCongViec, tenCongViec, ngayBatDau, ngayKetThuc);
            f.ShowDialog();

            int index = bdsCongViec != null ? bdsCongViec.Position : -1;
            loadDataCongViec();
            if (bdsCongViec.Count > 0 )
            {
                bdsCongViec.Position = index;
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (bdsCongViec == null || bdsCongViec.Count <= 0)
            {
                Alert.ErrorMessageBox("Vui lòng chọn công việc.");
                return;
            }
            else if (bdsPhanCong.Count > 0)
            {
                Alert.ErrorMessageBox("Không thể xóa công việc đã được phân công.");
                return;
            }
            DialogResult result = Alert.QuestionMessageBox("Xóa công việc?");
            if (result == DialogResult.Yes)
            {
                DataRowView drv = (DataRowView)bdsCongViec.Current;
                string maCongViec = drv["Mã"].ToString();
                if (xoaCongViec(maCongViec))
                {
                    int index = bdsCongViec.Position - 1;
                    loadDataCongViec();
                    if (index >= 0)
                        bdsCongViec.Position = index;
                }
                else
                {
                    Alert.ErrorMessageBox("Xóa thất bại");
                }
            }
        }

        private bool xoaCongViec(string maCV)
        {
            string query = $"delete from CongViec where MaCV = @Id";
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            try
            {
                using (SqlCommand command = new SqlCommand(query, Program.conn))
                {
                    command.Parameters.AddWithValue("@Id", maCV);
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

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            initDataAp();
            initDataAp();
        }

        private void gvCongViec_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            if (bdsCongViec.Current != null)
            {
                loadDataPhanCong();
            }
        }

        private void cmbChonAp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bdsAp != null && bdsAp.Current != null)
            {
                loadDataCongViec();
            }
        }
    }
}
