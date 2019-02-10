ALTER TABLE [dbo].[InsightLink]  WITH CHECK ADD  CONSTRAINT [FK_InsightLink_Insight] FOREIGN KEY([InsightId])
REFERENCES [dbo].[Insight] ([InsightId])
GO

ALTER TABLE [dbo].[InsightLink] CHECK CONSTRAINT [FK_InsightLink_Insight]
GO


ALTER TABLE [dbo].[InsightLink]  WITH CHECK ADD  CONSTRAINT [FK_InsightLink_VV_InsightLink] FOREIGN KEY([Vv_LinkType])
REFERENCES [dbo].[VV_InsightLink] ([TypeName])
GO

ALTER TABLE [dbo].[InsightLink] CHECK CONSTRAINT [FK_InsightLink_VV_InsightLink]
GO

