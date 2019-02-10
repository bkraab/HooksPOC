ALTER TABLE [dbo].[CdsServicePrefetch]  WITH CHECK ADD  CONSTRAINT [FK_CdsServicePrefetch_CdsServiceConfig] FOREIGN KEY([CdsServiceConfigId])
REFERENCES [dbo].[CdsServiceConfig] ([CdsServiceConfigId])
GO

ALTER TABLE [dbo].[CdsServicePrefetch] CHECK CONSTRAINT [FK_CdsServicePrefetch_CdsServiceConfig]
GO
