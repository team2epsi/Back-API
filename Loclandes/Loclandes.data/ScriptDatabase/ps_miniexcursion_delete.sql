DROP PROC ps_miniexcursion_delete
GO

CREATE PROCEDURE [dbo].[ps_miniexcursion_delete]
    @idMiniExcursion int
   
    
AS
BEGIN
DELETE FROM MiniExcursions WHERE idMiniExcursion = @idMiniExcursion;
END







