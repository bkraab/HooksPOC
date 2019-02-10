
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[CdsServicePrefetch](
	[CdsServicePrefetchId]  [int] IDENTITY(1,1)  NOT NULL,
	[CdsServiceConfigId]	[int]				 NOT NULL,
	[resourceName]			[nvarchar](100)		 NOT NULL,
	[resourceString]		[nvarchar](500)		 NOT NULL,
	[sequence]				[nvarchar](500)		 NOT NULL,
	[CreateDate]			[datetime]			 NOT NULL,
	[CreateUser]			[nvarchar](50)		 NOT NULL,
	[UpdateDate]			[datetime]			 NULL,
	[UpdateUser]			[nvarchar](50)		 NULL,
 CONSTRAINT [PK_CdsServicePrefetch] PRIMARY KEY CLUSTERED 
(
	[CdsServicePrefetchId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO






