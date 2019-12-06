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
    public partial class UserControlQLS : UserControl
    {
        Sach sach = new Sach();
        public UserControlQLS()
        {
            InitializeComponent();
            
        }
        int flag;
        private void UserControlQLS_Load(object sender, EventArgs e)
        {
            dtgv_sach.DataSource = sach.LoadBangSach_GhepBang();
            //-	Đỗ dữ liệu lên combobox Lớp, thông tin lớp lấy từ cơ sở dữ liệu với tên lớp là nhãn hiển thị, mã lớp là giá trị khi nhấn chọn item, trong đó dòng đầu tiên là “Tất cả lớp”. Khi chọn tên lớp trên combobox Lớp, datagridview sẽ được lọc dữ liệu theo.
            cmb_nxb.ValueMember = "TENNXB".Trim();
            cmb_nxb.DataSource = sach.LoadBangNhaXuatBan();
            cmb_tl.ValueMember = "TENLOAISH";
            cmb_tl.DataSource = sach.LoadBangLoaiSach();
            grb_thongtinsach.Enabled = false;

        }

        private void Stt()
        {
            for (int i = 0; i < dtgv_sach.Rows.Count - 1; i++)
            {
                dtgv_sach.Rows[i].Cells[0].Value = i + 1;
            }
        }

        private void TxtSoluog_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) == false && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void Txtgia_KeyPress(object sender, KeyPressEventArgs e)
        {
           if (Char.IsDigit(e.KeyChar) == false && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            grb_thongtinsach.Enabled = true;
            btnLuu.Enabled = btnHuy.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            txtMa.Clear();
            txtTen.Clear();
            txtSoluog.Clear();
            txtTenTG.Clear();
            txt_nanxb.Clear();
            txtgia.Clear();
            flag = 1;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            Stt();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            grb_thongtinsach.Enabled = true;
            btnLuu.Enabled = btnHuy.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            flag = 2;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            grb_thongtinsach.Enabled = true;
            btnLuu.Enabled = btnHuy.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            txtMa.Enabled = false;
            flag = 3;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                string pMasach = txtMa.Text;
                string pTensach = txtTen.Text;
                string pMaNXB = sach.layMANXB(cmb_nxb.Text.ToString());
                string pNamxb = txt_nanxb.Text;
                string pMaTL = sach.layMALOAISH(cmb_tl.Text.ToString());
                string pTentg = txtTenTG.Text;
                float pGiatien = float.Parse(txtgia.Text);
                int pSoluong = int.Parse(txtSoluog.Text);
                if (flag == 1)
                {
                    if (txtMa.Text.Length > 0 && txtTen.Text.Length > 0 && txtTenTG.Text.Length > 0 && cmb_nxb.Text.Length > 0 && cmb_tl.Text.Length > 0 && txtgia.Text.Length > 0)
                    {
                        int kq = sach.them(pMasach, pTensach, pTentg, pNamxb, pGiatien, pMaNXB, pMaTL,pSoluong);   
                        if (kq == 2)
                        {
                            MessageBox.Show("Trùng khóa chính");
                        }
                        if (kq == 1)
                        {
                            // -	Hiển thị thông tin sách trên datagridview
                            sach.LoadBangSach_GhepBang().Clear();
                            dtgv_sach.Refresh();
                            dtgv_sach.DataSource = sach.LoadBangSach_GhepBang();
                            MessageBox.Show("Thành công");
                            grb_thongtinsach.Enabled = false;
                            btnLuu.Enabled = btnHuy.Enabled = false;
                            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;

                        }
                        else
                        {
                            sach.LoadBangSach_GhepBang().Clear();
                            dtgv_sach.Refresh();
                            dtgv_sach.DataSource = sach.LoadBangSach_GhepBang();
                            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
                            MessageBox.Show("thất bại");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Dữ liệu thêm vào chưa đủ");
                    }

                }
                if (flag == 2)
                {
                    int kq = sach.xoa(pMasach);
                    if (kq == 1)
                    {
                        sach.LoadBangSach_GhepBang().Clear();
                        dtgv_sach.Refresh();
                        dtgv_sach.DataSource = sach.LoadBangSach_GhepBang();
                        btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;

                    }
                    else
                    {
                        btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
                        MessageBox.Show(" Đã xảy ra lỗi!!!");
                    }
                }
                if (flag == 3)
                {
                    int kq = sach.sua(pMasach, pTensach, pTentg, pNamxb, pGiatien, pMaNXB, pMaTL,pSoluong);
                    if (kq == 1)
                    {
                        sach.LoadBangSach_GhepBang().Clear();
                        dtgv_sach.Refresh();
                        dtgv_sach.DataSource = sach.LoadBangSach_GhepBang();
                        btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;

                    }
                    else
                    {
                        btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
                        MessageBox.Show("loi!!!");
                    }
                }
                flag = 0;
            }
            catch
            {
                flag = 0;
                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
                MessageBox.Show("Lưu thất bại");
            }
        }

        private void dtgv_sach_SelectionChanged(object sender, EventArgs e)
        {

            if (dtgv_sach.CurrentRow != null)
            {
                txtMa.Text = dtgv_sach.CurrentRow.Cells["MASH"].Value.ToString().Trim();
                txtTen.Text = dtgv_sach.CurrentRow.Cells["TENSH"].Value.ToString().Trim();
                //if (string.IsNullOrEmpty(txt_kt.Text))
                //{
                //    cmb_tl.Text = dtgv_sach.CurrentRow.Cells["TENLOAISH"].Value.ToString().Trim();
                //    cmb_nxb.Text = dtgv_sach.CurrentRow.Cells["TENNXB"].Value.ToString().Trim();
                //}
                txtTenTG.Text = dtgv_sach.CurrentRow.Cells["TENTG"].Value.ToString().Trim();
                txt_nanxb.Text = dtgv_sach.CurrentRow.Cells["NAMXB"].Value.ToString().Trim();
                
                txtgia.Text = dtgv_sach.CurrentRow.Cells["GIATIEN"].Value.ToString().Trim();

            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn hủy thao tác đang làm?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                grb_thongtinsach.Enabled = false;
                btnLuu.Enabled = btnHuy.Enabled = false;
                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
                flag = 0;
            }
            else
                return;
        }

        private void txt_kt_TextChanged(object sender, EventArgs e)
        {
            string ptensh = txt_kt.Text;
            dtgv_sach.DataSource = sach.ttsach(ptensh);
        }
    }
}
