CREATE TABLE [dbo].[UserPermission]
(
	[Id_UserPermission] INT NOT NULL PRIMARY KEY, 
    [Id_User] INT NOT NULL, 
    [Id_Permission] INT NOT NULL, 
    CONSTRAINT [FK_UserPermission_ToUser] FOREIGN KEY (Id_User) REFERENCES UserR(Id),
    CONSTRAINT [FK_UserPermission_ToPermission] FOREIGN KEY (Id_Permission) REFERENCES Permission(Id)
)
