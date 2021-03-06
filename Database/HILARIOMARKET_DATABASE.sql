USE [master]
GO
/****** Object:  Database [HILARIOMARKET]    Script Date: 20/01/2020 10:32:39 PM ******/
CREATE DATABASE [HILARIOMARKET]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'HILARIOMARKET', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\HILARIOMARKET.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'HILARIOMARKET_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\HILARIOMARKET_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [HILARIOMARKET] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [HILARIOMARKET].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [HILARIOMARKET] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [HILARIOMARKET] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [HILARIOMARKET] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [HILARIOMARKET] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [HILARIOMARKET] SET ARITHABORT OFF 
GO
ALTER DATABASE [HILARIOMARKET] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [HILARIOMARKET] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [HILARIOMARKET] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [HILARIOMARKET] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [HILARIOMARKET] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [HILARIOMARKET] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [HILARIOMARKET] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [HILARIOMARKET] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [HILARIOMARKET] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [HILARIOMARKET] SET  ENABLE_BROKER 
GO
ALTER DATABASE [HILARIOMARKET] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [HILARIOMARKET] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [HILARIOMARKET] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [HILARIOMARKET] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [HILARIOMARKET] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [HILARIOMARKET] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [HILARIOMARKET] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [HILARIOMARKET] SET RECOVERY FULL 
GO
ALTER DATABASE [HILARIOMARKET] SET  MULTI_USER 
GO
ALTER DATABASE [HILARIOMARKET] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [HILARIOMARKET] SET DB_CHAINING OFF 
GO
ALTER DATABASE [HILARIOMARKET] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [HILARIOMARKET] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [HILARIOMARKET] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'HILARIOMARKET', N'ON'
GO
ALTER DATABASE [HILARIOMARKET] SET QUERY_STORE = OFF
GO
USE [HILARIOMARKET]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 20/01/2020 10:32:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HilarioMarket_Company]    Script Date: 20/01/2020 10:32:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HilarioMarket_Company](
	[IdCompany] [int] IDENTITY(1,1) NOT NULL,
	[Description] [nvarchar](max) NULL,
 CONSTRAINT [PK_HilarioMarket_Company] PRIMARY KEY CLUSTERED 
(
	[IdCompany] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HilarioMarket_Customer]    Script Date: 20/01/2020 10:32:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HilarioMarket_Customer](
	[IdCustomer] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[LastName] [nvarchar](max) NULL,
	[FrequentBuyer] [bit] NOT NULL,
 CONSTRAINT [PK_HilarioMarket_Customer] PRIMARY KEY CLUSTERED 
(
	[IdCustomer] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HilarioMarket_Product]    Script Date: 20/01/2020 10:32:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HilarioMarket_Product](
	[IdProduct] [int] IDENTITY(1,1) NOT NULL,
	[Description] [nvarchar](max) NULL,
	[Quantity] [int] NOT NULL,
	[BaseAmount] [float] NOT NULL,
	[MarketAmount] [float] NOT NULL,
	[IdCompany] [int] NOT NULL,
 CONSTRAINT [PK_HilarioMarket_Product] PRIMARY KEY CLUSTERED 
(
	[IdProduct] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HilarioMarket_Purchase]    Script Date: 20/01/2020 10:32:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HilarioMarket_Purchase](
	[IdPurchase] [int] IDENTITY(1,1) NOT NULL,
	[Amount] [float] NOT NULL,
	[IdCustomer] [int] NOT NULL,
 CONSTRAINT [PK_HilarioMarket_Purchase] PRIMARY KEY CLUSTERED 
(
	[IdPurchase] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HilarioMarket_PurchaseDetail]    Script Date: 20/01/2020 10:32:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HilarioMarket_PurchaseDetail](
	[IdPurchaseDetails] [int] IDENTITY(1,1) NOT NULL,
	[IdPurchase] [int] NOT NULL,
	[IdProduct] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
	[UnitPrice] [float] NOT NULL,
	[TotalAmount] [float] NOT NULL,
 CONSTRAINT [PK_HilarioMarket_PurchaseDetail] PRIMARY KEY CLUSTERED 
(
	[IdPurchaseDetails] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HilarioMarket_User]    Script Date: 20/01/2020 10:32:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HilarioMarket_User](
	[IdUser] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[LastName] [nvarchar](max) NULL,
	[UserName] [nvarchar](max) NULL,
	[Password] [nvarchar](max) NULL,
 CONSTRAINT [PK_HilarioMarket_User] PRIMARY KEY CLUSTERED 
(
	[IdUser] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20190914234857_InitialCreate', N'2.2.6-servicing-10079')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20190915142855_initialmigration', N'2.2.6-servicing-10079')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20190915143827_initialmigration2', N'2.2.6-servicing-10079')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20190915144022_initialmigration3', N'2.2.6-servicing-10079')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20190915144120_initialmigration4', N'2.2.6-servicing-10079')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20191214185502_UserAdd', N'2.2.6-servicing-10079')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20191214192647_UserChange', N'2.2.6-servicing-10079')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20191230140203_Resolucion de palabra reservada', N'2.2.6-servicing-10079')
SET IDENTITY_INSERT [dbo].[HilarioMarket_Company] ON 

