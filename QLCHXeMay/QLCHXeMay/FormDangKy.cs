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
    public partial class FormDangKy : Form
    {
        public FormDangKy()
        {
            InitializeComponent();
        }

        XuLy xl = new XuLy();

        private void btnDK_Click(object sender, EventArgs e)
        {
            if (xl.dangKy(txtTDN.Text, txtMK.Text) == true)
            {
                MessageBox.Show("Đăng ký thành công!");
            }
            else MessageBox.Show("Đăng ký thất bại!");
            
        }
    }
}
