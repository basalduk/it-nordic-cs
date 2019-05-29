USE LiveHeroTour;
GO

--DROP  TABLE dbo.Goods
CREATE TABLE dbo.Goods(
Id INT NOT NULL IDENTITY(1,1),
CategoryId UNIqUEIDENTIFIER Not NULL,
[Name] NVARCHAR(100) NOT NULL,
CONSTRAINT PK_Goods PRIMARY KEY CLUSTERED (Id),
CONSTRAINT UQ_Goods_Name UNIQUE ([Name])
);

ALTER TABLE dbo.Goods
	ADD CONSTRAINT FK_Goods_CategoryId FOREIGN KEY (CategoryId)
		REFERENCES dbo.Category(Id);

DECLARE @guid AS UNIqUEIDENTIFIER

SELECT @guid = Id
FROM dbo.Category
WHERE [Name] = 'Mobile Phone'

--PRINT @guid

--DELETE FROM dbo.Goods 

TRUNCATE TABLE dbo.Goods

INSERT INTO dbo.Goods(CategoryId, [Name]) VALUES (@guid, 'IPhone X');

PRINT 'ID of IPhoneX is ' + CONVERT(VARCHAR(15), SCOPE_IDENTITY())

INSERT INTO dbo.Goods(CategoryId, [Name]) VALUES (@guid, 'Xiomy');

PRINT 'ID of Xiomy is ' + CAST(SCOPE_IDENTITY() AS VARCHAR(15))

SELECT * FROM dbo.Goods
