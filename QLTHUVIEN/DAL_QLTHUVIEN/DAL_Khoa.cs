using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL_QLTHUVIEN
{
    public class DAL_Khoa:DBConnection
    {
        public DataTable getListkhoa()
        {
            DataTable dalkhoa = new DataTable();
            string str = string.Format("select * from khoa");
            SqlDataAdapter dal = new SqlDataAdapter(str, con);
            dal.Fill(dalkhoa);
            return dalkhoa;
        }
    }
}
