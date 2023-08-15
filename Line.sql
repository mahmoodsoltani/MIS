USE [Nama_MIS]
GO
/****** Object:  Table [dbo].[Pm_Line]    Script Date: 06/27/2020 12:46:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pm_Line](
	[Srl] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Code] [nvarchar](50) NULL,
	[Voltage] [int] NULL,
	[CycleCount] [int] NULL,
	[LineLength] [float] NULL,
	[TowerCount] [int] NULL,
	[Srl_Group] [int] NULL,
	[Srl_SubmitUser] [int] NULL,
	[SubmitDate] [datetime] NULL,
 CONSTRAINT [PK_Pm_Line] PRIMARY KEY CLUSTERED 
(
	[Srl] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Pm_Line] ON
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (3, N'گلمکان-  شیروان', NULL, 400, 1, 147, 390, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (4, N'خواجه ربیع- کلات', NULL, 132, 2, 105.7, 238, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (5, N'خواجه ربيع- کلات', N'0', 132, 1, 105.7, 271, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (6, N'فردوسی-  گلمکان', NULL, 400, 2, 17, 45, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (7, N'فردوسی –زکریا', NULL, 400, 1, 23.1, 65, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (8, N'زکریا-تربت جام', NULL, 400, 1, 172.6, 489, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (9, N'گلمکان – نیشابور', NULL, 400, 1, 51.3, 153, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (10, N'توس – قوچان 63 ', NULL, 63, 2, 39, 150, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (11, N'توس-چناران', NULL, 132, 2, 36.6, 131, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (12, N'توس-چناران', N'0', 132, 4, 36.6, 6, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (13, N'   چناران- قوچان', NULL, 132, 2, 77.2, 219, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (14, N'شریعتی- سرخس132', NULL, 132, 2, 149.5, 471, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (15, N'شريعتي- سرخس132', N'0', 132, 1, 149.5, 457, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (16, N'سرخس – ترکمنستان  ', NULL, 230, 2, 2.2, 7, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (17, N'انشعاب ماشین ابزار', NULL, 132, 2, 0.5, 2, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (18, N'توس-سرخس2مداره', NULL, 400, 2, 25.3, 72, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (19, N'توس –فردوسی  ', NULL, 400, 1, 0.5, 4, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (20, N'دومداره تغذیه پست ابوطالب', NULL, 400, 2, 6.6, 18, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (21, N'توس-سرخس', NULL, 400, 1, 163.1, 444, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (22, N'توس – ابوطالب (دو وچهار مداره) ', NULL, 132, 2, 24.5, 111, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (23, N'توس - ابوطالب (دو وچهار مداره)', N'0', 132, 4, 24.5, 10, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (24, N'خواجه ربیع – ابوطالب   ', NULL, 132, 2, 8.7, 28, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (25, N'سربداران- مدرس', NULL, 400, 1, 127.1, 310, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (26, N'سربداران- مدرس', N'0', 400, 2, 127.1, 2, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (27, N'شادمهر- مدرس', NULL, 400, 1, 89.7, 232, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (28, N'انشعاب پردیس     ', NULL, 132, 2, 2.5, 14, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (29, N'ابوطالب- سپاد  ', NULL, 132, 4, 9.9, 9, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (30, N'ابوطالب- سپاد', N'0', 132, 1, 9.9, 34, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (31, N'پارت-درگز', NULL, 132, 2, 116.1, 349, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (32, N'سربداران-جوین', NULL, 132, 2, 54.8, 158, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (33, N'انشعاب ماشین های الکتریکی ', NULL, 132, 2, 7.8, 27, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (34, N'سربداران – سبزوار', NULL, 132, 2, 6.5, 22, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (35, N'132شریعتی-خواجه ربیع', NULL, 132, 2, 20.9, 107, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (36, N'سبزوار – داورزن ', NULL, 132, 2, 74.9, 247, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (37, N'نیشابور- اسفراین ', NULL, 400, 1, 161.6, 453, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (38, N'شریعتی- چاهک', NULL, 63, 1, 52, 403, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (39, N'انشعاب مشکان - سربداران', NULL, 400, 2, 54.7, 141, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (40, N'تغذیه پست فیروزه', NULL, 132, 1, 2.5, 3, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (41, N'تغذيه پست فيروزه', N'0', 132, 1, 2.5, 27, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (42, N'سربداران- عباس آباد', NULL, 400, 1, 85.5, 296, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (43, N'شریعتی – کوهسنگی ', NULL, 132, 2, 25.4, 127, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (44, N'شریعتی- فریمان  ', NULL, 132, 2, 62.1, 206, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (45, N'فریمان- زرین دشت', NULL, 132, 2, 48, 173, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (46, N'تربت جام- صالح آباد', NULL, 132, 1, 67.2, 235, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (47, N'شریعتی- مشهد چهار مداره  
132-63', NULL, 132, 2, 11.2, 57, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (48, N'شريعتي- مشهد چهار مداره  63-132', N'0', 63, 2, 11.2, 57, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (49, N'شادمهر- رشتخوار', NULL, 132, 2, 60.1, 195, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (50, N'رشتخوار- آسباد', NULL, 132, 2, 63.9, 213, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (51, N'توس- شهرک صنعتی  ', NULL, 132, 2, 1.6, 18, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (52, N'شهرک صنعتی گلبهار', NULL, 132, 2, 27, 103, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (53, N'تربت جام – خواف ', NULL, 400, 1, 88.6, 239, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (54, N'شریعتی- انتهای طبرسی', NULL, 63, 2, 15.5, 63, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (55, N' انشعاب خواف', NULL, 400, 2, 2.5, 8, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (56, N'خواف- شهید کاوه ', NULL, 400, 1, 154.4, 394, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (57, N'انشعاب رضوان', NULL, 63, 2, 14.6, 51, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (58, N'شادمهر- شهید کاوه', NULL, 400, 1, 177.4, 461, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (59, N'شادمهر – نیشابور', NULL, 400, 1, 139, 374, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (60, N'شادمهر – تربت جام', NULL, 400, 1, 168.3, 486, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (61, N'شادمهر- کاشمر', NULL, 132, 2, 59.8, 180, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (62, N'شادمهر- تربت حیدریه  ', NULL, 132, 2, 11.8, 39, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (63, N'توس- کوهسنگی 132', NULL, 132, 2, 26.4, 129, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (64, N'انشعاب دانشجو ', NULL, 132, 2, 5, 29, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (65, N'انشعاب راشد ', NULL, 132, 2, 6.8, 25, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (66, N'تربت حیدریه- ابوسعید', NULL, 132, 2, 11.9, 41, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (67, N'انشعاب سیمان زاوه', NULL, 132, 2, 1.18, 5, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (68, N'انشعاب دولت آباد', NULL, 132, 2, 28.5, 99, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (69, N'کاشمر- مدرس    ', NULL, 132, 2, 20.7, 100, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (70, N'کاشمر- مدرس', N'0', 132, 1, 20.7, 3, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (71, N'انشعاب خلیل   ', NULL, 132, 2, 3.4, 12, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (72, N'مدرس – بردسکن ', NULL, 132, 2, 16.2, 52, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (73, N'بردسکن- انابد  ', NULL, 132, 2, 17.3, 60, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (74, N'توس- کوهسنگی 63', NULL, 63, 2, 25.6, 109, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (75, N'کوهسنگی- مشهد', NULL, 63, 2, 20.9, 99, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (76, N'شریعتی- عطار', NULL, 132, 2, 112.8, 362, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (77, N'شادمهر- عطار', NULL, 132, 2, 135.2, 423, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (78, N'شهرک صنعتی – امامیه', NULL, 132, 2, 10.3, 50, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (79, N'انشعاب ریوش', NULL, 132, 2, 28.5, 133, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (80, N'انشعاب فتح آباد', NULL, 132, 2, 17.6, 60, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (81, N'فریمان- خیر آباد', NULL, 132, 2, 46.2, 130, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (82, N'خیر آباد- تربت جام', NULL, 132, 2, 42.9, 130, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (83, N'انشعاب سنگان ', NULL, 132, 2, 12, 44, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (84, N'انشعاب سیمان شرق', NULL, 63, 2, 18.8, 74, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (85, N'ارتباط تایباد- آسباد به خواف', NULL, 132, 4, 1.7, 9, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (86, N'انشعاب شهرک صنعتی تایباد', NULL, 132, 2, 14, 50, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (87, N'تربت جام- تایباد', NULL, 132, 2, 59.7, 171, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (88, N'تایباد-آسباد', NULL, 132, 2, 68.7, 241, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (89, N'انشعاب وحدت', NULL, 132, 2, 1.87, 8, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (90, N'انشعاب نیل آباد', NULL, 132, 2, 7.75, 27, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (91, N'تربت جام- باخرز ', NULL, 132, 2, 45.9, 154, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (92, N'تربت جام- جامی', NULL, 132, 2, 8, 27, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (93, N'تربت جام- دوغارون', NULL, 132, 2, 71.7, 240, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (94, N'توس – مشهد', NULL, 63, 2, 36.6, 167, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (95, N'عطار- سلطان آباد', NULL, 132, 2, 110.7, 205, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (96, N'سلطان آباد- سبزوار', NULL, 132, 2, 72.5, 126, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (97, N'رابط نیشابور،عطار - سبزوار', NULL, 132, 2, 16, 59, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (98, N'نیروگاه سیکل ترکیبی نیشابور-پست400کیلوولت نیشابور', NULL, 400, 1, 0.5, 7, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (99, N'نيروگاه سيکل ترکيبي نيشابور- پست 400', N'0', 400, 2, 0.5, 5, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (100, N'عطار-نیشابور', NULL, 132, 2, 12.3, 49, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (101, N'تغذیه شهرک صنعتی عطار', NULL, 132, 2, 48, 52, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (102, N'سلطان آباد-صبا', NULL, 132, 2, 45, 119, NULL, NULL, NULL)
GO
print 'Processed 100 total records'
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (103, N' 63شریعتی- خواجه ربیع', NULL, 63, 2, 17.7, 72, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (104, N'کلات –  درگز', NULL, 132, 1, 74.2, 242, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (105, N'شادمهر- فیض آباد', NULL, 132, 2, 35.9, 120, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (106, N'فیض آباد- گناباد', NULL, 132, 2, 88, 301, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (107, N'شریعتی- دیزباد', NULL, 63, 2, 61.1, 245, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (108, N'انشعاب جنگل ', NULL, 132, 2, 36.6, 120, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (109, N'انشعاب شهرک صنعتی مهولات(شهرک صنعتی- مهولات)', NULL, 132, 2, 4, 14, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (110, N'انشعاب سردق   ', NULL, 132, 2, 70.7, 210, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (111, N'گلبهار- اخلمد', NULL, 132, 2, 9.1, 39, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (112, N'دیزباد- عطار', NULL, 63, 1, 49.5, 125, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (113, N'ديزباد- عطار', N'0', 63, 1, 49.5, 44, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (114, N'عطار- خیام', NULL, 132, 2, 2.9, 11, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (115, N'سربداران- بیهق   ', NULL, 132, 2, 11.6, 42, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (116, N'سنگرد- بیهق', NULL, 132, 2, 51.5, 180, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (117, N'شهید کاوه- گلشن طبس ', NULL, 400, 1, 230, 599, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (118, N'بابا امان قلضی', NULL, 132, 2, 64.7, 241, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (119, N'انشعاب آشخانه', NULL, 132, 2, 0.46, 3, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (120, N'انشعاب شیرین دره', NULL, 132, 2, 0.3, 3, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (121, N'انشعاب بجنورد', NULL, 132, 2, 3, 21, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (122, N'انشعاب بدرانلو', NULL, 132, 2, 5.9, 21, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (123, N'انشعاب غلامان', NULL, 132, 2, 56.9, 180, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (124, N'قاضی-بدر الدین', NULL, 132, 2, 70.6, 256, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (125, N'132کیلوولت شیروان-مهرگان', NULL, 132, 2, 61.1, 185, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (126, N'400کیلوولت جاجرم-حق الخواجه ', NULL, 400, 1, 36.3, 109, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (127, N'132کیلوولت اسفراین-جوین', NULL, 132, 2, 48.3, 151, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (128, N'اسفراین-مهرگان', NULL, 132, 2, 15.4, 82, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (129, N'400کیلوولت شیروان-اسفراین2', NULL, 400, 1, 72, 188, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (130, N'نیروگاه سیکل ترکیبی شیروان-پست400کیلوولت شیروان', NULL, 400, 1, 0.4, 3, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (131, N'نيروگاه سيکل ترکيبي شيروان', N'0', 400, 2, 0.4, 3, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (132, N'132کیلوولت شیروان-پارت', NULL, 132, 2, 12.7, 41, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (133, N'بجنورد-اسفراین', NULL, 400, 1, 55, 164, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (134, N'400کیلوولت شیروان-اسفراین1', NULL, 400, 1, 73.2, 216, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (135, N'بدرالدین-داورزن
(جاجرم-داورزن)', NULL, 132, 2, 83.1, 303, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (136, N'132کیلوولت انشعاب آزادوار', NULL, 132, 2, 19.6, 66, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (137, N'132کیلوولت شیروان-قوچان', NULL, 132, 2, 49.2, 145, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (138, N'انشعاب نیروگاه جدید شیروان', NULL, 132, 2, 10.3, 38, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (139, N'132کیلوولت(پارت) شیروان-بابا امان', NULL, 132, 2, 57, 171, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (140, N'400کیلوولت اسفراین-جاجرم ', NULL, 400, 1, 91, 249, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (141, N'132کیلوولت قاین-قاینات', NULL, 132, 2, 8.9, 36, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (142, N'132کیلوولت فردوس-بشرویه', NULL, 132, 2, 76.4, 250, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (143, N'132کیلوولت بشرویه-طبس', NULL, 132, 2, 65, 195, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (144, N'132 رابط طبس-گلشن طبس', NULL, 132, 2, 9, 63, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (145, N'طبس-عشق آباد', NULL, 132, 1, 89.7, 299, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (146, N'قائن-فردوس', NULL, 132, 2, 119.2, 432, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (147, N'132سربیشه-اسد آباد', NULL, 132, 2, 50.7, 180, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (148, N'400کیلوولت شهید کاوه-بیرجند', NULL, 400, 1, 122.9, 316, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (149, N'132درح-سربیشه', NULL, 132, 2, 78, 260, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (150, N'بیرجند-سربیشه', NULL, 132, 2, 43, 140, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (151, N'132کیلوولت بیرجند-حکیم نزاری', NULL, 132, 2, 24.5, 86, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (152, N'132کیلوولت قاینات-گناباد', NULL, 132, 2, 82.2, 291, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (153, N'132کیلوولت انشعاب خضری', NULL, 132, 2, 4.3, 16, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (154, N'132کیلوولت قاینات-حاجی آباد', NULL, 132, 1, 85.3, 600, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (155, N'سربیشه-نهبندان', NULL, 132, 2, 120.7, 418, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (156, N'132کیلوولت قاین-حکیم نزاری', NULL, 132, 2, 100.9, 353, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (157, N'132انشعاب فرزان بیرجند', NULL, 132, 2, 0.9, 3, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (158, N'132حکیم نزاری-خوسف', NULL, 132, 2, 30.1, 100, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (159, N'انشعاب شهرک صنعتی بیرجند', NULL, 132, 2, 0.8, 5, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (160, N'132گناباد-کبیر کوه', NULL, 132, 1, 81, 243, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (161, N'132قاینات-بزرگمهر', NULL, 132, 2, 13.5, 45, NULL, NULL, NULL)
INSERT [dbo].[Pm_Line] ([Srl], [Name], [Code], [Voltage], [CycleCount], [LineLength], [TowerCount], [Srl_Group], [Srl_SubmitUser], [SubmitDate]) VALUES (162, N'400کیلوولت رابط قاینات-شهید کاوه', NULL, 400, 2, 0.9, 5, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Pm_Line] OFF
