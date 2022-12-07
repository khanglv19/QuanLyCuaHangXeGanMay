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
    public partial class FormKhachHang : Form
    {
        public FormKhachHang()
        {
            InitializeComponent();
        }

        XuLy xl = new XuLy();

        private void FormKhachHang_Load(object sender, EventArgs e)
        {
            dtGrdVwHienThi.DataSource = xl.loadKhachHang();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
                this.Close();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (xl.themKhachHang(txtMaKH.Text, txtHoTen.Text, txtSDT.Text, txtDiaChi.Text) == true)
            {
                MessageBox.Show("Thêm thành công!", "Thông báo");
            }
            else MessageBox.Show("Thêm thất bại!", "Thông báo");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dtGrdVwHienThi.CurrentRow != null)
            {
                //Lấy mã khoa chuẩn bị xóa
                string maSua = dtGrdVwHienThi.CurrentRow.Cells[0].Value.ToString();

                if (xl.suaKhachHang(maSua, txtHoTen.Text, txtSDT.Text, txtDiaChi.Text) == true)
                {
                    MessageBox.Show("Sửa thành công!", "Thông báo");
                }
                else MessageBox.Show("Sửa thất bại!", "Thông báo");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dtGrdVwHienThi.CurrentRow != null)
            {
                //Lấy mã khoa chuẩn bị xóa
                string maXoa = dtGrdVwHienThi.CurrentRow.Cells[0].Value.ToString();

                if (xl.xoaKhachHang(maXoa) == true)
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
                txtMaKH.Text = dtGrdVwHienThi.CurrentRow.Cells[0].Value.ToString();
                txtHoTen.Text = dtGrdVwHienThi.CurrentRow.Cells[1].Value.ToString();
                txtSDT.Text = dtGrdVwHienThi.CurrentRow.Cells[2].Value.ToString();
                txtDiaChi.Text = dtGrdVwHienThi.CurrentRow.Cells[3].Value.ToString();
            }
        }
    }
}
