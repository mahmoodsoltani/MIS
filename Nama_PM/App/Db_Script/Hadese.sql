USE [Nama_MIS]
GO
/****** Object:  ForeignKey [FK_Pm_Hadese_Pm_Hadese_AmalkardSystem]    Script Date: 10/10/2011 00:11:54 ******/
ALTER TABLE [dbo].[Pm_Hadese] DROP CONSTRAINT [FK_Pm_Hadese_Pm_Hadese_AmalkardSystem]
GO
/****** Object:  ForeignKey [FK_Pm_Hadese_Pm_Hadese_Elat]    Script Date: 10/10/2011 00:11:54 ******/
ALTER TABLE [dbo].[Pm_Hadese] DROP CONSTRAINT [FK_Pm_Hadese_Pm_Hadese_Elat]
GO
/****** Object:  ForeignKey [FK_Pm_Hadese_Pm_Hadese_SharayetBoroz]    Script Date: 10/10/2011 00:11:54 ******/
ALTER TABLE [dbo].[Pm_Hadese] DROP CONSTRAINT [FK_Pm_Hadese_Pm_Hadese_SharayetBoroz]
GO
/****** Object:  ForeignKey [FK_Pm_Hadese_Khesarat_Pm_Hadese]    Script Date: 10/10/2011 00:11:54 ******/
ALTER TABLE [dbo].[Pm_Hadese_Khesarat] DROP CONSTRAINT [FK_Pm_Hadese_Khesarat_Pm_Hadese]
GO
/****** Object:  ForeignKey [FK_Pm_Hadese_Khesarat_Pm_Hadese_KhesaratDevice]    Script Date: 10/10/2011 00:11:54 ******/
ALTER TABLE [dbo].[Pm_Hadese_Khesarat] DROP CONSTRAINT [FK_Pm_Hadese_Khesarat_Pm_Hadese_KhesaratDevice]
GO
/****** Object:  ForeignKey [FK_Pm_Hadese_Khesarat_Pm_Hadese_KhesaratType]    Script Date: 10/10/2011 00:11:54 ******/
ALTER TABLE [dbo].[Pm_Hadese_Khesarat] DROP CONSTRAINT [FK_Pm_Hadese_Khesarat_Pm_Hadese_KhesaratType]
GO
/****** Object:  ForeignKey [FK_Pm_Hadese_Pishnahad_Pm_Hadese]    Script Date: 10/10/2011 00:11:54 ******/
ALTER TABLE [dbo].[Pm_Hadese_Pishnahad] DROP CONSTRAINT [FK_Pm_Hadese_Pishnahad_Pm_Hadese]
GO
/****** Object:  Table [dbo].[Pm_Hadese_Khesarat]    Script Date: 10/10/2011 00:11:54 ******/
ALTER TABLE [dbo].[Pm_Hadese_Khesarat] DROP CONSTRAINT [FK_Pm_Hadese_Khesarat_Pm_Hadese]
GO
ALTER TABLE [dbo].[Pm_Hadese_Khesarat] DROP CONSTRAINT [FK_Pm_Hadese_Khesarat_Pm_Hadese_KhesaratDevice]
GO
ALTER TABLE [dbo].[Pm_Hadese_Khesarat] DROP CONSTRAINT [FK_Pm_Hadese_Khesarat_Pm_Hadese_KhesaratType]
GO
DROP TABLE [dbo].[Pm_Hadese_Khesarat]
GO
/****** Object:  Table [dbo].[Pm_Hadese_Pishnahad]    Script Date: 10/10/2011 00:11:54 ******/
ALTER TABLE [dbo].[Pm_Hadese_Pishnahad] DROP CONSTRAINT [FK_Pm_Hadese_Pishnahad_Pm_Hadese]
GO
DROP TABLE [dbo].[Pm_Hadese_Pishnahad]
GO
/****** Object:  Table [dbo].[Pm_Hadese]    Script Date: 10/10/2011 00:11:54 ******/
ALTER TABLE [dbo].[Pm_Hadese] DROP CONSTRAINT [FK_Pm_Hadese_Pm_Hadese_AmalkardSystem]
GO
ALTER TABLE [dbo].[Pm_Hadese] DROP CONSTRAINT [FK_Pm_Hadese_Pm_Hadese_Elat]
GO
ALTER TABLE [dbo].[Pm_Hadese] DROP CONSTRAINT [FK_Pm_Hadese_Pm_Hadese_SharayetBoroz]
GO
DROP TABLE [dbo].[Pm_Hadese]
GO
/****** Object:  Table [dbo].[Pm_Hadese_AmalkardSystem]    Script Date: 10/10/2011 00:11:54 ******/
DROP TABLE [dbo].[Pm_Hadese_AmalkardSystem]
GO
/****** Object:  Table [dbo].[Pm_Hadese_Elat]    Script Date: 10/10/2011 00:11:54 ******/
DROP TABLE [dbo].[Pm_Hadese_Elat]
GO
/****** Object:  Table [dbo].[Pm_Hadese_KhesaratDevice]    Script Date: 10/10/2011 00:11:54 ******/
DROP TABLE [dbo].[Pm_Hadese_KhesaratDevice]
GO
/****** Object:  Table [dbo].[Pm_Hadese_KhesaratType]    Script Date: 10/10/2011 00:11:54 ******/
DROP TABLE [dbo].[Pm_Hadese_KhesaratType]
GO
/****** Object:  Table [dbo].[Pm_Hadese_SharayetBoroz]    Script Date: 10/10/2011 00:11:54 ******/
DROP TABLE [dbo].[Pm_Hadese_SharayetBoroz]
GO
/****** Object:  Table [dbo].[Pm_Hadese_SharayetBoroz]    Script Date: 10/10/2011 00:11:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pm_Hadese_SharayetBoroz](
	[Srl] [int] IDENTITY(1,1) NOT NULL,
	[Sharayet] [nvarchar](50) NULL,
 CONSTRAINT [PK_Pm_Hadese_SharayetBoroz] PRIMARY KEY CLUSTERED 
(
	[Srl] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pm_Hadese_KhesaratType]    Script Date: 10/10/2011 00:11:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pm_Hadese_KhesaratType](
	[Srl] [int] IDENTITY(1,1) NOT NULL,
	[Khesarat] [nvarchar](50) NULL,
 CONSTRAINT [PK_Pm_Hadese_KhesaratType] PRIMARY KEY CLUSTERED 
(
	[Srl] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pm_Hadese_KhesaratDevice]    Script Date: 10/10/2011 00:11:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pm_Hadese_KhesaratDevice](
	[Srl] [int] IDENTITY(1,1) NOT NULL,
	[Srl_Parent] [int] NULL,
	[Srl_Pm_Post] [int] NULL,
	[Name] [nvarchar](max) NULL,
	[Model] [nvarchar](50) NULL,
	[MadeDate] [nvarchar](10) NULL,
 CONSTRAINT [PK_Pm_Hadese_KhesaratDevice] PRIMARY KEY CLUSTERED 
(
	[Srl] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pm_Hadese_Elat]    Script Date: 10/10/2011 00:11:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pm_Hadese_Elat](
	[Srl] [int] IDENTITY(1,1) NOT NULL,
	[Elat] [nvarchar](50) NULL,
 CONSTRAINT [PK_Pm_Hadese_Elat] PRIMARY KEY CLUSTERED 
(
	[Srl] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pm_Hadese_AmalkardSystem]    Script Date: 10/10/2011 00:11:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pm_Hadese_AmalkardSystem](
	[Srl] [int] IDENTITY(1,1) NOT NULL,
	[Amalkard] [nvarchar](50) NULL,
 CONSTRAINT [PK_Pm_Hadese_AmalkardSystem] PRIMARY KEY CLUSTERED 
(
	[Srl] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pm_Hadese]    Script Date: 10/10/2011 00:11:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pm_Hadese](
	[Srl] [int] IDENTITY(1,1) NOT NULL,
	[ReportNo] [nvarchar](50) NULL,
	[Sat] [nvarchar](5) NULL,
	[Tarikh] [nvarchar](10) NULL,
	[Srl_PM_Hadese_Elat] [int] NULL,
	[Srl_Pm_Hadese_SharayetBoroz] [int] NULL,
	[Srl_Pm_Post] [int] NULL,
	[Kelidi] [nvarchar](100) NULL,
	[SharhHadese] [nvarchar](max) NULL,
	[EghdamatAvalie] [nvarchar](max) NULL,
	[GostareshHadese] [bit] NULL,
	[ElatGostareshHadese] [nvarchar](max) NULL,
	[Srl_Pm_Hadese_Amalkard] [int] NULL,
	[Srl_Pm_Group] [int] NULL,
	[NatijeBarasi] [nvarchar](max) NULL,
	[DastorModir] [nvarchar](max) NULL,
	[Srl_SubmitUser] [int] NULL,
	[SubmitDate] [datetime] NULL,
 CONSTRAINT [PK_Pm_Hadese] PRIMARY KEY CLUSTERED 
(
	[Srl] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pm_Hadese_Pishnahad]    Script Date: 10/10/2011 00:11:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pm_Hadese_Pishnahad](
	[Srl] [int] IDENTITY(1,1) NOT NULL,
	[Srl_Pm_Hadese] [int] NULL,
	[pishnahad] [nvarchar](max) NULL,
 CONSTRAINT [PK_Pm_Hadese_Pishnahad] PRIMARY KEY CLUSTERED 
(
	[Srl] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pm_Hadese_Khesarat]    Script Date: 10/10/2011 00:11:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pm_Hadese_Khesarat](
	[Srl] [int] IDENTITY(1,1) NOT NULL,
	[Srl_Pm_Hadese] [int] NULL,
	[Srl_Pm_Hadese_KhesaratDevice] [int] NULL,
	[Srl_Pm_Hadese_KhesaratType] [int] NULL,
	[KhamoshiValue] [float] NULL,
	[ModateKhoroj] [nvarchar](5) NULL,
 CONSTRAINT [PK_Pm_Hadese_Khesarat] PRIMARY KEY CLUSTERED 
(
	[Srl] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  ForeignKey [FK_Pm_Hadese_Pm_Hadese_AmalkardSystem]    Script Date: 10/10/2011 00:11:54 ******/
