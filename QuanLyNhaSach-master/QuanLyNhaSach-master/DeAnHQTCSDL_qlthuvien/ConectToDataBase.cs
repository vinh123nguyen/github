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
    public class ConectToDataBase
    {
        public static SqlConnection conn;
        //public static string Chuoinoi = @"Data Source=.\SQLEXPRESS;Initial Catalog=QLNHASACH; User id=sa;Password=sa2012";
        ///public static string Chuoinoi = "";
        public ConectToDataBase()
        {
            conn = new SqlConnection(@"Data Source=PC-PC\SQLEXPRESS;Initial Catalog=QLNHASACH;Integrated Security=True");
            if (conn.State == ConnectionState.Closed)
                conn.Open();
        }

        public ConectToDataBase(string chuoi)
        {
            conn = new SqlConnection(chuoi);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
        }

        public bool KTKC_New(string pKhoaChinh, DataTable pdt)
        {
            DataRow dtKiemTra = pdt.Rows.Find(pKhoaChinh);

            if (dtKiemTra != null)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
