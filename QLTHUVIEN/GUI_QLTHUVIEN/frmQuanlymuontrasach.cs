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
    public partial class frmQuanlymuontrasach : Form
    {
        BUS_Muonsach busmuonsach = new BUS_Muonsach();
        public frmQuanlymuontrasach()
        {
            InitializeComponent();
            loadMuontrasach();
        }

        public void loadMuontrasach()
        {
            dtNgaymuon.Enabled = dtHantra.Enabled = false;
            dgvMuonsach.DataSource = busmuonsach.getListmuonsach();
            btnMatsach.Enabled = btnTrasach.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            dgvMuonsach.DataSource = busmuonsach.timkiemBymathe(long.Parse(txtTimkiem.Text));
        }

        private void dgvMuonsach_Click(object sender, EventArgs e)
        {
            int i = dgvMuonsach.CurrentRow.Index;
            txtMamuonsach.Text = dgvMuonsach[0, i].Value.ToString();
            txtMasach.Text = dgvMuonsach[1, i].Value.ToString();
            txtTensach.Text = dgvMuonsach[2, i].Value.ToString();
            txtMaloai.Text = dgvMuonsach[3, i].Value.ToString();
            txtMathe.Text = dgvMuonsach[4, i].Value.ToString();
            dtNgaymuon.Value = DateTime.Parse(dgvMuonsach[5, i].Value.ToString());
            dtHantra.Value = DateTime.Parse(dgvMuonsach[6, i].Value.ToString());
            btnMatsach.Enabled = btnTrasach.Enabled = true;
        }

        private void btnTrasach_Click(object sender, EventArgs e)
        {
            busmuonsach.traSach(long.Parse(txtMamuonsach.Text), long.Parse(txtMasach.Text), false);
            DateTime now = DateTime.Now;
            int day = now.Subtract(DateTime.Parse(dtHantra.Text)).Days;
            if (now > DateTime.Parse(dtHantra.Text)) MessageBox.Show("Trả sách thành công, bị trễ hạn "+day.ToString()+" ngày", "Thông báo");
            else MessageBox.Show("Trả sách thành công", "Thông báo");
        }

        private void btnMatsach_Click(object sender, EventArgs e)
        {
            busmuonsach.traSach(long.Parse(txtMamuonsach.Text), long.Parse(txtMasach.Text), true);
            DateTime now = DateTime.Now;
            MessageBox.Show("Thu phí đền bù mất sách", "Thông báo");
        }

        private void btnMuonsach_Click(object sender, EventArgs e)
        {
            frmMuonsach ms = new frmMuonsach();
            ms.Show();
        }

        private void frmQuanlymuontrasach_Activated(object sender, EventArgs e)
        {
            loadMuontrasach();
        }
    }
}
