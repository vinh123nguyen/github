using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DeAnHQTCSDL_qlthuvien;
using System.Windows.Forms;

namespace Doan.Class
{
    class Class_nhanvien : ConectToDataBase
    {
        public DataSet ds_nv = new DataSet();
        public SqlDataAdapter da_nv;
        public Class_nhanvien()
        {
            Loadnv();
        }
        public DataTable Loadnv()
        {
            
            SqlDataAdapter da_nv = new SqlDataAdapter("select * from NHANVIEN", conn);
            // Ánh xạ dữ liệu từ DB vào dataset, đặt tên Sach
            da_nv.Fill(ds_nv, "NHANVIEN");
            //Set Khóa chính
            DataColumn[] khoachinh = new DataColumn[1];
            khoachinh[0] = ds_nv.Tables["NHANVIEN"].Columns[0];
            ds_nv.Tables["NHANVIEN"].PrimaryKey = khoachinh;
            return ds_nv.Tables["NHANVIEN"];
            
        }
        public bool KTKC(string pManv)
        {
            return KTKC_New(pManv, ds_nv.Tables["NHANVIEN"]);
        }
        //public int them(string pManv, string pTennv,DateTime pngaysinh, DateTime pngayvaolam, string pmnql,string pgt, string pdc, string pcv, float pluong)
        //{
        //    try
        //    {
        //        int kq=0;
        //        //SqlCommand cmd1 = new SqlCommand("Exec ThemNV '" + pManv + "','" + pTennv + "','" + pgt + "','" + pdc + "','" + pngaysinh + "','" + pngayvaolam + "','" + pcv + "','" + pluong + "','" + pmnql + "'," + kq + " OUTPUT", conn);
        //        //SqlDataAdapter da = new SqlDataAdapter(cmd1);
        //        if(ConnectionState.Closed==conn.State)
        //            conn.Open();
        //        SqlCommand cmd1 = new SqlCommand("ThemNV", conn);
        //        // Kiểu của Command là StoredProcedure
        //        cmd1.CommandType = CommandType.StoredProcedure;

        //        // Thêm tham số @p_Emp_Id và gán giá trị 100 cho nó.
        //        cmd1.Parameters.Add("@MaNV", SqlDbType.NVarChar).Value = pManv;
        //        cmd1.Parameters.Add("@TenNV", SqlDbType.NVarChar).Value = pTennv;
        //        cmd1.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value = pgt;
        //        cmd1.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = pdc;
        //        cmd1.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = pngaysinh;
        //        cmd1.Parameters.Add("@NgayVaoLam", SqlDbType.Date).Value = pngayvaolam;
        //        cmd1.Parameters.Add("@ChucVu", SqlDbType.NVarChar).Value = pcv;
        //        cmd1.Parameters.Add("@Luong", SqlDbType.Float).Value = pluong;
        //        cmd1.Parameters.Add("@MaQL", SqlDbType.NVarChar).Value = pmnql;

        //        cmd1.Parameters.Add(new SqlParameter("@kiemtra", SqlDbType.Int));

        //        cmd1.Parameters["@kiemtra"].Direction = ParameterDirection.Output;
        //        //SqlCommand cmd1 = new SqlCommand("Declare @KT int EXEC ThemNV 'NV00215','CC','','','','','','','',@KT OUTPUT");
        //        cmd1.ExecuteNonQuery();

        //        kq =  int.Parse(cmd1.Parameters["@kiemtra"].Value.ToString());



        //        //DataTable dt = new DataTable();
        //        //da.Fill(dt);
        //        // Ánh xạ dữ liệu từ DB vào dataset, đặt tên NHANVIEN
        //        MessageBox.Show(kq.ToString());
        //        conn.Close();
        //        //da_nv.Fill(ds_nv, "NHANVIEN");
        //        //da_nv.Update(ds_nv, "NHANVIEN");
        //        return kq;
        //        //if (KTKC(pManv) == true)
        //        //{
        //        //    return 2;
        //        //}
        //        //else
        //        //{
        //        //    DataRow dtThem = ds_nv.Tables["NHANVIEN"].NewRow();
        //        //    dtThem[0] = pManv;
        //        //    dtThem[1] = pTennv;
        //        //    dtThem[2] = pngaysinh;
        //        //    dtThem[3] = pngayvaolam;
        //        //    dtThem[4] = pgt;
        //        //    dtThem[5] = pdc;
        //        //    dtThem[6] = pluong;
        //        //    dtThem[7] = pcv;
        //        //    dtThem[8] = pmnql;
        //        //    ds_nv.Tables["NHANVIEN"].Rows.Add(dtThem);
        //        //    SqlCommandBuilder builda = new SqlCommandBuilder(da_nv);
        //        //    da_nv.Update(ds_nv, "NHANVIEN");
        //        //    return 1;
        //        //}
        //    }
        //    catch
        //    {
        //        return -1;
        //    }
        //}

