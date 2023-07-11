using MUAHEXANH.App;
using MUAHEXANH.FormSchedule;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MUAHEXANH
{
    public partial class FrmRestore : Form
    {
        private DataTable dt;
        private BindingSource bds;
        private String deviceName;
        public FrmRestore()
        {
            InitializeComponent();
        }
        private void loadData()
        {
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();

            dt = new DataTable();
            bds = new BindingSource();

            this.dt = Program.ExecSqlDataTable($"Exec [dbo].[Sp_DanhSachBackupTrongBackupDevice] @DeviceName=N'{this.deviceName}'");
            bds.DataSource = dt;
            gcBackupFile.DataSource = bds;
        }

        private void FrmRestore_Load(object sender, EventArgs e)
        {
            btnChonBackupDevice_Click(null,null);
        }

        private void btnChonBackupDevice_Click(object sender, EventArgs e)
        {
            FrmChonBackupDevice f = new FrmChonBackupDevice();
            f.ShowDialog();
            this.deviceName = Program.backupDeviceName;
            if(this.deviceName == null)
            {
                return;
            }
            txtBackupDeviceName.Text = this.deviceName;
            loadData();
            
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            if (bds == null || bds.Current == null)
            {
                Alert.ErrorMessageBox("Vui lòng chọn file backup.");
                return;
            }
            DataRowView drv = (DataRowView)bds.Current;
            int possition = int.Parse(drv["position"].ToString());

            object[] args = { this.deviceName, possition };

           Action<object[]> worker = (arrParams) =>
            {
                restore(arrParams);
            };
            using (MyWaitForm f = new MyWaitForm(worker, args))
            {
                this.Enabled = false;
                f.Dock = DockStyle.Fill;
                f.SetCaption("Đang restore");
                f.ShowDialog(this);
                this.Enabled = true;
                
            }
        }

        private void restore(object[] args)
        {
            try
            {
                String backupDevice = (string)args[0];
                int position = (int)args[1];

                string connectString = $"Data Source=DESKTOP-9QNDCS8\\DUCTRONG;Initial Catalog=msdb;Persist Security Info=True;User ID={Program.mlogin};Password={Program.password}";
                using (SqlConnection connection = new SqlConnection(connectString))
                {
                    connection.Open();
                    string sqlQuery = $"DECLARE\t@return_value int\r\n\r\nEXEC\t@return_value = [dbo].[Sp_RestoreDatabaseTTCS_MUAHEXANH]\r\n\t\t@DeviceName = N'{backupDevice}',\r\n\t\t@Position = {position}\r\n\r\nSELECT\t'Value' = @return_value";
                    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                    {
                        command.CommandType = CommandType.Text;
                        try
                        {
                            SqlDataReader reader = command.ExecuteReader();
                            if (reader == null)
                            {
                                Alert.ErrorMessageBox("Đã xả ra lỗi khi restore");
                                return;
                            }
                            if (reader.Read())
                            {
                                int stt = int.Parse(reader.GetValue(0).ToString());
                                if (stt == 0)
                                {
                                    Alert.InfoMessageBox($"Restore thành công");
                                }
                                else
                                {
                                    Alert.ErrorMessageBox("Restore thất bại");
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"LỖI: {ex.ToString()}");
                            return;
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                Alert.ErrorMessageBox("Lỗi");
            }
        }
        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
