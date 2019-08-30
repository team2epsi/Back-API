IF OBJECT_ID('ps_miniexcursion_select_by_id', 'P') IS NOT NULL
DROP PROC ps_miniexcursion_select_by_id
GO

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
