USE [Nama_MIS]
GO
/****** Object:  Table [dbo].[Pm_Amo_ZamanDore]    Script Date: 05/19/2012 00:12:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pm_Amo_ZamanDore](
	[Srl] [int] NOT NULL,
	[Name] [nvarchar](50) NULL,
 CONSTRAINT [PK_Pm_Amo_ZamanDore] PRIMARY KEY CLUSTERED 
(
	[Srl] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Pm_Amo_ZamanDore] ([Srl], [Name]) VALUES (1, N'قبل از استخدام')
INSERT [dbo].[Pm_Amo_ZamanDore] ([Srl], [Name]) VALUES (2, N'بعد از استخدام')
/****** Object:  Table [dbo].[Pm_Amo_MoaseseAmozeshi]    Script Date: 05/19/2012 00:12:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pm_Amo_MoaseseAmozeshi](
	[Srl] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](150) NULL,
 CONSTRAINT [PK_Pm_Amo_MoaseseAmozeshi] PRIMARY KEY CLUSTERED 
(
	[Srl] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Pm_Amo_MoaseseAmozeshi] ON
INSERT [dbo].[Pm_Amo_MoaseseAmozeshi] ([Srl], [Name]) VALUES (1, N'موسسه مخته')
INSERT [dbo].[Pm_Amo_MoaseseAmozeshi] ([Srl], [Name]) VALUES (2, N'موسسه رضا يا')
SET IDENTITY_INSERT [dbo].[Pm_Amo_MoaseseAmozeshi] OFF
/****** Object:  Table [dbo].[Pm_Amo_MahaleBargozary]    Script Date: 05/19/2012 00:12:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pm_Amo_MahaleBargozary](
	[Srl] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](150) NULL,
 CONSTRAINT [PK_Pm_Amo_MahaleBargozary] PRIMARY KEY CLUSTERED 
(
	[Srl] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Pm_Amo_MahaleBargozary] ON
INSERT [dbo].[Pm_Amo_MahaleBargozary] ([Srl], [Name]) VALUES (1, N'مختار آباد')
INSERT [dbo].[Pm_Amo_MahaleBargozary] ([Srl], [Name]) VALUES (2, N'عبدل آباد')
INSERT [dbo].[Pm_Amo_MahaleBargozary] ([Srl], [Name]) VALUES (3, N'رضا يا')
INSERT [dbo].[Pm_Amo_MahaleBargozary] ([Srl], [Name]) VALUES (4, N'2 يه فم')
SET IDENTITY_INSERT [dbo].[Pm_Amo_MahaleBargozary] OFF
/****** Object:  Table [dbo].[Pm_Amo_DoreType]    Script Date: 05/19/2012 00:12:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pm_Amo_DoreType](
	[Srl] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](150) NULL,
 CONSTRAINT [PK_Pm_Amo_DoreType] PRIMARY KEY CLUSTERED 
(
	[Srl] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Pm_Amo_DoreType] ON
INSERT [dbo].[Pm_Amo_DoreType] ([Srl], [Name]) VALUES (3, N'تخصصي')
INSERT [dbo].[Pm_Amo_DoreType] ([Srl], [Name]) VALUES (4, N'ايمني')
SET IDENTITY_INSERT [dbo].[Pm_Amo_DoreType] OFF
/****** Object:  Table [dbo].[Pm_Amo_DoreName]    Script Date: 05/19/2012 00:12:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pm_Amo_DoreName](
	[Srl] [int] IDENTITY(1,1) NOT NULL,
	[Srl_Pm_Amo_DoreType] [int] NULL,
	[Name] [nvarchar](150) NULL,
 CONSTRAINT [PK_Pm_Amo_DoreName] PRIMARY KEY CLUSTERED 
(
	[Srl] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Pm_Amo_DoreName] ON
INSERT [dbo].[Pm_Amo_DoreName] ([Srl], [Srl_Pm_Amo_DoreType], [Name]) VALUES (1, 3, N'مخته')
INSERT [dbo].[Pm_Amo_DoreName] ([Srl], [Srl_Pm_Amo_DoreType], [Name]) VALUES (2, 3, N'رشا يا')
INSERT [dbo].[Pm_Amo_DoreName] ([Srl], [Srl_Pm_Amo_DoreType], [Name]) VALUES (3, 4, N'فلاکت')
SET IDENTITY_INSERT [dbo].[Pm_Amo_DoreName] OFF
/****** Object:  Table [dbo].[Pm_Amo_Dore]    Script Date: 05/19/2012 00:12:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pm_Amo_Dore](
	[Srl] [int] IDENTITY(1,1) NOT NULL,
	[Srl_Pm_Ashkhas] [int] NULL,
	[Srl_Pm_Amo_DoreName] [int] NULL,
	[Srl_Pm_Amo_MoaseseAmozeshi] [int] NULL,
	[Srl_Pm_Amo_MahaleBargozary] [int] NULL,
	[Srl_Pm_Amo_DoreType] [int] NULL,
	[Srl_Pm_Amo_ZamanDore] [int] NULL,
	[Tarikh] [nvarchar](10) NULL,
	[Modat] [float] NULL,
	[Srl_SubmitUser] [int] NULL,
	[SubmitDate] [datetime] NULL,
 CONSTRAINT [PK_Pm_Amo_Dore] PRIMARY KEY CLUSTERED 
(
	[Srl] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Pm_Amo_Dore] ON
INSERT [dbo].[Pm_Amo_Dore] ([Srl], [Srl_Pm_Ashkhas], [Srl_Pm_Amo_DoreName], [Srl_Pm_Amo_MoaseseAmozeshi], [Srl_Pm_Amo_MahaleBargozary], [Srl_Pm_Amo_DoreType], [Srl_Pm_Amo_ZamanDore], [Tarikh], [Modat], [Srl_SubmitUser], [SubmitDate]) VALUES (1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Pm_Amo_Dore] ([Srl], [Srl_Pm_Ashkhas], [Srl_Pm_Amo_DoreName], [Srl_Pm_Amo_MoaseseAmozeshi], [Srl_Pm_Amo_MahaleBargozary], [Srl_Pm_Amo_DoreType], [Srl_Pm_Amo_ZamanDore], [Tarikh], [Modat], [Srl_SubmitUser], [SubmitDate]) VALUES (2, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Pm_Amo_Dore] ([Srl], [Srl_Pm_Ashkhas], [Srl_Pm_Amo_DoreName], [Srl_Pm_Amo_MoaseseAmozeshi], [Srl_Pm_Amo_MahaleBargozary], [Srl_Pm_Amo_DoreType], [Srl_Pm_Amo_ZamanDore], [Tarikh], [Modat], [Srl_SubmitUser], [SubmitDate]) VALUES (3, 1249, 1, 1, 1, 3, 1, N'1391/02/25', 0, NULL, NULL)
INSERT [dbo].[Pm_Amo_Dore] ([Srl], [Srl_Pm_Ashkhas], [Srl_Pm_Amo_DoreName], [Srl_Pm_Amo_MoaseseAmozeshi], [Srl_Pm_Amo_MahaleBargozary], [Srl_Pm_Amo_DoreType], [Srl_Pm_Amo_ZamanDore], [Tarikh], [Modat], [Srl_SubmitUser], [SubmitDate]) VALUES (4, 1249, 1, 1, 1, 3, 1, N'1391/02/26', 12, NULL, NULL)
INSERT [dbo].[Pm_Amo_Dore] ([Srl], [Srl_Pm_Ashkhas], [Srl_Pm_Amo_DoreName], [Srl_Pm_Amo_MoaseseAmozeshi], [Srl_Pm_Amo_MahaleBargozary], [Srl_Pm_Amo_DoreType], [Srl_Pm_Amo_ZamanDore], [Tarikh], [Modat], [Srl_SubmitUser], [SubmitDate]) VALUES (5, 1107, 1, 1, 1, 3, 1, N'1391/02/25', 0, NULL, NULL)
INSERT [dbo].[Pm_Amo_Dore] ([Srl], [Srl_Pm_Ashkhas], [Srl_Pm_Amo_DoreName], [Srl_Pm_Amo_MoaseseAmozeshi], [Srl_Pm_Amo_MahaleBargozary], [Srl_Pm_Amo_DoreType], [Srl_Pm_Amo_ZamanDore], [Tarikh], [Modat], [Srl_SubmitUser], [SubmitDate]) VALUES (6, 1156, 3, 2, 3, 4, 2, N'1391/02/25', 100, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Pm_Amo_Dore] OFF
/****** Object:  ForeignKey [FK_Pm_Amo_Dore_Pm_Amo_DoreName]    Script Date: 05/19/2012 00:12:20 ******/
ALTER TABLE [dbo].[Pm_Amo_Dore]  WITH CHECK ADD  CONSTRAINT [FK_Pm_Amo_Dore_Pm_Amo_DoreName] FOREIGN KEY([Srl_Pm_Amo_DoreName])
REFERENCES [dbo].[Pm_Amo_DoreName] ([Srl])
GO
ALTER TABLE [dbo].[Pm_Amo_Dore] CHECK CONSTRAINT [FK_Pm_Amo_Dore_Pm_Amo_DoreName]
GO
/****** Object:  ForeignKey [FK_Pm_Amo_Dore_Pm_Amo_DoreType]    Script Date: 05/19/2012 00:12:20 ******/
ALTER TABLE [dbo].[Pm_Amo_Dore]  WITH CHECK ADD  CONSTRAINT [FK_Pm_Amo_Dore_Pm_Amo_DoreType] FOREIGN KEY([Srl_Pm_Amo_DoreType])
REFERENCES [dbo].[Pm_Amo_DoreType] ([Srl])
GO
ALTER TABLE [dbo].[Pm_Amo_Dore] CHECK CONSTRAINT [FK_Pm_Amo_Dore_Pm_Amo_DoreType]
GO
/****** Object:  ForeignKey [FK_Pm_Amo_Dore_Pm_Amo_MahaleBargozary]    Script Date: 05/19/2012 00:12:20 ******/
ALTER TABLE [dbo].[Pm_Amo_Dore]  WITH CHECK ADD  CONSTRAINT [FK_Pm_Amo_Dore_Pm_Amo_MahaleBargozary] FOREIGN KEY([Srl_Pm_Amo_MahaleBargozary])
REFERENCES [dbo].[Pm_Amo_MahaleBargozary] ([Srl])
GO
ALTER TABLE [dbo].[Pm_Amo_Dore] CHECK CONSTRAINT [FK_Pm_Amo_Dore_Pm_Amo_MahaleBargozary]
GO
/****** Object:  ForeignKey [FK_Pm_Amo_Dore_Pm_Amo_MoaseseAmozeshi]    Script Date: 05/19/2012 00:12:20 ******/
ALTER TABLE [dbo].[Pm_Amo_Dore]  WITH CHECK ADD  CONSTRAINT [FK_Pm_Amo_Dore_Pm_Amo_MoaseseAmozeshi] FOREIGN KEY([Srl_Pm_Amo_MoaseseAmozeshi])
REFERENCES [dbo].[Pm_Amo_MoaseseAmozeshi] ([Srl])
GO
ALTER TABLE [dbo].[Pm_Amo_Dore] CHECK CONSTRAINT [FK_Pm_Amo_Dore_Pm_Amo_MoaseseAmozeshi]
GO
/****** Object:  ForeignKey [FK_Pm_Amo_Dore_Pm_Amo_ZamanDore]    Script Date: 05/19/2012 00:12:20 ******/
ALTER TABLE [dbo].[Pm_Amo_Dore]  WITH CHECK ADD  CONSTRAINT [FK_Pm_Amo_Dore_Pm_Amo_ZamanDore] FOREIGN KEY([Srl_Pm_Amo_ZamanDore])
REFERENCES [dbo].[Pm_Amo_ZamanDore] ([Srl])
GO
ALTER TABLE [dbo].[Pm_Amo_Dore] CHECK CONSTRAINT [FK_Pm_Amo_Dore_Pm_Amo_ZamanDore]
GO
/****** Object:  ForeignKey [FK_Pm_Amo_Dore_Pm_Ashkhas]    Script Date: 05/19/2012 00:12:20 ******/
ALTER TABLE [dbo].[Pm_Amo_Dore]  WITH CHECK ADD  CONSTRAINT [FK_Pm_Amo_Dore_Pm_Ashkhas] FOREIGN KEY([Srl_Pm_Ashkhas])
REFERENCES [dbo].[Pm_Ashkhas] ([Srl])
GO
ALTER TABLE [dbo].[Pm_Amo_Dore] CHECK CONSTRAINT [FK_Pm_Amo_Dore_Pm_Ashkhas]
GO
/****** Object:  ForeignKey [FK_Pm_Amo_DoreName_Pm_Amo_DoreType]    Script Date: 05/19/2012 00:12:20 ******/
ALTER TABLE [dbo].[Pm_Amo_DoreName]  WITH CHECK ADD  CONSTRAINT [FK_Pm_Amo_DoreName_Pm_Amo_DoreType] FOREIGN KEY([Srl_Pm_Amo_DoreType])
REFERENCES [dbo].[Pm_Amo_DoreType] ([Srl])
GO
ALTER TABLE [dbo].[Pm_Amo_DoreName] CHECK CONSTRAINT [FK_Pm_Amo_DoreName_Pm_Amo_DoreType]
GO
