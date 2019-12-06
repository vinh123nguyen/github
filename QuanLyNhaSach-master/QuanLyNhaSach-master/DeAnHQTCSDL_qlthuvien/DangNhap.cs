using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeAnHQTCSDL_qlthuvien
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }


        private string Chuoinoi = @"Data Source=.\SQLEXPRESS;Initial Catalog=QLNHASACH;Integrated Security=True";
        private void Admin_CheckedChanged(object sender, EventArgs e)
        {
           Chuoinoi  = @"Data Source=.\SQLEXPRESS;Initial Catalog=QLNHASACH;Integrated Security=True";
        }

        private void khachhang_CheckedChanged(object sender, EventArgs e)
        {
           Chuoinoi = @"Data Source=.\SQLEXPRESS;Initial Catalog=QLNHASACH;Integrated Security=True";
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {         
            FormMain f = new FormMain(Chuoinoi);
            this.Hide();
            f.ShowDialog();
        }
    }
}
