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
    public partial class FormLoaiXe : Form
    {
        public FormLoaiXe()
        {
            InitializeComponent();
        }

        XuLy xl = new XuLy();

        private void FormLoaiXe_Load(object sender, EventArgs e)
        {
            dtGrdVwHienThi.DataSource = xl.loadLoaiXe();

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
            if (xl.themLoaiXe(txtMaXe.Text, txtLoaiXe.Text, cbbHangXe.Text) == true)
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

                if (xl.suaLoaiXe(maSua, txtLoaiXe.Text, cbbHangXe.Text) == true)
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

                if (xl.xoaLoaiXe(maXoa) == true)
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
                txtMaXe.Text = dtGrdVwHienThi.CurrentRow.Cells[0].Value.ToString();
                txtLoaiXe.Text = dtGrdVwHienThi.CurrentRow.Cells[1].Value.ToString();
                cbbHangXe.Text = dtGrdVwHienThi.CurrentRow.Cells[2].Value.ToString();
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string rowFilter = string.Format("{0} like '{1}'", "HangXe", "*" + txtTimKiem.Text + "*");
            (dtGrdVwHienThi.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
        }
    }
}
