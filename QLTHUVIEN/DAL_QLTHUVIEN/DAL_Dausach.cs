using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL_QLTHUVIEN
{
    public class DAL_Dausach:DBConnection
    {
        public DataTable getListdausach()
        {
            string str = string.Format("select madausach, tensach, tacgia, nhaxuatban, dausach.maloai, tenloai from dausach inner join loaisach on dausach.maloai= loaisach.maloai");
            SqlDataAdapter dal = new SqlDataAdapter(str, con);
            DataTable dalDausach = new DataTable();
            dal.Fill(dalDausach);
            return dalDausach;
        }

        public DataTable timkiemBykey(string key)
        {
            string str = string.Format("select madausach, tensach, tacgia, nhaxuatban, dausach.maloai, tenloai from dausach inner join loaisach on dausach.maloai= loaisach.maloai where tensach like '%{0}%' or tacgia like '%{1}%' or nhaxuatban like '%{2}%' or tenloai like '%{3}%'", key, key, key, key);
            SqlDataAdapter dal = new SqlDataAdapter(str, con);
            DataTable dalDausach = new DataTable();
            dal.Fill(dalDausach);
            return dalDausach;
        }

        public bool themDausach(string tensach, string tacgia, string nhaxuatban, long maloai)
        {
            string str = string.Format("insert into dausach(tensach, tacgia, nhaxuatban, maloai) values(N'{0}', N'{1}',N'{2}', '{3}')", tensach, tacgia, nhaxuatban, maloai);
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

        public bool suaDausach(long madausach, string tensach, string tacgia, string nhaxuatban, long maloai)
        {
            string str = string.Format("update dausach set tensach=N'{0}', tacgia=N'{1}', nhaxuatban=N'{2}', maloai='{3}' where madausach='{4}')", tensach, tacgia, nhaxuatban, maloai, madausach);
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

        public bool xoaDausach(long madausach)
        {
            string str = string.Format("delete from sach where madausach = '{0}'", madausach);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
                con.Close();
                str = string.Format("delete from dausach where madausach = '{0}'", madausach);
                con.Open();
                cmd = new SqlCommand(str, con);
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
