CREATE PROCEDURE [dbo].[ps_miniexcursion_insert]
    @idMiniExcursion int,
	@libelleMiniExcursion varchar(255),
	@nombrePlaceMiniExcursion int
	
AS
BEGIN
	INSERT [DBLoclandes].[dbo].[MiniExcursions] (libelleMiniExcursion, nombrePlaceMiniExcursion) 
	VALUES (@libelleMiniExcursion, @nombrePlaceMiniExcursion)
END