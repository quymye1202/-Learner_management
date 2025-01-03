USE [master]
GO
/****** Object:  Database [quanlyhocvien]    Script Date: 10/30/2024 7:09:12 PM ******/
CREATE DATABASE [quanlyhocvien]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'quanlyhocvien', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MAY1\MSSQL\DATA\quanlyhocvien.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'quanlyhocvien_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MAY1\MSSQL\DATA\quanlyhocvien_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [quanlyhocvien] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [quanlyhocvien].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [quanlyhocvien] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [quanlyhocvien] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [quanlyhocvien] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [quanlyhocvien] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [quanlyhocvien] SET ARITHABORT OFF 
GO
ALTER DATABASE [quanlyhocvien] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [quanlyhocvien] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [quanlyhocvien] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [quanlyhocvien] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [quanlyhocvien] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [quanlyhocvien] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [quanlyhocvien] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [quanlyhocvien] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [quanlyhocvien] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [quanlyhocvien] SET  DISABLE_BROKER 
GO
ALTER DATABASE [quanlyhocvien] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [quanlyhocvien] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [quanlyhocvien] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [quanlyhocvien] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [quanlyhocvien] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [quanlyhocvien] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [quanlyhocvien] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [quanlyhocvien] SET RECOVERY FULL 
GO
ALTER DATABASE [quanlyhocvien] SET  MULTI_USER 
GO
ALTER DATABASE [quanlyhocvien] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [quanlyhocvien] SET DB_CHAINING OFF 
GO
ALTER DATABASE [quanlyhocvien] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [quanlyhocvien] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [quanlyhocvien] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [quanlyhocvien] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'quanlyhocvien', N'ON'
GO
ALTER DATABASE [quanlyhocvien] SET QUERY_STORE = ON
GO
ALTER DATABASE [quanlyhocvien] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [quanlyhocvien]
GO
/****** Object:  Table [dbo].[bangdiem]    Script Date: 10/30/2024 7:09:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bangdiem](
	[bangdiem_id] [int] NOT NULL,
	[hocvien_id] [int] NOT NULL,
	[lophoc_id] [int] NOT NULL,
	[diem_so] [decimal](4, 2) NULL,
	[ngay_thi] [date] NULL,
 CONSTRAINT [PK_bangdiem] PRIMARY KEY CLUSTERED 
(
	[bangdiem_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[dangky]    Script Date: 10/30/2024 7:09:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dangky](
	[dangky_id] [int] NOT NULL,
	[hocvien_id] [int] NOT NULL,
	[lophoc_id] [int] NOT NULL,
	[ngay_dang_ky] [date] NOT NULL,
	[trang_thai] [nvarchar](20) NULL,
 CONSTRAINT [PK_dangky] PRIMARY KEY CLUSTERED 
(
	[dangky_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[giangvien]    Script Date: 10/30/2024 7:09:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[giangvien](
	[giangvien_id] [int] NOT NULL,
	[ho_ten] [nvarchar](100) NOT NULL,
	[chuyen_mon] [nvarchar](50) NULL,
	[so_dien_thoai] [nvarchar](15) NULL,
	[email] [nvarchar](100) NULL,
 CONSTRAINT [PK_giangvien] PRIMARY KEY CLUSTERED 
(
	[giangvien_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[hocvien]    Script Date: 10/30/2024 7:09:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hocvien](
	[hocvien_id] [int] NOT NULL,
	[ho_ten] [nvarchar](100) NOT NULL,
	[ngay_sinh] [date] NULL,
	[gioi_tinh] [nchar](10) NULL,
	[dia_chi] [nvarchar](200) NULL,
	[so_dien_thoai] [nvarchar](15) NULL,
	[email] [nvarchar](100) NULL,
	[ngay_dang_ky] [date] NOT NULL,
	[trinh_do] [nvarchar](50) NULL,
 CONSTRAINT [PK_hocvien] PRIMARY KEY CLUSTERED 
(
	[hocvien_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[khoahoc]    Script Date: 10/30/2024 7:09:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[khoahoc](
	[khoahoc_id] [int] NOT NULL,
	[ten_khoa_hoc] [nvarchar](100) NOT NULL,
	[mo_ta] [ntext] NULL,
	[trinh_do] [nvarchar](10) NULL,
	[hoc_phi] [decimal](10, 2) NOT NULL,
	[ngay_bat_dau] [date] NOT NULL,
	[ngay_ket_thuc] [date] NULL,
 CONSTRAINT [PK_khoahoc] PRIMARY KEY CLUSTERED 
(
	[khoahoc_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[lophoc]    Script Date: 10/30/2024 7:09:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[lophoc](
	[lophoc_id] [int] NOT NULL,
	[khoahoc_id] [int] NOT NULL,
	[giangvien_id] [int] NULL,
	[ten_lop] [nvarchar](100) NOT NULL,
	[lich_hoc] [nvarchar](100) NULL,
 CONSTRAINT [PK_lophoc] PRIMARY KEY CLUSTERED 
(
	[lophoc_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[bangdiem]  WITH CHECK ADD  CONSTRAINT [FK_bangdiem_hocvien] FOREIGN KEY([hocvien_id])
REFERENCES [dbo].[hocvien] ([hocvien_id])
GO
ALTER TABLE [dbo].[bangdiem] CHECK CONSTRAINT [FK_bangdiem_hocvien]
GO
ALTER TABLE [dbo].[bangdiem]  WITH CHECK ADD  CONSTRAINT [FK_bangdiem_lophoc] FOREIGN KEY([lophoc_id])
REFERENCES [dbo].[lophoc] ([lophoc_id])
GO
ALTER TABLE [dbo].[bangdiem] CHECK CONSTRAINT [FK_bangdiem_lophoc]
GO
ALTER TABLE [dbo].[dangky]  WITH CHECK ADD  CONSTRAINT [FK_dangky_hocvien] FOREIGN KEY([hocvien_id])
REFERENCES [dbo].[hocvien] ([hocvien_id])
GO
ALTER TABLE [dbo].[dangky] CHECK CONSTRAINT [FK_dangky_hocvien]
GO
ALTER TABLE [dbo].[dangky]  WITH CHECK ADD  CONSTRAINT [FK_dangky_lophoc] FOREIGN KEY([lophoc_id])
REFERENCES [dbo].[lophoc] ([lophoc_id])
GO
ALTER TABLE [dbo].[dangky] CHECK CONSTRAINT [FK_dangky_lophoc]
GO
ALTER TABLE [dbo].[lophoc]  WITH CHECK ADD  CONSTRAINT [FK_lophoc_giangvien] FOREIGN KEY([giangvien_id])
REFERENCES [dbo].[giangvien] ([giangvien_id])
GO
ALTER TABLE [dbo].[lophoc] CHECK CONSTRAINT [FK_lophoc_giangvien]
GO
ALTER TABLE [dbo].[lophoc]  WITH CHECK ADD  CONSTRAINT [FK_lophoc_khoahoc] FOREIGN KEY([khoahoc_id])
REFERENCES [dbo].[khoahoc] ([khoahoc_id])
GO
ALTER TABLE [dbo].[lophoc] CHECK CONSTRAINT [FK_lophoc_khoahoc]
GO
USE [master]
GO
ALTER DATABASE [quanlyhocvien] SET  READ_WRITE 
GO
