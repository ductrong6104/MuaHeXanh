using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MUAHEXANH.frmXaApNhaDan
{
    public partial class frmThemNhaDan : Form
    {
        private int viTri;
        public frmThemNhaDan()
        {
            InitializeComponent();
        }
        public void trangThaiBanDau()
        {
            btnThem.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = btnHieuChinh.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
            

        }
        public void trangThaiChuaGhi()
        {
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
           
        }

        private void frmThemNhaDan_Load(object sender, EventArgs e)
        {
            this.dSthemXaApNhaDan.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dSthemXaApNhaDan.NhaDan' table. You can move, or remove it, as needed.
            this.nhaDanTableAdapter.Fill(this.dSthemXaApNhaDan.NhaDan);
            // TODO: This line of code loads data into the 'dSthemXaApNhaDan.Ap' table. You can move, or remove it, as needed.
            this.apTableAdapter.Fill(this.dSthemXaApNhaDan.Ap);
            // TODO: This line of code loads data into the 'dSthemXaApNhaDan.Xa' table. You can move, or remove it, as needed.
            this.xaTableAdapter.Fill(this.dSthemXaApNhaDan.Xa);
            // TODO: This line of code loads data into the 'dSthemXaApNhaDan.DiaBan' table. You can move, or remove it, as needed.
            this.diaBanTableAdapter.Fill(this.dSthemXaApNhaDan.DiaBan);
            txtSDT.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            //txtSDT.Properties.Mask.EditMask = "#,##0.00";
            //txtSDT.Properties.Mask.UseMaskAsDisplayFormat = true;
            trangThaiBanDau();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTri = bdsNhaDan.Position;
            bdsNhaDan.AddNew();
            txtMaAp.Text = cmbAp.SelectedValue.ToString();
            trangThaiChuaGhi();
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {

                bdsNhaDan.EndEdit();
                bdsNhaDan.ResetCurrentItem();
                this.nhaDanTableAdapter.Update(this.dSthemXaApNhaDan.NhaDan);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi nhà!Xem lại trùng địa chỉ", "", MessageBoxButtons.OK);
                Console.WriteLine(ex.ToString());
                // tro ve trang thai luc them cho user dieu chinh lai
                return;
            }
            MessageBox.Show("Ghi nhà thành công!", "", MessageBoxButtons.OK);
            this.nhaDanTableAdapter.Fill(this.dSthemXaApNhaDan.NhaDan);
            trangThaiBanDau();
        }

        private void cmbDiaBan_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.xaTableAdapter.Fill(this.dSthemXaApNhaDan.Xa);
            this.apTableAdapter.Fill(this.dSthemXaApNhaDan.Ap);
            this.nhaDanTableAdapter.Fill(this.dSthemXaApNhaDan.NhaDan);
        }

        private void cmbXa_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.apTableAdapter.Fill(this.dSthemXaApNhaDan.Ap);
            this.nhaDanTableAdapter.Fill(this.dSthemXaApNhaDan.NhaDan);
        }

        private void cmbAp_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.nhaDanTableAdapter.Fill(this.dSthemXaApNhaDan.NhaDan);
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Ban có thật sự muốn xóa nhà dân này không?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    bdsNhaDan.RemoveCurrent();
                    this.nhaDanTableAdapter.Update(this.dSthemXaApNhaDan.NhaDan);
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa nhà dân!", "", MessageBoxButtons.OK);
                    Console.WriteLine(ex.ToString());
                    // tro ve trang thai luc them cho user dieu chinh lai
                    return;
                }
                MessageBox.Show("Xóa nhà dân thành công!", "", MessageBoxButtons.OK);
            }

            this.nhaDanTableAdapter.Fill(this.dSthemXaApNhaDan.NhaDan);
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.nhaDanTableAdapter.Fill(this.dSthemXaApNhaDan.NhaDan);
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (btnThem.Enabled == false)
                bdsNhaDan.Position = viTri;
            bdsNhaDan.CancelEdit();
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}
