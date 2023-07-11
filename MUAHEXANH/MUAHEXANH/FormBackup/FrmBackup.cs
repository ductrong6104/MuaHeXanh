using MUAHEXANH.App;
using MUAHEXANH.FormSchedule;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MUAHEXANH
{
    public partial class FrmBackup : Form
    {
        public FrmBackup()
        {
            InitializeComponent();
        }
        private void initCombobox()
        {
            //Loai
            DataTable dataTable1 = new DataTable();
            dataTable1.Columns.Add(new DataColumn("NAME", typeof(string)));
            dataTable1.Columns.Add(new DataColumn("VALUE", typeof(int)));

            DataRow row11 = dataTable1.NewRow();
            row11["NAME"] = "Full backup";
            row11["VALUE"] = 0;
            dataTable1.Rows.Add(row11);

            DataRow row12 = dataTable1.NewRow();
            row12["NAME"] = "Differential backup";
            row12["VALUE"] = 1;
            dataTable1.Rows.Add(row12);

            DataRow row13 = dataTable1.NewRow();
            row13["NAME"] = "Transaction log backup";
            row13["VALUE"] = 2;
            dataTable1.Rows.Add(row13);

            cmbLoai.DataSource = dataTable1;
            cmbLoai.DisplayMember = "NAME";
            cmbLoai.ValueMember = "VALUE";

         

        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            if(txtBackupDevice.Text.Trim() == "")
            {
                Alert.ErrorMessageBox("Vui lòng chọn backup device");
                return;
            }

            int backupType = cmbLoai.SelectedIndex;
            String deviceName= txtBackupDevice.Text.Trim();
            String description = $"Backup TTCS_MUAHEXANH {DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")}";

            object[] args = { backupType, deviceName, description };

            //Gọi sp backup
            Action<object[]> worker = (arrParams) =>
            {
                callBackup(arrParams);
            };
            using (MyWaitForm f = new MyWaitForm(worker, args))
            {
                this.Enabled = false;
                f.Dock = DockStyle.Fill;
                f.SetCaption("Đang backup");
                f.ShowDialog(this);
                this.Enabled = true;
            }
//            callBackup(backupType, deviceName, url, description);
        }
        private void callBackup(object[] args)
        {
            try
            {
                int backupType = (int)args[0];
                String deviceName = (String)args[1];
                String description = (String)args[2];

                using (SqlConnection connection = new SqlConnection(Program.connstr))
                {
                    connection.InfoMessage += Connection_InfoMessage;
                    connection.Open();
                    string sql = "";
                    if (deviceName != null)
                    {
                        sql = $"DECLARE\t@return_value int\r\n\r\nEXEC\t@return_value = [dbo].[Sp_Backup]\r\n\t\t@Type = {backupType},\r\n\t\t@BackupDevice = '{deviceName}',\r\n\t\t@Description='{description}'\r\n\r\nSELECT\t'Value' = @return_value";
                    }
                    else
                    {
                        Alert.ErrorMessageBox("Không được để trống Url");
                        return;
                    }

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.CommandType = CommandType.Text;
                        try
                        {
                            SqlDataReader reader = command.ExecuteReader();
                            if (reader == null)
                            {
                                Alert.ErrorMessageBox("Đã xả ra lỗi khi backup");
                                return;
                            }
                            if (reader.Read())
                            {
                                int stt = int.Parse(reader.GetValue(0).ToString());
                                if (stt == 0)
                                {
                                    Alert.InfoMessageBox($"Backup thành công");
                                }
                                else
                                {
                                    Alert.ErrorMessageBox("Backup thất bại");
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
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
        private static void Connection_InfoMessage(object sender, SqlInfoMessageEventArgs e)
        {
            // Lấy thông tin STATS từ các thông báo
            foreach (SqlError error in e.Errors)
            {
                
                if(error.State == 1)
                {
                }
                //Console.WriteLine($"_______________________{error.Message} :: {error.State}");
            }
        }
        private static void Connection_StateChange(object sender, StateChangeEventArgs e)
        {
            if(e.CurrentState == ConnectionState.Closed)
            {
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmBackup_Load(object sender, EventArgs e)
        {
            initCombobox();
        }

        private void frmBackup_Shown(object sender, EventArgs e)
        {
            
        }

        private void btnChonBackupDevice_Click(object sender, EventArgs e)
        {
            FrmChonBackupDevice frm = new FrmChonBackupDevice();
            frm.ShowDialog(this);
            if (Program.backupDeviceName != null)
            {
                txtBackupDevice.Text = Program.backupDeviceName.Trim();
            }
        }
    }
}
