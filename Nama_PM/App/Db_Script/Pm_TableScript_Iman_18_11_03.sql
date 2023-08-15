USE [Nama_MIS]
GO

/****** Object:  Table [dbo].[Pm_TimeCard]    Script Date: 01/23/2011 15:27:14 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Pm_TimeCard]') AND type in (N'U'))
DROP TABLE [dbo].[Pm_TimeCard]
GO

USE [Nama_MIS]
GO

/****** Object:  Table [dbo].[Pm_TimeCard]    Script Date: 01/23/2011 15:27:14 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Pm_TimeCard](
	[Srl] [int] IDENTITY(1,1) NOT NULL,
	[Srl_Pm_ashkhas] [int] NULL,
	[Tarikh] [nvarchar](10) NULL,
	[AllWork] [nvarchar](20) NULL,
	[BeginTimeExtraWork] [nvarchar](20) NULL,
	[EndTimeExtraWork] [nvarchar](20) NULL,
	[Morakhasi] [nvarchar](20) NULL,
	[Mamoriyat] [nvarchar](20) NULL,
	[Takhir] [nvarchar](20) NULL,
	[Tajil] [nvarchar](20) NULL,
	[EnterTime1] [nvarchar](20) NULL,
	[ExitTime1] [nvarchar](20) NULL,
	[EnterTime2] [nvarchar](20) NULL,
	[ExitTime2] [nvarchar](20) NULL,
	[EnterTime3] [nvarchar](20) NULL,
	[ExitTime3] [nvarchar](20) NULL,
	[Status] [nvarchar](50) NULL
) ON [PRIMARY]

GO

