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
    public partial class frmThemdausach : Form
    {
        BUS_Dausach busdausach = new BUS_Dausach();
        BUS_Loaisach busloaisach = new BUS_Loaisach();
        public frmThemdausach()
        {
            InitializeComponent();
            DataTable loaisach = busloaisach.getListloaisach();
            for (int i = 0; i < loaisach.Rows.Count; i++) cbbMaloai.Items.Add(loaisach.Rows[i]["maloai"]);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtTensach.Text.Trim().Equals("")||txtTensach==null||txtTacgia.Text.Trim().Equals("")||txtTacgia==null||txtNhaxuatban.Text.Trim().Equals("")||txtNhaxuatban==null||cbbMaloai==null||cbbMaloai.Text.Trim().Equals("")) MessageBox.Show("Bạn phải nhập đầy đủ thông tin", "Thông báo");
            else
            {
                busdausach.themDausach(txtTensach.Text, txtTacgia.Text, txtNhaxuatban.Text, long.Parse(cbbMaloai.Text));
                MessageBox.Show("Thêm đầu sách thành công", "Thông báo");
                Close();
            }
        }

        private void cbbMaloai_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTenloai.Text = busloaisach.gettenloaiByma(long.Parse(cbbMaloai.Text));
        }
    }
}
