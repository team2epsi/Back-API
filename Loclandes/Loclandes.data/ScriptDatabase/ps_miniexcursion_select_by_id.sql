CREATE PROCEDURE ps_miniexcursion_select_by_id
(
	@idMiniExcursion int
)

AS
BEGIN

SELECT *
FROM MiniExcursions
WHERE idMiniExcursion = @idMiniExcursion

END