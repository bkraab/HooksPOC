
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[InsightLink](
	[InsightLinkId]	[int] IDENTITY(1,1) NOT NULL,
	[InsightId]		[int] NOT NULL,
	[LinkLabel]		[nvarchar](100)	NOT NULL,
	[LinkUrl]		[nvarchar](250) NOT NULL,
	[Vv_LinkType]	[nvarchar](25)	NOT NULL,
	[CreateDate]	[datetime]		NOT NULL,
	[CreateUser]	[nvarchar](50)  NOT NULL,
	[UpdateDate]	[datetime]		NULL,
	[UpdateUser]	[nvarchar](50)	NULL,
 CONSTRAINT [PK_InsightLink] PRIMARY KEY CLUSTERED 
(
	[InsightLinkId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO






