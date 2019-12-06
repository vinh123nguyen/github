using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DeAnHQTCSDL_qlthuvien; 

namespace Doan.Class
{
    class Class_loaisach : ConectToDataBase
    {
        public DataSet ds_ls = new DataSet();
        public SqlDataAdapter da_ls;
        public Class_loaisach()
        {
            da_ls = new SqlDataAdapter("select * from LOAISACH", conn);
            LoadBangLoaiSach();
        }
        public DataTable LoadBangLoaiSach()
        {
            da_ls = new SqlDataAdapter("select * from LOAISACH", conn);
            // Ánh xạ dữ liệu từ DB vào dataset, đặt tên Sach
            da_ls.Fill(ds_ls, "LOAISACH");
            //Set Khóa chính
            DataColumn[] khoachinh = new DataColumn[1];
            khoachinh[0] = ds_ls.Tables["LOAISACH"].Columns[0];
            ds_ls.Tables["LOAISACH"].PrimaryKey = khoachinh;
            return ds_ls.Tables["LOAISACH"];
        }
        
        public bool KTKC(string pMaloai)
        {
            return KTKC_New(pMaloai, ds_ls.Tables["LOAISACH"]);
        }
        public int them(string pMaloai, string pTenloai)
        {
            try
            {

                da_ls = new SqlDataAdapter("select * from LOAISACH", conn);
                // Ánh xạ dữ liệu từ DB vào dataset, đặt tên LOAISACH
                da_ls.Fill(ds_ls, "LOAISACH");

                if (KTKC(pMaloai) == true)
                {
                    return 2;
                }
                else
                {
                    DataRow dtThem = ds_ls.Tables["LOAISACH"].NewRow();
                    dtThem[0] = pMaloai;
                    dtThem[1] = pTenloai;
                    ds_ls.Tables["LOAISACH"].Rows.Add(dtThem);
                    SqlCommandBuilder builda = new SqlCommandBuilder(da_ls);
                    da_ls.Update(ds_ls, "LOAISACH");
                    return 1;
                }
            }
            catch
            {
                return 0;
            }
        }
        public int xoa(string pMaloai)
        {
            try
            {

                da_ls = new SqlDataAdapter("select * from LOAISACH", conn);
                // Ánh xạ dữ liệu từ DB vào dataset, đặt tên Sach
                DataRow dtx = ds_ls.Tables["LOAISACH"].Rows.Find(pMaloai);
                if (dtx != null)
                {
                    dtx.Delete();
                }
                SqlCommandBuilder builda = new SqlCommandBuilder(da_ls);
                da_ls.Update(ds_ls, "LOAISACH");
                return 1;

            }
            catch
            {
                return 0;
            }
        }
        public int sua(string pMaloai, string pTenloai)
        {
            try
            {

                da_ls = new SqlDataAdapter("select * from LOAISACH", conn);
                // Ánh xạ dữ liệu từ DB vào dataset, đặt tên Sach
                DataRow dts = ds_ls.Tables["LOAISACH"].Rows.Find(pMaloai);
                if (dts != null)
                {
                    dts[1] = pTenloai;
                }
                SqlCommandBuilder builda = new SqlCommandBuilder(da_ls);
                da_ls.Update(ds_ls, "LOAISACH");
                return 1;
            }
            catch
            {
                return 0;
            }
        }
        public DataTable TTLS(string mals)
        {
            SqlCommand cmd1 = new SqlCommand("SELECT * from dbo.XEMTT_LS(@Mls)", conn);
            cmd1.Parameters.AddWithValue("@Mls", mals);
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataTable x = dt;
            return x;
        }
        public DataTable TTLS_2(string tenls)
        {
            SqlCommand cmd1 = new SqlCommand("SELECT * from dbo.XEMTT_LS_TLS(@tls)", conn);
            cmd1.Parameters.AddWithValue("@tls", tenls);
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataTable x = dt;
            return x;
        }
    }
}
