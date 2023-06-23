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
    public partial class FrmChonAp : Form
    {
        private void initCombobox() { 
            cmbDiaBan.DataSource = bdsDiaBan;
            cmbDiaBan.DisplayMember = "TenDiaBan";
            cmbXa.DataSource = bdsXa;
            cmbXa.DisplayMember = "TenXa";
        }
        public FrmChonAp()
        {
            InitializeComponent();
        }

        private void diaBanBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsDiaBan.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSChonAp);

        }

        private void FrmChonAp_Load(object sender, EventArgs e)
        {
            dSChonAp.EnforceConstraints = false;
            this.diaBanTableAdapter.Connection.ConnectionString = Program.connstr;
            this.diaBanTableAdapter.Fill(this.dSChonAp.DiaBan);
            this.xaTableAdapter.Connection.ConnectionString = Program.connstr;
            this.xaTableAdapter.Fill(this.dSChonAp.Xa);
            this.apTableAdapter.Connection.ConnectionString = Program.connstr;
            this.apTableAdapter.Fill(this.dSChonAp.Ap);
            initCombobox();
        }

        private void diaBanBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsDiaBan.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSChonAp);

        }

        private void apGridControl_Click(object sender, EventArgs e)
        {

        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Program.maApDuocChon = null;
            this.Close();
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            DataRow drv = gvAp.GetDataRow(gvAp.FocusedRowHandle);
            Program.maApDuocChon = drv["MaAp"].ToString().Trim();
            MessageBox.Show(Program.maApDuocChon);
            this.Close();
        }
    }
}
