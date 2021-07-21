CREATE TABLE [dbo].[Product]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] NVARCHAR(100) NOT NULL, 
    [Description] NVARCHAR(MAX) NOT NULL, 
    [RetailPrice] MONEY NOT NULL, 
    [QuantityInStock] INT NOT NULL DEFAULT 1, 
    [CreatedDate] DATETIME2 NOT NULL DEFAULT getutcdate(),
	[ModifiedDate] DATETIME2 NOT NULL DEFAULT getutcdate()
)
