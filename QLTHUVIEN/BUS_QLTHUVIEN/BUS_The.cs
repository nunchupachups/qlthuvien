using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAL_QLTHUVIEN;

namespace BUS_QLTHUVIEN
{
    public class BUS_The
    {
        DAL_The dalthe = new DAL_The();
        public DataTable getListthe()
        {
            return dalthe.getListthe();
        }

        public DataTable timkiemThebymathe(long mathe)
        {
            return dalthe.timkiemThebymathe(mathe);
        }

        public bool xoaThe(long mathe)
        {
            return dalthe.xoaThe(mathe);
        }

        public bool giahanThe(long mathe)
        {
            return dalthe.giahanThe(mathe);
        }

        public bool taoThesinhvien(DateTime ngaytaothe, DateTime hanthe, string hoten, DateTime ngaysinh, string masinhvien, string makhoa)
        {
            return dalthe.taoThesinhvien(ngaytaothe, hanthe, hoten, ngaysinh, masinhvien, makhoa);
        }

        public bool taoThegiangvien(DateTime ngaytaothe, DateTime hanthe, string hoten, DateTime ngaysinh, string magiangvien, string makhoa)
        {
            return dalthe.taoThegiangvien(ngaytaothe, hanthe, hoten, ngaysinh, magiangvien, makhoa);
        }

        public long taoThedocgiakhac(DateTime ngaytaothe, DateTime hanthe, string hoten, DateTime ngaysinh)
        {
            return dalthe.taoThedocgiakhac(ngaytaothe, hanthe, hoten, ngaysinh);
        }
    }
}
