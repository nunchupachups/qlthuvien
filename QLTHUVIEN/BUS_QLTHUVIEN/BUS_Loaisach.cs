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
    public class BUS_Loaisach
    {
        DAL_Loaisach dalloaisach = new DAL_Loaisach();
        public DataTable getListloaisach()
        {
            return dalloaisach.getListloaisach();
        }

        public String gettenloaiByma(long maloai)
        {
            return dalloaisach.gettenloaiByma(maloai);
        }

        public DataTable timkiemBykey(string key)
        {
            return dalloaisach.timkiemBykey(key);
        }

        public bool xoaLoaisach(long maloai)
        {
            return dalloaisach.xoaLoaisach(maloai);
        }

        public bool suaLoaisach(long maloai, string tenloai)
        {
            return dalloaisach.suaLoaisach(maloai, tenloai);
        }

        public bool themLoaisach(string tenloai)
        {
            return dalloaisach.themLoaisach(tenloai);
        }
    }
}
