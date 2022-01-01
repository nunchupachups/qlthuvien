using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BUS_QLTHUVIEN;

namespace GUI_QLTHUVIEN
{
    public partial class frmThemsach : Form
    {
        BUS_Sach bussach = new BUS_Sach();
        BUS_Dausach busdausach = new BUS_Dausach();
        public frmThemsach()
        {
            InitializeComponent();
            DataTable dausach = busdausach.getListdausach();
            for (int i = 0; i < dausach.Rows.Count; i++) cbbMadausach.Items.Add(dausach.Rows[i]["madausach"]);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnThemsach_Click(object sender, EventArgs e)
        {
            if (txtTinhtrang.Text.Trim().Equals("") || txtTinhtrang == null || cbbMadausach.Text.Equals("")||cbbMadausach==null) MessageBox.Show("Bạn phải nhập đầy đủ thông tin", "Thông báo");
            else
            {
                bussach.themSach(long.Parse(cbbMadausach.Text), txtTinhtrang.Text);
                MessageBox.Show("Thêm sách thành công", "Thông báo");
                Close();
            }
        }
    }
}
