CREATE TABLE [dbo].[People]
(
	[Id] INT NOT NULL PRIMARY KEY identity, 
    [FirstName] NVARCHAR(50) NOT NULL, 
    [LastName] NVARCHAR(50) NOT NULL, 
    [Email] NVARCHAR(50) NULL
)
