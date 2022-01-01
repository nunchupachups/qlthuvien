using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL_QLTHUVIEN
{
    public class DAL_Loaisach:DBConnection
    {
        public DataTable getListloaisach()
        {
            string str = string.Format("select * from loaisach ");
            SqlDataAdapter dal = new SqlDataAdapter(str, con);
            DataTable dalLoaisach = new DataTable();
            dal.Fill(dalLoaisach);
            return dalLoaisach;
        }

        public String gettenloaiByma(long maloai)
        {
            string str = string.Format("select tenloai from loaisach where maloai='{0}'", maloai);
            SqlDataAdapter dal = new SqlDataAdapter(str, con);
            DataTable dalLoaisach = new DataTable();
            dal.Fill(dalLoaisach);
            return dalLoaisach.Rows[0]["tenloai"].ToString();
        }

        public DataTable timkiemBykey(string key)
        {
            string str = string.Format("select * from loaisach where tenloai like '%{0}%'", key);
            SqlDataAdapter dal = new SqlDataAdapter(str, con);
            DataTable dalLoaisach = new DataTable();
            dal.Fill(dalLoaisach);
            return dalLoaisach;
        }

        public bool themLoaisach(string tenloai)
        {
            string str = string.Format("insert into loaisach(tenloai) values(N'{0}')", tenloai);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool suaLoaisach(long maloai, string tenloai)
        {
            string str = string.Format("update loaisach set tenloai=N'{0}' where maloai='{1}')", tenloai, maloai);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch
            {
                return false;
            }
            return true;
        }
        public bool xoaLoaisach(long maloai)
        {
            string str = string.Format("delete from loaisach where maloai = '{0}'", maloai);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
