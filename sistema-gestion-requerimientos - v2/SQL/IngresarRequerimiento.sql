alter  procedure IngresarRequerimiento(	@tipoReq int, 
										@IdUsuario int,
										@descripcion varchar(30),
										@tipoPrioridad int)
as begin
  declare @nuevo_id int

  select @nuevo_id  = isnull(max(Id_Requerimiento),0) +  1 from Requerimiento

  insert Requerimiento select @nuevo_id,@descripcion,@IdUsuario,@tipoReq,@tipoPrioridad,'P' 

  declare @plazo int,
           @Mensaje varchar(100)

  select @plazo  = plazo from TipoPrioridad where Id_Prioridad = @tipoPrioridad
  select @Mensaje = 'El requerimiento fue ingresado, el plazo para resolverlo es ' + convert(varchar(2), @plazo) + ' dias'

  -- tabla retornada hacia la pantalla
  select 0 as CodigoRet,
	     @Mensaje as MensajeRet
end