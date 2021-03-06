USE [DBGiayDep]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 11/18/2015 17:07:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [int] IDENTITY(1,1) NOT NULL,
	[HoTen] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[MatKhau] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SDT] [nvarchar](50) NULL,
	[CMND] [nvarchar](9) NULL,
	[QuyenAdmin] [int] NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[NhanVien] ON
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [Email], [MatKhau], [DiaChi], [SDT], [CMND], [QuyenAdmin]) VALUES (2, N'Bùi Duy Trình', N'buiduy.trinh515@gmail.com', N'123456', N'Kinh Dương Vương, Hồ Chí Minh', N'0978595230', N'285342647', 1)
SET IDENTITY_INSERT [dbo].[NhanVien] OFF
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 11/18/2015 17:07:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaCungCap](
	[MaNCC] [int] IDENTITY(1,1) NOT NULL,
	[TenNCC] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SDT] [nvarchar](50) NULL,
	[SoTK] [nvarchar](50) NULL,
 CONSTRAINT [PK_NhaCungCap] PRIMARY KEY CLUSTERED 
(
	[MaNCC] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[NhaCungCap] ON
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [DiaChi], [SDT], [SoTK]) VALUES (1, N'Giày Adidas', N'31 Thanh Xuân, Hà Nội', N'048090090', N'1223456789087')
SET IDENTITY_INSERT [dbo].[NhaCungCap] OFF
/****** Object:  Table [dbo].[Mau]    Script Date: 11/18/2015 17:07:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mau](
	[MaMau] [int] IDENTITY(1,1) NOT NULL,
	[TenMau] [nvarchar](50) NULL,
 CONSTRAINT [PK_Mau] PRIMARY KEY CLUSTERED 
(
	[MaMau] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Mau] ON
INSERT [dbo].[Mau] ([MaMau], [TenMau]) VALUES (1, N'Đỏ')
INSERT [dbo].[Mau] ([MaMau], [TenMau]) VALUES (2, N'Xanh')
INSERT [dbo].[Mau] ([MaMau], [TenMau]) VALUES (3, N'Vàng')
SET IDENTITY_INSERT [dbo].[Mau] OFF
/****** Object:  Table [dbo].[Loai]    Script Date: 11/18/2015 17:07:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Loai](
	[MaLoai] [int] IDENTITY(1,1) NOT NULL,
	[TenLoai] [nvarchar](50) NULL,
 CONSTRAINT [PK_Loai] PRIMARY KEY CLUSTERED 
(
	[MaLoai] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Loai] ON
INSERT [dbo].[Loai] ([MaLoai], [TenLoai]) VALUES (1, N'Nam')
INSERT [dbo].[Loai] ([MaLoai], [TenLoai]) VALUES (2, N'Nữ')
INSERT [dbo].[Loai] ([MaLoai], [TenLoai]) VALUES (3, N'Trẻ Em')
SET IDENTITY_INSERT [dbo].[Loai] OFF
/****** Object:  Table [dbo].[KhuyenMai]    Script Date: 11/18/2015 17:07:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhuyenMai](
	[MaKM] [int] IDENTITY(1,1) NOT NULL,
	[TenKM] [nvarchar](50) NULL,
	[NgayBD] [datetime] NULL,
	[NgayKT] [datetime] NULL,
 CONSTRAINT [PK_KhuyenMai] PRIMARY KEY CLUSTERED 
(
	[MaKM] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[KhuyenMai] ON
INSERT [dbo].[KhuyenMai] ([MaKM], [TenKM], [NgayBD], [NgayKT]) VALUES (1, N'Không khuyễn mãi', NULL, NULL)
SET IDENTITY_INSERT [dbo].[KhuyenMai] OFF
/****** Object:  Table [dbo].[KhachHang]    Script Date: 11/18/2015 17:07:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKH] [int] IDENTITY(1,1) NOT NULL,
	[HoTen] [nvarchar](50) NULL,
	[NgaySinh] [datetime] NULL,
	[Email] [nvarchar](50) NULL,
	[MatKhau] [nvarchar](50) NULL,
	[SDT] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[GioiTinh] [nvarchar](50) NULL,
	[NgayDangKi] [datetime] NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[KhachHang] ON
INSERT [dbo].[KhachHang] ([MaKH], [HoTen], [NgaySinh], [Email], [MatKhau], [SDT], [DiaChi], [GioiTinh], [NgayDangKi]) VALUES (1, N'Bùi Duy Trình', CAST(0x000085AA00000000 AS DateTime), N'buiduy.trinh515@gmail.com', N'123456', N'0978595230', N'81 Kinh Dương Vương, Quận 6', N'1', CAST(0x0000A56B00000000 AS DateTime))
INSERT [dbo].[KhachHang] ([MaKH], [HoTen], [NgaySinh], [Email], [MatKhau], [SDT], [DiaChi], [GioiTinh], [NgayDangKi]) VALUES (2, N'Nguyen DUy Huy', CAST(0x0000834900000000 AS DateTime), N'huy@gmail.com', N'123456', N'09778887788', N'81 Kinh Dương Vương, Quận 6', N'Nam', CAST(0x0000A56B00000000 AS DateTime))
SET IDENTITY_INSERT [dbo].[KhachHang] OFF
/****** Object:  Table [dbo].[Size]    Script Date: 11/18/2015 17:07:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Size](
	[MaSize] [int] IDENTITY(1,1) NOT NULL,
	[Size] [int] NULL,
 CONSTRAINT [PK_Size] PRIMARY KEY CLUSTERED 
(
	[MaSize] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Size] ON
INSERT [dbo].[Size] ([MaSize], [Size]) VALUES (1, 35)
INSERT [dbo].[Size] ([MaSize], [Size]) VALUES (2, 36)
INSERT [dbo].[Size] ([MaSize], [Size]) VALUES (3, 37)
INSERT [dbo].[Size] ([MaSize], [Size]) VALUES (4, 38)
INSERT [dbo].[Size] ([MaSize], [Size]) VALUES (5, 39)
INSERT [dbo].[Size] ([MaSize], [Size]) VALUES (6, 40)
INSERT [dbo].[Size] ([MaSize], [Size]) VALUES (7, 41)
INSERT [dbo].[Size] ([MaSize], [Size]) VALUES (8, 42)
INSERT [dbo].[Size] ([MaSize], [Size]) VALUES (9, 43)
SET IDENTITY_INSERT [dbo].[Size] OFF
/****** Object:  Table [dbo].[SanPham]    Script Date: 11/18/2015 17:07:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanPham](
	[MaSP] [int] IDENTITY(1,1) NOT NULL,
	[TenSP] [nvarchar](50) NULL,
	[MaLoai] [int] NULL,
	[ThuongHieu] [nvarchar](50) NULL,
	[HinhAnh] [nvarchar](100) NULL,
	[MoTa] [nvarchar](100) NULL,
	[MaKM] [int] NULL,
	[NgayDang] [datetime] NULL,
	[MoTaCT] [nvarchar](max) NULL,
 CONSTRAINT [PK_SanPham] PRIMARY KEY CLUSTERED 
(
	[MaSP] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[SanPham] ON
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaLoai], [ThuongHieu], [HinhAnh], [MoTa], [MaKM], [NgayDang], [MoTaCT]) VALUES (1, N'Nike Cao cấp', 1, N'Nike', N'nike1.jpg', N'Đây là sản phẩm cao cấp', 1, CAST(0x0000A47700000000 AS DateTime), N'Sản Phẩm cao cấp giành cho phái mạnh')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaLoai], [ThuongHieu], [HinhAnh], [MoTa], [MaKM], [NgayDang], [MoTaCT]) VALUES (2, N'Nike', 1, N'Nike', N'nike12.jpg', N'SP', 1, NULL, N'sas')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaLoai], [ThuongHieu], [HinhAnh], [MoTa], [MaKM], [NgayDang], [MoTaCT]) VALUES (3, N'nike ', 1, N'Nike', N'nike13.jpg', N'Sản Phẩm của Nike', 1, NULL, N'312')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaLoai], [ThuongHieu], [HinhAnh], [MoTa], [MaKM], [NgayDang], [MoTaCT]) VALUES (4, N'Gym Warrior .2', 1, N'Adidas', N'm11.jpg m12.jpg m13.jpg', N'Giày nam', 1, CAST(0x0000000000000000 AS DateTime), N'Giày training, Màu: Ðen, tr?ng, xám')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaLoai], [ThuongHieu], [HinhAnh], [MoTa], [MaKM], [NgayDang], [MoTaCT]) VALUES (5, N'adipure 360.3 Shoes', 1, N'Adidas', N'm21.jpg m22.jpg m23.jpg', N'Giày nam', 1, CAST(0x0000000000000000 AS DateTime), N'Giày training, Màu: Ðen, tr?ng, xám, d? den, vàng, xanh')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaLoai], [ThuongHieu], [HinhAnh], [MoTa], [MaKM], [NgayDang], [MoTaCT]) VALUES (6, N'ZX FLUX NPS UPDT AF6353', 1, N'Adidas', N'm31.jpg m32.jpg m33.jpg', N'Giày nam', 1, CAST(0x0000000000000000 AS DateTime), N'Giày training, Màu: den, xanh')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaLoai], [ThuongHieu], [HinhAnh], [MoTa], [MaKM], [NgayDang], [MoTaCT]) VALUES (7, N'Gym Warrior .1', 1, N'Adidas', N'm41.jpg m42.jpg m43.jpg', N'Giày nam', 1, CAST(0x0000000000000000 AS DateTime), N'Giày training, Màu: cam, xanh den')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaLoai], [ThuongHieu], [HinhAnh], [MoTa], [MaKM], [NgayDang], [MoTaCT]) VALUES (8, N'adipure 360.4 Shoes', 1, N'Adidas', N'm51.jpg m52.jpg m53.jpg', N'Giày nam', 1, CAST(0x0000000000000000 AS DateTime), N'Giày training, Màu: den, xanh den, vàng den')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaLoai], [ThuongHieu], [HinhAnh], [MoTa], [MaKM], [NgayDang], [MoTaCT]) VALUES (9, N'adipure 360.5 Shoes', 1, N'Adidas', N'm61.jpg m62.jpg m63.jpg', N'Giày nam', 1, CAST(0x0000000000000000 AS DateTime), N'Giày training, Màu: vàng, den, xanh, b?c')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaLoai], [ThuongHieu], [HinhAnh], [MoTa], [MaKM], [NgayDang], [MoTaCT]) VALUES (10, N'adipure 360.1 Shoes', 1, N'Adidas', N'm71.jpg m72.jpg m73.jpg', N'Giày nam', 1, CAST(0x0000000000000000 AS DateTime), N'Giày training, Màu: den b?c, xanh den')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaLoai], [ThuongHieu], [HinhAnh], [MoTa], [MaKM], [NgayDang], [MoTaCT]) VALUES (11, N'Essential Star 2.0', 1, N'Adidas', N'm81.jpg m82.jpg m83.jpg', N'Giày nam', 1, CAST(0x0000000000000000 AS DateTime), N'Giày training, Màu: den, xanh, tr?ng')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaLoai], [ThuongHieu], [HinhAnh], [MoTa], [MaKM], [NgayDang], [MoTaCT]) VALUES (12, N'adidas STELLASPORT Zais', 2, N'Adidas', N'w11.jpg w12.jpg w13.jpg', N'Giày nữ', 1, CAST(0x0000000000000000 AS DateTime), N'Giày training, Màu: vàng h?ng')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaLoai], [ThuongHieu], [HinhAnh], [MoTa], [MaKM], [NgayDang], [MoTaCT]) VALUES (13, N'adidas STELLASPORT Irana', 2, N'Adidas', N'w21.jpg w22.jpg w23.jpg', N'Giày n?', 1, CAST(0x0000000000000000 AS DateTime), N'Giày training, Màu: Ðen')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaLoai], [ThuongHieu], [HinhAnh], [MoTa], [MaKM], [NgayDang], [MoTaCT]) VALUES (14, N'adidas STELLASPORT Yvori', 2, N'Adidas', N'w31.jpg w32.jpg w33.jpg', N'Giày n?', 1, CAST(0x0000000000000000 AS DateTime), N'Giày training, Màu: Tr?ng, b?c')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaLoai], [ThuongHieu], [HinhAnh], [MoTa], [MaKM], [NgayDang], [MoTaCT]) VALUES (15, N'Atani Bounce', 2, N'Adidas', N'w41.jpg w42.jpg w43.jpg', N'Giày n?', 1, CAST(0x0000000000000000 AS DateTime), N'Giày training, Màu: vàng, den, xanh-den')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaLoai], [ThuongHieu], [HinhAnh], [MoTa], [MaKM], [NgayDang], [MoTaCT]) VALUES (16, N'Atani Bounce 02', 2, N'Adidas', N'w51.jpg w52.jpg w53.jpg', N'Giày n?', 1, CAST(0x0000000000000000 AS DateTime), N'Giày training, Màu: tr?ng-b?c, tr?ng-den')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaLoai], [ThuongHieu], [HinhAnh], [MoTa], [MaKM], [NgayDang], [MoTaCT]) VALUES (17, N'adipure 360.3 Shoes', 2, N'Adidas', N'w61.jpg w62.jpg w63.jpg', N'Giày n?', 1, CAST(0x0000000000000000 AS DateTime), N'Giày training, Màu: vàng-den, den-h?ng, den-tr?ng')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaLoai], [ThuongHieu], [HinhAnh], [MoTa], [MaKM], [NgayDang], [MoTaCT]) VALUES (18, N'adipure 360.4 Shoes', 2, N'Adidas', N'w71.jpg w72.jpg w73.jpg', N'Giày n?', 1, CAST(0x0000000000000000 AS DateTime), N'Giày training, Màu: h?ng-den')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaLoai], [ThuongHieu], [HinhAnh], [MoTa], [MaKM], [NgayDang], [MoTaCT]) VALUES (19, N'Atani Bounce', 2, N'Adidas', N'w81.jpg w82.jpg w83.jpg', N'Giày n?', 1, CAST(0x0000000000000000 AS DateTime), N'Giày training, Màu: vàng h?ng')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaLoai], [ThuongHieu], [HinhAnh], [MoTa], [MaKM], [NgayDang], [MoTaCT]) VALUES (20, N'Snice 4', 3, N'Adidas', N'k11.jpg k12.jpg k13.jpg', N'Giày tr? em', 1, CAST(0x0000000000000000 AS DateTime), N'Giày cho tr? em nam/n?, Màu: den-xanh lá, den-xanh, den-tr?ng, xanh-h?ng')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaLoai], [ThuongHieu], [HinhAnh], [MoTa], [MaKM], [NgayDang], [MoTaCT]) VALUES (21, N'Messi Shoes', 3, N'Adidas', N'k21.jpg k22.jpg k23.jpg', N'Giày tr? em', 1, CAST(0x0000000000000000 AS DateTime), N'Giày cho tr? em nam/n?, Màu: tr?ng-xanh')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaLoai], [ThuongHieu], [HinhAnh], [MoTa], [MaKM], [NgayDang], [MoTaCT]) VALUES (22, N'Trainer 6', 3, N'Adidas', N'k31.jpg k32.jpg k33.jpg', N'Giày tr? em', 1, CAST(0x0000000000000000 AS DateTime), N'Giày cho tr? em nam/n?, Màu: h?ng, tr?bg-xanh, b?c-h?ng')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaLoai], [ThuongHieu], [HinhAnh], [MoTa], [MaKM], [NgayDang], [MoTaCT]) VALUES (23, N'X Football Trainer ', 3, N'Adidas', N'k41.jpg k42.jpg k43.jpg', N'Giày tr? em', 1, CAST(0x0000000000000000 AS DateTime), N'Giày cho tr? em nam/n?, Màu: tr?ng-vàng, d?-den')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaLoai], [ThuongHieu], [HinhAnh], [MoTa], [MaKM], [NgayDang], [MoTaCT]) VALUES (24, N'STA Fluid 3', 3, N'Adidas', N'k51.jpg k52.jpg k53.jpg', N'Giày tr? em', 1, CAST(0x0000000000000000 AS DateTime), N'Giày cho tr? em nam/n?, Màu: h?ng-xanh, tr?ng-xanh')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaLoai], [ThuongHieu], [HinhAnh], [MoTa], [MaKM], [NgayDang], [MoTaCT]) VALUES (25, N'Messi Shoes 2', 3, N'Adidas', N'k61.jpg k62.jpg k63.jpg', N'Giày tr? em', 1, CAST(0x0000000000000000 AS DateTime), N'Giày cho tr? em nam/n?, Màu: den-b?c')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaLoai], [ThuongHieu], [HinhAnh], [MoTa], [MaKM], [NgayDang], [MoTaCT]) VALUES (26, N'Skr H Jsy', 3, N'Adidas', N'k71.jpg k72.jpg k73.jpg', N'Giày tr? em', 1, CAST(0x0000000000000000 AS DateTime), N'Giày cho tr? em nam/n?, Màu: vàng-tr?ng')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaLoai], [ThuongHieu], [HinhAnh], [MoTa], [MaKM], [NgayDang], [MoTaCT]) VALUES (27, N'Marvel Avengers Lo', 3, N'Adidas', N'k81.jpg k82.jpg k83.jpg', N'Giày tr? em', 1, CAST(0x0000000000000000 AS DateTime), N'Giày cho tr? em nam/n?, Màu: d?-vàng')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaLoai], [ThuongHieu], [HinhAnh], [MoTa], [MaKM], [NgayDang], [MoTaCT]) VALUES (28, N'New Balance 690v4', 3, N'New Balance', N'nk11.jpg nk12.jpg nk13.jpg', N'Giày tr? nam', 1, CAST(0x0000000000000000 AS DateTime), N'Màu: xanh-cam, xanh-tr?ng, xám-vàng, xám-d?, V?i công ngh? d?m nh?, ?n d?nh, h? tr? ho?t d?ng liên t?c')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaLoai], [ThuongHieu], [HinhAnh], [MoTa], [MaKM], [NgayDang], [MoTaCT]) VALUES (29, N'New Balance 880v5', 3, N'New Balance', N'nk21.jpg nk22.jpg nk23.jpg', N'Giày tr? nam', 1, CAST(0x0000000000000000 AS DateTime), N'Màu: xám-vàng, New Balance 880v5 có hai l?p mút x?p t?o c?m giác êm ái, m?m m?i, không c?m th?y khó ch?u ')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaLoai], [ThuongHieu], [HinhAnh], [MoTa], [MaKM], [NgayDang], [MoTaCT]) VALUES (30, N'New Balance 860v5', 3, N'New Balance', N'nk31.jpg nk32.jpg nk33.jpg', N'Giày tr? nam', 1, CAST(0x0000000000000000 AS DateTime), N'Màu: Xanh navy-d?, thi?t k? cho tr? thích ch?y nh?y m?nh, cung c?p d?m cao cho l?i s?ng nang d?ng và b?o v? dôi chân toàn di?n')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaLoai], [ThuongHieu], [HinhAnh], [MoTa], [MaKM], [NgayDang], [MoTaCT]) VALUES (31, N'New Balance 890v4', 3, N'New Balance', N'nk41.jpg nk42.jpg nk43.jpg', N'Giày tr? nam', 1, CAST(0x0000000000000000 AS DateTime), N'Màu: xám-d?, V?i mô hình crackle d?m, d?m nh? và h? tr? c?n thi?t cho t?ng bu?c di')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaLoai], [ThuongHieu], [HinhAnh], [MoTa], [MaKM], [NgayDang], [MoTaCT]) VALUES (32, N'New Balance 890v5', 3, N'New Balance', N'nk51.jpg nk52.jpg nk53.jpg', N'Giày tr? n?', 1, CAST(0x0000000000000000 AS DateTime), N'Màu: h?ng-xanh, xanh-h?ng, Bùng n? v? màu s?c v?i công ngh? d?m nh?, thích h?p d? t?p gym ')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaLoai], [ThuongHieu], [HinhAnh], [MoTa], [MaKM], [NgayDang], [MoTaCT]) VALUES (33, N'New Balance 790v5', 3, N'New Balance', N'nk61.jpg nk62.jpg nk63.jpg', N'Giày tr? n?', 1, CAST(0x0000000000000000 AS DateTime), N'Màu: h?ng-den, Mang l?i tính da d?ng và phong cách v?i s?c màu tuoi m?i, dôi giày gi? s? nang d?ng cho nh?ng d?a tr? ho?t d?ng nhi?u nh?t')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaLoai], [ThuongHieu], [HinhAnh], [MoTa], [MaKM], [NgayDang], [MoTaCT]) VALUES (34, N'New Balance 880v5', 3, N'New Balance', N'nk71.jpg nk72.jpg nk73.jpg', N'Giày tr? n?', 1, CAST(0x0000000000000000 AS DateTime), N'Màu: xám-h?ng, V?i công ngh? d?m nh?, ?n d?nh, h? tr? ho?t d?ng liên t?c ')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaLoai], [ThuongHieu], [HinhAnh], [MoTa], [MaKM], [NgayDang], [MoTaCT]) VALUES (35, N'New Balance 775', 3, N'New Balance', N'nk81.jpg nk82.jpg nk83.jpg', N'Giày tr? n?', 1, CAST(0x0000000000000000 AS DateTime), N'Màu: xanh-b?c, h?ng-b?c, Không bao gi? l?i th?i, v?i phong cách th? thao và siêu linh ho?t cho d?a tr? không b? ch?m l?i')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaLoai], [ThuongHieu], [HinhAnh], [MoTa], [MaKM], [NgayDang], [MoTaCT]) VALUES (36, N'Limited Edition Vazee Pace NYC', 1, N'New Balance', N'nm11.jpg nm12.jpg nm13.jpg', N'Giày nam ch?y b?', 1, CAST(0x0000000000000000 AS DateTime), N'Màu: cam-xanh, Truy?n c?m h?ng cho b?n ch?y nhanh nh?t, b?t c? thành ph? nào ')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaLoai], [ThuongHieu], [HinhAnh], [MoTa], [MaKM], [NgayDang], [MoTaCT]) VALUES (37, N'Vazee Pace Protect Pack', 1, N'New Balance', N'nm21.jpg nm22.jpg nm23.jpg', N'Giày nam ch?y b?', 1, CAST(0x0000000000000000 AS DateTime), N'Màu: d? dô, h?u du?c th?i ti?t, lu?i khép kín giúp b?n luôn tho?i mái b?t c? di?u gì m? thiên nhiên mang l?i. V?i m?t cái nhìn tuoi m?i và c?m ?ng, giày d?m trung tính c?a ngu?i dàn ông này dã s?n sàng d? dua b?n ch?y d?n c?p d? m?i.')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaLoai], [ThuongHieu], [HinhAnh], [MoTa], [MaKM], [NgayDang], [MoTaCT]) VALUES (38, N'Vazee Pace NB Beacon', 1, N'New Balance', N'nm31.jpg nm32.jpg nm33.jpg', N'Giày nam ch?y b?', 1, CAST(0x0000000000000000 AS DateTime), N'Màu: den-d?, xanh-xám, vàng-xám, V?i 360 d? c?a ph?n x? và các di?m nh?n màu s?c r?t d? th?y, giày này ch?y ?ng giúp b?n n?i b?t gi?a dám dông, ngày hay dêm.')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaLoai], [ThuongHieu], [HinhAnh], [MoTa], [MaKM], [NgayDang], [MoTaCT]) VALUES (39, N'Fresh Foam Zante', 1, N'New Balance', N'nm41.jpg nm42.jpg nm43.jpg', N'Giày nam ch?y b?', 1, CAST(0x0000000000000000 AS DateTime), N'Màu: navy, navy-vàng, navy-h?ng, xám-vàng, T?o c?m giác êm ái t? gót chân t?i t?ng ngón chân, dem d?n cho b?n co h?i d? du?ng ch?y t?t hon')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaLoai], [ThuongHieu], [HinhAnh], [MoTa], [MaKM], [NgayDang], [MoTaCT]) VALUES (40, N'1400v3', 1, N'New Balance', N'nm51.jpg nm52.jpg nm53.jpg', N'Giày nam ch?y b?', 1, CAST(0x0000000000000000 AS DateTime), N'Màu: cam-xanh lá, d?-xám, Lo?i b? nh?ng gì không c?n thi?t và gi?m tr?ng lu?ng t?i da h? tr? dua trên t?ng ch?ng du?ng và d?n d?u trong t?c d?')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaLoai], [ThuongHieu], [HinhAnh], [MoTa], [MaKM], [NgayDang], [MoTaCT]) VALUES (41, N'Fresh Foam 980 Trail', 1, N'New Balance', N'nm61.jpg nm62.jpg nm63.jpg', N'Giày nam ch?y b?', 1, CAST(0x0000000000000000 AS DateTime), N'Màu: d?-den-vàng, b?o v? dôi chân b?n trong nh?ng d?a hình kh?c nghi?t nh?t')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaLoai], [ThuongHieu], [HinhAnh], [MoTa], [MaKM], [NgayDang], [MoTaCT]) VALUES (42, N'New Balance 101', 1, N'New Balance', N'nm71.jpg nm72.jpg nm73.jpg', N'Giày nam bóng chuy?n', 1, CAST(0x0000000000000000 AS DateTime), N'Màu: den, T?o s? tho?i mái cao nh?t, cung c?p s?n sàng cho cung du?ng dài nh?t')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaLoai], [ThuongHieu], [HinhAnh], [MoTa], [MaKM], [NgayDang], [MoTaCT]) VALUES (43, N'Minimus Zero v2', 1, N'New Balance', N'nm81.jpg nm82.jpg nm83.jpg', N'Giày nam gym', 1, CAST(0x0000000000000000 AS DateTime), N'Màu: xanh-vàng, K?t h?p các c?m giác t? nhiên c?a chân tr?n ch?y v?i b?o v? b?n c?n d? ti?p t?c di trên du?ng')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaLoai], [ThuongHieu], [HinhAnh], [MoTa], [MaKM], [NgayDang], [MoTaCT]) VALUES (44, N'530 90s Running Woods', 2, N'New Balance', N'nw11.jpg nw12.jpg nw13.jpg', N'Giày n? ch?y classic', 1, CAST(0x0000000000000000 AS DateTime), N'Màu: den-d?, navy-xam, h?ng hình bóng c? di?n và tho?i mái xem là t?t c? nh?ng nam 90 trong khi b?ng màu phong phú c?a giày mang l?i màu trung tính c?a th?p niên 70.')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaLoai], [ThuongHieu], [HinhAnh], [MoTa], [MaKM], [NgayDang], [MoTaCT]) VALUES (45, N'620 Street Beat', 2, N'New Balance', N'nw21.jpg nw22.jpg nw23.jpg', N'Giày n? ch?y classic', 1, CAST(0x0000000000000000 AS DateTime), N'Màu: navy, xám-xanh lá, den-h?ng, phong cách m?i cho m?t cái nhìn c? di?n mà c?p v?i ch? là v? t?t c? m?i th?.')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaLoai], [ThuongHieu], [HinhAnh], [MoTa], [MaKM], [NgayDang], [MoTaCT]) VALUES (46, N'420 Glam', 2, N'New Balance', N'nw31.jpg nw32.jpg nw33.jpg', N'Giày n? ch?y classic', 1, CAST(0x0000000000000000 AS DateTime), N'Màu: xanh-h?ng, navy-tím, den-vàng, Thêm ánh vào rãnh c?a b?n trong New Balance Glam 420')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaLoai], [ThuongHieu], [HinhAnh], [MoTa], [MaKM], [NgayDang], [MoTaCT]) VALUES (47, N'530 Elite Edition Pinball', 2, N'New Balance', N'nw41.jpg nw42.jpg nw43.jpg', N'Giày n? ch?y classic', 1, CAST(0x0000000000000000 AS DateTime), N'Màu: h?ng-xanh-vàng, d?-xanh-vàng. L?y c?m h?ng t? máy pinball s?ng d?ng t? nh?ng nam 90. Sneaker c?a nhà suu t?p này có da l?n phong phú và lu?i trong màu s?c mà t? lòng tôn kính v?i các trò choi yêu thích')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaLoai], [ThuongHieu], [HinhAnh], [MoTa], [MaKM], [NgayDang], [MoTaCT]) VALUES (48, N'620 Lakeview', 2, N'New Balance', N'nw51.jpg nw52.jpg nw53.jpg', N'Giày n? ch?y classic', 1, CAST(0x0000000000000000 AS DateTime), N'Màu: den, b?c, xanh, Phong cách sang tr?ng c? di?n')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaLoai], [ThuongHieu], [HinhAnh], [MoTa], [MaKM], [NgayDang], [MoTaCT]) VALUES (49, N'574 Mineral Glow', 2, N'New Balance', N'nw61.jpg nw62.jpg nw63.jpg', N'Giày n? ch?y classic', 1, CAST(0x0000000000000000 AS DateTime), N'Màu: tím d?ng, den, xám danh')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaLoai], [ThuongHieu], [HinhAnh], [MoTa], [MaKM], [NgayDang], [MoTaCT]) VALUES (50, N'999 Shadows', 2, N'New Balance', N'nw71.jpg nw72.jpg nw73.jpg', N'Giày n? ch?y classic', 1, CAST(0x0000000000000000 AS DateTime), N'Màu: xanh lá d?m-tr?ng')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaLoai], [ThuongHieu], [HinhAnh], [MoTa], [MaKM], [NgayDang], [MoTaCT]) VALUES (51, N'999 Tartan', 2, N'New Balance', N'nw81.jpg nw82.jpg nw83.jpg', N'Giày n? ch?y classic', 1, CAST(0x0000000000000000 AS DateTime), N'Màu: xám navy')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaLoai], [ThuongHieu], [HinhAnh], [MoTa], [MaKM], [NgayDang], [MoTaCT]) VALUES (52, N'SUEDE JR SNEAKERS', 3, N'Puma', N'pk11.jpg pk12.jpg pk13.jpg', N'Giày tr? em', 1, CAST(0x0000000000000000 AS DateTime), N'-Da l?n có duc l? chi ti?t, -Ren dóng cho v?a khít, -Tr?ng lu?ng: 7.7 ounces (size 1), -')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaLoai], [ThuongHieu], [HinhAnh], [MoTa], [MaKM], [NgayDang], [MoTaCT]) VALUES (53, N'CABANA RACER MESH JR SNEAKERS', 3, N'Puma', N'pk21.jpg pk22.jpg pk23.jpg', N'Giày tr? em', 1, CAST(0x0000000000000000 AS DateTime), N'-Lu?i nylon c? di?n và da l?n trên, -Ð?m c?-tho?i m?c d? mang, -Tr?ng lu?ng: 5.5 ounces (size 1.5)')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaLoai], [ThuongHieu], [HinhAnh], [MoTa], [MaKM], [NgayDang], [MoTaCT]) VALUES (54, N'CABANA RACER MESH KIDS SNEAKERS', 3, N'Puma', N'pk31.jpg pk32.jpg pk33.jpg', N'Giày tr? em', 1, CAST(0x0000000000000000 AS DateTime), N'-Nylon lu?i trên v?i l?p da l?n, -Midsole d?m cho tho?i mái, -Grippy d? ngoài cao su, -Tr?ng lu?ng: 5.3 ounces (size 1)')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaLoai], [ThuongHieu], [HinhAnh], [MoTa], [MaKM], [NgayDang], [MoTaCT]) VALUES (55, N'CABANA RACER MESH KIDS SNEAKERS', 3, N'Puma', N'pk41.jpg pk42.jpg pk43.jpg', N'Giày tr? em', 1, CAST(0x0000000000000000 AS DateTime), N'-Nylon lu?i trên v?i l?p da l?n, -Midsole d?m cho tho?i mái, -Grippy d? ngoài cao su, -Tr?ng lu?ng: 5.3 ounces (size 1)')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaLoai], [ThuongHieu], [HinhAnh], [MoTa], [MaKM], [NgayDang], [MoTaCT]) VALUES (56, N'R698 MESH-NEOPRENE JR SNEAKERS', 3, N'Puma', N'pk51.jpg pk52.jpg pk53.jpg', N'Giày tr? em', 1, CAST(0x0000000000000000 AS DateTime), N'-In lu?i và cao su t?ng h?p trên v?i l?p ph? t?ng h?p, -Ren dóng cho v?a khít')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaLoai], [ThuongHieu], [HinhAnh], [MoTa], [MaKM], [NgayDang], [MoTaCT]) VALUES (57, N'ST RUNNER NYLON JR SNEAKERS', 3, N'Puma', N'pk61.jpg pk62.jpg pk63.jpg', N'Giày tr? em', 1, CAST(0x0000000000000000 AS DateTime), N'-Nylon trên v?i l?p da l?n, -Ren dóng cho v?a khít, -Tr?ng lu?ng: 4.2 ounces (size 11)')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaLoai], [ThuongHieu], [HinhAnh], [MoTa], [MaKM], [NgayDang], [MoTaCT]) VALUES (58, N'ST RUNNER NYLON KIDS SNEAKERS', 3, N'Puma', N'pk71.jpg pk72.jpg pk73.jpg', N'Giày tr? em', 1, CAST(0x0000000000000000 AS DateTime), N'-Nylon trên v?i l?p da l?n, -Ð?m EVA midsole cho tho?i mái, -Tr?ng lu?ng: 4.2 ounces (size 10.5)')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaLoai], [ThuongHieu], [HinhAnh], [MoTa], [MaKM], [NgayDang], [MoTaCT]) VALUES (59, N'ST RUNNER SUPERMAN™ JR SNEAKERS', 3, N'Puma', N'pk81.jpg pk82.jpg pk83.jpg', N'Giày tr? em', 1, CAST(0x0000000000000000 AS DateTime), N'-Da trên v?i SUPERMAN ™ lá ch?n bi?u tu?ng, -Ren dóng cho v?a khít')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaLoai], [ThuongHieu], [HinhAnh], [MoTa], [MaKM], [NgayDang], [MoTaCT]) VALUES (60, N'SUEDE CLASSIC + MENS SNEAKERS', 1, N'Puma', N'pm11.jpg pm12.jpg pm13.jpg', N'Giày nam', 1, CAST(0x0000000000000000 AS DateTime), N'-Da l?n trên có d?c chi ti?t t?i midfoot, -Ren dóng cho v?a khít, -Grippy d? ngoài cao su, -Tr?ng lu?ng: 14.5 ounces (size 9)')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaLoai], [ThuongHieu], [HinhAnh], [MoTa], [MaKM], [NgayDang], [MoTaCT]) VALUES (61, N'SUEDE CLASSIC + MENS SNEAKERS 2', 1, N'Puma', N'pm21.jpg pm22.jpg pm23.jpg', N'Giày nam', 1, CAST(0x0000000000000000 AS DateTime), N'-Da l?n trên có d?c chi ti?t t?i midfoot, -Ren dóng cho v?a khít, -Grippy d? ngoài cao su, -Tr?ng lu?ng: 14.5 ounces (size 9)')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaLoai], [ThuongHieu], [HinhAnh], [MoTa], [MaKM], [NgayDang], [MoTaCT]) VALUES (62, N'SUEDE CLASSIC + MENS SNEAKERS 3', 1, N'Puma', N'pm31.jpg pm32.jpg pm33.jpg', N'Giày nam', 1, CAST(0x0000000000000000 AS DateTime), N'-Da l?n trên có d?c chi ti?t t?i midfoot, -Ren dóng cho v?a khít, -Grippy d? ngoài cao su, -Tr?ng lu?ng: 14.5 ounces (size 9)')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaLoai], [ThuongHieu], [HinhAnh], [MoTa], [MaKM], [NgayDang], [MoTaCT]) VALUES (63, N'SUEDE CLASSIC + MENS SNEAKERS 4', 1, N'Puma', N'pm41.jpg pm42.jpg pm43.jpg', N'Giày nam', 1, CAST(0x0000000000000000 AS DateTime), N'-Da l?n trên có d?c chi ti?t t?i midfoot, -Ren dóng cho v?a khít, -Grippy d? ngoài cao su, -Tr?ng lu?ng: 14.5 ounces (size 9)')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaLoai], [ThuongHieu], [HinhAnh], [MoTa], [MaKM], [NgayDang], [MoTaCT]) VALUES (64, N'SUEDE CLASSIC + MENS SNEAKERS 5', 1, N'Puma', N'pm51.jpg pm52.jpg pm53.jpg', N'Giày nam', 1, CAST(0x0000000000000000 AS DateTime), N'-Da l?n trên có d?c chi ti?t t?i midfoot, -Ren dóng cho v?a khít, -Grippy d? ngoài cao su, -Tr?ng lu?ng: 13.1 ounces (size 9)')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaLoai], [ThuongHieu], [HinhAnh], [MoTa], [MaKM], [NgayDang], [MoTaCT]) VALUES (65, N'SUEDE CLASSIC + MONO ICED MENS SNEAKERS', 1, N'Puma', N'pm61.jpg pm62.jpg pm63.jpg', N'Giày nam', 1, CAST(0x0000000000000000 AS DateTime), N'-Da l?n trên có d?c chi ti?t t?i midfoot, -Ren dóng cho v?a khít, -Grippy d? ngoài cao su, -Tr?ng lu?ng: 14.5 ounces (size 9)')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaLoai], [ThuongHieu], [HinhAnh], [MoTa], [MaKM], [NgayDang], [MoTaCT]) VALUES (66, N'SUEDE CLASSIC + BLUR MENS SNEAKERS', 1, N'Puma', N'pm71.jpg pm72.jpg pm73.jpg', N'Giày nam', 1, CAST(0x0000000000000000 AS DateTime), N'-Da l?n cao v?i d? h?a m?, -Ren dóng cho v?a khít, -Ð? ngoài b?ng cao su cho bám, -Tr?ng lu?ng: 14.4 ounces (size 9)')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaLoai], [ThuongHieu], [HinhAnh], [MoTa], [MaKM], [NgayDang], [MoTaCT]) VALUES (67, N'SUEDE QUILTED MENS SNEAKERS', 1, N'Puma', N'pm81.jpg pm82.jpg pm83.jpg', N'Giày nam', 1, CAST(0x0000000000000000 AS DateTime), N'-Da l?n trên, -Ren dóng cho v?a khít, -Tr?ng lu?ng: 13.7 ounces (size 9)')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaLoai], [ThuongHieu], [HinhAnh], [MoTa], [MaKM], [NgayDang], [MoTaCT]) VALUES (68, N'ESKIVA HI', 2, N'Puma', N'pw11.jpg pw12.jpg pw13.jpg', N'Giày n?', 1, CAST(0x0000000000000000 AS DateTime), N'-Da trên v?i l?p ph? da l?n, -Chi?u cao Hi, -Ren dóng cho v?a khít, -Perf chi ti?t t?i lu?i')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaLoai], [ThuongHieu], [HinhAnh], [MoTa], [MaKM], [NgayDang], [MoTaCT]) VALUES (69, N'ESKIVA MID', 2, N'Puma', N'pw21.jpg pw22.jpg pw23.jpg', N'Giày n?', 1, CAST(0x0000000000000000 AS DateTime), N'-Da trên v?i l?p ph? da l?n, -Chi?u cao trung, -Slip-trong xây d?ng có dàn h?i dây deo dóng c?a và khóa kéo ? bên trung gian, -Perf chi ti?t ? lu?i và quý')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaLoai], [ThuongHieu], [HinhAnh], [MoTa], [MaKM], [NgayDang], [MoTaCT]) VALUES (70, N'SUEDE CLASSIC + BLUR WOMENS SNEAKERS', 2, N'Puma', N'pw31.jpg pw32.jpg pw33.jpg', N'Giày n?', 1, CAST(0x0000000000000000 AS DateTime), N'-Da l?n cao v?i d? h?a m?, -Ren dóng cho v?a khít, -Ð? ngoài b?ng cao su cho bám, -Tr?ng lu?ng: 11.4 ounces (size 7)')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaLoai], [ThuongHieu], [HinhAnh], [MoTa], [MaKM], [NgayDang], [MoTaCT]) VALUES (71, N'SUEDE CLASSIC MATTE & SHINE WOMENS SNEAKERS', 2, N'Puma', N'pw41.jpg pw42.jpg pw43.jpg', N'Giày n?', 1, CAST(0x0000000000000000 AS DateTime), N'-Da l?n trên v?i hi?u ?ng sáng bóng, -Ren dóng cho v?a khít, -Ð? ngoài b?ng cao su cho bám, -Tr?ng lu?ng: 10.5 ounces (size 7)')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaLoai], [ThuongHieu], [HinhAnh], [MoTa], [MaKM], [NgayDang], [MoTaCT]) VALUES (72, N'76 RUNNER FUN WOMENS SNEAKERS', 2, N'Puma', N'pw51.jpg pw52.jpg pw53.jpg', N'Giày n?', 1, CAST(0x0000000000000000 AS DateTime), N'-nylon trên, -Ren dóng cho phù h?p, -Ð?m EVA midsole cho h? tr? ki?n trúc và s? ?n d?nh, -Ð? ngoài b?ng cao su cho bám, -Tr?ng lu?ng: 6.6 ounces (size 7.5)')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaLoai], [ThuongHieu], [HinhAnh], [MoTa], [MaKM], [NgayDang], [MoTaCT]) VALUES (73, N'76 RUNNER FUN WOMENS SNEAKERS 2', 2, N'Puma', N'pw61.jpg pw62.jpg pw63.jpg', N'Giày n?', 1, CAST(0x0000000000000000 AS DateTime), N'-nylon trên, -Ren dóng cho phù h?p, -Ð?m EVA midsole cho h? tr? ki?n trúc và s? ?n d?nh, -Ð? ngoài b?ng cao su cho bám, -Tr?ng lu?ng: 6.6 ounces (size 7.5)')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaLoai], [ThuongHieu], [HinhAnh], [MoTa], [MaKM], [NgayDang], [MoTaCT]) VALUES (74, N'ARIL BASIC SPORTS WOMENS SNEAKERS', 2, N'Puma', N'pw71.jpg pw72.jpg pw73.jpg', N'Giày n?', 1, CAST(0x0000000000000000 AS DateTime), N'-Lu?i thoáng khí trên cho không khí luu thông t?t hon., -TPU yên cho s? ?n d?nh bàn chân., -Ð?m c? và lu?i cho d?m hon., -Gót chân tròn., -Ð? ngoài cao su v?i m?u gai l?p d?c bi?t.')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaLoai], [ThuongHieu], [HinhAnh], [MoTa], [MaKM], [NgayDang], [MoTaCT]) VALUES (75, N'ARIL BASIC SPORTS WOMENS SNEAKERS', 2, N'Puma', N'pw81.jpg pw82.jpg pw83.jpg', N'Giày n?', 1, CAST(0x0000000000000000 AS DateTime), N'-Lu?i thoáng khí trên cho không khí luu thông t?t hon., -TPU yên cho s? ?n d?nh bàn chân., -Ð?m c? và lu?i cho d?m hon., -Gót chân tròn., -Ð? ngoài cao su v?i m?u gai l?p d?c bi?t.')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaLoai], [ThuongHieu], [HinhAnh], [MoTa], [MaKM], [NgayDang], [MoTaCT]) VALUES (76, N'SUBLITE ESCAPE 2.0', 1, N'Reebook', N'rm11.jpg rm12.jpg rm13.jpg', N'Giày nam', 1, CAST(0x0000000000000000 AS DateTime), N'Màu: xanh, den, navy')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaLoai], [ThuongHieu], [HinhAnh], [MoTa], [MaKM], [NgayDang], [MoTaCT]) VALUES (77, N'REEBOK ROYAL ALPEREZ', 1, N'Reebook', N'rm21.jpg rm22.jpg rm23.jpg', N'Giày nam', 1, CAST(0x0000000000000000 AS DateTime), N'Màu: tr?ng, xanh lá, den, b?c, d?')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaLoai], [ThuongHieu], [HinhAnh], [MoTa], [MaKM], [NgayDang], [MoTaCT]) VALUES (78, N'SUBLITE ESCAPE 2.0', 1, N'Reebook', N'rm31.jpg rm32.jpg rm33.jpg', N'Giày nam', 1, CAST(0x0000000000000000 AS DateTime), N'Màu: xanh, dem, navy')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaLoai], [ThuongHieu], [HinhAnh], [MoTa], [MaKM], [NgayDang], [MoTaCT]) VALUES (79, N'REEBOK Z DUAL RUSH', 1, N'Reebook', N'rm41.jpg rm42.jpg rm43.jpg', N'Giày nam', 1, CAST(0x0000000000000000 AS DateTime), N'Màu: den, den-xanh lá, d?-den, tr?ng-xanh lá')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaLoai], [ThuongHieu], [HinhAnh], [MoTa], [MaKM], [NgayDang], [MoTaCT]) VALUES (80, N'PRINCESS MID', 1, N'Reebook', N'rm51.jpg rm52.jpg rm53.jpg', N'Giày nam', 1, CAST(0x0000000000000000 AS DateTime), N'Màu: tr?ng, navy')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaLoai], [ThuongHieu], [HinhAnh], [MoTa], [MaKM], [NgayDang], [MoTaCT]) VALUES (81, N'COURT VICTORY PUMP', 1, N'Reebook', N'rm61.jpg rm62.jpg rm63.jpg', N'Giày nam', 1, CAST(0x0000000000000000 AS DateTime), N'Màu: xanh, den')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaLoai], [ThuongHieu], [HinhAnh], [MoTa], [MaKM], [NgayDang], [MoTaCT]) VALUES (82, N'BB4600 HI', 1, N'Reebook', N'rm71.jpg rm72.jpg rm73.jpg', N'Giày nam', 1, CAST(0x0000000000000000 AS DateTime), N'Màu: tím, vàng, xanh, tr?ng')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaLoai], [ThuongHieu], [HinhAnh], [MoTa], [MaKM], [NgayDang], [MoTaCT]) VALUES (83, N'KAMIKAZE I MID', 1, N'Reebook', N'rm81.jpg rm82.jpg rm83.jpg', N'Giày nam', 1, CAST(0x0000000000000000 AS DateTime), N'Màu: xanh-den, d?-den, tr?ng-den, den-tr?ng')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaLoai], [ThuongHieu], [HinhAnh], [MoTa], [MaKM], [NgayDang], [MoTaCT]) VALUES (84, N'SUBLITE DUO RUSH', 2, N'Reebook', N'rw11.jpg rw12.jpg rw13.jpg', N'Giày n?', 1, CAST(0x0000000000000000 AS DateTime), N'Màu: h?ng, xám, den')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaLoai], [ThuongHieu], [HinhAnh], [MoTa], [MaKM], [NgayDang], [MoTaCT]) VALUES (85, N'RHYTHMCITY MID II', 2, N'Reebook', N'rw21.jpg rw22.jpg rw23.jpg', N'Giày n?', 1, CAST(0x0000000000000000 AS DateTime), N'Màu: tr?ng-tím')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaLoai], [ThuongHieu], [HinhAnh], [MoTa], [MaKM], [NgayDang], [MoTaCT]) VALUES (86, N'ZONE CUSHRUN', 2, N'Reebook', N'rw31.jpg rw32.jpg rw33.jpg', N'Giày n?', 1, CAST(0x0000000000000000 AS DateTime), N'Màu: cam-den, tím, d?,')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaLoai], [ThuongHieu], [HinhAnh], [MoTa], [MaKM], [NgayDang], [MoTaCT]) VALUES (87, N'REEBOK ROYAL TENSTALL', 2, N'Reebook', N'rw41.jpg rw42.jpg rw43.jpg', N'Giày n?', 1, CAST(0x0000000000000000 AS DateTime), N'Màu: h?ng, tr?ng, d?')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaLoai], [ThuongHieu], [HinhAnh], [MoTa], [MaKM], [NgayDang], [MoTaCT]) VALUES (88, N'WOMENS REEBOK ROYAL CLASSIC RAYEN', 2, N'Reebook', N'rw51.jpg rw52.jpg rw53.jpg', N'Giày n?', 1, CAST(0x0000000000000000 AS DateTime), N'Màu: xám-h?ng')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaLoai], [ThuongHieu], [HinhAnh], [MoTa], [MaKM], [NgayDang], [MoTaCT]) VALUES (89, N'REEFUNK II', 2, N'Reebook', N'rw61.jpg rw62.jpg rw63.jpg', N'Giày n?', 1, CAST(0x0000000000000000 AS DateTime), N'Màu: vàng, h?ng, tr?ng, den, xanh, b?c')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaLoai], [ThuongHieu], [HinhAnh], [MoTa], [MaKM], [NgayDang], [MoTaCT]) VALUES (90, N'SUBLITE DUO FLOW', 2, N'Reebook', N'rw71.jpg rw72.jpg rw73.jpg', N'Giày n?', 1, CAST(0x0000000000000000 AS DateTime), N'Màu: xanh, h?ng')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaLoai], [ThuongHieu], [HinhAnh], [MoTa], [MaKM], [NgayDang], [MoTaCT]) VALUES (91, N'REEBOK ROYAL TENSTALL 2', 2, N'Reebook', N'rw81.jpg rw82.jpg rw83.jpg', N'Giày n?', 1, CAST(0x0000000000000000 AS DateTime), N'Màu: navy')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaLoai], [ThuongHieu], [HinhAnh], [MoTa], [MaKM], [NgayDang], [MoTaCT]) VALUES (92, N'Sandals kappa', 1, N'Kappa', N'km11.jpg km12.jpg km13.jpg', N'Dép nam', 1, CAST(0x0000000000000000 AS DateTime), N'Màu: xanh')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaLoai], [ThuongHieu], [HinhAnh], [MoTa], [MaKM], [NgayDang], [MoTaCT]) VALUES (93, N'Mens Athletic Sandals', 1, N'Reef Fanning', N'km21.jpg', N'Dép nam', 1, CAST(0x0000000000000000 AS DateTime), N'Màu: den')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaLoai], [ThuongHieu], [HinhAnh], [MoTa], [MaKM], [NgayDang], [MoTaCT]) VALUES (94, N'Birkenstock Ramses', 1, N'Birkenstock', N'km31.jpg km32.jpg', N'Dép nam', 1, CAST(0x0000000000000000 AS DateTime), N'Màu: nâu')
SET IDENTITY_INSERT [dbo].[SanPham] OFF
/****** Object:  Table [dbo].[HDNhap]    Script Date: 11/18/2015 17:07:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HDNhap](
	[MaHDN] [int] IDENTITY(1,1) NOT NULL,
	[MaNCC] [int] NULL,
	[MaNV] [int] NULL,
	[NgayNhap] [datetime] NULL,
	[TongTien] [decimal](18, 0) NULL,
	[TinhTrang] [int] NULL,
 CONSTRAINT [PK_HDNhap] PRIMARY KEY CLUSTERED 
(
	[MaHDN] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[HDNhap] ON
INSERT [dbo].[HDNhap] ([MaHDN], [MaNCC], [MaNV], [NgayNhap], [TongTien], [TinhTrang]) VALUES (4, 1, 2, CAST(0x0000A52D00000000 AS DateTime), CAST(3000000 AS Decimal(18, 0)), 1)
SET IDENTITY_INSERT [dbo].[HDNhap] OFF
/****** Object:  Table [dbo].[DonHang]    Script Date: 11/18/2015 17:07:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DonHang](
	[MaDH] [int] IDENTITY(1,1) NOT NULL,
	[MaKH] [int] NULL,
	[NgayMua] [datetime] NULL,
	[TongTien] [decimal](18, 0) NULL,
	[TinhTrang] [int] NULL,
	[NVDuyet] [nvarchar](50) NULL,
 CONSTRAINT [PK_DonHang] PRIMARY KEY CLUSTERED 
(
	[MaDH] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[DonHang] ON
INSERT [dbo].[DonHang] ([MaDH], [MaKH], [NgayMua], [TongTien], [TinhTrang], [NVDuyet]) VALUES (1, 1, CAST(0x0000A55400000000 AS DateTime), CAST(13000000 AS Decimal(18, 0)), 0, N'')
INSERT [dbo].[DonHang] ([MaDH], [MaKH], [NgayMua], [TongTien], [TinhTrang], [NVDuyet]) VALUES (2, 1, CAST(0x0000A55401017D7A AS DateTime), CAST(4800 AS Decimal(18, 0)), 0, NULL)
INSERT [dbo].[DonHang] ([MaDH], [MaKH], [NgayMua], [TongTien], [TinhTrang], [NVDuyet]) VALUES (3, 1, CAST(0x0000A5540101FAEF AS DateTime), CAST(4800 AS Decimal(18, 0)), 0, NULL)
INSERT [dbo].[DonHang] ([MaDH], [MaKH], [NgayMua], [TongTien], [TinhTrang], [NVDuyet]) VALUES (4, 1, CAST(0x0000A55401033BA8 AS DateTime), CAST(4800 AS Decimal(18, 0)), 0, NULL)
INSERT [dbo].[DonHang] ([MaDH], [MaKH], [NgayMua], [TongTien], [TinhTrang], [NVDuyet]) VALUES (5, 1, CAST(0x0000A5540113DB68 AS DateTime), CAST(4800 AS Decimal(18, 0)), 0, N'')
INSERT [dbo].[DonHang] ([MaDH], [MaKH], [NgayMua], [TongTien], [TinhTrang], [NVDuyet]) VALUES (6, 1, CAST(0x0000A5540115757B AS DateTime), CAST(1200 AS Decimal(18, 0)), 0, NULL)
INSERT [dbo].[DonHang] ([MaDH], [MaKH], [NgayMua], [TongTien], [TinhTrang], [NVDuyet]) VALUES (7, 1, CAST(0x0000A554011745FD AS DateTime), CAST(7200 AS Decimal(18, 0)), 0, NULL)
INSERT [dbo].[DonHang] ([MaDH], [MaKH], [NgayMua], [TongTien], [TinhTrang], [NVDuyet]) VALUES (8, 1, CAST(0x0000A5540117C4C8 AS DateTime), CAST(1600 AS Decimal(18, 0)), 0, NULL)
INSERT [dbo].[DonHang] ([MaDH], [MaKH], [NgayMua], [TongTien], [TinhTrang], [NVDuyet]) VALUES (9, 1, CAST(0x0000A554011867F9 AS DateTime), CAST(1500 AS Decimal(18, 0)), 0, NULL)
INSERT [dbo].[DonHang] ([MaDH], [MaKH], [NgayMua], [TongTien], [TinhTrang], [NVDuyet]) VALUES (10, 1, CAST(0x0000A55401197476 AS DateTime), CAST(2900 AS Decimal(18, 0)), 0, NULL)
SET IDENTITY_INSERT [dbo].[DonHang] OFF
/****** Object:  Table [dbo].[Kho]    Script Date: 11/18/2015 17:07:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kho](
	[MaSP] [int] NOT NULL,
	[MaMau] [int] NOT NULL,
	[MaSize] [int] NOT NULL,
	[SL] [int] NULL,
	[GiaBan] [decimal](18, 0) NULL,
	[GiaNhap] [decimal](18, 0) NULL,
 CONSTRAINT [PK_Kho] PRIMARY KEY CLUSTERED 
(
	[MaSP] ASC,
	[MaMau] ASC,
	[MaSize] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Kho] ([MaSP], [MaMau], [MaSize], [SL], [GiaBan], [GiaNhap]) VALUES (1, 1, 3, 2, CAST(1200 AS Decimal(18, 0)), CAST(1000 AS Decimal(18, 0)))
INSERT [dbo].[Kho] ([MaSP], [MaMau], [MaSize], [SL], [GiaBan], [GiaNhap]) VALUES (1, 1, 4, 2, CAST(1200 AS Decimal(18, 0)), CAST(1000 AS Decimal(18, 0)))
INSERT [dbo].[Kho] ([MaSP], [MaMau], [MaSize], [SL], [GiaBan], [GiaNhap]) VALUES (1, 1, 5, 2, CAST(1200 AS Decimal(18, 0)), CAST(1000 AS Decimal(18, 0)))
INSERT [dbo].[Kho] ([MaSP], [MaMau], [MaSize], [SL], [GiaBan], [GiaNhap]) VALUES (1, 2, 4, 3, CAST(1500 AS Decimal(18, 0)), CAST(1000 AS Decimal(18, 0)))
INSERT [dbo].[Kho] ([MaSP], [MaMau], [MaSize], [SL], [GiaBan], [GiaNhap]) VALUES (1, 3, 3, 3, CAST(1600 AS Decimal(18, 0)), CAST(1000 AS Decimal(18, 0)))
INSERT [dbo].[Kho] ([MaSP], [MaMau], [MaSize], [SL], [GiaBan], [GiaNhap]) VALUES (2, 3, 3, 3, CAST(1300 AS Decimal(18, 0)), CAST(1000 AS Decimal(18, 0)))
INSERT [dbo].[Kho] ([MaSP], [MaMau], [MaSize], [SL], [GiaBan], [GiaNhap]) VALUES (3, 1, 1, 2, CAST(1900 AS Decimal(18, 0)), CAST(1600 AS Decimal(18, 0)))
/****** Object:  Table [dbo].[CTHDN]    Script Date: 11/18/2015 17:07:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTHDN](
	[MaHDN] [int] NOT NULL,
	[MaSP] [int] NOT NULL,
	[MaMau] [int] NOT NULL,
	[MaSize] [int] NOT NULL,
	[SL] [int] NULL,
	[GiaNhap] [decimal](18, 0) NULL,
 CONSTRAINT [PK_CTHDN] PRIMARY KEY CLUSTERED 
(
	[MaHDN] ASC,
	[MaSP] ASC,
	[MaMau] ASC,
	[MaSize] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[CTHDN] ([MaHDN], [MaSP], [MaMau], [MaSize], [SL], [GiaNhap]) VALUES (4, 1, 1, 3, 3, CAST(1000 AS Decimal(18, 0)))
INSERT [dbo].[CTHDN] ([MaHDN], [MaSP], [MaMau], [MaSize], [SL], [GiaNhap]) VALUES (4, 1, 2, 4, 2, CAST(1200 AS Decimal(18, 0)))
INSERT [dbo].[CTHDN] ([MaHDN], [MaSP], [MaMau], [MaSize], [SL], [GiaNhap]) VALUES (4, 1, 3, 3, 2, CAST(1000 AS Decimal(18, 0)))
/****** Object:  Table [dbo].[CTDH]    Script Date: 11/18/2015 17:07:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTDH](
	[MaDH] [int] NOT NULL,
	[MaSP] [int] NOT NULL,
	[MaSize] [int] NOT NULL,
	[MaMau] [int] NOT NULL,
	[SL] [int] NULL,
	[DonGia] [decimal](18, 0) NULL,
 CONSTRAINT [PK_CTDH] PRIMARY KEY CLUSTERED 
(
	[MaDH] ASC,
	[MaSP] ASC,
	[MaSize] ASC,
	[MaMau] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[CTDH] ([MaDH], [MaSP], [MaSize], [MaMau], [SL], [DonGia]) VALUES (1, 1, 5, 1, 1, CAST(1200 AS Decimal(18, 0)))
/****** Object:  ForeignKey [FK_CTDH_DonHang]    Script Date: 11/18/2015 17:07:49 ******/
ALTER TABLE [dbo].[CTDH]  WITH CHECK ADD  CONSTRAINT [FK_CTDH_DonHang] FOREIGN KEY([MaDH])
REFERENCES [dbo].[DonHang] ([MaDH])
GO
ALTER TABLE [dbo].[CTDH] CHECK CONSTRAINT [FK_CTDH_DonHang]
GO
/****** Object:  ForeignKey [FK_CTDH_Mau]    Script Date: 11/18/2015 17:07:49 ******/
ALTER TABLE [dbo].[CTDH]  WITH CHECK ADD  CONSTRAINT [FK_CTDH_Mau] FOREIGN KEY([MaMau])
REFERENCES [dbo].[Mau] ([MaMau])
GO
ALTER TABLE [dbo].[CTDH] CHECK CONSTRAINT [FK_CTDH_Mau]
GO
/****** Object:  ForeignKey [FK_CTDH_SanPham]    Script Date: 11/18/2015 17:07:49 ******/
ALTER TABLE [dbo].[CTDH]  WITH CHECK ADD  CONSTRAINT [FK_CTDH_SanPham] FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[CTDH] CHECK CONSTRAINT [FK_CTDH_SanPham]
GO
/****** Object:  ForeignKey [FK_CTDH_Size]    Script Date: 11/18/2015 17:07:49 ******/
ALTER TABLE [dbo].[CTDH]  WITH CHECK ADD  CONSTRAINT [FK_CTDH_Size] FOREIGN KEY([MaSize])
REFERENCES [dbo].[Size] ([MaSize])
GO
ALTER TABLE [dbo].[CTDH] CHECK CONSTRAINT [FK_CTDH_Size]
GO
/****** Object:  ForeignKey [FK_CTHDN_HDNhap]    Script Date: 11/18/2015 17:07:49 ******/
ALTER TABLE [dbo].[CTHDN]  WITH CHECK ADD  CONSTRAINT [FK_CTHDN_HDNhap] FOREIGN KEY([MaHDN])
REFERENCES [dbo].[HDNhap] ([MaHDN])
GO
ALTER TABLE [dbo].[CTHDN] CHECK CONSTRAINT [FK_CTHDN_HDNhap]
GO
/****** Object:  ForeignKey [FK_CTHDN_Mau]    Script Date: 11/18/2015 17:07:49 ******/
ALTER TABLE [dbo].[CTHDN]  WITH CHECK ADD  CONSTRAINT [FK_CTHDN_Mau] FOREIGN KEY([MaMau])
REFERENCES [dbo].[Mau] ([MaMau])
GO
ALTER TABLE [dbo].[CTHDN] CHECK CONSTRAINT [FK_CTHDN_Mau]
GO
/****** Object:  ForeignKey [FK_CTHDN_SanPham]    Script Date: 11/18/2015 17:07:49 ******/
ALTER TABLE [dbo].[CTHDN]  WITH CHECK ADD  CONSTRAINT [FK_CTHDN_SanPham] FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[CTHDN] CHECK CONSTRAINT [FK_CTHDN_SanPham]
GO
/****** Object:  ForeignKey [FK_CTHDN_Size]    Script Date: 11/18/2015 17:07:49 ******/
ALTER TABLE [dbo].[CTHDN]  WITH CHECK ADD  CONSTRAINT [FK_CTHDN_Size] FOREIGN KEY([MaSize])
REFERENCES [dbo].[Size] ([MaSize])
GO
ALTER TABLE [dbo].[CTHDN] CHECK CONSTRAINT [FK_CTHDN_Size]
GO
/****** Object:  ForeignKey [FK_DonHang_KhachHang]    Script Date: 11/18/2015 17:07:49 ******/
ALTER TABLE [dbo].[DonHang]  WITH CHECK ADD  CONSTRAINT [FK_DonHang_KhachHang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[DonHang] CHECK CONSTRAINT [FK_DonHang_KhachHang]
GO
/****** Object:  ForeignKey [FK_HDNhap_NhaCungCap]    Script Date: 11/18/2015 17:07:49 ******/
ALTER TABLE [dbo].[HDNhap]  WITH CHECK ADD  CONSTRAINT [FK_HDNhap_NhaCungCap] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NhaCungCap] ([MaNCC])
GO
ALTER TABLE [dbo].[HDNhap] CHECK CONSTRAINT [FK_HDNhap_NhaCungCap]
GO
/****** Object:  ForeignKey [FK_HDNhap_NhanVien]    Script Date: 11/18/2015 17:07:49 ******/
ALTER TABLE [dbo].[HDNhap]  WITH CHECK ADD  CONSTRAINT [FK_HDNhap_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[HDNhap] CHECK CONSTRAINT [FK_HDNhap_NhanVien]
GO
/****** Object:  ForeignKey [FK_Kho_Mau]    Script Date: 11/18/2015 17:07:49 ******/
ALTER TABLE [dbo].[Kho]  WITH CHECK ADD  CONSTRAINT [FK_Kho_Mau] FOREIGN KEY([MaMau])
REFERENCES [dbo].[Mau] ([MaMau])
GO
ALTER TABLE [dbo].[Kho] CHECK CONSTRAINT [FK_Kho_Mau]
GO
/****** Object:  ForeignKey [FK_Kho_SanPham]    Script Date: 11/18/2015 17:07:49 ******/
ALTER TABLE [dbo].[Kho]  WITH CHECK ADD  CONSTRAINT [FK_Kho_SanPham] FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[Kho] CHECK CONSTRAINT [FK_Kho_SanPham]
GO
/****** Object:  ForeignKey [FK_Kho_Size]    Script Date: 11/18/2015 17:07:49 ******/
ALTER TABLE [dbo].[Kho]  WITH CHECK ADD  CONSTRAINT [FK_Kho_Size] FOREIGN KEY([MaSize])
REFERENCES [dbo].[Size] ([MaSize])
GO
ALTER TABLE [dbo].[Kho] CHECK CONSTRAINT [FK_Kho_Size]
GO
/****** Object:  ForeignKey [FK_SanPham_KhuyenMai]    Script Date: 11/18/2015 17:07:49 ******/
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [FK_SanPham_KhuyenMai] FOREIGN KEY([MaKM])
REFERENCES [dbo].[KhuyenMai] ([MaKM])
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [FK_SanPham_KhuyenMai]
GO
/****** Object:  ForeignKey [FK_SanPham_Loai]    Script Date: 11/18/2015 17:07:49 ******/
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [FK_SanPham_Loai] FOREIGN KEY([MaLoai])
REFERENCES [dbo].[Loai] ([MaLoai])
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [FK_SanPham_Loai]
GO
