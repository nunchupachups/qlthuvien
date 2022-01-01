using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_QLTHUVIEN;

namespace GUI_QLTHUVIEN
{
    public partial class frmThemloaisach : Form
    {
        BUS_Loaisach busloai = new BUS_Loaisach();
        public frmThemloaisach()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtTenloai.Text.Trim().Equals("")||txtTenloai==null) MessageBox.Show("Bạn phải nhập đầy đủ thông tin", "Thông báo");
            else
            {
                busloai.themLoaisach(txtTenloai.Text);
                MessageBox.Show("Thêm loại sách thành công", "Thông báo");
                Close();
            }
        }
    }
}
