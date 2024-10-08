USE [Nama_MIS]
GO
/****** Object:  Table [dbo].[Pm_WorkType]    Script Date: 01/19/2011 07:20:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pm_WorkType](
	[Srl] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](300) NULL,
 CONSTRAINT [PK_Pm_WorkType] PRIMARY KEY CLUSTERED 
(
	[Srl] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pm_WorkFrom_Detail]    Script Date: 01/19/2011 07:20:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pm_WorkFrom_Detail](
	[Srl] [int] NOT NULL,
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
	[TardodeDotarfe] [bit] NULL,
	[Srl_SubmitUser] [int] NULL,
	[SubmitDate] [datetime] NULL,
 CONSTRAINT [PK_Pm_WorkFrom_Detail] PRIMARY KEY CLUSTERED 
(
	[Srl] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pm_WorkForm_NoSeq]    Script Date: 01/19/2011 07:20:59 ******/
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
/****** Object:  Table [dbo].[Pm_WorkForm_Master]    Script Date: 01/19/2011 07:20:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pm_WorkForm_Master](
	[Srl] [int] NOT NULL,
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
	[Srl_SubmitUser] [int] NULL,
	[SubmitDate] [datetime] NULL,
 CONSTRAINT [PK_Pm_WorkForm] PRIMARY KEY CLUSTERED 
(
	[Srl] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pm_WorkForm_Formula]    Script Date: 01/19/2011 07:20:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pm_WorkForm_Formula](
	[Srl] [int] IDENTITY(1,1) NOT NULL,
	[Srl_DayOfWeak] [int] NULL,
	[Srl_Pm_PostModel] [int] NULL,
	[Srl_Pm_WorkType] [int] NULL,
	[Srl_Pm_WorkDis] [int] NULL,
	[Zarib] [float] NULL,
	[FromSat] [nvarchar](5) NULL,
	[ToSat] [nvarchar](5) NULL,
	[ImportantSat] [bit] NULL,
	[StandardSat] [nvarchar](5) NULL,
	[Srl_SubmitUser] [int] NULL,
	[SubmitDate] [datetime] NULL,
 CONSTRAINT [PK_Pm_WorkForm_Formula] PRIMARY KEY CLUSTERED 
(
	[Srl] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pm_WorkDis]    Script Date: 01/19/2011 07:20:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pm_WorkDis](
	[Srl] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NULL,
	[Code] [int] NULL,
	[Srl_SubmitUser] [int] NULL,
	[SubmitDate] [datetime] NULL,
 CONSTRAINT [PK_Pm_WorkDis] PRIMARY KEY CLUSTERED 
(
	[Srl] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pm_Vahed]    Script Date: 01/19/2011 07:20:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pm_Vahed](
	[Srl] [int] IDENTITY(1,1) NOT NULL,
	[Code] [int] NULL,
	[Name] [nvarchar](50) NULL,
	[Zarib] [float] NULL,
	[Srl_SubmitUser] [int] NULL,
	[SubmitDate] [datetime] NULL,
 CONSTRAINT [PK_Pm_Vahed] PRIMARY KEY CLUSTERED 
(
	[Srl] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pm_TimeCardType]    Script Date: 01/19/2011 07:20:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pm_TimeCardType](
	[Srl] [int] NULL,
	[Name] [nvarchar](20) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pm_TimeCard]    Script Date: 01/19/2011 07:20:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pm_TimeCard](
	[Srl] [int] IDENTITY(1,1) NOT NULL,
	[Srl_Pm_Ashkhas] [int] NULL,
	[Date] [nchar](10) NULL,
	[StartTime] [nvarchar](10) NULL,
	[Endtime] [nvarchar](10) NULL,
	[Type] [int] NULL,
	[SubmitDate] [datetime] NULL,
	[srl_SubmitUser] [int] NULL,
 CONSTRAINT [PK_Pm_TimeCard] PRIMARY KEY CLUSTERED 
(
	[Srl] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pm_Sherkat]    Script Date: 01/19/2011 07:20:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pm_Sherkat](
	[Srl] [int] IDENTITY(1,1) NOT NULL,
	[Code] [nvarchar](50) NULL,
	[Name] [nvarchar](50) NULL,
	[Adres1] [nvarchar](300) NULL,
	[Adres2] [nvarchar](300) NULL,
	[Mobile] [nvarchar](11) NULL,
	[Eshterak] [float] NULL,
	[Telephone1] [nvarchar](11) NULL,
	[Telephone2] [nvarchar](11) NULL,
	[Fax] [nvarchar](11) NULL,
	[Srl_Acc_Ashkhas_Onvan] [int] NULL,
	[Saghf_etebar] [float] NULL,
	[Srl_Company] [int] NULL,
	[Srl_SubmitUser] [int] NULL,
	[SubmitDate] [datetime] NULL,
	[Shakhs_Type] [bit] NULL,
	[tavalod] [nvarchar](10) NULL,
	[Ezdevaj] [nvarchar](10) NULL,
	[EconomicCode] [nvarchar](50) NULL,
	[Email] [nvarchar](100) NULL,
	[Site] [nvarchar](100) NULL,
	[CodeMelli] [nvarchar](50) NULL,
	[RegisterNomber] [nvarchar](50) NULL,
	[JavazKasbNomber] [nvarchar](50) NULL,
	[Ostan] [nvarchar](50) NULL,
	[Shahr] [nvarchar](50) NULL,
	[Shahrestan] [nvarchar](50) NULL,
	[IsActive] [bit] NULL,
 CONSTRAINT [PK_Pm_Sherkat] PRIMARY KEY CLUSTERED 
(
	[Srl] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pm_Project]    Script Date: 01/19/2011 07:20:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pm_Project](
	[Srl] [int] IDENTITY(1,1) NOT NULL,
	[Code] [nvarchar](50) NULL,
	[Name] [nvarchar](50) NULL,
	[Address] [nvarchar](300) NULL,
	[Tel] [nvarchar](10) NULL,
	[Fax] [nvarchar](10) NULL,
	[Dis] [nvarchar](500) NULL,
	[Active] [bit] NULL,
 CONSTRAINT [PK_Pm_Project] PRIMARY KEY CLUSTERED 
(
	[Srl] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pm_PostTip]    Script Date: 01/19/2011 07:20:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pm_PostTip](
	[Srl] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Code] [int] NULL,
	[Srl_SubmitUser] [int] NULL,
	[SubmitDate] [datetime] NULL,
 CONSTRAINT [PK_Pm_PostTip] PRIMARY KEY CLUSTERED 
(
	[Srl] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pm_PostTajhiz]    Script Date: 01/19/2011 07:20:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pm_PostTajhiz](
	[Srl] [int] IDENTITY(1,1) NOT NULL,
	[Srl_Pm_Post] [int] NULL,
	[TajhizName] [nvarchar](50) NULL,
 CONSTRAINT [PK_Pm_PostTajhiz] PRIMARY KEY CLUSTERED 
(
	[Srl] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pm_Postmodel]    Script Date: 01/19/2011 07:20:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pm_Postmodel](
	[Srl] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NULL,
	[Code] [nvarchar](50) NULL,
	[Srl_SubmitUser] [int] NULL,
	[SubmitDate] [datetime] NULL,
 CONSTRAINT [PK_Pm_City] PRIMARY KEY CLUSTERED 
(
	[Srl] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pm_Post_Group]    Script Date: 01/19/2011 07:20:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pm_Post_Group](
	[Srl] [int] IDENTITY(1,1) NOT NULL,
	[Srl_Pm_Post] [int] NULL,
	[Name] [nvarchar](50) NULL,
 CONSTRAINT [PK_Pm_PostGroup] PRIMARY KEY CLUSTERED 
(
	[Srl] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pm_Post]    Script Date: 01/19/2011 07:20:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pm_Post](
	[Srl] [int] IDENTITY(1,1) NOT NULL,
	[Srl_Pm_PostTip] [int] NULL,
	[Srl_Pm_PostModel] [int] NULL,
	[Code] [int] NULL,
	[Name] [nvarchar](50) NULL,
	[Srl_SubmitUser] [int] NULL,
	[SubmitDate] [datetime] NULL,
 CONSTRAINT [PK_Pm_Post] PRIMARY KEY CLUSTERED 
(
	[Srl] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pm_HazineCode]    Script Date: 01/19/2011 07:20:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pm_HazineCode](
	[Srl] [int] IDENTITY(1,1) NOT NULL,
	[Code] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pm_GroupMember]    Script Date: 01/19/2011 07:20:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pm_GroupMember](
	[Srl] [int] IDENTITY(1,1) NOT NULL,
	[Srl_Pm_Group] [int] NULL,
	[Srl_Acc_Ashkhas] [int] NULL,
	[IsPrimary] [bit] NULL,
	[Srl_SubmitUser] [int] NULL,
	[SubmitDate] [datetime] NULL,
 CONSTRAINT [PK_Pm_GroupMember] PRIMARY KEY CLUSTERED 
(
	[Srl] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pm_Group]    Script Date: 01/19/2011 07:20:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pm_Group](
	[Srl] [int] IDENTITY(1,1) NOT NULL,
	[Srl_Pm_Vahed] [int] NULL,
	[Code] [int] NULL,
	[Name] [nvarchar](50) NULL,
	[Srl_SubmitUser] [int] NULL,
	[SubmitDate] [datetime] NULL,
 CONSTRAINT [PK_Pm_Group] PRIMARY KEY CLUSTERED 
(
	[Srl] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pm_FixEibDis]    Script Date: 01/19/2011 07:20:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pm_FixEibDis](
	[Srl] [int] IDENTITY(1,1) NOT NULL,
	[Code] [int] NULL,
	[Name] [nvarchar](500) NULL,
	[Srl_SubmitUser] [int] NULL,
	[SubmitDate] [datetime] NULL,
 CONSTRAINT [PK_Pm_FixEibDis] PRIMARY KEY CLUSTERED 
(
	[Srl] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pm_EibType]    Script Date: 01/19/2011 07:20:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pm_EibType](
	[Srl] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Code] [nvarchar](50) NULL,
	[Srl_SubmitUser] [int] NULL,
	[SubmitDate] [datetime] NULL,
 CONSTRAINT [PK_Pm_DeviceEib] PRIMARY KEY CLUSTERED 
(
	[Srl] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pm_EibFormPeiro]    Script Date: 01/19/2011 07:20:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pm_EibFormPeiro](
	[Srl] [int] IDENTITY(1,1) NOT NULL,
	[Srl_Pm_EibFormMaster] [int] NULL,
	[Srl_Pm_EibFormMasterPeiro] [int] NULL,
	[Srl_SubmitUser] [int] NULL,
	[SubmitDate] [datetime] NULL,
 CONSTRAINT [PK_Pm_EibFormPeiro] PRIMARY KEY CLUSTERED 
(
	[Srl] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pm_EibFormMaster]    Script Date: 01/19/2011 07:20:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pm_EibFormMaster](
	[Srl] [int] IDENTITY(1,1) NOT NULL,
	[EibFormNumber] [nvarchar](50) NULL,
	[EibFormDate] [nvarchar](10) NULL,
	[OrginalEibFormNumber] [nvarchar](50) NULL,
	[OriginalEibFormDate] [nvarchar](10) NULL,
	[Srl_Pm_Post] [int] NULL,
	[ReferenceDate] [nvarchar](10) NULL,
	[Srl_Pm_Vahed] [int] NULL,
	[Srl_Pm_Group] [int] NULL,
	[ReceptionDate] [nvarchar](10) NULL,
	[WorkFormNumber] [nchar](10) NULL,
	[EibFixDate] [nvarchar](10) NULL,
	[WorkDis] [nvarchar](500) NULL,
 CONSTRAINT [PK_Pm_EibWork_Form] PRIMARY KEY CLUSTERED 
(
	[Srl] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pm_EibFormDetails]    Script Date: 01/19/2011 07:20:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pm_EibFormDetails](
	[Srl] [int] IDENTITY(1,1) NOT NULL,
	[Srl_Pm_EibFormMaster] [int] NULL,
	[Srl_Pm_EibType] [int] NULL,
	[EibDis] [nvarchar](500) NULL,
	[Srl_SubmitUser] [int] NULL,
	[SubmitDate] [datetime] NULL,
 CONSTRAINT [PK_Pm_EibFormDetails] PRIMARY KEY CLUSTERED 
(
	[Srl] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pm_Distance]    Script Date: 01/19/2011 07:20:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pm_Distance](
	[Srl] [int] IDENTITY(1,1) NOT NULL,
	[Srl_Post1] [int] NULL,
	[Srl_Post2] [int] NULL,
	[Distance] [int] NULL,
	[Srl_SubmitUser] [int] NULL,
	[SubmitDate] [datetime] NULL,
 CONSTRAINT [PK_Pm_Distance] PRIMARY KEY CLUSTERED 
(
	[Srl] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pm_DeviceType]    Script Date: 01/19/2011 07:20:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pm_DeviceType](
	[Srl] [int] IDENTITY(1,1) NOT NULL,
	[Srl_Parent] [int] NULL,
	[Name] [nvarchar](50) NULL,
	[Code] [nvarchar](50) NULL,
	[Srl_SubmitUser] [int] NULL,
	[SubmitDate] [datetime] NULL,
 CONSTRAINT [PK_Pm_DeviceModel] PRIMARY KEY CLUSTERED 
(
	[Srl] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pm_Device]    Script Date: 01/19/2011 07:20:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pm_Device](
	[Srl] [int] IDENTITY(1,1) NOT NULL,
	[Srl_Parent] [int] NULL,
	[Srl_Pm_DeviceType] [int] NULL,
	[Srl_Pm_Post] [int] NULL,
	[Name] [nvarchar](50) NULL,
	[Code] [nvarchar](50) NULL,
	[Srl_SubmitUser] [int] NULL,
	[SubmitDate] [datetime] NULL,
 CONSTRAINT [PK_Pm_Device] PRIMARY KEY CLUSTERED 
(
	[Srl] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pm_DayOfWeek]    Script Date: 01/19/2011 07:20:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pm_DayOfWeek](
	[Srl] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
 CONSTRAINT [PK_Pm_DayOfWeek] PRIMARY KEY CLUSTERED 
(
	[Srl] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pm_Ashkhas]    Script Date: 01/19/2011 07:20:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pm_Ashkhas](
	[Srl] [int] IDENTITY(1,1) NOT NULL,
	[Code] [int] NULL,
	[Name] [nvarchar](50) NULL,
	[Family] [nvarchar](50) NULL,
	[Adres1] [nvarchar](300) NULL,
	[Adres2] [nvarchar](300) NULL,
	[Mobile] [nvarchar](11) NULL,
	[Telephone1] [nvarchar](11) NULL,
	[Telephone2] [nvarchar](11) NULL,
	[Fax] [nvarchar](11) NULL,
	[CodeMelli] [nvarchar](50) NULL,
	[tavalod] [nvarchar](10) NULL,
	[IsActive] [bit] NULL,
	[Srl_SubmitUser] [int] NULL,
	[SubmitDate] [datetime] NULL,
	[Image] [image] NULL,
 CONSTRAINT [PK_Pm_Ashkhas] PRIMARY KEY CLUSTERED 
(
	[Srl] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
