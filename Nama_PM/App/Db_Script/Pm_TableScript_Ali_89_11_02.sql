USE [Nama_MIS]
GO
/****** Object:  Table [dbo].[Pm_WorkForm_Master]    Script Date: 01/22/2011 11:25:14 ******/
DROP TABLE [dbo].[Pm_WorkForm_Master]
GO
/****** Object:  Table [dbo].[Pm_WorkForm_NoSeq]    Script Date: 01/22/2011 11:25:14 ******/
DROP TABLE [dbo].[Pm_WorkForm_NoSeq]
GO
/****** Object:  Table [dbo].[Pm_WorkFrom_Detail]    Script Date: 01/22/2011 11:25:14 ******/
DROP TABLE [dbo].[Pm_WorkFrom_Detail]
GO
/****** Object:  Table [dbo].[Pm_WorkFrom_Detail]    Script Date: 01/22/2011 11:25:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pm_WorkFrom_Detail](
	[Srl] [int] IDENTITY(1,1) NOT NULL,
	[Srl_Pm_WorkForm_Master] [int] NULL,
	[Srl_Pm_Ashkhas] [int] NULL,
	[Srl_Pm_Post_From] [int] NULL,
	[Srl_Pm_Post_To] [int] NULL,
	[Srl_Pm_Group] [int] NULL,
	[Srl_Pm_Vahed] [int] NULL,
	[Srl_Pm_WorkDis] [int] NULL,
	[Srl_HazineCode] [int] NULL,
	[WorkFormNo] [int] NULL,
	[WorkFormDis] [nvarchar](100) NULL,
	[Dis] [nvarchar](100) NULL,
	[WorkFormTarikh] [nvarchar](11) NULL,
	[SatKAr] [nvarchar](5) NULL,
	[EzafeKAr] [nvarchar](5) NULL,
	[EzafeKarTaradod] [nvarchar](5) NULL,
	[HarkatHamanRoz] [bit] NULL,
	[TardodeDotarfe] [bit] NULL,
	[UserChanged] [bit] NULL,
	[Srl_SubmitUser] [int] NULL,
	[SubmitDate] [datetime] NULL,
 CONSTRAINT [PK_Pm_WorkFrom_Detail] PRIMARY KEY CLUSTERED 
(
	[Srl] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pm_WorkForm_NoSeq]    Script Date: 01/22/2011 11:25:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pm_WorkForm_NoSeq](
	[Srl] [int] IDENTITY(1,1) NOT NULL,
	[Srl_Pm_Ashkhas] [int] NULL,
	[FromNo] [int] NULL,
	[ToNo] [int] NULL,
	[NowNo] [int] NULL,
 CONSTRAINT [PK_WorkForm_NoSequence] PRIMARY KEY CLUSTERED 
(
	[Srl] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pm_WorkForm_Master]    Script Date: 01/22/2011 11:25:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pm_WorkForm_Master](
	[Srl] [int] IDENTITY(1,1) NOT NULL,
	[Srl_Pm_Post_From] [int] NULL,
	[Srl_Pm_Post_To] [int] NULL,
	[Srl_Pm_Group] [int] NULL,
	[Srl_Pm_Vahed] [int] NULL,
	[Srl_Pm_WorkDis] [int] NULL,
	[Srl_HazineCode] [int] NULL,
	[No] [int] NULL,
	[Tarikh] [nvarchar](11) NULL,
	[WorkFormNo] [int] NULL,
	[WorkFormDis] [nvarchar](100) NULL,
	[Dis] [nvarchar](100) NULL,
	[WorkFormTarikh] [nvarchar](11) NULL,
	[BeginWorkSat] [nvarchar](5) NULL,
	[EndWorkSat] [nvarchar](5) NULL,
	[KhorojSat] [nvarchar](5) NULL,
	[TardodeDotarfe] [bit] NULL,
	[HarkatHamanRoz] [bit] NULL,
	[Srl_SubmitUser] [int] NULL,
	[SubmitDate] [datetime] NULL,
 CONSTRAINT [PK_Pm_WorkForm] PRIMARY KEY CLUSTERED 
(
	[Srl] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
