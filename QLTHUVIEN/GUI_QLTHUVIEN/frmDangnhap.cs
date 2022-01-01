using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using BUS_QLTHUVIEN;

namespace GUI_QLTHUVIEN
{
    public partial class frmDangnhap : Form
    {
        BUS_Nhanvien busnhanvien = new BUS_Nhanvien();
        public frmDangnhap()
        {
            InitializeComponent();
            txtUsername.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "")
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu trống", "Thông báo");
            else if (busnhanvien.ktdn(txtUsername.Text, txtPassword.Text).Rows.Count > 0)
            {
                mySave.KT = !mySave.KT;
                DataTable user = busnhanvien.ktdn(txtUsername.Text, txtPassword.Text);
                MessageBox.Show("Đăng nhập thành công!", "Thông báo");
                Close();
            }
            else MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Thông báo");
        }
    }
}