INSERT [dbo].[HilarioMarket_Company] ([IdCompany], [Description]) VALUES (1, N'Gloria')
INSERT [dbo].[HilarioMarket_Company] ([IdCompany], [Description]) VALUES (2, N'Coca Cola')
INSERT [dbo].[HilarioMarket_Company] ([IdCompany], [Description]) VALUES (3, N'Pepsico')
INSERT [dbo].[HilarioMarket_Company] ([IdCompany], [Description]) VALUES (4, N'Nestle')
INSERT [dbo].[HilarioMarket_Company] ([IdCompany], [Description]) VALUES (5, N'Molitalia')
SET IDENTITY_INSERT [dbo].[HilarioMarket_Company] OFF
SET IDENTITY_INSERT [dbo].[HilarioMarket_Product] ON 

INSERT [dbo].[HilarioMarket_Product] ([IdProduct], [Description], [Quantity], [BaseAmount], [MarketAmount], [IdCompany]) VALUES (1, N'Leche Evaporada', 20, 3, 3.2, 1)
SET IDENTITY_INSERT [dbo].[HilarioMarket_Product] OFF
SET IDENTITY_INSERT [dbo].[HilarioMarket_User] ON 

INSERT [dbo].[HilarioMarket_User] ([IdUser], [Name], [LastName], [UserName], [Password]) VALUES (1, N'Victor Jesus', N'La Rosa Gallegos', N'vlarosa', N'123456')
INSERT [dbo].[HilarioMarket_User] ([IdUser], [Name], [LastName], [UserName], [Password]) VALUES (2, N'Jose Luis', N'Perez Perez', N'jperez', N'123456')
INSERT [dbo].[HilarioMarket_User] ([IdUser], [Name], [LastName], [UserName], [Password]) VALUES (3, N'Jose JuanMartin', N'La Rosa Gallegos', N'vlarosa', N'123456')
SET IDENTITY_INSERT [dbo].[HilarioMarket_User] OFF
/****** Object:  Index [IX_HilarioMarket_Product_IdCompany]    Script Date: 20/01/2020 10:32:39 PM ******/
CREATE NONCLUSTERED INDEX [IX_HilarioMarket_Product_IdCompany] ON [dbo].[HilarioMarket_Product]
(
	[IdCompany] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_HilarioMarket_Purchase_IdCustomer]    Script Date: 20/01/2020 10:32:39 PM ******/
CREATE NONCLUSTERED INDEX [IX_HilarioMarket_Purchase_IdCustomer] ON [dbo].[HilarioMarket_Purchase]
(
	[IdCustomer] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_HilarioMarket_PurchaseDetail_IdProduct]    Script Date: 20/01/2020 10:32:39 PM ******/
CREATE NONCLUSTERED INDEX [IX_HilarioMarket_PurchaseDetail_IdProduct] ON [dbo].[HilarioMarket_PurchaseDetail]
(
	[IdProduct] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_HilarioMarket_PurchaseDetail_IdPurchase]    Script Date: 20/01/2020 10:32:39 PM ******/
CREATE NONCLUSTERED INDEX [IX_HilarioMarket_PurchaseDetail_IdPurchase] ON [dbo].[HilarioMarket_PurchaseDetail]
(
	[IdPurchase] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[HilarioMarket_Product]  WITH CHECK ADD  CONSTRAINT [FK_HilarioMarket_Product_HilarioMarket_Company_IdCompany] FOREIGN KEY([IdCompany])
REFERENCES [dbo].[HilarioMarket_Company] ([IdCompany])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[HilarioMarket_Product] CHECK CONSTRAINT [FK_HilarioMarket_Product_HilarioMarket_Company_IdCompany]
GO
ALTER TABLE [dbo].[HilarioMarket_Purchase]  WITH CHECK ADD  CONSTRAINT [FK_HilarioMarket_Purchase_HilarioMarket_Customer_IdCustomer] FOREIGN KEY([IdCustomer])
REFERENCES [dbo].[HilarioMarket_Customer] ([IdCustomer])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[HilarioMarket_Purchase] CHECK CONSTRAINT [FK_HilarioMarket_Purchase_HilarioMarket_Customer_IdCustomer]
GO
ALTER TABLE [dbo].[HilarioMarket_PurchaseDetail]  WITH CHECK ADD  CONSTRAINT [FK_HilarioMarket_PurchaseDetail_HilarioMarket_Product_IdProduct] FOREIGN KEY([IdProduct])
REFERENCES [dbo].[HilarioMarket_Product] ([IdProduct])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[HilarioMarket_PurchaseDetail] CHECK CONSTRAINT [FK_HilarioMarket_PurchaseDetail_HilarioMarket_Product_IdProduct]
GO
ALTER TABLE [dbo].[HilarioMarket_PurchaseDetail]  WITH CHECK ADD  CONSTRAINT [FK_HilarioMarket_PurchaseDetail_HilarioMarket_Purchase_IdPurchase] FOREIGN KEY([IdPurchase])
REFERENCES [dbo].[HilarioMarket_Purchase] ([IdPurchase])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[HilarioMarket_PurchaseDetail] CHECK CONSTRAINT [FK_HilarioMarket_PurchaseDetail_HilarioMarket_Purchase_IdPurchase]
GO
USE [master]
GO
ALTER DATABASE [HILARIOMARKET] SET  READ_WRITE 
GO
