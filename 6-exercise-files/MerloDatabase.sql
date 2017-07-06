USE [expoware_Merlo]
GO
/****** Object:  Table [dbo].[SentEmails]    Script Date: 07/14/2015 12:51:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SentEmails](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Address] [nvarchar](50) NOT NULL,
	[Body] [nvarchar](200) NOT NULL,
	[Sent] [datetime] NOT NULL,
 CONSTRAINT [PK_SentEmails] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[SentEmails] ON
INSERT [dbo].[SentEmails] ([Id], [Address], [Body], [Sent]) VALUES (11, N'user@company.com', N'Your request 8c258add-9b99-4222-a75d-8bfd555a34a9 could not be satisfied.', CAST(0x0000A4C7011DAD53 AS DateTime))
INSERT [dbo].[SentEmails] ([Id], [Address], [Body], [Sent]) VALUES (12, N'user@company.com', N'Congratulations! Your booking is confirmed. Your confirmation number is 35.', CAST(0x0000A4C7011DEAC0 AS DateTime))
INSERT [dbo].[SentEmails] ([Id], [Address], [Body], [Sent]) VALUES (13, N'user@company.com', N'Your request 10fca5a0-3634-4fad-911b-7f0c9a6633a9 could not be satisfied.', CAST(0x0000A4D400BB1C79 AS DateTime))
INSERT [dbo].[SentEmails] ([Id], [Address], [Body], [Sent]) VALUES (14, N'user@company.com', N'Congratulations! Your booking is confirmed. Your confirmation number is 36.', CAST(0x0000A4D400BB295F AS DateTime))
INSERT [dbo].[SentEmails] ([Id], [Address], [Body], [Sent]) VALUES (15, N'user@company.com', N'Congratulations! Your booking is confirmed. Your confirmation number is 37.', CAST(0x0000A4D400BB3223 AS DateTime))
INSERT [dbo].[SentEmails] ([Id], [Address], [Body], [Sent]) VALUES (16, N'user@company.com', N'Congratulations! Your booking is confirmed. Your confirmation number is 38.', CAST(0x0000A4D400BEEE18 AS DateTime))
INSERT [dbo].[SentEmails] ([Id], [Address], [Body], [Sent]) VALUES (17, N'user@company.com', N'Congratulations! Your booking is confirmed. Your confirmation number is 39.', CAST(0x0000A4D400C0B7B3 AS DateTime))
INSERT [dbo].[SentEmails] ([Id], [Address], [Body], [Sent]) VALUES (18, N'user@company.com', N'Your request fa61f284-746e-4e8e-9cb8-6a39869520ff could not be satisfied.', CAST(0x0000A4D400C12C36 AS DateTime))
INSERT [dbo].[SentEmails] ([Id], [Address], [Body], [Sent]) VALUES (19, N'user@company.com', N'Your request ea5323ec-8e51-403e-87da-7a637618077c could not be satisfied.', CAST(0x0000A4D400C140C9 AS DateTime))
INSERT [dbo].[SentEmails] ([Id], [Address], [Body], [Sent]) VALUES (20, N'user@company.com', N'Congratulations! Your booking is confirmed. Your confirmation number is 40.', CAST(0x0000A4D400C27328 AS DateTime))
INSERT [dbo].[SentEmails] ([Id], [Address], [Body], [Sent]) VALUES (21, N'user@company.com', N'Congratulations! Your booking is confirmed. Your confirmation number is 41.', CAST(0x0000A4D40100DE44 AS DateTime))
INSERT [dbo].[SentEmails] ([Id], [Address], [Body], [Sent]) VALUES (22, N'user@company.com', N'Congratulations! Your booking is confirmed. Your confirmation number is 42.', CAST(0x0000A4D40101ECF8 AS DateTime))
INSERT [dbo].[SentEmails] ([Id], [Address], [Body], [Sent]) VALUES (23, N'user@company.com', N'Congratulations! Your booking is confirmed. Your confirmation number is 43.', CAST(0x0000A4D40112D0B5 AS DateTime))
INSERT [dbo].[SentEmails] ([Id], [Address], [Body], [Sent]) VALUES (24, N'user@company.com', N'Congratulations! Your booking is confirmed. Your confirmation number is 44.', CAST(0x0000A4D4011C92E7 AS DateTime))
INSERT [dbo].[SentEmails] ([Id], [Address], [Body], [Sent]) VALUES (25, N'user@company.com', N'Congratulations! Your booking is confirmed. Your confirmation number is 45.', CAST(0x0000A4D401315328 AS DateTime))
INSERT [dbo].[SentEmails] ([Id], [Address], [Body], [Sent]) VALUES (26, N'user@company.com', N'Congratulations! Your booking is confirmed. Your confirmation number is 46.', CAST(0x0000A4D401317751 AS DateTime))
INSERT [dbo].[SentEmails] ([Id], [Address], [Body], [Sent]) VALUES (27, N'user@company.com', N'Congratulations! Your booking is confirmed. Your confirmation number is 47.', CAST(0x0000A4D500B8DE11 AS DateTime))
INSERT [dbo].[SentEmails] ([Id], [Address], [Body], [Sent]) VALUES (28, N'user@company.com', N'Congratulations! Your booking is confirmed. Your confirmation number is 48.', CAST(0x0000A4D500C00D9B AS DateTime))
INSERT [dbo].[SentEmails] ([Id], [Address], [Body], [Sent]) VALUES (29, N'user@company.com', N'Congratulations! Your booking is confirmed. Your confirmation number is 49.', CAST(0x0000A4D500C22A9F AS DateTime))
INSERT [dbo].[SentEmails] ([Id], [Address], [Body], [Sent]) VALUES (30, N'user@company.com', N'Congratulations! Your booking is confirmed. Your confirmation number is 50.', CAST(0x0000A4D500C28340 AS DateTime))
INSERT [dbo].[SentEmails] ([Id], [Address], [Body], [Sent]) VALUES (31, N'user@company.com', N'Congratulations! Your booking is confirmed. Your confirmation number is 51.', CAST(0x0000A4D500C45A1B AS DateTime))
SET IDENTITY_INSERT [dbo].[SentEmails] OFF
/****** Object:  Table [dbo].[RoomRules]    Script Date: 07/14/2015 12:51:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RoomRules](
	[Id] [int] NOT NULL,
	[RoomId] [int] NULL,
	[Slot] [int] NOT NULL,
	[StartTimeOfDayHour] [int] NOT NULL,
	[StartTimeOfDayMin] [int] NOT NULL,
	[ValidSince] [date] NULL,
 CONSTRAINT [PK_RoomRules] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[RoomRules] ([Id], [RoomId], [Slot], [StartTimeOfDayHour], [StartTimeOfDayMin], [ValidSince]) VALUES (1, 1, 60, 9, 30, CAST(0xA9390B00 AS Date))
INSERT [dbo].[RoomRules] ([Id], [RoomId], [Slot], [StartTimeOfDayHour], [StartTimeOfDayMin], [ValidSince]) VALUES (2, 1, 30, 9, 0, CAST(0x053A0B00 AS Date))
/****** Object:  Table [dbo].[MatchEvents]    Script Date: 07/14/2015 12:51:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MatchEvents](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[MatchId] [nvarchar](10) NOT NULL,
	[Action] [nvarchar](50) NOT NULL,
	[TeamId] [int] NULL,
	[PlayerId] [int] NULL,
	[TimeStamp] [datetime] NOT NULL,
	[Team1] [nvarchar](50) NULL,
	[Team2] [nvarchar](50) NULL,
 CONSTRAINT [PK_MatchEvents] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[MatchEvents] ON
INSERT [dbo].[MatchEvents] ([Id], [MatchId], [Action], [TeamId], [PlayerId], [TimeStamp], [Team1], [Team2]) VALUES (399, N'WP0001', N'Created', 0, NULL, CAST(0x0000A4C9016BB0D2 AS DateTime), N'Frogs', N'Sharks')
INSERT [dbo].[MatchEvents] ([Id], [MatchId], [Action], [TeamId], [PlayerId], [TimeStamp], [Team1], [Team2]) VALUES (400, N'WP0002', N'Created', 0, NULL, CAST(0x0000A4C9016BB183 AS DateTime), N'Sharks', N'Eels')
INSERT [dbo].[MatchEvents] ([Id], [MatchId], [Action], [TeamId], [PlayerId], [TimeStamp], [Team1], [Team2]) VALUES (401, N'WP0001', N'Start', 0, NULL, CAST(0x0000A4C9016BE3C4 AS DateTime), NULL, NULL)
SET IDENTITY_INSERT [dbo].[MatchEvents] OFF
/****** Object:  Table [dbo].[Matches]    Script Date: 07/14/2015 12:51:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Matches](
	[Id] [nvarchar](10) NOT NULL,
	[Team1] [nvarchar](50) NOT NULL,
	[Team2] [nvarchar](50) NOT NULL,
	[State] [int] NOT NULL,
	[Score1] [int] NOT NULL,
	[Score2] [int] NOT NULL,
	[Period] [int] NOT NULL,
	[Timeouts1] [nvarchar](10) NULL,
	[Timeouts2] [nvarchar](10) NULL,
 CONSTRAINT [PK_Matches] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Matches] ([Id], [Team1], [Team2], [State], [Score1], [Score2], [Period], [Timeouts1], [Timeouts2]) VALUES (N'WP0001', N'Frogs', N'Sharks', 10, 0, 0, 0, N'0/1', N'0/1')
INSERT [dbo].[Matches] ([Id], [Team1], [Team2], [State], [Score1], [Score2], [Period], [Timeouts1], [Timeouts2]) VALUES (N'WP0002', N'Sharks', N'Eels', 1, 0, 0, 0, N'0/1', N'0/1')
/****** Object:  Table [dbo].[LoggedEvents]    Script Date: 07/14/2015 12:51:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoggedEvents](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Action] [nvarchar](50) NOT NULL,
	[AggregateId] [int] NOT NULL,
	[Cargo] [nvarchar](max) NULL,
	[TimeStamp] [datetime] NULL,
 CONSTRAINT [PK_LoggedEvents] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[LoggedEvents] ON
INSERT [dbo].[LoggedEvents] ([Id], [Action], [AggregateId], [Cargo], [TimeStamp]) VALUES (58, N'BookingCreatedEvent', 51, N'{"Id":51,"RequestId":"9c01d39d-e4dd-4e9d-aff1-ba15fc355eb0","When":"\/Date(1436867693547)\/","Data":{"Action":null,"BookingId":0,"StartingAt":9,"CourtId":1,"Length":1,"Name":"Dino","Notes":null,"When":"\/Date(-62135596800000)\/"},"TimeStamp":"\/Date(1436867693547)\/","SagaId":51,"Name":"BookingCreatedEvent"}', CAST(0x0000A4D500C459E4 AS DateTime))
INSERT [dbo].[LoggedEvents] ([Id], [Action], [AggregateId], [Cargo], [TimeStamp]) VALUES (61, N'BookingUpdatedEvent', 51, N'{"Id":51,"When":"\/Date(1436869271653)\/","Data":{"Action":null,"BookingId":51,"StartingAt":9,"CourtId":0,"Length":2,"Name":"Dino","Notes":null,"When":"\/Date(-62135596800000)\/"},"TimeStamp":"\/Date(1436869271653)\/","SagaId":51,"Name":"BookingUpdatedEvent"}', CAST(0x0000A4D500CB9338 AS DateTime))
SET IDENTITY_INSERT [dbo].[LoggedEvents] OFF
/****** Object:  Table [dbo].[Courts]    Script Date: 07/14/2015 12:51:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Courts](
	[Id] [int] NOT NULL,
	[Name] [nvarchar](50) NULL,
	[FirstSlot] [int] NOT NULL,
	[LastSlot] [int] NOT NULL,
 CONSTRAINT [PK_Courts] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Courts] ([Id], [Name], [FirstSlot], [LastSlot]) VALUES (1, N'Centre Court', 8, 20)
INSERT [dbo].[Courts] ([Id], [Name], [FirstSlot], [LastSlot]) VALUES (2, N'Court 1', 8, 22)
/****** Object:  Table [dbo].[Bookings]    Script Date: 07/14/2015 12:51:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Bookings](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RequestId] [varchar](50) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[CourtId] [int] NOT NULL,
	[StartingAt] [int] NOT NULL,
	[Length] [int] NOT NULL,
	[Notes] [nvarchar](max) NULL,
 CONSTRAINT [PK_Bookings] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Bookings] ON
INSERT [dbo].[Bookings] ([Id], [RequestId], [Name], [CourtId], [StartingAt], [Length], [Notes]) VALUES (51, N'9c01d39d-e4dd-4e9d-aff1-ba15fc355eb0', N'Dino', 1, 9, 2, NULL)
SET IDENTITY_INSERT [dbo].[Bookings] OFF
/****** Object:  Default [DF_Bookings_Guid]    Script Date: 07/14/2015 12:51:59 ******/
ALTER TABLE [dbo].[Bookings] ADD  CONSTRAINT [DF_Bookings_Guid]  DEFAULT (newid()) FOR [RequestId]
GO
/****** Object:  Default [DF_Bookings_Length]    Script Date: 07/14/2015 12:51:59 ******/
ALTER TABLE [dbo].[Bookings] ADD  CONSTRAINT [DF_Bookings_Length]  DEFAULT ((1)) FOR [Length]
GO
/****** Object:  Default [DF_Table_1_StartingAt]    Script Date: 07/14/2015 12:51:59 ******/
ALTER TABLE [dbo].[Courts] ADD  CONSTRAINT [DF_Table_1_StartingAt]  DEFAULT ((8)) FOR [FirstSlot]
GO
/****** Object:  Default [DF_Courts_LastSlot]    Script Date: 07/14/2015 12:51:59 ******/
ALTER TABLE [dbo].[Courts] ADD  CONSTRAINT [DF_Courts_LastSlot]  DEFAULT ((20)) FOR [LastSlot]
GO
/****** Object:  Default [DF_Matches_State]    Script Date: 07/14/2015 12:51:59 ******/
ALTER TABLE [dbo].[Matches] ADD  CONSTRAINT [DF_Matches_State]  DEFAULT ((0)) FOR [State]
GO
/****** Object:  Default [DF_Matches_Score1]    Script Date: 07/14/2015 12:51:59 ******/
ALTER TABLE [dbo].[Matches] ADD  CONSTRAINT [DF_Matches_Score1]  DEFAULT ((0)) FOR [Score1]
GO
/****** Object:  Default [DF_Matches_Score2]    Script Date: 07/14/2015 12:51:59 ******/
ALTER TABLE [dbo].[Matches] ADD  CONSTRAINT [DF_Matches_Score2]  DEFAULT ((0)) FOR [Score2]
GO
/****** Object:  Default [DF_Matches_Period]    Script Date: 07/14/2015 12:51:59 ******/
ALTER TABLE [dbo].[Matches] ADD  CONSTRAINT [DF_Matches_Period]  DEFAULT ((0)) FOR [Period]
GO
/****** Object:  ForeignKey [FK_Bookings_Courts]    Script Date: 07/14/2015 12:51:59 ******/
ALTER TABLE [dbo].[Bookings]  WITH CHECK ADD  CONSTRAINT [FK_Bookings_Courts] FOREIGN KEY([CourtId])
REFERENCES [dbo].[Courts] ([Id])
GO
ALTER TABLE [dbo].[Bookings] CHECK CONSTRAINT [FK_Bookings_Courts]
GO
