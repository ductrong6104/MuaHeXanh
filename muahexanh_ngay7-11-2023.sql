USE [master]
GO
/****** Object:  Database [TTCS_MUAHEXANH]    Script Date: 7/11/2023 4:16:49 PM ******/
CREATE DATABASE [TTCS_MUAHEXANH]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TTCS_MUAHEXANH', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.DUCTRONG\MSSQL\DATA\TTCS_MUAHEXANH.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'TTCS_MUAHEXANH_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.DUCTRONG\MSSQL\DATA\TTCS_MUAHEXANH_log.ldf' , SIZE = 73728KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [TTCS_MUAHEXANH] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TTCS_MUAHEXANH].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TTCS_MUAHEXANH] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TTCS_MUAHEXANH] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TTCS_MUAHEXANH] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TTCS_MUAHEXANH] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TTCS_MUAHEXANH] SET ARITHABORT OFF 
GO
ALTER DATABASE [TTCS_MUAHEXANH] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TTCS_MUAHEXANH] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TTCS_MUAHEXANH] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TTCS_MUAHEXANH] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TTCS_MUAHEXANH] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TTCS_MUAHEXANH] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TTCS_MUAHEXANH] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TTCS_MUAHEXANH] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TTCS_MUAHEXANH] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TTCS_MUAHEXANH] SET  DISABLE_BROKER 
GO
ALTER DATABASE [TTCS_MUAHEXANH] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TTCS_MUAHEXANH] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TTCS_MUAHEXANH] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TTCS_MUAHEXANH] SET ALLOW_SNAPSHOT_ISOLATION ON 
GO
ALTER DATABASE [TTCS_MUAHEXANH] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TTCS_MUAHEXANH] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TTCS_MUAHEXANH] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TTCS_MUAHEXANH] SET RECOVERY FULL 
GO
ALTER DATABASE [TTCS_MUAHEXANH] SET  MULTI_USER 
GO
ALTER DATABASE [TTCS_MUAHEXANH] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TTCS_MUAHEXANH] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TTCS_MUAHEXANH] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TTCS_MUAHEXANH] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [TTCS_MUAHEXANH] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [TTCS_MUAHEXANH] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'TTCS_MUAHEXANH', N'ON'
GO
ALTER DATABASE [TTCS_MUAHEXANH] SET QUERY_STORE = OFF
GO
USE [TTCS_MUAHEXANH]
GO
/****** Object:  User [N20DCVT005]    Script Date: 7/11/2023 4:16:49 PM ******/
CREATE USER [N20DCVT005] FOR LOGIN [N20DCVT005] WITH DEFAULT_SCHEMA=[N20DCVT005]
GO
/****** Object:  User [N20DCCN079]    Script Date: 7/11/2023 4:16:49 PM ******/
CREATE USER [N20DCCN079] FOR LOGIN [N20DCCN079] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [N20DCCN052]    Script Date: 7/11/2023 4:16:49 PM ******/
CREATE USER [N20DCCN052] FOR LOGIN [N20DCCN052] WITH DEFAULT_SCHEMA=[N20DCCN052]
GO
/****** Object:  User [GV10]    Script Date: 7/11/2023 4:16:49 PM ******/
CREATE USER [GV10] FOR LOGIN [KHOA] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [GV09]    Script Date: 7/11/2023 4:16:49 PM ******/
CREATE USER [GV09] FOR LOGIN [ADMIN] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [GV08 ]    Script Date: 7/11/2023 4:16:49 PM ******/
CREATE USER [GV08 ] FOR LOGIN [GV08 ] WITH DEFAULT_SCHEMA=[GV08 ]
GO
/****** Object:  User [GV01 ]    Script Date: 7/11/2023 4:16:49 PM ******/
CREATE USER [GV01 ] FOR LOGIN [GV01 ] WITH DEFAULT_SCHEMA=[GV01 ]
GO
/****** Object:  DatabaseRole [SINHVIEN]    Script Date: 7/11/2023 4:16:49 PM ******/
CREATE ROLE [SINHVIEN]
GO
/****** Object:  DatabaseRole [NHOMTRUONG]    Script Date: 7/11/2023 4:16:49 PM ******/
CREATE ROLE [NHOMTRUONG]
GO
/****** Object:  DatabaseRole [KHOA]    Script Date: 7/11/2023 4:16:49 PM ******/
CREATE ROLE [KHOA]
GO
/****** Object:  DatabaseRole [GIAMSAT]    Script Date: 7/11/2023 4:16:49 PM ******/
CREATE ROLE [GIAMSAT]
GO
/****** Object:  DatabaseRole [DOITRUONG]    Script Date: 7/11/2023 4:16:49 PM ******/
CREATE ROLE [DOITRUONG]
GO
/****** Object:  DatabaseRole [DOIPHO]    Script Date: 7/11/2023 4:16:49 PM ******/
CREATE ROLE [DOIPHO]
GO
/****** Object:  DatabaseRole [ADMIN]    Script Date: 7/11/2023 4:16:49 PM ******/
CREATE ROLE [ADMIN]
GO
ALTER ROLE [DOITRUONG] ADD MEMBER [N20DCVT005]
GO
ALTER ROLE [db_datareader] ADD MEMBER [N20DCVT005]
GO
ALTER ROLE [DOITRUONG] ADD MEMBER [N20DCCN079]
GO
ALTER ROLE [db_datareader] ADD MEMBER [N20DCCN079]
GO
ALTER ROLE [DOITRUONG] ADD MEMBER [N20DCCN052]
GO
ALTER ROLE [db_datareader] ADD MEMBER [N20DCCN052]
GO
ALTER ROLE [KHOA] ADD MEMBER [GV10]
GO
ALTER ROLE [db_owner] ADD MEMBER [GV10]
GO
ALTER ROLE [db_securityadmin] ADD MEMBER [GV10]
GO
ALTER ROLE [ADMIN] ADD MEMBER [GV09]
GO
ALTER ROLE [db_owner] ADD MEMBER [GV09]
GO
ALTER ROLE [db_accessadmin] ADD MEMBER [GV09]
GO
ALTER ROLE [db_securityadmin] ADD MEMBER [GV09]
GO
ALTER ROLE [db_backupoperator] ADD MEMBER [GV09]
GO
ALTER ROLE [db_datareader] ADD MEMBER [GV09]
GO
ALTER ROLE [GIAMSAT] ADD MEMBER [GV08 ]
GO
ALTER ROLE [db_datareader] ADD MEMBER [GV08 ]
GO
ALTER ROLE [GIAMSAT] ADD MEMBER [GV01 ]
GO
ALTER ROLE [db_datareader] ADD MEMBER [GV01 ]
GO
ALTER ROLE [db_datareader] ADD MEMBER [SINHVIEN]
GO
ALTER ROLE [db_datareader] ADD MEMBER [NHOMTRUONG]
GO
ALTER ROLE [db_owner] ADD MEMBER [KHOA]
GO
ALTER ROLE [db_securityadmin] ADD MEMBER [KHOA]
GO
ALTER ROLE [db_datareader] ADD MEMBER [GIAMSAT]
GO
ALTER ROLE [db_datareader] ADD MEMBER [DOITRUONG]
GO
ALTER ROLE [db_datareader] ADD MEMBER [DOIPHO]
GO
ALTER ROLE [db_owner] ADD MEMBER [ADMIN]
GO
ALTER ROLE [db_accessadmin] ADD MEMBER [ADMIN]
GO
ALTER ROLE [db_securityadmin] ADD MEMBER [ADMIN]
GO
ALTER ROLE [db_backupoperator] ADD MEMBER [ADMIN]
GO
ALTER ROLE [db_datareader] ADD MEMBER [ADMIN]
GO
GRANT CONNECT TO [GV01 ] AS [dbo]
GO
GRANT CONNECT TO [GV08 ] AS [dbo]
GO
GRANT CONNECT TO [GV09] AS [dbo]
GO
GRANT CONNECT TO [GV10] AS [dbo]
GO
GRANT CONNECT TO [N20DCCN052] AS [dbo]
GO
GRANT CONNECT TO [N20DCCN079] AS [dbo]
GO
GRANT CONNECT TO [N20DCVT005] AS [dbo]
GO
GRANT VIEW ANY COLUMN ENCRYPTION KEY DEFINITION TO [public] AS [dbo]
GO
GRANT VIEW ANY COLUMN MASTER KEY DEFINITION TO [public] AS [dbo]
GO
/****** Object:  Schema [1]    Script Date: 7/11/2023 4:16:49 PM ******/
CREATE SCHEMA [1]
GO
/****** Object:  Schema [GV01 ]    Script Date: 7/11/2023 4:16:49 PM ******/
CREATE SCHEMA [GV01 ]
GO
/****** Object:  Schema [GV08 ]    Script Date: 7/11/2023 4:16:49 PM ******/
CREATE SCHEMA [GV08 ]
GO
/****** Object:  Schema [N20DCCN052]    Script Date: 7/11/2023 4:16:49 PM ******/
CREATE SCHEMA [N20DCCN052]
GO
/****** Object:  Schema [N20DCVT005]    Script Date: 7/11/2023 4:16:49 PM ******/
CREATE SCHEMA [N20DCVT005]
GO
/****** Object:  UserDefinedTableType [dbo].[TYPE_CHIANHOM]    Script Date: 7/11/2023 4:16:49 PM ******/
CREATE TYPE [dbo].[TYPE_CHIANHOM] AS TABLE(
	[MANHOM] [nchar](5) NULL,
	[MASV] [nchar](10) NULL
)
GO
GRANT CONTROL ON TYPE::[dbo].[TYPE_CHIANHOM] TO [DOIPHO] AS [dbo]
GO
GRANT CONTROL ON TYPE::[dbo].[TYPE_CHIANHOM] TO [DOITRUONG] AS [dbo]
GO
/****** Object:  UserDefinedTableType [dbo].[TYPE_KHOIPHUCTAIKHOAN]    Script Date: 7/11/2023 4:16:49 PM ******/
CREATE TYPE [dbo].[TYPE_KHOIPHUCTAIKHOAN] AS TABLE(
	[lgname] [nchar](10) NULL
)
GO
/****** Object:  UserDefinedFunction [dbo].[Fc_SinhMaChienDich]    Script Date: 7/11/2023 4:16:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date, ,>
-- Description:	<Description, ,>
-- =============================================
CREATE FUNCTION [dbo].[Fc_SinhMaChienDich]
(

)
RETURNS NCHAR(7)
AS
BEGIN
	-- Declare the return variable here
	DECLARE @MaChienDich nchar(4)

	DECLARE @MaChienDichLonNhat INT

	-- Add the T-SQL statements to compute the return value here
	SELECT @MaChienDich = MAX(MaChienDich)
	FROM ChienDich

	SET @MaChienDichLonNhat = CAST(SUBSTRING(@MaChienDich, 3, 2) AS INT)

	IF @MaChienDichLonNhat IS NULL
		SET @MaChienDichLonNhat = 0

	SET @MaChienDichLonNhat = @MaChienDichLonNhat + 1

	IF @MaChienDichLonNhat < 10
		SET @MaChienDich = 'CD0' + CAST(@MaChienDichLonNhat AS NCHAR)
	ELSE
		SET @MaChienDich = 'CD' + CAST(@MaChienDichLonNhat AS NCHAR)

	-- Return the result of the function
	RETURN @MaChienDich

END
GO
/****** Object:  UserDefinedFunction [dbo].[Fc_SinhMaCongViec]    Script Date: 7/11/2023 4:16:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date, ,>
-- Description:	<Description, ,>
-- =============================================
CREATE FUNCTION [dbo].[Fc_SinhMaCongViec]
(

)
RETURNS NCHAR(4)
AS
BEGIN
	-- Declare the return variable here
	DECLARE @MaCongViec nchar(4)

	DECLARE @MaCongViecLonNhat INT

	-- Add the T-SQL statements to compute the return value here
	SELECT @MaCongViec = MAX(MaCV)
	FROM CongViec

	SET @MaCongViecLonNhat = CAST(SUBSTRING(@MaCongViec, 3, 2) AS INT)

	IF @MaCongViecLonNhat IS NULL
		SET @MaCongViecLonNhat = 0

	SET @MaCongViecLonNhat = @MaCongViecLonNhat + 1

	IF @MaCongViecLonNhat < 10
		SET @MaCongViec = 'CV0' + CAST(@MaCongViecLonNhat AS NCHAR)
	ELSE
		SET @MaCongViec = 'CV' + CAST(@MaCongViecLonNhat AS NCHAR)

	-- Return the result of the function
	RETURN @MaCongViec

END
GO
/****** Object:  UserDefinedFunction [dbo].[FC_TenNhom]    Script Date: 7/11/2023 4:16:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[FC_TenNhom]
(@TENUSER NVARCHAR(50))
RETURNS NVARCHAR(50)
AS
BEGIN
	DECLARE @TENNHOM NVARCHAR(50)
	SELECT @TENNHOM = NAME
	FROM sys.sysusers 
	WHERE UID = (SELECT GROUPUID FROM SYS.SYSMEMBERS WHERE MEMBERUID= (SELECT UID FROM sys.sysusers WHERE NAME=@TENUSER))
	RETURN @TENNHOM
END
GO
/****** Object:  Table [dbo].[DiaBan]    Script Date: 7/11/2023 4:16:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DiaBan](
	[MaDiaBan] [nchar](4) NOT NULL,
	[TenDiaBan] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_MaDiaBan] PRIMARY KEY CLUSTERED 
(
	[MaDiaBan] DESC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietChienDich]    Script Date: 7/11/2023 4:16:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietChienDich](
	[MaChienDich] [nchar](7) NOT NULL,
	[MaDiaBan] [nchar](4) NOT NULL,
 CONSTRAINT [PK_CHITIETCHIENDICH] PRIMARY KEY CLUSTERED 
(
	[MaChienDich] ASC,
	[MaDiaBan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  UserDefinedFunction [dbo].[Fc_DanhSachDiaBanTheoMaChienDich]    Script Date: 7/11/2023 4:16:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE FUNCTION [dbo].[Fc_DanhSachDiaBanTheoMaChienDich] 
(	
	@MaChienDich nchar(7)
)
RETURNS TABLE 
AS
RETURN 
(
	-- Add the SELECT statement with parameter references here
	SELECT CTCD.MaDiaBan, DiaBan.TenDiaBan
	FROM (SELECT * FROM ChiTietChienDich WHERE MaChienDich = @MaChienDich) AS CTCD 
	INNER JOIN DiaBan ON CTCD.MaDiaBan = DiaBan.MaDiaBan
)
GO
/****** Object:  Table [dbo].[Ap]    Script Date: 7/11/2023 4:16:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ap](
	[MaAp] [nchar](4) NOT NULL,
	[TenAp] [nvarchar](50) NOT NULL,
	[MaXa] [nchar](4) NOT NULL,
 CONSTRAINT [PK_Ap] PRIMARY KEY CLUSTERED 
(
	[MaAp] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChienDich]    Script Date: 7/11/2023 4:16:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChienDich](
	[MaChienDich] [nchar](7) NOT NULL,
	[TenChienDich] [nvarchar](50) NOT NULL,
	[NgayPhatDong] [date] NOT NULL,
	[NgayKetThuc] [date] NOT NULL,
 CONSTRAINT [PK_ChienDich] PRIMARY KEY CLUSTERED 
(
	[MaChienDich] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
GRANT DELETE ON [dbo].[ChienDich] TO [ADMIN] AS [dbo]
GO
GRANT INSERT ON [dbo].[ChienDich] TO [ADMIN] AS [dbo]
GO
GRANT UPDATE ON [dbo].[ChienDich] TO [ADMIN] AS [dbo]
GO
/****** Object:  Table [dbo].[CongViec]    Script Date: 7/11/2023 4:16:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CongViec](
	[MaCV] [nchar](4) NOT NULL,
	[TenCV] [nvarchar](100) NOT NULL,
	[NgayBatDau] [date] NULL,
	[NgayKetThuc] [date] NULL,
	[MaAp] [nchar](4) NULL,
 CONSTRAINT [PK_CongViec] PRIMARY KEY CLUSTERED 
(
	[MaCV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
GRANT DELETE ON [dbo].[CongViec] TO [GIAMSAT] AS [dbo]
GO
GRANT INSERT ON [dbo].[CongViec] TO [GIAMSAT] AS [dbo]
GO
GRANT UPDATE ON [dbo].[CongViec] TO [GIAMSAT] AS [dbo]
GO
/****** Object:  Table [dbo].[Doi]    Script Date: 7/11/2023 4:16:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Doi](
	[MaDoi] [nchar](11) NOT NULL,
	[TenDoi] [nvarchar](50) NOT NULL,
	[GiamSat1] [nchar](5) NOT NULL,
	[GiamSat2] [nchar](5) NOT NULL,
	[DoiTruong] [nchar](10) NULL,
	[DoiPho] [nchar](10) NULL,
	[MaChienDich] [nchar](7) NOT NULL,
	[MaKhoa] [nchar](5) NOT NULL,
	[MaXa] [nchar](4) NOT NULL,
 CONSTRAINT [PK_Doi] PRIMARY KEY CLUSTERED 
(
	[MaDoi] DESC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GiangVien]    Script Date: 7/11/2023 4:16:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GiangVien](
	[MaGV] [nchar](5) NOT NULL,
	[Ho] [nvarchar](30) NOT NULL,
	[Ten] [nvarchar](20) NOT NULL,
	[MaKhoa] [nchar](5) NOT NULL,
 CONSTRAINT [PK_GiangVien] PRIMARY KEY CLUSTERED 
(
	[MaGV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhenThuong]    Script Date: 7/11/2023 4:16:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhenThuong](
	[MaDoi] [nchar](11) NOT NULL,
	[MaSV] [nchar](10) NOT NULL,
	[LyDo] [nvarchar](100) NOT NULL,
	[DanhHieu] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_KhenThuong_1] PRIMARY KEY CLUSTERED 
(
	[MaDoi] ASC,
	[MaSV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
GRANT DELETE ON [dbo].[KhenThuong] TO [GIAMSAT] AS [dbo]
GO
GRANT INSERT ON [dbo].[KhenThuong] TO [GIAMSAT] AS [dbo]
GO
GRANT UPDATE ON [dbo].[KhenThuong] TO [GIAMSAT] AS [dbo]
GO
/****** Object:  Table [dbo].[Khoa]    Script Date: 7/11/2023 4:16:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Khoa](
	[MaKhoa] [nchar](5) NOT NULL,
	[TenKhoa] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_KHOA] PRIMARY KEY CLUSTERED 
(
	[MaKhoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhaDan]    Script Date: 7/11/2023 4:16:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaDan](
	[MaNha] [nchar](7) NOT NULL,
	[DiaChi] [nvarchar](150) NOT NULL,
	[SDT] [char](10) NOT NULL,
	[ChuHo] [nvarchar](50) NOT NULL,
	[MaAp] [nchar](4) NULL,
 CONSTRAINT [PK_MaNha] PRIMARY KEY CLUSTERED 
(
	[MaNha] DESC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Nhom]    Script Date: 7/11/2023 4:16:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nhom](
	[MaNhom] [nchar](5) NOT NULL,
	[TenNhom] [nvarchar](50) NOT NULL,
	[NhomTruong] [nchar](10) NULL,
	[MaDoi] [nchar](11) NOT NULL,
	[MaNha] [nchar](7) NOT NULL,
 CONSTRAINT [PK_Nhom] PRIMARY KEY CLUSTERED 
(
	[MaNhom] DESC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
GRANT DELETE ON [dbo].[Nhom] TO [DOIPHO] AS [dbo]
GO
GRANT INSERT ON [dbo].[Nhom] TO [DOIPHO] AS [dbo]
GO
GRANT UPDATE ON [dbo].[Nhom] TO [DOIPHO] AS [dbo]
GO
GRANT DELETE ON [dbo].[Nhom] TO [DOITRUONG] AS [dbo]
GO
GRANT INSERT ON [dbo].[Nhom] TO [DOITRUONG] AS [dbo]
GO
GRANT UPDATE ON [dbo].[Nhom] TO [DOITRUONG] AS [dbo]
GO
/****** Object:  Table [dbo].[PhanCong]    Script Date: 7/11/2023 4:16:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhanCong](
	[MaNhom] [nchar](5) NOT NULL,
	[Buoi] [nvarchar](8) NOT NULL,
	[Ngay] [date] NOT NULL,
	[MaCV] [nchar](4) NOT NULL,
 CONSTRAINT [PK_PhanCong] PRIMARY KEY CLUSTERED 
(
	[MaNhom] ASC,
	[Buoi] ASC,
	[Ngay] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
GRANT DELETE ON [dbo].[PhanCong] TO [GIAMSAT] AS [dbo]
GO
GRANT INSERT ON [dbo].[PhanCong] TO [GIAMSAT] AS [dbo]
GO
GRANT SELECT ON [dbo].[PhanCong] TO [GIAMSAT] AS [dbo]
GO
GRANT UPDATE ON [dbo].[PhanCong] TO [GIAMSAT] AS [dbo]
GO
/****** Object:  Table [dbo].[SinhVien]    Script Date: 7/11/2023 4:16:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SinhVien](
	[MaSV] [nchar](10) NOT NULL,
	[Ho] [nvarchar](30) NOT NULL,
	[Ten] [nvarchar](20) NOT NULL,
	[MaKhoa] [nchar](5) NOT NULL,
 CONSTRAINT [PK_SinhVien] PRIMARY KEY CLUSTERED 
(
	[MaSV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ThanhVienNhom]    Script Date: 7/11/2023 4:16:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThanhVienNhom](
	[MaNhom] [nchar](5) NOT NULL,
	[MaSV] [nchar](10) NOT NULL,
 CONSTRAINT [PK_ThanhVienNhom] PRIMARY KEY CLUSTERED 
(
	[MaNhom] ASC,
	[MaSV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
GRANT DELETE ON [dbo].[ThanhVienNhom] TO [DOIPHO] AS [dbo]
GO
GRANT INSERT ON [dbo].[ThanhVienNhom] TO [DOIPHO] AS [dbo]
GO
GRANT SELECT ON [dbo].[ThanhVienNhom] TO [DOIPHO] AS [dbo]
GO
GRANT UPDATE ON [dbo].[ThanhVienNhom] TO [DOIPHO] AS [dbo]
GO
GRANT DELETE ON [dbo].[ThanhVienNhom] TO [DOITRUONG] AS [dbo]
GO
GRANT INSERT ON [dbo].[ThanhVienNhom] TO [DOITRUONG] AS [dbo]
GO
GRANT SELECT ON [dbo].[ThanhVienNhom] TO [DOITRUONG] AS [dbo]
GO
GRANT UPDATE ON [dbo].[ThanhVienNhom] TO [DOITRUONG] AS [dbo]
GO
/****** Object:  Table [dbo].[Xa]    Script Date: 7/11/2023 4:16:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Xa](
	[MaXa] [nchar](4) NOT NULL,
	[TenXa] [nvarchar](50) NOT NULL,
	[MaDiaBan] [nchar](4) NOT NULL,
 CONSTRAINT [PK_Xa] PRIMARY KEY CLUSTERED 
(
	[MaXa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Ap] ([MaAp], [TenAp], [MaXa]) VALUES (N'A001', N'Thôn Đông', N'X001')
INSERT [dbo].[Ap] ([MaAp], [TenAp], [MaXa]) VALUES (N'A002', N'Thôn Aka', N'X007')
INSERT [dbo].[Ap] ([MaAp], [TenAp], [MaXa]) VALUES (N'A003', N'Thôn Lý Nghĩa', N'X004')
INSERT [dbo].[Ap] ([MaAp], [TenAp], [MaXa]) VALUES (N'A004', N'Thôn La Tưng', N'X002')
INSERT [dbo].[Ap] ([MaAp], [TenAp], [MaXa]) VALUES (N'A005', N'Ấp Bù Gia', N'X009')
INSERT [dbo].[Ap] ([MaAp], [TenAp], [MaXa]) VALUES (N'A006', N'Ấp Chí Hòa', N'X008')
INSERT [dbo].[Ap] ([MaAp], [TenAp], [MaXa]) VALUES (N'A007', N'Ấp Bù La', N'X007')
INSERT [dbo].[Ap] ([MaAp], [TenAp], [MaXa]) VALUES (N'A008', N'Ấp Điện Ảnh', N'X006')
INSERT [dbo].[Ap] ([MaAp], [TenAp], [MaXa]) VALUES (N'A009', N'Ấp Mười Mẫu', N'X005')
INSERT [dbo].[Ap] ([MaAp], [TenAp], [MaXa]) VALUES (N'A010', N'Hoàng Nam', N'X016')
INSERT [dbo].[Ap] ([MaAp], [TenAp], [MaXa]) VALUES (N'A011', N'Thôn 5', N'X014')
INSERT [dbo].[Ap] ([MaAp], [TenAp], [MaXa]) VALUES (N'A012', N'Khu Phố 2', N'X013')
INSERT [dbo].[Ap] ([MaAp], [TenAp], [MaXa]) VALUES (N'A013', N'Khu Phố 1', N'X010')
INSERT [dbo].[Ap] ([MaAp], [TenAp], [MaXa]) VALUES (N'A014', N'Khu Phố 5', N'X002')
INSERT [dbo].[Ap] ([MaAp], [TenAp], [MaXa]) VALUES (N'A015', N'Bản Phúc Lộc', N'X001')
INSERT [dbo].[Ap] ([MaAp], [TenAp], [MaXa]) VALUES (N'A016', N'Thôn Nam', N'X003')
INSERT [dbo].[Ap] ([MaAp], [TenAp], [MaXa]) VALUES (N'A017', N'Thôn 2', N'X004')
INSERT [dbo].[Ap] ([MaAp], [TenAp], [MaXa]) VALUES (N'A018', N'Cà là', N'X022')
INSERT [dbo].[Ap] ([MaAp], [TenAp], [MaXa]) VALUES (N'A019', N'Cà Ha', N'X022')
INSERT [dbo].[Ap] ([MaAp], [TenAp], [MaXa]) VALUES (N'A021', N'Trà Đào', N'X027')
INSERT [dbo].[Ap] ([MaAp], [TenAp], [MaXa]) VALUES (N'A022', N'Trà Olong', N'X027')
INSERT [dbo].[Ap] ([MaAp], [TenAp], [MaXa]) VALUES (N'A023', N'Biển Đà', N'X026')
INSERT [dbo].[Ap] ([MaAp], [TenAp], [MaXa]) VALUES (N'A024', N'Biển Đông', N'X026')
INSERT [dbo].[Ap] ([MaAp], [TenAp], [MaXa]) VALUES (N'A025', N'Thạnh Thanh', N'X032')
INSERT [dbo].[Ap] ([MaAp], [TenAp], [MaXa]) VALUES (N'A026', N'Hòa Bình', N'X033')
INSERT [dbo].[Ap] ([MaAp], [TenAp], [MaXa]) VALUES (N'A027', N'Vàng Vang', N'X019')
INSERT [dbo].[Ap] ([MaAp], [TenAp], [MaXa]) VALUES (N'A028', N'Vàng Làn', N'X019')
INSERT [dbo].[Ap] ([MaAp], [TenAp], [MaXa]) VALUES (N'A029', N'Đỏ Cỏ', N'X020')
INSERT [dbo].[Ap] ([MaAp], [TenAp], [MaXa]) VALUES (N'A030', N'Đỏ Đen', N'X020')
INSERT [dbo].[Ap] ([MaAp], [TenAp], [MaXa]) VALUES (N'A031', N'Đen Thui', N'X021')
INSERT [dbo].[Ap] ([MaAp], [TenAp], [MaXa]) VALUES (N'A032', N'Đen đen', N'X021')
INSERT [dbo].[Ap] ([MaAp], [TenAp], [MaXa]) VALUES (N'A033', N'Nhân Mã', N'X030')
INSERT [dbo].[Ap] ([MaAp], [TenAp], [MaXa]) VALUES (N'A034', N'Nhân Sư', N'X030')
INSERT [dbo].[Ap] ([MaAp], [TenAp], [MaXa]) VALUES (N'A035', N'Quý Báu', N'X031')
INSERT [dbo].[Ap] ([MaAp], [TenAp], [MaXa]) VALUES (N'A036', N'Quý Quy', N'X031')
INSERT [dbo].[Ap] ([MaAp], [TenAp], [MaXa]) VALUES (N'A037', N'Đen Vâu', N'X017')
INSERT [dbo].[Ap] ([MaAp], [TenAp], [MaXa]) VALUES (N'A038', N'Vàng Kim', N'X018')
INSERT [dbo].[Ap] ([MaAp], [TenAp], [MaXa]) VALUES (N'A039', N'Tài Tể', N'X024')
INSERT [dbo].[Ap] ([MaAp], [TenAp], [MaXa]) VALUES (N'A040', N'Tài Tốc', N'X024')
INSERT [dbo].[Ap] ([MaAp], [TenAp], [MaXa]) VALUES (N'A041', N'Phước Lộc', N'X025')
INSERT [dbo].[Ap] ([MaAp], [TenAp], [MaXa]) VALUES (N'A042', N'Phước Hậu', N'X025')
INSERT [dbo].[Ap] ([MaAp], [TenAp], [MaXa]) VALUES (N'A043', N'Hải Âu', N'X006')
INSERT [dbo].[Ap] ([MaAp], [TenAp], [MaXa]) VALUES (N'A044', N'Nhơn Lý', N'X011')
INSERT [dbo].[Ap] ([MaAp], [TenAp], [MaXa]) VALUES (N'A045', N'Nhơn Hòa', N'X011')
INSERT [dbo].[Ap] ([MaAp], [TenAp], [MaXa]) VALUES (N'A046', N'Cần Kim', N'X028')
INSERT [dbo].[Ap] ([MaAp], [TenAp], [MaXa]) VALUES (N'A047', N'Cần Hát', N'X028')
INSERT [dbo].[Ap] ([MaAp], [TenAp], [MaXa]) VALUES (N'A048', N'Búa Tạ', N'X029')
INSERT [dbo].[Ap] ([MaAp], [TenAp], [MaXa]) VALUES (N'A049', N'Búa Bủa', N'X029')
INSERT [dbo].[Ap] ([MaAp], [TenAp], [MaXa]) VALUES (N'A050', N'Sao Sáo', N'X012')
INSERT [dbo].[Ap] ([MaAp], [TenAp], [MaXa]) VALUES (N'A051', N'Sơn Đoàng', N'X015')
INSERT [dbo].[Ap] ([MaAp], [TenAp], [MaXa]) VALUES (N'A052', N'Đen Mực', N'X023')
GO
INSERT [dbo].[ChienDich] ([MaChienDich], [TenChienDich], [NgayPhatDong], [NgayKetThuc]) VALUES (N'CD01   ', N'Mùa hè xanh', CAST(N'2023-06-01' AS Date), CAST(N'2023-08-07' AS Date))
INSERT [dbo].[ChienDich] ([MaChienDich], [TenChienDich], [NgayPhatDong], [NgayKetThuc]) VALUES (N'CD02   ', N'ABCdef', CAST(N'2021-06-07' AS Date), CAST(N'2021-08-07' AS Date))
INSERT [dbo].[ChienDich] ([MaChienDich], [TenChienDich], [NgayPhatDong], [NgayKetThuc]) VALUES (N'CD03   ', N'abc', CAST(N'2022-06-27' AS Date), CAST(N'2022-08-07' AS Date))
GO
INSERT [dbo].[ChiTietChienDich] ([MaChienDich], [MaDiaBan]) VALUES (N'CD01   ', N'DB01')
INSERT [dbo].[ChiTietChienDich] ([MaChienDich], [MaDiaBan]) VALUES (N'CD01   ', N'DB02')
INSERT [dbo].[ChiTietChienDich] ([MaChienDich], [MaDiaBan]) VALUES (N'CD01   ', N'DB05')
INSERT [dbo].[ChiTietChienDich] ([MaChienDich], [MaDiaBan]) VALUES (N'CD02   ', N'DB03')
INSERT [dbo].[ChiTietChienDich] ([MaChienDich], [MaDiaBan]) VALUES (N'CD02   ', N'DB09')
INSERT [dbo].[ChiTietChienDich] ([MaChienDich], [MaDiaBan]) VALUES (N'CD02   ', N'DB10')
INSERT [dbo].[ChiTietChienDich] ([MaChienDich], [MaDiaBan]) VALUES (N'CD02   ', N'DB12')
INSERT [dbo].[ChiTietChienDich] ([MaChienDich], [MaDiaBan]) VALUES (N'CD03   ', N'DB03')
INSERT [dbo].[ChiTietChienDich] ([MaChienDich], [MaDiaBan]) VALUES (N'CD03   ', N'DB06')
INSERT [dbo].[ChiTietChienDich] ([MaChienDich], [MaDiaBan]) VALUES (N'CD03   ', N'DB09')
INSERT [dbo].[ChiTietChienDich] ([MaChienDich], [MaDiaBan]) VALUES (N'CD03   ', N'DB10')
INSERT [dbo].[ChiTietChienDich] ([MaChienDich], [MaDiaBan]) VALUES (N'CD03   ', N'DB14')
GO
INSERT [dbo].[CongViec] ([MaCV], [TenCV], [NgayBatDau], [NgayKetThuc], [MaAp]) VALUES (N'CV01', N'Làm nhà', CAST(N'2023-05-01' AS Date), CAST(N'2023-07-01' AS Date), N'A001')
INSERT [dbo].[CongViec] ([MaCV], [TenCV], [NgayBatDau], [NgayKetThuc], [MaAp]) VALUES (N'CV02', N'Đắp ', CAST(N'2023-05-01' AS Date), CAST(N'2023-07-23' AS Date), N'A015')
INSERT [dbo].[CongViec] ([MaCV], [TenCV], [NgayBatDau], [NgayKetThuc], [MaAp]) VALUES (N'CV03', N'Xây cầu', CAST(N'2023-05-01' AS Date), CAST(N'2023-07-01' AS Date), N'A001')
INSERT [dbo].[CongViec] ([MaCV], [TenCV], [NgayBatDau], [NgayKetThuc], [MaAp]) VALUES (N'CV04', N'đập đá', CAST(N'2023-07-22' AS Date), CAST(N'2023-07-22' AS Date), N'A010')
INSERT [dbo].[CongViec] ([MaCV], [TenCV], [NgayBatDau], [NgayKetThuc], [MaAp]) VALUES (N'CV05', N'Đòi nợ thuê', CAST(N'2023-07-10' AS Date), CAST(N'2023-07-25' AS Date), N'A001')
INSERT [dbo].[CongViec] ([MaCV], [TenCV], [NgayBatDau], [NgayKetThuc], [MaAp]) VALUES (N'CV06', N'xiết nợ', CAST(N'2023-07-10' AS Date), CAST(N'2023-07-24' AS Date), N'A015')
GO
INSERT [dbo].[DiaBan] ([MaDiaBan], [TenDiaBan]) VALUES (N'DB10', N'Bà Điểm')
INSERT [dbo].[DiaBan] ([MaDiaBan], [TenDiaBan]) VALUES (N'DB12', N'Ba Sao')
INSERT [dbo].[DiaBan] ([MaDiaBan], [TenDiaBan]) VALUES (N'DB15', N'Cà Lúi')
INSERT [dbo].[DiaBan] ([MaDiaBan], [TenDiaBan]) VALUES (N'DB09', N'Đa Lộc')
INSERT [dbo].[DiaBan] ([MaDiaBan], [TenDiaBan]) VALUES (N'DB08', N'Đảo Phú Quý')
INSERT [dbo].[DiaBan] ([MaDiaBan], [TenDiaBan]) VALUES (N'DB01', N'Dĩ An')
INSERT [dbo].[DiaBan] ([MaDiaBan], [TenDiaBan]) VALUES (N'DB03', N'Đồng Tháp')
INSERT [dbo].[DiaBan] ([MaDiaBan], [TenDiaBan]) VALUES (N'DB14', N'Hương Sơn')
INSERT [dbo].[DiaBan] ([MaDiaBan], [TenDiaBan]) VALUES (N'DB06', N'huyện Cần Giờ')
INSERT [dbo].[DiaBan] ([MaDiaBan], [TenDiaBan]) VALUES (N'DB04', N'huyện Hóc Môn')
INSERT [dbo].[DiaBan] ([MaDiaBan], [TenDiaBan]) VALUES (N'DB11', N'Lý Nhơn')
INSERT [dbo].[DiaBan] ([MaDiaBan], [TenDiaBan]) VALUES (N'DB13', N'Mỹ Tân')
INSERT [dbo].[DiaBan] ([MaDiaBan], [TenDiaBan]) VALUES (N'DB02', N'Nam Đông')
INSERT [dbo].[DiaBan] ([MaDiaBan], [TenDiaBan]) VALUES (N'DB07', N'Phú Yên')
INSERT [dbo].[DiaBan] ([MaDiaBan], [TenDiaBan]) VALUES (N'DB16', N'quận 9')
INSERT [dbo].[DiaBan] ([MaDiaBan], [TenDiaBan]) VALUES (N'DB05', N'TP Thủ Đức')
GO
INSERT [dbo].[Doi] ([MaDoi], [TenDoi], [GiamSat1], [GiamSat2], [DoiTruong], [DoiPho], [MaChienDich], [MaKhoa], [MaXa]) VALUES (N'D20230004  ', N'đen', N'GV07 ', N'GV08 ', N'N20DCVT005', N'N20DCVT031', N'CD01   ', N'VT2  ', N'X002')
INSERT [dbo].[Doi] ([MaDoi], [TenDoi], [GiamSat1], [GiamSat2], [DoiTruong], [DoiPho], [MaChienDich], [MaKhoa], [MaXa]) VALUES (N'D20230003  ', N'ngọc trai', N'GV06 ', N'GV03 ', N'N20DCCN052', N'N20DCCN049', N'CD01   ', N'CNTT2', N'X005')
INSERT [dbo].[Doi] ([MaDoi], [TenDoi], [GiamSat1], [GiamSat2], [DoiTruong], [DoiPho], [MaChienDich], [MaKhoa], [MaXa]) VALUES (N'D20230001  ', N'Bóng đêm', N'GV01 ', N'GV02 ', N'N20DCCN079', N'N19DCCN007', N'CD01   ', N'CNTT2', N'X001')
GO
INSERT [dbo].[GiangVien] ([MaGV], [Ho], [Ten], [MaKhoa]) VALUES (N'GV01 ', N'Nguyễn Thị Tuyết', N'Hải', N'CNTT2')
INSERT [dbo].[GiangVien] ([MaGV], [Ho], [Ten], [MaKhoa]) VALUES (N'GV02 ', N'Nguyễn Thị', N'Lan', N'CNTT2')
INSERT [dbo].[GiangVien] ([MaGV], [Ho], [Ten], [MaKhoa]) VALUES (N'GV03 ', N'Trần', N'An', N'CNTT2')
INSERT [dbo].[GiangVien] ([MaGV], [Ho], [Ten], [MaKhoa]) VALUES (N'GV04 ', N'Lâm Văn', N'Cơ', N'CNTT2')
INSERT [dbo].[GiangVien] ([MaGV], [Ho], [Ten], [MaKhoa]) VALUES (N'GV05 ', N'Lưu Ngọc ', N'Ân', N'CNTT2')
INSERT [dbo].[GiangVien] ([MaGV], [Ho], [Ten], [MaKhoa]) VALUES (N'GV06 ', N'Nguyễn Hoài', N'An', N'CNTT2')
INSERT [dbo].[GiangVien] ([MaGV], [Ho], [Ten], [MaKhoa]) VALUES (N'GV07 ', N'Lưu Hoàng', N'Thiên', N'VT2  ')
INSERT [dbo].[GiangVien] ([MaGV], [Ho], [Ten], [MaKhoa]) VALUES (N'GV08 ', N'Trần Văn', N'Kha', N'VT2  ')
INSERT [dbo].[GiangVien] ([MaGV], [Ho], [Ten], [MaKhoa]) VALUES (N'GV09 ', N'Nguyễn ', N'ADMIN', N'CNTT2')
INSERT [dbo].[GiangVien] ([MaGV], [Ho], [Ten], [MaKhoa]) VALUES (N'GV10 ', N'Nguyễn ', N'KHOA', N'CNTT2')
GO
INSERT [dbo].[KhenThuong] ([MaDoi], [MaSV], [LyDo], [DanhHieu]) VALUES (N'D20230001  ', N'N19DCAT063', N'abc', N'Hăng hài trong công việc')
INSERT [dbo].[KhenThuong] ([MaDoi], [MaSV], [LyDo], [DanhHieu]) VALUES (N'D20230001  ', N'N19DCCN020', N'ACX', N'Năng động sáng tạo')
INSERT [dbo].[KhenThuong] ([MaDoi], [MaSV], [LyDo], [DanhHieu]) VALUES (N'D20230001  ', N'N20DCCN016', N'Luôn có mặt', N'Lao động tích cực')
INSERT [dbo].[KhenThuong] ([MaDoi], [MaSV], [LyDo], [DanhHieu]) VALUES (N'D20230001  ', N'N20DCCN060', N'quá sáng tạo', N'Năng động sáng tạo')
INSERT [dbo].[KhenThuong] ([MaDoi], [MaSV], [LyDo], [DanhHieu]) VALUES (N'D20230001  ', N'N20DCCN079', N'ABC', N'Lao động tích cực')
GO
INSERT [dbo].[Khoa] ([MaKhoa], [TenKhoa]) VALUES (N'CNTT2', N'Khoa công nghệ thông tin 2')
INSERT [dbo].[Khoa] ([MaKhoa], [TenKhoa]) VALUES (N'KTDT2', N'Khoa kỹ thuật điện tử 2')
INSERT [dbo].[Khoa] ([MaKhoa], [TenKhoa]) VALUES (N'QTKD2', N'Khoa quản trị kinh doanh 2')
INSERT [dbo].[Khoa] ([MaKhoa], [TenKhoa]) VALUES (N'VT2  ', N'Khoa viễn thông 2')
GO
INSERT [dbo].[NhaDan] ([MaNha], [DiaChi], [SDT], [ChuHo], [MaAp]) VALUES (N'Nha0047', N'47 Man Thiện', N'1234567890', N'Ông', N'A051')
INSERT [dbo].[NhaDan] ([MaNha], [DiaChi], [SDT], [ChuHo], [MaAp]) VALUES (N'Nha0046', N'46 Man Thiện', N'1234567890', N'Ông', N'A051')
INSERT [dbo].[NhaDan] ([MaNha], [DiaChi], [SDT], [ChuHo], [MaAp]) VALUES (N'Nha0045', N'45 Man Thiện', N'1234567890', N'Ông', N'A011')
INSERT [dbo].[NhaDan] ([MaNha], [DiaChi], [SDT], [ChuHo], [MaAp]) VALUES (N'Nha0044', N'44 Man Thiện', N'1234567890', N'Ông', N'A011')
INSERT [dbo].[NhaDan] ([MaNha], [DiaChi], [SDT], [ChuHo], [MaAp]) VALUES (N'Nha0043', N'43 Man Thiện', N'1234567890', N'Ông', N'A015')
INSERT [dbo].[NhaDan] ([MaNha], [DiaChi], [SDT], [ChuHo], [MaAp]) VALUES (N'Nha0042', N'42 Man Thiện', N'1234567890', N'Ông', N'A015')
INSERT [dbo].[NhaDan] ([MaNha], [DiaChi], [SDT], [ChuHo], [MaAp]) VALUES (N'Nha0041', N'41 Man Thiện', N'1234567890', N'Ông', N'A009')
INSERT [dbo].[NhaDan] ([MaNha], [DiaChi], [SDT], [ChuHo], [MaAp]) VALUES (N'Nha0040', N'40 Man Thiện', N'1234567890', N'Ông', N'A009')
INSERT [dbo].[NhaDan] ([MaNha], [DiaChi], [SDT], [ChuHo], [MaAp]) VALUES (N'Nha0039', N'39 Man Thiện', N'1234567890', N'Ông', N'A017')
INSERT [dbo].[NhaDan] ([MaNha], [DiaChi], [SDT], [ChuHo], [MaAp]) VALUES (N'Nha0038', N'38 Man Thiện', N'1234567890', N'Ông', N'A017')
INSERT [dbo].[NhaDan] ([MaNha], [DiaChi], [SDT], [ChuHo], [MaAp]) VALUES (N'Nha0037', N'37 Man Thiện', N'1234567890', N'Ông', N'A003')
INSERT [dbo].[NhaDan] ([MaNha], [DiaChi], [SDT], [ChuHo], [MaAp]) VALUES (N'Nha0036', N'36 Man Thiện', N'1234567890', N'Ông', N'A003')
INSERT [dbo].[NhaDan] ([MaNha], [DiaChi], [SDT], [ChuHo], [MaAp]) VALUES (N'Nha0035', N'35 Man Thiện', N'1234567890', N'Ông', N'A016')
INSERT [dbo].[NhaDan] ([MaNha], [DiaChi], [SDT], [ChuHo], [MaAp]) VALUES (N'Nha0034', N'34 Man Thiện', N'1234567890', N'Ông', N'A016')
INSERT [dbo].[NhaDan] ([MaNha], [DiaChi], [SDT], [ChuHo], [MaAp]) VALUES (N'Nha0033', N'33 Man Thiện', N'1234567890', N'Ông', N'A014')
INSERT [dbo].[NhaDan] ([MaNha], [DiaChi], [SDT], [ChuHo], [MaAp]) VALUES (N'Nha0032', N'32 Man Thiện', N'1234567890', N'Ông', N'A014')
INSERT [dbo].[NhaDan] ([MaNha], [DiaChi], [SDT], [ChuHo], [MaAp]) VALUES (N'Nha0031', N'31 Man Thiện', N'1234567890', N'Ông', N'A004')
INSERT [dbo].[NhaDan] ([MaNha], [DiaChi], [SDT], [ChuHo], [MaAp]) VALUES (N'Nha0030', N'30 Man Thiện', N'1234567890', N'Ông', N'A004')
INSERT [dbo].[NhaDan] ([MaNha], [DiaChi], [SDT], [ChuHo], [MaAp]) VALUES (N'Nha0029', N'22 Man Thiện', N'1234567890', N'Ông', N'A032')
INSERT [dbo].[NhaDan] ([MaNha], [DiaChi], [SDT], [ChuHo], [MaAp]) VALUES (N'Nha0028', N'21 Man Thiện', N'1234567890', N'Ông', N'A032')
INSERT [dbo].[NhaDan] ([MaNha], [DiaChi], [SDT], [ChuHo], [MaAp]) VALUES (N'Nha0027', N'20 Man Thiện', N'1234567890', N'Ông', N'A031')
INSERT [dbo].[NhaDan] ([MaNha], [DiaChi], [SDT], [ChuHo], [MaAp]) VALUES (N'Nha0026', N'19 Man Thiện', N'1234567890', N'Ông', N'A031')
INSERT [dbo].[NhaDan] ([MaNha], [DiaChi], [SDT], [ChuHo], [MaAp]) VALUES (N'Nha0025', N'18 Man Thiện', N'1234567890', N'Ông', N'A030')
INSERT [dbo].[NhaDan] ([MaNha], [DiaChi], [SDT], [ChuHo], [MaAp]) VALUES (N'Nha0024', N'17 Man Thiện', N'1234567890', N'Ông', N'A030')
INSERT [dbo].[NhaDan] ([MaNha], [DiaChi], [SDT], [ChuHo], [MaAp]) VALUES (N'Nha0023', N'16 Man Thiện', N'1234567890', N'Ông', N'A029')
INSERT [dbo].[NhaDan] ([MaNha], [DiaChi], [SDT], [ChuHo], [MaAp]) VALUES (N'Nha0022', N'15 Man Thiện', N'1234567890', N'Ông', N'A029')
INSERT [dbo].[NhaDan] ([MaNha], [DiaChi], [SDT], [ChuHo], [MaAp]) VALUES (N'Nha0021', N'14 Man Thiện', N'1234567890', N'Ông', N'A028')
INSERT [dbo].[NhaDan] ([MaNha], [DiaChi], [SDT], [ChuHo], [MaAp]) VALUES (N'Nha0020', N'13 Man Thiện', N'1234567890', N'Ông', N'A028')
INSERT [dbo].[NhaDan] ([MaNha], [DiaChi], [SDT], [ChuHo], [MaAp]) VALUES (N'Nha0019', N'12 Man Thiện', N'1234567890', N'Ông', N'A027')
INSERT [dbo].[NhaDan] ([MaNha], [DiaChi], [SDT], [ChuHo], [MaAp]) VALUES (N'Nha0018', N'11 Man Thiện', N'1234567890', N'Ông', N'A027')
INSERT [dbo].[NhaDan] ([MaNha], [DiaChi], [SDT], [ChuHo], [MaAp]) VALUES (N'Nha0017', N'10 Man Thiện', N'1234567890', N'Ông', N'A027')
INSERT [dbo].[NhaDan] ([MaNha], [DiaChi], [SDT], [ChuHo], [MaAp]) VALUES (N'Nha0016', N'9 Man Thiện', N'1234567890', N'Ông c', N'A038')
INSERT [dbo].[NhaDan] ([MaNha], [DiaChi], [SDT], [ChuHo], [MaAp]) VALUES (N'Nha0015', N'8 Man Thiện', N'1234567890', N'Ông n', N'A038')
INSERT [dbo].[NhaDan] ([MaNha], [DiaChi], [SDT], [ChuHo], [MaAp]) VALUES (N'Nha0014', N'7 Man Thiện', N'1234567890', N'Ông c', N'A038')
INSERT [dbo].[NhaDan] ([MaNha], [DiaChi], [SDT], [ChuHo], [MaAp]) VALUES (N'Nha0013', N'6 Man Thiện', N'1234567890', N'Ông', N'A037')
INSERT [dbo].[NhaDan] ([MaNha], [DiaChi], [SDT], [ChuHo], [MaAp]) VALUES (N'Nha0012', N'5 man thiện ', N'1231231235', N'chu c', N'A010')
INSERT [dbo].[NhaDan] ([MaNha], [DiaChi], [SDT], [ChuHo], [MaAp]) VALUES (N'Nha0011', N'4 man thiện', N'1231231234', N'chu b', N'A010')
INSERT [dbo].[NhaDan] ([MaNha], [DiaChi], [SDT], [ChuHo], [MaAp]) VALUES (N'Nha0010', N'2 man thien', N'1212121211', N'ong b', N'A037')
INSERT [dbo].[NhaDan] ([MaNha], [DiaChi], [SDT], [ChuHo], [MaAp]) VALUES (N'Nha0009', N'3 man thiện', N'1231231233', N'ong B ', N'A010')
INSERT [dbo].[NhaDan] ([MaNha], [DiaChi], [SDT], [ChuHo], [MaAp]) VALUES (N'Nha0008', N'97 man thiện', N'0123456789', N'Bà sáu', N'A017')
INSERT [dbo].[NhaDan] ([MaNha], [DiaChi], [SDT], [ChuHo], [MaAp]) VALUES (N'Nha0007', N'21 Đường 19, huyện Hóc Môn, TP HCM', N'0394264191', N'Ông Sáu', N'A001')
INSERT [dbo].[NhaDan] ([MaNha], [DiaChi], [SDT], [ChuHo], [MaAp]) VALUES (N'Nha0006', N'199 Khu Phố 5, Tăng Nhơn Phú A, TP Thủ Đức', N'0374112126', N'Bác Khánh', N'A001')
INSERT [dbo].[NhaDan] ([MaNha], [DiaChi], [SDT], [ChuHo], [MaAp]) VALUES (N'Nha0005', N'Ấp Bù Gia, Ba Sao, Đồng Tháp', N'0392539376', N'Anh Trọng', N'A001')
INSERT [dbo].[NhaDan] ([MaNha], [DiaChi], [SDT], [ChuHo], [MaAp]) VALUES (N'Nha0004', N'Bản Phúc Lộc, Nam Đông, Thừa Thiên Huế', N'0394264153', N'Cô Trinh', N'A001')
INSERT [dbo].[NhaDan] ([MaNha], [DiaChi], [SDT], [ChuHo], [MaAp]) VALUES (N'Nha0003', N'Thôn Nam, Hương Sơn, Thừa Thiên Huế', N'0374114626', N'Chị Duyên', N'A001')
INSERT [dbo].[NhaDan] ([MaNha], [DiaChi], [SDT], [ChuHo], [MaAp]) VALUES (N'Nha0002', N'Thôn 2, Đa Lộc, Phú Yên', N'0962523930', N'Cô Hằng', N'A001')
INSERT [dbo].[NhaDan] ([MaNha], [DiaChi], [SDT], [ChuHo], [MaAp]) VALUES (N'Nha0001', N'27 Nguyễn Thị Thập, Khu Phố 2, Dĩ An', N'0366539600', N'Chú Tư', N'A001')
GO
INSERT [dbo].[Nhom] ([MaNhom], [TenNhom], [NhomTruong], [MaDoi], [MaNha]) VALUES (N'N0009', N'Đen Vâu', NULL, N'D20230004  ', N'Nha0021')
INSERT [dbo].[Nhom] ([MaNhom], [TenNhom], [NhomTruong], [MaDoi], [MaNha]) VALUES (N'N0008', N'ngọc gái', N'N18DCCN011', N'D20230003  ', N'Nha0022')
INSERT [dbo].[Nhom] ([MaNhom], [TenNhom], [NhomTruong], [MaDoi], [MaNha]) VALUES (N'N0007', N'temp', NULL, N'D20230004  ', N'Nha0033')
INSERT [dbo].[Nhom] ([MaNhom], [TenNhom], [NhomTruong], [MaDoi], [MaNha]) VALUES (N'N0006', N'temp', N'N19DCCN128', N'D20230003  ', N'Nha0041')
INSERT [dbo].[Nhom] ([MaNhom], [TenNhom], [NhomTruong], [MaDoi], [MaNha]) VALUES (N'N0004', N'kien cuong', N'N19DCAT034', N'D20230001  ', N'Nha0001')
INSERT [dbo].[Nhom] ([MaNhom], [TenNhom], [NhomTruong], [MaDoi], [MaNha]) VALUES (N'N0003', N'haisa', N'N19DCAT048', N'D20230001  ', N'Nha0002')
INSERT [dbo].[Nhom] ([MaNhom], [TenNhom], [NhomTruong], [MaDoi], [MaNha]) VALUES (N'N0002', N'tự do', N'N19DCAT063', N'D20230001  ', N'Nha0003')
INSERT [dbo].[Nhom] ([MaNhom], [TenNhom], [NhomTruong], [MaDoi], [MaNha]) VALUES (N'N0001', N'temp', N'N20DCCN016', N'D20230001  ', N'Nha0004')
GO
INSERT [dbo].[PhanCong] ([MaNhom], [Buoi], [Ngay], [MaCV]) VALUES (N'N0001', N'Chiều', CAST(N'2023-05-23' AS Date), N'CV01')
INSERT [dbo].[PhanCong] ([MaNhom], [Buoi], [Ngay], [MaCV]) VALUES (N'N0001', N'Chiều ', CAST(N'2023-05-24' AS Date), N'CV01')
INSERT [dbo].[PhanCong] ([MaNhom], [Buoi], [Ngay], [MaCV]) VALUES (N'N0001', N'Chiều ', CAST(N'2023-05-30' AS Date), N'CV01')
INSERT [dbo].[PhanCong] ([MaNhom], [Buoi], [Ngay], [MaCV]) VALUES (N'N0001', N'Chiều ', CAST(N'2023-07-11' AS Date), N'CV05')
INSERT [dbo].[PhanCong] ([MaNhom], [Buoi], [Ngay], [MaCV]) VALUES (N'N0001', N'Sáng ', CAST(N'2023-06-13' AS Date), N'CV01')
INSERT [dbo].[PhanCong] ([MaNhom], [Buoi], [Ngay], [MaCV]) VALUES (N'N0001', N'Sáng ', CAST(N'2023-07-11' AS Date), N'CV05')
INSERT [dbo].[PhanCong] ([MaNhom], [Buoi], [Ngay], [MaCV]) VALUES (N'N0001', N'Sáng ', CAST(N'2023-07-12' AS Date), N'CV05')
INSERT [dbo].[PhanCong] ([MaNhom], [Buoi], [Ngay], [MaCV]) VALUES (N'N0001', N'Tối', CAST(N'2023-05-23' AS Date), N'CV01')
INSERT [dbo].[PhanCong] ([MaNhom], [Buoi], [Ngay], [MaCV]) VALUES (N'N0001', N'Tối', CAST(N'2023-06-13' AS Date), N'CV01')
INSERT [dbo].[PhanCong] ([MaNhom], [Buoi], [Ngay], [MaCV]) VALUES (N'N0001', N'Tối', CAST(N'2023-06-14' AS Date), N'CV01')
INSERT [dbo].[PhanCong] ([MaNhom], [Buoi], [Ngay], [MaCV]) VALUES (N'N0001', N'Tối', CAST(N'2023-07-11' AS Date), N'CV05')
INSERT [dbo].[PhanCong] ([MaNhom], [Buoi], [Ngay], [MaCV]) VALUES (N'N0002', N'Chiều', CAST(N'2023-05-23' AS Date), N'CV02')
INSERT [dbo].[PhanCong] ([MaNhom], [Buoi], [Ngay], [MaCV]) VALUES (N'N0002', N'Chiều', CAST(N'2023-06-13' AS Date), N'CV01')
INSERT [dbo].[PhanCong] ([MaNhom], [Buoi], [Ngay], [MaCV]) VALUES (N'N0002', N'Sáng ', CAST(N'2023-06-13' AS Date), N'CV01')
INSERT [dbo].[PhanCong] ([MaNhom], [Buoi], [Ngay], [MaCV]) VALUES (N'N0002', N'Sáng ', CAST(N'2023-07-12' AS Date), N'CV05')
INSERT [dbo].[PhanCong] ([MaNhom], [Buoi], [Ngay], [MaCV]) VALUES (N'N0002', N'Tối', CAST(N'2023-06-13' AS Date), N'CV01')
INSERT [dbo].[PhanCong] ([MaNhom], [Buoi], [Ngay], [MaCV]) VALUES (N'N0003', N'Sáng ', CAST(N'2023-06-17' AS Date), N'CV03')
INSERT [dbo].[PhanCong] ([MaNhom], [Buoi], [Ngay], [MaCV]) VALUES (N'N0003', N'Sáng ', CAST(N'2023-07-12' AS Date), N'CV05')
INSERT [dbo].[PhanCong] ([MaNhom], [Buoi], [Ngay], [MaCV]) VALUES (N'N0004', N'Chiều ', CAST(N'2023-07-09' AS Date), N'CV02')
INSERT [dbo].[PhanCong] ([MaNhom], [Buoi], [Ngay], [MaCV]) VALUES (N'N0004', N'Sáng ', CAST(N'2023-06-07' AS Date), N'CV02')
INSERT [dbo].[PhanCong] ([MaNhom], [Buoi], [Ngay], [MaCV]) VALUES (N'N0004', N'Sáng ', CAST(N'2023-07-11' AS Date), N'CV02')
GO
INSERT [dbo].[SinhVien] ([MaSV], [Ho], [Ten], [MaKhoa]) VALUES (N'N15DCKT063', N'Hoàng Thị Ngọc Yến', N'Minh', N'QTKD2')
INSERT [dbo].[SinhVien] ([MaSV], [Ho], [Ten], [MaKhoa]) VALUES (N'N17DCPT069', N'Trần Hiếu', N'Trung', N'CNTT2')
INSERT [dbo].[SinhVien] ([MaSV], [Ho], [Ten], [MaKhoa]) VALUES (N'N18DCCN009', N'Trần Nhật', N'Anh', N'CNTT2')
INSERT [dbo].[SinhVien] ([MaSV], [Ho], [Ten], [MaKhoa]) VALUES (N'N18DCCN011', N'Dương Quốc', N'Bảo', N'CNTT2')
INSERT [dbo].[SinhVien] ([MaSV], [Ho], [Ten], [MaKhoa]) VALUES (N'N19DCAT034', N'Phạm Ngọc', N'Hoạt', N'CNTT2')
INSERT [dbo].[SinhVien] ([MaSV], [Ho], [Ten], [MaKhoa]) VALUES (N'N19DCAT048', N'Nguyễn Công', N'Lực', N'CNTT2')
INSERT [dbo].[SinhVien] ([MaSV], [Ho], [Ten], [MaKhoa]) VALUES (N'N19DCAT063', N'Phạm Minh', N'Quang', N'CNTT2')
INSERT [dbo].[SinhVien] ([MaSV], [Ho], [Ten], [MaKhoa]) VALUES (N'N19DCCN007', N'Nguyễn Quốc', N'Anh', N'CNTT2')
INSERT [dbo].[SinhVien] ([MaSV], [Ho], [Ten], [MaKhoa]) VALUES (N'N19DCCN008', N'Nguyễn Trần Đức', N'Anh', N'CNTT2')
INSERT [dbo].[SinhVien] ([MaSV], [Ho], [Ten], [MaKhoa]) VALUES (N'N19DCCN020', N'Mai Hoàng Thanh', N'Bình', N'CNTT2')
INSERT [dbo].[SinhVien] ([MaSV], [Ho], [Ten], [MaKhoa]) VALUES (N'N19DCCN024', N'Nguyễn Bảo', N'Chính', N'CNTT2')
INSERT [dbo].[SinhVien] ([MaSV], [Ho], [Ten], [MaKhoa]) VALUES (N'N19DCCN044', N'Lê Vạn', N'Giang', N'CNTT2')
INSERT [dbo].[SinhVien] ([MaSV], [Ho], [Ten], [MaKhoa]) VALUES (N'N19DCCN092', N'Trần Thanh', N'Khiêm', N'CNTT2')
INSERT [dbo].[SinhVien] ([MaSV], [Ho], [Ten], [MaKhoa]) VALUES (N'N19DCCN105', N'Chu Văn', N'Mạnh', N'CNTT2')
INSERT [dbo].[SinhVien] ([MaSV], [Ho], [Ten], [MaKhoa]) VALUES (N'N19DCCN109', N'Đinh Bảo', N'Minh', N'CNTT2')
INSERT [dbo].[SinhVien] ([MaSV], [Ho], [Ten], [MaKhoa]) VALUES (N'N19DCCN110', N'Nguyễn Nhật', N'Minh', N'CNTT2')
INSERT [dbo].[SinhVien] ([MaSV], [Ho], [Ten], [MaKhoa]) VALUES (N'N19DCCN128', N'Lê Bá Minh', N'Nhật', N'CNTT2')
INSERT [dbo].[SinhVien] ([MaSV], [Ho], [Ten], [MaKhoa]) VALUES (N'N19DCCN176', N'Giang Mạnh', N'Tuấn', N'CNTT2')
INSERT [dbo].[SinhVien] ([MaSV], [Ho], [Ten], [MaKhoa]) VALUES (N'N19DCCN179', N'Nguyễn Quốc', N'Tuấn', N'CNTT2')
INSERT [dbo].[SinhVien] ([MaSV], [Ho], [Ten], [MaKhoa]) VALUES (N'N19DCCN180', N'Nguyễn Văn', N'Tuấn', N'CNTT2')
INSERT [dbo].[SinhVien] ([MaSV], [Ho], [Ten], [MaKhoa]) VALUES (N'N19DCCN195', N'Lê Quốc', N'Thiên', N'CNTT2')
INSERT [dbo].[SinhVien] ([MaSV], [Ho], [Ten], [MaKhoa]) VALUES (N'N19DCCN205', N'Trần Ngọc', N'Thuận', N'CNTT2')
INSERT [dbo].[SinhVien] ([MaSV], [Ho], [Ten], [MaKhoa]) VALUES (N'N19DCCN212', N'Phan Thanh', N'Trụ', N'CNTT2')
INSERT [dbo].[SinhVien] ([MaSV], [Ho], [Ten], [MaKhoa]) VALUES (N'N19DCPT031', N'Triệu Thị Yến', N'Khoa', N'CNTT2')
INSERT [dbo].[SinhVien] ([MaSV], [Ho], [Ten], [MaKhoa]) VALUES (N'N19DCQT063', N'Huỳnh Thị Cẩm', N'Tiên', N'QTKD2')
INSERT [dbo].[SinhVien] ([MaSV], [Ho], [Ten], [MaKhoa]) VALUES (N'N20DCAT016', N'Đỗ Diệu', N'Hiền', N'CNTT2')
INSERT [dbo].[SinhVien] ([MaSV], [Ho], [Ten], [MaKhoa]) VALUES (N'N20DCCN002', N'Bùi Tuấn', N'Anh', N'CNTT2')
INSERT [dbo].[SinhVien] ([MaSV], [Ho], [Ten], [MaKhoa]) VALUES (N'N20DCCN004', N'Đoàn Long', N'Âu', N'CNTT2')
INSERT [dbo].[SinhVien] ([MaSV], [Ho], [Ten], [MaKhoa]) VALUES (N'N20DCCN005', N'Phạm Gia', N'Bảo', N'CNTT2')
INSERT [dbo].[SinhVien] ([MaSV], [Ho], [Ten], [MaKhoa]) VALUES (N'N20DCCN006', N'Phạm Ngọc', N'Bảo', N'CNTT2')
INSERT [dbo].[SinhVien] ([MaSV], [Ho], [Ten], [MaKhoa]) VALUES (N'N20DCCN007', N'Phạm Khánh', N'Băng', N'CNTT2')
INSERT [dbo].[SinhVien] ([MaSV], [Ho], [Ten], [MaKhoa]) VALUES (N'N20DCCN008', N'Trần Hữu', N'Chiến', N'CNTT2')
INSERT [dbo].[SinhVien] ([MaSV], [Ho], [Ten], [MaKhoa]) VALUES (N'N20DCCN010', N'Châu Huy', N'Diễn', N'CNTT2')
INSERT [dbo].[SinhVien] ([MaSV], [Ho], [Ten], [MaKhoa]) VALUES (N'N20DCCN011', N'Trần Văn', N'Du', N'CNTT2')
INSERT [dbo].[SinhVien] ([MaSV], [Ho], [Ten], [MaKhoa]) VALUES (N'N20DCCN012', N'Nguyễn Hữu', N'Dũng', N'CNTT2')
INSERT [dbo].[SinhVien] ([MaSV], [Ho], [Ten], [MaKhoa]) VALUES (N'N20DCCN013', N'Nguyễn Quốc', N'Duy', N'CNTT2')
INSERT [dbo].[SinhVien] ([MaSV], [Ho], [Ten], [MaKhoa]) VALUES (N'N20DCCN014', N'Hồ Thái', N'Đạt', N'CNTT2')
INSERT [dbo].[SinhVien] ([MaSV], [Ho], [Ten], [MaKhoa]) VALUES (N'N20DCCN016', N'Hoàng Lê Thúy', N'Hoa', N'CNTT2')
INSERT [dbo].[SinhVien] ([MaSV], [Ho], [Ten], [MaKhoa]) VALUES (N'N20DCCN017', N'Đậu Văn', N'Hoàng', N'CNTT2')
INSERT [dbo].[SinhVien] ([MaSV], [Ho], [Ten], [MaKhoa]) VALUES (N'N20DCCN018', N'Hồ Đức', N'Hoàng', N'CNTT2')
INSERT [dbo].[SinhVien] ([MaSV], [Ho], [Ten], [MaKhoa]) VALUES (N'N20DCCN019', N'Trương TháI', N'HoàNg', N'CNTT2')
INSERT [dbo].[SinhVien] ([MaSV], [Ho], [Ten], [MaKhoa]) VALUES (N'N20DCCN020', N'Vũ Huy', N'Hùng', N'CNTT2')
INSERT [dbo].[SinhVien] ([MaSV], [Ho], [Ten], [MaKhoa]) VALUES (N'N20DCCN021', N'Nguyễn Đức', N'Huy', N'CNTT2')
INSERT [dbo].[SinhVien] ([MaSV], [Ho], [Ten], [MaKhoa]) VALUES (N'N20DCCN022', N'Võ Quang', N'Huy', N'CNTT2')
INSERT [dbo].[SinhVien] ([MaSV], [Ho], [Ten], [MaKhoa]) VALUES (N'N20DCCN024', N'Huỳnh Gia', N'Hưng', N'CNTT2')
INSERT [dbo].[SinhVien] ([MaSV], [Ho], [Ten], [MaKhoa]) VALUES (N'N20DCCN025', N'Ngô Tiến', N'Hưng', N'CNTT2')
INSERT [dbo].[SinhVien] ([MaSV], [Ho], [Ten], [MaKhoa]) VALUES (N'N20DCCN026', N'Văn Tố', N'Hữu', N'CNTT2')
INSERT [dbo].[SinhVien] ([MaSV], [Ho], [Ten], [MaKhoa]) VALUES (N'N20DCCN027', N'Đoàn Trung', N'Kiên', N'CNTT2')
INSERT [dbo].[SinhVien] ([MaSV], [Ho], [Ten], [MaKhoa]) VALUES (N'N20DCCN028', N'Lê Ngọc Tuấn', N'Kiệt', N'CNTT2')
INSERT [dbo].[SinhVien] ([MaSV], [Ho], [Ten], [MaKhoa]) VALUES (N'N20DCCN029', N'Đinh Hồng', N'Kông', N'CNTT2')
INSERT [dbo].[SinhVien] ([MaSV], [Ho], [Ten], [MaKhoa]) VALUES (N'N20DCCN031', N'Nguyễn Nhật', N'Kha', N'CNTT2')
INSERT [dbo].[SinhVien] ([MaSV], [Ho], [Ten], [MaKhoa]) VALUES (N'N20DCCN032', N'Văn Chí', N'Khanh', N'CNTT2')
INSERT [dbo].[SinhVien] ([MaSV], [Ho], [Ten], [MaKhoa]) VALUES (N'N20DCCN033', N'Trần Ngọc Đăng', N'Khoa', N'CNTT2')
INSERT [dbo].[SinhVien] ([MaSV], [Ho], [Ten], [MaKhoa]) VALUES (N'N20DCCN034', N'Vũ Văn', N'Lâm', N'CNTT2')
INSERT [dbo].[SinhVien] ([MaSV], [Ho], [Ten], [MaKhoa]) VALUES (N'N20DCCN035', N'Trần Gia', N'Long', N'CNTT2')
INSERT [dbo].[SinhVien] ([MaSV], [Ho], [Ten], [MaKhoa]) VALUES (N'N20DCCN036', N'Nguyễn Phúc', N'Luân', N'CNTT2')
INSERT [dbo].[SinhVien] ([MaSV], [Ho], [Ten], [MaKhoa]) VALUES (N'N20DCCN040', N'Phùng Đức', N'Mạnh', N'CNTT2')
INSERT [dbo].[SinhVien] ([MaSV], [Ho], [Ten], [MaKhoa]) VALUES (N'N20DCCN041', N'Đỗ Xuân', N'Minh', N'CNTT2')
INSERT [dbo].[SinhVien] ([MaSV], [Ho], [Ten], [MaKhoa]) VALUES (N'N20DCCN042', N'Vũ Đức', N'Minh', N'CNTT2')
INSERT [dbo].[SinhVien] ([MaSV], [Ho], [Ten], [MaKhoa]) VALUES (N'N20DCCN045', N'Nguyễn Quang', N'Nghĩa', N'CNTT2')
INSERT [dbo].[SinhVien] ([MaSV], [Ho], [Ten], [MaKhoa]) VALUES (N'N20DCCN046', N'Nguyễn Tiến', N'Ngọc', N'CNTT2')
INSERT [dbo].[SinhVien] ([MaSV], [Ho], [Ten], [MaKhoa]) VALUES (N'N20DCCN049', N'Hồ Đức', N'Nhân', N'CNTT2')
INSERT [dbo].[SinhVien] ([MaSV], [Ho], [Ten], [MaKhoa]) VALUES (N'N20DCCN052', N'Nguyễn Thị', N'Nhung', N'CNTT2')
INSERT [dbo].[SinhVien] ([MaSV], [Ho], [Ten], [MaKhoa]) VALUES (N'N20DCCN053', N'Nguyễn Đình', N'Phát', N'CNTT2')
INSERT [dbo].[SinhVien] ([MaSV], [Ho], [Ten], [MaKhoa]) VALUES (N'N20DCCN054', N'Nguyễn Tấn', N'Phát', N'CNTT2')
INSERT [dbo].[SinhVien] ([MaSV], [Ho], [Ten], [MaKhoa]) VALUES (N'N20DCCN055', N'Lê Văn', N'Phúc', N'CNTT2')
INSERT [dbo].[SinhVien] ([MaSV], [Ho], [Ten], [MaKhoa]) VALUES (N'N20DCCN056', N'Lại Khắc Minh', N'Quang', N'CNTT2')
INSERT [dbo].[SinhVien] ([MaSV], [Ho], [Ten], [MaKhoa]) VALUES (N'N20DCCN058', N'Lương Thanh', N'Quý', N'CNTT2')
INSERT [dbo].[SinhVien] ([MaSV], [Ho], [Ten], [MaKhoa]) VALUES (N'N20DCCN060', N'Trịnh Công', N'Sơn', N'CNTT2')
INSERT [dbo].[SinhVien] ([MaSV], [Ho], [Ten], [MaKhoa]) VALUES (N'N20DCCN062', N'Đặng Thành', N'Tân', N'CNTT2')
INSERT [dbo].[SinhVien] ([MaSV], [Ho], [Ten], [MaKhoa]) VALUES (N'N20DCCN064', N'Lê Văn', N'Tiến', N'CNTT2')
INSERT [dbo].[SinhVien] ([MaSV], [Ho], [Ten], [MaKhoa]) VALUES (N'N20DCCN065', N'Nguyễn Trần Trọng', N'Tín', N'CNTT2')
INSERT [dbo].[SinhVien] ([MaSV], [Ho], [Ten], [MaKhoa]) VALUES (N'N20DCCN066', N'Nguyễn Trọng', N'Tín', N'CNTT2')
INSERT [dbo].[SinhVien] ([MaSV], [Ho], [Ten], [MaKhoa]) VALUES (N'N20DCCN067', N'Đặng Khắc', N'Toản', N'CNTT2')
INSERT [dbo].[SinhVien] ([MaSV], [Ho], [Ten], [MaKhoa]) VALUES (N'N20DCCN068', N'Bùi Ngọc', N'Tú', N'CNTT2')
INSERT [dbo].[SinhVien] ([MaSV], [Ho], [Ten], [MaKhoa]) VALUES (N'N20DCCN069', N'Lê Văn', N'Tuấn', N'CNTT2')
INSERT [dbo].[SinhVien] ([MaSV], [Ho], [Ten], [MaKhoa]) VALUES (N'N20DCCN070', N'Đinh Văn', N'Ty', N'CNTT2')
INSERT [dbo].[SinhVien] ([MaSV], [Ho], [Ten], [MaKhoa]) VALUES (N'N20DCCN071', N'Nguyễn Khắc', N'Thái', N'CNTT2')
INSERT [dbo].[SinhVien] ([MaSV], [Ho], [Ten], [MaKhoa]) VALUES (N'N20DCCN072', N'Phạm Văn', N'Thành', N'CNTT2')
INSERT [dbo].[SinhVien] ([MaSV], [Ho], [Ten], [MaKhoa]) VALUES (N'N20DCCN073', N'Phạm Đức', N'Thắng', N'CNTT2')
INSERT [dbo].[SinhVien] ([MaSV], [Ho], [Ten], [MaKhoa]) VALUES (N'N20DCCN075', N'Nguyễn Phước Duy', N'Thịnh', N'CNTT2')
INSERT [dbo].[SinhVien] ([MaSV], [Ho], [Ten], [MaKhoa]) VALUES (N'N20DCCN079', N'Đặng Đức', N'Trọng', N'CNTT2')
INSERT [dbo].[SinhVien] ([MaSV], [Ho], [Ten], [MaKhoa]) VALUES (N'N20DCCN080', N'Nguyễn Quang', N'Trung', N'CNTT2')
INSERT [dbo].[SinhVien] ([MaSV], [Ho], [Ten], [MaKhoa]) VALUES (N'N20DCCN081', N'Lê Xuân', N'Trường', N'CNTT2')
INSERT [dbo].[SinhVien] ([MaSV], [Ho], [Ten], [MaKhoa]) VALUES (N'N20DCCN082', N'Nguyễn Phan Nhựt', N'Trường', N'CNTT2')
INSERT [dbo].[SinhVien] ([MaSV], [Ho], [Ten], [MaKhoa]) VALUES (N'N20DCCN083', N'Nguyễn Thái', N'Trưởng', N'CNTT2')
INSERT [dbo].[SinhVien] ([MaSV], [Ho], [Ten], [MaKhoa]) VALUES (N'N20DCCN084', N'Trần Ngọc Khánh', N'Văn', N'CNTT2')
INSERT [dbo].[SinhVien] ([MaSV], [Ho], [Ten], [MaKhoa]) VALUES (N'N20DCCN087', N'Trần Việt', N'Anh', N'CNTT2')
INSERT [dbo].[SinhVien] ([MaSV], [Ho], [Ten], [MaKhoa]) VALUES (N'N20DCCN097', N'Mai Thanh', N'Hải', N'CNTT2')
INSERT [dbo].[SinhVien] ([MaSV], [Ho], [Ten], [MaKhoa]) VALUES (N'N20DCCN103', N'Đào Huy', N'Hiệu', N'CNTT2')
INSERT [dbo].[SinhVien] ([MaSV], [Ho], [Ten], [MaKhoa]) VALUES (N'N20DCCN108', N'Nguyễn Thanh', N'Hữu', N'CNTT2')
INSERT [dbo].[SinhVien] ([MaSV], [Ho], [Ten], [MaKhoa]) VALUES (N'N20DCCN125', N'Nguyễn Dương', N'Phi', N'CNTT2')
INSERT [dbo].[SinhVien] ([MaSV], [Ho], [Ten], [MaKhoa]) VALUES (N'N20DCCN147', N'Đỗ Duy', N'Thiên', N'CNTT2')
INSERT [dbo].[SinhVien] ([MaSV], [Ho], [Ten], [MaKhoa]) VALUES (N'N20DCCN165', N'Nguyễn Thanh Tuấn', N'Vũ', N'CNTT2')
INSERT [dbo].[SinhVien] ([MaSV], [Ho], [Ten], [MaKhoa]) VALUES (N'N20DCMR033', N'Nguyễn Văn', N'Khánh', N'QTKD2')
INSERT [dbo].[SinhVien] ([MaSV], [Ho], [Ten], [MaKhoa]) VALUES (N'N20DCMR034', N'Trần Huỳnh', N'Khánh', N'QTKD2')
INSERT [dbo].[SinhVien] ([MaSV], [Ho], [Ten], [MaKhoa]) VALUES (N'N20DCPT012', N'Ngô Khánh', N'Duy', N'CNTT2')
INSERT [dbo].[SinhVien] ([MaSV], [Ho], [Ten], [MaKhoa]) VALUES (N'N20DCVT005', N'Hoàng Tiến', N'Dũng', N'VT2  ')
INSERT [dbo].[SinhVien] ([MaSV], [Ho], [Ten], [MaKhoa]) VALUES (N'N20DCVT031', N'Nguyễn Văn', N'Mạnh', N'VT2  ')
INSERT [dbo].[SinhVien] ([MaSV], [Ho], [Ten], [MaKhoa]) VALUES (N'N20DCVT048', N'Lê Minh', N'Tài', N'VT2  ')
GO
INSERT [dbo].[SinhVien] ([MaSV], [Ho], [Ten], [MaKhoa]) VALUES (N'N21DCAT035', N'Tô Đặng Hiếu', N'Ngân', N'CNTT2')
INSERT [dbo].[SinhVien] ([MaSV], [Ho], [Ten], [MaKhoa]) VALUES (N'N21DCCN010', N'Nguyễn Văn', N'Chiến', N'CNTT2')
INSERT [dbo].[SinhVien] ([MaSV], [Ho], [Ten], [MaKhoa]) VALUES (N'N21DCCN071', N'Nguyễn Bá', N'Sang', N'CNTT2')
INSERT [dbo].[SinhVien] ([MaSV], [Ho], [Ten], [MaKhoa]) VALUES (N'N21DCCN104', N'Nguyễn Thái', N'Bình', N'CNTT2')
INSERT [dbo].[SinhVien] ([MaSV], [Ho], [Ten], [MaKhoa]) VALUES (N'N21DCCN179', N'Nguyễn Phát', N'Thịnh', N'CNTT2')
INSERT [dbo].[SinhVien] ([MaSV], [Ho], [Ten], [MaKhoa]) VALUES (N'N21DCDT013', N'Đỗ Việt', N'Cường', N'KTDT2')
INSERT [dbo].[SinhVien] ([MaSV], [Ho], [Ten], [MaKhoa]) VALUES (N'N21DCDT071', N'Vu Van', N'Phúc', N'KTDT2')
INSERT [dbo].[SinhVien] ([MaSV], [Ho], [Ten], [MaKhoa]) VALUES (N'N21DCDT081', N'Nguyễn Quí', N'Thái', N'KTDT2')
INSERT [dbo].[SinhVien] ([MaSV], [Ho], [Ten], [MaKhoa]) VALUES (N'N21DCKT029', N'Trần Gia', N'Minh', N'QTKD2')
INSERT [dbo].[SinhVien] ([MaSV], [Ho], [Ten], [MaKhoa]) VALUES (N'N21DCMR013', N'Phan Thị', N'Diệu', N'QTKD2')
INSERT [dbo].[SinhVien] ([MaSV], [Ho], [Ten], [MaKhoa]) VALUES (N'N21DCMR016', N'Đoàn Thị Mỹ', N'Duyên', N'QTKD2')
INSERT [dbo].[SinhVien] ([MaSV], [Ho], [Ten], [MaKhoa]) VALUES (N'N21DCMR023', N'Trần Thị Thu', N'Hiền', N'QTKD2')
INSERT [dbo].[SinhVien] ([MaSV], [Ho], [Ten], [MaKhoa]) VALUES (N'N21DCMR069', N'Phạm Nguyễn Hữu', N'Vương', N'QTKD2')
INSERT [dbo].[SinhVien] ([MaSV], [Ho], [Ten], [MaKhoa]) VALUES (N'N21DCPT019', N'Trần Hồ Tây', N'Giang', N'CNTT2')
INSERT [dbo].[SinhVien] ([MaSV], [Ho], [Ten], [MaKhoa]) VALUES (N'N21DCPT072', N'Lê Truong Hoàng', N'Phú', N'CNTT2')
INSERT [dbo].[SinhVien] ([MaSV], [Ho], [Ten], [MaKhoa]) VALUES (N'N21DCPT082', N'Vũ Văn', N'Sỹ', N'CNTT2')
INSERT [dbo].[SinhVien] ([MaSV], [Ho], [Ten], [MaKhoa]) VALUES (N'N21DCVT037', N'Nguyễn Đình', N'Huy', N'VT2  ')
INSERT [dbo].[SinhVien] ([MaSV], [Ho], [Ten], [MaKhoa]) VALUES (N'N22DCCN100', N'Vũ Trần Thanh', N'An', N'CNTT2')
INSERT [dbo].[SinhVien] ([MaSV], [Ho], [Ten], [MaKhoa]) VALUES (N'N22DCCN153', N'Nguyễn Hồ Quang', N'Minh', N'CNTT2')
INSERT [dbo].[SinhVien] ([MaSV], [Ho], [Ten], [MaKhoa]) VALUES (N'N22DCCN155', N'Đỗ Phú', N'Nghĩa', N'CNTT2')
INSERT [dbo].[SinhVien] ([MaSV], [Ho], [Ten], [MaKhoa]) VALUES (N'N22DCDT012', N'Phạm Quang', N'Duy', N'KTDT2')
INSERT [dbo].[SinhVien] ([MaSV], [Ho], [Ten], [MaKhoa]) VALUES (N'N22DCDT014', N'Lưu Tiến', N'Đạt', N'KTDT2')
INSERT [dbo].[SinhVien] ([MaSV], [Ho], [Ten], [MaKhoa]) VALUES (N'N22DCDT023', N'Trần Việt', N'Hà', N'KTDT2')
INSERT [dbo].[SinhVien] ([MaSV], [Ho], [Ten], [MaKhoa]) VALUES (N'N22DCPT010', N'Nguyễn Lương Ngọc', N'Diệu', N'CNTT2')
GO
INSERT [dbo].[ThanhVienNhom] ([MaNhom], [MaSV]) VALUES (N'N0001', N'N20DCCN016')
INSERT [dbo].[ThanhVienNhom] ([MaNhom], [MaSV]) VALUES (N'N0002', N'N19DCAT063')
INSERT [dbo].[ThanhVienNhom] ([MaNhom], [MaSV]) VALUES (N'N0003', N'N19DCAT048')
INSERT [dbo].[ThanhVienNhom] ([MaNhom], [MaSV]) VALUES (N'N0003', N'N19DCCN007')
INSERT [dbo].[ThanhVienNhom] ([MaNhom], [MaSV]) VALUES (N'N0004', N'N19DCAT034')
INSERT [dbo].[ThanhVienNhom] ([MaNhom], [MaSV]) VALUES (N'N0004', N'N19DCCN008')
INSERT [dbo].[ThanhVienNhom] ([MaNhom], [MaSV]) VALUES (N'N0004', N'N19DCCN020')
INSERT [dbo].[ThanhVienNhom] ([MaNhom], [MaSV]) VALUES (N'N0004', N'N20DCCN040')
INSERT [dbo].[ThanhVienNhom] ([MaNhom], [MaSV]) VALUES (N'N0004', N'N20DCCN060')
INSERT [dbo].[ThanhVienNhom] ([MaNhom], [MaSV]) VALUES (N'N0004', N'N20DCCN079')
INSERT [dbo].[ThanhVienNhom] ([MaNhom], [MaSV]) VALUES (N'N0006', N'N19DCCN110')
INSERT [dbo].[ThanhVienNhom] ([MaNhom], [MaSV]) VALUES (N'N0006', N'N19DCCN128')
INSERT [dbo].[ThanhVienNhom] ([MaNhom], [MaSV]) VALUES (N'N0006', N'N20DCCN046')
INSERT [dbo].[ThanhVienNhom] ([MaNhom], [MaSV]) VALUES (N'N0006', N'N20DCCN049')
INSERT [dbo].[ThanhVienNhom] ([MaNhom], [MaSV]) VALUES (N'N0006', N'N20DCCN052')
INSERT [dbo].[ThanhVienNhom] ([MaNhom], [MaSV]) VALUES (N'N0006', N'N20DCCN053')
INSERT [dbo].[ThanhVienNhom] ([MaNhom], [MaSV]) VALUES (N'N0007', N'N20DCVT005')
INSERT [dbo].[ThanhVienNhom] ([MaNhom], [MaSV]) VALUES (N'N0007', N'N20DCVT031')
INSERT [dbo].[ThanhVienNhom] ([MaNhom], [MaSV]) VALUES (N'N0008', N'N17DCPT069')
INSERT [dbo].[ThanhVienNhom] ([MaNhom], [MaSV]) VALUES (N'N0008', N'N18DCCN009')
INSERT [dbo].[ThanhVienNhom] ([MaNhom], [MaSV]) VALUES (N'N0008', N'N18DCCN011')
INSERT [dbo].[ThanhVienNhom] ([MaNhom], [MaSV]) VALUES (N'N0008', N'N19DCCN024')
INSERT [dbo].[ThanhVienNhom] ([MaNhom], [MaSV]) VALUES (N'N0008', N'N19DCCN044')
INSERT [dbo].[ThanhVienNhom] ([MaNhom], [MaSV]) VALUES (N'N0008', N'N19DCCN092')
INSERT [dbo].[ThanhVienNhom] ([MaNhom], [MaSV]) VALUES (N'N0009', N'N20DCVT048')
INSERT [dbo].[ThanhVienNhom] ([MaNhom], [MaSV]) VALUES (N'N0009', N'N21DCVT037')
GO
INSERT [dbo].[Xa] ([MaXa], [TenXa], [MaDiaBan]) VALUES (N'X001', N'Hương Lộc', N'DB02')
INSERT [dbo].[Xa] ([MaXa], [TenXa], [MaDiaBan]) VALUES (N'X002', N'Đông Hòa', N'DB01')
INSERT [dbo].[Xa] ([MaXa], [TenXa], [MaDiaBan]) VALUES (N'X003', N'Tân Đông Hiệp', N'DB01')
INSERT [dbo].[Xa] ([MaXa], [TenXa], [MaDiaBan]) VALUES (N'X004', N'Hiệp Phú', N'DB05')
INSERT [dbo].[Xa] ([MaXa], [TenXa], [MaDiaBan]) VALUES (N'X005', N'Tăng Nhơn Phú A', N'DB05')
INSERT [dbo].[Xa] ([MaXa], [TenXa], [MaDiaBan]) VALUES (N'X006', N'Long Hải', N'DB08')
INSERT [dbo].[Xa] ([MaXa], [TenXa], [MaDiaBan]) VALUES (N'X007', N'Tam Thanh', N'DB08')
INSERT [dbo].[Xa] ([MaXa], [TenXa], [MaDiaBan]) VALUES (N'X008', N'Cà Lúi', N'DB07')
INSERT [dbo].[Xa] ([MaXa], [TenXa], [MaDiaBan]) VALUES (N'X009', N'Đa Lộc', N'DB07')
INSERT [dbo].[Xa] ([MaXa], [TenXa], [MaDiaBan]) VALUES (N'X010', N'Bà Điểm', N'DB04')
INSERT [dbo].[Xa] ([MaXa], [TenXa], [MaDiaBan]) VALUES (N'X011', N'Lý Nhơn', N'DB06')
INSERT [dbo].[Xa] ([MaXa], [TenXa], [MaDiaBan]) VALUES (N'X012', N'Ba Sao', N'DB03')
INSERT [dbo].[Xa] ([MaXa], [TenXa], [MaDiaBan]) VALUES (N'X013', N'Mỹ Tân', N'DB03')
INSERT [dbo].[Xa] ([MaXa], [TenXa], [MaDiaBan]) VALUES (N'X014', N'Hương Sơn', N'DB02')
INSERT [dbo].[Xa] ([MaXa], [TenXa], [MaDiaBan]) VALUES (N'X015', N'KIM SON', N'DB02')
INSERT [dbo].[Xa] ([MaXa], [TenXa], [MaDiaBan]) VALUES (N'X016', N'Bà đỏ', N'DB10')
INSERT [dbo].[Xa] ([MaXa], [TenXa], [MaDiaBan]) VALUES (N'X017', N'Bà Đen', N'DB10')
INSERT [dbo].[Xa] ([MaXa], [TenXa], [MaDiaBan]) VALUES (N'X018', N'Bà Vàng', N'DB10')
INSERT [dbo].[Xa] ([MaXa], [TenXa], [MaDiaBan]) VALUES (N'X019', N'Sao vàng', N'DB12')
INSERT [dbo].[Xa] ([MaXa], [TenXa], [MaDiaBan]) VALUES (N'X020', N'Sao đỏ', N'DB12')
INSERT [dbo].[Xa] ([MaXa], [TenXa], [MaDiaBan]) VALUES (N'X021', N'Sao đen', N'DB12')
INSERT [dbo].[Xa] ([MaXa], [TenXa], [MaDiaBan]) VALUES (N'X022', N'Cà đỏ', N'DB15')
INSERT [dbo].[Xa] ([MaXa], [TenXa], [MaDiaBan]) VALUES (N'X023', N'Cà đen', N'DB15')
INSERT [dbo].[Xa] ([MaXa], [TenXa], [MaDiaBan]) VALUES (N'X024', N'Lộc Tài', N'DB09')
INSERT [dbo].[Xa] ([MaXa], [TenXa], [MaDiaBan]) VALUES (N'X025', N'Lộc Phước', N'DB09')
INSERT [dbo].[Xa] ([MaXa], [TenXa], [MaDiaBan]) VALUES (N'X026', N'Hương Biển', N'DB14')
INSERT [dbo].[Xa] ([MaXa], [TenXa], [MaDiaBan]) VALUES (N'X027', N'Hương Trà', N'DB14')
INSERT [dbo].[Xa] ([MaXa], [TenXa], [MaDiaBan]) VALUES (N'X028', N'Cần Cần', N'DB06')
INSERT [dbo].[Xa] ([MaXa], [TenXa], [MaDiaBan]) VALUES (N'X029', N'Hóc Búa', N'DB04')
INSERT [dbo].[Xa] ([MaXa], [TenXa], [MaDiaBan]) VALUES (N'X030', N'Lý Nhân', N'DB11')
INSERT [dbo].[Xa] ([MaXa], [TenXa], [MaDiaBan]) VALUES (N'X031', N'Lý Quý', N'DB11')
INSERT [dbo].[Xa] ([MaXa], [TenXa], [MaDiaBan]) VALUES (N'X032', N'Mỹ Thạnh', N'DB13')
INSERT [dbo].[Xa] ([MaXa], [TenXa], [MaDiaBan]) VALUES (N'X033', N'Mỹ Hòa', N'DB13')
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UK_Ap]    Script Date: 7/11/2023 4:16:49 PM ******/
ALTER TABLE [dbo].[Ap] ADD  CONSTRAINT [UK_Ap] UNIQUE NONCLUSTERED 
(
	[TenAp] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UK_TenDiaBan]    Script Date: 7/11/2023 4:16:49 PM ******/