ALTER TABLE [dbo].[Pm_Hadese]  WITH CHECK ADD  CONSTRAINT [FK_Pm_Hadese_Pm_Hadese_AmalkardSystem] FOREIGN KEY([Srl_Pm_Hadese_Amalkard])
REFERENCES [dbo].[Pm_Hadese_AmalkardSystem] ([Srl])
GO
ALTER TABLE [dbo].[Pm_Hadese] CHECK CONSTRAINT [FK_Pm_Hadese_Pm_Hadese_AmalkardSystem]
GO
/****** Object:  ForeignKey [FK_Pm_Hadese_Pm_Hadese_Elat]    Script Date: 10/10/2011 00:11:54 ******/
ALTER TABLE [dbo].[Pm_Hadese]  WITH CHECK ADD  CONSTRAINT [FK_Pm_Hadese_Pm_Hadese_Elat] FOREIGN KEY([Srl_PM_Hadese_Elat])
REFERENCES [dbo].[Pm_Hadese_Elat] ([Srl])
GO
ALTER TABLE [dbo].[Pm_Hadese] CHECK CONSTRAINT [FK_Pm_Hadese_Pm_Hadese_Elat]
GO
/****** Object:  ForeignKey [FK_Pm_Hadese_Pm_Hadese_SharayetBoroz]    Script Date: 10/10/2011 00:11:54 ******/
ALTER TABLE [dbo].[Pm_Hadese]  WITH CHECK ADD  CONSTRAINT [FK_Pm_Hadese_Pm_Hadese_SharayetBoroz] FOREIGN KEY([Srl_Pm_Hadese_SharayetBoroz])
REFERENCES [dbo].[Pm_Hadese_SharayetBoroz] ([Srl])
GO
ALTER TABLE [dbo].[Pm_Hadese] CHECK CONSTRAINT [FK_Pm_Hadese_Pm_Hadese_SharayetBoroz]
GO
/****** Object:  ForeignKey [FK_Pm_Hadese_Khesarat_Pm_Hadese]    Script Date: 10/10/2011 00:11:54 ******/
ALTER TABLE [dbo].[Pm_Hadese_Khesarat]  WITH CHECK ADD  CONSTRAINT [FK_Pm_Hadese_Khesarat_Pm_Hadese] FOREIGN KEY([Srl_Pm_Hadese])
REFERENCES [dbo].[Pm_Hadese] ([Srl])
GO
ALTER TABLE [dbo].[Pm_Hadese_Khesarat] CHECK CONSTRAINT [FK_Pm_Hadese_Khesarat_Pm_Hadese]
GO
/****** Object:  ForeignKey [FK_Pm_Hadese_Khesarat_Pm_Hadese_KhesaratDevice]    Script Date: 10/10/2011 00:11:54 ******/
ALTER TABLE [dbo].[Pm_Hadese_Khesarat]  WITH CHECK ADD  CONSTRAINT [FK_Pm_Hadese_Khesarat_Pm_Hadese_KhesaratDevice] FOREIGN KEY([Srl_Pm_Hadese_KhesaratDevice])
REFERENCES [dbo].[Pm_Hadese_KhesaratDevice] ([Srl])
GO
ALTER TABLE [dbo].[Pm_Hadese_Khesarat] CHECK CONSTRAINT [FK_Pm_Hadese_Khesarat_Pm_Hadese_KhesaratDevice]
GO
/****** Object:  ForeignKey [FK_Pm_Hadese_Khesarat_Pm_Hadese_KhesaratType]    Script Date: 10/10/2011 00:11:54 ******/
ALTER TABLE [dbo].[Pm_Hadese_Khesarat]  WITH CHECK ADD  CONSTRAINT [FK_Pm_Hadese_Khesarat_Pm_Hadese_KhesaratType] FOREIGN KEY([Srl_Pm_Hadese_KhesaratType])
REFERENCES [dbo].[Pm_Hadese_KhesaratType] ([Srl])
GO
ALTER TABLE [dbo].[Pm_Hadese_Khesarat] CHECK CONSTRAINT [FK_Pm_Hadese_Khesarat_Pm_Hadese_KhesaratType]
GO
/****** Object:  ForeignKey [FK_Pm_Hadese_Pishnahad_Pm_Hadese]    Script Date: 10/10/2011 00:11:54 ******/
ALTER TABLE [dbo].[Pm_Hadese_Pishnahad]  WITH CHECK ADD  CONSTRAINT [FK_Pm_Hadese_Pishnahad_Pm_Hadese] FOREIGN KEY([Srl_Pm_Hadese])
REFERENCES [dbo].[Pm_Hadese] ([Srl])
GO
ALTER TABLE [dbo].[Pm_Hadese_Pishnahad] CHECK CONSTRAINT [FK_Pm_Hadese_Pishnahad_Pm_Hadese]
GO
