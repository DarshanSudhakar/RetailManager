CREATE TABLE [dbo].[Sale]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [SaleDate] DATETIME2 NOT NULL DEFAULT getutcdate(), 
    [CashierId] NVARCHAR(128) NOT NULL, 
    [UserId] NVARCHAR(128) NULL
)
