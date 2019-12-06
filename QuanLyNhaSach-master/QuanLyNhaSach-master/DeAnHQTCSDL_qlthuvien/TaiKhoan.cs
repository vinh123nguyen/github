using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeAnHQTCSDL_qlthuvien
{
    class TaiKhoan:ConectToDataBase
    {
        public DataSet ds_TK = new DataSet();
        public SqlDataAdapter da_TK;
        public TaiKhoan()
        {

        }
        public DataTable Loadtk()
        {
            da_TK = new SqlDataAdapter("  SELECT MATK,QUYEN,'____(*-*)____',NGAYLAP FROM TAIKHOAN", conn);
            // Ánh xạ dữ liệu từ DB vào dataset, đặt tên Sach
            da_TK.Fill(ds_TK, "TAIKHOAN");
            //Set Khóa chính
            DataColumn[] khoachinh = new DataColumn[1];
            khoachinh[0] = ds_TK.Tables["TAIKHOAN"].Columns[0];
            ds_TK.Tables["TAIKHOAN"].PrimaryKey = khoachinh;
            return ds_TK.Tables["TAIKHOAN"];
        }
        //public DataTable LoadBang()
        //{
        //    SqlDataAdapter daSach = new SqlDataAdapter("Select TENNXB from NHAXUATBAN", conn);
        //    daSach.Fill(ds_sach, "NHAXUATBAN");
        //    return ds_sach.Tables["NHAXUATBAN"];
        //}
        public bool KTKC(string pManv)
        {
            return KTKC_New(pManv, ds_TK.Tables["TAIKHOAN"]);
        }

        public int khoiphuc(string pma)
        {
            try
            {
                da_TK = new SqlDataAdapter("select * from TAIKHOAN", conn);
                // Ánh xạ dữ liệu từ DB vào dataset, đặt tên Sach
                DataRow dts = ds_TK.Tables["TAIKHOAN"].Rows.Find(pma);
                if (dts != null)
                {
                    dts[2] = "123";
                }
                SqlCommandBuilder builda = new SqlCommandBuilder(da_TK);
                da_TK.Update(ds_TK, "TAIKHOAN");
                return 1;
            }
            catch
            {
                return 0;
            }
        }
        public int themtk(string pManv, string pquyen, string pmk, DateTime pngaylap)
        {
            try
            {

                da_TK = new SqlDataAdapter("select * from TAIKHOAN", conn);
                // Ánh xạ dữ liệu từ DB vào dataset, đặt tên Sach
                da_TK.Fill(ds_TK, "TAIKHOAN");
                DataRow dtThem = ds_TK.Tables["TAIKHOAN"].NewRow();
                dtThem[0] = pManv;
                dtThem[1] = pquyen;
                dtThem[2] = pmk;
                dtThem[3] = pngaylap;
                ds_TK.Tables["TAIKHOAN"].Rows.Add(dtThem);
                SqlCommandBuilder builda = new SqlCommandBuilder(da_TK);
                da_TK.Update(ds_TK, "TAIKHOAN");
                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public int sua(string pma, string pquyen, string pmk,  DateTime nl)
        {
            try
            {
                da_TK = new SqlDataAdapter("select * from TAIKHOAN", conn);
                // Ánh xạ dữ liệu từ DB vào dataset, đặt tên Sach
                DataRow dts = ds_TK.Tables["TAIKHOAN"].Rows.Find(pma);
                if (dts != null)
                {
                    dts[1] = pquyen;
                    dts[2] = pmk;
                    dts[3] = nl;
                }
                SqlCommandBuilder builda = new SqlCommandBuilder(da_TK);
                da_TK.Update(ds_TK, "TAIKHOAN");
                return 1;
            }
            catch
            {
                return 0;
            }
        }
        public int xoatk(string pManv, string tt)
        {
            try
            {
                int kq = 0;


                SqlCommand cmd1 = new SqlCommand("XoaTK", conn);
                // Kiểu của Command là StoredProcedure
                cmd1.CommandType = CommandType.StoredProcedure;

                // Thêm tham số @p_Emp_Id và gán giá trị 100 cho nó.
                cmd1.Parameters.Add("@MaTK", SqlDbType.NVarChar).Value = pManv;
                cmd1.Parameters.Add("@TT", SqlDbType.NVarChar).Value = tt;
                cmd1.Parameters.Add(new SqlParameter("@kiemtra", SqlDbType.Int));

                cmd1.Parameters["@kiemtra"].Direction = ParameterDirection.Output;

                cmd1.ExecuteNonQuery();

                kq = int.Parse(cmd1.Parameters["@kiemtra"].Value.ToString());

                return kq;

            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e);
                MessageBox.Show(e.StackTrace);
                return 0;
            }
        }
        public int xoa(string pMatk)
        {
            da_TK = new SqlDataAdapter("select * from TAIKHOAN", conn);
            // Ánh xạ dữ liệu từ DB vào dataset, đặt tên Sach
            DataRow dtx = ds_TK.Tables["TAIKHOAN"].Rows.Find(pMatk);
            if (dtx != null)
            {
                dtx.Delete();
            }
            SqlCommandBuilder builda = new SqlCommandBuilder(da_TK);
            da_TK.Update(ds_TK, "TAIKHOAN");
            return 1;
        }
        public String tennv(string manv)
        {
            SqlCommand cmd = new SqlCommand("XEMTT_NV('@MTK')", conn);//Cái tên của hàm sql 

            // Kiểu của Command là StoredProcedure
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MTK", manv);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
           // da.Fill(dt);
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
        }

        public DataTable TKTTTAIKHOAN(string MTK,string Q)
        {
            SqlCommand cmd1 = new SqlCommand("SELECT * from dbo.XEMTK_QUYEN('"+@MTK+"','"+Q+"')", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataTable x = dt;
            return x;
        }
    }
}
