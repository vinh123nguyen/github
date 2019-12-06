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
    public partial class UserControlTK : UserControl
    {
        TaiKhoan tk = new TaiKhoan();
        int flag;
        public UserControlTK()
        {
            InitializeComponent();
            
        }

        private void UserControlTK_Load(object sender, EventArgs e)
        {
            dtgv_tk.DataSource = tk.Loadtk();
            btnLuu.Enabled = btnHuy.Enabled = false;
        }

        public void STT()
        {
            for (int i = 0; i < dtgv_tk.Rows.Count - 1; i++)
            {
                dtgv_tk.Rows[i].Cells[0].Value = (i + 1).ToString();
            }
        }

        private void BtnKhoiPhuc_Click(object sender, EventArgs e)
        {
            if(dtgv_tk.SelectedCells !=null)
            {
                int kq=tk.khoiphuc(dtgv_tk.CurrentRow.Cells[1].Value.ToString());
                if (kq == 1)
                {
                    dtgv_tk.Refresh();
                    dtgv_tk.DataSource = tk.Loadtk();
                    STT();
                    MessageBox.Show("Khôi Phục Mật Khẩu Thành công");
                    btnSua.Enabled = btnHuy.Enabled = true;
                    flag = 0;
                }
                else
                {
                    flag = 0;
                    MessageBox.Show(" Có Vấn Đề !!!");
                }
            }
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            flag = 1;
            btnSua.Enabled = btn_xoa.Enabled = false;
            grb_THONGTINTK.Enabled = true;
            btnLuu.Enabled = btnHuy.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (flag == 1)
                {
                    string pma = txt_matk.Text;
                    string pquyen = txt_q.Text.ToString();
                    string pmk = txt_mk.Text;
                    DateTime pnl = DateTime.Parse(dtp_ngaylap.Text.ToString());
                    int kq = tk.sua(pma, pquyen, pmk, pnl);
                    if (kq == 1)
                    {
                        dtgv_tk.Refresh();
                        dtgv_tk.DataSource = tk.Loadtk();
                        STT();
                        MessageBox.Show("Sửa Thành công");
                        btnSua.Enabled = btnHuy.Enabled = true;
                        flag = 0;
                    }
                    else
                    {
                        flag = 0;
                        MessageBox.Show(" Lưu thất bại!!!");
                    }
                }
                if (flag == 2)
                {
                    string pma = txt_matk.Text;
                    string pquyen = txt_q.Text.ToString();
                    string pmk = txt_mk.Text;
                    int kq = tk.xoa(pma);
                    if (kq == 1)
                    {
                        dtgv_tk.Refresh();
                        dtgv_tk.DataSource = tk.Loadtk();
                        STT();
                        MessageBox.Show("Xóa Thành công");
                        btnSua.Enabled = btnHuy.Enabled = true;
                        flag = 0;
                    }
                    else
                    {
                        flag = 0;
                        MessageBox.Show(" Lưu thất bại!!!");
                    }
                }
            }
            catch
            {
                flag = 0;
                MessageBox.Show("Lỗi!!!");
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            flag = 2;
            btnSua.Enabled = btn_xoa.Enabled = false;
            grb_THONGTINTK.Enabled = true;
            btnLuu.Enabled = btnHuy.Enabled = true;
        }

        private void dtgv_tk_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgv_tk.CurrentRow != null)
            {
                txt_matk.Text = dtgv_tk.CurrentRow.Cells["MATK"].Value.ToString().Trim();
                txt_q.Text = dtgv_tk.CurrentRow.Cells["QUYEN"].Value.ToString().Trim();
                txt_mk.Text = "*************";
                dtp_ngaylap.Text = dtgv_tk.CurrentRow.Cells["NGAYLAP"].Value.ToString().Trim();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn hủy thao tác đang làm?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes && flag != 4)
            {
                grb_tk.Enabled = false;
                btnLuu.Enabled = btnHuy.Enabled = false;
                btnSua.Enabled = btn_xoa.Enabled = true;
                flag = 0;
            }
            else
            {
                UserControlTK_Load(sender, e);
                flag = 0;
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            STT();
        }

        private void TextBox1_TextChanged_1(object sender, EventArgs e)
        {
            string pmtk = textBox1.Text;
            string pq = textBox2.Text;
            dtgv_tk.DataSource = tk.TKTTTAIKHOAN(pmtk,pq);
        }

        //private void textBox2_TextChanged(object sender, EventArgs e)
        //{
        //    string pmtk = textBox1.Text;
        //    string pq = textBox2.Text;
        //    dtgv_tk.DataSource = tk.TKTTTAIKHOAN(pmtk, pq);
        //}

    }
}
