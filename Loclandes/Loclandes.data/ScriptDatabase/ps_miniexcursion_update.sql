CREATE PROCEDURE ps_miniexcursion_update
(
	@idMiniExcursion int,
	@libelleMiniExcursion varchar(255),
	@nombrePlaceMiniExcursion int
)

AS
BEGIN

UPDATE dbo.[MiniExcursions]
SET [libelleMiniExcursion] = @libelleMiniExcursion,
	[nombrePlaceMiniExcursion] = @nombrePlaceMiniExcursion
WHERE [idMiniExcursion] = @idMiniExcursion

END