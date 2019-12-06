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
    public partial class UserControlTruyXuatKH : UserControl
    {
        KhachHang doiTuongKH = new KhachHang();
        DataTable dt = new DataTable();
        public UserControlTruyXuatKH()
        {
            InitializeComponent();
        }

        private void UserControlTruyXuatKH_Load(object sender, EventArgs e)
        {
            dtgv_KH.DataSource = dt = doiTuongKH.LoadBangKH();
            dtgv_KH.Columns["NGAYSINH"].DefaultCellStyle.Format = "dd/MM/yyyy";
            cb_GT.Items.Insert(0, "Nam");
            cb_GT.Items.Insert(1, "Nữ");
        }

        public void stt()
        {
            for (int i = 0; i < dtgv_KH.Rows.Count - 1; i++)
            {
                dtgv_KH.Rows[i].Cells[0].Value = (i + 1).ToString();
            }
        }

        private void Txt_maKH_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(dt);
            DV.RowFilter = string.Format(" MAKH LIKE '%" + txt_maKH.Text + "%' AND HOTEN LIKE '%" + txt_TenKH.Text + "%'  AND DTKH LIKE '%" + txt_soDT.Text + "%'  AND DIACHI LIKE '%" + txt_DCKH.Text + "%' AND GIOITINH LIKE '%" + cb_GT.Text + "%'");
            dtgv_KH.DataSource = DV;
        }

        private void Txt_TenKH_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(dt);
            DV.RowFilter = string.Format(" MAKH LIKE '%" + txt_maKH.Text + "%' AND HOTEN LIKE '%" + txt_TenKH.Text + "%'  AND DTKH LIKE '%" + txt_soDT.Text + "%'  AND DIACHI LIKE '%" + txt_DCKH.Text + "%' AND GIOITINH LIKE '%" + cb_GT.Text + "%'");
            dtgv_KH.DataSource = DV;
        }

        private void Txt_soDT_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(dt);
            DV.RowFilter = string.Format(" MAKH LIKE '%" + txt_maKH.Text + "%' AND HOTEN LIKE '%" + txt_TenKH.Text + "%'  AND DTKH LIKE '%" + txt_soDT.Text + "%'  AND DIACHI LIKE '%" + txt_DCKH.Text + "%' AND GIOITINH LIKE '%" + cb_GT.Text + "%'");
            dtgv_KH.DataSource = DV;
        }
        private void Txt_DCKH_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(dt);
            DV.RowFilter = string.Format(" MAKH LIKE '%" + txt_maKH.Text + "%' AND HOTEN LIKE '%" + txt_TenKH.Text + "%'  AND DTKH LIKE '%" + txt_soDT.Text + "%'  AND DIACHI LIKE '%" + txt_DCKH.Text + "%' AND GIOITINH LIKE '%" + cb_GT.Text + "%'");
            dtgv_KH.DataSource = DV;
        }
        private void Cb_GT_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(dt);
            DV.RowFilter = string.Format(" MAKH LIKE '%" + txt_maKH.Text + "%' AND HOTEN LIKE '%" + txt_TenKH.Text + "%'  AND DTKH LIKE '%" + txt_soDT.Text + "%'  AND DIACHI LIKE '%" + txt_DCKH.Text + "%' AND GIOITINH LIKE '%" + cb_GT.Text + "%'");
            dtgv_KH.DataSource = DV;
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            stt();
        }

        
    }
}
