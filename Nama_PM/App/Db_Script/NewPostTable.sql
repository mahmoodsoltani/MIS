USE [NAMA_MIS]
GO

/****** Object:  Table [dbo].[Pm_PostDetails]    Script Date: 07/25/2011 17:36:33 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Pm_PostDetails]') AND type in (N'U'))
DROP TABLE [dbo].[Pm_PostDetails]
GO

USE [NAMA_MIS]
GO

/****** Object:  Table [dbo].[Pm_PostDetails]    Script Date: 07/25/2011 17:36:33 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Pm_PostDetails](
	[Srl] [int] IDENTITY(1,1) NOT NULL,
	[Srl_Pm_Post] [int] NULL,
	[Srl_Pm_PostTip] [int] NULL,
	[Srl_Pm_PostModel] [int] NULL,
	[SatheVoltaj] [nvarchar](100) NULL,
	[SatheVoltaj1] [nvarchar](100) NULL,
	[SalBahrebardari] [nvarchar](100) NULL,
	[Transformator] [nvarchar](500) NULL,
	[Automasion] [nvarchar](500) NULL,
	[Rele] [nvarchar](500) NULL,
	[Zarfiyat_MVA] [nvarchar](50) NULL,
	[Zarfiyat_Count] [nvarchar](50) NULL,
 CONSTRAINT [PK_Pm_PostDetails] PRIMARY KEY CLUSTERED 
(
	[Srl] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

