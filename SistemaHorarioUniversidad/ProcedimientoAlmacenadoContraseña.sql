use HorariosI
go

CREATE PROCEDURE [dbo].[usp_ValidarContrase�a] 
@prmContrase�a varchar(30)
as
SELECT [id]
      ,[contrase�a]
  FROM [HorariosI].[dbo].[Usuario]
  WHERE contrase�a= @prmContrase�a
  Go
  exec usp_ValidarContrase�a '123456'