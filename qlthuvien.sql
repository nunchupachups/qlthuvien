USE [master]
GO
/****** Object:  Database [QLTHUVIEN]    Script Date: 1/1/2022 11:14:56 PM ******/
CREATE DATABASE [QLTHUVIEN]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLTHUVIEN', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\QLTHUVIEN.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QLTHUVIEN_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\QLTHUVIEN_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QLTHUVIEN] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLTHUVIEN].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLTHUVIEN] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLTHUVIEN] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLTHUVIEN] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLTHUVIEN] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLTHUVIEN] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLTHUVIEN] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLTHUVIEN] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLTHUVIEN] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLTHUVIEN] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLTHUVIEN] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLTHUVIEN] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLTHUVIEN] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLTHUVIEN] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLTHUVIEN] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLTHUVIEN] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QLTHUVIEN] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLTHUVIEN] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLTHUVIEN] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLTHUVIEN] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLTHUVIEN] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLTHUVIEN] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLTHUVIEN] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLTHUVIEN] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QLTHUVIEN] SET  MULTI_USER 
GO
ALTER DATABASE [QLTHUVIEN] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLTHUVIEN] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLTHUVIEN] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLTHUVIEN] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [QLTHUVIEN] SET DELAYED_DURABILITY = DISABLED 
GO
USE [QLTHUVIEN]
GO
/****** Object:  Table [dbo].[dausach]    Script Date: 1/1/2022 11:14:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dausach](
	[madausach] [bigint] IDENTITY(1,1) NOT NULL,
	[tensach] [nvarchar](150) NULL,
	[tacgia] [nvarchar](50) NULL,
	[nhaxuatban] [nvarchar](150) NULL,
	[maloai] [bigint] NULL,
 CONSTRAINT [PK_dausach] PRIMARY KEY CLUSTERED 
(
	[madausach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[docgiakhac]    Script Date: 1/1/2022 11:14:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[docgiakhac](
	[madocgia] [bigint] IDENTITY(1,1) NOT NULL,
	[hoten] [nvarchar](50) NULL,
	[ngaysinh] [date] NULL,
	[mathe] [bigint] NULL,
 CONSTRAINT [PK_docgiakhac] PRIMARY KEY CLUSTERED 
(
	[madocgia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[giangvien]    Script Date: 1/1/2022 11:14:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[giangvien](
	[magiangvien] [nvarchar](50) NOT NULL,
	[hoten] [nvarchar](50) NULL,
	[ngaysinh] [date] NULL,
	[makhoa] [nvarchar](50) NULL,
	[mathe] [bigint] NULL,
 CONSTRAINT [PK_giangvien] PRIMARY KEY CLUSTERED 
(
	[magiangvien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[khoa]    Script Date: 1/1/2022 11:14:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[khoa](
	[makhoa] [nvarchar](50) NOT NULL,
	[tenkhoa] [nvarchar](150) NULL,
 CONSTRAINT [PK_khoa] PRIMARY KEY CLUSTERED 
(
	[makhoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[loaisach]    Script Date: 1/1/2022 11:14:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[loaisach](
	[maloai] [bigint] IDENTITY(1,1) NOT NULL,
	[tenloai] [nvarchar](150) NULL,
 CONSTRAINT [PK_loaisach] PRIMARY KEY CLUSTERED 
(
	[maloai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[muonsach]    Script Date: 1/1/2022 11:14:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[muonsach](
	[mamuonsach] [bigint] IDENTITY(1,1) NOT NULL,
	[masach] [bigint] NULL,
	[mathe] [bigint] NULL,
	[ngaymuon] [date] NULL,
	[hantra] [date] NULL,
 CONSTRAINT [PK_muonsach] PRIMARY KEY CLUSTERED 
(
	[mamuonsach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[nhanvien]    Script Date: 1/1/2022 11:14:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[nhanvien](
	[idnhanvien] [bigint] IDENTITY(1,1) NOT NULL,
	[hoten] [nvarchar](50) NULL,
	[tendangnhap] [nvarchar](50) NULL,
	[matkhau] [nvarchar](50) NULL,
 CONSTRAINT [PK_nhanvien] PRIMARY KEY CLUSTERED 
(
	[idnhanvien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[sach]    Script Date: 1/1/2022 11:14:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sach](
	[masach] [bigint] IDENTITY(1,1) NOT NULL,
	[madausach] [bigint] NULL,
	[tinhtrang] [nvarchar](500) NULL,
	[matsach] [bit] NULL,
	[damuon] [bit] NULL,
 CONSTRAINT [PK_sach] PRIMARY KEY CLUSTERED 
(
	[masach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[sinhvien]    Script Date: 1/1/2022 11:14:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sinhvien](
	[masinhvien] [nvarchar](50) NOT NULL,
	[hoten] [nvarchar](50) NULL,
	[ngaysinh] [date] NULL,
	[makhoa] [nvarchar](50) NULL,
	[mathe] [bigint] NULL,
 CONSTRAINT [PK_sinhvien] PRIMARY KEY CLUSTERED 
(
	[masinhvien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[the]    Script Date: 1/1/2022 11:14:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[the](
	[mathe] [bigint] IDENTITY(1,1) NOT NULL,
	[ngaytao] [date] NULL,
	[hanthe] [date] NULL,
 CONSTRAINT [PK_the] PRIMARY KEY CLUSTERED 
(
	[mathe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[dausach] ON 

INSERT [dbo].[dausach] ([madausach], [tensach], [tacgia], [nhaxuatban], [maloai]) VALUES (1, N'Tôi thấy hoa hàng trên cỏ xanh', N'Nguyễn Nhật Ánh', N'Nhà xuất bản Trẻ', 1)
SET IDENTITY_INSERT [dbo].[dausach] OFF
INSERT [dbo].[giangvien] ([magiangvien], [hoten], [ngaysinh], [makhoa], [mathe]) VALUES (N'GV001', N'Lê Văn Tường Lân', CAST(N'1980-12-28' AS Date), N'CNTT', 1)
INSERT [dbo].[khoa] ([makhoa], [tenkhoa]) VALUES (N'CNTT', N'Công nghệ thông tin')
SET IDENTITY_INSERT [dbo].[loaisach] ON 

INSERT [dbo].[loaisach] ([maloai], [tenloai]) VALUES (1, N'Tiểu thuyết')
INSERT [dbo].[loaisach] ([maloai], [tenloai]) VALUES (2, N'Sách giáo trình')
SET IDENTITY_INSERT [dbo].[loaisach] OFF
SET IDENTITY_INSERT [dbo].[muonsach] ON 

INSERT [dbo].[muonsach] ([mamuonsach], [masach], [mathe], [ngaymuon], [hantra]) VALUES (1, 1, 2, CAST(N'2022-01-01' AS Date), CAST(N'2022-02-01' AS Date))
SET IDENTITY_INSERT [dbo].[muonsach] OFF
SET IDENTITY_INSERT [dbo].[nhanvien] ON 

INSERT [dbo].[nhanvien] ([idnhanvien], [hoten], [tendangnhap], [matkhau]) VALUES (1, N'trang', N'trang', N'123')
SET IDENTITY_INSERT [dbo].[nhanvien] OFF
SET IDENTITY_INSERT [dbo].[sach] ON 

INSERT [dbo].[sach] ([masach], [madausach], [tinhtrang], [matsach], [damuon]) VALUES (1, 1, N'bẩn bìa sau', 0, 1)
SET IDENTITY_INSERT [dbo].[sach] OFF
INSERT [dbo].[sinhvien] ([masinhvien], [hoten], [ngaysinh], [makhoa], [mathe]) VALUES (N'18T1001', N'Dương Thị Kiều Trang', CAST(N'2000-06-13' AS Date), N'CNTT', 2)
SET IDENTITY_INSERT [dbo].[the] ON 

INSERT [dbo].[the] ([mathe], [ngaytao], [hanthe]) VALUES (1, CAST(N'2021-12-28' AS Date), CAST(N'2022-06-28' AS Date))
INSERT [dbo].[the] ([mathe], [ngaytao], [hanthe]) VALUES (2, CAST(N'2022-01-01' AS Date), CAST(N'2023-01-01' AS Date))
SET IDENTITY_INSERT [dbo].[the] OFF
ALTER TABLE [dbo].[dausach]  WITH CHECK ADD  CONSTRAINT [FK_dausach_loaisach] FOREIGN KEY([maloai])
REFERENCES [dbo].[loaisach] ([maloai])
GO
ALTER TABLE [dbo].[dausach] CHECK CONSTRAINT [FK_dausach_loaisach]
GO
ALTER TABLE [dbo].[docgiakhac]  WITH CHECK ADD  CONSTRAINT [FK_docgiakhac_the] FOREIGN KEY([mathe])
REFERENCES [dbo].[the] ([mathe])
GO
ALTER TABLE [dbo].[docgiakhac] CHECK CONSTRAINT [FK_docgiakhac_the]
GO
ALTER TABLE [dbo].[giangvien]  WITH CHECK ADD  CONSTRAINT [FK_giangvien_khoa] FOREIGN KEY([makhoa])
REFERENCES [dbo].[khoa] ([makhoa])
GO
ALTER TABLE [dbo].[giangvien] CHECK CONSTRAINT [FK_giangvien_khoa]
GO
ALTER TABLE [dbo].[giangvien]  WITH CHECK ADD  CONSTRAINT [FK_giangvien_the] FOREIGN KEY([mathe])
REFERENCES [dbo].[the] ([mathe])
GO
ALTER TABLE [dbo].[giangvien] CHECK CONSTRAINT [FK_giangvien_the]
GO
ALTER TABLE [dbo].[muonsach]  WITH CHECK ADD  CONSTRAINT [FK_muonsach_sach] FOREIGN KEY([masach])
REFERENCES [dbo].[sach] ([masach])
GO
ALTER TABLE [dbo].[muonsach] CHECK CONSTRAINT [FK_muonsach_sach]
GO
ALTER TABLE [dbo].[muonsach]  WITH CHECK ADD  CONSTRAINT [FK_muonsach_the] FOREIGN KEY([mathe])
REFERENCES [dbo].[the] ([mathe])
GO
ALTER TABLE [dbo].[muonsach] CHECK CONSTRAINT [FK_muonsach_the]
GO
ALTER TABLE [dbo].[sach]  WITH CHECK ADD  CONSTRAINT [FK_sach_dausach] FOREIGN KEY([madausach])
REFERENCES [dbo].[dausach] ([madausach])
GO
ALTER TABLE [dbo].[sach] CHECK CONSTRAINT [FK_sach_dausach]
GO
ALTER TABLE [dbo].[sinhvien]  WITH CHECK ADD  CONSTRAINT [FK_sinhvien_khoa] FOREIGN KEY([makhoa])
REFERENCES [dbo].[khoa] ([makhoa])
GO
ALTER TABLE [dbo].[sinhvien] CHECK CONSTRAINT [FK_sinhvien_khoa]
GO
ALTER TABLE [dbo].[sinhvien]  WITH CHECK ADD  CONSTRAINT [FK_sinhvien_the] FOREIGN KEY([mathe])
REFERENCES [dbo].[the] ([mathe])
GO
ALTER TABLE [dbo].[sinhvien] CHECK CONSTRAINT [FK_sinhvien_the]
GO
USE [master]
GO
ALTER DATABASE [QLTHUVIEN] SET  READ_WRITE 
GO
