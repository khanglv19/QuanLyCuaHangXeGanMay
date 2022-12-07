using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCHXeMay
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        XuLy xl = new XuLy();

        private void btnDN_Click(object sender, EventArgs e)
        {
            if (xl.dangNhap(txtTDN.Text, txtMK.Text) == true)
            {
                MessageBox.Show("Đăng nhập thành công!");
            }
            else MessageBox.Show("Đăng nhập thất bại!");
        }
    }
}
