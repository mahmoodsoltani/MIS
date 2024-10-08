USE [Nama_MIS]
GO
/****** Object:  ForeignKey [FK_Pm_Lab_Rol_Tamirat_GheteMasrafi_Pm_Lab_Rol_GhatatMasrafi]    Script Date: 04/06/2012 22:27:47 ******/
ALTER TABLE [dbo].[Pm_Lab_Rol_Tamirat_GheteMasrafi] DROP CONSTRAINT [FK_Pm_Lab_Rol_Tamirat_GheteMasrafi_Pm_Lab_Rol_GhatatMasrafi]
GO
/****** Object:  ForeignKey [FK_Pm_Lab_Rol_Tamirat_GheteMasrafi_Pm_Lab_Rol_Tamirat]    Script Date: 04/06/2012 22:27:47 ******/
ALTER TABLE [dbo].[Pm_Lab_Rol_Tamirat_GheteMasrafi] DROP CONSTRAINT [FK_Pm_Lab_Rol_Tamirat_GheteMasrafi_Pm_Lab_Rol_Tamirat]
GO
/****** Object:  ForeignKey [FK_Pm_Lab_Rol_Tamirat_Pm_Ashkhas]    Script Date: 04/06/2012 22:27:47 ******/
ALTER TABLE [dbo].[Pm_Lab_Rol_Tamirat] DROP CONSTRAINT [FK_Pm_Lab_Rol_Tamirat_Pm_Ashkhas]
GO
/****** Object:  ForeignKey [FK_Pm_Lab_Rol_Tamirat_Pm_Lab_Rol_ElateVorod]    Script Date: 04/06/2012 22:27:47 ******/
ALTER TABLE [dbo].[Pm_Lab_Rol_Tamirat] DROP CONSTRAINT [FK_Pm_Lab_Rol_Tamirat_Pm_Lab_Rol_ElateVorod]
GO
/****** Object:  ForeignKey [FK_Pm_Lab_Rol_Tamirat_Pm_Lab_Rol_SatheAhamniat]    Script Date: 04/06/2012 22:27:47 ******/
ALTER TABLE [dbo].[Pm_Lab_Rol_Tamirat] DROP CONSTRAINT [FK_Pm_Lab_Rol_Tamirat_Pm_Lab_Rol_SatheAhamniat]
GO
/****** Object:  ForeignKey [FK_Pm_Lab_Rol_Tamirat_Pm_Post]    Script Date: 04/06/2012 22:27:47 ******/
ALTER TABLE [dbo].[Pm_Lab_Rol_Tamirat] DROP CONSTRAINT [FK_Pm_Lab_Rol_Tamirat_Pm_Post]
GO
/****** Object:  Table [dbo].[Pm_Lab_Rol_Tamirat_GheteMasrafi]    Script Date: 04/06/2012 22:27:47 ******/
ALTER TABLE [dbo].[Pm_Lab_Rol_Tamirat_GheteMasrafi] DROP CONSTRAINT [FK_Pm_Lab_Rol_Tamirat_GheteMasrafi_Pm_Lab_Rol_GhatatMasrafi]
GO
ALTER TABLE [dbo].[Pm_Lab_Rol_Tamirat_GheteMasrafi] DROP CONSTRAINT [FK_Pm_Lab_Rol_Tamirat_GheteMasrafi_Pm_Lab_Rol_Tamirat]
GO
DROP TABLE [dbo].[Pm_Lab_Rol_Tamirat_GheteMasrafi]
GO
/****** Object:  Table [dbo].[Pm_Lab_Rol_Tamirat]    Script Date: 04/06/2012 22:27:47 ******/
ALTER TABLE [dbo].[Pm_Lab_Rol_Tamirat] DROP CONSTRAINT [FK_Pm_Lab_Rol_Tamirat_Pm_Ashkhas]
GO
ALTER TABLE [dbo].[Pm_Lab_Rol_Tamirat] DROP CONSTRAINT [FK_Pm_Lab_Rol_Tamirat_Pm_Lab_Rol_ElateVorod]
GO
ALTER TABLE [dbo].[Pm_Lab_Rol_Tamirat] DROP CONSTRAINT [FK_Pm_Lab_Rol_Tamirat_Pm_Lab_Rol_SatheAhamniat]
GO
ALTER TABLE [dbo].[Pm_Lab_Rol_Tamirat] DROP CONSTRAINT [FK_Pm_Lab_Rol_Tamirat_Pm_Post]
GO
DROP TABLE [dbo].[Pm_Lab_Rol_Tamirat]
GO
/****** Object:  UserDefinedFunction [dbo].[Fn_TraceTreeName_Down]    Script Date: 04/06/2012 22:27:49 ******/
DROP FUNCTION [dbo].[Fn_TraceTreeName_Down]
GO
/****** Object:  Table [dbo].[Pm_Lab_Rol_ElateVorod]    Script Date: 04/06/2012 22:27:46 ******/
DROP TABLE [dbo].[Pm_Lab_Rol_ElateVorod]
GO
/****** Object:  Table [dbo].[Pm_Lab_Rol_GhatatMasrafi]    Script Date: 04/06/2012 22:27:46 ******/
DROP TABLE [dbo].[Pm_Lab_Rol_GhatatMasrafi]
GO
/****** Object:  Table [dbo].[Pm_Lab_Rol_SatheAhamniat]    Script Date: 04/06/2012 22:27:46 ******/
DROP TABLE [dbo].[Pm_Lab_Rol_SatheAhamniat]
GO
/****** Object:  Table [dbo].[Pm_Lab_Rol_SatheAhamniat]    Script Date: 04/06/2012 22:27:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pm_Lab_Rol_SatheAhamniat](
	[Srl] [int] IDENTITY(1,1) NOT NULL,
	[Text] [nvarchar](50) NULL,
 CONSTRAINT [PK_Lab_SatheAhamniat] PRIMARY KEY CLUSTERED 
(
	[Srl] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Pm_Lab_Rol_SatheAhamniat] ON
INSERT [dbo].[Pm_Lab_Rol_SatheAhamniat] ([Srl], [Text]) VALUES (1, N'داراي اهميت')
INSERT [dbo].[Pm_Lab_Rol_SatheAhamniat] ([Srl], [Text]) VALUES (2, N'بي اهميت')
INSERT [dbo].[Pm_Lab_Rol_SatheAhamniat] ([Srl], [Text]) VALUES (3, N'سلام')
INSERT [dbo].[Pm_Lab_Rol_SatheAhamniat] ([Srl], [Text]) VALUES (4, N'اي بابا')
INSERT [dbo].[Pm_Lab_Rol_SatheAhamniat] ([Srl], [Text]) VALUES (5, N'رضا يار')
SET IDENTITY_INSERT [dbo].[Pm_Lab_Rol_SatheAhamniat] OFF
/****** Object:  Table [dbo].[Pm_Lab_Rol_GhatatMasrafi]    Script Date: 04/06/2012 22:27:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pm_Lab_Rol_GhatatMasrafi](
	[Srl] [int] IDENTITY(1,1) NOT NULL,
	[text] [nvarchar](50) NULL,
 CONSTRAINT [PK_Pm_Lab_Rol_GhatatMasrafi] PRIMARY KEY CLUSTERED 
(
	[Srl] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Pm_Lab_Rol_GhatatMasrafi] ON
INSERT [dbo].[Pm_Lab_Rol_GhatatMasrafi] ([Srl], [text]) VALUES (1, N'يلام')
INSERT [dbo].[Pm_Lab_Rol_GhatatMasrafi] ([Srl], [text]) VALUES (2, N'چزوري')
SET IDENTITY_INSERT [dbo].[Pm_Lab_Rol_GhatatMasrafi] OFF
/****** Object:  Table [dbo].[Pm_Lab_Rol_ElateVorod]    Script Date: 04/06/2012 22:27:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pm_Lab_Rol_ElateVorod](
	[Srl] [int] IDENTITY(1,1) NOT NULL,
	[Text] [nvarchar](50) NULL,
 CONSTRAINT [PK_Lab_ElateVorod] PRIMARY KEY CLUSTERED 
(
	[Srl] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Pm_Lab_Rol_ElateVorod] ON
INSERT [dbo].[Pm_Lab_Rol_ElateVorod] ([Srl], [Text]) VALUES (1, N'علتي نداشت')
INSERT [dbo].[Pm_Lab_Rol_ElateVorod] ([Srl], [Text]) VALUES (2, N'رضا يار')
INSERT [dbo].[Pm_Lab_Rol_ElateVorod] ([Srl], [Text]) VALUES (3, N'2غثبثئ')
INSERT [dbo].[Pm_Lab_Rol_ElateVorod] ([Srl], [Text]) VALUES (4, N'مختار')
INSERT [dbo].[Pm_Lab_Rol_ElateVorod] ([Srl], [Text]) VALUES (5, N'بدون علت')
INSERT [dbo].[Pm_Lab_Rol_ElateVorod] ([Srl], [Text]) VALUES (6, N'تست است')
SET IDENTITY_INSERT [dbo].[Pm_Lab_Rol_ElateVorod] OFF
/****** Object:  UserDefinedFunction [dbo].[Fn_TraceTreeName_Down]    Script Date: 04/06/2012 22:27:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[Fn_TraceTreeName_Down]
(
@Srl as int
)
RETURNS nvarchar(max)
AS
BEGIN
declare @NameQutue as nvarchar(100)
set @NameQutue=null

while (not @Srl=0)
begin
set @NameQutue=isnull(@NameQutue+' <- ','') +(select Name from Pm_Hadese_KhesaratDevice where Srl=@Srl)
set @Srl =(select Srl_Parent from Pm_Hadese_KhesaratDevice where Srl=@Srl)
end

return @NameQutue
END
GO
/****** Object:  Table [dbo].[Pm_Lab_Rol_Tamirat]    Script Date: 04/06/2012 22:27:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pm_Lab_Rol_Tamirat](
	[Srl] [int] IDENTITY(1,1) NOT NULL,
	[Srl_Pm_Post] [int] NOT NULL,
	[Srl_Pm_Hadese_KhesaratDevice] [int] NULL,
	[Srl_Pm_Lab_Rol_SatheAhamniat] [int] NULL,
	[Srl_Acc_Ashkhas_Tavasot] [int] NULL,
	[Srl_Pm_Lab_Rol_ElateVorod] [int] NULL,
	[No] [nvarchar](50) NULL,
	[NafarSAt] [int] NULL,
	[SabtDate] [nvarchar](10) NULL,
	[VorodDate] [nvarchar](10) NULL,
	[VorodDateBound] [nvarchar](10) NULL,
	[TamirDate] [nvarchar](10) NULL,
	[TamirDateBound] [nvarchar](10) NULL,
	[TahvilDate] [nvarchar](10) NULL,
	[Dis] [nvarchar](500) NULL,
	[Srl_Acc_Ashkhas_Tahvil] [int] NULL,
	[Srl_SubmitUser] [int] NULL,
	[SubmitDate] [datetime] NULL,
 CONSTRAINT [PK_Pm_Lab_Rol_Tamirat] PRIMARY KEY CLUSTERED 
(
	[Srl] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Pm_Lab_Rol_Tamirat] ON
INSERT [dbo].[Pm_Lab_Rol_Tamirat] ([Srl], [Srl_Pm_Post], [Srl_Pm_Hadese_KhesaratDevice], [Srl_Pm_Lab_Rol_SatheAhamniat], [Srl_Acc_Ashkhas_Tavasot], [Srl_Pm_Lab_Rol_ElateVorod], [No], [NafarSAt], [SabtDate], [VorodDate], [VorodDateBound], [TamirDate], [TamirDateBound], [TahvilDate], [Dis], [Srl_Acc_Ashkhas_Tahvil], [Srl_SubmitUser], [SubmitDate]) VALUES (8, 777, 88, 1, 963, 4, N'1', 0, N'1391/01/18', N'1391/01/13', N'1391/01/20', N'1391/01/07', N'1391/01/12', N'1391/01/20', N'منن', 1010, 207, CAST(0x0000A02B015F5241 AS DateTime))
INSERT [dbo].[Pm_Lab_Rol_Tamirat] ([Srl], [Srl_Pm_Post], [Srl_Pm_Hadese_KhesaratDevice], [Srl_Pm_Lab_Rol_SatheAhamniat], [Srl_Acc_Ashkhas_Tavasot], [Srl_Pm_Lab_Rol_ElateVorod], [No], [NafarSAt], [SabtDate], [VorodDate], [VorodDateBound], [TamirDate], [TamirDateBound], [TahvilDate], [Dis], [Srl_Acc_Ashkhas_Tahvil], [Srl_SubmitUser], [SubmitDate]) VALUES (9, 777, 88, 1, 1249, 1, N'2', 0, N'1391/01/18', N'', N'', N'', N'', N'', N'', 1249, 207, CAST(0x0000A02B01607CA2 AS DateTime))
SET IDENTITY_INSERT [dbo].[Pm_Lab_Rol_Tamirat] OFF
/****** Object:  Table [dbo].[Pm_Lab_Rol_Tamirat_GheteMasrafi]    Script Date: 04/06/2012 22:27:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pm_Lab_Rol_Tamirat_GheteMasrafi](
	[Srl] [int] IDENTITY(1,1) NOT NULL,
	[Srl_Pm_Lab_Rol_Tamirat] [int] NULL,
	[Pm_Lab_Rol_GhatatMasrafi] [int] NULL,
 CONSTRAINT [PK_Pm_Lab_Rol_Tamirat_GheteMasrafi] PRIMARY KEY CLUSTERED 
(
	[Srl] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Pm_Lab_Rol_Tamirat_GheteMasrafi] ON
INSERT [dbo].[Pm_Lab_Rol_Tamirat_GheteMasrafi] ([Srl], [Srl_Pm_Lab_Rol_Tamirat], [Pm_Lab_Rol_GhatatMasrafi]) VALUES (3, 8, 1)
INSERT [dbo].[Pm_Lab_Rol_Tamirat_GheteMasrafi] ([Srl], [Srl_Pm_Lab_Rol_Tamirat], [Pm_Lab_Rol_GhatatMasrafi]) VALUES (4, 9, 1)
INSERT [dbo].[Pm_Lab_Rol_Tamirat_GheteMasrafi] ([Srl], [Srl_Pm_Lab_Rol_Tamirat], [Pm_Lab_Rol_GhatatMasrafi]) VALUES (5, 9, 2)
SET IDENTITY_INSERT [dbo].[Pm_Lab_Rol_Tamirat_GheteMasrafi] OFF
/****** Object:  ForeignKey [FK_Pm_Lab_Rol_Tamirat_GheteMasrafi_Pm_Lab_Rol_GhatatMasrafi]    Script Date: 04/06/2012 22:27:47 ******/
ALTER TABLE [dbo].[Pm_Lab_Rol_Tamirat_GheteMasrafi]  WITH CHECK ADD  CONSTRAINT [FK_Pm_Lab_Rol_Tamirat_GheteMasrafi_Pm_Lab_Rol_GhatatMasrafi] FOREIGN KEY([Pm_Lab_Rol_GhatatMasrafi])
REFERENCES [dbo].[Pm_Lab_Rol_GhatatMasrafi] ([Srl])
GO
ALTER TABLE [dbo].[Pm_Lab_Rol_Tamirat_GheteMasrafi] CHECK CONSTRAINT [FK_Pm_Lab_Rol_Tamirat_GheteMasrafi_Pm_Lab_Rol_GhatatMasrafi]
GO
/****** Object:  ForeignKey [FK_Pm_Lab_Rol_Tamirat_GheteMasrafi_Pm_Lab_Rol_Tamirat]    Script Date: 04/06/2012 22:27:47 ******/
ALTER TABLE [dbo].[Pm_Lab_Rol_Tamirat_GheteMasrafi]  WITH CHECK ADD  CONSTRAINT [FK_Pm_Lab_Rol_Tamirat_GheteMasrafi_Pm_Lab_Rol_Tamirat] FOREIGN KEY([Srl_Pm_Lab_Rol_Tamirat])
REFERENCES [dbo].[Pm_Lab_Rol_Tamirat] ([Srl])
GO
ALTER TABLE [dbo].[Pm_Lab_Rol_Tamirat_GheteMasrafi] CHECK CONSTRAINT [FK_Pm_Lab_Rol_Tamirat_GheteMasrafi_Pm_Lab_Rol_Tamirat]
GO
/****** Object:  ForeignKey [FK_Pm_Lab_Rol_Tamirat_Pm_Ashkhas]    Script Date: 04/06/2012 22:27:47 ******/
ALTER TABLE [dbo].[Pm_Lab_Rol_Tamirat]  WITH CHECK ADD  CONSTRAINT [FK_Pm_Lab_Rol_Tamirat_Pm_Ashkhas] FOREIGN KEY([Srl_Acc_Ashkhas_Tavasot])
REFERENCES [dbo].[Pm_Ashkhas] ([Srl])
GO
ALTER TABLE [dbo].[Pm_Lab_Rol_Tamirat] CHECK CONSTRAINT [FK_Pm_Lab_Rol_Tamirat_Pm_Ashkhas]
GO
/****** Object:  ForeignKey [FK_Pm_Lab_Rol_Tamirat_Pm_Lab_Rol_ElateVorod]    Script Date: 04/06/2012 22:27:47 ******/
ALTER TABLE [dbo].[Pm_Lab_Rol_Tamirat]  WITH CHECK ADD  CONSTRAINT [FK_Pm_Lab_Rol_Tamirat_Pm_Lab_Rol_ElateVorod] FOREIGN KEY([Srl_Pm_Lab_Rol_ElateVorod])
REFERENCES [dbo].[Pm_Lab_Rol_ElateVorod] ([Srl])
GO
ALTER TABLE [dbo].[Pm_Lab_Rol_Tamirat] CHECK CONSTRAINT [FK_Pm_Lab_Rol_Tamirat_Pm_Lab_Rol_ElateVorod]
GO
/****** Object:  ForeignKey [FK_Pm_Lab_Rol_Tamirat_Pm_Lab_Rol_SatheAhamniat]    Script Date: 04/06/2012 22:27:47 ******/
ALTER TABLE [dbo].[Pm_Lab_Rol_Tamirat]  WITH CHECK ADD  CONSTRAINT [FK_Pm_Lab_Rol_Tamirat_Pm_Lab_Rol_SatheAhamniat] FOREIGN KEY([Srl_Pm_Lab_Rol_SatheAhamniat])
REFERENCES [dbo].[Pm_Lab_Rol_SatheAhamniat] ([Srl])
GO
ALTER TABLE [dbo].[Pm_Lab_Rol_Tamirat] CHECK CONSTRAINT [FK_Pm_Lab_Rol_Tamirat_Pm_Lab_Rol_SatheAhamniat]
GO
/****** Object:  ForeignKey [FK_Pm_Lab_Rol_Tamirat_Pm_Post]    Script Date: 04/06/2012 22:27:47 ******/
ALTER TABLE [dbo].[Pm_Lab_Rol_Tamirat]  WITH CHECK ADD  CONSTRAINT [FK_Pm_Lab_Rol_Tamirat_Pm_Post] FOREIGN KEY([Srl_Pm_Post])
REFERENCES [dbo].[Pm_Post] ([Srl])
GO
ALTER TABLE [dbo].[Pm_Lab_Rol_Tamirat] CHECK CONSTRAINT [FK_Pm_Lab_Rol_Tamirat_Pm_Post]
GO