        public int them(string pManv, string pTennv, DateTime pngaysinh, DateTime pngayvaolam, string pmnql, string pgt, string pdc, string pcv, float pluong)
        {
            try
            {
                int kq = 0;

                if (ConnectionState.Closed == conn.State)
                    conn.Open();
                SqlCommand cmd1 = new SqlCommand("ThemNV", conn);
                // Kiểu của Command là StoredProcedure
                cmd1.CommandType = CommandType.StoredProcedure;

                cmd1.Parameters.Add("@MaNV", SqlDbType.NVarChar).Value = pManv;
                cmd1.Parameters.Add("@TenNV", SqlDbType.NVarChar).Value = pTennv;
                cmd1.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value = pgt;
                cmd1.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = pdc;
                cmd1.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = pngaysinh;
                cmd1.Parameters.Add("@NgayVaoLam", SqlDbType.Date).Value = pngayvaolam;
                cmd1.Parameters.Add("@ChucVu", SqlDbType.NVarChar).Value = pcv;
                cmd1.Parameters.Add("@Luong", SqlDbType.Float).Value = pluong;
                cmd1.Parameters.Add("@MaQL", SqlDbType.NVarChar).Value = pmnql;

                cmd1.Parameters.Add(new SqlParameter("@kiemtra", SqlDbType.Int));

                cmd1.Parameters["@kiemtra"].Direction = ParameterDirection.Output;

                cmd1.ExecuteNonQuery();

                kq = int.Parse(cmd1.Parameters["@kiemtra"].Value.ToString());
                
                conn.Close();

                return kq;

            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e);
                MessageBox.Show(e.StackTrace);
                return 0;
            }
            //finally
            //{
            //    //conn.Close();
            //    //conn.Dispose();
            //}
         
        }




        //public int xoa(string pManv)
        //{
        //    try
        //    {
        //        int kq = 0;
                
        //        if (ConnectionState.Closed == conn.State)
        //            conn.Open();
        //        SqlCommand cmd1 = new SqlCommand("XoaNV", conn);
        //        // Kiểu của Command là StoredProcedure
        //        cmd1.CommandType = CommandType.StoredProcedure;

        //        // Thêm tham số @p_Emp_Id và gán giá trị 100 cho nó.
        //        cmd1.Parameters.Add("@MaNV", SqlDbType.NVarChar).Value = pManv;

        //        cmd1.Parameters.Add(new SqlParameter("@kiemtra", SqlDbType.Int));

        //        cmd1.ExecuteNonQuery();

        //        kq = int.Parse(cmd1.Parameters["@kiemtra"].Value.ToString());

        //        MessageBox.Show(kq.ToString());
        //        conn.Close();
               
        //        return kq;
               
        //    }
        //    catch
        //    {
        //        return 0;
        //    }
        //}

        public int xoa(string pManv)
        {
            try
            {
                int kq = 0;

              
                SqlCommand cmd1 = new SqlCommand("XoaNV", conn);
                // Kiểu của Command là StoredProcedure
                cmd1.CommandType = CommandType.StoredProcedure;

                // Thêm tham số @p_Emp_Id và gán giá trị 100 cho nó.
                cmd1.Parameters.Add("@MaNV", SqlDbType.NVarChar).Value = pManv;

                cmd1.Parameters.Add(new SqlParameter("@kiemtra", SqlDbType.Int));

                cmd1.Parameters["@kiemtra"].Direction = ParameterDirection.Output;

                cmd1.ExecuteNonQuery();

                kq = int.Parse(cmd1.Parameters["@kiemtra"].Value.ToString());

                return kq;              
                
           }
            catch
            {
                //MessageBox.Show("Error: " + e);
                //MessageBox.Show(e.StackTrace);
                return 0;
            }
            //finally
            //{
            //   // conn.Close();
            //    //conn.Dispose();
            //}
 
        }

