USE [ReqV1]
GO
/****** Object:  StoredProcedure [dbo].[ValidarUsuario]    Script Date: 27-11-2020 12:23:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- select *  from Usuario
--drop proc [dbo].[ValidarUsuario]

--  exec ValidarUsuario 'juan','123456'
--go
--  exec ValidarUsuario 'blisboa','123456'
--go
--  exec ValidarUsuario 'nnnn','123456x'
create or alter proc [dbo].[ValidarUsuario](	@nickName varchar(10),
							@password varchar(30))
as
begin
   -- verificar si el usuario existe
   if exists (select * from Usuario where Nick_usuario = @nickName)
		-- se ejecuta si el usuario existe
		-- entonces validar si la clave es correcta
		if exists (select * from Usuario where Nick_usuario = @nickName and Contraseña = @password)
			select	                  0 as CodigoRet,
					'Usuario Autorizado para acceder' as MensajeRet
		else
			select					 1 as CodigoRet,
					'Clave Incorrecta' as MensajeRet
   else
		-- se ejecuta si el usuairo NO existe
			select					  2 as CodigoRet,
					'Usuario Invalido' as MensajeRet
end
