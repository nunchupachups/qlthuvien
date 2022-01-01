using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL_QLTHUVIEN
{
    public class DAL_Muonsach:DBConnection
    {
        public DataTable getListmuonsach()
        {
            string str = string.Format("select mamuonsach, muonsach.masach, tensach, maloai, mathe, ngaymuon, hantra from muonsach inner join sach on muonsach.masach=sach.masach inner join dausach on sach.madausach=dausach.madausach ");
            SqlDataAdapter dal = new SqlDataAdapter(str, con);
            DataTable dalSach = new DataTable();
            dal.Fill(dalSach);
            return dalSach;
        }

        public DataTable timkiemBymathe(long mathe)
        {
            string str = string.Format("select mamuonsach, masach, tensach, maloai, mathe, ngaymuon, hantra from sach inner join dausach on sach.madausach=dausach.madausach where mathe='{0}'", mathe);
            SqlDataAdapter dal = new SqlDataAdapter(str, con);
            DataTable dalSach = new DataTable();
            dal.Fill(dalSach);
            return dalSach;
        }

        public int tongsachBymathe(long mathe)
        {
            string str = string.Format("select count(*) as tong from muonsach where mathe='{0}'", mathe);
            SqlDataAdapter dal = new SqlDataAdapter(str, con);
            DataTable dalSach = new DataTable();
            dal.Fill(dalSach);
            int tong=int.Parse(dalSach.Rows[0]["tong"].ToString());
            return tong;
        }

        public bool traSach(long mamuonsach, long masach, bool matsach)
        {
            string str = string.Format("update sach set damuon = 0, matsach ='{1}' where masach='{0}'", masach, matsach);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
                con.Close();

                str = string.Format("delete from muonsach where mamuonsach='{0}'", mamuonsach);
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool muonSach(long mathe, long masach,DateTime ngaymuon)
        {
            string str = string.Format("update sach set damuon = 1 where masach='{0}'", masach);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
                con.Close();

                str = string.Format("select dausach.maloai from sach inner join dausach on dausach.madausach = sach.madausach inner join loaisach on dausach.maloai = loaisach.maloai where masach = '{0}'", masach);
                SqlDataAdapter dal = new SqlDataAdapter(str, con);
                DataTable dalSach = new DataTable();
                dal.Fill(dalSach);
                DateTime hantra = ngaymuon.AddMonths(1);
                if (dalSach.Rows[0]["maloai"].ToString().Equals("2")) hantra = ngaymuon.AddMonths(6);
                str = string.Format("insert into muonsach(masach, mathe, ngaymuon, hantra) values('{0}','{1}','{2}','{3}')", masach, mathe, ngaymuon, hantra);
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
