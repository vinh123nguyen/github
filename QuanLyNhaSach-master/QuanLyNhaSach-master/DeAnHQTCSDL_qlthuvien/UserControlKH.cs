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
    public partial class UserControlKH : UserControl
    {
        KhachHang doiTuongKH = new KhachHang();
        public UserControlKH()
        {
            InitializeComponent();

        }
        private void UserControlKH_Load(object sender, EventArgs e)
        {
            dtgv_KH.DataSource = doiTuongKH.LoadBangKH();
            dtgv_KH.Columns["NGAYSINH"].DefaultCellStyle.Format = "dd/MM/yyyy";
            loadgt();
        }
        public void STT()
        {
            for (int i = 0; i < dtgv_KH.Rows.Count - 1; i++)
            {
                dtgv_KH.Rows[i].Cells[0].Value = (i + 1).ToString();
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            STT();
        }
        private bool ktdl()
        {
            if (txt_maKH.Text.Length == 0 || txt_soDT.Text.Length == 0 || txt_HoTenKH.Text.Length == 0 || txt_DCKH.Text.Length == 0 || mtxt_ngaySinh.Text.Length != 10)
                return false;
            return true;
        }
        private void loadgt()
        {
            cb_GT.Items.Add("Nam");
            cb_GT.Items.Add("Nữ");
            cb_GT.SelectedItem = "Nam";
        }
        private void Btn_themKH_Click(object sender, EventArgs e)
        {
            if (ktdl())
            {
                string maKH = txt_maKH.Text;
                string tenKH = txt_HoTenKH.Text;
                DateTime ngaySinh = DateTime.Parse(mtxt_ngaySinh.Text);
                string gioiTinh = cb_GT.SelectedItem.ToString();
                string diaChi = txt_DCKH.Text;
                string dienThoai = txt_soDT.Text;

                int kq = doiTuongKH.Them(tenKH, ngaySinh, gioiTinh, diaChi, dienThoai);

                if (kq == 2)
                {
                    MessageBox.Show("Trùng khóa chính");
                }
                else
                    if (kq == 1)
                    {
                        //-	Hiển thị thông tin sinh viên trên datagridview.
                        dtgv_KH.DataSource = doiTuongKH.LoadBangKH();
                        MessageBox.Show("Thêm thành công");
                    }
                    else
                        MessageBox.Show("thất bại");
            }
            else
            {
                MessageBox.Show("Chưa nhập đủ thông tin");
            }
        }

        private void Btn_xoaKH_Click(object sender, EventArgs e)
        {
            try
            {
                string maKHCanXoa = dtgv_KH.CurrentRow.Cells[1].Value.ToString();
                if (doiTuongKH.Xoa(maKHCanXoa) == 1)
                {
                    MessageBox.Show("Xóa thành công");
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
                }
            }
            catch
            {
                MessageBox.Show("Lỗi!!!");
            }
        }

        private void Btn_suaKH_Click(object sender, EventArgs e)
        {
            try
            {
                if (ktdl())
                {
                    string maKHCanSua = dtgv_KH.CurrentRow.Cells[1].Value.ToString();
                    int kq = doiTuongKH.Sua(maKHCanSua, txt_HoTenKH.Text, DateTime.Parse(mtxt_ngaySinh.Text), cb_GT.SelectedItem.ToString(), txt_DCKH.Text, txt_soDT.Text);
                    if (kq == 1)
                    {
                        dtgv_KH.DataSource = doiTuongKH.LoadBangKH();
                    }
                    else
                    {
                        MessageBox.Show("Sửa thất bại!!!");
                    }
                }
                else
                {
                    MessageBox.Show("Chưa nhập đủ thông tin");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Lỗi!!");
            }
        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (doiTuongKH.luu() == 1)
                {
                    MessageBox.Show("Đã lưu");
                }
                else
                {
                    dtgv_KH.DataSource = doiTuongKH.LoadBangKH();
                    MessageBox.Show("Lưu thất bại");
                }
            }
            catch
            {
                dtgv_KH.DataSource = doiTuongKH.LoadBangKH();
                MessageBox.Show("Lưu thất bại");
                return;
            }
        }

        private void BtnHuy_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn hủy thao tác đang làm?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                btnLuu.Enabled = btnHuy.Enabled = false;
                btn_suaKH.Enabled = btn_xoaKH.Enabled = true;
            }
            else
            {
                UserControlKH_Load(sender, e);
            }
        }

        private void Dtgv_KH_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgv_KH.CurrentRow != null)
            {
                txt_maKH.Text = dtgv_KH.CurrentRow.Cells[1].Value.ToString().Trim();
                txt_HoTenKH.Text = dtgv_KH.CurrentRow.Cells[2].Value.ToString();
                txt_DCKH.Text = dtgv_KH.CurrentRow.Cells[5].Value.ToString();
                txt_soDT.Text = dtgv_KH.CurrentRow.Cells[6].Value.ToString().Trim();
                mtxt_ngaySinh.Text = dtgv_KH.CurrentRow.Cells[3].Value.ToString().Trim();
                cb_GT.Text = dtgv_KH.CurrentRow.Cells[4].Value.ToString();
            }
        }

        private void Txt_soDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) == false)
                e.Handled = true;
        }

        //private void TextBox1_TextChanged(object sender, EventArgs e)
        //{
        //    DataView dv = new DataView(doiTuongKH.LoadBangKH());
        //    dv.RowFilter = string.Format("HOTEN LIKE '%{0}%'", textBox1.Text);
        //    dtgv_KH.DataSource = dv;
        //}

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(textBox1.Text))
                {
                    UserControlKH_Load(sender, e);
                }
                else
                {
                    string TENKH = textBox1.Text;
                    dtgv_KH.DataSource = doiTuongKH.TTKhachHang(TENKH);
                }
            }
        }

        private void btn_lm_Click(object sender, EventArgs e)
        {
            txt_maKH.Text = "";
            txt_soDT.Text = "";
            txt_DCKH.Text = "";
            txt_HoTenKH.Text = "";
            mtxt_ngaySinh.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
