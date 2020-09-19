CREATE TABLE [dbo].[Inventory]
(
	[ProductId] INT NOT NULL PRIMARY KEY, 
    [PurchasePrice] MONEY NOT NULL, 
    [RetailPrice] MONEY NOT NULL, 
    [Quantity] FLOAT NOT NULL, 
    [PurchaseDate] DATETIME2 NULL DEFAULT getutcdate()
)
