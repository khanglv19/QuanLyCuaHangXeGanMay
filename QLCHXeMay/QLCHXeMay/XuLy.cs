using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHXeMay
{
    public class XuLy
    {
        public XuLy()
        {

        }

        //Tạo kết nối CSDL
        SqlConnection cnn = new SqlConnection("Data Source = VINHKHANG; Initial Catalog = QLCHXeMay_CSharp; Integrated Security = True");
        //Tạo dataset
        DataSet ds = new DataSet();
        SqlDataAdapter da;

        public DataTable loadLoaiXe()
        {
            //Tạo đối tượng DataAdapter
            da = new SqlDataAdapter("select * from LoaiXe", cnn);
            //Điền dữ liệu vào Dataset hoặc ánh xạ bảng Khoa lên Dataset
            da.Fill(ds, "LoaiXe");
            //Trước khi thêm/xóa/sửa cần đặt khóa chính cho table Khoa
            DataColumn[] key = new DataColumn[1];
            key[0] = ds.Tables["LoaiXe"].Columns[0];
            //Set khóa chính
            ds.Tables["LoaiXe"].PrimaryKey = key;
            //Trả dữ liệu cho phương thức
            return ds.Tables["LoaiXe"];
        }

        public bool themLoaiXe(string maXe, string loaiXe, string HangXe)
        {
            try
            {
                //Tạo một dòng dữ liệu mới
                DataRow dtRw = ds.Tables["LoaiXe"].NewRow();
                //Gán giá trị vào data row
                dtRw["MaXe"] = maXe;
                dtRw["LoaiXe"] = loaiXe;
                dtRw["HangXe"] = HangXe;
                //dtRw["MaNCC"] = HangXe;
                //Chèn vào bảng Khoa trên Dataset
                ds.Tables["LoaiXe"].Rows.Add(dtRw);
                //Update vào Database
                SqlCommandBuilder builder = new SqlCommandBuilder(da); //Giúp build câu lệnh thêm/xóa/sửa vào bảng khoa
                da.Update(ds, "LoaiXe");
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool suaLoaiXe(string maXe, string loaiXe, string HangXe)
        {
            try
            {
                //Tìm dòng dữ liệu cần xóa (chỉ có tác dụng khi đã có khóa chính)
                DataRow dtRw = ds.Tables["LoaiXe"].Rows.Find(maXe);
                //Sửa dòng của bảng Khoa trên Dataset
                dtRw["LoaiXe"] = loaiXe;
                dtRw["HangXe"] = HangXe;
                //Update vào Database
                SqlCommandBuilder builder = new SqlCommandBuilder(da); //Giúp build câu lệnh thêm/xóa/sửa vào bảng khoa
                da.Update(ds, "LoaiXe");
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool xoaLoaiXe(string maXe)
        {
            try
            {
                //Tìm dòng dữ liệu cần xóa (chỉ có tác dụng khi đã có khóa chính)
                DataRow dtRw = ds.Tables["LoaiXe"].Rows.Find(maXe);
                //Xóa dòng khỏi bảng Khoa trên Dataset
                dtRw.Delete(); //Giúp đánh dấu trạng thái dữ liệu đã xóa
                //Update vào Database
                SqlCommandBuilder builder = new SqlCommandBuilder(da); //Giúp build câu lệnh thêm/xóa/sửa vào bảng khoa
                da.Update(ds, "LoaiXe");
                return true;
            }
            catch
            {
                return false;
            }
        }

        public DataTable loadNhanVien()
        {
            //Tạo đối tượng DataAdapter
            da = new SqlDataAdapter("select * from NhanVien", cnn);
            //Điền dữ liệu vào Dataset hoặc ánh xạ bảng Khoa lên Dataset
            da.Fill(ds, "NhanVien");
            //Trước khi thêm/xóa/sửa cần đặt khóa chính cho table Khoa
            DataColumn[] key = new DataColumn[1];
            key[0] = ds.Tables["NhanVien"].Columns[0];
            //Set khóa chính
            ds.Tables["NhanVien"].PrimaryKey = key;
            //Trả dữ liệu cho phương thức
            return ds.Tables["NhanVien"];
        }

        public DataTable loadBangNhanVien()
        {
            return ds.Tables["NhanVien"];
        }

        public bool kiemTraTrungKhoaChinhNV(string ma)
        {
            loadNhanVien();
            if (ds.Tables["NhanVien"].Rows.Find(ma) == null)
            {
                return false;
            }
            return true;
        }

        public bool themNhanVien(string maNV, string tenNV, string sdt, string chucVu, string diaChi)
        {
            try
            {
                //Tạo một dòng dữ liệu mới
                DataRow dtRw = ds.Tables["NhanVien"].NewRow();
                //Gán giá trị vào data row
                dtRw["MaNV"] = maNV;
                dtRw["TenNV"] = tenNV;
                dtRw["SDT"] = sdt;
                dtRw["ChucVu"] = chucVu;
                dtRw["DiaChi"] = diaChi;
                //Chèn vào bảng Khoa trên Dataset
                ds.Tables["NhanVien"].Rows.Add(dtRw);
                //Update vào Database
                SqlCommandBuilder builder = new SqlCommandBuilder(da); //Giúp build câu lệnh thêm/xóa/sửa vào bảng khoa
                da.Update(ds, "NhanVien");
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool suaNhanVien(string maNV, string tenNV, string sdt, string chucVu, string diaChi)
        {
            try
            {
                //Tìm dòng dữ liệu cần xóa (chỉ có tác dụng khi đã có khóa chính)
                DataRow dtRw = ds.Tables["NhanVien"].Rows.Find(maNV);
                //Sửa dòng của bảng Khoa trên Dataset
                dtRw["TenNV"] = tenNV;
                dtRw["SDT"] = sdt;
                dtRw["ChucVu"] = chucVu;
                dtRw["DiaChi"] = diaChi;
                //Update vào Database
                SqlCommandBuilder builder = new SqlCommandBuilder(da); //Giúp build câu lệnh thêm/xóa/sửa vào bảng khoa
                da.Update(ds, "NhanVien");
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool xoaNhanVien(string maNV)
        {
            try
            {
                //Tìm dòng dữ liệu cần xóa (chỉ có tác dụng khi đã có khóa chính)
                DataRow dtRw = ds.Tables["NhanVien"].Rows.Find(maNV);
                //Xóa dòng khỏi bảng Khoa trên Dataset
                dtRw.Delete(); //Giúp đánh dấu trạng thái dữ liệu đã xóa
                //Update vào Database
                SqlCommandBuilder builder = new SqlCommandBuilder(da); //Giúp build câu lệnh thêm/xóa/sửa vào bảng khoa
                da.Update(ds, "NhanVien");
                return true;
            }
            catch
            {
                return false;
            }
        }

        public DataTable loadKhachHang()
        {
            //Tạo đối tượng DataAdapter
            da = new SqlDataAdapter("select * from KhachHang", cnn);
            //Điền dữ liệu vào Dataset hoặc ánh xạ bảng Khoa lên Dataset
            da.Fill(ds, "KhachHang");
            //Trước khi thêm/xóa/sửa cần đặt khóa chính cho table Khoa
            DataColumn[] key = new DataColumn[1];
            key[0] = ds.Tables["KhachHang"].Columns[0];
            //Set khóa chính
            ds.Tables["KhachHang"].PrimaryKey = key;
            //Trả dữ liệu cho phương thức
            return ds.Tables["KhachHang"];
        }

        public bool kiemTraTrungKhoaChinhKH(string ma)
        {
            loadNhanVien();
            if (ds.Tables["KhachHang"].Rows.Find(ma) == null)
            {
                return false;
            }
            return true;
        }

        public bool themKhachHang(string maKH, string tenKH, string sdt, string diaChi)
        {
            try
            {
                //Tạo một dòng dữ liệu mới
                DataRow dtRw = ds.Tables["KhachHang"].NewRow();
                //Gán giá trị vào data row
                dtRw["MaKH"] = maKH;
                dtRw["TenKH"] = tenKH;
                dtRw["SDT"] = sdt;
                dtRw["DiaChi"] = diaChi;
                //Chèn vào bảng Khoa trên Dataset
                ds.Tables["KhachHang"].Rows.Add(dtRw);
                //Update vào Database
                SqlCommandBuilder builder = new SqlCommandBuilder(da); //Giúp build câu lệnh thêm/xóa/sửa vào bảng khoa
                da.Update(ds, "KhachHang");
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool suaKhachHang(string maKH, string tenKH, string sdt, string diaChi)
        {
            try
            {
                //Tìm dòng dữ liệu cần xóa (chỉ có tác dụng khi đã có khóa chính)
                DataRow dtRw = ds.Tables["KhachHang"].Rows.Find(maKH);
                //Sửa dòng của bảng Khoa trên Dataset
                dtRw["TenKH"] = tenKH;
                dtRw["SDT"] = sdt;
                dtRw["DiaChi"] = diaChi;
                //Update vào Database
                SqlCommandBuilder builder = new SqlCommandBuilder(da); //Giúp build câu lệnh thêm/xóa/sửa vào bảng khoa
                da.Update(ds, "KhachHang");
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool xoaKhachHang(string maKH)
        {
            try
            {
                //Tìm dòng dữ liệu cần xóa (chỉ có tác dụng khi đã có khóa chính)
                DataRow dtRw = ds.Tables["KhachHang"].Rows.Find(maKH);
                //Xóa dòng khỏi bảng Khoa trên Dataset
                dtRw.Delete(); //Giúp đánh dấu trạng thái dữ liệu đã xóa
                //Update vào Database
                SqlCommandBuilder builder = new SqlCommandBuilder(da); //Giúp build câu lệnh thêm/xóa/sửa vào bảng khoa
                da.Update(ds, "KhachHang");
                return true;
            }
            catch
            {
                return false;
            }
        }

        public DataTable loadNhaCungCap()
        {
            //Tạo đối tượng DataAdapter
            da = new SqlDataAdapter("select * from NhaCungCap", cnn);
            //Điền dữ liệu vào Dataset hoặc ánh xạ bảng Khoa lên Dataset
            da.Fill(ds, "NhaCungCap");
            //Trước khi thêm/xóa/sửa cần đặt khóa chính cho table Khoa
            DataColumn[] key = new DataColumn[1];
            key[0] = ds.Tables["NhaCungCap"].Columns[0];
            //Set khóa chính
            ds.Tables["NhaCungCap"].PrimaryKey = key;
            //Trả dữ liệu cho phương thức
            return ds.Tables["NhaCungCap"];
        }

        public bool kiemTraTrungKhoaChinhNCC(string ma)
        {
            loadNhanVien();
            if (ds.Tables["NhaCungCap"].Rows.Find(ma) == null)
            {
                return false;
            }
            return true;
        }

        public bool themNhaCungCap(string maNCC, string tenNCC, string sdt, string diaChi)
        {
            try
            {
                //Tạo một dòng dữ liệu mới
                DataRow dtRw = ds.Tables["NhaCungCap"].NewRow();
                //Gán giá trị vào data row
                dtRw["MaNCC"] = maNCC;
                dtRw["TenNCC"] = tenNCC;
                dtRw["SDT"] = sdt;
                dtRw["DiaChi"] = diaChi;
                //Chèn vào bảng Khoa trên Dataset
                ds.Tables["NhaCungCap"].Rows.Add(dtRw);
                //Update vào Database
                SqlCommandBuilder builder = new SqlCommandBuilder(da); //Giúp build câu lệnh thêm/xóa/sửa vào bảng khoa
                da.Update(ds, "NhaCungCap");
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool suaNhaCungCap(string maNCC, string tenNCC, string sdt, string diaChi)
        {
            try
            {
                //Tìm dòng dữ liệu cần xóa (chỉ có tác dụng khi đã có khóa chính)
                DataRow dtRw = ds.Tables["NhaCungCap"].Rows.Find(maNCC);
                //Sửa dòng của bảng Khoa trên Dataset
                dtRw["TenNCC"] = tenNCC;
                dtRw["SDT"] = sdt;
                dtRw["DiaChi"] = diaChi;
                //Update vào Database
                SqlCommandBuilder builder = new SqlCommandBuilder(da); //Giúp build câu lệnh thêm/xóa/sửa vào bảng khoa
                da.Update(ds, "NhaCungCap");
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool xoaNhaCungCap(string maNCC)
        {
            try
            {
                //Tìm dòng dữ liệu cần xóa (chỉ có tác dụng khi đã có khóa chính)
                DataRow dtRw = ds.Tables["NhaCungCap"].Rows.Find(maNCC);
                //Xóa dòng khỏi bảng Khoa trên Dataset
                dtRw.Delete(); //Giúp đánh dấu trạng thái dữ liệu đã xóa
                //Update vào Database
                SqlCommandBuilder builder = new SqlCommandBuilder(da); //Giúp build câu lệnh thêm/xóa/sửa vào bảng khoa
                da.Update(ds, "NhaCungCap");
                return true;
            }
            catch
            {
                return false;
            }
        }

        public DataTable loadXe()
        {
            //Tạo đối tượng DataAdapter
            da = new SqlDataAdapter("select * from Xe", cnn);
            //Điền dữ liệu vào Dataset hoặc ánh xạ bảng Khoa lên Dataset
            da.Fill(ds, "Xe");
            //Trước khi thêm/xóa/sửa cần đặt khóa chính cho table Xe
            DataColumn[] key = new DataColumn[1];
            key[0] = ds.Tables["Xe"].Columns[0];
            //key[1] = ds.Tables["Xe"].Columns[1];
            //key[2] = ds.Tables["Xe"].Columns[2];
            //Set khóa chính
            ds.Tables["Xe"].PrimaryKey = key;
            //Trả dữ liệu cho phương thức
            return ds.Tables["Xe"];
        }

        public bool kiemTraTrungKhoaChinhXe(string ma)
        {
            loadNhanVien();
            if (ds.Tables["Xe"].Rows.Find(ma) == null)
            {
                return false;
            }
            return true;
        }

        public bool themXe(string maXe, string hangXe, string mauSac, string soKhung, string soMay,  float giaBan)
        {
            try
            {
                //Tạo một dòng dữ liệu mới
                DataRow dtRw = ds.Tables["Xe"].NewRow();
                //Gán giá trị vào data row
                dtRw["MaXe"] = maXe;
                dtRw["HangXe"] = hangXe;
                dtRw["MauSac"] = mauSac;
                dtRw["SoKhung"] = soKhung;
                dtRw["SoMay"] = soMay;
                dtRw["GiaBan"] = giaBan;
                //Chèn vào bảng Khoa trên Dataset
                ds.Tables["Xe"].Rows.Add(dtRw);
                //Update vào Database
                SqlCommandBuilder builder = new SqlCommandBuilder(da); //Giúp build câu lệnh thêm/xóa/sửa vào bảng khoa
                da.Update(ds, "Xe");
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool suaXe(string maXe, string hangXe, string mauSac, string soKhung, string soMay, float giaBan)
        {
            try
            {
                //Tìm dòng dữ liệu cần xóa (chỉ có tác dụng khi đã có khóa chính)
                DataRow dtRw = ds.Tables["Xe"].Rows.Find(maXe);
                //Sửa dòng của bảng Khoa trên Dataset
                dtRw["HangXe"] = hangXe;
                dtRw["MauSac"] = mauSac;
                dtRw["SoKhung"] = soKhung;
                dtRw["SoMay"] = soMay;
                dtRw["GiaBan"] = giaBan;
                //Update vào Database
                SqlCommandBuilder builder = new SqlCommandBuilder(da); //Giúp build câu lệnh thêm/xóa/sửa vào bảng khoa
                da.Update(ds, "Xe");
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool xoaXe(string maXe)
        {
            try
            {
                //Tìm dòng dữ liệu cần xóa (chỉ có tác dụng khi đã có khóa chính)
                DataRow dtRw = ds.Tables["Xe"].Rows.Find(maXe);
                //Xóa dòng khỏi bảng Khoa trên Dataset
                dtRw.Delete(); //Giúp đánh dấu trạng thái dữ liệu đã xóa
                //Update vào Database
                SqlCommandBuilder builder = new SqlCommandBuilder(da); //Giúp build câu lệnh thêm/xóa/sửa vào bảng khoa
                da.Update(ds, "Xe");
                return true;
            }
            catch
            {
                return false;
            }
        }

        public DataTable loadBangChucVu()
        {
            //Tạo đối tượng DataAdapter
            da = new SqlDataAdapter("select * from ChucVu", cnn);
            //Điền dữ liệu vào Dataset hoặc ánh xạ bảng Khoa lên Dataset
            da.Fill(ds, "ChucVu");
            //Trước khi thêm/xóa/sửa cần đặt khóa chính cho table Khoa
            DataColumn[] key = new DataColumn[1];
            key[0] = ds.Tables["ChucVu"].Columns[0];
            //Set khóa chính
            ds.Tables["ChucVu"].PrimaryKey = key;
            //Trả dữ liệu cho phương thức
            return ds.Tables["ChucVu"];
        }

        public DataTable loadChiTietPN()
        {
            //Tạo đối tượng DataAdapter
            da = new SqlDataAdapter("select * from ChiTietPhieuNhap", cnn);
            //Điền dữ liệu vào Dataset hoặc ánh xạ bảng Khoa lên Dataset
            da.Fill(ds, "ChiTietPhieuNhap");
            //Trước khi thêm/xóa/sửa cần đặt khóa chính cho table Khoa
            DataColumn[] key = new DataColumn[1];
            key[0] = ds.Tables["ChiTietPhieuNhap"].Columns[0];
            //Set khóa chính
            ds.Tables["ChiTietPhieuNhap"].PrimaryKey = key;
            //Trả dữ liệu cho phương thức
            return ds.Tables["ChiTietPhieuNhap"];
        }

        public bool themPN(string maPN, string ngayNhap, float thanhTien)
        {
            try
            {
                //Tạo một dòng dữ liệu mới
                DataRow dtRw = ds.Tables["ChiTietPhieuNhap"].NewRow();
                //Gán giá trị vào data row
                dtRw["MaPN"] = maPN;
                dtRw["NgayNhap"] = ngayNhap;
                dtRw["ThanhTien"] = thanhTien;
                //Chèn vào bảng Khoa trên Dataset
                ds.Tables["ChiTietPhieuNhap"].Rows.Add(dtRw);
                //Update vào Database
                SqlCommandBuilder builder = new SqlCommandBuilder(da); //Giúp build câu lệnh thêm/xóa/sửa vào bảng khoa
                da.Update(ds, "ChiTietPhieuNhap");
                return true;
            }
            catch
            {
                return false;
            }
        }

        public DataTable loadHoaDon()
        {
            //Tạo đối tượng DataAdapter
            da = new SqlDataAdapter("select * from HoaDonBanXe", cnn);
            //Điền dữ liệu vào Dataset hoặc ánh xạ bảng Khoa lên Dataset
            da.Fill(ds, "HoaDonBanXe");
            //Trước khi thêm/xóa/sửa cần đặt khóa chính cho table Khoa
            DataColumn[] key = new DataColumn[1];
            key[0] = ds.Tables["HoaDonBanXe"].Columns[0];
            //Set khóa chính
            ds.Tables["HoaDonBanXe"].PrimaryKey = key;
            //Trả dữ liệu cho phương thức
            return ds.Tables["HoaDonBanXe"];
        }

        public DataTable loadCTHD()
        {
            //Tạo đối tượng DataAdapter
            da = new SqlDataAdapter("select * from ChiTietHoaDon", cnn);
            //Điền dữ liệu vào Dataset hoặc ánh xạ bảng Khoa lên Dataset
            da.Fill(ds, "ChiTietHoaDon");
            //Trước khi thêm/xóa/sửa cần đặt khóa chính cho table Khoa
            DataColumn[] key = new DataColumn[1];
            key[0] = ds.Tables["ChiTietHoaDon"].Columns[0];
            //Set khóa chính
            ds.Tables["ChiTietHoaDon"].PrimaryKey = key;
            //Trả dữ liệu cho phương thức
            return ds.Tables["ChiTietHoaDon"];
        }

        public bool kiemTraTrungKhoaChinhHD(string ma)
        {
            loadNhanVien();
            if (ds.Tables["HoaDonBanXe"].Rows.Find(ma) == null)
            {
                return false;
            }
            return true;
        }

        public bool themHD(string maNV, string maKH, string maXe, float thanhTien, string ngayLap)
        {
            try
            {
                //Mở kết nối
                if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                }
                //Tạo câu lệnh điều khiển
                string truyVan = "insert into HoaDonBanXe (MaNV, MaKH, MaXe, ThanhTien, NgayLap) values ('" + maNV + "', '" + maKH + "', '" + maXe + "', " + thanhTien + ", '" + ngayLap + "')";
                //Đối tượng điều khiển
                SqlCommand cmd = new SqlCommand(truyVan, cnn);
                //Thực thi câu lệnh
                cmd.ExecuteNonQuery();
                //Kiểm tra kết nối và đóng
                if (cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool themCTHD(string maHD, string soKhung, string soMay, string mauSac, int soLuong, float donGa)
        {
            try
            {
                //Tạo một dòng dữ liệu mới
                DataRow dtRw = ds.Tables["ChiTietHoaDon"].NewRow();
                //Gán giá trị vào data row
                dtRw["MaHD"] = maHD;
                dtRw["SoKhung"] = soKhung;
                dtRw["SoMay"] = soMay;
                dtRw["MauSac"] = mauSac;
                dtRw["SoLuong"] = soLuong;
                dtRw["DonGia"] = donGa;
                //Chèn vào bảng Khoa trên Dataset
                ds.Tables["ChiTietHoaDon"].Rows.Add(dtRw);
                //Update vào Database
                SqlCommandBuilder builder = new SqlCommandBuilder(da); //Giúp build câu lệnh thêm/xóa/sửa vào bảng khoa
                da.Update(ds, "ChiTietHoaDon");
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool xoaCTHD(string maHD)
        {
            try
            {
                //Tìm dòng dữ liệu cần xóa (chỉ có tác dụng khi đã có khóa chính)
                DataRow dtRw = ds.Tables["ChiTietHoaDon"].Rows.Find(maHD);
                //Xóa dòng khỏi bảng Khoa trên Dataset
                dtRw.Delete(); //Giúp đánh dấu trạng thái dữ liệu đã xóa
                //Update vào Database
                SqlCommandBuilder builder = new SqlCommandBuilder(da); //Giúp build câu lệnh thêm/xóa/sửa vào bảng khoa
                da.Update(ds, "ChiTietHoaDon");
                return true;
            }
            catch
            {
                return false;
            }
        }

        //public bool themCTHD(string maHD, string soKhung, string soMay, string mauSac, int soLuong, float donGa)
        //{
        //    try
        //    {
        //        //Mở kết nối
        //        if (cnn.State == ConnectionState.Closed)
        //        {
        //            cnn.Open();
        //        }
        //        //Tạo câu lệnh điều khiển
        //        string truyVan = "insert into ChiTietHoaDon values ('" + maHD + "', '" + soKhung + "', '" + soMay + "', '" + mauSac + "', " + soLuong + ", " + donGa + ")";
        //        //Đối tượng điều khiển
        //        SqlCommand cmd = new SqlCommand(truyVan, cnn);
        //        //Thực thi câu lệnh
        //        cmd.ExecuteNonQuery();
        //        //Kiểm tra kết nối và đóng
        //        if (cnn.State == ConnectionState.Open)
        //        {
        //            cnn.Close();
        //        }
        //        return true;
        //    }
        //    catch
        //    {
        //        return false;
        //    }
        //}

        public bool xoaHD(string maHD)
        {
            try
            {
                //Tìm dòng dữ liệu cần xóa (chỉ có tác dụng khi đã có khóa chính)
                DataRow dtRw = ds.Tables["HoaDonBanXe"].Rows.Find(maHD);
                //Xóa dòng khỏi bảng Khoa trên Dataset
                dtRw.Delete(); //Giúp đánh dấu trạng thái dữ liệu đã xóa
                //Update vào Database
                SqlCommandBuilder builder = new SqlCommandBuilder(da); //Giúp build câu lệnh thêm/xóa/sửa vào bảng khoa
                da.Update(ds, "HoaDonBanXe");
                return true;
            }
            catch
            {
                return false;
            }
        }

        public float tinhThanhTien(int sl, float dg)
        {
            return sl * dg;
        }

        public bool dangKy(string tdn, string mk)
        {
            try
            {
                //Mở kết nối
                if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                }
                //Tạo câu lệnh điều khiển
                string truyVan = "insert into TaiKhoan values ('" + tdn + "', '" + mk + "')";
                //Đối tượng điều khiển
                SqlCommand cmd = new SqlCommand(truyVan, cnn);
                //Thực thi câu lệnh
                cmd.ExecuteNonQuery();
                //Kiểm tra kết nối và đóng
                if (cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool dangNhap(string tdn, string mk)
        {
            try
            {
                //Mở kết nối
                if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                }
                //Tạo câu lệnh điều khiển
                string truyVan = "select * from TaiKhoan where TenDangNhap =  '" + tdn + "' and MatKhau = '" + mk + "' ";
                //Đối tượng điều khiển
                SqlCommand cmd = new SqlCommand(truyVan, cnn);
                //Thực thi câu lệnh
                cmd.ExecuteNonQuery();
                //Kiểm tra kết nối và đóng
                if (cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
