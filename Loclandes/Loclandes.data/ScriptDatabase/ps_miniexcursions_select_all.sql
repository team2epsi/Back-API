IF OBJECT_ID('ps_miniexcursions_select_all', 'P') IS NOT NULL
DROP PROC ps_miniexcursions_select_all
GO

CREATE PROCEDURE ps_miniexcursions_select_all

AS
BEGIN
	SELECT *
	FROM MiniExcursions
END;
