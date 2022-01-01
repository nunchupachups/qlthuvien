using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL_QLTHUVIEN
{
    public class DAL_Sach:DBConnection
    {
        public DataTable getListsach()
        {
            string str = string.Format("select masach, sach.madausach, tensach, tacgia, nhaxuatban, tinhtrang, damuon, matsach " +
                "from sach inner join dausach on sach.madausach = dausach.madausach ");
            SqlDataAdapter dal = new SqlDataAdapter(str, con);
            DataTable dalSach = new DataTable();
            dal.Fill(dalSach);
            return dalSach;
        }

        public DataTable getListsachchuamuon()
        {
            string str = string.Format("select masach, sach.madausach, tensach, tacgia, nhaxuatban, tinhtrang, damuon, matsach " +
                "from sach inner join dausach on sach.madausach = dausach.madausach where damuon='{0}'",0);
            SqlDataAdapter dal = new SqlDataAdapter(str, con);
            DataTable dalSach = new DataTable();
            dal.Fill(dalSach);
            return dalSach;
        }

        public DataTable timkiemBykey(string key)
        {
            string str = string.Format("select masach, sach.madausach, tensach, tacgia, nhaxuatban, tinhtrang, damuon, matsach " +
                "from sach inner join dausach on sach.madausach = dausach.madausach " +
                "where tensach like '%{0}%' or tacgia like '%{1}%' or nhaxuatban like '%{2}%' ", key, key, key);
            SqlDataAdapter dal = new SqlDataAdapter(str, con);
            DataTable dalSach = new DataTable();
            dal.Fill(dalSach);
            return dalSach;
        }

        public bool themSach(long madausach, string  tinhtrang)
        {
            string str = string.Format("insert into sach(madausach, tinhtrang, matsach, damuon) values('{0}', N'{1}','{2}','{3}')", madausach, tinhtrang, 0, 0);
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

        public bool suaSach(long masach, long madausach, string tinhtrang, bool matsach, bool damuon)
        {
            string str = string.Format("update sach set madausach='{0}', tinhtrang=N'{1}', matsach='{2}', damuon='{3}' where masach='{4}')", madausach, tinhtrang, matsach, damuon, masach);
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

        public bool xoaSach(long masach)
        {
            string str = string.Format("delete from sach where masach = '{0}'", masach);
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
