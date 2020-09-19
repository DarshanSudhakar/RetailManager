CREATE TABLE [dbo].[Product]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] NVARCHAR(100) NOT NULL, 
    [Description] NVARCHAR(MAX) NOT NULL, 
    [Size] FLOAT NOT NULL, 
    [Unit] NVARCHAR(20) NOT NULL, 
    [TaxId] INT NOT NULL
)
