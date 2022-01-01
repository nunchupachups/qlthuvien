using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL_QLTHUVIEN
{
    public class DAL_The:DBConnection
    {
        public DataTable getListthe()
        {
            DataTable dalThe = new DataTable();
            string str = string.Format("select masinhvien as madocgia, hoten, sinhvien.mathe, ngaytao, hanthe from the inner join sinhvien on the.mathe = sinhvien.mathe");
            SqlDataAdapter dal = new SqlDataAdapter(str, con);
            dal.Fill(dalThe);
            int sv = dalThe.Rows.Count;


            str = string.Format("select magiangvien as madocgia, hoten, giangvien.mathe, ngaytao, hanthe from the inner join giangvien on the.mathe = giangvien.mathe");
            dal = new SqlDataAdapter(str, con);
            dal.Fill(dalThe);
            int gv = dalThe.Rows.Count;

            str = string.Format("select madocgia, hoten, docgiakhac.mathe, ngaytao, hanthe from the inner join docgiakhac on the.mathe = docgiakhac.mathe");
            dal = new SqlDataAdapter(str, con);
            dal.Fill(dalThe);
            int dg = dalThe.Rows.Count;



            dalThe.Columns.Add("doituong", typeof(string));
            for(int i = 0; i < dg; i++)
            {
                if (i < sv) {
                    dalThe.Rows[i]["doituong"] = "Sinh viên";
                    continue;
                }
                else if (i < gv)
                {
                    dalThe.Rows[i]["doituong"] = "Giảng viên";
                    continue;
                }
                else
                {
                    dalThe.Rows[i]["doituong"] = "Đọc giả khác";
                }
            }

            return dalThe;
        }

        public DataTable timkiemThebymathe(long mathe)
        {
            DataTable dalThe = new DataTable();
            string str = string.Format("select masinhvien as madoituong, hoten, sinhvien.mathe, ngaytao, " +
                "hanthe from the inner join sinhvien on the.mathe = sinhvien.mathe where the.mathe like '%{0}%'", mathe);
            SqlDataAdapter dal = new SqlDataAdapter(str, con);
            dal.Fill(dalThe);
            int sv = dalThe.Rows.Count;

            str = string.Format("select magiangvien as madoituong, hoten, giangvien.mathe, ngaytao, hanthe " +
                "from the inner join giangvien on the.mathe = giangvien.mathe where the.mathe like '%{0}%'", mathe);
            dal = new SqlDataAdapter(str, con);
            dal.Fill(dalThe);
            int gv = dalThe.Rows.Count;

            str = string.Format("select madocgia as madoituong, hoten, docgiakhac.mathe, ngaytao, hanthe from " +
                "the inner join docgiakhac on the.mathe = docgiakhac.mathe where the.mathe like '%{0}%'", mathe);
            dal = new SqlDataAdapter(str, con);
            dal.Fill(dalThe);
            int dg = dalThe.Rows.Count;

            dalThe.Columns.Add("doituong", typeof(string));
            for (int i = 0; i < dg; i++) dalThe.Rows[i]["doituong"] = "Sinh viên";
            for (int i = sv; i < gv; i++) dalThe.Rows[i]["doituong"] = "Giảng viên";
            for (int i = gv; i < dg; i++) dalThe.Rows[i]["doituong"] = "Đọc giả khác";

            return dalThe;
        }

        public bool xoaThe(long mathe)
        {
            string str = string.Format("delete from sinhvien where mathe = '{0}'", mathe);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();

                str = string.Format("delete from giangvien where mathe = '{0}'", mathe);
                cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();

                str = string.Format("delete from docgiakhac where mathe = '{0}'", mathe);
                cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();

                str = string.Format("delete from the where mathe = '{0}'", mathe);
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

        public bool giahanThe(long mathe)
        {

            string str = string.Format("select * from the where mathe = '{0}'", mathe);
            try
            {
                SqlDataAdapter dal = new SqlDataAdapter(str, con);
                DataTable dalthe = new DataTable();
                dal.Fill(dalthe);

                DateTime han = DateTime.Parse(dalthe.Rows[0]["hanthe"].ToString());

                han=han.AddMonths(6);
                str = string.Format("update the set hanthe='{0}' where mathe='{1}'",han, mathe);
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
        public bool taoThesinhvien(DateTime ngaytaothe, DateTime hanthe, string hoten, DateTime ngaysinh, string masinhvien, string makhoa)
        {

            string str = string.Format("insert into the(ngaytao, hanthe) values('{0}','{1}')",ngaytaothe, hanthe);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
                con.Close();

                str = string.Format("select top 1 mathe from the order by mathe desc");
                SqlDataAdapter dal = new SqlDataAdapter(str, con);
                DataTable dalthe = new DataTable();
                dal.Fill(dalthe);
                long mathe = long.Parse(dalthe.Rows[0]["mathe"].ToString());

                str = string.Format("insert into sinhvien(masinhvien, hoten, ngaysinh, makhoa, mathe) values('{0}',N'{1}', '{2}','{3}','{4}')", masinhvien, hoten, ngaysinh, makhoa, mathe);
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

        public bool taoThegiangvien(DateTime ngaytaothe, DateTime hanthe, string hoten, DateTime ngaysinh, string magiangvien, string makhoa)
        {

            string str = string.Format("insert into the(ngaytao, hanthe) values('{0}','{1}')", ngaytaothe, hanthe);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
                con.Close();

                str = string.Format("select top 1 mathe from the order by mathe desc");
                SqlDataAdapter dal = new SqlDataAdapter(str, con);
                DataTable dalthe = new DataTable();
                dal.Fill(dalthe);
                long mathe = long.Parse(dalthe.Rows[0]["mathe"].ToString());

                str = string.Format("insert into giangvien(magiangvien, hoten, ngaysinh, makhoa, mathe) values('{0}',N'{1}', '{2}','{3}','{4}')", magiangvien, hoten, ngaysinh, makhoa, mathe);
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

        public long taoThedocgiakhac(DateTime ngaytaothe, DateTime hanthe, string hoten, DateTime ngaysinh)
        {

            
            try
            {
                string str = string.Format("insert into the(ngaytao, hanthe) values('{0}','{1}')", ngaytaothe, hanthe);
                con.Open();
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
                con.Close();

                str = string.Format("select top 1 mathe from the order by mathe desc");
                SqlDataAdapter dal = new SqlDataAdapter(str, con);
                DataTable dalthe = new DataTable();
                dal.Fill(dalthe);
                long mathe = long.Parse(dalthe.Rows[0]["mathe"].ToString());

                str = string.Format("insert into docgiakhac(hoten, ngaysinh, mathe) values(N'{0}','{1}', '{2}')", hoten, ngaysinh,mathe);
                con.Open();
                cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
                con.Close();

                str = string.Format("select top 1 madocgia from docgiakhac order by madocgia desc");
                dal = new SqlDataAdapter(str, con);
                DataTable docgia = new DataTable();
                dal.Fill(docgia);
                long madocgia = long.Parse(docgia.Rows[0]["madocgia"].ToString());
                return madocgia;

            }
            catch
            {
                return 0;
            }
        }
    }
}
