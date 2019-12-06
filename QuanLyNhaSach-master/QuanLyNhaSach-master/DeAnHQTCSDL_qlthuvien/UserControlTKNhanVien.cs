using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeAnHQTCSDL_qlthuvien
{
    public partial class UserControlTKNhanVien : UserControl
    {
        TaiKhoan tk = new TaiKhoan();
        public UserControlTKNhanVien()
        {
            InitializeComponent();
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {   
            if(label5.Visible==false)
            {
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                txtMKCu.Visible = true;
                txtMKMoi1.Visible = true;
                txtMKMoi2.Visible = true;
                btnLuu.Visible = true;
            }
            else
            {
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                txtMKCu.Visible = false;
                txtMKMoi1.Visible = false;
                txtMKMoi2.Visible = false;
                btnLuu.Visible = false;
            }
        
        }

        private void UserControlTKNhanVien_Load(object sender, EventArgs e)
        {
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            txtMKCu.Visible = false;
            txtMKMoi1.Visible = false;
            txtMKMoi2.Visible = false;
            btnLuu.Visible = false;
        }

        private void txtMa_TextChanged(object sender, EventArgs e)
        {
            //string manv = txtMa.Text;
            //txtTen.Text = tk.tennv(manv);
        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtMa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string manv = txtMa.Text;
                txtTen.Text = tk.tennv(manv);
            }
        }
    }
}
