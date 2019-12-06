using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeAnHQTCSDL_qlthuvien
{
    public class KhachHang:ConectToDataBase
    {
        public DataSet ds_KH = new DataSet();
        public SqlDataAdapter daKH;
        public KhachHang()
        {
            daKH = new SqlDataAdapter("select * from KHACHHANG", conn);
            LoadBangKH();
        }

        public DataTable LoadBangKH()
        {
            // Ánh xạ dữ liệu từ DB vào dataset
            daKH.Fill(ds_KH, "KHACHHANG");
            //Set Khóa chính
            DataColumn[] khoachinh = new DataColumn[1];
            khoachinh[0] = ds_KH.Tables["KHACHHANG"].Columns[0];
            ds_KH.Tables["KHACHHANG"].PrimaryKey = khoachinh;

            return ds_KH.Tables["KHACHHANG"];
        }

        public bool KTKC(string pMaKH)
        {
            DataRow dtKiemTra = ds_KH.Tables["KHACHHANG"].Rows.Find(pMaKH);

            if (dtKiemTra != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int Them( string pHoTen, DateTime pNgaySinh, string pGioiTinh, string pDiaChi, string pDienThoai)
        {
            try
            {
                if (KTKC(TESTKK()) == true)
                    return 2;

                DataRow dtThem = ds_KH.Tables["KHACHHANG"].NewRow();
                dtThem[0] = TESTKK();
                dtThem[1] = pHoTen;
                dtThem[2] = pNgaySinh;
                dtThem[3] = pGioiTinh;
                dtThem[4] = pDiaChi;
                dtThem[5] = pDienThoai;


                ds_KH.Tables["KHACHHANG"].Rows.Add(dtThem);

                SqlCommandBuilder builda = new SqlCommandBuilder(daKH);

                daKH.Update(ds_KH, "KHACHHANG");
                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public int luu()
        {
            SqlCommandBuilder duilda = new SqlCommandBuilder(daKH);
            daKH.Update(ds_KH, "KHACHHANG");
            return 1;
        }


        public int Sua(string maKH, string hoTen, DateTime ngaySinh, string gioiTinh, string diaChi, string dienThoai)
        {
            daKH = new SqlDataAdapter("select * from KHACHHANG", conn);

            DataRow dtKiemTra = ds_KH.Tables["KHACHHANG"].Rows.Find(maKH);
            if (dtKiemTra != null)
            {
                dtKiemTra["HOTEN"] = hoTen;
                dtKiemTra["NGAYSINH"] = ngaySinh;
                dtKiemTra["GIOITINH"] = gioiTinh;
                dtKiemTra["DIACHI"] = diaChi;
                dtKiemTra["DTKH"] = dienThoai;

                SqlCommandBuilder builda = new SqlCommandBuilder(daKH);
                daKH.Update(ds_KH, "KHACHHANG");
                return 1;
            }
            return 0;
        }

        public int Xoa(string maKH)
        {
            DataRow dtKiemTra = ds_KH.Tables["KHACHHANG"].Rows.Find(maKH);
            if (dtKiemTra != null)
            {
                dtKiemTra.Delete();
                return 1;
            }
            return 0;
        }
        public DataTable TTKhachHang(string TenKH)
        {
            SqlCommand cmd1 = new SqlCommand("SELECT * FROM DBO.XEM_TENKH(@TENKH)", conn);
            cmd1.Parameters.AddWithValue("@TENKH", TenKH);
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataTable x = dt;
            return x;
        }

        public string TESTKK()
        {
           
                // Tạo một đối tượng Command để gọi hàm Get_Emp_No.
                SqlCommand cmd = new SqlCommand("SINHMA_KH", conn);//Cái tên của hàm sql 

                // Kiểu của Command là StoredProcedure
                cmd.CommandType = CommandType.StoredProcedure;

                // Tạo một đối tượng Parameter, lưu trữ giá trị trả về của hàm.
                SqlParameter resultParam = new SqlParameter("@Result", SqlDbType.VarChar);

                resultParam.Direction = ParameterDirection.ReturnValue;

                cmd.Parameters.Add(resultParam);

                // Gọi hàm.
                cmd.ExecuteNonQuery();

                string empNo = null;
                if (resultParam.Value != DBNull.Value)
                {
                    empNo = (string)resultParam.Value;
                }
                return empNo;
                //Console.WriteLine("Emp No: " + empNo);
                //MessageBox.Show(empNo);
            }
    }
}
