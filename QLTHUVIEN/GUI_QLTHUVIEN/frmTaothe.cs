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
    public partial class frmTaothe : Form
    {
        BUS_Khoa buskhoa = new BUS_Khoa();
        BUS_The busthe = new BUS_The();
        public frmTaothe()
        {
            InitializeComponent();
            loadTaothe();
        }
        public void loadTaothe()
        {
            dtNgaytaothe.Value = DateTime.Now;
            dtHanthe.Value = dtNgaytaothe.Value.AddMonths(6);
            DataTable khoa = buskhoa.getListkhoa();
            for(int i = 0; i < khoa.Rows.Count;i++)
            {
                cbbMakhoa1.Items.Add(khoa.Rows[i]["makhoa"].ToString());
                cbbMakhoa2.Items.Add(khoa.Rows[i]["makhoa"].ToString());
            }
            txtHoten.Text =txtMasinhvien.Text = txtGiangvien.Text = "";
            radSinhvien.Checked = true;
            radGiangvien.Checked = radDocgiakhac.Checked = false;
            grbgiangvien.Visible = false;
            grbsinhvien.Visible = true;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void radGiangvien_Click(object sender, EventArgs e)
        {
            radSinhvien.Checked = radDocgiakhac.Checked = false;
            radGiangvien.Checked = true;
            grbgiangvien.Visible = true;
            grbsinhvien.Visible = false;
        }

        private void radSinhvien_Click(object sender, EventArgs e)
        {
            radDocgiakhac.Checked = radGiangvien.Checked = grbgiangvien.Visible = false;
            radSinhvien.Checked = grbsinhvien.Visible = true;
        }

        private void radDocgiakhac_Click(object sender, EventArgs e)
        {
            radDocgiakhac.Checked = true;
            radSinhvien.Checked = grbsinhvien.Visible = radGiangvien.Checked = grbgiangvien.Visible = false;
        }

        private void btnTaothe_Click(object sender, EventArgs e)
        {
            if (txtHoten.Text.Trim().Equals(""))
            {
                MessageBox.Show("Họ tên không được để trống", "Thông báo");
                txtHoten.Focus();
            }
            else if(dtNgaysinh.Text.Equals("")||dtNgaysinh==null)
            {
                MessageBox.Show("Ngày sinh không được để trống", "Thông báo");
                dtNgaysinh.Focus();
            }
            else if (radSinhvien.Checked)
            {
                if (txtMasinhvien==null||txtMasinhvien.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Mã sinh viên không được để trống", "Thông báo");
                    txtMasinhvien.Focus();
                }
                else if (cbbMakhoa1 == null || cbbMakhoa1.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Mã khoa không được để trống", "Thông báo");
                    cbbMakhoa1.Focus();
                }
                else
                {
                    busthe.taoThesinhvien(dtNgaytaothe.Value, dtHanthe.Value, txtHoten.Text, dtNgaysinh.Value, txtMasinhvien.Text, cbbMakhoa1.Text);
                    MessageBox.Show("Tạo thẻ thành công", "Thông báo");
                    Close();
                }
            }
            else if (radGiangvien.Checked)
            {
                if (txtGiangvien == null || txtGiangvien.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Mã giảng viên không được để trống", "Thông báo");
                    txtGiangvien.Focus();
                }
                else if (cbbMakhoa2 == null||cbbMakhoa2.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Mã khoa không được để trống", "Thông báo");
                    cbbMakhoa2.Focus();
                }
                else
                {
                    busthe.taoThegiangvien(dtNgaytaothe.Value, dtHanthe.Value, txtHoten.Text, dtNgaysinh.Value, txtGiangvien.Text, cbbMakhoa1.Text);
                    MessageBox.Show("Tạo thẻ thành công", "Thông báo");
                    Close();
                }
            }
            else
            {
                long madocgia =busthe.taoThedocgiakhac(dtNgaytaothe.Value, dtHanthe.Value, txtHoten.Text, dtNgaysinh.Value);
                MessageBox.Show("Tạo thẻ thành công, mã đọc giả : "+madocgia.ToString(), "Thông báo");
                Close();
            }
        }
    }
}
