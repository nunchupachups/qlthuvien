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
    public class BUS_Muonsach
    {
        DAL_Muonsach dalmuonsach = new DAL_Muonsach();
        public DataTable getListmuonsach()
        {
            return dalmuonsach.getListmuonsach();
        }

        public DataTable timkiemBymathe(long mathe)
        {
            return dalmuonsach.timkiemBymathe(mathe);
        }

        public bool traSach(long mamuonsach, long masach, bool matsach)
        {
            return dalmuonsach.traSach(mamuonsach, masach, matsach);
        }

        public bool muonSach(long mathe, long masach, DateTime ngaymuon)
        {
            return dalmuonsach.muonSach(mathe, masach, ngaymuon);
        }

        public int tongsachBymathe(long mathe)
        {
            return dalmuonsach.tongsachBymathe(mathe);
        }
    }
}
