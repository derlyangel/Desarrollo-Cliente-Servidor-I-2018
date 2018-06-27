use HorariosI
go

CREATE PROCEDURE [dbo].[usp_ValidarContraseña] 
@prmContraseña varchar(30)
as
SELECT [id]
      ,[contraseña]
  FROM [HorariosI].[dbo].[Usuario]
  WHERE contraseña= @prmContraseña
  Go
  exec usp_ValidarContraseña '123456'