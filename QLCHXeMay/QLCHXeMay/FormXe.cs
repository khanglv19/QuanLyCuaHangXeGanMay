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
    public partial class FormXe : Form
    {
        public FormXe()
        {
            InitializeComponent();
        }

        XuLy xl = new XuLy();

        private void FormXe_Load(object sender, EventArgs e)
        {
            dtGrdVwHienThi.DataSource = xl.loadXe();

            //cbbMaXe.DataSource = xl.loadLoaiXe();
            //cbbMaXe.DisplayMember = "MaXe";
            //cbbMaXe.ValueMember = "MaXe";

            //cbbHangXe.DataSource = xl.loadNhaCungCap();
            //cbbHangXe.DisplayMember = "TenNCC";
            //cbbHangXe.ValueMember = "MaNCC";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
                this.Close();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (xl.themXe(cbbMaXe.Text, cbbHangXe.Text, txtMauSac.Text, txtSoKhung.Text, txtSoMay.Text, float.Parse(txtGiaBan.Text)) == true)
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

                if (xl.suaXe(maSua, cbbHangXe.Text, txtMauSac.Text, txtSoKhung.Text, txtSoMay.Text, float.Parse(txtGiaBan.Text)) == true)
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
                string maXoa1 = dtGrdVwHienThi.CurrentRow.Cells[0].Value.ToString();

                if (xl.xoaXe(maXoa1) == true)
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
                cbbMaXe.Text = dtGrdVwHienThi.CurrentRow.Cells[0].Value.ToString();
                cbbHangXe.Text = dtGrdVwHienThi.CurrentRow.Cells[1].Value.ToString();
                txtMauSac.Text = dtGrdVwHienThi.CurrentRow.Cells[2].Value.ToString();
                txtSoKhung.Text = dtGrdVwHienThi.CurrentRow.Cells[3].Value.ToString();
                txtSoMay.Text = dtGrdVwHienThi.CurrentRow.Cells[4].Value.ToString();
                txtGiaBan.Text = dtGrdVwHienThi.CurrentRow.Cells[5].Value.ToString();
            }
        }
    }
}
