USE [QLCHXeMay_CSharp]
GO
/****** Object:  Table [dbo].[ChiTietHoaDon]    Script Date: 12/12/2021 07:20:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHoaDon](
	[MaHD] [int] NOT NULL,
	[SoKhung] [char](10) NULL,
	[SoMay] [char](10) NULL,
	[MauSac] [nvarchar](50) NULL,
	[SoLuong] [int] NULL,
	[DonGia] [float] NULL,
 CONSTRAINT [PK_ChiTietHoaDon] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietPhieuNhap]    Script Date: 12/12/2021 07:20:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietPhieuNhap](
	[MaPN] [char](10) NOT NULL,
	[MaXe] [char](10) NOT NULL,
	[MaNCC] [char](10) NOT NULL,
	[DonGia] [float] NULL,
	[SoLuong] [int] NULL,
 CONSTRAINT [PK_ChiTietPhieuNhap] PRIMARY KEY CLUSTERED 
(
	[MaPN] ASC,
	[MaXe] ASC,
	[MaNCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDonBanXe]    Script Date: 12/12/2021 07:20:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDonBanXe](
	[MaHD] [int] IDENTITY(1,1) NOT NULL,
	[MaNV] [char](10) NULL,
	[MaKH] [char](10) NULL,
	[MaXe] [char](10) NULL,
	[ThanhTien] [float] NULL,
	[NgayLap] [date] NULL,
 CONSTRAINT [PK_HoaDonBanXe] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 12/12/2021 07:20:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKH] [char](10) NOT NULL,
	[TenKH] [nvarchar](50) NULL,
	[SDT] [char](10) NULL,
	[DiaChi] [nvarchar](250) NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiXe]    Script Date: 12/12/2021 07:20:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiXe](
	[MaXe] [char](10) NOT NULL,
	[LoaiXe] [nvarchar](50) NULL,
	[HangXe] [nvarchar](50) NULL,
 CONSTRAINT [PK_LoaiXe] PRIMARY KEY CLUSTERED 
(
	[MaXe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 12/12/2021 07:20:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaCungCap](
	[MaNCC] [char](10) NOT NULL,
	[TenNCC] [nvarchar](50) NULL,
	[SDT] [char](18) NULL,
	[DiaChi] [nvarchar](250) NULL,
 CONSTRAINT [PK_NhaCungCap] PRIMARY KEY CLUSTERED 
(
	[MaNCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 12/12/2021 07:20:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [char](10) NOT NULL,
	[TenNV] [nvarchar](50) NULL,
	[SDT] [char](10) NULL,
	[ChucVu] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](250) NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuBaoHanh]    Script Date: 12/12/2021 07:20:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuBaoHanh](
	[MaHD] [int] NOT NULL,
	[MaKH] [char](10) NULL,
	[SoKhung] [char](10) NULL,
	[SoMay] [char](10) NULL,
 CONSTRAINT [PK_PhieuBaoHanh] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuNhap]    Script Date: 12/12/2021 07:20:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuNhap](
	[MaPN] [char](10) NOT NULL,
	[NgayNhap] [char](10) NULL,
	[ThanhTien] [float] NULL,
 CONSTRAINT [PK_PhieuNhap] PRIMARY KEY CLUSTERED 
(
	[MaPN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 12/12/2021 07:20:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[TenDangNhap] [varchar](50) NOT NULL,
	[MatKhau] [varchar](max) NULL,
 CONSTRAINT [PK_TaiKhoan] PRIMARY KEY CLUSTERED 
(
	[TenDangNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Xe]    Script Date: 12/12/2021 07:20:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Xe](
	[MaXe] [char](10) NOT NULL,
	[HangXe] [nvarchar](50) NULL,
	[MauSac] [nvarchar](50) NULL,
	[SoKhung] [char](10) NULL,
	[SoMay] [char](10) NULL,
	[GiaBan] [float] NULL,
 CONSTRAINT [PK_Xe] PRIMARY KEY CLUSTERED 
(
	[MaXe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [SoKhung], [SoMay], [MauSac], [SoLuong], [DonGia]) VALUES (1, N'SKAT789   ', N'SMAT789   ', N'Đen', 1, 40000000)
GO
SET IDENTITY_INSERT [dbo].[HoaDonBanXe] ON 

INSERT [dbo].[HoaDonBanXe] ([MaHD], [MaNV], [MaKH], [MaXe], [ThanhTien], [NgayLap]) VALUES (1, N'NV001     ', N'KH002     ', N'AB        ', 40000000, CAST(N'2021-09-22' AS Date))
INSERT [dbo].[HoaDonBanXe] ([MaHD], [MaNV], [MaKH], [MaXe], [ThanhTien], [NgayLap]) VALUES (5, N'NV001     ', N'KH002     ', N'SH        ', 0, CAST(N'2021-12-12' AS Date))
SET IDENTITY_INSERT [dbo].[HoaDonBanXe] OFF
GO
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SDT], [DiaChi]) VALUES (N'KH001     ', N'Trần Quốc Dũng', N'0987645362', N'Đồng Nai')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SDT], [DiaChi]) VALUES (N'KH002     ', N'Lê Thị Ái Phương', N'0873645627', N'Tây Ninh')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SDT], [DiaChi]) VALUES (N'KH003     ', N'Nguyễn Thanh Sơn', N'0987365242', N'Tp. HCM')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SDT], [DiaChi]) VALUES (N'KH004     ', N'Ngô Minh Tài', N'0983756109', N'Đà Nẵng')
GO
INSERT [dbo].[LoaiXe] ([MaXe], [LoaiXe], [HangXe]) VALUES (N'AB        ', N'Air Blade', N'Honda     ')
INSERT [dbo].[LoaiXe] ([MaXe], [LoaiXe], [HangXe]) VALUES (N'AC        ', N'Acrozo', N'Yamaha    ')
INSERT [dbo].[LoaiXe] ([MaXe], [LoaiXe], [HangXe]) VALUES (N'AD        ', N'Address', N'Suzuki    ')
INSERT [dbo].[LoaiXe] ([MaXe], [LoaiXe], [HangXe]) VALUES (N'AT        ', N'Attila', N'SYM       ')
INSERT [dbo].[LoaiXe] ([MaXe], [LoaiXe], [HangXe]) VALUES (N'BL        ', N'Blade', N'Honda     ')
INSERT [dbo].[LoaiXe] ([MaXe], [LoaiXe], [HangXe]) VALUES (N'BMS       ', N'Bugman Street', N'Suzuki    ')
INSERT [dbo].[LoaiXe] ([MaXe], [LoaiXe], [HangXe]) VALUES (N'EX        ', N'Exciter', N'Yamaha    ')
INSERT [dbo].[LoaiXe] ([MaXe], [LoaiXe], [HangXe]) VALUES (N'FG        ', N'Freego', N'Yamaha    ')
INSERT [dbo].[LoaiXe] ([MaXe], [LoaiXe], [HangXe]) VALUES (N'FT        ', N'Future', N'Honda     ')
INSERT [dbo].[LoaiXe] ([MaXe], [LoaiXe], [HangXe]) VALUES (N'GD        ', N'Grande', N'Yamaha    ')
INSERT [dbo].[LoaiXe] ([MaXe], [LoaiXe], [HangXe]) VALUES (N'IP        ', N'Impulse', N'Suzuki    ')
INSERT [dbo].[LoaiXe] ([MaXe], [LoaiXe], [HangXe]) VALUES (N'JN        ', N'Janus', N'Yamaha    ')
INSERT [dbo].[LoaiXe] ([MaXe], [LoaiXe], [HangXe]) VALUES (N'Jp        ', N'Jupiter', N'Yamaha    ')
INSERT [dbo].[LoaiXe] ([MaXe], [LoaiXe], [HangXe]) VALUES (N'LBT       ', N'Liberty', N'Piaggio   ')
INSERT [dbo].[LoaiXe] ([MaXe], [LoaiXe], [HangXe]) VALUES (N'LD        ', N'Lead', N'Honda     ')
INSERT [dbo].[LoaiXe] ([MaXe], [LoaiXe], [HangXe]) VALUES (N'LT        ', N'Latte', N'Yamaha    ')
INSERT [dbo].[LoaiXe] ([MaXe], [LoaiXe], [HangXe]) VALUES (N'ML        ', N'Medley', N'Piaggio   ')
INSERT [dbo].[LoaiXe] ([MaXe], [LoaiXe], [HangXe]) VALUES (N'NA        ', N'New Angel', N'SYM       ')
INSERT [dbo].[LoaiXe] ([MaXe], [LoaiXe], [HangXe]) VALUES (N'NG        ', N'New Galaxy', N'SYM       ')
INSERT [dbo].[LoaiXe] ([MaXe], [LoaiXe], [HangXe]) VALUES (N'NVX       ', N'NVX', N'Yamaha    ')
INSERT [dbo].[LoaiXe] ([MaXe], [LoaiXe], [HangXe]) VALUES (N'SC        ', N'Super Cub', N'Honda     ')
INSERT [dbo].[LoaiXe] ([MaXe], [LoaiXe], [HangXe]) VALUES (N'SH        ', N'SH', N'Honda     ')
INSERT [dbo].[LoaiXe] ([MaXe], [LoaiXe], [HangXe]) VALUES (N'Sr        ', N'Sirius', N'Yamaha    ')
INSERT [dbo].[LoaiXe] ([MaXe], [LoaiXe], [HangXe]) VALUES (N'SSR       ', N'Star RS', N'SYM       ')
INSERT [dbo].[LoaiXe] ([MaXe], [LoaiXe], [HangXe]) VALUES (N'VS        ', N'Vision', N'Honda     ')
INSERT [dbo].[LoaiXe] ([MaXe], [LoaiXe], [HangXe]) VALUES (N'WA        ', N'Wave Alpha', N'Honda     ')
INSERT [dbo].[LoaiXe] ([MaXe], [LoaiXe], [HangXe]) VALUES (N'WRSX      ', N'Wave RSX', N'Honda     ')
INSERT [dbo].[LoaiXe] ([MaXe], [LoaiXe], [HangXe]) VALUES (N'WX        ', N'Winner X', N'Honda     ')
INSERT [dbo].[LoaiXe] ([MaXe], [LoaiXe], [HangXe]) VALUES (N'Zp        ', N'Zip', N'Piaggio   ')
GO
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [SDT], [DiaChi]) VALUES (N'NCC001    ', N'Yamaha', N'18001588          ', N'Thôn Bình An, Xã Trung Giã, Huyện Sóc Sơn, TP. Hà Nội')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [SDT], [DiaChi]) VALUES (N'NCC002    ', N'Honda', N'18008001          ', N'Phường Phúc Thắng, Thành Phố Phúc Yên, Tỉnh Vĩnh Phúc, Việt Nam')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [SDT], [DiaChi]) VALUES (N'NCC003    ', N'Piaggio', N'0249857284        ', N'Tp. Hồ Chí Minh')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [SDT], [DiaChi]) VALUES (N'NCC004    ', N'SYM', N'0251.3.812080     ', N' Lô số 4, đường số 5C, KCN Nhơn Trạch 2, Đồng Nai')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [SDT], [DiaChi]) VALUES (N'NCC005    ', N'Suzuki', N'028. 62929119     ', N'Đường số 2, KCN Long Bình, P. Long Bình,
TP. Biên Hòa, Đồng Nai')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [SDT], [DiaChi]) VALUES (N'NCC006    ', N'Ducati', N'0287847563        ', N'TẦNG 1, TÒA NHÀ PACKSIMEX, SỐ 52 ĐÔNG DU, PHƯỜNG BẾN NGHÉ, QUẬN 1, TP. HỒ CHÍ MINH')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [SDT], [DiaChi]) VALUES (N'NCC007    ', N'Kawasaki', N'+(84) 28 3925 5899', N'Phòng 709, Tầng 7, toà nhà Zen Plaza,

54-56 Đường Nguyễn Trãi,Phường Bến Thành, Quận 1,

Thành Phố Hồ Chí Minh')
GO
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [SDT], [ChucVu], [DiaChi]) VALUES (N'NV001     ', N'Bùi Tiến Quốc', N'0558493827', N'Giám Đốc', N'Đồng Nai')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [SDT], [ChucVu], [DiaChi]) VALUES (N'NV002     ', N'Phạm Hoàng Phúc', N'0984763524', N'Trợ lý', N'Long An')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [SDT], [ChucVu], [DiaChi]) VALUES (N'NV003     ', N'Lâm Dương Diễm', N'0789645123', N'Thu ngân', N'Tiền Giang')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [SDT], [ChucVu], [DiaChi]) VALUES (N'NV004     ', N'Đinh Đức Huy', N'0957480985', N'Kỹ thuật viên', N'Tây Ninh')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [SDT], [ChucVu], [DiaChi]) VALUES (N'NV005     ', N'Phan Dương Nam', N'0364751209', N'Thợ máy', N'Bình Thuận')
GO
INSERT [dbo].[TaiKhoan] ([TenDangNhap], [MatKhau]) VALUES (N'admin', N'12345')
GO
INSERT [dbo].[Xe] ([MaXe], [HangXe], [MauSac], [SoKhung], [SoMay], [GiaBan]) VALUES (N'AB        ', N'Honda', N'Trắng', N'SKAT789   ', N'SMAT789   ', 40000000)
INSERT [dbo].[Xe] ([MaXe], [HangXe], [MauSac], [SoKhung], [SoMay], [GiaBan]) VALUES (N'AT        ', N'SYM', N'Trắng', N'SKAT789   ', N'SMAT789   ', 40000000)
INSERT [dbo].[Xe] ([MaXe], [HangXe], [MauSac], [SoKhung], [SoMay], [GiaBan]) VALUES (N'BL        ', N'Honda', N'Đen', N'SKAB123   ', N'SMAB123   ', 45000000)
INSERT [dbo].[Xe] ([MaXe], [HangXe], [MauSac], [SoKhung], [SoMay], [GiaBan]) VALUES (N'EX        ', N'Yamaha', N'Xanh', N'SKEX456   ', N'SMEX456   ', 50000000)
INSERT [dbo].[Xe] ([MaXe], [HangXe], [MauSac], [SoKhung], [SoMay], [GiaBan]) VALUES (N'LBT       ', N'Piaggio', N'Trắng', N'SKLBT135  ', N'SMLBT135  ', 35000000)
INSERT [dbo].[Xe] ([MaXe], [HangXe], [MauSac], [SoKhung], [SoMay], [GiaBan]) VALUES (N'LD        ', N'Honda', N'Đen', N'SKLD123   ', N'SMLD123   ', 55000000)
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDon_HoaDonBanXe] FOREIGN KEY([MaHD])
REFERENCES [dbo].[HoaDonBanXe] ([MaHD])
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [FK_ChiTietHoaDon_HoaDonBanXe]
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuNhap_LoaiXe] FOREIGN KEY([MaXe])
REFERENCES [dbo].[LoaiXe] ([MaXe])
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap] CHECK CONSTRAINT [FK_ChiTietPhieuNhap_LoaiXe]
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuNhap_NhaCungCap] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NhaCungCap] ([MaNCC])
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap] CHECK CONSTRAINT [FK_ChiTietPhieuNhap_NhaCungCap]
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuNhap_PhieuNhap] FOREIGN KEY([MaPN])
REFERENCES [dbo].[PhieuNhap] ([MaPN])
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap] CHECK CONSTRAINT [FK_ChiTietPhieuNhap_PhieuNhap]
GO
ALTER TABLE [dbo].[HoaDonBanXe]  WITH CHECK ADD  CONSTRAINT [FK_HoaDonBanXe_KhachHang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[HoaDonBanXe] CHECK CONSTRAINT [FK_HoaDonBanXe_KhachHang]
GO
ALTER TABLE [dbo].[HoaDonBanXe]  WITH CHECK ADD  CONSTRAINT [FK_HoaDonBanXe_LoaiXe] FOREIGN KEY([MaXe])
REFERENCES [dbo].[LoaiXe] ([MaXe])
GO
ALTER TABLE [dbo].[HoaDonBanXe] CHECK CONSTRAINT [FK_HoaDonBanXe_LoaiXe]
GO
ALTER TABLE [dbo].[HoaDonBanXe]  WITH CHECK ADD  CONSTRAINT [FK_HoaDonBanXe_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[HoaDonBanXe] CHECK CONSTRAINT [FK_HoaDonBanXe_NhanVien]
GO
ALTER TABLE [dbo].[PhieuBaoHanh]  WITH CHECK ADD  CONSTRAINT [FK_PhieuBaoHanh_HoaDonBanXe] FOREIGN KEY([MaHD])
REFERENCES [dbo].[HoaDonBanXe] ([MaHD])
GO
ALTER TABLE [dbo].[PhieuBaoHanh] CHECK CONSTRAINT [FK_PhieuBaoHanh_HoaDonBanXe]
GO
ALTER TABLE [dbo].[PhieuBaoHanh]  WITH CHECK ADD  CONSTRAINT [FK_PhieuBaoHanh_KhachHang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[PhieuBaoHanh] CHECK CONSTRAINT [FK_PhieuBaoHanh_KhachHang]
GO
ALTER TABLE [dbo].[Xe]  WITH CHECK ADD  CONSTRAINT [FK_Xe_LoaiXe] FOREIGN KEY([MaXe])
REFERENCES [dbo].[LoaiXe] ([MaXe])
GO
ALTER TABLE [dbo].[Xe] CHECK CONSTRAINT [FK_Xe_LoaiXe]
GO
