using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeAnHQTCSDL_qlthuvien
{
    class Sach:ConectToDataBase
    {
        public DataSet ds_sach = new DataSet();
        public SqlDataAdapter da_sach;
        public Sach()
        {
           LoadBangSach();
        }
        public DataTable LoadBangSach()
        {
            da_sach = new SqlDataAdapter("select * from SACH", conn);
            // Ánh xạ dữ liệu từ DB vào dataset, đặt tên Sach
            da_sach.Fill(ds_sach, "SACH");
            //Set Khóa chính
            DataColumn[] khoachinh = new DataColumn[1];
            khoachinh[0] = ds_sach.Tables["SACH"].Columns[0];
            ds_sach.Tables["SACH"].PrimaryKey = khoachinh;

            return ds_sach.Tables["SACH"];
        }

        public DataTable LoadBangSach_GhepBang()
        {
            SqlDataAdapter daSach_ghepbang = new SqlDataAdapter("Select SACH.MASH,SACH.TENSH,SACH.MALOAISH,SACH.NAMXB,SACH.GIATIEN,SACH.TENTG,NHAXUATBAN.TENNXB,LOAISACH.TENLOAISH,SACH.SOLUONG From SACH,NHAXUATBAN,LOAISACH where SACH.MALOAISH=LOAISACH.MALOAISH AND SACH.MANXB=NHAXUATBAN.MANXB ", conn);
            daSach_ghepbang.Fill(ds_sach, "Sach_ghep");
            return ds_sach.Tables["Sach_ghep"];
        }

        public DataTable LoadBangLoaiSach()
        {
            SqlDataAdapter daLoaisach = new SqlDataAdapter("Select TENLOAISH from LOAISACH", conn);
            daLoaisach.Fill(ds_sach, "LOAISACH");
            return ds_sach.Tables["LOAISACH"];
        }

        public DataTable LoadBangNhaXuatBan()
        {
            SqlDataAdapter daSach = new SqlDataAdapter("Select TENNXB from NHAXUATBAN", conn);
            daSach.Fill(ds_sach, "NHAXUATBAN");
            return ds_sach.Tables["NHAXUATBAN"];
        }

        public int them(string pMasach, string pTensach, string pTenTG, string pNamxb, float pGiatien, string pMaNXB, string pMATL,int pSoluong)
        {
            try
            {
                da_sach = new SqlDataAdapter("select * from SACH", conn);
                // Ánh xạ dữ liệu từ DB vào dataset, đặt tên Sach
                da_sach.Fill(ds_sach, "SACH");

                if (KTKC(pMasach) == true)
                    return 2;
                else
                {
                    DataRow dtThem = ds_sach.Tables["SACH"].NewRow();
                    dtThem[0] = pMasach;
                    dtThem[1] = pTensach;
                    dtThem[2] = pTenTG;
                    dtThem[3] = pMaNXB;
                    dtThem[4] = pNamxb;
                    dtThem[5] = pMATL;
                    dtThem[6] = pSoluong;
                    dtThem[7] = pGiatien;
                    ds_sach.Tables["SACH"].Rows.Add(dtThem);
                    SqlCommandBuilder builda = new SqlCommandBuilder(da_sach);
                    da_sach.Update(ds_sach, "SACH");
                    return 1;
                }
            }
            catch
            {
                return 0;
            }
        }

        public string layMANXB(string pbien)
        {

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand("select * from NHAXUATBAN where TENNXB=N'" + pbien + "'", conn);
            SqlDataReader dr = cmd.ExecuteReader();

            string kq = " ";
            while (dr.Read())
            {
                kq = dr["MANXB"].ToString();
            }
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            return kq;
        }
        public string layMALOAISH(string pbien)
        {

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand("select * from LOAISACH where TENLOAISH=N'" + pbien + "'", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            string kq = " ";
            while (dr.Read())
            {
                kq = dr["MALOAISH"].ToString();
            }
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            return kq;
        }
        public bool KTKC(string pMasach)
        {
            return KTKC_New(pMasach, ds_sach.Tables["SACH"]);
        }
        public int xoa(string pMasach)
        {
            try
            {

                da_sach = new SqlDataAdapter("select * from SACH", conn);
                // Ánh xạ dữ liệu từ DB vào dataset, đặt tên Sach
                DataRow dtx = ds_sach.Tables["SACH"].Rows.Find(pMasach);
                if (dtx != null)
                {
                    dtx.Delete();
                }
                SqlCommandBuilder builda = new SqlCommandBuilder(da_sach);
                da_sach.Update(ds_sach, "SACH");
                return 1;

            }
            catch
            {
                return 0;
            }
        }
        public int sua(string pMasach, string pTensach, string pTenTG, string pNamxb, float pGiatien, string pMaNXB, string pMATL,int pSoluong)
        {
            try
            {

                da_sach = new SqlDataAdapter("select * from SACH", conn);
                // Ánh xạ dữ liệu từ DB vào dataset, đặt tên Sach
                DataRow dts = ds_sach.Tables["SACH"].Rows.Find(pMasach);
                if (dts != null)
                {
                    dts[1] = pTensach;
                    dts[2] = pTenTG;
                    dts[3] = pMaNXB;
                    dts[4] = pNamxb;
                    dts[5] = pMATL;
                    dts[6] = pSoluong;
                    dts[7] = pGiatien;
                }
                SqlCommandBuilder builda = new SqlCommandBuilder(da_sach);
                da_sach.Update(ds_sach, "SACH");
                return 1;
            }
            catch
            {
                return 0;
            }
        }
        public DataTable ttsach(string tensach)
        {
            SqlCommand cmd1 = new SqlCommand("SELECT * from dbo.DSSACH_TENSACH(@TS)", conn);
            cmd1.Parameters.AddWithValue("@TS", tensach);
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataTable x = dt;
            return x;
        }
    }
}

