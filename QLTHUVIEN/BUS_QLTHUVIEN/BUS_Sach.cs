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
    public class BUS_Sach
    {
        DAL_Sach dalqlsach = new DAL_Sach();
        public DataTable getListsach()
        {
            return dalqlsach.getListsach();
        }

        public DataTable getListsachchuamuon()
        {
            return dalqlsach.getListsachchuamuon();
        }

        public DataTable timkiemBykey(string key)
        {
            return dalqlsach.timkiemBykey(key);
        }

        public bool themSach(long madausach, string tinhtrang)
        {
            return dalqlsach.themSach(madausach, tinhtrang);
        }

        public bool suaSach(long masach, long madausach, string tinhtrang, bool matsach, bool damuon)
        {
            return dalqlsach.suaSach(masach, madausach, tinhtrang, matsach, damuon);
        }

        public bool xoaSach(long masach)
        {
            return dalqlsach.xoaSach(masach);
        }
    }
}
