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
    public partial class frmQuanlythe : Form
    {
        BUS_The busthe = new BUS_The();
        public frmQuanlythe()
        {
            InitializeComponent();
            loadThe();
        }

        public void loadThe()
        {
            dgvThe.DataSource = busthe.getListthe();
            txtTimkiem.Text = "";
            txtMathe.Text = "";
            txtMadocgia.Text = "";
            dtNgaytaothe.Text = "";
            dtHanthe.Text = "";
            btnXoathe.Enabled = btnGiahanthe.Enabled = false;
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            if (!txtTimkiem.Text.Equals(""))
            {
                dgvThe.DataSource = busthe.timkiemThebymathe(long.Parse(txtTimkiem.Text));
            }
        } 

        private void dgvThe_Click(object sender, EventArgs e)
        {
            int i= dgvThe.CurrentRow.Index;
            txtMadocgia.Text = dgvThe[0, i].Value.ToString();
            txtHoten.Text= dgvThe[1, i].Value.ToString();
            txtMathe.Text = dgvThe[2, i].Value.ToString();
            dtNgaytaothe.Text = dgvThe[3, i].Value.ToString();
            dtHanthe.Text = dgvThe[4, i].Value.ToString();
            btnXoathe.Enabled = btnGiahanthe.Enabled = true;
        }

        private void btnXoathe_Click(object sender, EventArgs e)
        {
            busthe.xoaThe(long.Parse(txtMathe.Text));
            MessageBox.Show("Xoá thẻ thành công", "Thông báo");
            loadThe();
        }

        private void btnGiahanthe_Click(object sender, EventArgs e)
        {
            busthe.giahanThe(long.Parse(txtMathe.Text));
            MessageBox.Show("Đã gia hạn thẻ thêm 6 tháng", "Thông báo");
            loadThe();
        }
       
        private void btnTaothe_Click(object sender, EventArgs e)
        {
            frmTaothe tt= new frmTaothe();
            tt.Show();
        }

        private void frmQuanlythe_Activated(object sender, EventArgs e)
        {
            loadThe();
        }
    }
}
