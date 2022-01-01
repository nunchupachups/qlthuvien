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
    public partial class frmquanlysach : Form
    {
        BUS_Sach bussach = new BUS_Sach();
        BUS_Dausach busdausach = new BUS_Dausach();
        public frmquanlysach()
        {
            InitializeComponent();
            loadSach();
        }

        public void loadSach()
        {
            dgvSach.DataSource = bussach.getListsach();
            btnSuasach.Enabled = btnXoasach.Enabled = false;
            DataTable dausach = busdausach.getListdausach();
            for (int i = 0; i < dausach.Rows.Count; i++) cbbMadausach.Items.Add(dausach.Rows[i]["madausach"]);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            dgvSach.DataSource = bussach.timkiemBykey(txtTimkiem.Text);
        }

        private void dgvSach_Click(object sender, EventArgs e)
        {
            int i = dgvSach.CurrentRow.Index;
            txtMasach.Text = dgvSach[0, i].Value.ToString();
            cbbMadausach.Text = dgvSach[1, i].Value.ToString();
            txtTensach.Text = dgvSach[2, i].Value.ToString();
            txtTacgia.Text = dgvSach[3, i].Value.ToString();
            txtNhaxuatban.Text = dgvSach[4, i].Value.ToString();
            txtTinhtrang.Text = dgvSach[5, i].Value.ToString();
            txtDamuon.Text = dgvSach[6, i].Value.ToString();
            txtMatsach.Text = dgvSach[7, i].Value.ToString();
            btnThemsach.Enabled = btnSuasach.Enabled = btnXoasach.Enabled = true;
        }

        private void btnXoasach_Click(object sender, EventArgs e)
        {
            bussach.xoaSach(long.Parse(txtMasach.Text));
            MessageBox.Show("Xoá sách thành công", "Thông báo");
            loadSach();
        }

        private void btnSuasach_Click(object sender, EventArgs e)
        {
            bussach.suaSach(long.Parse(txtMasach.Text), long.Parse(cbbMadausach.Text), txtTinhtrang.Text, Boolean.Parse(txtMatsach.Text), Boolean.Parse(txtDamuon.Text));
            MessageBox.Show("Sửa sách thành công", "Thông báo");
            loadSach();
        }

        private void btnThemsach_Click(object sender, EventArgs e)
        {
            frmThemsach ts = new frmThemsach();
            ts.Show();
        }

        private void frmquanlysach_Activated(object sender, EventArgs e)
        {
            loadSach();
        }
    }
}
