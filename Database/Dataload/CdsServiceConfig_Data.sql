Declare @CreateUser as nvarchar(50)
set @CreateUser = 'initialLoad'

INSERT INTO [dbo].[CdsServiceConfig]([Hook], [Title], [Description], [Id], [CreateDate], [CreateUser])
VALUES('patient-view', 'Example patient-view CDS Service', 'Returns CDS Insights', 'patient-view-example', getdate(), @CreateUser)

INSERT INTO [dbo].[CdsServiceConfig]([Hook], [Title], [Description], [Id], [CreateDate], [CreateUser])
VALUES('medication-prescribe', 'Example medicaton-prescribe CDS Service', 'Returns CDS Insghts', 'medication-prescribe-example', getdate(), @CreateUser)

GO


