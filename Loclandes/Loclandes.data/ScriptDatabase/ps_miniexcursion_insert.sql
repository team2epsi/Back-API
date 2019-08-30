IF OBJECT_ID('ps_miniexcursion_insert', 'P') IS NOT NULL
DROP PROC ps_miniexcursion_insert
GO

CREATE PROCEDURE [dbo].[ps_miniexcursion_insert]
	@libelleMiniExcursion varchar(255),
	@nombrePlaceMiniExcursion int
	
AS
BEGIN
	INSERT [DBLoclandes].[dbo].[MiniExcursions] (libelleMiniExcursion, nombrePlaceMiniExcursion) 
	VALUES (@libelleMiniExcursion, @nombrePlaceMiniExcursion)
END
