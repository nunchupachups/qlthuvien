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
    public class BUS_Dausach
    {
        DAL_Dausach daldausach = new DAL_Dausach();
        public DataTable getListdausach()
        {
            return daldausach.getListdausach();
        }

        public DataTable timkiemBykey(string key)
        {
            return daldausach.timkiemBykey(key);
        }

        public bool themDausach(string tensach, string tacgia, string nhaxuatban, long maloai)
        {
            return daldausach.themDausach(tensach, tacgia, nhaxuatban, maloai);
        }

        public bool suaDausach(long madausach, string tensach, string tacgia, string nhaxuatban, long maloai)
        {
            return daldausach.suaDausach(madausach, tensach, tacgia, nhaxuatban, maloai);
        }

        public bool xoaDausach(long madausach)
        {
            return daldausach.xoaDausach(madausach);
        }
    }
}
