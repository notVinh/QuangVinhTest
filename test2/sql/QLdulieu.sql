USE [QLdulieu]
GO
/****** Object:  Table [dbo].[Nguoidung]    Script Date: 5/4/2022 3:25:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nguoidung](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[hoten] [nvarchar](50) NULL,
	[email] [nvarchar](50) NULL,
	[dienthoai] [nchar](12) NULL,
	[noidung] [nvarchar](50) NULL,
 CONSTRAINT [PK_Nguoidung] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
