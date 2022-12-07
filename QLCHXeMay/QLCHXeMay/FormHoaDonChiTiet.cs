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
    public partial class FormHoaDonChiTiet : Form
    {
        public FormHoaDonChiTiet()
        {
            InitializeComponent();
        }

        XuLy xl = new XuLy();

        private void FormHoaDonChiTiet_Load(object sender, EventArgs e)
        {
            txtMaHD.Enabled = cbbMaNV.Enabled = cbbMaKH.Enabled = cbbMaXe.Enabled = txtThanhTien.Enabled = maskedTextBox1.Enabled = false;
            
            dtGrdVwHienThi.DataSource = xl.loadCTHD();
        }

        private void btnTaoHD_Click(object sender, EventArgs e)
        {
            cbbMaNV.Enabled = cbbMaKH.Enabled = cbbMaXe.Enabled = maskedTextBox1.Enabled = true;
            string ngayHienTai = DateTime.Now.ToShortDateString();
            maskedTextBox1.Text = ngayHienTai;
            txtThanhTien.Text = "0";

            //cbbMaNV.DataSource = xl.loadNhanVien();
            //cbbMaNV.DisplayMember = "TenNV";
            //cbbMaNV.ValueMember = "MaNV";

            //cbbMaKH.DataSource = xl.loadKhachHang();
            //cbbMaKH.DisplayMember = "TenKH";
            //cbbMaKH.ValueMember = "MaKH";
        }

        private void btnLuuHD_Click(object sender, EventArgs e)
        {
            string ngayNhap = maskedTextBox1.Text;
            if (xl.themHD(cbbMaNV.Text, cbbMaKH.Text, cbbMaXe.Text, 0, ngayNhap) == true)
            {
                MessageBox.Show("Tạo hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbbMaHD.SelectedValue = txtMaHD.Text;
            }
            else MessageBox.Show("Tạo hóa đơn thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnInHD_Click(object sender, EventArgs e)
        {
            FormInHoaDon frmIHD = new FormInHoaDon();
            //frmIHD.MdiParent = this;
            frmIHD.Show();
        }

        private void btnThemMH_Click(object sender, EventArgs e)
        {
            if (xl.themCTHD(cbbMaHD.Text, cbbSoKhung.Text, cbbSoMay.Text, cbbMauSac.Text, int.Parse(txtSoLuong.Text), float.Parse(txtDonGia.Text)) == true)
            {
                MessageBox.Show("Thêm thành công!", "Thông báo");
            }
            else MessageBox.Show("Thêm thất bại!", "Thông báo");
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dtGrdVwHienThi.CurrentRow != null)
            {
                //Lấy mã khoa chuẩn bị xóa
                string maXoa = dtGrdVwHienThi.CurrentRow.Cells[0].Value.ToString();

                if (xl.xoaCTHD(maXoa) == true)
                {
                    MessageBox.Show("Xóa thành công!", "Thông báo");
                }
                else MessageBox.Show("Xóa thất bại!", "Thông báo");
            }
        }

        private void dtGrdVwHienThi_SelectionChanged(object sender, EventArgs e)
        {
            if (dtGrdVwHienThi.CurrentRow != null)
            {
                cbbMaHD.Text = dtGrdVwHienThi.CurrentRow.Cells[0].Value.ToString();
                cbbSoKhung.Text = dtGrdVwHienThi.CurrentRow.Cells[1].Value.ToString();
                cbbSoMay.Text = dtGrdVwHienThi.CurrentRow.Cells[2].Value.ToString();
                cbbMauSac.Text = dtGrdVwHienThi.CurrentRow.Cells[3].Value.ToString();
                txtSoLuong.Text = dtGrdVwHienThi.CurrentRow.Cells[4].Value.ToString();
                txtDonGia.Text = dtGrdVwHienThi.CurrentRow.Cells[5].Value.ToString();

                float tt = xl.tinhThanhTien(int.Parse(txtSoLuong.Text), float.Parse(txtDonGia.Text));
                txtThanhTien.Text = tt.ToString();
            }
        }
    }
}
