CREATE PROCEDURE [dbo].[spProduct_GetById]
	@Id int
AS
	SET NOCOUNT ON;
	SELECT Id, [Name], [Description], RetailPrice, QuantityInStock, IsTaxable 
	FROM dbo.Product
	WHERE Id = @Id
RETURN 0
