﻿

/****** Object:  Table [dbo].[DbInfo]    Script Date: 7/12/2018 2:35:11 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[DbInfo](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Version] [varchar](100) NOT NULL,
 CONSTRAINT [PK_DbInfo] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO