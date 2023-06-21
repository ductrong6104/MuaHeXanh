using MUAHEXANH.App;
using MUAHEXANH.FrmChon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MUAHEXANH
{
    public partial class FrmCongViec : Form
    {
        public FrmCongViec()
        {
            InitializeComponent();
        }
        private void initCombobox()
        {
            cmbDiaBan.DataSource = bdsDiaBan;
            cmbDiaBan.DisplayMember = "TenDiaBan";
            cmbXa.DataSource = bdsXa;
            cmbXa.DisplayMember = "TenXa";
            cmbChonAp.DataSource = bdsAp;
            cmbChonAp.DisplayMember = "TenAp";
        }

        private void initData()
        {
            this.diaBanTableAdapter.Connection.ConnectionString = Program.connstr;
            this.xaTableAdapter.Connection.ConnectionString = Program.connstr;
            this.apTableAdapter.Connection.ConnectionString = Program.connstr;
            this.congViecTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phanCongTableAdapter.Connection.ConnectionString = Program.connstr;


            this.dSTaoCongViec.EnforceConstraints = false;
            this.diaBanTableAdapter.Fill(this.dSTaoCongViec.DiaBan);
            this.xaTableAdapter.Fill(this.dSTaoCongViec.Xa);
            this.apTableAdapter.Fill(this.dSTaoCongViec.Ap);
            this.congViecTableAdapter.Fill(this.dSTaoCongViec.CongViec);
            this.phanCongTableAdapter.Fill(this.dSTaoCongViec.PhanCong);

        }

        private void frmTaoCongViec_Load(object sender, EventArgs e)
        {
            initData();
            initCombobox();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsCongViec.AddNew();
            FrmNhapLieuCongViec f = new FrmNhapLieuCongViec(this.bdsAp, this.bdsCongViec, "them", congViecTableAdapter, this.dSTaoCongViec);
            f.ShowDialog();
        }

        private void btnHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmNhapLieuCongViec f = new FrmNhapLieuCongViec(this.bdsAp, this.bdsCongViec, "sua", congViecTableAdapter, this.dSTaoCongViec);
            f.ShowDialog();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsCongViec.Count <= 0)
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
                int index = bdsCongViec.Position - 1;
                bdsCongViec.RemoveCurrent();
                bdsCongViec.EndEdit();
                congViecTableAdapter.Update(this.dSTaoCongViec.CongViec);
                if (index > -1)
                    bdsCongViec.Position = index;
            }
        }

        private void congViecGridControl_Click(object sender, EventArgs e)
        {

        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            initData();
        }
    }
}
