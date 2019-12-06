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
    public partial class UserControlNXB : UserControl
    {
        NhaXuatBan nxb = new NhaXuatBan();
        int flag;
        public UserControlNXB()
        {
            InitializeComponent();
            
        }

        private void UserControlNXB_Load(object sender, EventArgs e)
        {
            dtgv_nxb.DataSource = nxb.LoadNhaxuatban();
            grb_thongnxb.Enabled = false;
        }
        private void stt()
        {
            for (int i = 0; i < dtgv_nxb.Rows.Count - 1; i++)
            {
                dtgv_nxb.Rows[i].Cells[0].Value = i + 1;
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            stt();
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            grb_thongnxb.Enabled = true;
            txt_manxb.Clear();
            txt_tennxb.Clear();
            txt_dcnxb.Clear();
            txt_dtnxb.Clear();
            btnLuu.Enabled = btnHuy.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = false;
            flag = 1;
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            grb_thongnxb.Enabled = true;
            btnLuu.Enabled = btnHuy.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = false;
            flag = 2;
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            grb_thongnxb.Enabled = true;
            btnLuu.Enabled = btnHuy.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = false;
            flag = 2;
        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                string pManxb = txt_manxb.Text;
                string pTennxb = txt_tennxb.Text;
                string pDcnxb = txt_dcnxb.Text;
                string pDtnxb = txt_dtnxb.Text;
                if (flag == 1)
                {
                    if (txt_manxb.Text.Length > 0 && txt_tennxb.Text.Length > 0 && txt_dcnxb.Text.Length > 0 && txt_dtnxb.Text.Length > 0)
                    {
                        int kq = nxb.them(pManxb, pTennxb, pDcnxb, pDtnxb);
                        if (kq == 2)
                        {
                            MessageBox.Show("Trùng khóa chính");
                        }
                        if (kq == 1)
                        {
                            // -	Hiển thị thông tin sách trên datagridview
                            nxb.LoadNhaxuatban().Clear();
                            dtgv_nxb.Refresh();
                            dtgv_nxb.DataSource = nxb.LoadNhaxuatban();
                            stt();
                            MessageBox.Show("Thêm Thành công");
                            btnLuu.Enabled = btnHuy.Enabled = false;
                            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = true;
                        }
                        else
                        {
                            nxb.LoadNhaxuatban().Clear();
                            dtgv_nxb.Refresh();
                            dtgv_nxb.DataSource = nxb.LoadNhaxuatban();
                            stt();
                            MessageBox.Show("thất bại");
                        }
                    }
                    else
                    {
                        MessageBox.Show("dữ liệu đầu vào chưa đủ");
                    }
                }
                if (flag == 2)
                {
                    int kq = nxb.xoa(pManxb);
                    if (kq == 1)
                    {
                        nxb.LoadNhaxuatban().Clear();
                        dtgv_nxb.Refresh();
                        dtgv_nxb.DataSource = nxb.LoadNhaxuatban();
                        stt();
                        MessageBox.Show("Xóa Thành công");
                        btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show(" Đã xảy ra lỗi!!!");
                    }
                }
                if (flag == 3)
                {
                    int kq = nxb.sua(pManxb, pTennxb, pDcnxb, pDtnxb);
                    if (kq == 1)
                    {
                        nxb.LoadNhaxuatban().Clear();
                        dtgv_nxb.Refresh();
                        dtgv_nxb.DataSource = nxb.LoadNhaxuatban();
                        stt();
                        MessageBox.Show("Sửa Thành công");
                        btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show(" Đã xảy ra lỗi!!!");
                    }
                }
                flag = 0;
            }
            catch
            {
                flag = 0;
                MessageBox.Show("Lưu dữ liệu thất bại");
            }
        }

        private void BtnHuy_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn hủy thao tác đang làm?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                grb_thongnxb.Enabled = false;
                btnLuu.Enabled = btnHuy.Enabled = false;
                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
                flag = 0;
            }
            else
                return;
        }

        private void Txt_tk_TextChanged(object sender, EventArgs e)
        {
            string ptennxb = txt_tk.Text;
            dtgv_nxb.DataSource = nxb.TTNXB(ptennxb);
        }

        private void Dtgv_nxb_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgv_nxb.CurrentRow != null)
            {
                txt_manxb.Text = dtgv_nxb.CurrentRow.Cells["MANXB"].Value.ToString().Trim();
                txt_tennxb.Text = dtgv_nxb.CurrentRow.Cells["TENNXB"].Value.ToString().Trim();
                txt_dcnxb.Text = dtgv_nxb.CurrentRow.Cells["DCNXB"].Value.ToString().Trim();
                txt_dtnxb.Text = dtgv_nxb.CurrentRow.Cells["DTNXB"].Value.ToString().Trim();
            }
        }
    }
}
