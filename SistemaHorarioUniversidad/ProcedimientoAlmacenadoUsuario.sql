use HorariosI
go

CREATE PROCEDURE [dbo].[usp_ValidarUsuario] 
@prmUsuario varchar(30)
as
SELECT [id]
      ,[contraseña]
  FROM [HorariosI].[dbo].[Usuario]
  WHERE id= @prmUsuario
  Go
  exec usp_ValidarUsuario 'MG123'