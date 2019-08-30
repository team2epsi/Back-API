IF OBJECT_ID('ps_miniexcursion_update', 'P') IS NOT NULL
DROP PROC ps_miniexcursion_update
GO

CREATE PROCEDURE ps_miniexcursion_update
(
	@idMiniExcursion int,
	@libelleMiniExcursion varchar(255),
	@nombrePlaceMiniExcursion int
)

AS

declare @mini int
set @mini = (SELECT count(*) FROM MiniExcursions WHERE idMiniExcursion = @idMiniExcursion)
print @mini

IF (@mini = 1)
BEGIN

UPDATE dbo.[MiniExcursions]
SET [libelleMiniExcursion] = @libelleMiniExcursion,
	[nombrePlaceMiniExcursion] = @nombrePlaceMiniExcursion
WHERE [idMiniExcursion] = @idMiniExcursion
print 'MiniExcursion has been successfully updated'
END
ELSE
print 'MiniExcursion has not been updated'

--EXEC ps_miniexcursion_update_test @idMiniExcursion=23, @libelleMiniExcursion='coucou', @nombrePlaceMiniExcursion = 2
