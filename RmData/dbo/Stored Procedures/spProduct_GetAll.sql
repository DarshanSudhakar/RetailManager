CREATE PROCEDURE [dbo].[spProduct_GetAll]
AS

	SET NOCOUNT ON;

	SELECT Id, [Name], [Description], RetailPrice, QuantityInStock, IsTaxable  
	FROM dbo.Product
	ORDER BY Name
RETURN 0
