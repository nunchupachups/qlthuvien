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
    public partial class frmMuonsach : Form
    {
        BUS_Muonsach busmuonsach = new BUS_Muonsach();
        BUS_Sach sach = new BUS_Sach();
        BUS_The the = new BUS_The();
        public frmMuonsach()
        {
            InitializeComponent();
            loadMuonsach();
        }

        public void loadMuonsach()
        {
            dtNgaymuon.Value = DateTime.Now;
            for (int i = 0; i < sach.getListsachchuamuon().Rows.Count; i++) cbbMasach.Items.Add(sach.getListsachchuamuon().Rows[i]["masach"].ToString());
            for (int i = 0; i < the.getListthe().Rows.Count; i++) cbbMathe.Items.Add(the.getListthe().Rows[i]["mathe"].ToString());
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMuonsach_Click(object sender, EventArgs e)
        {
            if(cbbMasach.Text.Equals("")||cbbMasach==null) MessageBox.Show("Vui lòng chọn sách", "Thông báo");
            else if (cbbMathe.Text.Equals("") || cbbMathe == null) MessageBox.Show("Vui lòng chọn mã thẻ", "Thông báo");
            else if (busmuonsach.tongsachBymathe(long.Parse(cbbMathe.Text))>5) MessageBox.Show("Đã mượn quá số sách cho phép", "Thông báo");
            else
            {
                busmuonsach.muonSach(long.Parse(cbbMathe.Text), long.Parse(cbbMasach.Text), dtNgaymuon.Value);
                MessageBox.Show("Mượn sách thành công", "Thông báo");
                Close();
                
            }
        }
    }
}
