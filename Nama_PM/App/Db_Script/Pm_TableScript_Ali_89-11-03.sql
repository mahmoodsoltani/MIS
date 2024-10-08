USE [Nama_MIS]
GO
/****** Object:  Table [dbo].[Pm_WorkForm_EibForm]    Script Date: 01/23/2011 07:13:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pm_WorkForm_EibForm](
	[Srl] [int] NOT NULL,
	[Srl_Pm_EibFormMaster] [int] NULL,
	[Srl_Pm_WorkForm_Master] [int] NULL,
	[Srl_SubmitUser] [int] NULL,
	[SubmitDate] [datetime] NULL,
 CONSTRAINT [PK_Pm_WorkForm_EibForm] PRIMARY KEY CLUSTERED 
(
	[Srl] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[Pm_WorkDis]    Script Date: 01/23/2011 07:19:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pm_WorkDis](
	[Srl] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NULL,
	[Code] [int] NULL,
	[IsPm] [bit] NULL,
	[Srl_SubmitUser] [int] NULL,
	[SubmitDate] [datetime] NULL,
 CONSTRAINT [PK_Pm_WorkDis] PRIMARY KEY CLUSTERED 
(
	[Srl] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
