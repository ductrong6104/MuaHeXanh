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
    public partial class frmNhapLieuBackup : Form
    {
        private String filePath;

        private void initCombobox()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add(new DataColumn("NAME", typeof(string)));
            dataTable.Columns.Add(new DataColumn("VALUE", typeof(string)));

            DataRow row1 = dataTable.NewRow();
            row1["NAME"] = "Disk";
            row1["VALUE"] = "disk";
            dataTable.Rows.Add(row1);

/*            DataRow row2 = dataTable.NewRow();
            row2["NAME"] = "Pipe";
            row2["VALUE"] = "pipe";
            dataTable.Rows.Add(row2);*/

            cmbLoai.DataSource = dataTable;
            cmbLoai.DisplayMember = "NAME";
            cmbLoai.ValueMember = "VALUE";
        }
        public frmNhapLieuBackup()
        {
            InitializeComponent();
        }

        private bool chonNoiLuuFile()
        {
            if(txtTenBackup.Text.Trim() == "")
            {
                Alert.InfoMessageBox("Tên backup không hợp lệ");
                txtTenBackup.Focus();
                return false;
            }
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Title = "Chọn đường dẫn";
                saveFileDialog.RestoreDirectory = true;
                saveFileDialog.ValidateNames = false;
                saveFileDialog.CheckFileExists = false;
                //saveFileDialog.CheckPathExists = true;
                saveFileDialog.FileName = $"{txtTenBackup.Text.Trim()}.bak";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath =  saveFileDialog.FileName;
                    return true;
                }
                else
                {
                    Console.WriteLine("Hủy bỏ chọn thư mục.");
                }
            }
            catch(Exception ex)
            {
                Alert.ErrorMessageBox($"Lỗi: {ex.Message}");
            }
            return false;
        }
        private void luuFile(String loaiBackup, String tenBackup, String tenFileBackup)
        {
            try
            {
                string sql = $"DECLARE\t@return_value int\r\n\r\nEXEC\t@return_value = [dbo].[sp_addumpdevice]\r\n\t\t@devtype = '{loaiBackup}',\r\n\t\t@logicalname = '{tenBackup}',\r\n\t\t@physicalname = '{tenFileBackup}'\r\n\r\nSELECT\t'Value' = @return_value";
                SqlDataReader dataReader = Program.ExecSqlDataReader(sql);
                if (dataReader == null)
                {
                    Alert.ErrorMessageBox("Lỗi");
                    return;
                }
                if (dataReader.Read())
                {
                    int stt = int.Parse(dataReader.GetValue(0).ToString());
                    if (stt == 0)
                    {
                        Alert.InfoMessageBox($"Đã thêm.\nTên backup: {tenBackup}\nĐường dẫn: {tenFileBackup}");
                    }
                    else
                    {
                        Alert.ErrorMessageBox("Thêm thiết bị backup thất bại.");
                    }
                    dataReader.Close();
                }
            }
            catch(Exception ex)
            {
                Alert.ErrorMessageBox($"Lỗi: {ex.Message}");
            }
        }
        private void frmNhapLieuBackup_Load(object sender, EventArgs e)
        {
            initCombobox();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (chonNoiLuuFile())
            {
                string loaiBackup = cmbLoai.SelectedValue.ToString().Trim();
                string tenBackup = txtTenBackup.Text.Trim();
                string tenFileBackup = filePath;

                Action<String, String, String> worker = (loai, ten, path) =>
                {
                    luuFile(loai, ten, path);
                };
                using (FrmWaitTaoDevice f = new FrmWaitTaoDevice(worker, loaiBackup, tenBackup, tenFileBackup))
                {
                    f.Dock = DockStyle.Fill;
                    f.ShowDialog(this);
                }
            }
           
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
