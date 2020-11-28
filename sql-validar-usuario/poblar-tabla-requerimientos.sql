-- insertar tipos de req.
insert TipoRequerimiento select 1,'Instalar Software'
insert TipoRequerimiento select 2,'Formatear computador'
insert TipoRequerimiento select 3,'Desbloquear usuario '

-- insert prioridades
insert TipoPrioridad select 1,'Alta',3
insert TipoPrioridad select 2,'Media',4
insert TipoPrioridad select 3,'Baja',5

-- simular el ingreso de requemientos por pantalla
insert Requerimiento select 1,'Instalar Office',1,1,3,'P'
insert Requerimiento select 2,'Instalar Chrome',1,1,1,'P'
insert Requerimiento select 3,'Instalar Excel',2,1,3,'P'
insert Requerimiento select 4,'Instalar Outllok',2,1,1,'P'

select *  from Usuario where Nick_usuario = 'blisboa'
select 1024*4
123456->#r4..5&66





select *  from Requerimiento 
