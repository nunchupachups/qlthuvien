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
    public partial class frmQuanlydausach : Form
    {
        BUS_Dausach busdausach = new BUS_Dausach();
        BUS_Loaisach busloaisach = new BUS_Loaisach();

        public frmQuanlydausach()
        {
            InitializeComponent();
            loadDausach();
        }

        public void loadDausach()
        {
            dgvDausach.DataSource = busdausach.getListdausach();
            btnSua.Enabled = btnXoa.Enabled = false;
            DataTable loaisach = busloaisach.getListloaisach();
            for (int i = 0; i < loaisach.Rows.Count; i++) cbbMaloai.Items.Add(loaisach.Rows[i]["maloai"]);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            dgvDausach.DataSource = busdausach.timkiemBykey(txtTimkiem.Text);
        }

        private void dgvDausach_Click(object sender, EventArgs e)
        {
            int i = dgvDausach.CurrentRow.Index;
            txtMadausach.Text = dgvDausach[0, i].Value.ToString();
            txtTensach.Text = dgvDausach[1, i].Value.ToString();
            txtTacgia.Text = dgvDausach[2, i].Value.ToString();
            txtNhaxuatban.Text = dgvDausach[3, i].Value.ToString();
            cbbMaloai.Text = dgvDausach[4, i].Value.ToString();
            txtTenloai.Text = dgvDausach[5, i].Value.ToString();
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
        }

        private void frmQuanlydausach_Activated(object sender, EventArgs e)
        {
            loadDausach();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            busdausach.xoaDausach(long.Parse(txtMadausach.Text));
            MessageBox.Show("Xoá đầu sách thành công", "Thông báo");
            loadDausach();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            busdausach.suaDausach(long.Parse(txtMadausach.Text), txtTensach.Text, txtTacgia.Text, txtNhaxuatban.Text, long.Parse(cbbMaloai.Text));
            MessageBox.Show("Sửa đầu sách thành công", "Thông báo");
            loadDausach();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThemdausach ql = new frmThemdausach();
            ql.Show();
        }

        private void cbbMaloai_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTenloai.Text = busloaisach.gettenloaiByma(long.Parse(cbbMaloai.Text));
        }
    }
}
