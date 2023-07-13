using DevExpress.ClipboardSource.SpreadsheetML;
using DevExpress.Utils.Gesture;
using DevExpress.XtraCharts.Designer.Native;
using MUAHEXANH.App;
using MUAHEXANH.DSTaoChienDichTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        private BindingSource bdsChienDich;
        private DSTaoChienDich dSTaoChienDich;
        private ChienDichTableAdapter chienDichTableAdapter;
        private int state;
        public FrmNhapLieuChienDich(BindingSource bdsChienDich, ChienDichTableAdapter chienDichTableAdapter, DSTaoChienDich dSTaoChienDich, int state)
        {
            InitializeComponent();
            if (bdsChienDich == null)
            {
                Alert.ErrorMessageBox("Không thể khởi tạo FrmNhapLieuChienDich mà không truyền binddingsource");
                return;
            }
            this.txtTenChienDich.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", bdsChienDich, "TenChienDich", true));
            this.dtpNgayPhatDong.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", bdsChienDich, "NgayPhatDong", true));
            this.dtpNgayKetThuc.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", bdsChienDich, "NgayKetThuc", true));

            this.bdsChienDich = bdsChienDich;
            this.dSTaoChienDich = dSTaoChienDich;
            this.chienDichTableAdapter = chienDichTableAdapter;
            this.state = state;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            Alert.InfoMessageBox(dtpNgayPhatDong.Text + ", " + dtpNgayKetThuc.Text);
            
            if (txtTenChienDich.Text?.Trim() == "")
            {
                Alert.ErrorMessageBox("Tên chiến dịch không được để trống");
                return;
            }
            DateTime ngayPhatDong = dtpNgayPhatDong.DateTime;
            DateTime ngayKetThuc = dtpNgayKetThuc.DateTime;
            if(ngayPhatDong > ngayKetThuc)
            {
                Alert.ErrorMessageBox("Ngày kết thúc phải sau ngày phát động");
                return;
            }


            bdsChienDich.EndEdit();
            chienDichTableAdapter.Update(this.dSTaoChienDich.ChienDich);
            int index = bdsChienDich.Position;
            this.chienDichTableAdapter.Fill(this.dSTaoChienDich.ChienDich);
            bdsChienDich.Position = index;
            this.Close();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            if (state == 0)
                bdsChienDich.RemoveCurrent();
            else if (state == 1)
            {
                int index = bdsChienDich.Position;
                this.chienDichTableAdapter.Fill(this.dSTaoChienDich.ChienDich);
                bdsChienDich.Position = index;
            }
            bdsChienDich.EndEdit();
            chienDichTableAdapter.Update(this.dSTaoChienDich.ChienDich);
            this.Close();
        }

        private void FrmNhapLieuChienDich_Shown(object sender, EventArgs e)
        {
            if(state == 0)
            {
                dtpNgayPhatDong.EditValue = maxTimeKetThuc();
                dtpNgayPhatDong.Properties.MinValue = maxTimeKetThuc();
                dtpNgayKetThuc.Properties.MinValue = dtpNgayPhatDong.DateTime.AddDays(1);
                dtpNgayKetThuc.EditValue = dtpNgayKetThuc.Properties.MinValue;
            }
        }

        private void FrmNhapLieuChienDich_Load(object sender, EventArgs e)
        {

        }

        private void dtpNgayPhatDong_EditValueChanged(object sender, EventArgs e)
        {
            dtpNgayKetThuc.Properties.MinValue = dtpNgayPhatDong.DateTime.AddDays(1);
            if (dtpNgayKetThuc.DateTime != null &&  dtpNgayKetThuc.DateTime > dtpNgayPhatDong.DateTime)
            {
                return;
            }
            dtpNgayKetThuc.EditValue = dtpNgayKetThuc.Properties.MinValue;
        }

        private DateTime maxTimeKetThuc()
        {
            if (bdsChienDich.DataSource == null)
                return DateTime.Now;

            DataTable dt = new DataTable();
            dt.Columns.Add("ngayKetThuc", typeof(DateTime));
            
            for (int i =0;i <bdsChienDich.Count; i++)
            {
                string ngay = ((DataRowView)bdsChienDich[i])["NGAYKETTHUC"].ToString();
                string[] sDate = ngay.Split('/');
                string ngayConvert = sDate[1] + '/' + sDate[0] + '/' + sDate[2];
                DateTime ngaydata = Convert.ToDateTime(ngayConvert); 
                Console.WriteLine(((DataRowView)bdsChienDich[i])["NGAYKETTHUC"].ToString());
                dt.Rows.Add(ngaydata);
            }
            DateTime dateTime = Convert.ToDateTime(dt.AsEnumerable()
                        .Max(row => row["NGAYKETTHUC"]));
            Alert.InfoMessageBox("datetime max" + dateTime.ToString());
            return dateTime;
        }
    }
}
