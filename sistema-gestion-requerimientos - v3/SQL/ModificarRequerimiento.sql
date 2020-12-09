use ReqV1
go

alter  proc ModificarRequerimiento(@IdReq int)
as begin
 
	update Requerimiento set Estado ='R' where Id_requerimiento = @IdReq 
    select	0 as CodigoRet, 
			'El requerimiento ' + convert(varchar(5),@IdReq ) + ' cambió de estado.' as MensajeRet 
end