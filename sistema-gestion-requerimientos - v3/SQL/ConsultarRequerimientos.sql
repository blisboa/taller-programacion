USE [ReqV1]
GO
/****** Object:  StoredProcedure [dbo].[ConsultarRequerimientos]    Script Date: 09-12-2020 14:27:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- exec ConsultarRequerimientos 'pperez','P'
-- exec ConsultarRequerimientos 2  -- pperez

ALTER proc [dbo].[ConsultarRequerimientos](	@NickUsuario varchar(10), 
											@estado char(1),
											@tipoReq int,
											@tipoPrioridad int)
as begin
   select	r.Id_requerimiento as 'Id',
			tr.Nombre as 'Requerimiento',
			p.nombre as 'Prioridad',
			r.Descripcion as 'Descripcion',
			p.plazo as 'Dias de plazo',
			U.Nick_usuario as 'Responsable',
			--r.Estado as 'Estado',
			case r.Estado
			  when 'P' then 'Pendiente'
			  when 'R' then 'Resuelto'
		  end as Estado
   from Requerimiento r
   inner join TipoPrioridad p
   ON r.Id_Prioridad = p.Id_Prioridad
   inner join TipoRequerimiento tr
   ON tr.Id_Tipo = r.Id_Tipo
   inner join Usuario u
   ON r.Id_Usuario = u.Id_Usuario
   where u.Nick_usuario = @NickUsuario
   and r.Estado = @estado
   and r.Id_Tipo =  @tipoReq
   and  r.Id_Prioridad = @tipoPrioridad
end