        //public int sua(string pManv, string pTennv, DateTime pngaysinh, DateTime pngayvaolam, string pmnql, string pgt, string pdc, string pcv, float pluong)
        //{
        //    try
        //    {

        //        da_nv = new SqlDataAdapter("select * from NHANVIEN", conn);
        //        // Ánh xạ dữ liệu từ DB vào dataset, đặt NHANVIEN
        //        DataRow dts = ds_nv.Tables["NHANVIEN"].Rows.Find(pManv);
        //        if (dts != null)
        //        {
        //            dts[1] = pTennv;
        //            dts[2] = pngaysinh;
        //            dts[3] = pngayvaolam;
        //            dts[4] = pgt;
        //            dts[5] = pdc;
        //            dts[6] = pluong;
        //            dts[7] = pcv;
        //            dts[8] = pmnql;
        //        }
        //        SqlCommandBuilder builda = new SqlCommandBuilder(da_nv);
        //        da_nv.Update(ds_nv, "NHANVIEN");
        //        return 1;
        //    }
        //    catch
        //    {
        //        return 0;
        //    }
        //}

        public string CapMaNhanVien()// cấp mã nhân viên
        {
            try
            {
                string kq ;

                SqlCommand cmd1 = new SqlCommand("TaoMaNV", conn);
                // Kiểu của Command là StoredProcedure
                cmd1.CommandType = CommandType.StoredProcedure;

                cmd1.Parameters.Add(new SqlParameter("@MaNV", SqlDbType.NVarChar,30));

                cmd1.Parameters["@MaNV"].Direction = ParameterDirection.Output;

                cmd1.ExecuteNonQuery();

                kq = cmd1.Parameters["@MaNV"].Value.ToString();

                return kq;

            }
            catch
            {
                //return 0;
                return null;
            }
        
        }

        public int sua(string pManv, string pTennv, DateTime pngaysinh, DateTime pngayvaolam, string pmnql, string pgt, string pdc, string pcv, float pluong)
        {
            try
            {
                int kq = 0;


                SqlCommand cmd1 = new SqlCommand("SUANV", conn);
                // Kiểu của Command là StoredProcedure
                cmd1.CommandType = CommandType.StoredProcedure;

                cmd1.Parameters.Add("@MaNV", SqlDbType.NVarChar).Value = pManv;
                cmd1.Parameters.Add("@TenNV", SqlDbType.NVarChar, 50).Value = pTennv;
                cmd1.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value = pgt;
                cmd1.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = pdc;
                cmd1.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = pngaysinh;
                cmd1.Parameters.Add("@NgayVaoLam", SqlDbType.Date).Value = pngayvaolam;
                cmd1.Parameters.Add("@ChucVu", SqlDbType.NVarChar).Value = pcv;
                cmd1.Parameters.Add("@Luong", SqlDbType.Float).Value = pluong;
                cmd1.Parameters.Add("@MaQL", SqlDbType.NVarChar).Value = pmnql;


                cmd1.Parameters.Add(new SqlParameter("@kiemtra", SqlDbType.Int));

                cmd1.Parameters["@kiemtra"].Direction = ParameterDirection.Output;

                cmd1.ExecuteNonQuery();

                kq = int.Parse(cmd1.Parameters["@kiemtra"].Value.ToString());

                return kq;

            }
            catch 
            {
                //MessageBox.Show("Error: " + e);
                //MessageBox.Show(e.StackTrace);
                return 0;
            }
        }
        public int luu()
        {
            SqlCommandBuilder duilda = new SqlCommandBuilder(da_nv);
            da_nv.Update(ds_nv, "NHANVIEN");
            return 1;
        }
        public DataTable TTNV(string manv)
        {
            SqlCommand cmd1 = new SqlCommand("SELECT * from dbo.XEMTT_NV(@MNV)", conn);          
            cmd1.Parameters.AddWithValue("@MNV", manv);
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            DataTable dt = new DataTable();
            da.Fill(dt); 
            DataTable x = dt;
            return x; 
        }
        public DataTable TTNV_2(string tennv)
        {
            SqlCommand cmd1 = new SqlCommand("SELECT * from dbo.XEMTT_NV_TNV(@TNV)", conn);
            cmd1.Parameters.AddWithValue("@TNV", tennv);
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataTable x = dt;
            return x;
        }
    }
}
