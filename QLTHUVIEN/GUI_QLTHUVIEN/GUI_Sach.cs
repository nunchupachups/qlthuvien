using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QLTHUVIEN
{
    public partial class GUI_Sach : Form
    {
        public GUI_Sach()
        {
            InitializeComponent();
            Lock_Unlock(mySave.KT);
        }
        void Lock_Unlock(Boolean kt)
        {
            mnuDangxuat.Enabled = mnuQuanlydausach.Enabled= mnuQuanlysach.Enabled=mnuQuanlyloai.Enabled=mnuQuanlymuontrasach.Enabled=mnuQuanlythe.Enabled=mnuThongke.Enabled= !kt;
            mnuDangnhap.Enabled = mnuClose.Enabled = kt;
        }

        private void mnuQuanlysach_Click(object sender, EventArgs e)
        {
            frmquanlysach ql = new frmquanlysach();
            ql.Show();
        }

        private void mnuClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mnuQuanlydausach_Click(object sender, EventArgs e)
        {
            frmQuanlydausach ql = new frmQuanlydausach();
            ql.Show();
        }

        private void mnuQuanlyloai_Click(object sender, EventArgs e)
        {
            frmQuanlyloaisach ql = new frmQuanlyloaisach();
            ql.Show();
        }

        private void mnuQuanlythe_Click(object sender, EventArgs e)
        {
            frmQuanlythe ql = new frmQuanlythe();
            ql.Show();
        }

        private void mnuQuanlymuontrasach_Click(object sender, EventArgs e)
        {
            frmQuanlymuontrasach ql = new frmQuanlymuontrasach();
            ql.Show();
        }

        private void mnuDangnhap_Click(object sender, EventArgs e)
        {
            frmDangnhap dn = new frmDangnhap();
            dn.Show();
        }

        private void GUI_Sach_Activated(object sender, EventArgs e)
        {
            Lock_Unlock(mySave.KT);
        }

        private void mnuDangxuat_Click(object sender, EventArgs e)
        {
            mySave.KT = !mySave.KT;
            Lock_Unlock(mySave.KT);
        }

        private void mnuThongke_Click(object sender, EventArgs e)
        {
            frmThongke tk = new frmThongke();
            tk.Show();
        }
    }
}
