use ReqV1
go

create  proc EliminarRequerimiento(@IdReq int)
as begin
	delete Requerimiento where Id_requerimiento = @IdReq 
    select	0 as CodigoRet, 
			'El requerimiento ' + convert(varchar(5),@IdReq ) + ' fue eliminado.' as MensajeRet 
end