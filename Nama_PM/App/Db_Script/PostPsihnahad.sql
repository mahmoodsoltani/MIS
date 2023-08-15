USE [Nama_MIS]
GO

/****** Object:  Table [dbo].[Pm_Post_Pishnahd]    Script Date: 06/23/2012 11:08:24 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Pm_Post_Pishnahd](
	[Srl] [int] IDENTITY(1,1) NOT NULL,
	[Srl_Post] [int] NULL,
	[Srl_Pm_Ashkhas] [int] NULL,
	[Tarikh] [nvarchar](10) NULL,
	[Onvan] [nvarchar](max) NULL,
	[Pishnahad] [nvarchar](max) NULL,
 CONSTRAINT [PK_Pm_Post_Pishnahd] PRIMARY KEY CLUSTERED 
(
	[Srl] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


