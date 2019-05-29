USE LiveHeroTour;
GO

CREATE FUNCTION dbo.GetCategoryId(
	@categoryName AS VARCHAR(50))
	RETURNS UNIQUEIDENTIFIER 
	AS

	BEGIN
	DECLARE @guid AS UNIQUEIDENTIFIER

	SELECT @guid =Id
	FROM dbo.Category 
	WHERE Category.[Name] = @categoryName
	
	IF (@guid IS NULL)
	BEGIN
		SELECT TOP 1 @guid =Id
		FROM dbo.Category 
		WHERE Category.[Name] LIKE @categoryName +' %'
	
	END

	RETURN (@guid)

	END
	GO
	SELECT dbo.GetCategoryId('Mobile')

	--RETURN (123)
	--SELECT Id FROM dbo.Category WHERE Category.[Name] = @categoryName