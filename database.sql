USE [master]
GO
/****** Object:  Database [MichalDzialekLab5_ZadDom]    Script Date: 20.05.2019 18:45:44 ******/
CREATE DATABASE [MichalDzialekLab5_ZadDom]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MichalDzialekLab5_ZadDom', FILENAME = N'C:\PROGRAMOWANIE\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\MichalDzialekLab5_ZadDom.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'MichalDzialekLab5_ZadDom_log', FILENAME = N'C:\PROGRAMOWANIE\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\MichalDzialekLab5_ZadDom_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [MichalDzialekLab5_ZadDom] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MichalDzialekLab5_ZadDom].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MichalDzialekLab5_ZadDom] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MichalDzialekLab5_ZadDom] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MichalDzialekLab5_ZadDom] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MichalDzialekLab5_ZadDom] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MichalDzialekLab5_ZadDom] SET ARITHABORT OFF 
GO
ALTER DATABASE [MichalDzialekLab5_ZadDom] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [MichalDzialekLab5_ZadDom] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MichalDzialekLab5_ZadDom] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MichalDzialekLab5_ZadDom] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MichalDzialekLab5_ZadDom] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MichalDzialekLab5_ZadDom] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MichalDzialekLab5_ZadDom] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MichalDzialekLab5_ZadDom] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MichalDzialekLab5_ZadDom] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MichalDzialekLab5_ZadDom] SET  DISABLE_BROKER 
GO
ALTER DATABASE [MichalDzialekLab5_ZadDom] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MichalDzialekLab5_ZadDom] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MichalDzialekLab5_ZadDom] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MichalDzialekLab5_ZadDom] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MichalDzialekLab5_ZadDom] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MichalDzialekLab5_ZadDom] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MichalDzialekLab5_ZadDom] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MichalDzialekLab5_ZadDom] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [MichalDzialekLab5_ZadDom] SET  MULTI_USER 
GO
ALTER DATABASE [MichalDzialekLab5_ZadDom] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MichalDzialekLab5_ZadDom] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MichalDzialekLab5_ZadDom] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MichalDzialekLab5_ZadDom] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [MichalDzialekLab5_ZadDom] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [MichalDzialekLab5_ZadDom] SET QUERY_STORE = OFF
GO
USE [MichalDzialekLab5_ZadDom]
GO
/****** Object:  Table [dbo].[AutomatyOddechowe]    Script Date: 20.05.2019 18:45:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AutomatyOddechowe](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](127) NOT NULL,
	[Type] [nvarchar](127) NOT NULL,
	[Description] [nvarchar](127) NOT NULL,
	[Price] [decimal](18, 0) NOT NULL,
	[Photo] [nvarchar](127) NOT NULL,
	[UniqueID] [nvarchar](127) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[AutomatyView]    Script Date: 20.05.2019 18:45:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[AutomatyView] AS
SELECT AutomatyOddechowe.Name, AutomatyOddechowe.Type, AutomatyOddechowe.Description, AutomatyOddechowe.Price, AutomatyOddechowe.Photo, AutomatyOddechowe.UniqueID FROM AutomatyOddechowe;
GO
/****** Object:  Table [dbo].[Boje]    Script Date: 20.05.2019 18:45:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Boje](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](127) NOT NULL,
	[Type] [nvarchar](127) NOT NULL,
	[Description] [nvarchar](127) NOT NULL,
	[Price] [decimal](18, 0) NOT NULL,
	[Photo] [nvarchar](127) NOT NULL,
	[UniqueID] [nvarchar](127) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[BojeView]    Script Date: 20.05.2019 18:45:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[BojeView] AS
SELECT Boje.Name, Boje.Type, Boje.Description, Boje.Price, Boje.Photo, Boje.UniqueID FROM Boje;
GO
/****** Object:  Table [dbo].[Butle]    Script Date: 20.05.2019 18:45:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Butle](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](127) NOT NULL,
	[Type] [nvarchar](127) NOT NULL,
	[Description] [nvarchar](127) NOT NULL,
	[Price] [decimal](18, 0) NOT NULL,
	[Photo] [nvarchar](127) NOT NULL,
	[UniqueID] [nvarchar](127) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[ButleView]    Script Date: 20.05.2019 18:45:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[ButleView] AS
SELECT Butle.Name, Butle.Type, Butle.Description, Butle.Price, Butle.Photo, Butle.UniqueID FROM Butle;
GO
/****** Object:  Table [dbo].[Kamizelki]    Script Date: 20.05.2019 18:45:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kamizelki](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](127) NOT NULL,
	[Type] [nvarchar](127) NOT NULL,
	[Description] [nvarchar](127) NOT NULL,
	[Price] [decimal](18, 0) NOT NULL,
	[Photo] [nvarchar](127) NOT NULL,
	[UniqueID] [nvarchar](127) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[KamizelkiView]    Script Date: 20.05.2019 18:45:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[KamizelkiView] AS
SELECT Kamizelki.Name, Kamizelki.Type, Kamizelki.Description, Kamizelki.Price, Kamizelki.Photo, Kamizelki.UniqueID FROM Kamizelki;
GO
/****** Object:  Table [dbo].[Skafandry]    Script Date: 20.05.2019 18:45:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Skafandry](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](127) NOT NULL,
	[Type] [nvarchar](127) NOT NULL,
	[Description] [nvarchar](127) NOT NULL,
	[Price] [decimal](18, 0) NOT NULL,
	[Photo] [nvarchar](127) NOT NULL,
	[UniqueID] [nvarchar](127) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[SkafandryView]    Script Date: 20.05.2019 18:45:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[SkafandryView] AS
SELECT Skafandry.Name, Skafandry.Type, Skafandry.Description, Skafandry.Price, Skafandry.Photo, Skafandry.UniqueID FROM Skafandry;
GO
/****** Object:  Table [dbo].[UserActivity]    Script Date: 20.05.2019 18:45:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserActivity](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](127) NOT NULL,
	[Type] [nvarchar](127) NOT NULL,
	[Description] [nvarchar](127) NOT NULL,
	[Price] [decimal](18, 0) NOT NULL,
	[Photo] [nvarchar](127) NOT NULL,
	[UniqueID] [nvarchar](127) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[AutomatyOddechowe] ON 

INSERT [dbo].[AutomatyOddechowe] ([ID], [Name], [Type], [Description], [Price], [Photo], [UniqueID]) VALUES (1, N'Omen', N'Automat oddechowy', N'Najtańsza i najprostrza wersja automatu oddechowego do nurkowania', CAST(1200 AS Decimal(18, 0)), N'~/images/Aut.Oddech/1.jpg', N'1')
INSERT [dbo].[AutomatyOddechowe] ([ID], [Name], [Type], [Description], [Price], [Photo], [UniqueID]) VALUES (2, N'Tech', N'Automat oddechowy', N'Średniej jakości i droższa wersja aparatu oddechowego do nurkowania', CAST(2500 AS Decimal(18, 0)), N'~/images/Aut.Oddech/2.jpg', N'2')
INSERT [dbo].[AutomatyOddechowe] ([ID], [Name], [Type], [Description], [Price], [Photo], [UniqueID]) VALUES (3, N'Mares', N'Automat oddechowy', N'Najdroższy aparat oddechowy do nurkowania', CAST(4000 AS Decimal(18, 0)), N'~/images/Aut.Oddech/3.jpg', N'3')
SET IDENTITY_INSERT [dbo].[AutomatyOddechowe] OFF
SET IDENTITY_INSERT [dbo].[Boje] ON 

INSERT [dbo].[Boje] ([ID], [Name], [Type], [Description], [Price], [Photo], [UniqueID]) VALUES (1, N'Normalna', N'Boja', N'Boja zwyczajna', CAST(50 AS Decimal(18, 0)), N'~/images/Boje/normalna.jpg', N'1')
INSERT [dbo].[Boje] ([ID], [Name], [Type], [Description], [Price], [Photo], [UniqueID]) VALUES (2, N'Awaryjna', N'Boja', N'Boja awaryjna', CAST(75 AS Decimal(18, 0)), N'~/images/Boje/awaryjna.jpg', N'2')
SET IDENTITY_INSERT [dbo].[Boje] OFF
SET IDENTITY_INSERT [dbo].[Butle] ON 

INSERT [dbo].[Butle] ([ID], [Name], [Type], [Description], [Price], [Photo], [UniqueID]) VALUES (1, N'Szóstka', N'Butla', N'6l butla do nurkowania', CAST(400 AS Decimal(18, 0)), N'~/images/Butle/6l.jpg', N'1')
INSERT [dbo].[Butle] ([ID], [Name], [Type], [Description], [Price], [Photo], [UniqueID]) VALUES (2, N'Dziesiątka', N'Butla', N'10l butla do nurkowania', CAST(1000 AS Decimal(18, 0)), N'~/images/Butle/10l.jpg', N'2')
INSERT [dbo].[Butle] ([ID], [Name], [Type], [Description], [Price], [Photo], [UniqueID]) VALUES (3, N'Piętnastka', N'Butla', N'15l butla do nurkowania', CAST(2300 AS Decimal(18, 0)), N'~/images/Butle/15l.jpg', N'3')
INSERT [dbo].[Butle] ([ID], [Name], [Type], [Description], [Price], [Photo], [UniqueID]) VALUES (4, N'Dwudziestka', N'Butla', N'20l butla do nurkowania', CAST(4000 AS Decimal(18, 0)), N'~/images/Butle/20l.jpg', N'4')
SET IDENTITY_INSERT [dbo].[Butle] OFF
SET IDENTITY_INSERT [dbo].[Kamizelki] ON 

INSERT [dbo].[Kamizelki] ([ID], [Name], [Type], [Description], [Price], [Photo], [UniqueID]) VALUES (1, N'Prestige', N'Jacket', N'Najtańsza i najprostrza wersja kamizelki do nurkowania', CAST(2200 AS Decimal(18, 0)), N'~/images/jacket/1.jpg', N'1')
INSERT [dbo].[Kamizelki] ([ID], [Name], [Type], [Description], [Price], [Photo], [UniqueID]) VALUES (2, N'Beuchat', N'Jacket', N'Średniej jakości i droższa wersja kamizelki do nurkowania', CAST(4200 AS Decimal(18, 0)), N'~/images/jacket/2.jpg', N'2')
INSERT [dbo].[Kamizelki] ([ID], [Name], [Type], [Description], [Price], [Photo], [UniqueID]) VALUES (3, N'Cressi', N'Jacket', N'Najdroższa wersja kamizelki do nurkowania', CAST(6200 AS Decimal(18, 0)), N'~/images/jacket/3.jpg', N'3')
SET IDENTITY_INSERT [dbo].[Kamizelki] OFF
SET IDENTITY_INSERT [dbo].[Skafandry] ON 

INSERT [dbo].[Skafandry] ([ID], [Name], [Type], [Description], [Price], [Photo], [UniqueID]) VALUES (1, N'Mokry', N'Skafander', N'Mokry skafander do nurkowania', CAST(900 AS Decimal(18, 0)), N'~/images/Skafandry/mokry.jpg', N'1')
INSERT [dbo].[Skafandry] ([ID], [Name], [Type], [Description], [Price], [Photo], [UniqueID]) VALUES (2, N'Półsuchy', N'Skafander', N'Półsuchy skafander do nurkowania', CAST(1200 AS Decimal(18, 0)), N'~/images/Skafandry/polsuchy.jpg', N'2')
INSERT [dbo].[Skafandry] ([ID], [Name], [Type], [Description], [Price], [Photo], [UniqueID]) VALUES (3, N'Suchy', N'Skafander', N'Suchy skafander do nurkowania', CAST(2500 AS Decimal(18, 0)), N'~/images/Skafandry/suchy.jpg', N'3')
SET IDENTITY_INSERT [dbo].[Skafandry] OFF
USE [master]
GO
ALTER DATABASE [MichalDzialekLab5_ZadDom] SET  READ_WRITE 
GO
