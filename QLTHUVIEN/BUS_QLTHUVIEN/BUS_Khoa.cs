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
    public class BUS_Khoa
    {
        DAL_Khoa dalKhoa = new DAL_Khoa();
        public DataTable getListkhoa()
        {
            return dalKhoa.getListkhoa();
        }
    }
}
