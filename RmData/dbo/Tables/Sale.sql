﻿CREATE TABLE [dbo].[Sale]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [SaleDate] DATETIME2 NOT NULL DEFAULT getutcdate(), 
    [CashierId] NVARCHAR(128) NOT NULL, 
    [SubTotal] MONEY NOT NULL, 
    [Tax] MONEY NOT NULL, 
    [Total] MONEY NOT NULL, 
    CONSTRAINT [FK_Sale_ToUser] FOREIGN KEY ([CashierId]) REFERENCES [User]([Id])
)
