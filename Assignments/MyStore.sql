USE [master] 
GO
/****** Object:  Database [MyStore]    Script Date: 10/11/21 5:38:32 PM ******/
CREATE DATABASE [MyStore]

GO
USE [MyStore]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 10/11/21 5:38:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[CategoryID] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [nvarchar](15) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY] 
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 10/11/21 5:38:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[ProductID] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [nvarchar](40) NOT NULL,
	[CategoryID] [int] NULL,
	[UnitsInStock] [smallint] NULL,
	[UnitPrice] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Categories] ON 
GO
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (1, N'Beverages')
GO
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (2, N'Condiments')
GO
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (3, N'Confections')
GO
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (4, N'Dairy Products')
GO
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (5, N'Grains/Cereals')
GO
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (6, N'Meat/Poultry')
GO
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (7, N'Produce')
GO
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (8, N'Seafood')
GO
SET IDENTITY_INSERT [dbo].[Categories] OFF
GO
SET IDENTITY_INSERT [dbo].[Products] ON 
GO
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [UnitsInStock], [UnitPrice]) VALUES (1, N'Chai', 1, 12, 18.0000)
GO
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [UnitsInStock], [UnitPrice]) VALUES (2, N'Chang', 1, 23, 19.0000)
GO
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [UnitsInStock], [UnitPrice]) VALUES (3, N'Aniseed Syrup', 2, 23, 10.0000)
GO
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [UnitsInStock], [UnitPrice]) VALUES (4, N'Chef Anton''s Cajun Seasoning', 2, 34, 22.0000)
GO
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [UnitsInStock], [UnitPrice]) VALUES (5, N'Chef Anton''s Gumbo Mix', 2, 45, 21.3500)
GO
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [UnitsInStock], [UnitPrice]) VALUES (6, N'Grandma''s Boysenberry Spread', 2, 21, 25.0000)
GO
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [UnitsInStock], [UnitPrice]) VALUES (7, N'Uncle Bob''s Organic Dried Pears', 7, 22, 30.0000)
GO
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [UnitsInStock], [UnitPrice]) VALUES (8, N'Northwoods Cranberry Sauce', 2, 10, 40.0000)
GO
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [UnitsInStock], [UnitPrice]) VALUES (9, N'Mishi Kobe Niku', 6, 12, 97.0000)
GO
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [UnitsInStock], [UnitPrice]) VALUES (10, N'Ikura', 8, 13, 31.0000)
GO
SET IDENTITY_INSERT [dbo].[Products] OFF
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD FOREIGN KEY([CategoryID])
REFERENCES [dbo].[Categories] ([CategoryID])
GO
USE [master]
GO
ALTER DATABASE [MyStore] SET  READ_WRITE 
GO
