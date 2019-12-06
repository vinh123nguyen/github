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
    public partial class UserControlQLNhanVien : UserControl
    {
        Class_nhanvien nv = new Class_nhanvien();
        TaiKhoan tk = new TaiKhoan();
        public UserControlQLNhanVien()
        {
            InitializeComponent();
        }
        int flag=0;
        private void UserControlQLNhanVien_Load(object sender, EventArgs e)
        {
            dtgvDS.DataSource = nv.Loadnv();
            dtgvDS.Columns["NGAYSINH"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dtgvDS.Columns["NGAYVL"].DefaultCellStyle.Format = "dd/MM/yyyy";
            stt();
            DisEnl(false);
            cmbGioiTinh.Items.Clear();
            cmbGioiTinh.Items.Add("Nam");
            cmbGioiTinh.Items.Add("Nữ");
            cmbGioiTinh.SelectedItem = 0;
            dt_nvl.Value = DateTime.Now.Date;
        }
        private void DisEnl(bool e)
        {
            btnThem.Enabled = !e;
            btnXoa.Enabled = !e;
            btnSua.Enabled = !e;
            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
            //txtMa.Enabled = e;
            txtTen.Enabled = e;
            txtDiaChi.Enabled = e;
            txtMNQL.Enabled = e;
            txtcv.Enabled = e;
            txtluong.Enabled = e;
            msk_ngaysinh.Enabled = e;
            cmbGioiTinh.Enabled = e;
            dt_nvl.Enabled = e;

        }
        private void stt()
        {
            for (int i = 0; i < dtgvDS.Rows.Count - 1; i++)
            {
                dtgvDS.Rows[i].Cells[0].Value = i + 1;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            stt();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            flag = 1;
            clearData();
            DisEnl(true);
            txtMa.Text = nv.CapMaNhanVien();
            dtgvDS.Enabled = false;


        }
        private void clearData()
        {
            txtMa.Text = "";
            txtTen.Text = "";
            txtDiaChi.Text = "";
            txtMNQL.Text = "";
            txtcv.Text = "";
            txtluong.Text = "";
            msk_ngaysinh.Text = "";
            dt_nvl.Value = DateTime.Now.Date;
            cmbGioiTinh.SelectedValue = true;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn hủy thao tác đang làm?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                dtgvDS.Enabled = true;
                DisEnl(false);
                flag = 0;
                UserControlQLNhanVien_Load(sender, e);
            }
            else
                return;
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            flag = 2;
            DisEnl(true);
            grb_thongtinnhanvien.Enabled = false;         
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                
                string pManv = txtMa.Text;
                string pTennv = txtTen.Text;
                DateTime pngaysinh = DateTime.Parse(msk_ngaysinh.Text);
                DateTime pngayvaolam = DateTime.Parse(dt_nvl.Text);
                string pmnql = txtMNQL.Text;
                string pgt = cmbGioiTinh.Text;
                string pdc = txtDiaChi.Text;
                string pcv = txtcv.Text;
                string tt = dtgvDS.CurrentRow.Cells["TINHTRANG"].Value.ToString();//cái cột tình trạng đâu

                //string pManv = "NV0010";
                //string pTennv = "HJKHSI";
                //DateTime pngaysinh = DateTime.Parse(msk_ngaysinh.Text);
                //DateTime pngayvaolam = DateTime.Parse(dt_nvl.Text);
                //string pmnql = "123";
                //string pgt = "Nam";
                //string pdc = "VN";
                //string pcv = "123";


                //string pquyen = " ";
                //if (pcv.CompareTo("Nhân viên") != 0)
                //{
                //    pquyen = "user";
                //}
                float pluong = float.Parse(txtluong.Text);
                //string pmk = "123456789";
                //string pTentaikhoan = pManv;
                DateTime pngaylap = pngayvaolam;

                //mở khóa datagridview cho trường hợp thêm
                dtgvDS.Enabled = true;
                if (flag == 1)
                {
                    
                    if (txtMa.Text.Length > 0 && txtTen.Text.Length > 0 )
                    {

                        int kq = nv.them(pManv, pTennv, pngaysinh, pngayvaolam, pmnql, pgt, pdc, pcv, pluong);

                        if (kq == 0)
                        {
                            MessageBox.Show("Trùng khóa chính");
                        }
                        if (kq == 1)
                        {
                            // -	Hiển thị thông tin sách trên datagridview
                            nv.Loadnv().Clear();
                            dtgvDS.Refresh();
                            dtgvDS.DataSource = nv.Loadnv();
                            stt();
                            MessageBox.Show("Thêm Thành công");
                            btnLuu.Enabled = btnHuy.Enabled = false;
                            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = true;
                            flag = 0;
                        }
                        else
                        {
                            flag = 0;
                            MessageBox.Show("thất bại");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Dữ liệu thêm chưa đủ ");
                    }
                }
                if (flag == 2)
                {
                    pManv = dtgvDS.CurrentRow.Cells[1].Value.ToString();
                    
                    int kq = nv.xoa(pManv);
                    tk.xoatk(pManv,tt);
                    if (kq == 1)
                    {

                        nv.Loadnv().Clear();
                        dtgvDS.Refresh();
                        tk.Loadtk().Clear();
                       // nv.luu();
                        dtgvDS.DataSource = nv.Loadnv();
                        stt();
                        MessageBox.Show("Xóa Thành công");
                        btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = true;
                        flag = 0;
                    }
                    else
                    {
                        nv.Loadnv().Clear();
                        dtgvDS.Refresh();
                        dtgvDS.DataSource = nv.Loadnv();
                        stt();
                        flag = 0;
                        MessageBox.Show(" Đã xảy ra lỗi!!!");
                    }

                }
                if (flag == 3)
                {
                    int kq = nv.sua(pManv, pTennv, pngaysinh, pngayvaolam, pmnql, pgt, pdc, pcv, pluong);
                    if (kq == 1)
                    {
                        
                        nv.Loadnv().Clear();
                        dtgvDS.Refresh();
                        dtgvDS.DataSource = nv.Loadnv();
                        stt();
                        MessageBox.Show("Sửa Thành công");
                        btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = true;
                        flag = 0;
                    }
                    else
                    {
                        flag = 0;
                        MessageBox.Show(" Đã xảy ra lỗi!!!");
                    }
                }
                grb_thongtinnhanvien.Enabled = true;

            }
            catch
            {
                flag = 0;
                MessageBox.Show("Lưu thất bại");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            flag = 3;
            DisEnl(true);
            grb_thongtinnhanvien.Enabled = true;
        }

        private void txtluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            DisEnl(true);
            grb_thongtinnhanvien.Enabled = true;
        }

        private void dtgvDS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgvDS_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgvDS.CurrentRow != null)
            {
                txtMa.Text = dtgvDS.CurrentRow.Cells["MANV"].Value.ToString();
                txtTen.Text = dtgvDS.CurrentRow.Cells["HOTENNV"].Value.ToString();
                msk_ngaysinh.Text = dtgvDS.CurrentRow.Cells["NGAYSINH"].Value.ToString();
                dt_nvl.Text = dtgvDS.CurrentRow.Cells["NGAYVL"].Value.ToString();
                cmbGioiTinh.Text = dtgvDS.CurrentRow.Cells["GIOITINH"].Value.ToString();
                txtDiaChi.Text = dtgvDS.CurrentRow.Cells["DIACHINV"].Value.ToString();
                txtluong.Text = dtgvDS.CurrentRow.Cells["LUONG"].Value.ToString();
                txtcv.Text = dtgvDS.CurrentRow.Cells["CHUCVU"].Value.ToString();
                txtMNQL.Text = dtgvDS.CurrentRow.Cells["MANQL"].Value.ToString();
            }
        }

       

       

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string pManv = textBox2.Text;
            dtgvDS.DataSource = nv.TTNV(pManv);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string pTennv = textBox1.Text;
            dtgvDS.DataSource = nv.TTNV_2(pTennv);
        }

    }
}
