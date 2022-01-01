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
    public partial class frmQuanlyloaisach : Form
    {

        BUS_Loaisach busloaisach = new BUS_Loaisach();
        public frmQuanlyloaisach()
        {
            InitializeComponent();
            loadLoaisach();
        }

        public void loadLoaisach()
        {
            dgvLoaisach.DataSource = busloaisach.getListloaisach();
            btnSua.Enabled = btnXoa.Enabled = false;
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            dgvLoaisach.DataSource = busloaisach.getListloaisach();
        }

        private void dgvLoaisach_Click(object sender, EventArgs e)
        {
            int i = dgvLoaisach.CurrentRow.Index;
            txtMaloaisach.Text = dgvLoaisach[0, i].Value.ToString();
            txtTenloai.Text = dgvLoaisach[1, i].Value.ToString();
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
        }

        private void frmQuanlyloaisach_Activated(object sender, EventArgs e)
        {
            loadLoaisach();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            busloaisach.xoaLoaisach(long.Parse(txtMaloaisach.Text));
            MessageBox.Show("Xoá loại sách thành công", "Thông báo");
            loadLoaisach();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            busloaisach.suaLoaisach(long.Parse(txtMaloaisach.Text), txtTenloai.Text);
            MessageBox.Show("Sửa loại sách thành công", "Thông báo");
            loadLoaisach();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThemloaisach ql = new frmThemloaisach();
            ql.Show();
        }
    }
}
