using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.SqlServer.Server;

namespace DeAnHQTCSDL_qlthuvien
{
    public partial class UserControlSaoLuu : UserControl
    {
        public UserControlSaoLuu()
        {
            InitializeComponent();
        }

        private void BtnBackupFULL_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length <= 0)
            {

                MessageBox.Show("Nhập server");
                return;
            }

            if (textBox2.Text.Length <= 0)
            {
                MessageBox.Show("Nhập database");
                return;
            }
            SqlConnection conn = new SqlConnection();
            SqlCommand sqlcmd = new SqlCommand();
            try
            {
                conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=QLNHASACH;Integrated Security=True");
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                label7.Text = "29%";
                label7.Text = "30%";
                label7.Text = "30%";
                label7.Text = "30%";
                label7.Text = "30%";
                label7.Text = "30%";
                label7.Text = "30%";
                label7.Text = "30%";
                label7.Text = "30%";
                label7.Text = "30%";
                label7.Text = "30%";
                label7.Text = "30%";
                label7.Text = "30%";
                label7.Text = "30%";
                label7.Text = "30%";
                label7.Text = "30%";
                sqlcmd = new SqlCommand(@"BACKUP DATABASE QLNHASACH TO DISK = 'C:\baocao\QLSV_BC-FULL.BAK'", conn);
                sqlcmd.ExecuteNonQuery();
                conn.Close();

                label7.Text = "100%";
                MessageBox.Show("thành công òi nè ");

            }
            catch (Exception ex)
            {
                MessageBox.Show("fail nhẹ");
            }
        }

        private void BtnDiff_Click(object sender, EventArgs e)
        {
            if (textBox3.Text.Length <= 0)
            {

                MessageBox.Show("Nhập server");
                return;
            }

            if (textBox4.Text.Length <= 0)
            {
                MessageBox.Show("Nhập database");
                return;
            }
            SqlConnection conn = new SqlConnection();
            SqlCommand sqlcmd = new SqlCommand();
            try
            {
                conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=QLNHASACH;Integrated Security=True");
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                label8.Text = "21%";
                label8.Text = "31%";
                label8.Text = "31%";
                label8.Text = "31%";
                label8.Text = "31%";
                label8.Text = "31%";
                label8.Text = "31%";
                label8.Text = "31%";
                label8.Text = "31%";
                label8.Text = "31%";
                label8.Text = "31%";
                label8.Text = "31%";
                label8.Text = "31%";
                sqlcmd = new SqlCommand(@"BACKUP DATABASE QLNHASACH TO DISK = 'C:\baocao\QLSV_BC-DIFF.BAK' WITH DIFFERENTIAL", conn);
                sqlcmd.ExecuteNonQuery();
                conn.Close();

                label8.Text = "100%";
                MessageBox.Show("thành công òi nè ");

            }
            catch (Exception ex)
            {
                MessageBox.Show("fail nhẹ");
            }
        }
        //    progressBar1.Value = 0;
        //    try
        //    {
        //        Server dbserver = new Server(new ServerConnection(@"PC-PC\SQLEXPRESS"));
        //        Backup dbbackup = new Backup() { Action = BackupActionType.Database, Database = "QLNHANVIEN" };
        //        dbbackup.Devices.AddDevice(@"C:\backup\backupfull.bak", DeviceType.File);
        //        dbbackup.Initialize = true;
        //        dbbackup.PercentComplete += DbBackup_PercentComplete;
        //        dbbackup.Complete += DbBackup_Complete;
        //        dbbackup.SqlBackupAsync(dbserver);

        //        MessageBox.Show("thành công òi nè ");
        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //}

        //private void DbBackup_Complete(object sender, ServerMessageEventArgs e)
        //{
        //    if (e.Error != null)
        //    {
        //        labelstatus.Invoke((MethodInvoker)delegate
        //        {
        //            labelstatus.Text = e.Error.Message;
        //        });
        //    }
        //}

        //private void DbBackup_PercentComplete(object sender, PercentCompleteEventArgs e)
        //{
        //    progressBar1.Invoke((MethodInvoker)delegate
        //    {
        //        progressBar1.Value = e.Percent;
        //        progressBar1.Update();

        //    });
        //    labelPercentFull.Invoke((MethodInvoker)delegate
        //    {
        //        labelPercentFull.Text = $"{e.Percent}%";
        //    });
        //    MessageBox.Show(labelPercentFull.Text);
        //}
    }
}
