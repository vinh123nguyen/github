using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Doan.Class;

namespace DeAnHQTCSDL_qlthuvien
{
    public partial class UserControlTLS : UserControl
    {
        Class_loaisach lsach = new Class_loaisach();
        public UserControlTLS()
        {
            InitializeComponent();
        }

        private void stt()
        {
            for (int i = 0; i < dtgv_loaisach.Rows.Count - 1; i++)
            {
                dtgv_loaisach.Rows[i].Cells[0].Value = i + 1;
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            stt();
        }

        private void UserControlTLS_Load(object sender, EventArgs e)
        {
            dtgv_loaisach.DataSource = lsach.LoadBangLoaiSach();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {            
            try
            {
                string pMaloai = txt_maloaish.Text;
                string pTenloai = txt_tenloaish.Text;
                if (txt_maloaish.Text.Length > 0 && txt_tenloaish.Text.Length > 0)
                {
                    int kq = lsach.them(pMaloai, pTenloai);
                    if (kq == 2)
                    {
                        MessageBox.Show("Trùng khóa chính");
                    }
                    if (kq == 1)
                    {
                        // -	Hiển thị thông tin sách trên datagridview

                        lsach.LoadBangLoaiSach().Clear();
                        dtgv_loaisach.Refresh();
                        dtgv_loaisach.DataSource = lsach.LoadBangLoaiSach();
                        MessageBox.Show("Thành công");
                        stt();                   
                    }
                    //else
                    //{
                    //    lsach.LoadBangLoaiSach().Clear();
                    //    dtgv_loaisach.Refresh();
                    //    dtgv_loaisach.DataSource = lsach.LoadBangLoaiSach();
                    //    stt();
                    //    MessageBox.Show("thất bại");
                    //}
                }
            }
            catch
            {
                MessageBox.Show("thất bại");
            }
        }

        private void txt_maloaish_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string pMaloai = txt_maloaish.Text;
                int kq = lsach.xoa(pMaloai);
                if (kq == 1)
                {
                    lsach.LoadBangLoaiSach().Clear();
                    dtgv_loaisach.Refresh();
                    dtgv_loaisach.DataSource = lsach.LoadBangLoaiSach();
                    stt();
                    btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;

                }
                //else
                //{
                //    lsach.LoadBangLoaiSach().Clear();
                //    dtgv_loaisach.Refresh();
                //    dtgv_loaisach.DataSource = lsach.LoadBangLoaiSach();
                //    stt();
                //    btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
                //    MessageBox.Show(" Đã xảy ra lỗi!!!");
                //}
            }
            catch
            {
                MessageBox.Show(" Đã xảy ra lỗi!!!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string pMaloai = txt_maloaish.Text;
                string pTenloai = txt_tenloaish.Text;
                int kq = lsach.sua(pMaloai, pTenloai);
                if (kq == 1)
                {
                    lsach.LoadBangLoaiSach().Clear();
                    dtgv_loaisach.Refresh();
                    dtgv_loaisach.DataSource = lsach.LoadBangLoaiSach();
                    stt();
                    grb_loaisach.Enabled = false;
                    btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;

                }
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lội");
            }
        }

        private void dtgv_loaisach_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgv_loaisach.CurrentRow != null)
            {
                txt_maloaish.Text = dtgv_loaisach.CurrentRow.Cells["MALOAISH"].Value.ToString().Trim();
                txt_tenloaish.Text = dtgv_loaisach.CurrentRow.Cells["TENLOAISH"].Value.ToString().Trim();
            }
        }

        private void textBoxTimMaSach_TextChanged(object sender, EventArgs e)
        {
            string pMals = textBoxTimMaSach.Text;
            dtgv_loaisach.DataSource = lsach.TTLS(pMals);
        }

        private void textBoxTimTheLoai_TextChanged(object sender, EventArgs e)
        {
            string ptenls = textBoxTimTheLoai.Text;
            dtgv_loaisach.DataSource = lsach.TTLS_2(ptenls);
        }
    }
}
