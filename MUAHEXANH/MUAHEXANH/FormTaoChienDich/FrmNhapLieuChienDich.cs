using DevExpress.XtraCharts.Designer.Native;
using MUAHEXANH.App;
using MUAHEXANH.DSTaoChienDichTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            this.bdsChienDich = bdsChienDich;
            this.dSTaoChienDich = dSTaoChienDich;
            this.chienDichTableAdapter = chienDichTableAdapter;
            this.state = state;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtTenChienDich.Text?.Trim() == "")
            {
                Alert.ErrorMessageBox("Tên chiến dịch không được để trống");
                return;
            }
      
            try
            {
                bdsChienDich.EndEdit();
                chienDichTableAdapter.Update(this.dSTaoChienDich.ChienDich);
                int index = bdsChienDich.Position;
                this.chienDichTableAdapter.Fill(this.dSTaoChienDich.ChienDich);
                bdsChienDich.Position = index;
                this.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                Alert.ErrorMessageBox("Loi them chien dich!");
            }
            
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
            dtpNgayPhatDong.EditValue = DateTime.Now;
           
        }
    }
}
