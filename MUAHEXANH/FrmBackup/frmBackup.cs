using MUAHEXANH.App;
using MUAHEXANH.FrmBackup;
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
    public partial class frmBackup : Form
    {
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

            //Destination

            DataTable dataTable2 = new DataTable();
            dataTable2.Columns.Add(new DataColumn("NAME", typeof(string)));
            dataTable2.Columns.Add(new DataColumn("VALUE", typeof(int)));

            DataRow row21 = dataTable2.NewRow();
            row21["NAME"] = "Url";
            row21["VALUE"] = 0;
            dataTable2.Rows.Add(row21);

            DataRow row22 = dataTable2.NewRow();
            row22["NAME"] = "Disk";
            row22["VALUE"] = 1;
            dataTable2.Rows.Add(row22);


            cmbDestination.DataSource = dataTable2;
            cmbDestination.DisplayMember = "NAME";
            cmbDestination.ValueMember = "VALUE";

            cmbDestination.SelectedIndex = 0;
        }
        public frmBackup()
        {
            InitializeComponent();
        }

        private void cmbDestination_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int destination = int.Parse(cmbDestination.SelectedValue.ToString());
                if (destination == 1)
                {
                    txtUrl.ReadOnly = true;
                    frmChonBackupDevice frm = new frmChonBackupDevice();
                    frm.ShowDialog();

                    if (Program.backupDeviceName != null)
                    {
                        txtUrl.Text = Program.backupDeviceName.Trim();
                    }
                }
                else if (destination == 0)
                {
                    txtUrl.ReadOnly = false;
                }
            }
            catch(Exception ex) { }
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            int backupType = cmbLoai.SelectedIndex;
            String deviceName= null;
            String url = null;
            String description = $"Backup TTCS_MUAHEXANH {DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")}";
            if(int.Parse(cmbDestination.SelectedValue.ToString()) == 0)
            {
                url = txtUrl.Text.Trim();
            }
            else
            {
                deviceName = txtUrl.Text.Trim();
            }
            //Gọi sp backup
            Action<int, String, String, String> worker = (param1, param2, param3, param4) =>
            {
                callBackup(param1, param2, param3, param4);
            };
            using (FrmWaitBackup f = new FrmWaitBackup(worker, backupType, deviceName, url, description))
            {
                f.Dock = DockStyle.Fill;
                f.ShowDialog(this);
            }
//            callBackup(backupType, deviceName, url, description);
        }
        private void callBackup(int backupType, String deviceName, String url, String description)
        {
            using (SqlConnection connection = new SqlConnection(Program.connstr))
            {
                connection.InfoMessage += Connection_InfoMessage;
                connection.Open();
                string sql = "";
                if (url != null)
                {
                    sql = $"DECLARE\t@return_value int\r\n\r\nEXEC\t@return_value = [dbo].[Sp_Backup]\r\n\t\t@Type = {backupType},\r\n\t\t@BackupDevice = NULL,\r\n\t\t@Url = '{url}',\r\n\t\t@Description='{description}'\r\n\r\nSELECT\t'Value' = @return_value";
                }
                else if (deviceName != null)
                {
                    sql = $"DECLARE\t@return_value int\r\n\r\nEXEC\t@return_value = [dbo].[Sp_Backup]\r\n\t\t@Type = {backupType},\r\n\t\t@BackupDevice = '{deviceName}',\r\n\t\t@Url = NULL,\r\n\t\t@Description='{description}'\r\n\r\nSELECT\t'Value' = @return_value";
                }
                else
                {
                    Alert.ErrorMessageBox("Không được để trống Url");
                    return;
                }

                sql += "\t\n\nWAITFOR DELAY '00:00:05'";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.CommandType = CommandType.Text;
                    try
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        if(reader == null)
                        {
                            Alert.ErrorMessageBox("Đã xả ra lỗi khi backup");
                            Program.progress = null;
                            return;
                        }
                        if(reader.Read())
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
                        Program.progress = null;
                    }
                    catch (Exception ex) {
                        MessageBox.Show(ex.Message);
                        Program.progress = null;
                        return;
                    }
                }
            }
        }
        private static void Connection_InfoMessage(object sender, SqlInfoMessageEventArgs e)
        {
            // Lấy thông tin STATS từ các thông báo
            foreach (SqlError error in e.Errors)
            {
                
                if(error.State == 1)
                {
                    Program.progress = error.Message;
                }
                //Console.WriteLine($"_______________________{error.Message} :: {error.State}");
            }
        }
        private static void Connection_StateChange(object sender, StateChangeEventArgs e)
        {
            if(e.CurrentState == ConnectionState.Closed)
            {
                Program.progress = null;
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
    }
}
