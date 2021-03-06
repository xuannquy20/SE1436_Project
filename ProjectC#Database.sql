USE [csProject]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 8/11/2021 11:05:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[username] [varchar](50) NOT NULL,
	[password] [varchar](50) NULL,
	[isStaff] [int] NULL,
	[name] [nvarchar](100) NULL,
	[phone] [varchar](20) NULL,
	[feedback] [nvarchar](4000) NULL,
	[liked] [int] NULL,
	[datefb] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[bookOff]    Script Date: 8/11/2021 11:05:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bookOff](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](100) NULL,
	[sdt] [varchar](20) NULL,
	[room] [int] NULL,
	[datebook] [datetime] NULL,
	[dateend] [datetime] NULL,
	[people] [int] NULL,
	[status] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[listBook]    Script Date: 8/11/2021 11:05:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[listBook](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[username] [varchar](50) NULL,
	[room] [int] NULL,
	[datebook] [date] NULL,
	[dateend] [date] NULL,
	[people] [int] NULL,
	[status] [int] NULL,
 CONSTRAINT [PK_listBook] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[requestCheckout]    Script Date: 8/11/2021 11:05:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[requestCheckout](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idbook] [int] NULL,
	[status] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[room]    Script Date: 8/11/2021 11:05:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[room](
	[room] [int] NOT NULL,
	[floor] [int] NULL,
	[type] [int] NULL,
	[status] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[room] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Account] ([username], [password], [isStaff], [name], [phone], [feedback], [liked], [datefb]) VALUES (N'cobecocu', N'123', 0, N'cobecocu', N'0563887898', N'alo', 1, CAST(N'2021-07-23' AS Date))
INSERT [dbo].[Account] ([username], [password], [isStaff], [name], [phone], [feedback], [liked], [datefb]) VALUES (N'huanhoahong', N'1', 0, N'Nguyen Van A', N'0123456123', N'abc', 1, CAST(N'2021-06-21' AS Date))
INSERT [dbo].[Account] ([username], [password], [isStaff], [name], [phone], [feedback], [liked], [datefb]) VALUES (N'staff', N'1', 1, N'Nguyen Van B', N'0123197211', N'khách sạn ổn vl', 0, CAST(N'2021-06-21' AS Date))
INSERT [dbo].[Account] ([username], [password], [isStaff], [name], [phone], [feedback], [liked], [datefb]) VALUES (N'user', N'1', 0, N'Nguyen Van C', N'0127399128', N'ổn', 2, CAST(N'2021-07-21' AS Date))
INSERT [dbo].[Account] ([username], [password], [isStaff], [name], [phone], [feedback], [liked], [datefb]) VALUES (N'user1', N'1', 0, N'Nguyen ABC', N'0912345678', N'đầy đủ đồ chơi ', 0, CAST(N'2021-07-21' AS Date))
INSERT [dbo].[Account] ([username], [password], [isStaff], [name], [phone], [feedback], [liked], [datefb]) VALUES (N'user2', N'1', 0, N'Nguyen Van D', N'0458923012', N'nhân viên ngon :)', 0, CAST(N'2021-07-21' AS Date))
GO
INSERT [dbo].[room] ([room], [floor], [type], [status]) VALUES (101, 1, 1, 0)
INSERT [dbo].[room] ([room], [floor], [type], [status]) VALUES (102, 1, 1, 0)
INSERT [dbo].[room] ([room], [floor], [type], [status]) VALUES (103, 1, 1, 0)
INSERT [dbo].[room] ([room], [floor], [type], [status]) VALUES (104, 1, 1, 0)
INSERT [dbo].[room] ([room], [floor], [type], [status]) VALUES (105, 1, 1, 0)
INSERT [dbo].[room] ([room], [floor], [type], [status]) VALUES (106, 1, 1, 0)
INSERT [dbo].[room] ([room], [floor], [type], [status]) VALUES (201, 2, 1, 0)
INSERT [dbo].[room] ([room], [floor], [type], [status]) VALUES (202, 2, 1, 0)
INSERT [dbo].[room] ([room], [floor], [type], [status]) VALUES (203, 2, 1, 0)
INSERT [dbo].[room] ([room], [floor], [type], [status]) VALUES (204, 2, 1, 0)
INSERT [dbo].[room] ([room], [floor], [type], [status]) VALUES (205, 2, 1, 0)
INSERT [dbo].[room] ([room], [floor], [type], [status]) VALUES (206, 2, 1, 0)
INSERT [dbo].[room] ([room], [floor], [type], [status]) VALUES (301, 3, 2, 0)
INSERT [dbo].[room] ([room], [floor], [type], [status]) VALUES (302, 3, 2, 0)
INSERT [dbo].[room] ([room], [floor], [type], [status]) VALUES (303, 3, 2, 0)
INSERT [dbo].[room] ([room], [floor], [type], [status]) VALUES (304, 3, 2, 0)
INSERT [dbo].[room] ([room], [floor], [type], [status]) VALUES (305, 3, 2, 0)
INSERT [dbo].[room] ([room], [floor], [type], [status]) VALUES (306, 3, 2, 0)
INSERT [dbo].[room] ([room], [floor], [type], [status]) VALUES (401, 4, 2, 0)
INSERT [dbo].[room] ([room], [floor], [type], [status]) VALUES (402, 4, 2, 0)
INSERT [dbo].[room] ([room], [floor], [type], [status]) VALUES (403, 4, 2, 0)
INSERT [dbo].[room] ([room], [floor], [type], [status]) VALUES (404, 4, 2, 0)
INSERT [dbo].[room] ([room], [floor], [type], [status]) VALUES (405, 4, 2, 0)
INSERT [dbo].[room] ([room], [floor], [type], [status]) VALUES (406, 4, 2, 0)
INSERT [dbo].[room] ([room], [floor], [type], [status]) VALUES (501, 5, 3, 0)
INSERT [dbo].[room] ([room], [floor], [type], [status]) VALUES (502, 5, 3, 0)
INSERT [dbo].[room] ([room], [floor], [type], [status]) VALUES (503, 5, 3, 0)
INSERT [dbo].[room] ([room], [floor], [type], [status]) VALUES (504, 5, 3, 0)
INSERT [dbo].[room] ([room], [floor], [type], [status]) VALUES (505, 5, 3, 0)
INSERT [dbo].[room] ([room], [floor], [type], [status]) VALUES (506, 5, 3, 0)
INSERT [dbo].[room] ([room], [floor], [type], [status]) VALUES (601, 6, 3, 0)
INSERT [dbo].[room] ([room], [floor], [type], [status]) VALUES (602, 6, 3, 0)
INSERT [dbo].[room] ([room], [floor], [type], [status]) VALUES (603, 6, 3, 0)
INSERT [dbo].[room] ([room], [floor], [type], [status]) VALUES (604, 6, 3, 0)
INSERT [dbo].[room] ([room], [floor], [type], [status]) VALUES (605, 6, 3, 0)
INSERT [dbo].[room] ([room], [floor], [type], [status]) VALUES (606, 6, 3, 0)
GO
ALTER TABLE [dbo].[bookOff]  WITH CHECK ADD FOREIGN KEY([room])
REFERENCES [dbo].[room] ([room])
GO
ALTER TABLE [dbo].[listBook]  WITH CHECK ADD FOREIGN KEY([username])
REFERENCES [dbo].[Account] ([username])
GO
ALTER TABLE [dbo].[listBook]  WITH CHECK ADD  CONSTRAINT [FK_listBook_room] FOREIGN KEY([room])
REFERENCES [dbo].[room] ([room])
GO
ALTER TABLE [dbo].[listBook] CHECK CONSTRAINT [FK_listBook_room]
GO
ALTER TABLE [dbo].[requestCheckout]  WITH CHECK ADD FOREIGN KEY([idbook])
REFERENCES [dbo].[listBook] ([id])
GO
