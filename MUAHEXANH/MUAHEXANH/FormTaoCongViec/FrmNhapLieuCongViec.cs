using MUAHEXANH.App;
using MUAHEXANH.DSTaoCongViecTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MUAHEXANH.FrmChon
{
    public partial class FrmNhapLieuCongViec : Form
    {
        private string state = "none";
        private BindingSource bdsCongViec;
        private CongViecTableAdapter adapter;
        private DSTaoCongViec dsTaoCongViec;
        public FrmNhapLieuCongViec(BindingSource bdsAp, BindingSource bdsCongViec, string state, CongViecTableAdapter adapter, DSTaoCongViec dsTaoCongViec)
        {
            InitializeComponent();
            this.txtTenAp.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", bdsAp, "TenAp", true));
            this.txtMaAp.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", bdsCongViec, "MaAp", true));
            this.txtTenCongViec.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", bdsCongViec, "TenCV", true));
            this.dtpNgayBatDau.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", bdsCongViec, "NgayBatDau", true));
            this.dtpNgayKetThuc.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", bdsCongViec, "NgayKetThuc", true));
            this.state = state;
            this.bdsCongViec = bdsCongViec;
            this.adapter = adapter;
            this.dsTaoCongViec = dsTaoCongViec;
        }

        private void frmNhapLieuThemCongViec_Load(object sender, EventArgs e)
        {

        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            if (state == "them")
                bdsCongViec.RemoveCurrent();
            else if (state == "sua")
            {
                int index = bdsCongViec.Position;
                this.adapter.Fill(this.dsTaoCongViec.CongViec);
                bdsCongViec.Position = index;
            }
            bdsCongViec.EndEdit();
            adapter.Update(this.dsTaoCongViec.CongViec);
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(txtTenCongViec.Text?.Trim() == "")
            {
                Alert.ErrorMessageBox("Tên công việc không được để trống");
                return;
            }
            bdsCongViec.EndEdit();
            adapter.Update(this.dsTaoCongViec.CongViec);
            int index = bdsCongViec.Position;
            this.adapter.Fill(this.dsTaoCongViec.CongViec);
            bdsCongViec.Position = index;
            this.Close();
        }

        private void dtpNgayBatDau_EditValueChanged(object sender, EventArgs e)
        {
            dtpNgayKetThuc.Properties.MinValue = dtpNgayBatDau.DateTime;
        }
    }
}
