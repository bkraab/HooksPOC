
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Insight](
	[InsightId] [int] IDENTITY(1,1) NOT NULL,
	[MemberMessageHeadline]		[nvarchar](100)	NOT NULL,
	[MemberMessage]				[nvarchar](500) NOT NULL,
	[ProviderMessageheadline]	[nvarchar](100)	NOT NULL,
	[ProviderMessage]			[nvarchar](500) NULL,
	[MessageType]				[nvarchar](100) NULL,
	[Sensitiveind]				[int] NOT		NULL,
	[RuleNameFriendly]			[nvarchar](100)	NULL,
	[RuleName]					[nvarchar](100)	NULL,
	[CreateDate]				[datetime]		NOT NULL,
	[CreateUser]				[nvarchar](50)  NOT NULL,
	[UpdateDate]				[datetime]		NULL,
	[UpdateUser]				[nvarchar](50)	NULL,
 CONSTRAINT [PK_Insight] PRIMARY KEY CLUSTERED 
(
	[InsightId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO






