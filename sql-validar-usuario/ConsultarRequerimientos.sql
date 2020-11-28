use ReqV1
go
-- exec ConsultarRequerimientos 1  -- blisboa
-- exec ConsultarRequerimientos 2  -- pperez
-- exec ConsultarRequerimientos 'blisboa'
-- exec ConsultarRequerimientos 'pperez'


alter proc ConsultarRequerimientos(@NickUsuario varchar(10))
as begin
   select	tr.Nombre,
			p.nombre,
			r.Descripcion,
			p.plazo,
			r.Id_Usuario,
			U.Nick_usuario
   from Requerimiento r
   inner join TipoPrioridad p
   ON r.Id_Prioridad = p.Id_Prioridad
   inner join TipoRequerimiento tr
   ON tr.Id_Tipo = r.Id_Tipo
   inner join Usuario u
   ON r.Id_Usuario = u.Id_Usuario
--   where r.Id_Usuario = @usuario
   where u.Nick_usuario = @NickUsuario
end
