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
    public partial class FormMain : Form
    {
        XuLy xl = new XuLy();

        public FormMain()
        {
            InitializeComponent();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
                Application.Exit();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNhanVien frmNV = new FormNhanVien();
            frmNV.MdiParent = this;
            frmNV.Show();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKhachHang frmKH = new FormKhachHang();
            frmKH.MdiParent = this;
            frmKH.Show();
        }

        private void loạiXeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLoaiXe frmLX = new FormLoaiXe();
            frmLX.MdiParent = this;
            frmLX.Show();
        }

        private void xeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormXe frmXe = new FormXe();
            frmXe.MdiParent = this;
            frmXe.Show();
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNhaCungCap frmNCC = new FormNhaCungCap();
            frmNCC.MdiParent = this;
            frmNCC.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form1 frmNCC = new Form1();
            //frmNCC.MdiParent = this;
            //frmNCC.Show();
        }

        private void đăngKýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDangKy frmDK = new FormDangKy();
            frmDK.MdiParent = this;
            frmDK.Show();
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDangNhap frmDN = new FormDangNhap();
            frmDN.MdiParent = this;
            frmDN.Show();
        }

        private void phieuNhaptoolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHoaDonChiTiet frmHDCT = new FormHoaDonChiTiet();
            frmHDCT.MdiParent = this;
            frmHDCT.Show();
        }
    }
}
