USE [master]
GO
/****** Object:  Database [BOOK]    Script Date: 12/20/2018 11:32:10 PM ******/
CREATE DATABASE [BOOK]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BOOK', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\BOOK.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'BOOK_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\BOOK_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [BOOK] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BOOK].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BOOK] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BOOK] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BOOK] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BOOK] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BOOK] SET ARITHABORT OFF 
GO
ALTER DATABASE [BOOK] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BOOK] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BOOK] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BOOK] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BOOK] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BOOK] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BOOK] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BOOK] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BOOK] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BOOK] SET  DISABLE_BROKER 
GO
ALTER DATABASE [BOOK] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BOOK] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BOOK] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BOOK] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BOOK] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BOOK] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BOOK] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BOOK] SET RECOVERY FULL 
GO
ALTER DATABASE [BOOK] SET  MULTI_USER 
GO
ALTER DATABASE [BOOK] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BOOK] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BOOK] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BOOK] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [BOOK] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'BOOK', N'ON'
GO
ALTER DATABASE [BOOK] SET QUERY_STORE = OFF
GO
USE [BOOK]
GO
ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [BOOK]
GO
/****** Object:  Table [dbo].[ChiTietHoaDon]    Script Date: 12/20/2018 11:32:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHoaDon](
	[MaChiTietHoaDon] [nvarchar](10) NOT NULL,
	[MaHoaDon] [nvarchar](10) NULL,
	[MaSach] [nvarchar](10) NULL,
	[SoLuong] [int] NULL,
	[GiaBan] [int] NULL,
 CONSTRAINT [PK_ChiTietHoaDon] PRIMARY KEY CLUSTERED 
(
	[MaChiTietHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietPhieuNhapSach]    Script Date: 12/20/2018 11:32:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietPhieuNhapSach](
	[MaChiTietPhieuNhapSach] [nvarchar](10) NOT NULL,
	[MaPhieuNhapSach] [nvarchar](10) NULL,
	[MaSach] [nvarchar](10) NULL,
	[SoLuong] [int] NULL,
	[GiaNhap] [int] NULL,
 CONSTRAINT [PK_ChiTietPhieuNhapSach] PRIMARY KEY CLUSTERED 
(
	[MaChiTietPhieuNhapSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 12/20/2018 11:32:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MaHoaDon] [nvarchar](10) NOT NULL,
	[MaKhachHang] [nvarchar](10) NULL,
	[MaNhanVien] [nvarchar](10) NULL,
	[NgayLapHoaDon] [datetime] NULL,
	[TongTien] [int] NULL,
	[DiemThuong] [int] NULL,
 CONSTRAINT [PK_HoaDon] PRIMARY KEY CLUSTERED 
(
	[MaHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 12/20/2018 11:32:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKhachHang] [nvarchar](10) NOT NULL,
	[TenKhachHang] [ntext] NULL,
	[CMND] [ntext] NULL,
	[SoDienThoai] [ntext] NULL,
	[DiemTichLuy] [int] NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKhachHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 12/20/2018 11:32:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNhanVien] [nvarchar](10) NOT NULL,
	[TenNhanVien] [ntext] NULL,
	[NgaySinh] [datetime] NULL,
	[DiaChi] [ntext] NULL,
	[SoDienThoai] [ntext] NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuNhapSach]    Script Date: 12/20/2018 11:32:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuNhapSach](
	[MaPhieuNhapSach] [nvarchar](10) NOT NULL,
	[NgayNhapSach] [datetime] NULL,
	[MaNhanVien] [nvarchar](10) NULL,
	[TongTien] [int] NULL,
 CONSTRAINT [PK_PhieuNhapSach] PRIMARY KEY CLUSTERED 
(
	[MaPhieuNhapSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sach]    Script Date: 12/20/2018 11:32:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sach](
	[MaSach] [nvarchar](10) NOT NULL,
	[TenSach] [ntext] NULL,
	[TacGia] [ntext] NULL,
	[TheLoai] [ntext] NULL,
	[NhaXuatBan] [ntext] NULL,
	[NamXuatBan] [int] NULL,
	[GiaBan] [int] NULL,
	[SoLuong] [int] NULL,
 CONSTRAINT [PK_SACH] PRIMARY KEY CLUSTERED 
(
	[MaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaSach], [SoLuong], [GiaBan]) VALUES (N'CD001', N'HD001', N'SA001', 1, 65000)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaSach], [SoLuong], [GiaBan]) VALUES (N'CD002', N'HD001', N'SA002', 1, 75000)
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaHoaDon], [MaSach], [SoLuong], [GiaBan]) VALUES (N'CD003', N'HD001', N'SA005', 2, 35000)
INSERT [dbo].[ChiTietPhieuNhapSach] ([MaChiTietPhieuNhapSach], [MaPhieuNhapSach], [MaSach], [SoLuong], [GiaNhap]) VALUES (N'CP001', N'PN001', N'SA001', 20, 30000)
INSERT [dbo].[ChiTietPhieuNhapSach] ([MaChiTietPhieuNhapSach], [MaPhieuNhapSach], [MaSach], [SoLuong], [GiaNhap]) VALUES (N'CP002', N'PN001', N'SA002', 25, 50000)
INSERT [dbo].[ChiTietPhieuNhapSach] ([MaChiTietPhieuNhapSach], [MaPhieuNhapSach], [MaSach], [SoLuong], [GiaNhap]) VALUES (N'CP003', N'PN001', N'SA003', 50, 25000)
INSERT [dbo].[ChiTietPhieuNhapSach] ([MaChiTietPhieuNhapSach], [MaPhieuNhapSach], [MaSach], [SoLuong], [GiaNhap]) VALUES (N'CP004', N'PN001', N'SA004', 10, 30000)
INSERT [dbo].[ChiTietPhieuNhapSach] ([MaChiTietPhieuNhapSach], [MaPhieuNhapSach], [MaSach], [SoLuong], [GiaNhap]) VALUES (N'CP005', N'PN002', N'SA005', 100, 20000)
INSERT [dbo].[ChiTietPhieuNhapSach] ([MaChiTietPhieuNhapSach], [MaPhieuNhapSach], [MaSach], [SoLuong], [GiaNhap]) VALUES (N'CP006', NULL, N'SA006', 15, 50000)
INSERT [dbo].[HoaDon] ([MaHoaDon], [MaKhachHang], [MaNhanVien], [NgayLapHoaDon], [TongTien], [DiemThuong]) VALUES (N'HD001', N'KH001', N'NV003', CAST(N'2018-12-20T00:00:00.000' AS DateTime), 210, 2)
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [CMND], [SoDienThoai], [DiemTichLuy]) VALUES (N'KH001', N'Nguyễn Long Hồ', N'241003212', N'035371888', 2)
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [CMND], [SoDienThoai], [DiemTichLuy]) VALUES (N'KH002', N'Đỗ Minh Hiếu', N'210234050', N'031294485', 0)
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [CMND], [SoDienThoai], [DiemTichLuy]) VALUES (N'KH003', N'Hồ Thiên Hổ', N'230459662', N'023485555', 0)
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [CMND], [SoDienThoai], [DiemTichLuy]) VALUES (N'KH004', N'Cao Thiên Hoàng', N'231456042', N'049311239', 0)
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [NgaySinh], [DiaChi], [SoDienThoai]) VALUES (N'NV001', N'Lê Tống Minh Hiếu', CAST(N'1998-11-20T00:00:00.000' AS DateTime), N'191 Đồng Đen, Tân Bình', N'0932345134')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [NgaySinh], [DiaChi], [SoDienThoai]) VALUES (N'NV002', N'Vũ Quốc Hội', CAST(N'1998-01-01T00:00:00.000' AS DateTime), N'17A đường 1, Q7', N'0365141006')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [NgaySinh], [DiaChi], [SoDienThoai]) VALUES (N'NV003', N'Trần Văn Huân', CAST(N'1997-02-01T00:00:00.000' AS DateTime), N'191 Thống Nhất, Gò Vấp', N'035112036')
INSERT [dbo].[PhieuNhapSach] ([MaPhieuNhapSach], [NgayNhapSach], [MaNhanVien], [TongTien]) VALUES (N'PN001', CAST(N'2018-12-20T00:00:00.000' AS DateTime), N'NV001', 3400000)
INSERT [dbo].[PhieuNhapSach] ([MaPhieuNhapSach], [NgayNhapSach], [MaNhanVien], [TongTien]) VALUES (N'PN002', CAST(N'2018-12-19T00:00:00.000' AS DateTime), N'NV002', 2750000)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [TheLoai], [NhaXuatBan], [NamXuatBan], [GiaBan], [SoLuong]) VALUES (N'SA001', N'Nhập môn lập trình', N'KHTN', N'Khoa học', N'Kĩ thuật', 2007, 65000, 20)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [TheLoai], [NhaXuatBan], [NamXuatBan], [GiaBan], [SoLuong]) VALUES (N'SA002', N'Kĩ thuật lập trình', N'KHTN', N'Khoa học', N'Kĩ thuật', 2007, 75000, 25)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [TheLoai], [NhaXuatBan], [NamXuatBan], [GiaBan], [SoLuong]) VALUES (N'SA003', N'Tư tưởng HCM', N'Bộ GDĐT', N'Chính trị', N'Chính trị Quốc gia sự thật', 2002, 50000, 50)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [TheLoai], [NhaXuatBan], [NamXuatBan], [GiaBan], [SoLuong]) VALUES (N'SA004', N'Đường lối CMĐCS', N'Bộ GDĐT', N'Chính trị', N'Chính trị Quốc gia sự thật', 2000, 60000, 10)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [TheLoai], [NhaXuatBan], [NamXuatBan], [GiaBan], [SoLuong]) VALUES (N'SA005', N'Toán cao cấp C1', N'Nguyễn Quốc Hưng', N'Khoa học', N'Đại học sư phạm', 2003, 35000, 100)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [TacGia], [TheLoai], [NhaXuatBan], [NamXuatBan], [GiaBan], [SoLuong]) VALUES (N'SA006', N'Vật lí đại cương 2', N'Nguyễn Thành Vấn', N'Khoa học', N'Kĩ thuật', 2002, 70000, 15)
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDon_HoaDon] FOREIGN KEY([MaHoaDon])
REFERENCES [dbo].[HoaDon] ([MaHoaDon])
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [FK_ChiTietHoaDon_HoaDon]
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDon_Sach] FOREIGN KEY([MaSach])
REFERENCES [dbo].[Sach] ([MaSach])
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [FK_ChiTietHoaDon_Sach]
GO
ALTER TABLE [dbo].[ChiTietPhieuNhapSach]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuNhapSach_PhieuNhapSach] FOREIGN KEY([MaPhieuNhapSach])
REFERENCES [dbo].[PhieuNhapSach] ([MaPhieuNhapSach])
GO
ALTER TABLE [dbo].[ChiTietPhieuNhapSach] CHECK CONSTRAINT [FK_ChiTietPhieuNhapSach_PhieuNhapSach]
GO
ALTER TABLE [dbo].[ChiTietPhieuNhapSach]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuNhapSach_Sach] FOREIGN KEY([MaSach])
REFERENCES [dbo].[Sach] ([MaSach])
GO
ALTER TABLE [dbo].[ChiTietPhieuNhapSach] CHECK CONSTRAINT [FK_ChiTietPhieuNhapSach_Sach]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_KhachHang] FOREIGN KEY([MaKhachHang])
REFERENCES [dbo].[KhachHang] ([MaKhachHang])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_KhachHang]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_NhanVien] FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NhanVien] ([MaNhanVien])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_NhanVien]
GO
ALTER TABLE [dbo].[PhieuNhapSach]  WITH CHECK ADD  CONSTRAINT [FK_PhieuNhapSach_NhanVien1] FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NhanVien] ([MaNhanVien])
GO
ALTER TABLE [dbo].[PhieuNhapSach] CHECK CONSTRAINT [FK_PhieuNhapSach_NhanVien1]
GO
USE [master]
GO
ALTER DATABASE [BOOK] SET  READ_WRITE 
GO
