USE [OsirisDB]
GO
/****** Object:  Table [dbo].[DeviceInfo]    Script Date: 10/25/2016 22:10:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DeviceInfo](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DeviceId] [varchar](20) NOT NULL,
	[Brightness] [varchar](10) NULL,
	[Temperature] [varchar](10) NULL,
	[Powerwaste] [varchar](10) NULL,
	[ViewModel] [varchar](10) NULL,
	[Switch] [varchar](10) NULL,
	[IsLock] [bit] NULL,
	[Lon] [varchar](20) NULL,
	[Lat] [varchar](20) NULL,
	[CreateTime] [datetime] NULL,
	[UpdateTime] [datetime] NULL,
	[Creator] [varchar](20) NULL,
	[Remark] [nvarchar](50) NULL,
	[Gyroscope] [varchar](20) NULL,
 CONSTRAINT [PK__DeviceIn__3214EC0707020F21] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[DeviceInfo] ON
INSERT [dbo].[DeviceInfo] ([Id], [DeviceId], [Brightness], [Temperature], [Powerwaste], [ViewModel], [Switch], [IsLock], [Lon], [Lat], [CreateTime], [UpdateTime], [Creator], [Remark], [Gyroscope]) VALUES (1, N'11-22-33-44-55', N'100', N'11.2', N'11.0', N'0', N'1', 0, N'121.631298', N'31.182384', CAST(0x0000A69E015EDAD6 AS DateTime), CAST(0x0000A6A801495BBC AS DateTime), N'admin', N'Gyroscope', N'Gyroscope')
INSERT [dbo].[DeviceInfo] ([Id], [DeviceId], [Brightness], [Temperature], [Powerwaste], [ViewModel], [Switch], [IsLock], [Lon], [Lat], [CreateTime], [UpdateTime], [Creator], [Remark], [Gyroscope]) VALUES (3, N'11-22-33-44-44', N'2', N'37.8', N'1.12', N'1', N'0', 1, N'121.48', N'31.48', CAST(0x0000A69E015EDAD6 AS DateTime), CAST(0x0000A6A20120C7D5 AS DateTime), N'admin', N'1122', N'暂定为string')
INSERT [dbo].[DeviceInfo] ([Id], [DeviceId], [Brightness], [Temperature], [Powerwaste], [ViewModel], [Switch], [IsLock], [Lon], [Lat], [CreateTime], [UpdateTime], [Creator], [Remark], [Gyroscope]) VALUES (4, N'11-22-33-44-33', N'2', N'37.8', N'1.12', N'1', N'0', 1, N'121.48', N'31.28', CAST(0x0000A69E015EDAD6 AS DateTime), CAST(0x0000A6A20120C7D5 AS DateTime), N'admin', N'1122', N'暂定为string')
INSERT [dbo].[DeviceInfo] ([Id], [DeviceId], [Brightness], [Temperature], [Powerwaste], [ViewModel], [Switch], [IsLock], [Lon], [Lat], [CreateTime], [UpdateTime], [Creator], [Remark], [Gyroscope]) VALUES (5, N'11-22-33-44-22', N'2', N'37.8', N'1.12', N'1', N'1', 0, N'121.48', N'31.43', CAST(0x0000A69E015EDAD6 AS DateTime), CAST(0x0000A6A20120C7D5 AS DateTime), N'admin', N'1122', N'暂定为string')
INSERT [dbo].[DeviceInfo] ([Id], [DeviceId], [Brightness], [Temperature], [Powerwaste], [ViewModel], [Switch], [IsLock], [Lon], [Lat], [CreateTime], [UpdateTime], [Creator], [Remark], [Gyroscope]) VALUES (6, N'11-22-33-44-11', N'2', N'37.8', N'1.12', N'1', N'0', 0, N'121.48', N'31.42', CAST(0x0000A69E015EDAD6 AS DateTime), CAST(0x0000A6A20120C7D5 AS DateTime), N'admin', N'1122', N'暂定为string')
INSERT [dbo].[DeviceInfo] ([Id], [DeviceId], [Brightness], [Temperature], [Powerwaste], [ViewModel], [Switch], [IsLock], [Lon], [Lat], [CreateTime], [UpdateTime], [Creator], [Remark], [Gyroscope]) VALUES (7, N'11-22-33-44-66', N'2', N'37.8', N'1.12', N'1', N'1', 0, N'121.48', N'31.41', CAST(0x0000A69E015EDAD6 AS DateTime), CAST(0x0000A6A20120C7D5 AS DateTime), N'admin', N'1122', N'暂定为string')
INSERT [dbo].[DeviceInfo] ([Id], [DeviceId], [Brightness], [Temperature], [Powerwaste], [ViewModel], [Switch], [IsLock], [Lon], [Lat], [CreateTime], [UpdateTime], [Creator], [Remark], [Gyroscope]) VALUES (8, N'11-22-33-44-77', N'2', N'37.8', N'1.12', N'1', N'0', 1, N'121.48', N'31.39', CAST(0x0000A69E015EDAD6 AS DateTime), CAST(0x0000A6A20120C7D5 AS DateTime), N'admin', N'1122', N'暂定为string')
INSERT [dbo].[DeviceInfo] ([Id], [DeviceId], [Brightness], [Temperature], [Powerwaste], [ViewModel], [Switch], [IsLock], [Lon], [Lat], [CreateTime], [UpdateTime], [Creator], [Remark], [Gyroscope]) VALUES (9, N'11-22-33-44-88', N'2', N'37.8', N'1.12', N'1', N'0', 0, N'121.48', N'31.38', CAST(0x0000A69E015EDAD6 AS DateTime), CAST(0x0000A6A20120C7D5 AS DateTime), N'admin', N'1122', N'暂定为string')
INSERT [dbo].[DeviceInfo] ([Id], [DeviceId], [Brightness], [Temperature], [Powerwaste], [ViewModel], [Switch], [IsLock], [Lon], [Lat], [CreateTime], [UpdateTime], [Creator], [Remark], [Gyroscope]) VALUES (10, N'11-22-33-44-99', N'2', N'37.8', N'1.12', N'1', N'0', 0, N'121.48', N'31.37', CAST(0x0000A69E015EDAD6 AS DateTime), CAST(0x0000A6A20120C7D5 AS DateTime), N'admin', N'1122', N'暂定为string')
INSERT [dbo].[DeviceInfo] ([Id], [DeviceId], [Brightness], [Temperature], [Powerwaste], [ViewModel], [Switch], [IsLock], [Lon], [Lat], [CreateTime], [UpdateTime], [Creator], [Remark], [Gyroscope]) VALUES (11, N'11-22-33-44-00', N'2', N'37.8', N'1.12', N'1', N'0', 0, N'121.48', N'31.36', CAST(0x0000A69E015EDAD6 AS DateTime), CAST(0x0000A6A20120C7D5 AS DateTime), N'admin', N'1122', N'暂定为string')
INSERT [dbo].[DeviceInfo] ([Id], [DeviceId], [Brightness], [Temperature], [Powerwaste], [ViewModel], [Switch], [IsLock], [Lon], [Lat], [CreateTime], [UpdateTime], [Creator], [Remark], [Gyroscope]) VALUES (12, N'11-22-33-11-55', N'2', N'37.8', N'1.12', N'1', N'1', 0, N'121.46', N'31.35', CAST(0x0000A69E015EDAD6 AS DateTime), CAST(0x0000A6A20120C7D5 AS DateTime), N'admin', N'1122', N'暂定为string')
INSERT [dbo].[DeviceInfo] ([Id], [DeviceId], [Brightness], [Temperature], [Powerwaste], [ViewModel], [Switch], [IsLock], [Lon], [Lat], [CreateTime], [UpdateTime], [Creator], [Remark], [Gyroscope]) VALUES (13, N'11-22-33-22-55', N'2', N'37.8', N'1.12', N'1', N'1', 0, N'121.47', N'31.33', CAST(0x0000A69E015EDAD6 AS DateTime), CAST(0x0000A6A20120C7D5 AS DateTime), N'admin', N'1122', N'暂定为string')
INSERT [dbo].[DeviceInfo] ([Id], [DeviceId], [Brightness], [Temperature], [Powerwaste], [ViewModel], [Switch], [IsLock], [Lon], [Lat], [CreateTime], [UpdateTime], [Creator], [Remark], [Gyroscope]) VALUES (14, N'11-22-33-33-55', N'2', N'37.8', N'1.12', N'1', N'1', 0, N'121.38', N'31.32', CAST(0x0000A69E015EDAD6 AS DateTime), CAST(0x0000A6A20120C7D5 AS DateTime), N'admin', N'1122', N'暂定为string')
INSERT [dbo].[DeviceInfo] ([Id], [DeviceId], [Brightness], [Temperature], [Powerwaste], [ViewModel], [Switch], [IsLock], [Lon], [Lat], [CreateTime], [UpdateTime], [Creator], [Remark], [Gyroscope]) VALUES (15, N'11-22-33-55-55', N'2', N'37.8', N'1.12', N'1', N'0', 0, N'121.33', N'31.30', CAST(0x0000A69E015EDAD6 AS DateTime), CAST(0x0000A6A20120C7D5 AS DateTime), N'admin', N'1122', N'暂定为string')
INSERT [dbo].[DeviceInfo] ([Id], [DeviceId], [Brightness], [Temperature], [Powerwaste], [ViewModel], [Switch], [IsLock], [Lon], [Lat], [CreateTime], [UpdateTime], [Creator], [Remark], [Gyroscope]) VALUES (16, N'11-22-33-66-55', N'2', N'37.8', N'1.12', N'1', N'0', 0, N'121.35', N'31.29', CAST(0x0000A69E015EDAD6 AS DateTime), CAST(0x0000A6A20120C7D5 AS DateTime), N'admin', N'1122', N'暂定为string')
INSERT [dbo].[DeviceInfo] ([Id], [DeviceId], [Brightness], [Temperature], [Powerwaste], [ViewModel], [Switch], [IsLock], [Lon], [Lat], [CreateTime], [UpdateTime], [Creator], [Remark], [Gyroscope]) VALUES (17, N'11-22-33-77-55', N'2', N'37.8', N'1.12', N'1', N'1', 0, N'121.21', N'31.28', CAST(0x0000A69E015EDAD6 AS DateTime), CAST(0x0000A6A20120C7D5 AS DateTime), N'admin', N'1122', N'暂定为string')
INSERT [dbo].[DeviceInfo] ([Id], [DeviceId], [Brightness], [Temperature], [Powerwaste], [ViewModel], [Switch], [IsLock], [Lon], [Lat], [CreateTime], [UpdateTime], [Creator], [Remark], [Gyroscope]) VALUES (18, N'11-22-33-88-55', N'2', N'37.8', N'1.12', N'1', N'0', 0, N'121.37', N'31.22', CAST(0x0000A69E015EDAD6 AS DateTime), CAST(0x0000A6A20120C7D5 AS DateTime), N'admin', N'1122', N'暂定为string')
INSERT [dbo].[DeviceInfo] ([Id], [DeviceId], [Brightness], [Temperature], [Powerwaste], [ViewModel], [Switch], [IsLock], [Lon], [Lat], [CreateTime], [UpdateTime], [Creator], [Remark], [Gyroscope]) VALUES (19, N'11-22-33-99-55', N'2', N'37.8', N'1.12', N'1', N'1', 0, N'121.23', N'31.27', CAST(0x0000A69E015EDAD6 AS DateTime), CAST(0x0000A6A20120C7D5 AS DateTime), N'admin', N'1122', N'暂定为string')
INSERT [dbo].[DeviceInfo] ([Id], [DeviceId], [Brightness], [Temperature], [Powerwaste], [ViewModel], [Switch], [IsLock], [Lon], [Lat], [CreateTime], [UpdateTime], [Creator], [Remark], [Gyroscope]) VALUES (20, N'11-22-33-00-55', N'2', N'37.8', N'1.12', N'1', N'0', 0, N'121.26', N'31.26', CAST(0x0000A69E015EDAD6 AS DateTime), CAST(0x0000A6A20120C7D5 AS DateTime), N'admin', N'1122', N'暂定为string')
INSERT [dbo].[DeviceInfo] ([Id], [DeviceId], [Brightness], [Temperature], [Powerwaste], [ViewModel], [Switch], [IsLock], [Lon], [Lat], [CreateTime], [UpdateTime], [Creator], [Remark], [Gyroscope]) VALUES (21, N'11-22-11-44-55', N'2', N'37.8', N'1.12', N'1', N'0', 0, N'121.41', N'31.23', CAST(0x0000A69E015EDAD6 AS DateTime), CAST(0x0000A6A20120C7D5 AS DateTime), N'admin', N'1122', N'暂定为string')
INSERT [dbo].[DeviceInfo] ([Id], [DeviceId], [Brightness], [Temperature], [Powerwaste], [ViewModel], [Switch], [IsLock], [Lon], [Lat], [CreateTime], [UpdateTime], [Creator], [Remark], [Gyroscope]) VALUES (22, N'11-22-22-44-55', N'2', N'37.8', N'1.12', N'1', N'0', 0, N'121.40', N'31.24', CAST(0x0000A69E015EDAD6 AS DateTime), CAST(0x0000A6A20120C7D5 AS DateTime), N'admin', N'1122', N'暂定为string')
INSERT [dbo].[DeviceInfo] ([Id], [DeviceId], [Brightness], [Temperature], [Powerwaste], [ViewModel], [Switch], [IsLock], [Lon], [Lat], [CreateTime], [UpdateTime], [Creator], [Remark], [Gyroscope]) VALUES (23, N'11-22-44-44-55', N'2', N'37.8', N'1.12', N'1', N'0', 0, N'121.48', N'31.25', CAST(0x0000A69E015EDAD6 AS DateTime), CAST(0x0000A6A20120C7D5 AS DateTime), N'admin', N'1122', N'暂定为string')
SET IDENTITY_INSERT [dbo].[DeviceInfo] OFF
/****** Object:  Table [dbo].[DeviceAd]    Script Date: 10/25/2016 22:10:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DeviceAd](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[AdType] [int] NULL,
	[AdText] [varchar](500) NULL,
	[AdPath] [varchar](100) NULL,
	[ThumbPath] [varchar](100) NULL,
	[RepeatNum] [int] NULL,
	[Eare] [nvarchar](10) NULL,
	[BeginTime] [datetime] NULL,
	[EndTime] [datetime] NULL,
	[CreateTime] [datetime] NULL,
	[UpdateTime] [datetime] NULL,
	[Creator] [varchar](20) NULL,
	[Remark] [nvarchar](50) NULL,
 CONSTRAINT [PK__DeviceAd__3214EC071367E606] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[DeviceAd] ON
INSERT [dbo].[DeviceAd] ([Id], [AdType], [AdText], [AdPath], [ThumbPath], [RepeatNum], [Eare], [BeginTime], [EndTime], [CreateTime], [UpdateTime], [Creator], [Remark]) VALUES (1, 0, N'这是著名广告大师伯恩巴克的灵感之作，堪称经典，流传至今。它既反映了M&M巧克力糖衣包装的独特USP，又暗示M&M巧克力口味好，以至于我们不愿意使巧克力在手上停留片刻。', N'', NULL, 10, N'无', CAST(0x0000A69B00C91AD0 AS DateTime), CAST(0x0000A69B00C91AD0 AS DateTime), CAST(0x0000A69E015FCB23 AS DateTime), CAST(0x0000A69E015FCB23 AS DateTime), N'admin', N'')
INSERT [dbo].[DeviceAd] ([Id], [AdType], [AdText], [AdPath], [ThumbPath], [RepeatNum], [Eare], [BeginTime], [EndTime], [CreateTime], [UpdateTime], [Creator], [Remark]) VALUES (2, 1, NULL, N'/FileStore/AdFiles/Photos/ad1.png', N'/FileStore/AdFiles/Photos/thumb/ad1.png', 5, N'无', CAST(0x0000A69B00B8A010 AS DateTime), CAST(0x0000A69B00C91AD0 AS DateTime), CAST(0x0000A69E01617220 AS DateTime), CAST(0x0000A69E01617220 AS DateTime), N'admin', NULL)
INSERT [dbo].[DeviceAd] ([Id], [AdType], [AdText], [AdPath], [ThumbPath], [RepeatNum], [Eare], [BeginTime], [EndTime], [CreateTime], [UpdateTime], [Creator], [Remark]) VALUES (3, 2, NULL, N'/FileStore/AdFiles/Videos/v1.avi', N'/FileStore/AdFiles/Videos/thumb/v1.png', 10, N'无', CAST(0x0000A69B016DE650 AS DateTime), CAST(0x0000A69B00C91AD0 AS DateTime), CAST(0x0000A69E0161CAB3 AS DateTime), CAST(0x0000A69E0161CAB3 AS DateTime), N'admin', NULL)
INSERT [dbo].[DeviceAd] ([Id], [AdType], [AdText], [AdPath], [ThumbPath], [RepeatNum], [Eare], [BeginTime], [EndTime], [CreateTime], [UpdateTime], [Creator], [Remark]) VALUES (4, 1, NULL, N'/FileStore/AdFiles/Photos/ad2.jpg', N'/FileStore/AdFiles/Photos/thumb/ad2.jpg', 5, N'无', CAST(0x0000A69B00D99590 AS DateTime), CAST(0x0000A69B00C91AD0 AS DateTime), CAST(0x0000A69E01617220 AS DateTime), CAST(0x0000A69E01617220 AS DateTime), N'admin', NULL)
INSERT [dbo].[DeviceAd] ([Id], [AdType], [AdText], [AdPath], [ThumbPath], [RepeatNum], [Eare], [BeginTime], [EndTime], [CreateTime], [UpdateTime], [Creator], [Remark]) VALUES (5, 2, NULL, N'/FileStore/AdFiles/Videos/v2.avi', N'/FileStore/AdFiles/Videos/thumb/v2.png', 10, N'无', CAST(0x0000A69B00EA1050 AS DateTime), CAST(0x0000A69B00C91AD0 AS DateTime), CAST(0x0000A69E0161CAB3 AS DateTime), CAST(0x0000A69E0161CAB3 AS DateTime), N'admin', NULL)
INSERT [dbo].[DeviceAd] ([Id], [AdType], [AdText], [AdPath], [ThumbPath], [RepeatNum], [Eare], [BeginTime], [EndTime], [CreateTime], [UpdateTime], [Creator], [Remark]) VALUES (6, 1, NULL, N'/FileStore/AdFiles/Photos/ad3.jpg', N'/FileStore/AdFiles/Photos/thumb/ad3.jpg', 5, N'无', CAST(0x0000A69B00FA8B10 AS DateTime), CAST(0x0000A69B00C91AD0 AS DateTime), CAST(0x0000A69E01617220 AS DateTime), CAST(0x0000A69E01617220 AS DateTime), N'admin', NULL)
INSERT [dbo].[DeviceAd] ([Id], [AdType], [AdText], [AdPath], [ThumbPath], [RepeatNum], [Eare], [BeginTime], [EndTime], [CreateTime], [UpdateTime], [Creator], [Remark]) VALUES (7, 2, NULL, N'/FileStore/AdFiles/Videos/v3.avi', N'/FileStore/AdFiles/Videos/thumb/v3.png', 10, N'无', CAST(0x0000A69B010B05D0 AS DateTime), CAST(0x0000A69B00C91AD0 AS DateTime), CAST(0x0000A69E0161CAB3 AS DateTime), CAST(0x0000A69E0161CAB3 AS DateTime), N'admin', NULL)
INSERT [dbo].[DeviceAd] ([Id], [AdType], [AdText], [AdPath], [ThumbPath], [RepeatNum], [Eare], [BeginTime], [EndTime], [CreateTime], [UpdateTime], [Creator], [Remark]) VALUES (8, 1, NULL, N'/FileStore/AdFiles/Photos/ad4.png', N'/FileStore/AdFiles/Photos/thumb/ad4.png', 5, N'无', CAST(0x0000A69B011B8090 AS DateTime), CAST(0x0000A69B00C91AD0 AS DateTime), CAST(0x0000A69E01617220 AS DateTime), CAST(0x0000A69E01617220 AS DateTime), N'admin', NULL)
INSERT [dbo].[DeviceAd] ([Id], [AdType], [AdText], [AdPath], [ThumbPath], [RepeatNum], [Eare], [BeginTime], [EndTime], [CreateTime], [UpdateTime], [Creator], [Remark]) VALUES (9, 2, NULL, N'/FileStore/AdFiles/Videos/v4.mp4', N'/FileStore/AdFiles/Videos/thumb/v4.png', 10, N'无', CAST(0x0000A69B012BFB50 AS DateTime), CAST(0x0000A69B00C91AD0 AS DateTime), CAST(0x0000A69E0161CAB3 AS DateTime), CAST(0x0000A69E0161CAB3 AS DateTime), N'admin', NULL)
INSERT [dbo].[DeviceAd] ([Id], [AdType], [AdText], [AdPath], [ThumbPath], [RepeatNum], [Eare], [BeginTime], [EndTime], [CreateTime], [UpdateTime], [Creator], [Remark]) VALUES (10, 1, NULL, N'/FileStore/AdFiles/Photos/ad5.jpg', N'/FileStore/AdFiles/Photos/thumb/ad5.jpg', 5, N'无', CAST(0x0000A69B013C7610 AS DateTime), CAST(0x0000A69B00C91AD0 AS DateTime), CAST(0x0000A69E01617220 AS DateTime), CAST(0x0000A69E01617220 AS DateTime), N'admin', NULL)
INSERT [dbo].[DeviceAd] ([Id], [AdType], [AdText], [AdPath], [ThumbPath], [RepeatNum], [Eare], [BeginTime], [EndTime], [CreateTime], [UpdateTime], [Creator], [Remark]) VALUES (11, 2, NULL, N'/FileStore/AdFiles/Videos/v1.avi', N'/FileStore/AdFiles/Videos/thumb/v1.png', 10, N'无', CAST(0x0000A69B014CF0D0 AS DateTime), CAST(0x0000A69B00C91AD0 AS DateTime), CAST(0x0000A69E0161CAB3 AS DateTime), CAST(0x0000A69E0161CAB3 AS DateTime), N'admin', NULL)
INSERT [dbo].[DeviceAd] ([Id], [AdType], [AdText], [AdPath], [ThumbPath], [RepeatNum], [Eare], [BeginTime], [EndTime], [CreateTime], [UpdateTime], [Creator], [Remark]) VALUES (12, 1, NULL, N'/FileStore/AdFiles/Photos/ad6.jpg', N'/FileStore/AdFiles/Photos/thumb/ad6.jpg', 5, N'无', CAST(0x0000A69B015D6B90 AS DateTime), CAST(0x0000A69B00C91AD0 AS DateTime), CAST(0x0000A69E01617220 AS DateTime), CAST(0x0000A69E01617220 AS DateTime), N'admin', NULL)
INSERT [dbo].[DeviceAd] ([Id], [AdType], [AdText], [AdPath], [ThumbPath], [RepeatNum], [Eare], [BeginTime], [EndTime], [CreateTime], [UpdateTime], [Creator], [Remark]) VALUES (13, 2, NULL, N'/FileStore/AdFiles/Videos/v2.avi', N'/FileStore/AdFiles/Videos/thumb/v2.png', 10, N'无', CAST(0x0000A69B017E6110 AS DateTime), CAST(0x0000A69B00C91AD0 AS DateTime), CAST(0x0000A69E0161CAB3 AS DateTime), CAST(0x0000A69E0161CAB3 AS DateTime), N'admin', NULL)
INSERT [dbo].[DeviceAd] ([Id], [AdType], [AdText], [AdPath], [ThumbPath], [RepeatNum], [Eare], [BeginTime], [EndTime], [CreateTime], [UpdateTime], [Creator], [Remark]) VALUES (14, 0, N'在与可口可乐的竞争中，百事可乐终于找到突破口，它们从年轻人身上发现市场，把自己定位为新生代的可乐，邀请新生代喜欢的超级歌星作为自己的品牌代言人，终于赢得青年人的青睐。一句广告语明确的传达了品牌的定位，创造了一个市场，这句广告语居功至伟。', N'', NULL, 10, N'无', CAST(0x0000A69B00A82550 AS DateTime), CAST(0x0000A69B00C91AD0 AS DateTime), CAST(0x0000A69E015FCB23 AS DateTime), CAST(0x0000A69E015FCB23 AS DateTime), N'admin', N'')
INSERT [dbo].[DeviceAd] ([Id], [AdType], [AdText], [AdPath], [ThumbPath], [RepeatNum], [Eare], [BeginTime], [EndTime], [CreateTime], [UpdateTime], [Creator], [Remark]) VALUES (15, 0, N'60年代的美国汽车市场是大型车的天下，大众的甲克虫刚进入美国时根本就没有市场，伯恩巴克再次拯救了大众的甲克虫，提出“think', N'', NULL, 10, N'无', CAST(0x0000A69B0097AA90 AS DateTime), CAST(0x0000A69B00C91AD0 AS DateTime), CAST(0x0000A69E015FCB23 AS DateTime), CAST(0x0000A69E015FCB23 AS DateTime), N'admin', N'')
SET IDENTITY_INSERT [dbo].[DeviceAd] OFF
/****** Object:  Table [dbo].[Coordinate]    Script Date: 10/25/2016 22:10:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Coordinate](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Eare] [nvarchar](10) NULL,
	[Lon] [varchar](20) NULL,
	[lat] [varchar](20) NULL,
	[LogoName] [nvarchar](30) NULL,
	[CreateTime] [datetime] NULL,
	[UpdateTime] [datetime] NULL,
	[Creator] [varchar](20) NULL,
	[Remark] [nvarchar](50) NULL,
 CONSTRAINT [PK__Coordina__3214EC070DAF0CB0] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Coordinate] ON
INSERT [dbo].[Coordinate] ([Id], [Eare], [Lon], [lat], [LogoName], [CreateTime], [UpdateTime], [Creator], [Remark]) VALUES (1, N'黄浦区', N'121.48', N'31.23', N'上海市政府', CAST(0x0000A6A2015F175F AS DateTime), CAST(0x0000A6A2015F175F AS DateTime), N'admin', NULL)
INSERT [dbo].[Coordinate] ([Id], [Eare], [Lon], [lat], [LogoName], [CreateTime], [UpdateTime], [Creator], [Remark]) VALUES (2, N'卢湾区', N'121.47', N'31.22', N'新天地', CAST(0x0000A6A2015F3339 AS DateTime), CAST(0x0000A6A2015F3339 AS DateTime), N'admin', NULL)
INSERT [dbo].[Coordinate] ([Id], [Eare], [Lon], [lat], [LogoName], [CreateTime], [UpdateTime], [Creator], [Remark]) VALUES (3, N'徐汇区', N'121.43', N'31.18', N'天主教堂', CAST(0x0000A6A2015F5CC7 AS DateTime), CAST(0x0000A6A2015F5CC7 AS DateTime), N'admin', NULL)
INSERT [dbo].[Coordinate] ([Id], [Eare], [Lon], [lat], [LogoName], [CreateTime], [UpdateTime], [Creator], [Remark]) VALUES (4, N'长宁区', N'121.42', N'31.22', N'国贸大厦', CAST(0x0000A6A2015F8B09 AS DateTime), CAST(0x0000A6A2015F8B09 AS DateTime), N'admin', NULL)
INSERT [dbo].[Coordinate] ([Id], [Eare], [Lon], [lat], [LogoName], [CreateTime], [UpdateTime], [Creator], [Remark]) VALUES (5, N'静安区', N'121.45', N'31.23', N'静安寺', CAST(0x0000A6A2015FA4EA AS DateTime), CAST(0x0000A6A2015FA4EA AS DateTime), N'admin', NULL)
INSERT [dbo].[Coordinate] ([Id], [Eare], [Lon], [lat], [LogoName], [CreateTime], [UpdateTime], [Creator], [Remark]) VALUES (6, N'普陀区', N'121.4', N'31.25', N'玉佛寺', CAST(0x0000A6A2015FC42F AS DateTime), CAST(0x0000A6A2015FC42F AS DateTime), N'admin', NULL)
INSERT [dbo].[Coordinate] ([Id], [Eare], [Lon], [lat], [LogoName], [CreateTime], [UpdateTime], [Creator], [Remark]) VALUES (7, N'闸北区', N'121.45', N'31.25', N'火车站', CAST(0x0000A6A2015FEC02 AS DateTime), CAST(0x0000A6A2015FEC02 AS DateTime), N'admin', NULL)
INSERT [dbo].[Coordinate] ([Id], [Eare], [Lon], [lat], [LogoName], [CreateTime], [UpdateTime], [Creator], [Remark]) VALUES (8, N'虹口区', N'121.5', N'31.27', N'鲁迅公园', CAST(0x0000A6A2015FFB65 AS DateTime), CAST(0x0000A6A2015FFB65 AS DateTime), N'admin', NULL)
INSERT [dbo].[Coordinate] ([Id], [Eare], [Lon], [lat], [LogoName], [CreateTime], [UpdateTime], [Creator], [Remark]) VALUES (9, N'杨浦区', N'121.52', N'31.27', N'复旦大学', CAST(0x0000A6A201601D5C AS DateTime), CAST(0x0000A6A201601D5C AS DateTime), N'admin', NULL)
INSERT [dbo].[Coordinate] ([Id], [Eare], [Lon], [lat], [LogoName], [CreateTime], [UpdateTime], [Creator], [Remark]) VALUES (10, N'闵行区', N'121.38', N'31.12', N'白宫法院', CAST(0x0000A6A2016033C5 AS DateTime), CAST(0x0000A6A2016033C5 AS DateTime), N'admin', NULL)
INSERT [dbo].[Coordinate] ([Id], [Eare], [Lon], [lat], [LogoName], [CreateTime], [UpdateTime], [Creator], [Remark]) VALUES (11, N'宝山区', N'121.48', N'31.4', N'宝钢', CAST(0x0000A6A2016048D7 AS DateTime), CAST(0x0000A6A2016048D7 AS DateTime), N'admin', NULL)
INSERT [dbo].[Coordinate] ([Id], [Eare], [Lon], [lat], [LogoName], [CreateTime], [UpdateTime], [Creator], [Remark]) VALUES (12, N'嘉定区', N'121.27', N'31.38', N'法华塔', CAST(0x0000A6A2016079E1 AS DateTime), CAST(0x0000A6A2016079E1 AS DateTime), N'admin', NULL)
INSERT [dbo].[Coordinate] ([Id], [Eare], [Lon], [lat], [LogoName], [CreateTime], [UpdateTime], [Creator], [Remark]) VALUES (13, N'浦东新区', N'121.53', N'31.22', N'东方明珠', CAST(0x0000A6A201608A05 AS DateTime), CAST(0x0000A6A201608A05 AS DateTime), N'admin', NULL)
INSERT [dbo].[Coordinate] ([Id], [Eare], [Lon], [lat], [LogoName], [CreateTime], [UpdateTime], [Creator], [Remark]) VALUES (14, N'金山区', N'121.33', N'30.75', N'石化', CAST(0x0000A6A20160C51D AS DateTime), CAST(0x0000A6A20160C51D AS DateTime), N'admin', NULL)
INSERT [dbo].[Coordinate] ([Id], [Eare], [Lon], [lat], [LogoName], [CreateTime], [UpdateTime], [Creator], [Remark]) VALUES (15, N'松江区', N'121.22', N'31.03', N'方塔', CAST(0x0000A6A20160FCFD AS DateTime), CAST(0x0000A6A20160FCFD AS DateTime), N'admin', NULL)
INSERT [dbo].[Coordinate] ([Id], [Eare], [Lon], [lat], [LogoName], [CreateTime], [UpdateTime], [Creator], [Remark]) VALUES (16, N'青浦区', N'121.12', N'31.15', N'东方绿舟', CAST(0x0000A6A201611069 AS DateTime), CAST(0x0000A6A201611069 AS DateTime), N'admin', NULL)
INSERT [dbo].[Coordinate] ([Id], [Eare], [Lon], [lat], [LogoName], [CreateTime], [UpdateTime], [Creator], [Remark]) VALUES (17, N'南汇区', N'121.75', N'31.05', N'滴水湖', CAST(0x0000A6A201613280 AS DateTime), CAST(0x0000A6A201613280 AS DateTime), N'admin', NULL)
INSERT [dbo].[Coordinate] ([Id], [Eare], [Lon], [lat], [LogoName], [CreateTime], [UpdateTime], [Creator], [Remark]) VALUES (18, N'奉贤区', N'121.47', N'30.92', N'奉浦大桥', CAST(0x0000A6A201614D91 AS DateTime), CAST(0x0000A6A201614D91 AS DateTime), N'admin', NULL)
INSERT [dbo].[Coordinate] ([Id], [Eare], [Lon], [lat], [LogoName], [CreateTime], [UpdateTime], [Creator], [Remark]) VALUES (19, N'崇明县', N'121.4', N'31.62', NULL, CAST(0x0000A6A201616314 AS DateTime), CAST(0x0000A6A201616314 AS DateTime), N'admin', NULL)
INSERT [dbo].[Coordinate] ([Id], [Eare], [Lon], [lat], [LogoName], [CreateTime], [UpdateTime], [Creator], [Remark]) VALUES (20, N'上海市', N'121.4878', N'31.2491', N'外滩', CAST(0x0000A6A501202093 AS DateTime), CAST(0x0000A6A501202093 AS DateTime), N'admin', NULL)
SET IDENTITY_INSERT [dbo].[Coordinate] OFF
/****** Object:  Table [dbo].[UserInfo]    Script Date: 10/25/2016 22:10:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[UserInfo](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [varchar](20) NOT NULL,
	[Password] [varchar](32) NOT NULL,
	[HeadImage] [varchar](100) NULL,
	[IsLock] [int] NOT NULL,
	[IsAdmin] [bit] NOT NULL,
	[CreateTime] [datetime] NULL,
	[UpdateTime] [datetime] NULL,
	[Creator] [varchar](20) NULL,
	[Remark] [nvarchar](50) NULL,
 CONSTRAINT [PK__UserInfo__3214EC077F60ED59] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[UserInfo] ON
INSERT [dbo].[UserInfo] ([Id], [UserName], [Password], [HeadImage], [IsLock], [IsAdmin], [CreateTime], [UpdateTime], [Creator], [Remark]) VALUES (1, N'admin', N'21232f297a57a5a743894a0e4a801fc3', N'/FileStore/HeadImages/2.png', 0, 1, CAST(0x0000A69E015DC088 AS DateTime), CAST(0x0000A69E015DC088 AS DateTime), N'admin', N'admin')
INSERT [dbo].[UserInfo] ([Id], [UserName], [Password], [HeadImage], [IsLock], [IsAdmin], [CreateTime], [UpdateTime], [Creator], [Remark]) VALUES (2, N'wenping', N'e10adc3949ba59abbe56e057f20f883e', N'/FileStore/HeadImages/3.png', 0, 0, CAST(0x0000A69E015E0261 AS DateTime), CAST(0x0000A69E015E0261 AS DateTime), N'admin', N'123456')
SET IDENTITY_INSERT [dbo].[UserInfo] OFF
/****** Object:  StoredProcedure [dbo].[PagerHelper]    Script Date: 10/25/2016 22:10:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE  [dbo].[PagerHelper]
/*
nzperfect [no_mIss] 高效通用分页存储过程(双向检索) 2007.5.7   QQ:34813284
敬告：适用于单一主键或存在唯一值列的表或视图
ps:Sql语句为8000字节,调用时请注意传入参数及sql总长度不要超过指定范围
*/
@TableName VARCHAR(200),      --表名
@FieldList VARCHAR(2000),     --显示列名，如果是全部字段则为*
@PrimaryKey VARCHAR(100),     --单一主键或唯一值键
@Where VARCHAR(2000),         --查询条件 不含'where'字符，如id>10 and len(userid)>9
@Order VARCHAR(1000),         --排序 不含'order by'字符，如id asc,userid desc，必须指定asc或desc
--注意当@SortType=3时生效，记住一定要在最后加上主键，否则会让你比较郁闷
@SortType INT,                --排序规则 1:正序asc 2:倒序desc 3:多列排序方法
@RecorderCount INT,           --记录总数 0:会返回总记录
@PageSize INT,                --每页输出的记录数
@PageIndex INT,               --当前页数
@TotalCount INT OUTPUT,       --记返回总记录
@TotalPageCount INT OUTPUT    --返回总页数
AS
SET NOCOUNT ON
IF ISNULL(@TotalCount,'') = '' SET @TotalCount = 0
SET @Order = RTRIM(LTRIM(@Order))
SET @PrimaryKey = RTRIM(LTRIM(@PrimaryKey))
SET @FieldList = REPLACE(RTRIM(LTRIM(@FieldList)),' ','')
WHILE CHARINDEX(', ',@Order) > 0 OR CHARINDEX(' ,',@Order) > 0
BEGIN
SET @Order = REPLACE(@Order,', ',',')
SET @Order = REPLACE(@Order,' ,',',')
END
IF ISNULL(@TableName,'') = '' OR ISNULL(@FieldList,'') = ''
OR ISNULL(@PrimaryKey,'') = ''
OR @SortType < 1 OR @SortType >3
OR @RecorderCount   < 0 OR @PageSize < 0 OR @PageIndex < 0
BEGIN
PRINT('ERR_00')
RETURN
END
IF @SortType = 3
BEGIN
IF (UPPER(RIGHT(@Order,4))!=' ASC' AND UPPER(RIGHT(@Order,5))!=' DESC')
BEGIN PRINT('ERR_02') RETURN END
END
DECLARE @new_where1 VARCHAR(1000)
DECLARE @new_where2 VARCHAR(1000)
DECLARE @new_order1 VARCHAR(1000)
DECLARE @new_order2 VARCHAR(1000)
DECLARE @new_order3 VARCHAR(1000)
DECLARE @Sql VARCHAR(8000)
DECLARE @SqlCount NVARCHAR(4000)
IF ISNULL(@where,'') = ''
BEGIN
SET @new_where1 = ' '
SET @new_where2 = ' WHERE   '
END
ELSE
BEGIN
SET @new_where1 = ' WHERE ' + @where
SET @new_where2 = ' WHERE ' + @where + ' AND '
END
IF ISNULL(@order,'') = '' OR @SortType = 1   OR @SortType = 2
BEGIN
IF @SortType = 1
BEGIN
SET @new_order1 = ' ORDER BY ' + @PrimaryKey + ' ASC'
SET @new_order2 = ' ORDER BY ' + @PrimaryKey + ' DESC'
END
IF @SortType = 2
BEGIN
SET @new_order1 = ' ORDER BY ' + @PrimaryKey + ' DESC'
SET @new_order2 = ' ORDER BY ' + @PrimaryKey + ' ASC'
END
END
ELSE
BEGIN
SET @new_order1 = ' ORDER BY ' + @Order
END
IF @SortType = 3 AND   CHARINDEX(','+@PrimaryKey+' ',','+@Order)>0
BEGIN
SET @new_order1 = ' ORDER BY ' + @Order
SET @new_order2 = @Order + ','
SET @new_order2 = REPLACE(REPLACE(@new_order2,'ASC,','{ASC},'),'DESC,','{DESC},')
SET @new_order2 = REPLACE(REPLACE(@new_order2,'{ASC},','DESC,'),'{DESC},','ASC,')
SET @new_order2 = ' ORDER BY ' + SUBSTRING(@new_order2,1,LEN(@new_order2)-1)
IF @FieldList <> '*'
BEGIN
SET @new_order3 = REPLACE(REPLACE(@Order + ',','ASC,',','),'DESC,',',')
SET @FieldList = ',' + @FieldList
WHILE CHARINDEX(',',@new_order3)>0
BEGIN
IF CHARINDEX(SUBSTRING(','+@new_order3,1,CHARINDEX(',',@new_order3)),','+@FieldList+',')>0
BEGIN
SET @FieldList =
@FieldList + ',' + SUBSTRING(@new_order3,1,CHARINDEX(',',@new_order3))
END
SET @new_order3 =
SUBSTRING(@new_order3,CHARINDEX(',',@new_order3)+1,LEN(@new_order3))
END
SET @FieldList = SUBSTRING(@FieldList,2,LEN(@FieldList))
END
END
SET @SqlCount = 'SELECT @TotalCount=COUNT(*),@TotalPageCount=CEILING((COUNT(*)+0.0)/'
+ CAST(@PageSize AS VARCHAR)+') FROM ' + @TableName + @new_where1
IF @RecorderCount   = 0
BEGIN
EXEC SP_EXECUTESQL @SqlCount,N'@TotalCount INT OUTPUT,@TotalPageCount INT OUTPUT',
@TotalCount OUTPUT,@TotalPageCount OUTPUT
END
ELSE
BEGIN
SELECT @TotalCount = @RecorderCount
END
IF @PageIndex > CEILING((@TotalCount+0.0)/@PageSize)
BEGIN
SET @PageIndex =   CEILING((@TotalCount+0.0)/@PageSize)
END
IF @PageIndex = 1 OR @PageIndex >= CEILING((@TotalCount+0.0)/@PageSize)
BEGIN
IF @PageIndex = 1 --返回第一页数据
BEGIN
SET @Sql = 'SELECT TOP ' + STR(@PageSize) + ' ' + @FieldList + ' FROM '
+ @TableName + @new_where1 + @new_order1
END
IF @PageIndex >= CEILING((@TotalCount+0.0)/@PageSize)   --返回最后一页数据
BEGIN
SET @Sql = 'SELECT TOP ' + STR(@PageSize) + ' ' + @FieldList + ' FROM ('
+ 'SELECT TOP ' + STR(ABS(@PageSize*@PageIndex-@TotalCount-@PageSize))
+ ' ' + @FieldList + ' FROM '
+ @TableName + @new_where1 + @new_order2 + ' ) AS TMP '
+ @new_order1
END
END
ELSE
BEGIN
IF @SortType = 1   --仅主键正序排序
BEGIN
IF @PageIndex <= CEILING((@TotalCount+0.0)/@PageSize)/2   --正向检索
BEGIN
SET @Sql = 'SELECT TOP ' + STR(@PageSize) + ' ' + @FieldList + ' FROM '
+ @TableName + @new_where2 + @PrimaryKey + ' > '
+ '(SELECT MAX(' + @PrimaryKey + ') FROM (SELECT TOP '
+ STR(@PageSize*(@PageIndex-1)) + ' ' + @PrimaryKey
+ ' FROM ' + @TableName
+ @new_where1 + @new_order1 +' ) AS TMP) '+ @new_order1
END
ELSE   --反向检索
BEGIN
SET @Sql = 'SELECT TOP ' + STR(@PageSize) + ' ' + @FieldList + ' FROM ('
+ 'SELECT TOP ' + STR(@PageSize) + ' '
+ @FieldList + ' FROM '
+ @TableName + @new_where2 + @PrimaryKey + ' < '
+ '(SELECT MIN(' + @PrimaryKey + ') FROM (SELECT TOP '
+ STR(@TotalCount-@PageSize*@PageIndex) + ' ' + @PrimaryKey
+ ' FROM ' + @TableName
+ @new_where1 + @new_order2 +' ) AS TMP) '+ @new_order2
+ ' ) AS TMP ' + @new_order1
END
END
IF @SortType = 2   --仅主键反序排序
BEGIN
IF @PageIndex <= CEILING((@TotalCount+0.0)/@PageSize)/2   --正向检索
BEGIN
SET @Sql = 'SELECT TOP ' + STR(@PageSize) + ' ' + @FieldList + ' FROM '
+ @TableName + @new_where2 + @PrimaryKey + ' < '
+ '(SELECT MIN(' + @PrimaryKey + ') FROM (SELECT TOP '
+ STR(@PageSize*(@PageIndex-1)) + ' ' + @PrimaryKey
+' FROM '+ @TableName
+ @new_where1 + @new_order1 + ') AS TMP) '+ @new_order1
END
ELSE   --反向检索
BEGIN
SET @Sql = 'SELECT TOP ' + STR(@PageSize) + ' ' + @FieldList + ' FROM ('
+ 'SELECT TOP ' + STR(@PageSize) + ' '
+ @FieldList + ' FROM '
+ @TableName + @new_where2 + @PrimaryKey + ' > '
+ '(SELECT MAX(' + @PrimaryKey + ') FROM (SELECT TOP '
+ STR(@TotalCount-@PageSize*@PageIndex) + ' ' + @PrimaryKey
+ ' FROM ' + @TableName
+ @new_where1 + @new_order2 +' ) AS TMP) '+ @new_order2
+ ' ) AS TMP ' + @new_order1
END
END
IF @SortType = 3   --多列排序，必须包含主键，且放置最后，否则不处理
BEGIN
IF CHARINDEX(',' + @PrimaryKey + ' ',',' + @Order) = 0
BEGIN PRINT('ERR_02') RETURN END
IF @PageIndex <= CEILING((@TotalCount+0.0)/@PageSize)/2   --正向检索
BEGIN
SET @Sql = 'SELECT TOP ' + STR(@PageSize) + ' ' + @FieldList + ' FROM ( '
+ 'SELECT TOP ' + STR(@PageSize) + ' ' + @FieldList + ' FROM ( '
+ ' SELECT TOP ' + STR(@PageSize*@PageIndex) + ' ' + @FieldList
+ ' FROM ' + @TableName + @new_where1 + @new_order1 + ' ) AS TMP '
+ @new_order2 + ' ) AS TMP ' + @new_order1
END
ELSE   --反向检索
BEGIN
SET @Sql = 'SELECT TOP ' + STR(@PageSize) + ' ' + @FieldList + ' FROM ( '
+ 'SELECT TOP ' + STR(@PageSize) + ' ' + @FieldList + ' FROM ( '
+ ' SELECT TOP ' + STR(@TotalCount-@PageSize *@PageIndex+@PageSize) + ' ' + @FieldList
+ ' FROM ' + @TableName + @new_where1 + @new_order2 + ' ) AS TMP '
+ @new_order1 + ' ) AS TMP ' + @new_order1
END
END
END
EXEC(@Sql)
GO
/****** Object:  StoredProcedure [dbo].[GetCurrentAd]    Script Date: 10/25/2016 22:10:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<witer chen>
-- Create date: <20161001>
-- Description:	<获取当前时段的一条广告>
-- =============================================
CREATE PROCEDURE [dbo].[GetCurrentAd] 
	@DeviceId varchar(30)
AS
  declare @UserName varchar(20) 
BEGIN 
	SET NOCOUNT ON;
	if exists(select * from DeviceInfo where DeviceId=@DeviceId)
	begin
		select @UserName=Creator from DeviceInfo where DeviceId=@DeviceId
		if exists(select * from UserInfo where UserName=@UserName)
		begin
			if exists(select * from DeviceAd where Creator=@UserName and Eare='无' and (Datename(hour,BeginTime)=Datename(hour,getdate())))
			begin
				select top 1 a.*,b.UserName,b.headimage from DeviceAd a left join UserInfo b on a.Creator=b.UserName where  a.Creator=@UserName and Eare='无' and (Datename(hour,BeginTime)=Datename(hour,getdate()))
				return 0
			end
			else
				return 3  --当前用户未上传广告			
		end
		else
			return 2  --用户不存在
	end
	else
		return 1  --deviceid 未绑定
END
GO
/****** Object:  StoredProcedure [dbo].[UserAdLast]    Script Date: 10/25/2016 22:10:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<witer chen>
-- Create date: <20161001>
-- Description:	<获取最后一条广告>
-- =============================================
create PROCEDURE [dbo].[UserAdLast]
	@UserName varchar(20),
	@DeviceId varchar(30)
AS
BEGIN 
	SET NOCOUNT ON;
	if exists(select * from DeviceInfo where DeviceId=@DeviceId)
	begin
		if exists(select * from UserInfo where UserName=@UserName)
		begin
			if exists(select * from DeviceAd where Creator=@UserName and Eare='无')
			begin
				select * from DeviceAd where Creator=@UserName and Eare='无'
				return 0
			end
			else
				return 3  --当前用户未上传广告
			
		end
		else
			return 2  --用户不存在
	end
	else
		return 1  --deviceid 未绑定
END
GO
/****** Object:  StoredProcedure [dbo].[UserAdAll]    Script Date: 10/25/2016 22:10:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<witer chen>
-- Create date: <20161001>
-- Description:	<获取所有广告>
-- =============================================
create PROCEDURE [dbo].[UserAdAll]
	@UserName varchar(20),
	@DeviceId varchar(30)
AS
BEGIN 
	SET NOCOUNT ON;
	if exists(select * from DeviceInfo where DeviceId=@DeviceId)
	begin
		if exists(select * from UserInfo where UserName=@UserName)
		begin
			if exists(select * from DeviceAd where Creator=@UserName and Eare='无')
			begin
				select * from DeviceAd where Creator=@UserName and Eare='无'
				return 0
			end
			else
				return 3  --当前用户未上传广告
			
		end
		else
			return 2  --用户不存在
	end
	else
		return 1  --deviceid 未绑定
END
GO
/****** Object:  StoredProcedure [dbo].[CheckUserInfo]    Script Date: 10/25/2016 22:10:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<witer chen>
-- Create date: <20161001>
-- Description:	<用户登录>
-- =============================================
create PROCEDURE [dbo].[CheckUserInfo]
	@UserName varchar(20),
	@password varchar(32)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	if exists(select * from UserInfo where  userName=@UserName)
	begin
		if exists(select * from UserInfo where  userName=@UserName and password=@password)
		begin
			if exists(select * from UserInfo where  userName=@UserName and password=@password and IsLock=0)
			begin
				return 0 
			end
			else
			return 3  --用户被锁定
		end
		else
		return 2  --密码错误
	end
	else
	return 1  --用户名不存在
END
GO
/****** Object:  Default [DF__Coordinat__Creat__0F975522]    Script Date: 10/25/2016 22:10:58 ******/
ALTER TABLE [dbo].[Coordinate] ADD  CONSTRAINT [DF__Coordinat__Creat__0F975522]  DEFAULT (getdate()) FOR [CreateTime]
GO
/****** Object:  Default [DF__Coordinat__Updat__108B795B]    Script Date: 10/25/2016 22:10:58 ******/
ALTER TABLE [dbo].[Coordinate] ADD  CONSTRAINT [DF__Coordinat__Updat__108B795B]  DEFAULT (getdate()) FOR [UpdateTime]
GO
/****** Object:  Default [DF__DeviceAd__AdType__15502E78]    Script Date: 10/25/2016 22:10:58 ******/
ALTER TABLE [dbo].[DeviceAd] ADD  CONSTRAINT [DF__DeviceAd__AdType__15502E78]  DEFAULT ((0)) FOR [AdType]
GO
/****** Object:  Default [DF__DeviceAd__Create__164452B1]    Script Date: 10/25/2016 22:10:58 ******/
ALTER TABLE [dbo].[DeviceAd] ADD  CONSTRAINT [DF__DeviceAd__Create__164452B1]  DEFAULT (getdate()) FOR [CreateTime]
GO
/****** Object:  Default [DF__DeviceAd__Update__173876EA]    Script Date: 10/25/2016 22:10:58 ******/
ALTER TABLE [dbo].[DeviceAd] ADD  CONSTRAINT [DF__DeviceAd__Update__173876EA]  DEFAULT (getdate()) FOR [UpdateTime]
GO
/****** Object:  Default [DF__DeviceInf__IsLoc__08EA5793]    Script Date: 10/25/2016 22:10:58 ******/
ALTER TABLE [dbo].[DeviceInfo] ADD  CONSTRAINT [DF__DeviceInf__IsLoc__08EA5793]  DEFAULT ((0)) FOR [IsLock]
GO
/****** Object:  Default [DF__DeviceInf__Creat__09DE7BCC]    Script Date: 10/25/2016 22:10:58 ******/
ALTER TABLE [dbo].[DeviceInfo] ADD  CONSTRAINT [DF__DeviceInf__Creat__09DE7BCC]  DEFAULT (getdate()) FOR [CreateTime]
GO
/****** Object:  Default [DF__DeviceInf__Updat__0AD2A005]    Script Date: 10/25/2016 22:10:58 ******/
ALTER TABLE [dbo].[DeviceInfo] ADD  CONSTRAINT [DF__DeviceInf__Updat__0AD2A005]  DEFAULT (getdate()) FOR [UpdateTime]
GO
/****** Object:  Default [DF__UserInfo__IsLock__014935CB]    Script Date: 10/25/2016 22:10:58 ******/
ALTER TABLE [dbo].[UserInfo] ADD  CONSTRAINT [DF__UserInfo__IsLock__014935CB]  DEFAULT ((0)) FOR [IsLock]
GO
/****** Object:  Default [DF__UserInfo__IsAdmi__023D5A04]    Script Date: 10/25/2016 22:10:58 ******/
ALTER TABLE [dbo].[UserInfo] ADD  CONSTRAINT [DF__UserInfo__IsAdmi__023D5A04]  DEFAULT ((0)) FOR [IsAdmin]
GO
/****** Object:  Default [DF__UserInfo__Create__03317E3D]    Script Date: 10/25/2016 22:10:58 ******/
ALTER TABLE [dbo].[UserInfo] ADD  CONSTRAINT [DF__UserInfo__Create__03317E3D]  DEFAULT (getdate()) FOR [CreateTime]
GO
/****** Object:  Default [DF__UserInfo__Update__0425A276]    Script Date: 10/25/2016 22:10:58 ******/
ALTER TABLE [dbo].[UserInfo] ADD  CONSTRAINT [DF__UserInfo__Update__0425A276]  DEFAULT (getdate()) FOR [UpdateTime]
GO
