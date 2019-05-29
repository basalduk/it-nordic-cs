USE LiveHeroTour;
GO

CREATE PROCEDURE dbo.CreateCategory(
@categoryName AS VARCHAR(50),
@guid AS UNIQUEIDENTIFIER OUTPUT)

AS BEGIN
	SET NOCOUNT ON
	DECLARE @tempguid AS UNIQUEIDENTIFIER
	SELECT @tempguid = NEWID()

	INSERT INTO dbo.Category (Id,[Name])
	VALUES (@tempguid,@categoryName)

	SET @guid = @tempguid

END
GO

DELETE  FROM dbo.Category WHERE [Name]= 'TEST'
DECLARE @guid AS UNIQUEIDENTIFIER
EXECUTE dbo.CreateCategory @categoryName = 'TEST', @guid=@guid OUTPUT

PRINT CONVERT(VARCHAR(50), @guid)

SELECT * FROM dbo.Category


