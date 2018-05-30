-- exec[Fj_servindustrias].[spROLES_Rpt017]  2,1,2,'01/07/2017','31/07/2017'
CREATE PROCEDURE [Fj_servindustrias].[spROLES_Rpt017]  
	@IdEmpresa int,
	@IdNomina int,
	@IdDivision int,
	@FechaInicio date,
	@FechaFin date
	
	
AS
/*

declare
   @IdEmpresa int,
	@FechaInicio date,
	@FechaFin date

	set @IdEmpresa=2
	
	set @FechaInicio ='2017-07-01'
	set @FechaFin ='2017-07-30'
	
	*/


SELECT        marc.IdEmpresa, marc.IdNomina_Tipo, marc.IdEmpleado, per.pe_cedulaRuc, per.pe_apellido + ' ' + per.pe_nombre AS Empleado, carg.ca_descripcion AS Cargo,

ISNULL(asistencia.Asistencia,0) Asistencia,
ISNULL(Atraso.Atraso,0) Atraso,
isnull(Falta.Falta,0) Falta,
ISNULL(Permiso.Permiso,0) Permiso,
ISNULL(SinLaborar.SinLaborar,0) SinLaborar,
ISNULL(Suspendido.Suspendido,0) Suspendido,
ISNULL(Vacaciones.Vacaciones,0) Vacaciones

FROM            dbo.ro_empleado AS emp INNER JOIN
                         Fj_servindustrias.ro_marcaciones_x_empleado_x_incidentes_falt_Perm AS marc ON emp.IdEmpresa = marc.IdEmpresa AND emp.IdEmpleado = marc.IdEmpleado INNER JOIN
                         dbo.ro_Nomina_Tipo AS nomin ON marc.IdEmpresa = nomin.IdEmpresa AND marc.IdNomina_Tipo = nomin.IdNomina_Tipo AND marc.IdEmpresa = nomin.IdEmpresa AND marc.IdNomina_Tipo = nomin.IdNomina_Tipo INNER JOIN
                         dbo.ro_catalogo AS catg ON marc.Id_catalogo_Cat = catg.CodCatalogo AND marc.Id_catalogo_Cat = catg.CodCatalogo INNER JOIN
                         dbo.tb_persona AS per ON emp.IdPersona = per.IdPersona INNER JOIN
                         dbo.ro_cargo AS carg ON emp.IdEmpresa = carg.IdEmpresa AND emp.IdCargo = carg.IdCargo

						 left join (
						 select m.IdEmpresa,m.IdEmpleado, count(m.IdEmpresa) Asistencia
							from Fj_servindustrias.ro_marcaciones_x_empleado_x_incidentes_falt_Perm m
							where m.Id_catalogo_Cat='ASIST' and CAST( m.es_fecha_registro as date) between  @FechaInicio and @FechaFin
							group by m.IdEmpresa,m.IdEmpleado
						 ) asistencia on marc.IdEmpresa = asistencia.IdEmpresa and marc.IdEmpleado = asistencia.IdEmpleado

						 left join (
						 select m.IdEmpresa,m.IdEmpleado, count(m.IdEmpresa) Atraso
							from Fj_servindustrias.ro_marcaciones_x_empleado_x_incidentes_falt_Perm m
							where m.Id_catalogo_Cat='ATRA' and CAST( m.es_fecha_registro as date) between  @FechaInicio and @FechaFin
							group by m.IdEmpresa,m.IdEmpleado
						 ) Atraso on marc.IdEmpresa = Atraso.IdEmpresa and marc.IdEmpleado = Atraso.IdEmpleado

						 left join (
						 select m.IdEmpresa,m.IdEmpleado, count(m.IdEmpresa) Falta
							from Fj_servindustrias.ro_marcaciones_x_empleado_x_incidentes_falt_Perm m
							where m.Id_catalogo_Cat='FAL' and CAST( m.es_fecha_registro as date) between  @FechaInicio and @FechaFin
							group by m.IdEmpresa,m.IdEmpleado
						 ) Falta on marc.IdEmpresa = Falta.IdEmpresa and marc.IdEmpleado = Falta.IdEmpleado

						 left join (
						 select m.IdEmpresa,m.IdEmpleado, count(m.IdEmpresa) Permiso
							from Fj_servindustrias.ro_marcaciones_x_empleado_x_incidentes_falt_Perm m
							where m.Id_catalogo_Cat='PER' and CAST( m.es_fecha_registro as date) between  @FechaInicio and @FechaFin
							group by m.IdEmpresa,m.IdEmpleado
						 ) Permiso on marc.IdEmpresa = Permiso.IdEmpresa and marc.IdEmpleado = Permiso.IdEmpleado

						 left join (
						 select m.IdEmpresa,m.IdEmpleado, count(m.IdEmpresa) SinLaborar
							from Fj_servindustrias.ro_marcaciones_x_empleado_x_incidentes_falt_Perm m
							where m.Id_catalogo_Cat='SINLABORAR' and CAST( m.es_fecha_registro as date) between  @FechaInicio and @FechaFin
							group by m.IdEmpresa,m.IdEmpleado
						 ) SinLaborar on marc.IdEmpresa = SinLaborar.IdEmpresa and marc.IdEmpleado = SinLaborar.IdEmpleado

						 left join (
						 select m.IdEmpresa,m.IdEmpleado, count(m.IdEmpresa) Suspendido
							from Fj_servindustrias.ro_marcaciones_x_empleado_x_incidentes_falt_Perm m
							where m.Id_catalogo_Cat='SUSP' and CAST( m.es_fecha_registro as date) between  @FechaInicio and @FechaFin
							group by m.IdEmpresa,m.IdEmpleado
						 ) Suspendido on marc.IdEmpresa = Suspendido.IdEmpresa and marc.IdEmpleado = Suspendido.IdEmpleado

						 left join (
						 select m.IdEmpresa,m.IdEmpleado, count(m.IdEmpresa) Vacaciones
							from Fj_servindustrias.ro_marcaciones_x_empleado_x_incidentes_falt_Perm m
							where m.Id_catalogo_Cat='VACA' and CAST( m.es_fecha_registro as date) between  @FechaInicio and @FechaFin
							group by m.IdEmpresa,m.IdEmpleado
						 ) Vacaciones on marc.IdEmpresa = Vacaciones.IdEmpresa and marc.IdEmpleado = Vacaciones.IdEmpleado

						 where emp.IdEmpresa=@IdEmpresa
						 and nomin.IdNomina_Tipo=@IdNomina
						 and emp.IdDivision=@IdDivision
						 and CAST( marc.es_fecha_registro as date) between  @FechaInicio and @FechaFin
						 group by
						 marc.IdEmpresa, marc.IdNomina_Tipo, marc.IdEmpleado, per.pe_cedulaRuc, per.pe_apellido + ' ' + per.pe_nombre , carg.ca_descripcion,
						 asistencia.Asistencia,Atraso,Falta.Falta,Permiso.Permiso,SinLaborar.SinLaborar,Suspendido.Suspendido,Vacaciones.Vacaciones