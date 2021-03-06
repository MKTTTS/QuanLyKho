
/****** Object:  Database [QuanLyKho]    Script Date: 22/12/2020 9:20:14 CH ******/
USE [QuanLyKho]
GO
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLyKho', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\QuanLyKho.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QuanLyKho_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\QuanLyKho_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [QuanLyKho] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLyKho].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLyKho] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLyKho] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLyKho] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLyKho] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLyKho] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLyKho] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [QuanLyKho] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLyKho] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyKho] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLyKho] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLyKho] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLyKho] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLyKho] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLyKho] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLyKho] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QuanLyKho] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLyKho] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLyKho] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLyKho] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLyKho] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLyKho] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLyKho] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLyKho] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QuanLyKho] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLyKho] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLyKho] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLyKho] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLyKho] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QuanLyKho] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QuanLyKho] SET QUERY_STORE = OFF
GO
USE [QuanLyKho]
GO
/****** Object:  Table [dbo].[tblChiTietNhap]    Script Date: 22/12/2020 9:20:14 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblChiTietNhap](
	[MaHDNhap] [int] NOT NULL,
	[MaHangHoa] [int] NOT NULL,
	[SoLuong] [int] NULL,
	[DonGia] [int] NULL,
 CONSTRAINT [PK_tblChiTietNhap] PRIMARY KEY CLUSTERED 
(
	[MaHDNhap] ASC,
	[MaHangHoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblChiTietXuat]    Script Date: 22/12/2020 9:20:14 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblChiTietXuat](
	[MaHDXuat] [int] NOT NULL,
	[MaHangHoa] [int] NOT NULL,
	[SoLuong] [int] NULL,
	[DonGia] [int] NULL,
 CONSTRAINT [PK_tblChiTietXuat] PRIMARY KEY CLUSTERED 
(
	[MaHDXuat] ASC,
	[MaHangHoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblHangHoa]    Script Date: 22/12/2020 9:20:14 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblHangHoa](
	[MaHangHoa] [int] NOT NULL,
	[TenHang] [nvarchar](50) NULL,
	[SoLuong] [int] NULL,
	[GiaNhap] [int] NULL,
	[GiaXuat] [int] NULL,
	[GhiChu] [nvarchar](200) NULL,
 CONSTRAINT [PK_tblHangHoa] PRIMARY KEY CLUSTERED 
(
	[MaHangHoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblHoaDonNhap]    Script Date: 22/12/2020 9:20:14 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblHoaDonNhap](
	[MaHDNhap] [int] NOT NULL,
	[NgayNhap] [date] NULL,
	[TongTien] [int] NULL,
	[MaNhaCC] [int] NULL,
 CONSTRAINT [PK_tblHoaDonNhap] PRIMARY KEY CLUSTERED 
(
	[MaHDNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblHoaDonXuat]    Script Date: 22/12/2020 9:20:14 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblHoaDonXuat](
	[MaHDXuat] [int] NOT NULL,
	[NgayXuat] [date] NULL,
	[TongTien] [nchar](10) NULL,
	[MaKhachHang] [int] NULL,
 CONSTRAINT [PK_tblHoaDonXuat] PRIMARY KEY CLUSTERED 
(
	[MaHDXuat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblKhachHang]    Script Date: 22/12/2020 9:20:14 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblKhachHang](
	[MaKhachHang] [int] NOT NULL,
	[HoTen] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[SDT] [varchar](15) NULL,
 CONSTRAINT [PK_tblKhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKhachHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblNhaCungCap]    Script Date: 22/12/2020 9:20:14 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblNhaCungCap](
	[MaNhaCC] [int] NOT NULL,
	[TenNhaCC] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SDT] [varchar](20) NULL,
 CONSTRAINT [PK_tblNhaCungCap] PRIMARY KEY CLUSTERED 
(
	[MaNhaCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblTaiKhoan]    Script Date: 22/12/2020 9:20:14 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblTaiKhoan](
	[TaiKhoan] [varchar](50) NOT NULL,
	[MatKhau] [varchar](50) NULL,
 CONSTRAINT [PK_tblTaiKhoan] PRIMARY KEY CLUSTERED 
(
	[TaiKhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[tblChiTietNhap] ([MaHDNhap], [MaHangHoa], [SoLuong], [DonGia]) VALUES (1, 1, 1000, 10000)
INSERT [dbo].[tblChiTietNhap] ([MaHDNhap], [MaHangHoa], [SoLuong], [DonGia]) VALUES (2, 2, 10, 100000)
INSERT [dbo].[tblChiTietXuat] ([MaHDXuat], [MaHangHoa], [SoLuong], [DonGia]) VALUES (1, 1, 100, 10000)
INSERT [dbo].[tblChiTietXuat] ([MaHDXuat], [MaHangHoa], [SoLuong], [DonGia]) VALUES (2, 2, 10, 10000)
INSERT [dbo].[tblHangHoa] ([MaHangHoa], [TenHang], [SoLuong], [GiaNhap], [GiaXuat], [GhiChu]) VALUES (1, N'Thuoc ', 100, 25000, 50000, NULL)
INSERT [dbo].[tblHangHoa] ([MaHangHoa], [TenHang], [SoLuong], [GiaNhap], [GiaXuat], [GhiChu]) VALUES (2, N'thuốc đau đầu', 200, 2500, 30000, NULL)
INSERT [dbo].[tblHangHoa] ([MaHangHoa], [TenHang], [SoLuong], [GiaNhap], [GiaXuat], [GhiChu]) VALUES (3, N'máy tính', 500, 200000, 3000000, NULL)
INSERT [dbo].[tblHoaDonNhap] ([MaHDNhap], [NgayNhap], [TongTien], [MaNhaCC]) VALUES (1, CAST(N'2020-10-10' AS Date), 150000, 1)
INSERT [dbo].[tblHoaDonNhap] ([MaHDNhap], [NgayNhap], [TongTien], [MaNhaCC]) VALUES (2, CAST(N'2020-10-11' AS Date), 15000000, 2)
INSERT [dbo].[tblHoaDonXuat] ([MaHDXuat], [NgayXuat], [TongTien], [MaKhachHang]) VALUES (1, CAST(N'2020-10-10' AS Date), N'150000    ', 1)
INSERT [dbo].[tblHoaDonXuat] ([MaHDXuat], [NgayXuat], [TongTien], [MaKhachHang]) VALUES (2, CAST(N'2020-10-11' AS Date), N'250000    ', 2)
INSERT [dbo].[tblKhachHang] ([MaKhachHang], [HoTen], [DiaChi], [Email], [SDT]) VALUES (1, N'Dang trong tien', N'nghe an', N'dangtien@gmail.com', N'09840654231')
INSERT [dbo].[tblKhachHang] ([MaKhachHang], [HoTen], [DiaChi], [Email], [SDT]) VALUES (2, N'tran bao tri', N'nghe an ', N'batri@gmail.com', N'1234567891')
INSERT [dbo].[tblNhaCungCap] ([MaNhaCC], [TenNhaCC], [DiaChi], [SDT]) VALUES (1, N'tiến', N'nghệ an ', N'032145689')
INSERT [dbo].[tblNhaCungCap] ([MaNhaCC], [TenNhaCC], [DiaChi], [SDT]) VALUES (2, N'trí', N'nghệ an ', N'0123456789')
INSERT [dbo].[tblTaiKhoan] ([TaiKhoan], [MatKhau]) VALUES (N'admin1', N'1')
INSERT [dbo].[tblTaiKhoan] ([TaiKhoan], [MatKhau]) VALUES (N'admin2', N'1')
INSERT [dbo].[tblTaiKhoan] ([TaiKhoan], [MatKhau]) VALUES (N'admin3', N'1')
ALTER TABLE [dbo].[tblChiTietNhap]  WITH CHECK ADD  CONSTRAINT [FK_tblChiTietNhap_tblHangHoa] FOREIGN KEY([MaHangHoa])
REFERENCES [dbo].[tblHangHoa] ([MaHangHoa])
GO
ALTER TABLE [dbo].[tblChiTietNhap] CHECK CONSTRAINT [FK_tblChiTietNhap_tblHangHoa]
GO
ALTER TABLE [dbo].[tblChiTietNhap]  WITH CHECK ADD  CONSTRAINT [FK_tblChiTietNhap_tblHoaDonNhap] FOREIGN KEY([MaHDNhap])
REFERENCES [dbo].[tblHoaDonNhap] ([MaHDNhap])
GO
ALTER TABLE [dbo].[tblChiTietNhap] CHECK CONSTRAINT [FK_tblChiTietNhap_tblHoaDonNhap]
GO
ALTER TABLE [dbo].[tblChiTietXuat]  WITH CHECK ADD  CONSTRAINT [FK_tblChiTietXuat_tblHangHoa] FOREIGN KEY([MaHangHoa])
REFERENCES [dbo].[tblHangHoa] ([MaHangHoa])
GO
ALTER TABLE [dbo].[tblChiTietXuat] CHECK CONSTRAINT [FK_tblChiTietXuat_tblHangHoa]
GO
ALTER TABLE [dbo].[tblChiTietXuat]  WITH CHECK ADD  CONSTRAINT [FK_tblChiTietXuat_tblHoaDonXuat] FOREIGN KEY([MaHDXuat])
REFERENCES [dbo].[tblHoaDonXuat] ([MaHDXuat])
GO
ALTER TABLE [dbo].[tblChiTietXuat] CHECK CONSTRAINT [FK_tblChiTietXuat_tblHoaDonXuat]
GO
ALTER TABLE [dbo].[tblHoaDonNhap]  WITH CHECK ADD  CONSTRAINT [FK_tblHoaDonNhap_tblNhaCungCap] FOREIGN KEY([MaNhaCC])
REFERENCES [dbo].[tblNhaCungCap] ([MaNhaCC])
GO
ALTER TABLE [dbo].[tblHoaDonNhap] CHECK CONSTRAINT [FK_tblHoaDonNhap_tblNhaCungCap]
GO
ALTER TABLE [dbo].[tblHoaDonXuat]  WITH CHECK ADD  CONSTRAINT [FK_tblHoaDonXuat_tblKhachHang] FOREIGN KEY([MaKhachHang])
REFERENCES [dbo].[tblKhachHang] ([MaKhachHang])
GO
ALTER TABLE [dbo].[tblHoaDonXuat] CHECK CONSTRAINT [FK_tblHoaDonXuat_tblKhachHang]
GO
USE [master]
GO
ALTER DATABASE [QuanLyKho] SET  READ_WRITE 
GO
