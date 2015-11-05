USE [DBGiayDep]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 11/04/2015 15:37:00 ******/
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
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 11/04/2015 15:37:00 ******/
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
/****** Object:  Table [dbo].[Mau]    Script Date: 11/04/2015 15:37:00 ******/
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
/****** Object:  Table [dbo].[Loai]    Script Date: 11/04/2015 15:37:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Loai](
	[MaLoai] [int] NOT NULL,
	[TenLoai] [nvarchar](50) NULL,
 CONSTRAINT [PK_Loai] PRIMARY KEY CLUSTERED 
(
	[MaLoai] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhuyenMai]    Script Date: 11/04/2015 15:37:00 ******/
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
/****** Object:  Table [dbo].[KhachHang]    Script Date: 11/04/2015 15:37:00 ******/
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
/****** Object:  Table [dbo].[Size]    Script Date: 11/04/2015 15:37:00 ******/
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
/****** Object:  Table [dbo].[SanPham]    Script Date: 11/04/2015 15:37:00 ******/
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
 CONSTRAINT [PK_SanPham] PRIMARY KEY CLUSTERED 
(
	[MaSP] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HDNhap]    Script Date: 11/04/2015 15:37:00 ******/
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
/****** Object:  Table [dbo].[DonHang]    Script Date: 11/04/2015 15:37:00 ******/
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
/****** Object:  Table [dbo].[Kho]    Script Date: 11/04/2015 15:37:00 ******/
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
/****** Object:  Table [dbo].[CTHDN]    Script Date: 11/04/2015 15:37:00 ******/
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
/****** Object:  Table [dbo].[CTDH]    Script Date: 11/04/2015 15:37:00 ******/
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
/****** Object:  ForeignKey [FK_CTDH_DonHang]    Script Date: 11/04/2015 15:37:00 ******/
ALTER TABLE [dbo].[CTDH]  WITH CHECK ADD  CONSTRAINT [FK_CTDH_DonHang] FOREIGN KEY([MaDH])
REFERENCES [dbo].[DonHang] ([MaDH])
GO
ALTER TABLE [dbo].[CTDH] CHECK CONSTRAINT [FK_CTDH_DonHang]
GO
/****** Object:  ForeignKey [FK_CTDH_Mau]    Script Date: 11/04/2015 15:37:00 ******/
ALTER TABLE [dbo].[CTDH]  WITH CHECK ADD  CONSTRAINT [FK_CTDH_Mau] FOREIGN KEY([MaMau])
REFERENCES [dbo].[Mau] ([MaMau])
GO
ALTER TABLE [dbo].[CTDH] CHECK CONSTRAINT [FK_CTDH_Mau]
GO
/****** Object:  ForeignKey [FK_CTDH_SanPham]    Script Date: 11/04/2015 15:37:00 ******/
ALTER TABLE [dbo].[CTDH]  WITH CHECK ADD  CONSTRAINT [FK_CTDH_SanPham] FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[CTDH] CHECK CONSTRAINT [FK_CTDH_SanPham]
GO
/****** Object:  ForeignKey [FK_CTDH_Size]    Script Date: 11/04/2015 15:37:00 ******/
ALTER TABLE [dbo].[CTDH]  WITH CHECK ADD  CONSTRAINT [FK_CTDH_Size] FOREIGN KEY([MaSize])
REFERENCES [dbo].[Size] ([MaSize])
GO
ALTER TABLE [dbo].[CTDH] CHECK CONSTRAINT [FK_CTDH_Size]
GO
/****** Object:  ForeignKey [FK_CTHDN_HDNhap]    Script Date: 11/04/2015 15:37:00 ******/
ALTER TABLE [dbo].[CTHDN]  WITH CHECK ADD  CONSTRAINT [FK_CTHDN_HDNhap] FOREIGN KEY([MaHDN])
REFERENCES [dbo].[HDNhap] ([MaHDN])
GO
ALTER TABLE [dbo].[CTHDN] CHECK CONSTRAINT [FK_CTHDN_HDNhap]
GO
/****** Object:  ForeignKey [FK_CTHDN_Mau]    Script Date: 11/04/2015 15:37:00 ******/
ALTER TABLE [dbo].[CTHDN]  WITH CHECK ADD  CONSTRAINT [FK_CTHDN_Mau] FOREIGN KEY([MaMau])
REFERENCES [dbo].[Mau] ([MaMau])
GO
ALTER TABLE [dbo].[CTHDN] CHECK CONSTRAINT [FK_CTHDN_Mau]
GO
/****** Object:  ForeignKey [FK_CTHDN_SanPham]    Script Date: 11/04/2015 15:37:00 ******/
ALTER TABLE [dbo].[CTHDN]  WITH CHECK ADD  CONSTRAINT [FK_CTHDN_SanPham] FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[CTHDN] CHECK CONSTRAINT [FK_CTHDN_SanPham]
GO
/****** Object:  ForeignKey [FK_CTHDN_Size]    Script Date: 11/04/2015 15:37:00 ******/
ALTER TABLE [dbo].[CTHDN]  WITH CHECK ADD  CONSTRAINT [FK_CTHDN_Size] FOREIGN KEY([MaSize])
REFERENCES [dbo].[Size] ([MaSize])
GO
ALTER TABLE [dbo].[CTHDN] CHECK CONSTRAINT [FK_CTHDN_Size]
GO
/****** Object:  ForeignKey [FK_DonHang_KhachHang]    Script Date: 11/04/2015 15:37:00 ******/
ALTER TABLE [dbo].[DonHang]  WITH CHECK ADD  CONSTRAINT [FK_DonHang_KhachHang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[DonHang] CHECK CONSTRAINT [FK_DonHang_KhachHang]
GO
/****** Object:  ForeignKey [FK_HDNhap_NhaCungCap]    Script Date: 11/04/2015 15:37:00 ******/
ALTER TABLE [dbo].[HDNhap]  WITH CHECK ADD  CONSTRAINT [FK_HDNhap_NhaCungCap] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NhaCungCap] ([MaNCC])
GO
ALTER TABLE [dbo].[HDNhap] CHECK CONSTRAINT [FK_HDNhap_NhaCungCap]
GO
/****** Object:  ForeignKey [FK_HDNhap_NhanVien]    Script Date: 11/04/2015 15:37:00 ******/
ALTER TABLE [dbo].[HDNhap]  WITH CHECK ADD  CONSTRAINT [FK_HDNhap_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[HDNhap] CHECK CONSTRAINT [FK_HDNhap_NhanVien]
GO
/****** Object:  ForeignKey [FK_Kho_Mau]    Script Date: 11/04/2015 15:37:00 ******/
ALTER TABLE [dbo].[Kho]  WITH CHECK ADD  CONSTRAINT [FK_Kho_Mau] FOREIGN KEY([MaMau])
REFERENCES [dbo].[Mau] ([MaMau])
GO
ALTER TABLE [dbo].[Kho] CHECK CONSTRAINT [FK_Kho_Mau]
GO
/****** Object:  ForeignKey [FK_Kho_SanPham]    Script Date: 11/04/2015 15:37:00 ******/
ALTER TABLE [dbo].[Kho]  WITH CHECK ADD  CONSTRAINT [FK_Kho_SanPham] FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[Kho] CHECK CONSTRAINT [FK_Kho_SanPham]
GO
/****** Object:  ForeignKey [FK_Kho_Size]    Script Date: 11/04/2015 15:37:00 ******/
ALTER TABLE [dbo].[Kho]  WITH CHECK ADD  CONSTRAINT [FK_Kho_Size] FOREIGN KEY([MaSize])
REFERENCES [dbo].[Size] ([MaSize])
GO
ALTER TABLE [dbo].[Kho] CHECK CONSTRAINT [FK_Kho_Size]
GO
/****** Object:  ForeignKey [FK_SanPham_KhuyenMai]    Script Date: 11/04/2015 15:37:00 ******/
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [FK_SanPham_KhuyenMai] FOREIGN KEY([MaKM])
REFERENCES [dbo].[KhuyenMai] ([MaKM])
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [FK_SanPham_KhuyenMai]
GO
/****** Object:  ForeignKey [FK_SanPham_Loai]    Script Date: 11/04/2015 15:37:00 ******/
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [FK_SanPham_Loai] FOREIGN KEY([MaLoai])
REFERENCES [dbo].[Loai] ([MaLoai])
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [FK_SanPham_Loai]
GO
