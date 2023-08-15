USE [Nama_MIS]
GO

/****** Object:  Table [dbo].[Pm_Taghvim]    Script Date: 02/01/2011 11:25:14 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Pm_Taghvim]') AND type in (N'U'))
DROP TABLE [dbo].[Pm_Taghvim]
GO

USE [Nama_MIS]
GO

/****** Object:  Table [dbo].[Pm_Taghvim]    Script Date: 02/01/2011 11:25:14 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Pm_Taghvim](
	[Srl] [int] IDENTITY(1,1) NOT NULL,
	[Tarikh] [nvarchar](10) NULL,
	[Type] [int] NULL,
 CONSTRAINT [PK_Pm_Taghvim] PRIMARY KEY CLUSTERED 
(
	[Srl] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

