Declare @CreateUser as nvarchar(50)
set @CreateUser = 'initialLoad'

INSERT INTO [dbo].[CdsServicePrefetch]([CdsServiceConfigId], [resourceName], [resourceString], [sequence], [CreateDate], [CreateUser])
VALUES(1, 'requestedPatient', 'Patient/{{context.patientId}}', 1, getdate(), @CreateUser)

INSERT INTO [dbo].[CdsServicePrefetch]([CdsServiceConfigId], [resourceName], [resourceString], [sequence], [CreateDate], [CreateUser])
VALUES(1, 'user', '{{context.userId}}', 2, getdate(), @CreateUser)


GO


