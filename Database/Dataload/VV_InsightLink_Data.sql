Declare @CreateUser as nvarchar(50)
set @CreateUser = 'initialLoad'

INSERT INTO [dbo].[VV_InsightLink]([TypeName], [TypeDescription], [IsEnabled], [CreateDate], [CreateUser])
VALUES('absolute', 'indicates that the URL is absolute and should be treated as-is', 1, getdate(), @CreateUser)

INSERT INTO [dbo].[VV_InsightLink]([TypeName], [TypeDescription], [IsEnabled], [CreateDate], [CreateUser])
VALUES('smart', 'indicates that the URL is a SMART app launch URL', 1, getdate(), @CreateUser)

GO