ALTER TABLE [dbo].[DiaBan] ADD  CONSTRAINT [UK_TenDiaBan] UNIQUE NONCLUSTERED 
(
	[TenDiaBan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UK_MaCD_Giamsat1]    Script Date: 7/11/2023 4:16:49 PM ******/
ALTER TABLE [dbo].[Doi] ADD  CONSTRAINT [UK_MaCD_Giamsat1] UNIQUE NONCLUSTERED 
(
	[MaChienDich] ASC,
	[GiamSat1] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UK_MaCD_Giamsat2]    Script Date: 7/11/2023 4:16:49 PM ******/
ALTER TABLE [dbo].[Doi] ADD  CONSTRAINT [UK_MaCD_Giamsat2] UNIQUE NONCLUSTERED 
(
	[MaChienDich] ASC,
	[GiamSat2] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UK_MaCD_MaXa]    Script Date: 7/11/2023 4:16:49 PM ******/
ALTER TABLE [dbo].[Doi] ADD  CONSTRAINT [UK_MaCD_MaXa] UNIQUE NONCLUSTERED 
(
	[MaChienDich] ASC,
	[MaXa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_KHOA]    Script Date: 7/11/2023 4:16:49 PM ******/
ALTER TABLE [dbo].[Khoa] ADD  CONSTRAINT [IX_KHOA] UNIQUE NONCLUSTERED 
(
	[TenKhoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UK_DiaChi]    Script Date: 7/11/2023 4:16:49 PM ******/
ALTER TABLE [dbo].[NhaDan] ADD  CONSTRAINT [UK_DiaChi] UNIQUE NONCLUSTERED 
(
	[DiaChi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UK_TenXa]    Script Date: 7/11/2023 4:16:49 PM ******/
ALTER TABLE [dbo].[Xa] ADD  CONSTRAINT [UK_TenXa] UNIQUE NONCLUSTERED 
(
	[TenXa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ChienDich] ADD  CONSTRAINT [DF_ChienDich_NgayPhatDong]  DEFAULT (getdate()) FOR [NgayPhatDong]
GO
ALTER TABLE [dbo].[PhanCong] ADD  CONSTRAINT [DF_PhanCong_Ngay]  DEFAULT (getdate()) FOR [Ngay]
GO
ALTER TABLE [dbo].[Ap]  WITH CHECK ADD  CONSTRAINT [FK_Ap_Xa] FOREIGN KEY([MaXa])
REFERENCES [dbo].[Xa] ([MaXa])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Ap] CHECK CONSTRAINT [FK_Ap_Xa]
GO
ALTER TABLE [dbo].[ChiTietChienDich]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETCHIENDICH_ChienDich] FOREIGN KEY([MaChienDich])
REFERENCES [dbo].[ChienDich] ([MaChienDich])
GO
ALTER TABLE [dbo].[ChiTietChienDich] CHECK CONSTRAINT [FK_CHITIETCHIENDICH_ChienDich]
GO
ALTER TABLE [dbo].[ChiTietChienDich]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETCHIENDICH_DiaBan] FOREIGN KEY([MaDiaBan])
REFERENCES [dbo].[DiaBan] ([MaDiaBan])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[ChiTietChienDich] CHECK CONSTRAINT [FK_CHITIETCHIENDICH_DiaBan]
GO
ALTER TABLE [dbo].[CongViec]  WITH CHECK ADD  CONSTRAINT [FK_CongViec_Ap] FOREIGN KEY([MaAp])
REFERENCES [dbo].[Ap] ([MaAp])
GO
ALTER TABLE [dbo].[CongViec] CHECK CONSTRAINT [FK_CongViec_Ap]
GO
ALTER TABLE [dbo].[Doi]  WITH CHECK ADD  CONSTRAINT [FK_Doi_ChienDich] FOREIGN KEY([MaChienDich])
REFERENCES [dbo].[ChienDich] ([MaChienDich])
GO
ALTER TABLE [dbo].[Doi] CHECK CONSTRAINT [FK_Doi_ChienDich]
GO
ALTER TABLE [dbo].[Doi]  WITH CHECK ADD  CONSTRAINT [FK_Doi_GiangVien] FOREIGN KEY([GiamSat1])
REFERENCES [dbo].[GiangVien] ([MaGV])
GO
ALTER TABLE [dbo].[Doi] CHECK CONSTRAINT [FK_Doi_GiangVien]
GO
ALTER TABLE [dbo].[Doi]  WITH CHECK ADD  CONSTRAINT [FK_Doi_GiangVien1] FOREIGN KEY([GiamSat2])
REFERENCES [dbo].[GiangVien] ([MaGV])
GO
ALTER TABLE [dbo].[Doi] CHECK CONSTRAINT [FK_Doi_GiangVien1]
GO
ALTER TABLE [dbo].[Doi]  WITH CHECK ADD  CONSTRAINT [FK_Doi_KHOA] FOREIGN KEY([MaKhoa])
REFERENCES [dbo].[Khoa] ([MaKhoa])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Doi] CHECK CONSTRAINT [FK_Doi_KHOA]
GO
ALTER TABLE [dbo].[Doi]  WITH CHECK ADD  CONSTRAINT [FK_Doi_SinhVien] FOREIGN KEY([DoiTruong])
REFERENCES [dbo].[SinhVien] ([MaSV])
GO
ALTER TABLE [dbo].[Doi] CHECK CONSTRAINT [FK_Doi_SinhVien]
GO
ALTER TABLE [dbo].[Doi]  WITH CHECK ADD  CONSTRAINT [FK_Doi_SinhVien1] FOREIGN KEY([DoiPho])
REFERENCES [dbo].[SinhVien] ([MaSV])
GO
ALTER TABLE [dbo].[Doi] CHECK CONSTRAINT [FK_Doi_SinhVien1]
GO
ALTER TABLE [dbo].[Doi]  WITH CHECK ADD  CONSTRAINT [FK_Doi_Xa] FOREIGN KEY([MaXa])
REFERENCES [dbo].[Xa] ([MaXa])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Doi] CHECK CONSTRAINT [FK_Doi_Xa]
GO
ALTER TABLE [dbo].[GiangVien]  WITH CHECK ADD  CONSTRAINT [FK_GiangVien_KHOA] FOREIGN KEY([MaKhoa])
REFERENCES [dbo].[Khoa] ([MaKhoa])
GO
ALTER TABLE [dbo].[GiangVien] CHECK CONSTRAINT [FK_GiangVien_KHOA]
GO
ALTER TABLE [dbo].[KhenThuong]  WITH CHECK ADD  CONSTRAINT [FK_KhenThuong_Doi] FOREIGN KEY([MaDoi])
REFERENCES [dbo].[Doi] ([MaDoi])
GO
ALTER TABLE [dbo].[KhenThuong] CHECK CONSTRAINT [FK_KhenThuong_Doi]
GO
ALTER TABLE [dbo].[KhenThuong]  WITH CHECK ADD  CONSTRAINT [FK_KhenThuong_SinhVien] FOREIGN KEY([MaSV])
REFERENCES [dbo].[SinhVien] ([MaSV])
GO
ALTER TABLE [dbo].[KhenThuong] CHECK CONSTRAINT [FK_KhenThuong_SinhVien]
GO
ALTER TABLE [dbo].[NhaDan]  WITH CHECK ADD  CONSTRAINT [FK_NhaDan_Ap] FOREIGN KEY([MaAp])
REFERENCES [dbo].[Ap] ([MaAp])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[NhaDan] CHECK CONSTRAINT [FK_NhaDan_Ap]
GO
ALTER TABLE [dbo].[Nhom]  WITH CHECK ADD  CONSTRAINT [FK_Nhom_Doi] FOREIGN KEY([MaDoi])
REFERENCES [dbo].[Doi] ([MaDoi])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Nhom] CHECK CONSTRAINT [FK_Nhom_Doi]
GO
ALTER TABLE [dbo].[Nhom]  WITH CHECK ADD  CONSTRAINT [FK_Nhom_NhaDan] FOREIGN KEY([MaNha])
REFERENCES [dbo].[NhaDan] ([MaNha])
GO
ALTER TABLE [dbo].[Nhom] CHECK CONSTRAINT [FK_Nhom_NhaDan]
GO
ALTER TABLE [dbo].[Nhom]  WITH CHECK ADD  CONSTRAINT [FK_Nhom_SinhVien] FOREIGN KEY([NhomTruong])
REFERENCES [dbo].[SinhVien] ([MaSV])
GO
ALTER TABLE [dbo].[Nhom] CHECK CONSTRAINT [FK_Nhom_SinhVien]
GO
ALTER TABLE [dbo].[PhanCong]  WITH CHECK ADD  CONSTRAINT [FK_PhanCong_CongViec] FOREIGN KEY([MaCV])
REFERENCES [dbo].[CongViec] ([MaCV])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[PhanCong] CHECK CONSTRAINT [FK_PhanCong_CongViec]
GO
ALTER TABLE [dbo].[PhanCong]  WITH CHECK ADD  CONSTRAINT [FK_PhanCong_Nhom] FOREIGN KEY([MaNhom])
REFERENCES [dbo].[Nhom] ([MaNhom])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[PhanCong] CHECK CONSTRAINT [FK_PhanCong_Nhom]
GO
ALTER TABLE [dbo].[SinhVien]  WITH CHECK ADD  CONSTRAINT [FK_SinhVien_KHOA] FOREIGN KEY([MaKhoa])
REFERENCES [dbo].[Khoa] ([MaKhoa])
GO
ALTER TABLE [dbo].[SinhVien] CHECK CONSTRAINT [FK_SinhVien_KHOA]
GO
ALTER TABLE [dbo].[ThanhVienNhom]  WITH CHECK ADD  CONSTRAINT [FK_ThanhVienNhom_Nhom] FOREIGN KEY([MaNhom])
REFERENCES [dbo].[Nhom] ([MaNhom])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[ThanhVienNhom] CHECK CONSTRAINT [FK_ThanhVienNhom_Nhom]
GO
ALTER TABLE [dbo].[ThanhVienNhom]  WITH CHECK ADD  CONSTRAINT [FK_ThanhVienNhom_SinhVien] FOREIGN KEY([MaSV])
REFERENCES [dbo].[SinhVien] ([MaSV])
GO
ALTER TABLE [dbo].[ThanhVienNhom] CHECK CONSTRAINT [FK_ThanhVienNhom_SinhVien]
GO
ALTER TABLE [dbo].[Xa]  WITH CHECK ADD  CONSTRAINT [FK_Xa_DiaBan] FOREIGN KEY([MaDiaBan])
REFERENCES [dbo].[DiaBan] ([MaDiaBan])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Xa] CHECK CONSTRAINT [FK_Xa_DiaBan]
GO
ALTER TABLE [dbo].[Doi]  WITH CHECK ADD  CONSTRAINT [Một đội có 2 giám sát khác nhau] CHECK  (([Giamsat1]<>[Giamsat2]))
GO
ALTER TABLE [dbo].[Doi] CHECK CONSTRAINT [Một đội có 2 giám sát khác nhau]
GO
ALTER TABLE [dbo].[Doi]  WITH CHECK ADD  CONSTRAINT [Một đội có đội trưởng, đội phó khác nhau] CHECK  (([DoiTruong]<>[DoiPho]))
GO
ALTER TABLE [dbo].[Doi] CHECK CONSTRAINT [Một đội có đội trưởng, đội phó khác nhau]
GO
/****** Object:  StoredProcedure [dbo].[Sp_Backup]    Script Date: 7/11/2023 4:16:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Sp_Backup]
	-- Add the parameters for the stored procedure here
	@Type int, @BackupDevice nvarchar(100), @Description NVARCHAR(4000)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	DECLARE @DBName NVARCHAR(100)
	SET @DBName = 'TTCS_MUAHEXANH'

    IF @Type = 0
		BEGIN
		-- Fullbackup, backup device
			IF @BackupDevice IS NOT NULL
				BEGIN
					SET @Description = @Description
					BACKUP DATABASE @DBName
					TO @BackupDevice
					WITH
					DESCRIPTION  = @Description,
					STATS = 1
				END
		
			ELSE
				BEGIN
					RAISERROR('Vui lòng cung cấp tên backup device hoặc url', 16, 1);
					RETURN 1;
				END
		END
	ELSE IF @Type = 1
		BEGIN
		-- Differential backup, backup device
			IF @BackupDevice IS NOT NULL
				BEGIN
					SET @Description = @Description
					BACKUP DATABASE @DBName
					TO @BackupDevice
					WITH
					DIFFERENTIAL,
					DESCRIPTION  = @Description,
					STATS = 1
				END

			ELSE
				BEGIN
					RAISERROR('Vui lòng cung cấp tên backup device hoặc url', 16, 1);
					RETURN 1;
				END
		END
	ELSE
		BEGIN
		-- Transaction log backup, backup device
			IF @BackupDevice IS NOT NULL
				BEGIN
					SET @Description = @Description
					BACKUP LOG @DBName
					TO @BackupDevice
					WITH
					DESCRIPTION  = @Description,
					STATS = 1
				END

			
			ELSE
				BEGIN
					RAISERROR('Vui lòng cung cấp tên backup device hoặc url', 16, 1);
					RETURN 1;
				END
		END

		RETURN 0;
END
GO
/****** Object:  StoredProcedure [dbo].[sp_chiadoi]    Script Date: 7/11/2023 4:16:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_chiadoi](@SVTHEM TYPE_CHIANHOM READONLY)
AS
BEGIN
	INSERT ThanhVienNhom
		SELECT MANHOM, MASV 
		FROM @SVTHEM
END
GO
/****** Object:  StoredProcedure [dbo].[sp_chianhom]    Script Date: 7/11/2023 4:16:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_chianhom] (@SVXOA TYPE_CHIANHOM READONLY, @SVTHEM TYPE_CHIANHOM READONLY)
AS
BEGIN
	BEGIN TRAN

    BEGIN TRY
		DELETE 
		FROM ThanhVienNhom
		WHERE MaNhom IN (SELECT MANHOM FROM @SVXOA) AND MaSV IN (SELECT MASV FROM @SVXOA)

		INSERT ThanhVienNhom
		SELECT MANHOM, MASV 
		FROM @SVTHEM
    END TRY
    BEGIN CATCH
        Raiserror(N'Chia nhóm không thành công! Vui lòng kiểm lại!',16,1) 
        ROLLBACK TRAN
    END CATCH
    COMMIT TRAN
END
GO
GRANT EXECUTE ON [dbo].[sp_chianhom] TO [DOIPHO] AS [dbo]
GO
GRANT EXECUTE ON [dbo].[sp_chianhom] TO [DOITRUONG] AS [dbo]
GO
/****** Object:  StoredProcedure [dbo].[SP_DangNhap]    Script Date: 7/11/2023 4:16:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_DangNhap]
@TENLOGIN NVARCHAR (50)
AS


DECLARE @TENUSER NVARCHAR(50)
DECLARE @TENNHOM NVARCHAR(50)
SELECT @TENUSER=NAME FROM sys.sysusers WHERE sid = SUSER_SID(@TENLOGIN)
 
SET @TENNHOM = dbo.FC_TenNhom(@TENUSER)


if not exists(select * from ChienDich where NgayKetThuc >= getdate() and NgayPhatDong <= getdate()) and @TENNHOM <> N'ADMIN'
	begin
		raiserror('Không thể đăng nhập khi không có chiến dịch nào đang được triển khai',16,1)
		return 1
	end
declare @tencd nvarchar(50), @macd nchar(7) 
select @macd = MaChienDich, @tencd = TenChienDich from ChienDich where NgayKetThuc >= getdate() and NgayPhatDong <= getdate()
IF @TENNHOM = 'GIAMSAT' OR @TENNHOM = 'KHOA' OR @TENNHOM = 'ADMIN'
	BEGIN 
		SELECT USERNAME = @TENUSER, HOTEN = (SELECT Ho + ' ' + Ten FROM GiangVien WHERE MaGV = @TENUSER), TENNHOM = @TENNHOM, @macd,@tencd
	END 
ELSE
	BEGIN
		SELECT USERNAME = @TENUSER, HOTEN = (SELECT Ho + ' ' + Ten FROM SinhVien WHERE MaSV = @TENUSER), TENNHOM = @TENNHOM, @macd,@tencd
	END
GO
GRANT EXECUTE ON [dbo].[SP_DangNhap] TO [DOIPHO] AS [dbo]
GO
GRANT EXECUTE ON [dbo].[SP_DangNhap] TO [DOITRUONG] AS [dbo]
GO
GRANT EXECUTE ON [dbo].[SP_DangNhap] TO [GIAMSAT] AS [dbo]
GO
GRANT EXECUTE ON [dbo].[SP_DangNhap] TO [NHOMTRUONG] AS [dbo]
GO
/****** Object:  StoredProcedure [dbo].[Sp_DanhSachBackupTrongBackupDevice]    Script Date: 7/11/2023 4:16:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Sp_DanhSachBackupTrongBackupDevice]
@DeviceName Nvarchar(100)
as
begin
	if not exists(select * from sys.backup_devices where name = @DeviceName)
		begin
			raiserror('Backup device không tồn tại.', 16,1)
			return 1
		end
	
	select backup_set_id, media_set_id, position, type, backup_finish_date, backup_size, compressed_backup_size, database_name
	from msdb.dbo.backupset where media_set_id in ( select media_set_id	from  msdb.dbo.backupmediafamily where logical_device_name = @DeviceName)
	order by position

end
GO
/****** Object:  StoredProcedure [dbo].[Sp_DanhSachDiaBanChuaCoTrongChienDich]    Script Date: 7/11/2023 4:16:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Sp_DanhSachDiaBanChuaCoTrongChienDich]
	-- Add the parameters for the stored procedure here
	@MaChienDich nchar(7)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	SELECT * FROM DiaBan 
	WHERE MaDiaBan NOT IN (SELECT MaDiaBan FROM ChiTietChienDich WHERE MaChienDich = @MaChienDich)
    
END
GO
GRANT EXECUTE ON [dbo].[Sp_DanhSachDiaBanChuaCoTrongChienDich] TO [ADMIN] AS [dbo]
GO
/****** Object:  StoredProcedure [dbo].[Sp_DanhSachDiaBanCuaChienDich]    Script Date: 7/11/2023 4:16:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Sp_DanhSachDiaBanCuaChienDich]
	-- Add the parameters for the stored procedure here
	@MaChienDich nchar(7)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	SELECT * FROM DiaBan 
	WHERE MaDiaBan IN (SELECT MaDiaBan FROM ChiTietChienDich WHERE MaChienDich = @MaChienDich)
    
END
GO
GRANT EXECUTE ON [dbo].[Sp_DanhSachDiaBanCuaChienDich] TO [ADMIN] AS [dbo]
GO
/****** Object:  StoredProcedure [dbo].[Sp_DanhSachThietBiBackup]    Script Date: 7/11/2023 4:16:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Sp_DanhSachThietBiBackup]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	EXEC sp_helpdevice;
END
GO
GRANT EXECUTE ON [dbo].[Sp_DanhSachThietBiBackup] TO [ADMIN] AS [dbo]
GO
/****** Object:  StoredProcedure [dbo].[sp_khenThuong]    Script Date: 7/11/2023 4:16:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_khenThuong] @madoi nchar(7), @masv nchar(10)
as

begin
	declare @cout int
	SET TRANSACTION ISOLATION LEVEL read Uncommitted;
	BEGIN TRAN
	select @cout = count(madoi) from KhenThuong where madoi = @madoi
	if (@cout<2)
		BEGIN
		print @cout
		WAITFOR DELAY '00:00:04'
		INSERT INTO KhenThuong VALUES (@madoi, @masv, 'LYDO', 'DANHHIEU') 
		
		COMMIT TRAN
		RETURN 0
		END
	ELSE
		BEGIN
			print @cout
			RAISERROR('LOI',16,1)
			ROLLBACK
			RETURN 1
		END
end
GO
/****** Object:  StoredProcedure [dbo].[sp_khoiPhucTaiKhoan]    Script Date: 7/11/2023 4:16:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[sp_khoiPhucTaiKhoan](@taiKhoan TYPE_KHOIPHUCTAIKHOAN READONLY)
AS
BEGIN
	declare @cmd nvarchar(max)
	set @cmd = (select STRING_AGG('ALTER LOGIN ' + QUOTENAME(lgname) + ' enable;',' ') from
	-- (SELECT name, is_disabled FROM sys.server_principals where is_disabled = 1 and name not like N'##MS_%##') dd
	@taiKhoan)
	--print(@cmd)
	exec(@cmd)
END
GO
/****** Object:  StoredProcedure [dbo].[sp_lay_ap_tu_doi]    Script Date: 7/11/2023 4:16:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_lay_ap_tu_doi](@madoi nchar(11))
as
begin
	select MaAp, TenAp from Ap where maxa = (select maxa from Doi where MaDoi = @madoi)
end
GO
GRANT EXECUTE ON [dbo].[sp_lay_ap_tu_doi] TO [GIAMSAT] AS [dbo]
GO
/****** Object:  StoredProcedure [dbo].[sp_lay_doi_tu_chiendich]    Script Date: 7/11/2023 4:16:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_lay_doi_tu_chiendich](@macd nchar(7))
as
begin
	SELECT D.MADOI, TENDOI, DoiTruong, DoiPho, SOSVTOIDA, SOSVHIENTAI = SUM(SOSVMOINHOM)
	FROM
		(SELECT D.MADOI, TENDOI, DoiTruong, DoiPho, SOSVTOIDA, SOSVMOINHOM=
		CASE
			WHEN TVN.MaNhom IS NULL THEN 0
			ELSE COUNT(*)
		END
		FROM 
			(SELECT MANHOM FROM ThanhVienNhom TVN) TVN
			RIGHT JOIN
			(SELECT D.MADOI, TENDOI, DoiTruong, DoiPho, SOSVTOIDA, MaNhom
			FROM 
				NHOM N,
				(SELECT MADOI, TENDOI, DoiTruong, DoiPho, SOSVTOIDA =COUNT(MaNha)*6
				FROM
					NhaDan nd,
					Ap a,
					(SELECT MADOI, TENDOI, DoiTruong, DoiPho, MaXa FROM DOI WHERE MaChienDich = @macd) d
				WHERE d.MaXa = a.MaXa and nd.MaAp = a.MaAp
				GROUP BY MADOI, TENDOI, DoiTruong, DoiPho)D
			WHERE N.MaDoi = D.MaDoi)D
		ON TVN.MaNhom = D.MaNhom
		GROUP BY MADOI, TENDOI, DoiTruong, DoiPho, SOSVTOIDA, TVN.MaNhom) D
	GROUP BY MADOI, TENDOI, DoiTruong, DoiPho, SOSVTOIDA
end
GO
GRANT EXECUTE ON [dbo].[sp_lay_doi_tu_chiendich] TO [DOIPHO] AS [dbo]
GO
GRANT EXECUTE ON [dbo].[sp_lay_doi_tu_chiendich] TO [DOITRUONG] AS [dbo]
GO
/****** Object:  StoredProcedure [dbo].[sp_lay_doipho_chua_tao_taikhoan]    Script Date: 7/11/2023 4:16:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_lay_doipho_chua_tao_taikhoan]
as
begin
	SET NOCOUNT ON;
	IF 1=0 BEGIN  
        SET FMTONLY OFF  
    END  
	create table #dtdp(
		dtdp nchar(10)
	)
	create table #dtdpcotaikhoan(
		dtdp nchar(10)
	)

	insert into #dtdpcotaikhoan select name from sys.sysusers where issqluser = 1 and hasdbaccess = 1 and name <> 'dbo' and name not like 'GV%'
	insert into #dtdp  select DoiPho  from Doi where DoiPho not in (select * from #dtdpcotaikhoan)
	select MaSV, hoten = ho + ' ' + ten from SinhVien WHERE MASV IN  (select * from #dtdp)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_lay_doitruong_chua_tao_taikhoan]    Script Date: 7/11/2023 4:16:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_lay_doitruong_chua_tao_taikhoan]
as
begin
	SET NOCOUNT ON;
	IF 1=0 BEGIN  
        SET FMTONLY OFF  
    END  
	create table #dtdp(
		dtdp nchar(10)
	)
	create table #dtdpcotaikhoan(
		dtdp nchar(10)
	)

	insert into #dtdpcotaikhoan select name from sys.sysusers where issqluser = 1 and hasdbaccess = 1 and name <> 'dbo' and name not like 'GV%'
	insert into #dtdp  select DoiTruong  from Doi where DoiTruong not in (select * from #dtdpcotaikhoan)
	select MaSV, hoten = ho + ' ' + ten from SinhVien WHERE MASV IN  (select * from #dtdp)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_lay_ds_taikhoan]    Script Date: 7/11/2023 4:16:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_lay_ds_taikhoan](@role nchar(10))
as
begin
	-- lay danh sach tai khoan vo hieu hoa dua theo @role 
	--SELECT * FROM syslogins 
	SELECT name
	FROM sys.server_principals
	where name in
		(SELECT name 
		FROM sys.sysusers 
		where uid in(
			SELECT memberuid  
			FROM SYS.SYSMEMBERS 
			where groupuid =(
				SELECT uid FROM sys.sysusers  
				WHERE name = @role)))
end
GO
/****** Object:  StoredProcedure [dbo].[sp_lay_ds_taikhoan_chuavohieuhoa]    Script Date: 7/11/2023 4:16:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_lay_ds_taikhoan_chuavohieuhoa](@role nchar(10))
as
begin
	-- lay danh sach tai khoan vo hieu hoa dua theo @role 
	--SELECT * FROM syslogins 
	SELECT name
	FROM sys.server_principals
	where is_disabled = 0 and name in
		(SELECT name 
		FROM sys.sysusers 
		where uid in(
			SELECT memberuid  
			FROM SYS.SYSMEMBERS 
			where groupuid =(
				SELECT uid FROM sys.sysusers  
				WHERE name = @role)))
end
GO
/****** Object:  StoredProcedure [dbo].[sp_lay_ds_taikhoan_vohieuhoa]    Script Date: 7/11/2023 4:16:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_lay_ds_taikhoan_vohieuhoa](@role nchar(10))
as
begin
	-- lay danh sach tai khoan vo hieu hoa dua theo @role 
	--SELECT * FROM syslogins 
	SELECT name
	FROM sys.server_principals
	where is_disabled = 1 and name not like N'##MS_%##' and name in
		(SELECT name 
		FROM sys.sysusers 
		where uid in(
			SELECT memberuid  
			FROM SYS.SYSMEMBERS 
			where groupuid =(
				SELECT uid FROM sys.sysusers  
				WHERE name = @role)))
end
GO
/****** Object:  StoredProcedure [dbo].[sp_lay_dscongviec_tu_ap]    Script Date: 7/11/2023 4:16:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_lay_dscongviec_tu_ap](@maap nchar(4), @ngay nvarchar(10))
as 
begin
	set dateformat dmy
	select MaCV, TenCV from CongViec where MaAp = @maap and NgayBatDau <= @ngay and NgayKetThuc >= @ngay
end
GO
GRANT EXECUTE ON [dbo].[sp_lay_dscongviec_tu_ap] TO [GIAMSAT] AS [dbo]
GO
/****** Object:  StoredProcedure [dbo].[sp_lay_dscongviec_tu_doi]    Script Date: 7/11/2023 4:16:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_lay_dscongviec_tu_doi](@madoi nchar(11))
as
begin
	select MaCV,TenCV, NgayBatDau, NgayKetThuc, TENAP 
	from 
		congviec CV,
		(select MaAp, TenAp from Ap where maxa = (select maxa from Doi where MaDoi = @madoi)) AP
	WHERE CV.MaAp = AP.MaAp
end
GO
GRANT EXECUTE ON [dbo].[sp_lay_dscongviec_tu_doi] TO [GIAMSAT] AS [dbo]
GO
/****** Object:  StoredProcedure [dbo].[sp_lay_dsdoi_theo_chiendich]    Script Date: 7/11/2023 4:16:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_lay_dsdoi_theo_chiendich](@machiendich nchar(7))
as
begin



select d.MaDoi, tendoi, GiamSat1 = gs1.hotengv, GiamSat2 = gs2.hotengv, DoiTruong = dt.hotensv, DoiPho=dp.hotensv, tenkhoa, tenxa, sosv
from
	
	(select madoi, hotengv
	from 
		(select magv, hotengv = ho + ' ' + ten from giangvien) gv
		RIGHT JOIN
		(select madoi, GiamSat1 from doi) d
	ON gv.MaGV = d.GiamSat1) gs1,

	(select madoi, hotengv
	from 
		(select magv, hotengv = ho + ' ' + ten from giangvien) gv
		RIGHT JOIN
		(select madoi, GiamSat2 from doi) d
	ON gv.MaGV = d.GiamSat2) gs2,

	(select madoi, hotensv
	from 
		(select masv, hotensv = ho + ' ' + ten from sinhvien) sv
		RIGHT JOIN
		(select madoi, DoiTruong from doi) d
	ON sv.MaSV = d.DoiTruong) dt,

	(select madoi, hotensv
	from 
		(select masv, hotensv = ho + ' ' + ten from sinhvien) sv
		RIGHT JOIN 
		(select madoi, DoiPho from doi) d
	on sv.MaSV = d.DoiPho) dp,

	(select MaDoi, tendoi, GiamSat1, GiamSat2, DoiTruong, DoiPho, tenkhoa, tenxa
	from
		khoa k,
		xa x, 
 		(select * from doi where MaChienDich = @machiendich) d
	where d.MaKhoa = k.MaKhoa and d.MaXa = x.MaXa) d,

	(select madoi, sosv = count(tvn.masv)
	from 
		ThanhVienNhom tvn
		RIGHT JOIN
		(select madoi, MaNhom from Nhom where madoi in
			(select madoi from doi  where MaChienDich = @machiendich ))d
	ON tvn.MaNhom = d.MaNhom
	group by d.MaDoi
	) demsv
where gs1.MaDoi = d.MaDoi and gs2.MaDoi = d.MaDoi and dt.MaDoi = d.MaDoi and dp.MaDoi =d.MaDoi and d.MaDoi = demsv.MaDoi
end
GO
/****** Object:  StoredProcedure [dbo].[sp_lay_dsphancong_tu_doi]    Script Date: 7/11/2023 4:16:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_lay_dsphancong_tu_doi](@madoi nchar(11), @ngay nvarchar(10), @buoi nvarchar(8))
as
begin
	SET DATEFORMAT DMY
	select MaNhom, TenNhom, Buoi, Ngay, diachi, TenCV, TenAp 
	from
		Ap a,
		Congviec cv,
		nhadan nd,
		(select d.MaNhom, TenNhom, MaNha, Buoi, Ngay, MaCV
		from 
			(SELECT * from PhanCong WHERE Ngay = @ngay AND Buoi = @buoi) pc,
			(select manhom, TenNhom, MaNha from Nhom where MaDoi = @madoi) d
		where pc.MaNhom = d.MaNhom) pc
	where cv.MaCV = pc.MaCV and cv.MaAp = a.MaAp and nd.MaNha = pc.MaNha

end
GO
GRANT EXECUTE ON [dbo].[sp_lay_dsphancong_tu_doi] TO [GIAMSAT] AS [dbo]
GO
/****** Object:  StoredProcedure [dbo].[sp_lay_dssv_chuacodoi_theo_makhoa]    Script Date: 7/11/2023 4:16:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_lay_dssv_chuacodoi_theo_makhoa](@makhoa nchar(5))
as
begin
	select masv, hoten= ho + ' ' + ten, MaKhoa 
	from 
		SinhVien 
	-- chỉ lấy sinh viên theo khoa và không chưa có trong các đội khác
	where MaKhoa = @makhoa and masv not in
		-- lay tất cả sinh viên từ những đội cùng khoa với đội cần thêm
		(select masv
		from 
			ThanhVienNhom 
		where manhom in
			(select MaNhom 
			from 
				nhom 
			where MaDoi in 
				(select MaDoi from Doi where MaKhoa = @makhoa)
			)
		)

end
GO
/****** Object:  StoredProcedure [dbo].[sp_lay_dssv_theo_makhoa]    Script Date: 7/11/2023 4:16:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_lay_dssv_theo_makhoa](@makhoa nchar(5))
as
begin
	select masv, hoten= ho + ' ' + ten, MaKhoa from SinhVien where MaKhoa = @makhoa
end
GO
/****** Object:  StoredProcedure [dbo].[sp_lay_giamsat_chua_tao_taikhoan]    Script Date: 7/11/2023 4:16:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_lay_giamsat_chua_tao_taikhoan]
as
begin
	SET NOCOUNT ON;
	IF 1=0 BEGIN  
        SET FMTONLY OFF  
    END  
	create table #giamsat(
		giamsat nchar(5)
	)
	create table #giamsatcotaikhoan(
		giamsat nchar(5)
	)
	insert into #giamsatcotaikhoan select name from sys.sysusers where issqluser = 1 and hasdbaccess = 1 and name <> 'dbo' and name not like 'N%DCCN%'
	insert into #giamsat  select GiamSat1  from Doi where GiamSat1 not in (select giamsat from #giamsatcotaikhoan)
	insert into #giamsat select GiamSat2  from Doi where GiamSat2 not in (select giamsat from #giamsatcotaikhoan)
	select MaGV, hoten = ho + ' ' + ten from GiangVien where MaGV in (select * from #giamsat)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_lay_giamsat1_them_vao_doi]    Script Date: 7/11/2023 4:16:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_lay_giamsat1_them_vao_doi](@makhoa nchar(5), @ngoaitrumagv nchar(5), @machiendich nchar(7))
as
begin
	if @ngoaitrumagv is null
			set @ngoaitrumagv = ''
	select MaGV, hoten = ho + ' ' + ten 
	from GiangVien 
	where MaKhoa = @makhoa 
	and MaGV <> @ngoaitrumagv 
	and magv not in (select GiamSat1=ISNULL(Giamsat1, '') from doi where MaChienDich = @machiendich) 
	and magv not in (select GiamSat2=ISNULL(Giamsat2, '') from doi where MaChienDich = @machiendich)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_lay_giamsat2_them_vao_doi]    Script Date: 7/11/2023 4:16:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_lay_giamsat2_them_vao_doi](@makhoa nchar(5), @ngoaitrumagv nchar(5), @machiendich nchar(7))
as
begin
	if @ngoaitrumagv is null
				set @ngoaitrumagv = ''
	select MaGV, hoten = ho + ' ' + ten 
	from GiangVien
	where MaKhoa = @makhoa 
		and MaGV <> @ngoaitrumagv
		and magv not in (select GiamSat1=ISNULL(Giamsat1, '')  from doi where MaChienDich = @machiendich) 
		and magv not in (select GiamSat2=ISNULL(Giamsat2, '') from doi where MaChienDich = @machiendich)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_lay_manhom_tenhom_makhoa_tenkhoa_tu_madoi]    Script Date: 7/11/2023 4:16:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_lay_manhom_tenhom_makhoa_tenkhoa_tu_madoi](@madoi nchar(11))
as
begin	
	-- lay nhom temp để thêm tất cả sinh viên trong đội vào trong này
	-- sau đó lấy nhóm này chia ra các nhóm nhỏ khác
	select manhom, TenNhom, MaKhoa, TenKhoa
	from
		(select MaNhom, TenNhom from Nhom where MaDoi = @madoi AND TenNhom = 'Temp') n,
		(select makhoa, tenkhoa from Khoa where makhoa =( select makhoa from Doi where MaDoi = @madoi)) d
end
GO
/****** Object:  StoredProcedure [dbo].[sp_lay_manhom_tenhom_tu_madoi]    Script Date: 7/11/2023 4:16:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_lay_manhom_tenhom_tu_madoi](@madoi nchar(11))
as
begin	
	-- lay nhom temp để thêm tất cả sinh viên trong đội vào trong này
	-- sau đó lấy nhóm này chia ra các nhóm nhỏ khác
	select MaNhom, TenNhom from Nhom where MaDoi = @madoi AND TenNhom = 'Temp'
end
GO
/****** Object:  StoredProcedure [dbo].[sp_lay_nha_chuaconhom_tudoi]    Script Date: 7/11/2023 4:16:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_lay_nha_chuaconhom_tudoi](@madoi nchar(11))
as
begin
	-- cũng có thể xem xét select nhà từ ấp <- xã <- đội
	select MaNha, DiaChi 
	from 
		NhaDan
	where manha not in 
		(select MaNha from Nhom where MaDoi = @madoi)
end
GO
GRANT EXECUTE ON [dbo].[sp_lay_nha_chuaconhom_tudoi] TO [DOIPHO] AS [dbo]
GO
GRANT EXECUTE ON [dbo].[sp_lay_nha_chuaconhom_tudoi] TO [DOITRUONG] AS [dbo]
GO
/****** Object:  StoredProcedure [dbo].[sp_lay_nhom_tu_doi]    Script Date: 7/11/2023 4:16:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_lay_nhom_tu_doi](@madoi nchar(11))
as
begin
	SELECT N.MANHOM, TENNHOM, NHOMTRUONG = HOTEN, TENDOI, TENAP, diachi, SOSVNHOM, MANHOMTRUONG= NhomTruong
	FROM 
		(SELECT MASV, HOTEN = HO +  ' ' + TEN
		FROM 
			SINHVIEN
		WHERE MASV IN 
			-- chưa tối ưu hóa, chỉ nên lấy sinh viên nằm trong đội này
			(SELECT MASV FROM ThanhVienNhom)) SV
		RIGHT JOIN

		(SELECT N.MANHOM, TENNHOM, NHOMTRUONG, TENDOI, TENAP, diachi, SOSVNHOM = 
		CASE
			WHEN sv.MaNhom is NULL THEN 0
			ELSE COUNT(*)
		END
		FROM 
			-- chưa tối ưu hóa, chỉ nên lấy sinh viên nằm trong đội này
			(SELECT MaNhom, masv FROM ThanhVienNhom) SV
			RIGHT JOIN
			(SELECT MANHOM, TENNHOM, NHOMTRUONG, TENDOI, TENAP, diachi
			FROM
				(SELECT MADOI, TENDOI FROM DOI) D,
				(SELECT MAAP, TENAP FROM AP) A, 
				(SELECT MANHOM, TENNHOM, NHOMTRUONG, diachi, MaAp, MaDoi 
				FROM 
					(select manha, diachi, MaAp from NhaDan) nd,
					(select * FROM NHOM WHERE MaDoi = @madoi) n
				where nd.MaNha = n.MaNha) N
			WHERE D.MaDoi = N.MaDoi AND A.MaAp = N.MaAp) N
		ON SV.MaNhom = N.MaNhom
		GROUP BY N.MaNhom, TENNHOM, TENDOI, TENAP, NhomTruong, sv.MaNhom, N.DiaChi) N
	ON N.NhomTruong = SV.MaSV
end
GO
GRANT EXECUTE ON [dbo].[sp_lay_nhom_tu_doi] TO [DOIPHO] AS [dbo]
GO
GRANT EXECUTE ON [dbo].[sp_lay_nhom_tu_doi] TO [DOITRUONG] AS [dbo]
GO
/****** Object:  StoredProcedure [dbo].[sp_lay_nhom_tu_doi_de_chia]    Script Date: 7/11/2023 4:16:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_lay_nhom_tu_doi_de_chia](@madoi nchar(11), @ngoaitrumanhom nchar(5))
as
begin
	select MaNhom, TenNhom from nhom where MaDoi = @madoi and MaNhom <> @ngoaitrumanhom
end
GO
GRANT EXECUTE ON [dbo].[sp_lay_nhom_tu_doi_de_chia] TO [DOIPHO] AS [dbo]
GO
GRANT EXECUTE ON [dbo].[sp_lay_nhom_tu_doi_de_chia] TO [DOITRUONG] AS [dbo]
GO
/****** Object:  StoredProcedure [dbo].[sp_lay_nhom_tu_manhom]    Script Date: 7/11/2023 4:16:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_lay_nhom_tu_manhom](@manhom nchar(5))
as
begin
	select n.masv, hoten, MaNhom
	from 
		(select masv, hoten = ho + ' ' + ten from sinhvien) sv,
		(select MaNhom, masv from ThanhVienNhom where MaNhom= @manhom) n
	where sv.MaSV = n.MaSV
end
GO
GRANT EXECUTE ON [dbo].[sp_lay_nhom_tu_manhom] TO [DOIPHO] AS [dbo]
GO
GRANT EXECUTE ON [dbo].[sp_lay_nhom_tu_manhom] TO [DOITRUONG] AS [dbo]
GO
/****** Object:  StoredProcedure [dbo].[sp_lay_nhomtruong_chua_tao_taikhoan]    Script Date: 7/11/2023 4:16:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_lay_nhomtruong_chua_tao_taikhoan]
as
begin
	SET NOCOUNT ON;
	IF 1=0 BEGIN  
        SET FMTONLY OFF  
    END  
	create table #nt(
		dtdp nchar(10)
	)
	create table #ntcotaikhoan(
		dtdp nchar(10)
	)

	insert into #ntcotaikhoan select name from sys.sysusers where issqluser = 1 and hasdbaccess = 1 and name <> 'dbo' and name not like 'GV%'
	insert into #nt  select NhomTruong  from Nhom where NhomTruong not in (select * from #ntcotaikhoan)
	select MaSV, hoten = ho + ' ' + ten from SinhVien WHERE MASV IN  (select * from #nt)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_lay_xa_tu_chiendich]    Script Date: 7/11/2023 4:16:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_lay_xa_tu_chiendich](@machiendich nchar(7))
as
begin
	select MaXa, TenXa
	from xa
	where MaDiaBan in (select MaDiaBan from ChiTietChienDich where MaChienDich = @machiendich)
		-- moi doi quan li 1 xa nen khi them doi khong cho chon lại xã đã có ở đội khác
		and maxa not in (select maxa from doi where MaChienDich = @machiendich)

end
GO
/****** Object:  StoredProcedure [dbo].[sp_laySinhVienKhenThuongTheoDoi]    Script Date: 7/11/2023 4:16:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_laySinhVienKhenThuongTheoDoi] @madoi nchar(11)
as

begin
	select kt.masv, hoten = ho + ' ' + ten, lydo, danhhieu from 
		sinhvien sv, 
		(select masv, lydo, danhhieu from KhenThuong where MaDoi = @madoi) kt
	where sv.MaSV = kt.MaSV
end
GO
GRANT EXECUTE ON [dbo].[sp_laySinhVienKhenThuongTheoDoi] TO [GIAMSAT] AS [dbo]
GO
/****** Object:  StoredProcedure [dbo].[sp_laySinhVienTuNhom]    Script Date: 7/11/2023 4:16:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_laySinhVienTuNhom] @manhom nchar(5)
as

begin
	declare @nhomTruong nchar(10) = (select NhomTruong from nhom where MaNhom = @manhom)
	select tvn.masv, hoten = ho + ' ' + ten,  MaKhoa ,checkNhomTruong
	from 
		SinhVien sv,
		(select masv, checkNhomTruong =
		case
			when masv = @nhomTruong then 1
			else 0		
		end
		from 
			ThanhVienNhom tvn
		where tvn.MaNhom = @manhom) tvn
	where sv.MaSV = tvn.MaSV
end
GO
GRANT EXECUTE ON [dbo].[sp_laySinhVienTuNhom] TO [GIAMSAT] AS [dbo]
GO
/****** Object:  StoredProcedure [dbo].[Sp_Restore]    Script Date: 7/11/2023 4:16:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Sp_Restore]
@DeviceName Nvarchar(100),
@Position int
as begin
	declare @Type char(1)
	declare @CheckPointLsn Numeric
	declare @DifferentialBaseLsn Numeric
	declare @Cmd Nvarchar(4000)

	-- lay thong tin backup vao bang tam
	select position, type, checkpoint_lsn, differential_base_lsn, first_lsn
	into #tmp
	from msdb.dbo.backupset where media_set_id in ( select media_set_id	from  msdb.dbo.backupmediafamily where logical_device_name = @DeviceName)
	-- lay thong tin cua tep backup can restore
	select @Type = type, @CheckPointLsn = checkpoint_lsn, @DifferentialBaseLsn = differential_base_lsn
	from #tmp where position = @Position

	-- full backup
	if @Type = 'd'
		begin
			set @Cmd = '
			ALTER DATABASE TTCS_MUAHEXANH SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
			RESTORE DATABASE TTCS_MUAHEXANH
			FROM '+ @DeviceName +'
			WITH FILE = '+CAST(@Position AS NVARCHAR(5))+' ,  REPLACE, RECOVERY;'
			print @Cmd
			select @Cmd
			return 0;
		end
	-- else
	declare @LoopPosition int
	set @Cmd = N'RESTORE DATABASE TTCS_MUAHEXANH FROM ' + @DeviceName + N' WITH FILE = '+ CAST(@Position AS NVARCHAR(5))  + N',  REPLACE, RECOVERY;'
	while @Type <> 'd'
		begin
			declare @tmpCommand Nvarchar(4000)
			-- pre backup file info
			if @DifferentialBaseLsn is not null
				begin
					select @Position=position, @Type = type, @CheckPointLsn = checkpoint_lsn, @DifferentialBaseLsn = differential_base_lsn
					from #tmp where first_lsn = @DifferentialBaseLsn
				end
			else
				begin
					select @Position=position, @Type = type, @CheckPointLsn = checkpoint_lsn, @DifferentialBaseLsn = differential_base_lsn
					from #tmp where first_lsn = @CheckPointLsn
				end
			-- set tmp command
			if @Type = 'l'
				begin
					set @tmpCommand = N'RESTORE LOG TTCS_MUAHEXANH FROM ' + @DeviceName + N' WITH FILE = '+  CAST(@Position AS NVARCHAR(5))  + N',  REPLACE, NORECOVERY;'
				end
			else
				begin
					set @tmpCommand = N'RESTORE DATABASE TTCS_MUAHEXANH FROM ' + @DeviceName + N' WITH FILE = '+  CAST(@Position AS NVARCHAR(5))  + N',  REPLACE, NORECOVERY;'
				end
			-- set command
			set @Cmd = @tmpCommand + ' ' + @Cmd
		end
		-- final command
		set @Cmd = N'ALTER DATABASE TTCS_MUAHEXANH SET SINGLE_USER WITH ROLLBACK IMMEDIATE;' + ' ' + @Cmd;

		print @Cmd

		select @Cmd

end
GO
/****** Object:  StoredProcedure [dbo].[Sp_RestoreDatabaseTTCS_MUAHEXANH]    Script Date: 7/11/2023 4:16:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Sp_RestoreDatabaseTTCS_MUAHEXANH]
@DeviceName Nvarchar(100),
@Position int
as begin
	declare @Type char(1)
	declare @CheckPointLsn Numeric
	declare @DifferentialBaseLsn Numeric
	declare @Cmd Nvarchar(4000)

	-- lay thong tin backup vao bang tam
	select position, type, checkpoint_lsn, differential_base_lsn, first_lsn
	into #tmp
	from msdb.dbo.backupset where media_set_id in ( select media_set_id	from  msdb.dbo.backupmediafamily where logical_device_name = @DeviceName)
	-- lay thong tin cua tep backup can restore
	select @Type = type, @CheckPointLsn = checkpoint_lsn, @DifferentialBaseLsn = differential_base_lsn
	from #tmp where position = @Position

	-- full backup
	if @Type = 'd'
		begin
			set @Cmd = '
			ALTER DATABASE TTCS_MUAHEXANH SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
			RESTORE DATABASE TTCS_MUAHEXANH
			FROM '+ @DeviceName +'
			WITH FILE = '+CAST(@Position AS NVARCHAR(5))+' ,  REPLACE, RECOVERY;'
			print @Cmd
			
			begin try
				exec(@Cmd)
				return 0
			end try
			begin catch
				raiserror('Thực thi câu lệnh restore thất bại',16,1)
				return 1
			end catch
			
		end
	-- else
	declare @LoopPosition int
	set @Cmd = N'RESTORE DATABASE TTCS_MUAHEXANH FROM ' + @DeviceName + N' WITH FILE = '+ CAST(@Position AS NVARCHAR(5))  + N',  REPLACE, RECOVERY;'
	while @Type <> 'd'
		begin
			declare @tmpCommand Nvarchar(4000)
			-- pre backup file info
			if @DifferentialBaseLsn is not null
				begin
					select @Position=position, @Type = type, @CheckPointLsn = checkpoint_lsn, @DifferentialBaseLsn = differential_base_lsn
					from #tmp where first_lsn = @DifferentialBaseLsn
				end
			else
				begin
					select @Position=position, @Type = type, @CheckPointLsn = checkpoint_lsn, @DifferentialBaseLsn = differential_base_lsn
					from #tmp where first_lsn = @CheckPointLsn
				end
			-- set tmp command
			if @Type = 'l'
				begin
					set @tmpCommand = N'RESTORE LOG TTCS_MUAHEXANH FROM ' + @DeviceName + N' WITH FILE = '+  CAST(@Position AS NVARCHAR(5))  + N',  REPLACE, NORECOVERY;'
				end
			else
				begin
					set @tmpCommand = N'RESTORE DATABASE TTCS_MUAHEXANH FROM ' + @DeviceName + N' WITH FILE = '+  CAST(@Position AS NVARCHAR(5))  + N',  REPLACE, NORECOVERY;'
				end
			-- set command
			set @Cmd = @tmpCommand + ' ' + @Cmd
		end
		-- final command
		set @Cmd = N'ALTER DATABASE TTCS_MUAHEXANH SET SINGLE_USER WITH ROLLBACK IMMEDIATE;' + ' ' + @Cmd;

		print @Cmd

		
			begin try
				exec(@Cmd)
				return 0
			end try
			begin catch
				raiserror('Thực thi câu lệnh restore thất bại',16,1)
				return 1
			end catch

end
GO
/****** Object:  StoredProcedure [dbo].[SP_TaoLogin]    Script Date: 7/11/2023 4:16:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_TaoLogin]
  @LGNAME VARCHAR(50),
  @PASS VARCHAR(50),
  @USERNAME VARCHAR(50),
  @ROLE VARCHAR(50)
AS
  DECLARE @RET INT
  EXEC @RET= SP_ADDLOGIN @LGNAME, @PASS,'TTCS_MUAHEXANH'
  IF (@RET =1)  -- LOGIN NAME BI TRUNG
     RETURN 1
 
  EXEC @RET= SP_GRANTDBACCESS @LGNAME, @USERNAME
  IF (@RET =1)  -- USER  NAME BI TRUNG
  BEGIN
       EXEC SP_DROPLOGIN @LGNAME
       RETURN 2
  END
  EXEC sp_addrolemember @ROLE, @USERNAME
  IF @ROLE= 'KHOA'
  BEGIN 
    EXEC sp_addsrvrolemember @LGNAME, 'SecurityAdmin'
  END
  Exec sp_defaultdb @loginame=@LGNAME, @defdb='TTCS_MUAHEXANH' 
RETURN 0  -- THANH CONG
GO
/****** Object:  StoredProcedure [dbo].[sp_them_nhom_moi_sau_khi_them_doi]    Script Date: 7/11/2023 4:16:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_them_nhom_moi_sau_khi_them_doi](@tennhom nvarchar(50), @madoi nchar(11), @manha nchar(7), @doitruong nchar(10), @doipho nchar(10))
as
begin


	BEGIN TRAN

    BEGIN TRY
		insert into nhom
		values('n', @tennhom, @doitruong, @madoi, @manha)
	
		declare @manhomcuoi nchar(5) = (select TOP 1 MaNhom from nhom with(index(PK_NHOM)))

		insert into ThanhVienNhom
		values
		(@manhomcuoi, @doitruong),
		(@manhomcuoi, @doipho)

    END TRY
    BEGIN CATCH
        Raiserror(N'Thêm nhóm mới cho đội không thành công! Vui lòng kiểm lại thông tin đội!',16,1) 
        ROLLBACK TRAN
    END CATCH

    COMMIT TRAN

end
GO
/****** Object:  StoredProcedure [dbo].[Sp_ThemChiTietChienDich]    Script Date: 7/11/2023 4:16:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Sp_ThemChiTietChienDich]
	-- Add the parameters for the stored procedure here
	@MaChienDich nchar(7),
	@MaDiaBan nchar(4)
AS
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	BEGIN TRY
    	BEGIN TRANSACTION
			INSERT INTO ChiTietChienDich(MaChienDich, MaDiaBan) VALUES(@MaChienDich, @MaDiaBan)
		COMMIT TRANSACTION
		RETURN 0;
	END TRY
	BEGIN CATCH
		IF @@TRANCOUNT > 0
			ROLLBACK TRANSACTION
		RETURN 1
	END CATCH
END
GO
GRANT EXECUTE ON [dbo].[Sp_ThemChiTietChienDich] TO [ADMIN] AS [dbo]
GO
/****** Object:  StoredProcedure [dbo].[sp_voHieuTaiKhoan]    Script Date: 7/11/2023 4:16:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[sp_voHieuTaiKhoan](@taiKhoan TYPE_KHOIPHUCTAIKHOAN READONLY)
AS
BEGIN
	declare @cmd nvarchar(max)
	set @cmd = (select STRING_AGG('ALTER LOGIN ' + QUOTENAME(lgname) + ' disable;',' ') from
	-- (SELECT name, is_disabled FROM sys.server_principals where is_disabled = 1 and name not like N'##MS_%##') dd
	@taiKhoan)
	--print(@cmd)
	exec(@cmd)
END
GO
/****** Object:  StoredProcedure [dbo].[sp_xemThoiGianLamViec]    Script Date: 7/11/2023 4:16:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_xemThoiGianLamViec](@manhom nchar(5), @ngay date)
as
begin
	select TenCV, buoi, TenAp from CongViec cv, ap a,
	(select macv, Buoi from PhanCong where Ngay = @ngay and MaNhom = @manhom) pc
	where pc.MaCV = cv.MaCV and a.MaAp = cv.MaAp
end
GO
GRANT EXECUTE ON [dbo].[sp_xemThoiGianLamViec] TO [NHOMTRUONG] AS [dbo]
GO
/****** Object:  StoredProcedure [dbo].[Sp_XoaChiTietChienDich]    Script Date: 7/11/2023 4:16:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Sp_XoaChiTietChienDich]
	-- Add the parameters for the stored procedure here
	@MaChienDich nchar(7),
	@MaDiaBan nchar(4)
AS
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.

		SET NOCOUNT ON;
		BEGIN TRY
    		BEGIN TRANSACTION
					DELETE FROM ChiTietChienDich WHERE MaChienDich = @MaChienDich AND MaDiaBan = @MaDiaBan
			COMMIT TRANSACTION
			RETURN 0;
		END TRY
		BEGIN CATCH
			IF @@TRANCOUNT > 0
				ROLLBACK TRANSACTION
			RETURN 1
		END CATCH
END
GO
GRANT EXECUTE ON [dbo].[Sp_XoaChiTietChienDich] TO [ADMIN] AS [dbo]
GO
/****** Object:  StoredProcedure [dbo].[SP_XoaLogin]    Script Date: 7/11/2023 4:16:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_XoaLogin]
  (@taiKhoan TYPE_KHOIPHUCTAIKHOAN READONLY)
  
AS
	declare @cmd nvarchar(max)
	set @cmd = (select STRING_AGG('EXEC SP_DROPUSER ' + QUOTENAME(lgname) + '; EXEC SP_DROPLOGIN'  + QUOTENAME(lgname) + '; ',' ') from
	-- (SELECT name, is_disabled FROM sys.server_principals where is_disabled = 1 and name not like N'##MS_%##') dd
	@taiKhoan)
	--print(@cmd)
	exec(@cmd)
GO
/****** Object:  Trigger [dbo].[Tgr_TuSinhMaAp]    Script Date: 7/11/2023 4:16:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[Tgr_TuSinhMaAp]
ON [dbo].[Ap]
INSTEAD OF INSERT
AS
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
BEGIN
	BEGIN TRANSACTION
			BEGIN TRY
				DECLARE @MaAp varchar(5)

				DECLARE @MaApLonNhat INT

				-- Add the T-SQL statements to compute the return value here
				SELECT @MaAp = MAX(MaAp)
				FROM Ap


				SET @MaApLonNhat = CAST(SUBSTRING(@MaAp, 2, LEN(@MaAp)) AS INT)

				IF @MaApLonNhat IS NULL
					SET @MaApLonNhat = 0

				SET @MaApLonNhat = @MaApLonNhat + 1

				SET @MaAp = 'A' + RIGHT('000' + CAST(@MaApLonNhat AS varchar(3)), 3)

				-- Return the result of the function
				
				INSERT INTO Ap
				SELECT MaAp = @MaAp,TenAp, MaXa FROM inserted
				COMMIT TRANSACTION
			END TRY
			BEGIN CATCH
				RAISERROR('Không thể thêm', 16,1);
				ROLLBACK TRANSACTION
			END CATCH
	
END
GO
ALTER TABLE [dbo].[Ap] ENABLE TRIGGER [Tgr_TuSinhMaAp]
GO
/****** Object:  Trigger [dbo].[Tgr_TuSinhMaChienDich]    Script Date: 7/11/2023 4:16:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[Tgr_TuSinhMaChienDich]
ON [dbo].[ChienDich]
INSTEAD OF INSERT
AS
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
BEGIN
	BEGIN TRANSACTION
			BEGIN TRY
				DECLARE @MaChienDich nchar(4)

				DECLARE @MaChienDichLonNhat INT

				-- Add the T-SQL statements to compute the return value here
				SELECT @MaChienDich = MAX(MaChienDich)
				FROM ChienDich

				SET @MaChienDichLonNhat = CAST(SUBSTRING(@MaChienDich, 3, 2) AS INT)

				IF @MaChienDichLonNhat IS NULL
					SET @MaChienDichLonNhat = 0

				SET @MaChienDichLonNhat = @MaChienDichLonNhat + 1

				IF @MaChienDichLonNhat < 10
					SET @MaChienDich = 'CD0' + CAST(@MaChienDichLonNhat AS NCHAR)
				ELSE
					SET @MaChienDich = 'CD' + CAST(@MaChienDichLonNhat AS NCHAR)

				-- Return the result of the function
				
				INSERT INTO ChienDich
				--VALUES(@MaChienDich, (SELECT TenChienDich FROM inserted), (SELECT NgayPhatDong FROM inserted), (SELECT NgayKetThuc FROM inserted))
				SELECT MaChienDich= @MaChienDich,TenChienDich,NgayPhatDong,NgayKetThuc FROM inserted
			END TRY
			BEGIN CATCH
				RAISERROR('Không thể thêm', 16,1);
				ROLLBACK TRANSACTION
			END CATCH
	COMMIT TRANSACTION
END
GO
ALTER TABLE [dbo].[ChienDich] ENABLE TRIGGER [Tgr_TuSinhMaChienDich]
GO
/****** Object:  Trigger [dbo].[Tgr_TuSinhMaCongViec]    Script Date: 7/11/2023 4:16:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create TRIGGER [dbo].[Tgr_TuSinhMaCongViec]
ON [dbo].[CongViec]
INSTEAD OF INSERT
AS
BEGIN
	SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
	BEGIN TRANSACTION
		BEGIN TRY
			INSERT INTO CongViec(MaCV, TenCV, NgayBatDau, NgayKetThuc, MaAp)
			VALUES(dbo.Fc_SinhMaCongViec(), (SELECT TenCV FROM inserted), (SELECT NgayBatDau FROM inserted), (SELECT NgayKetThuc FROM inserted), (SELECT MaAp FROM inserted))
		END TRY
		BEGIN CATCH
			RAISERROR('Không thể thêm', 16,1);
			ROLLBACK TRANSACTION
		END CATCH
	COMMIT TRANSACTION
END


GO
ALTER TABLE [dbo].[CongViec] ENABLE TRIGGER [Tgr_TuSinhMaCongViec]
GO
/****** Object:  Trigger [dbo].[trg_tuSinhMaDiaBan]    Script Date: 7/11/2023 4:16:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE trigger [dbo].[trg_tuSinhMaDiaBan] on [dbo].[DiaBan]
instead of insert
as
begin

	DECLARE @MADB NVARCHAR(11), @MACUOI int = (SELECT TOP 1 SUBSTRING(MaDiaBan,3, LEN(MaDiaBan)) FROM DiaBan WITH(INDEX(PK_MADIABAN)))
		
		-- lay ma cuoi cung trong danh sach, tang ma do len
		SET @MACUOI += 1
		IF @MACUOI < 10
			SET @MADB = 'DB0' + cast (@MACUOI as VARCHAR)
		ELSE IF @MACUOI between 10 and 99
			SET @MADB = 'DB' + cast (@MACUOI as VARCHAR)
		INSERT 
		INTO DiaBan
		SELECT @MADB, TenDiaBan
		FROM inserted
end
GO
ALTER TABLE [dbo].[DiaBan] ENABLE TRIGGER [trg_tuSinhMaDiaBan]
GO
/****** Object:  Trigger [dbo].[trg_insert_doipho]    Script Date: 7/11/2023 4:16:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[trg_insert_doipho] on [dbo].[Doi]
for insert, update
as
	IF @@ROWCOUNT = 0 
		RETURN
	if Exists (select d.MaDoi from doi d, inserted ir where d.MaChienDich = ir.MaChienDich and d.DoiTruong = ir.DoiPho)
	BEGIN
		RAISERROR(N'Đội phó đã có trong đội khác trong chiến dịch! Vui lòng chọn giám sát khác ',16,1)
		ROLLBACK TRANSACTION;  
		RETURN   
	END
GO
ALTER TABLE [dbo].[Doi] ENABLE TRIGGER [trg_insert_doipho]
GO
/****** Object:  Trigger [dbo].[trg_insert_doitruong]    Script Date: 7/11/2023 4:16:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[trg_insert_doitruong] on [dbo].[Doi]
for insert, update 
as
	IF @@ROWCOUNT = 0 
		RETURN
	if Exists (select d.MaDoi from doi d, inserted ir where d.MaChienDich = ir.MaChienDich and d.DoiPho = ir.DoiTruong)
	BEGIN
		RAISERROR(N'Đội trưởng đã có trong đội khác trong chiến dịch! Vui lòng chọn giám sát khác ',16,1)
		ROLLBACK TRANSACTION;  
		RETURN   
	END
GO
ALTER TABLE [dbo].[Doi] ENABLE TRIGGER [trg_insert_doitruong]
GO
/****** Object:  Trigger [dbo].[trg_insert_giamsat1]    Script Date: 7/11/2023 4:16:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[trg_insert_giamsat1] on [dbo].[Doi]
for insert, update 
as
	IF @@ROWCOUNT = 0 
		RETURN
	if Exists (select d.MaDoi from doi d, inserted ir where d.MaChienDich = ir.MaChienDich and d.GiamSat2 = ir.GiamSat1)
	BEGIN
		RAISERROR(N'Giám sát 1 đã giám sát đội khác trong chiến dịch! Vui lòng chọn giám sát khác ',16,1)
		ROLLBACK TRANSACTION;  
		RETURN   
	END
GO
ALTER TABLE [dbo].[Doi] ENABLE TRIGGER [trg_insert_giamsat1]
GO
/****** Object:  Trigger [dbo].[trg_insert_giamsat2]    Script Date: 7/11/2023 4:16:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[trg_insert_giamsat2] on [dbo].[Doi]
for insert, update
as
	IF @@ROWCOUNT = 0 
		RETURN
	if Exists (select d.MaDoi from doi d, inserted ir where d.MaChienDich = ir.MaChienDich and d.GiamSat1 = ir.GiamSat2)
	BEGIN
		RAISERROR(N'Giám sát 2 đã giám sát đội khác trong chiến dịch! Vui lòng chọn giám sát khác ',16,1)
		ROLLBACK TRANSACTION;  
		RETURN   
	END
GO
ALTER TABLE [dbo].[Doi] ENABLE TRIGGER [trg_insert_giamsat2]
GO
/****** Object:  Trigger [dbo].[trg_kiemTraDoiTruongDoiPhoCoTrongNhom]    Script Date: 7/11/2023 4:16:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create trigger [dbo].[trg_kiemTraDoiTruongDoiPhoCoTrongNhom] on [dbo].[Doi]
for update 
as begin
	IF @@ROWCOUNT = 0 
			RETURN
	declare @madoi nchar(11) = (select madoi from inserted)
	if not Exists (select doitruong, DoiPho from inserted, (select masv from thanhviennhom where manhom in (select MaNhom from nhom n where n.MaDoi = @madoi)) tvn where inserted.doitruong = tvn.MaSV or inserted.DoiPho = tvn.MaSV)
	BEGIN
		RAISERROR('Đội trưởng này chưa có trong nhóm',16,1)
		ROLLBACK TRANSACTION;  
		RETURN   
	END
end
GO
ALTER TABLE [dbo].[Doi] DISABLE TRIGGER [trg_kiemTraDoiTruongDoiPhoCoTrongNhom]
GO
/****** Object:  Trigger [dbo].[trg_tuDongSinhMaDoi]    Script Date: 7/11/2023 4:16:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[trg_tuDongSinhMaDoi]
ON [dbo].[Doi]
INSTEAD OF INSERT
AS
BEGIN

	BEGIN TRAN

    BEGIN TRY
		--Tự sinh mã đội dạng MHX2023X, x là số tự tăng
		DECLARE @MADOI NVARCHAR(11), @TENDOI NVARCHAR(50), @GIAMSAT1 NCHAR(5),
		@GIAMSAT2 NCHAR(5), @MACHIENDICH NCHAR(7),
		@MAKHOA NCHAR(5) ,@MAXA NCHAR(4), @MACUOI int = (SELECT TOP 1 SUBSTRING(MADOI,6, LEN(MADOI)) FROM DOI WITH(INDEX(PK_DOI)))
		
		-- lay ma cuoi cung trong danh sach, tang ma do len
		SET @MACUOI += 1
		SET @MADOI = 'D' + CAST(YEAR(GETDATE()) AS CHAR(4))
		IF @MACUOI < 10
			SET @MADOI = @MADOI + '000' + cast (@MACUOI as VARCHAR)
		ELSE IF @MACUOI between 10 and 99
			SET @MADOI = @MADOI +'00' + cast (@MACUOI as VARCHAR)
		ELSE IF @MACUOI between 100 and 999
			SET @MADOI = @MADOI + '0' + cast (@MACUOI as VARCHAR)
		ELSE IF @MACUOI between 1000 and 9999
			SET @MADOI = @MADOI + cast (@MACUOI as VARCHAR)
		
		
		SELECT @TENDOI = TenDoi, @GIAMSAT1 = GiamSat1, @GIAMSAT2 = GiamSat2, 
	 @MACHIENDICH = MaChienDich, @MAKHOA = MaKhoa,  @MAXA = MaXa
		FROM inserted
		INSERT 
		INTO DOI(MaDoi, TenDoi, GiamSat1, GiamSat2, MaChienDich, MaKhoa, MaXa)
		VALUES(@MADOI, @TENDOI, @GIAMSAT1, @GIAMSAT2, @MACHIENDICH, @MAKHOA, @MAXA)

		declare @maNha nchar(7) = (select TOP 1 MaNha from NhaDan WHERE maap in (select maap from ap where maxa = @MAXA) )
		--and MaNha not in (select manha from Nhom where MaDoi like CAST(@MADOI AS CHAR(5)) + '%'))
		--PRINT @MANHA
		--if (@maNha is null)
		--	begin
		--		Raiserror(N'Không còn trống nhà trống! Không thể thêm đội!',16,1) 
		--		ROLLBACK TRAN
		--		RETURN
		--	end
		
		INSERT iNTO NHOM
		VALUES('1', 'temp',null,@MADOI, @maNha)
		COMMIT TRAN
	END TRY
    BEGIN CATCH
        Raiserror(N'Thêm đội không thành công! Không còn nhà trống trong xã này! Vui lòng chọn xã khác!',16,1) 
        ROLLBACK TRAN
    END CATCH
    
	

END
GO
ALTER TABLE [dbo].[Doi] ENABLE TRIGGER [trg_tuDongSinhMaDoi]
GO
/****** Object:  Trigger [dbo].[trg_rangBuocSoSVkhenThuong]    Script Date: 7/11/2023 4:16:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE trigger [dbo].[trg_rangBuocSoSVkhenThuong] on [dbo].[KhenThuong]
for insert
as
begin
	declare @sosv int = (select count(kt.MaSV) from khenthuong kt, inserted  where kt.madoi = inserted.madoi group by kt.madoi)
	if (@sosv > 5)
		begin
			RAISERROR('Một đội khen thưởng tối đa 5 sinh viên!',16,1)
			ROLLBACK
			RETURN
		end
	
end
GO
ALTER TABLE [dbo].[KhenThuong] ENABLE TRIGGER [trg_rangBuocSoSVkhenThuong]
GO
/****** Object:  Trigger [dbo].[trg_tuSinhMaNhaDan]    Script Date: 7/11/2023 4:16:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create trigger [dbo].[trg_tuSinhMaNhaDan] on [dbo].[NhaDan]
instead of insert
as
begin

	DECLARE @MANHA NVARCHAR(7), @MACUOI int = (SELECT TOP 1 SUBSTRING(manha,4, LEN(manha)) FROM NhaDan WITH(INDEX(PK_MaNha)))
		
		-- lay ma cuoi cung trong danh sach, tang ma do len
		SET @MACUOI += 1
		IF @MACUOI < 10
			SET @MANHA = 'Nha000' + cast (@MACUOI as VARCHAR)
		ELSE IF @MACUOI between 10 and 99
			SET @MANHA = 'Nha00' + cast (@MACUOI as VARCHAR)
		ELSE IF @MACUOI between 100 and 999
			SET @MANHA = 'Nha0' + cast (@MACUOI as VARCHAR)
		ELSE IF @MACUOI between 1000 and 9999
			SET @MANHA = 'Nha' + cast (@MACUOI as VARCHAR)
		INSERT 
		INTO nhadan
		SELECT @MANHA, diachi, sdt, chuho, maap 
		FROM inserted
end
GO
ALTER TABLE [dbo].[NhaDan] ENABLE TRIGGER [trg_tuSinhMaNhaDan]
GO
/****** Object:  Trigger [dbo].[trg_kiemTraNhomTruongCoTrongNhom]    Script Date: 7/11/2023 4:16:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create trigger [dbo].[trg_kiemTraNhomTruongCoTrongNhom] on [dbo].[Nhom]
for update 
as begin
	IF @@ROWCOUNT = 0 
			RETURN
	if not Exists (select nhomtruong from inserted, ThanhVienNhom tvn where inserted.NhomTruong = tvn.MaSV and inserted.MaNhom = tvn.MaNhom)
	BEGIN
		RAISERROR('Nhóm trưởng này chưa có trong nhóm',16,1)
		ROLLBACK TRANSACTION;  
		RETURN   
	END
end
GO
ALTER TABLE [dbo].[Nhom] ENABLE TRIGGER [trg_kiemTraNhomTruongCoTrongNhom]
GO
/****** Object:  Trigger [dbo].[trg_tuDongSinhMaNhom]    Script Date: 7/11/2023 4:16:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[trg_tuDongSinhMaNhom]
ON [dbo].[Nhom]
INSTEAD OF INSERT
	AS
BEGIN
	BEGIN TRAN
	
    BEGIN TRY
		--Tự sinh mã đội dạng MHX2023X, x là số tự tăng
		DECLARE @MANHOM NCHAR(5), @TENNHOM NVARCHAR(50),
		@MADOI NCHAR(11), @MANHA NCHAR(7), @MACUOI int = (SELECT TOP 1 SUBSTRING(MANHOM, 2, LEN(MANHOM)) FROM NHOM)
		
		-- lay ma cuoi cung trong danh sach, tang ma do len
		SET @MACUOI += 1
		--N0001
		IF @MACUOI < 10
			SET @MANHOM = 'N000' + cast (@MACUOI as VARCHAR)
		ELSE IF @macuoi between 10 and 99
			SET @MANHOM = 'N00' + cast (@MACUOI as VARCHAR)
		ELSE IF @macuoi between 100 and 999
			SET @MANHOM = 'N0' + cast (@MACUOI as VARCHAR)
		ELSE IF @macuoi between 1000 and 9999
			SET @MANHOM = 'N' + cast (@MACUOI as VARCHAR)
		SELECT @TENNHOM = TenNhom, @MADOI = MaDoi, 
		@MANHA= MaNha
		FROM inserted
		
		INSERT INTO NHOM (MaNhom, TenNhom, MaDoi, MaNha)
		VALUES(@MANHOM, @TENNHOM, @MADOI, @MANHA)
		COMMIT TRAN
    END TRY
    BEGIN CATCH
        Raiserror(N'Thêm nhóm không thành công! Vui lòng kiểm lại!',16,1) 
        ROLLBACK TRAN
    END CATCH
   
	

END
GO
ALTER TABLE [dbo].[Nhom] ENABLE TRIGGER [trg_tuDongSinhMaNhom]
GO
/****** Object:  Trigger [dbo].[trg_thayDoiFormatDateKhiChen]    Script Date: 7/11/2023 4:16:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE trigger [dbo].[trg_thayDoiFormatDateKhiChen] on [dbo].[PhanCong]
instead of insert
as
begin
	SET DATEFORMAT DMY
	DECLARE @ngay nvarchar(10) = (SELECT NGAY FROM INSERTED)
	PRINT @NGAY
	INSERT INTO PHANCONG
	SELECT MaNhom, Buoi, @NGAY, MaCV FROM inserted
end
GO
ALTER TABLE [dbo].[PhanCong] DISABLE TRIGGER [trg_thayDoiFormatDateKhiChen]
GO
/****** Object:  Trigger [dbo].[Tgr_TuSinhMaXa]    Script Date: 7/11/2023 4:16:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[Tgr_TuSinhMaXa]
ON [dbo].[Xa]
INSTEAD OF INSERT
AS
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
BEGIN
	BEGIN TRANSACTION
			BEGIN TRY
				DECLARE @MaXa nchar(5)

				DECLARE @MaXaLonNhat INT

				-- Add the T-SQL statements to compute the return value here
				SELECT @MaXa = MAX(MaXa)
				FROM Xa


				SET @MaXaLonNhat = CAST(SUBSTRING(@MaXa, 2, LEN(@MaXa)) AS INT)

				IF @MaXaLonNhat IS NULL
					SET @MaXaLonNhat = 0

				SET @MaXaLonNhat = @MaXaLonNhat + 1

				SET @MaXa = 'X' + RIGHT('000' + CAST(@MaXaLonNhat AS NVARCHAR(3)), 3)

				-- Return the result of the function
				--print @maxa
				INSERT INTO Xa
				SELECT MaXa= @MaXa,TenXa, MaDiaBan FROM inserted
				COMMIT TRANSACTION
			END TRY
			BEGIN CATCH
				RAISERROR('Không thể thêm', 16,1);
				ROLLBACK TRANSACTION
			END CATCH
	
END
GO
ALTER TABLE [dbo].[Xa] ENABLE TRIGGER [Tgr_TuSinhMaXa]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'1 đội có 2 giám sát khác nhau' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Doi', @level2type=N'CONSTRAINT',@level2name=N'Một đội có 2 giám sát khác nhau'
GO
USE [master]
GO
ALTER DATABASE [TTCS_MUAHEXANH] SET  READ_WRITE 
GO
