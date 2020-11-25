use ReqV1
go

-- select *  from Usuario

--  exec ValidarUsuario 'blisboa','123456' -->   dr = cmd.ExecuteReader(usua,cla);
alter proc ValidarUsuario(	@nickName varchar(10),
							@password varchar(30))
as
begin
   -- verificar si el usuario existe
   if exists (select * from Usuario where Nick_usuario = @nickName)
		-- se ejecuta si el usuario existe
		-- entonces validar si la clave es correcta
		if exists (select * from Usuario where Nick_usuario = @nickName and Contraseña = @password)
			select 'UsuarioOk' as CodigoRet
		else
			select 'ClaveIncorrecta' as CodigoRet
   else
		-- se ejecuta si el usuairo NO existe
		select 'UsuarioInvalido' as CodigoRet
end
