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
    public partial class FormPhieuNhap : Form
    {
        public FormPhieuNhap()
        {
            InitializeComponent();
        }

        XuLy xl = new XuLy();

        private void FormPhieuNhap_Load(object sender, EventArgs e)
        {
            txtMaPN.Enabled = txtThanhTien.Enabled = maskedTextBox1.Enabled = false;

            dtGrdVwHienThi.DataSource = xl.loadChiTietPN();
        }

        private void btnTaoHD_Click(object sender, EventArgs e)
        {
            txtMaPN.Enabled = maskedTextBox1.Enabled = true;
            string ngayHienTai = DateTime.Now.ToShortDateString();
            maskedTextBox1.Text = ngayHienTai;
            txtThanhTien.Text = "0";
        }

        private void btnLuuHD_Click(object sender, EventArgs e)
        {
            string ngayNhap = maskedTextBox1.Text;
            if (xl.themPN(txtMaPN.Text, ngayNhap, 0) == true)
            {
                MessageBox.Show("Tạo phiếu nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("Tạo phiếu nhập thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
