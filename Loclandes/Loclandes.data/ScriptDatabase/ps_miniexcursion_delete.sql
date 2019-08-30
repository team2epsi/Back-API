IF OBJECT_ID('ps_miniexcursion_delete', 'P') IS NOT NULL
DROP PROC ps_miniexcursion_delete
GO

CREATE PROCEDURE [dbo].[ps_miniexcursion_delete]
    @idMiniExcursion int
   
    
AS
BEGIN
DELETE FROM MiniExcursions WHERE idMiniExcursion = @idMiniExcursion;
END
