CREATE TABLE [dbo].[Permission]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [RoleName] NCHAR(10) NULL, 
    [PermissionName] NCHAR(10) NOT NULL
)
