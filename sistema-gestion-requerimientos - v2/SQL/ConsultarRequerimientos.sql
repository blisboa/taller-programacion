USE [ReqV1]
GO
/****** Object:  StoredProcedure [dbo].[ConsultarRequerimientos]    Script Date: 02-12-2020 13:24:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- exec ConsultarRequerimientos 'pperez','R'
-- exec ConsultarRequerimientos 2  -- pperez

ALTER proc [dbo].[ConsultarRequerimientos](@NickUsuario varchar(10), @estado char(1) )
as begin
   select	tr.Nombre as 'Requerimiento',
			p.nombre as 'Prioridad',
			r.Descripcion as 'Descripcion',
			p.plazo as 'Dias de plazo',
			U.Nick_usuario as 'Responsable',
			r.Estado as 'Estado'
   from Requerimiento r
   inner join TipoPrioridad p
   ON r.Id_Prioridad = p.Id_Prioridad
   inner join TipoRequerimiento tr
   ON tr.Id_Tipo = r.Id_Tipo
   inner join Usuario u
   ON r.Id_Usuario = u.Id_Usuario
--   where r.Id_Usuario = @usuario
   where u.Nick_usuario = @NickUsuario
   and r.Estado = @estado
end
