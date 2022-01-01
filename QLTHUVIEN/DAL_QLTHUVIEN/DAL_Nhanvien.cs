using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL_QLTHUVIEN
{
    public class DAL_Nhanvien:DBConnection
    {
        public DataTable ktdn(string username, string password)
        {
            string str = string.Format("select * from nhanvien where tendangnhap='{0}' and matkhau='{1}'", username, password);
            SqlDataAdapter dal = new SqlDataAdapter(str, con);
            DataTable dalNhanvien = new DataTable();
            dal.Fill(dalNhanvien);
            return dalNhanvien;
        }
    }
}
