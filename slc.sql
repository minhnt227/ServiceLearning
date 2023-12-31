USE [master]
GO
/****** Object:  Database [Service_Learning]    Script Date: 12/8/2023 11:49:23 AM ******/
CREATE DATABASE [Service_Learning]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Service_Learning', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\Service_Learning.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Service_Learning_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\Service_Learning_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Service_Learning].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Service_Learning] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Service_Learning] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Service_Learning] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Service_Learning] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Service_Learning] SET ARITHABORT OFF 
GO
ALTER DATABASE [Service_Learning] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Service_Learning] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Service_Learning] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Service_Learning] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Service_Learning] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Service_Learning] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Service_Learning] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Service_Learning] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Service_Learning] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Service_Learning] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Service_Learning] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Service_Learning] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Service_Learning] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Service_Learning] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Service_Learning] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Service_Learning] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Service_Learning] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Service_Learning] SET RECOVERY FULL 
GO
ALTER DATABASE [Service_Learning] SET  MULTI_USER 
GO
ALTER DATABASE [Service_Learning] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Service_Learning] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Service_Learning] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Service_Learning] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Service_Learning] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Service_Learning] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Service_Learning', N'ON'
GO
ALTER DATABASE [Service_Learning] SET QUERY_STORE = ON
GO
ALTER DATABASE [Service_Learning] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [Service_Learning]
GO
/****** Object:  Table [dbo].[DANH_GIA]    Script Date: 12/8/2023 11:49:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DANH_GIA](
	[MaDanhGia] [nchar](10) NOT NULL,
	[MaHD] [nchar](10) NULL,
	[MSSV] [nchar](10) NULL,
	[NoiDung] [ntext] NULL,
	[Hide] [bit] NULL,
 CONSTRAINT [PK_DANH_GIA_1] PRIMARY KEY CLUSTERED 
(
	[MaDanhGia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DANHGIA_DETAILS]    Script Date: 12/8/2023 11:49:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DANHGIA_DETAILS](
	[MaDanhGia] [nchar](10) NOT NULL,
	[HangMuc] [int] NOT NULL,
	[MucDo] [int] NULL,
	[GhiChu] [ntext] NULL,
 CONSTRAINT [PK_DANHGIA_DETAILS] PRIMARY KEY CLUSTERED 
(
	[MaDanhGia] ASC,
	[HangMuc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DOI_TAC]    Script Date: 12/8/2023 11:49:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DOI_TAC](
	[ID_DoiTac] [int] IDENTITY(1,1) NOT NULL,
	[TenDoiTac] [nvarchar](100) NULL,
	[DaiDien] [nvarchar](50) NULL,
	[SDT] [nchar](20) NULL,
	[Email] [nvarchar](50) NULL,
	[Hide] [bit] NULL,
 CONSTRAINT [PK_DOI_TAC] PRIMARY KEY CLUSTERED 
(
	[ID_DoiTac] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GIANG_VIEN]    Script Date: 12/8/2023 11:49:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GIANG_VIEN](
	[MaGV] [nchar](10) NOT NULL,
	[HoTenLot] [nvarchar](50) NULL,
	[Ten] [nvarchar](50) NULL,
	[Khoa] [nchar](10) NULL,
	[Hide] [bit] NULL,
 CONSTRAINT [PK_GIANG_VIEN] PRIMARY KEY CLUSTERED 
(
	[MaGV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HANG_MUC]    Script Date: 12/8/2023 11:49:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HANG_MUC](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenHangMuc] [ntext] NULL,
	[Hide] [bit] NULL,
 CONSTRAINT [PK_HANG_MUC] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HD_DOITAC]    Script Date: 12/8/2023 11:49:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HD_DOITAC](
	[ID_DoiTac] [int] NOT NULL,
	[MaHD] [nchar](10) NOT NULL,
	[NoiDung] [ntext] NULL,
 CONSTRAINT [PK_DT_HOATDONG] PRIMARY KEY CLUSTERED 
(
	[ID_DoiTac] ASC,
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HD_GIANGVIEN]    Script Date: 12/8/2023 11:49:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HD_GIANGVIEN](
	[MaHD] [nchar](10) NOT NULL,
	[MaGV] [nchar](10) NOT NULL,
	[VaiTro] [nvarchar](50) NULL,
 CONSTRAINT [PK_HD_GIANGVIEN] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC,
	[MaGV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HD_SINHVIEN]    Script Date: 12/8/2023 11:49:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HD_SINHVIEN](
	[MaHD] [nchar](10) NOT NULL,
	[MSSV] [nchar](10) NOT NULL,
	[VaiTro] [nvarchar](50) NULL,
	[GhiChu] [ntext] NULL,
 CONSTRAINT [PK_SV_HOATDONG] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC,
	[MSSV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HD_TAITRO]    Script Date: 12/8/2023 11:49:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HD_TAITRO](
	[ID_TaiTro] [int] NOT NULL,
	[MaHD] [nchar](10) NOT NULL,
	[NoiDung] [ntext] NULL,
 CONSTRAINT [PK_HD_TAITRO] PRIMARY KEY CLUSTERED 
(
	[ID_TaiTro] ASC,
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HOAT_DONG]    Script Date: 12/8/2023 11:49:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOAT_DONG](
	[MaHD] [nchar](10) NOT NULL,
	[TenHoatDong] [ntext] NULL,
	[Loai] [nvarchar](50) NULL,
	[NgayBatDau] [datetime] NULL,
	[NgayKetThuc] [datetime] NULL,
	[Hide] [bit] NULL,
	[CreatedDate] [datetime] NULL,
 CONSTRAINT [PK_HOAT_DONG] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KHOA]    Script Date: 12/8/2023 11:49:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHOA](
	[MaKhoa] [nchar](10) NOT NULL,
	[TenKhoa] [nvarchar](50) NULL,
	[SDT] [nchar](20) NULL,
	[Email] [nvarchar](50) NULL,
	[NgayThanhLap] [date] NULL,
	[Hide] [bit] NULL,
 CONSTRAINT [PK_KHOA] PRIMARY KEY CLUSTERED 
(
	[MaKhoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHU_TRACH]    Script Date: 12/8/2023 11:49:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHU_TRACH](
	[MaGV] [nchar](10) NOT NULL,
	[NamHoc] [nvarchar](50) NOT NULL,
	[GhiChu] [ntext] NULL,
 CONSTRAINT [PK_PHU_TRACH_1] PRIMARY KEY CLUSTERED 
(
	[MaGV] ASC,
	[NamHoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SINH_VIEN]    Script Date: 12/8/2023 11:49:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SINH_VIEN](
	[MSSV] [nchar](10) NOT NULL,
	[HoTen] [nvarchar](100) NULL,
	[Khoa] [nchar](10) NULL,
	[Hide] [bit] NULL,
 CONSTRAINT [PK_SINH_VIEN] PRIMARY KEY CLUSTERED 
(
	[MSSV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TAI_CHINH]    Script Date: 12/8/2023 11:49:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TAI_CHINH](
	[ID_TaiChinh] [int] IDENTITY(1,1) NOT NULL,
	[MaHD] [nchar](10) NULL,
	[UEF] [decimal](12, 0) NULL,
	[TaiTro] [decimal](12, 0) NULL,
	[Khac] [ntext] NULL,
	[TieuDe] [ntext] NULL,
	[CreatedDate] [datetime] NULL,
	[Hide] [bit] NULL,
 CONSTRAINT [PK_TAI_CHINH] PRIMARY KEY CLUSTERED 
(
	[ID_TaiChinh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TAI_TRO]    Script Date: 12/8/2023 11:49:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TAI_TRO](
	[ID_TaiTro] [int] IDENTITY(1,1) NOT NULL,
	[TenTaiTro] [nvarchar](100) NULL,
	[DaiDien] [nvarchar](50) NULL,
	[SDT] [nchar](20) NULL,
	[Email] [nvarchar](50) NULL,
	[Hide] [bit] NULL,
 CONSTRAINT [PK_TAI_TRO] PRIMARY KEY CLUSTERED 
(
	[ID_TaiTro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[DOI_TAC] ON 

INSERT [dbo].[DOI_TAC] ([ID_DoiTac], [TenDoiTac], [DaiDien], [SDT], [Email], [Hide]) VALUES (7, N'Cty TNHH Nhat Minh', N'Nguyen Hai A', N'0935455254          ', N'NhatMinhCorp@gmail.com', 0)
INSERT [dbo].[DOI_TAC] ([ID_DoiTac], [TenDoiTac], [DaiDien], [SDT], [Email], [Hide]) VALUES (8, N'Truong THPT Le Quy Don', N'Do Em', N'0285355647          ', N'lqdHigh@uef.edu.vn', 0)
INSERT [dbo].[DOI_TAC] ([ID_DoiTac], [TenDoiTac], [DaiDien], [SDT], [Email], [Hide]) VALUES (9, N'Đại Học Văn Lang', N'Th.S Nguyễn Trung Lang', N'028665417           ', N'VLU@gmail.com', 0)
INSERT [dbo].[DOI_TAC] ([ID_DoiTac], [TenDoiTac], [DaiDien], [SDT], [Email], [Hide]) VALUES (10, N'Hợp tác xã Vô Tiền', N'Nguyễn Thanh Phương', N'025541265           ', N'VT@Bussiness.mail.com', 0)
INSERT [dbo].[DOI_TAC] ([ID_DoiTac], [TenDoiTac], [DaiDien], [SDT], [Email], [Hide]) VALUES (11, N'Tập Đoàn Dầu Khí Miền Nam', N'Nguyễn Thành Long', N'028665425           ', N'DKMN@spf.com', 0)
SET IDENTITY_INSERT [dbo].[DOI_TAC] OFF
GO
INSERT [dbo].[GIANG_VIEN] ([MaGV], [HoTenLot], [Ten], [Khoa], [Hide]) VALUES (N'111111    ', N'Nguyen The', N'Minh', N'UEF001    ', 0)
INSERT [dbo].[GIANG_VIEN] ([MaGV], [HoTenLot], [Ten], [Khoa], [Hide]) VALUES (N'321654    ', N'Nguyen Thanh', N'Phuong', N'UEF002    ', 0)
INSERT [dbo].[GIANG_VIEN] ([MaGV], [HoTenLot], [Ten], [Khoa], [Hide]) VALUES (N'654321    ', N'Nguyen Van', N'Hai', N'UEF003    ', 0)
GO
SET IDENTITY_INSERT [dbo].[HANG_MUC] ON 

INSERT [dbo].[HANG_MUC] ([ID], [TenHangMuc], [Hide]) VALUES (1, N'hang muc A', 0)
INSERT [dbo].[HANG_MUC] ([ID], [TenHangMuc], [Hide]) VALUES (2, N'hang muc B', 0)
INSERT [dbo].[HANG_MUC] ([ID], [TenHangMuc], [Hide]) VALUES (3, N'hang muc C', 0)
INSERT [dbo].[HANG_MUC] ([ID], [TenHangMuc], [Hide]) VALUES (4, N'Hang Muc D', 0)
SET IDENTITY_INSERT [dbo].[HANG_MUC] OFF
GO
INSERT [dbo].[HD_DOITAC] ([ID_DoiTac], [MaHD], [NoiDung]) VALUES (9, N'EV003     ', N'eh?')
INSERT [dbo].[HD_DOITAC] ([ID_DoiTac], [MaHD], [NoiDung]) VALUES (10, N'EV003     ', N'event B.3')
INSERT [dbo].[HD_DOITAC] ([ID_DoiTac], [MaHD], [NoiDung]) VALUES (11, N'EV008     ', N'ev8')
GO
INSERT [dbo].[HD_GIANGVIEN] ([MaHD], [MaGV], [VaiTro]) VALUES (N'EV003     ', N'111111    ', N'Tổ chức')
INSERT [dbo].[HD_GIANGVIEN] ([MaHD], [MaGV], [VaiTro]) VALUES (N'EV003     ', N'654321    ', N'Tham gia')
INSERT [dbo].[HD_GIANGVIEN] ([MaHD], [MaGV], [VaiTro]) VALUES (N'EV004     ', N'111111    ', N'Tổ chức')
INSERT [dbo].[HD_GIANGVIEN] ([MaHD], [MaGV], [VaiTro]) VALUES (N'EV008     ', N'111111    ', N'Tham gia')
INSERT [dbo].[HD_GIANGVIEN] ([MaHD], [MaGV], [VaiTro]) VALUES (N'EV008     ', N'321654    ', N'Tổ chức')
GO
INSERT [dbo].[HD_SINHVIEN] ([MaHD], [MSSV], [VaiTro], [GhiChu]) VALUES (N'EV001     ', N'111111    ', N'Tham gia', N'event1')
INSERT [dbo].[HD_SINHVIEN] ([MaHD], [MSSV], [VaiTro], [GhiChu]) VALUES (N'EV002     ', N'111111    ', N'', N'event 2.3')
INSERT [dbo].[HD_SINHVIEN] ([MaHD], [MSSV], [VaiTro], [GhiChu]) VALUES (N'EV002     ', N'123456    ', N'', N'event 2')
INSERT [dbo].[HD_SINHVIEN] ([MaHD], [MSSV], [VaiTro], [GhiChu]) VALUES (N'EV002     ', N'222222    ', N'', N'')
INSERT [dbo].[HD_SINHVIEN] ([MaHD], [MSSV], [VaiTro], [GhiChu]) VALUES (N'EV002     ', N'987654    ', N'', N'e2')
INSERT [dbo].[HD_SINHVIEN] ([MaHD], [MSSV], [VaiTro], [GhiChu]) VALUES (N'EV003     ', N'111111    ', N'Tham gia', N'ev03
b')
INSERT [dbo].[HD_SINHVIEN] ([MaHD], [MSSV], [VaiTro], [GhiChu]) VALUES (N'EV003     ', N'987654    ', N'Tham gia', N'B')
INSERT [dbo].[HD_SINHVIEN] ([MaHD], [MSSV], [VaiTro], [GhiChu]) VALUES (N'EV004     ', N'222222    ', N'Tham gia', N'note event C')
INSERT [dbo].[HD_SINHVIEN] ([MaHD], [MSSV], [VaiTro], [GhiChu]) VALUES (N'EV004     ', N'654321    ', N'Tổ chức', N'note new ev C')
INSERT [dbo].[HD_SINHVIEN] ([MaHD], [MSSV], [VaiTro], [GhiChu]) VALUES (N'EV005     ', N'111111    ', N'', N'note gam thua')
INSERT [dbo].[HD_SINHVIEN] ([MaHD], [MSSV], [VaiTro], [GhiChu]) VALUES (N'EV005     ', N'333333    ', N'', N'To chuc 5')
INSERT [dbo].[HD_SINHVIEN] ([MaHD], [MSSV], [VaiTro], [GhiChu]) VALUES (N'EV007     ', N'123456    ', N'Tổ chức', N'meh')
INSERT [dbo].[HD_SINHVIEN] ([MaHD], [MSSV], [VaiTro], [GhiChu]) VALUES (N'EV007     ', N'222222    ', N'Tham gia', N'Ev D')
INSERT [dbo].[HD_SINHVIEN] ([MaHD], [MSSV], [VaiTro], [GhiChu]) VALUES (N'EV008     ', N'321654    ', N'Tham gia', N'note1')
GO
INSERT [dbo].[HD_TAITRO] ([ID_TaiTro], [MaHD], [NoiDung]) VALUES (1, N'EV002     ', N'200,000,000đ')
INSERT [dbo].[HD_TAITRO] ([ID_TaiTro], [MaHD], [NoiDung]) VALUES (1, N'EV004     ', N'Nhà tài trợ Vàng')
GO
INSERT [dbo].[HOAT_DONG] ([MaHD], [TenHoatDong], [Loai], [NgayBatDau], [NgayKetThuc], [Hide], [CreatedDate]) VALUES (N'EV001     ', N'Event A', N'Dự án', CAST(N'2023-02-01T00:00:00.000' AS DateTime), CAST(N'2023-02-22T00:00:00.000' AS DateTime), 0, CAST(N'2023-10-23T20:07:04.250' AS DateTime))
INSERT [dbo].[HOAT_DONG] ([MaHD], [TenHoatDong], [Loai], [NgayBatDau], [NgayKetThuc], [Hide], [CreatedDate]) VALUES (N'EV002     ', N'Dự Án Vì Một Ngày Mai Không Deadline', N'Dự án', CAST(N'2023-10-08T12:45:42.000' AS DateTime), CAST(N'2023-10-17T12:45:42.000' AS DateTime), 0, CAST(N'2023-11-02T12:51:45.853' AS DateTime))
INSERT [dbo].[HOAT_DONG] ([MaHD], [TenHoatDong], [Loai], [NgayBatDau], [NgayKetThuc], [Hide], [CreatedDate]) VALUES (N'EV003     ', N'Event B', N'Sự kiện', CAST(N'2023-10-16T17:29:31.000' AS DateTime), CAST(N'2023-10-24T17:29:31.000' AS DateTime), 0, CAST(N'2023-11-02T12:50:25.457' AS DateTime))
INSERT [dbo].[HOAT_DONG] ([MaHD], [TenHoatDong], [Loai], [NgayBatDau], [NgayKetThuc], [Hide], [CreatedDate]) VALUES (N'EV004     ', N'Event C', N'Sự kiện', CAST(N'2023-10-15T17:35:04.000' AS DateTime), CAST(N'2023-10-17T17:35:04.000' AS DateTime), 0, CAST(N'2023-12-08T02:06:43.433' AS DateTime))
INSERT [dbo].[HOAT_DONG] ([MaHD], [TenHoatDong], [Loai], [NgayBatDau], [NgayKetThuc], [Hide], [CreatedDate]) VALUES (N'EV005     ', N'Event 5', N'Sự kiện', CAST(N'2023-10-03T13:01:37.000' AS DateTime), CAST(N'2023-10-18T13:01:37.000' AS DateTime), 0, CAST(N'2023-10-22T01:09:48.267' AS DateTime))
INSERT [dbo].[HOAT_DONG] ([MaHD], [TenHoatDong], [Loai], [NgayBatDau], [NgayKetThuc], [Hide], [CreatedDate]) VALUES (N'EV007     ', N'Event D', N'Dự án', CAST(N'2023-10-17T14:20:25.000' AS DateTime), CAST(N'2023-10-20T14:20:25.000' AS DateTime), 0, CAST(N'2023-10-20T15:11:47.680' AS DateTime))
INSERT [dbo].[HOAT_DONG] ([MaHD], [TenHoatDong], [Loai], [NgayBatDau], [NgayKetThuc], [Hide], [CreatedDate]) VALUES (N'EV008     ', N'AV008', N'Dự án', CAST(N'2023-10-17T07:55:23.000' AS DateTime), CAST(N'2023-11-01T07:55:23.000' AS DateTime), 0, CAST(N'2023-10-31T07:58:58.703' AS DateTime))
INSERT [dbo].[HOAT_DONG] ([MaHD], [TenHoatDong], [Loai], [NgayBatDau], [NgayKetThuc], [Hide], [CreatedDate]) VALUES (N'EV009     ', N'Event 9', N'Dự án', CAST(N'2023-11-29T00:16:03.080' AS DateTime), CAST(N'2023-11-29T00:16:03.077' AS DateTime), 1, CAST(N'2023-11-29T00:16:04.183' AS DateTime))
GO
INSERT [dbo].[KHOA] ([MaKhoa], [TenKhoa], [SDT], [Email], [NgayThanhLap], [Hide]) VALUES (N'UEF001    ', N'Công Nghệ Thông Tin', N'0911222333          ', N'cntt@uef.edu.vn', CAST(N'2005-09-22' AS Date), 0)
INSERT [dbo].[KHOA] ([MaKhoa], [TenKhoa], [SDT], [Email], [NgayThanhLap], [Hide]) VALUES (N'UEF002    ', N'Khoa Kinh Tế', N'0284222666          ', N'kt@uef.edu.vn', CAST(N'2000-06-14' AS Date), 0)
INSERT [dbo].[KHOA] ([MaKhoa], [TenKhoa], [SDT], [Email], [NgayThanhLap], [Hide]) VALUES (N'UEF003    ', N'Khoa Quản Trị Kinh Doanh', N'0283534427          ', N'qtkt@uef.edu.vn', CAST(N'2006-01-25' AS Date), 0)
INSERT [dbo].[KHOA] ([MaKhoa], [TenKhoa], [SDT], [Email], [NgayThanhLap], [Hide]) VALUES (N'UEF004    ', N'Khoa Luật', N'0952648445          ', N'luatuef@uef.edu.vn', CAST(N'2016-01-05' AS Date), 0)
GO
INSERT [dbo].[SINH_VIEN] ([MSSV], [HoTen], [Khoa], [Hide]) VALUES (N'111111    ', N'Nguyen Van C', N'UEF001    ', 0)
INSERT [dbo].[SINH_VIEN] ([MSSV], [HoTen], [Khoa], [Hide]) VALUES (N'123456    ', N'Nguyen The Minh', N'UEF001    ', 0)
INSERT [dbo].[SINH_VIEN] ([MSSV], [HoTen], [Khoa], [Hide]) VALUES (N'222222    ', N'Nguyen Van C', N'UEF002    ', 0)
INSERT [dbo].[SINH_VIEN] ([MSSV], [HoTen], [Khoa], [Hide]) VALUES (N'321654    ', N'Vu THanh Van', N'UEF003    ', 0)
INSERT [dbo].[SINH_VIEN] ([MSSV], [HoTen], [Khoa], [Hide]) VALUES (N'333333    ', N'Nguyen Thi Vam Co Dong', N'UEF003    ', 0)
INSERT [dbo].[SINH_VIEN] ([MSSV], [HoTen], [Khoa], [Hide]) VALUES (N'654321    ', N'Nguyen Thi D', N'UEF001    ', 0)
INSERT [dbo].[SINH_VIEN] ([MSSV], [HoTen], [Khoa], [Hide]) VALUES (N'987654    ', N'Dang Thi Mai', N'UEF001    ', 0)
GO
SET IDENTITY_INSERT [dbo].[TAI_CHINH] ON 

INSERT [dbo].[TAI_CHINH] ([ID_TaiChinh], [MaHD], [UEF], [TaiTro], [Khac], [TieuDe], [CreatedDate], [Hide]) VALUES (1, N'EV004     ', CAST(0 AS Decimal(12, 0)), CAST(0 AS Decimal(12, 0)), N'', N'', CAST(N'2023-12-08T01:52:12.620' AS DateTime), 0)
INSERT [dbo].[TAI_CHINH] ([ID_TaiChinh], [MaHD], [UEF], [TaiTro], [Khac], [TieuDe], [CreatedDate], [Hide]) VALUES (2, N'EV004     ', CAST(2000000 AS Decimal(12, 0)), CAST(20000000 AS Decimal(12, 0)), N'20 Phần quà xe đạp', N'Event C Tai Chinh', CAST(N'2023-12-08T02:07:41.610' AS DateTime), 0)
SET IDENTITY_INSERT [dbo].[TAI_CHINH] OFF
GO
SET IDENTITY_INSERT [dbo].[TAI_TRO] ON 

INSERT [dbo].[TAI_TRO] ([ID_TaiTro], [TenTaiTro], [DaiDien], [SDT], [Email], [Hide]) VALUES (1, N'Tập Đoàn Dầu Khí Miền Nam', N'Nguyễn Hải Nam', N'025356254           ', N'daukhi@miennam.com', 0)
SET IDENTITY_INSERT [dbo].[TAI_TRO] OFF
GO
ALTER TABLE [dbo].[DANH_GIA]  WITH CHECK ADD  CONSTRAINT [FK_DANH_GIA_HOAT_DONG] FOREIGN KEY([MaHD])
REFERENCES [dbo].[HOAT_DONG] ([MaHD])
GO
ALTER TABLE [dbo].[DANH_GIA] CHECK CONSTRAINT [FK_DANH_GIA_HOAT_DONG]
GO
ALTER TABLE [dbo].[DANH_GIA]  WITH CHECK ADD  CONSTRAINT [FK_DANH_GIA_SINH_VIEN] FOREIGN KEY([MSSV])
REFERENCES [dbo].[SINH_VIEN] ([MSSV])
GO
ALTER TABLE [dbo].[DANH_GIA] CHECK CONSTRAINT [FK_DANH_GIA_SINH_VIEN]
GO
ALTER TABLE [dbo].[DANHGIA_DETAILS]  WITH CHECK ADD  CONSTRAINT [FK_DANHGIA_DETAILS_DANH_GIA] FOREIGN KEY([MaDanhGia])
REFERENCES [dbo].[DANH_GIA] ([MaDanhGia])
GO
ALTER TABLE [dbo].[DANHGIA_DETAILS] CHECK CONSTRAINT [FK_DANHGIA_DETAILS_DANH_GIA]
GO
ALTER TABLE [dbo].[DANHGIA_DETAILS]  WITH CHECK ADD  CONSTRAINT [FK_DANHGIA_DETAILS_HANG_MUC] FOREIGN KEY([HangMuc])
REFERENCES [dbo].[HANG_MUC] ([ID])
GO
ALTER TABLE [dbo].[DANHGIA_DETAILS] CHECK CONSTRAINT [FK_DANHGIA_DETAILS_HANG_MUC]
GO
ALTER TABLE [dbo].[GIANG_VIEN]  WITH CHECK ADD  CONSTRAINT [FK_GIANG_VIEN_KHOA] FOREIGN KEY([Khoa])
REFERENCES [dbo].[KHOA] ([MaKhoa])
GO
ALTER TABLE [dbo].[GIANG_VIEN] CHECK CONSTRAINT [FK_GIANG_VIEN_KHOA]
GO
ALTER TABLE [dbo].[HD_DOITAC]  WITH CHECK ADD  CONSTRAINT [FK_DT_HOATDONG_DOI_TAC] FOREIGN KEY([ID_DoiTac])
REFERENCES [dbo].[DOI_TAC] ([ID_DoiTac])
GO
ALTER TABLE [dbo].[HD_DOITAC] CHECK CONSTRAINT [FK_DT_HOATDONG_DOI_TAC]
GO
ALTER TABLE [dbo].[HD_DOITAC]  WITH CHECK ADD  CONSTRAINT [FK_DT_HOATDONG_HOAT_DONG] FOREIGN KEY([MaHD])
REFERENCES [dbo].[HOAT_DONG] ([MaHD])
GO
ALTER TABLE [dbo].[HD_DOITAC] CHECK CONSTRAINT [FK_DT_HOATDONG_HOAT_DONG]
GO
ALTER TABLE [dbo].[HD_GIANGVIEN]  WITH CHECK ADD  CONSTRAINT [FK_HD_GIANGVIEN_GIANG_VIEN] FOREIGN KEY([MaGV])
REFERENCES [dbo].[GIANG_VIEN] ([MaGV])
GO
ALTER TABLE [dbo].[HD_GIANGVIEN] CHECK CONSTRAINT [FK_HD_GIANGVIEN_GIANG_VIEN]
GO
ALTER TABLE [dbo].[HD_GIANGVIEN]  WITH CHECK ADD  CONSTRAINT [FK_HD_GIANGVIEN_HD] FOREIGN KEY([MaHD])
REFERENCES [dbo].[HOAT_DONG] ([MaHD])
GO
ALTER TABLE [dbo].[HD_GIANGVIEN] CHECK CONSTRAINT [FK_HD_GIANGVIEN_HD]
GO
ALTER TABLE [dbo].[HD_SINHVIEN]  WITH CHECK ADD  CONSTRAINT [FK_SV_HOATDONG_HOAT_DONG] FOREIGN KEY([MaHD])
REFERENCES [dbo].[HOAT_DONG] ([MaHD])
GO
ALTER TABLE [dbo].[HD_SINHVIEN] CHECK CONSTRAINT [FK_SV_HOATDONG_HOAT_DONG]
GO
ALTER TABLE [dbo].[HD_SINHVIEN]  WITH CHECK ADD  CONSTRAINT [FK_SV_HOATDONG_SINH_VIEN] FOREIGN KEY([MSSV])
REFERENCES [dbo].[SINH_VIEN] ([MSSV])
GO
ALTER TABLE [dbo].[HD_SINHVIEN] CHECK CONSTRAINT [FK_SV_HOATDONG_SINH_VIEN]
GO
ALTER TABLE [dbo].[HD_TAITRO]  WITH CHECK ADD  CONSTRAINT [FK_HD_TAITRO_HD] FOREIGN KEY([MaHD])
REFERENCES [dbo].[HOAT_DONG] ([MaHD])
GO
ALTER TABLE [dbo].[HD_TAITRO] CHECK CONSTRAINT [FK_HD_TAITRO_HD]
GO
ALTER TABLE [dbo].[HD_TAITRO]  WITH CHECK ADD  CONSTRAINT [FK_HD_TAITRO_TAITRO] FOREIGN KEY([ID_TaiTro])
REFERENCES [dbo].[TAI_TRO] ([ID_TaiTro])
GO
ALTER TABLE [dbo].[HD_TAITRO] CHECK CONSTRAINT [FK_HD_TAITRO_TAITRO]
GO
ALTER TABLE [dbo].[PHU_TRACH]  WITH CHECK ADD  CONSTRAINT [FK_PHU_TRACH_GIANG_VIEN] FOREIGN KEY([MaGV])
REFERENCES [dbo].[GIANG_VIEN] ([MaGV])
GO
ALTER TABLE [dbo].[PHU_TRACH] CHECK CONSTRAINT [FK_PHU_TRACH_GIANG_VIEN]
GO
ALTER TABLE [dbo].[SINH_VIEN]  WITH CHECK ADD  CONSTRAINT [FK_SINH_VIEN_KHOA] FOREIGN KEY([Khoa])
REFERENCES [dbo].[KHOA] ([MaKhoa])
GO
ALTER TABLE [dbo].[SINH_VIEN] CHECK CONSTRAINT [FK_SINH_VIEN_KHOA]
GO
ALTER TABLE [dbo].[TAI_CHINH]  WITH CHECK ADD  CONSTRAINT [FK_TAI_CHINH_HOAT_DONG] FOREIGN KEY([MaHD])
REFERENCES [dbo].[HOAT_DONG] ([MaHD])
GO
ALTER TABLE [dbo].[TAI_CHINH] CHECK CONSTRAINT [FK_TAI_CHINH_HOAT_DONG]
GO
USE [master]
GO
ALTER DATABASE [Service_Learning] SET  READ_WRITE 
GO
