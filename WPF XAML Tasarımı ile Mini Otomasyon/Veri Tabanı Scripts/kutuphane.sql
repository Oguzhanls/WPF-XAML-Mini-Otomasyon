USE [KutuphaneDB]
GO
/****** Object:  Table [dbo].[Kitaplar]    Script Date: 3.06.2023 17:09:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kitaplar](
	[kitapID] [int] IDENTITY(1,1) NOT NULL,
	[kitapAdi] [varchar](50) NULL,
	[kitapYazari] [varchar](50) NULL,
	[kitapTuru] [varchar](50) NULL,
	[yayinEvi] [varchar](50) NULL,
	[rafNumara] [int] NULL,
 CONSTRAINT [PK_Kitaplar] PRIMARY KEY CLUSTERED 
(
	[kitapID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[login]    Script Date: 3.06.2023 17:09:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[login](
	[users_ID] [int] IDENTITY(1,1) NOT NULL,
	[users_name] [varchar](50) NULL,
	[password] [varchar](50) NULL,
 CONSTRAINT [PK_login] PRIMARY KEY CLUSTERED 
(
	[users_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[uyeler]    Script Date: 3.06.2023 17:09:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[uyeler](
	[uyeID] [int] IDENTITY(1,1) NOT NULL,
	[uyeTC] [int] NULL,
	[uyeADİ] [nvarchar](50) NULL,
	[uyeSOYADİ] [nvarchar](50) NULL,
	[uyeTELNO] [int] NULL,
	[uyeMAİL] [nvarchar](50) NULL,
 CONSTRAINT [PK_uyeler] PRIMARY KEY CLUSTERED 
(
	[uyeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Kitaplar] ON 

INSERT [dbo].[Kitaplar] ([kitapID], [kitapAdi], [kitapYazari], [kitapTuru], [yayinEvi], [rafNumara]) VALUES (1, N'Tutunamayanlar', N'Oğuz Atay', N'Roman', N'Karakus Yayınları', 98)
SET IDENTITY_INSERT [dbo].[Kitaplar] OFF
GO
SET IDENTITY_INSERT [dbo].[login] ON 

INSERT [dbo].[login] ([users_ID], [users_name], [password]) VALUES (1, N'admin', N'1234')
SET IDENTITY_INSERT [dbo].[login] OFF
GO
SET IDENTITY_INSERT [dbo].[uyeler] ON 

INSERT [dbo].[uyeler] ([uyeID], [uyeTC], [uyeADİ], [uyeSOYADİ], [uyeTELNO], [uyeMAİL]) VALUES (1, NULL, N'Oğuzhan', N'Karakuş', NULL, N'oguzhan.krakus@gmail.com')
INSERT [dbo].[uyeler] ([uyeID], [uyeTC], [uyeADİ], [uyeSOYADİ], [uyeTELNO], [uyeMAİL]) VALUES (4, NULL, N'Oğuzhan', N'Karakuş', 5396339, N'oguzhan.krakus@gmail.com')
INSERT [dbo].[uyeler] ([uyeID], [uyeTC], [uyeADİ], [uyeSOYADİ], [uyeTELNO], [uyeMAİL]) VALUES (5, 1560165, N'Faruk ', N'Ulutürk', 5232545, N'faruk')
INSERT [dbo].[uyeler] ([uyeID], [uyeTC], [uyeADİ], [uyeSOYADİ], [uyeTELNO], [uyeMAİL]) VALUES (6, 1560165378, N'Faruk ', N'Ulutürk', 523254, N'faruk')
SET IDENTITY_INSERT [dbo].[uyeler] OFF
GO
