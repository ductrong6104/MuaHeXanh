using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MUAHEXANH.FormXemThoiGianCV
{
    public partial class frmXemThoiGianLamViec : Form
    {
        
        public frmXemThoiGianLamViec()
        {
            InitializeComponent();
        }

        


        private void deNgay_DateTimeChanged(object sender, EventArgs e)
        {
            this.sp_xemThoiGianLamViecTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sp_xemThoiGianLamViecTableAdapter.Fill(this.dSxemThoiGianLamViec.sp_xemThoiGianLamViec, Program.mNhom, deNgay.DateTime);
            if (sp_xemThoiGianLamViecBindingSource.Count == 0)
            {
                MessageBox.Show("Không có công việc nào ngày: " + deNgay.Text, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void frmXemThoiGianLamViec_Load(object sender, EventArgs e)
        {
            this.deNgay.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.deNgay.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.deNgay.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.deNgay.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.deNgay.Properties.Mask.EditMask = "dd/MM/yyyy";
            deNgay.DateTime = DateTime.Now;
            Console.WriteLine(Program.mNhom);
            Console.WriteLine(deNgay.Text);
        }
    }
}
