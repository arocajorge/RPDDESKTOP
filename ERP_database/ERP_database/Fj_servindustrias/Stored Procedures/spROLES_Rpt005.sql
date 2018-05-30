

create PROCEDURE [Fj_servindustrias].[spROLES_Rpt005]  
	@IdEmpresa int,
	@IdNomina_tipo int,
	@Fecha_Inicio date,
	@Fecha_Fin date,
	@Idperiodo int


AS
/*
declare
    @IdEmpresa int,
	@IdNomina_tipo int,
	@Fecha_Inicio date,
	@Fecha_Fin date,
	@Idperiodo int
	set @IdEmpresa=2
	set @IdNomina_tipo=1
	set @Fecha_Inicio ='2017-09-01'
	set @Fecha_Fin ='2017-09-30'
	set @Idperiodo =201709
*/	
BEGIN
	SELECT        Ma.IdEmpresa, Ma.IdNomina_Tipo, Ma.IdEmpleado, Ma.IdRegistro, P.pe_cedulaRuc, P.pe_nombre, P.pe_apellido, Ma.es_fecha_registro, 
                         Cat.ca_descripcion, C.ca_descripcion AS Cargo, Ma.IdTurno, Ma.es_jornada_desfasada,Dep.de_descripcion,
						 case when Ma.Id_catalogo_Cat='ASIST' THEN 'X'
						 WHEN Ma.Id_catalogo_Cat ='ATRA' THEN 'A'
						 WHEN Ma.Id_catalogo_Cat ='VACA' THEN 'V'
						 WHEN Ma.Id_catalogo_Cat ='PER' THEN 'P'
						 WHEN Ma.Id_catalogo_Cat ='FAL' THEN 'F'
						 WHEN Ma.Id_catalogo_Cat ='SUSP' THEN 'S'
						 WHEN Ma.Id_catalogo_Cat ='SINLABORAR' THEN 'SL'
						 WHEN Ma.es_jornada_desfasada =1 AND Ma.Id_catalogo_Cat='ASIST'  THEN 'JD'
						 ELSE '' END aS Id_catalogo_Cat,
						 planifica.zo_descripcion,
						 planifica.Disco,
						 planifica.ru_descripcion,
						 planifica.fu_descripcion,
					     planifica.Placa,
						 Em.em_status,


						 (select valor from ro_rol_detalle R where R.IdEmpresa=Em.idempresa 
						 and R.IdNominaTipo=@IdNomina_tipo
						 and R.IdNominaTipoLiqui=2
						 and R.IdPeriodo=@Idperiodo
						 and R.IdEmpleado=Em.IdEmpleado
						 and R.idrubro=2
						 )DiasTrabajados,

						 (select valor from ro_rol_detalle R where R.IdEmpresa=Em.idempresa 
						 and R.IdNominaTipo=@IdNomina_tipo
						 and R.IdNominaTipoLiqui=2
						 and R.IdPeriodo=@Idperiodo
						 and R.IdEmpleado=Em.IdEmpleado
						 and R.idrubro=976
						 )DiasEfectivos,

						 (select COUNT(R.IdEmpleado) from Fj_servindustrias.ro_marcaciones_x_empleado_x_incidentes_falt_Perm R 
						 where R.IdEmpresa=Em.idempresa 
						 and R.IdNomina_Tipo=@IdNomina_tipo
						 and R.IdEmpleado=Em.IdEmpleado
						 and cast(R.es_fecha_registro as date) between @Fecha_Inicio and @Fecha_Fin
						 and R.Id_catalogo_Cat='FAL'
						 )Faltas,

						 (select COUNT(R.IdEmpleado) from Fj_servindustrias.ro_marcaciones_x_empleado_x_incidentes_falt_Perm R 
						 where R.IdEmpresa=Em.idempresa 
						 and R.IdNomina_Tipo=@IdNomina_tipo
						 and R.IdEmpleado=Em.IdEmpleado
						 and cast(R.es_fecha_registro as date) between @Fecha_Inicio and @Fecha_Fin
						 and R.Id_catalogo_Cat='PER'
						 )Permiso,

						 (select sum(R.Dias_a_disfrutar) from vwRo_Solicitud_Vacaciones R 
						 where R.IdEmpresa=Em.idempresa 
						 and R.IdNomina_Tipo=@IdNomina_tipo
						 and R.IdEmpleado=Em.IdEmpleado
						 and cast(R.Fecha_Desde as date) between @Fecha_Inicio and @Fecha_Fin
						 and R.IdOrdenPago>0
						 )Vacaciones,
						 
						 (select valor from ro_rol_detalle R where R.IdEmpresa=Em.idempresa 
						 and R.IdNominaTipo=@IdNomina_tipo
						 and R.IdNominaTipoLiqui=2
						 and R.IdPeriodo=@Idperiodo
						 and R.IdEmpleado=Em.IdEmpleado
						 and R.idrubro=966
						 )HorasExtras,
						 em.IdDivision,
						 em.IdArea


						 
						-- ELSE END THEN  'N' AS Id_catalogo_Cat
FROM                     dbo.ro_Division INNER JOIN
                         dbo.tb_persona AS P INNER JOIN
                         dbo.ro_empleado AS Em ON P.IdPersona = Em.IdPersona INNER JOIN
                         dbo.ro_empleado_x_ro_tipoNomina AS ExN ON Em.IdEmpleado = ExN.IdEmpleado INNER JOIN
                         Fj_servindustrias.ro_marcaciones_x_empleado_x_incidentes_falt_Perm AS Ma ON ExN.IdEmpresa = Ma.IdEmpresa AND ExN.IdTipoNomina = Ma.IdNomina_Tipo AND ExN.IdEmpleado = Ma.IdEmpleado INNER JOIN
                         dbo.ro_catalogo AS Cat ON Em.em_status = Cat.CodCatalogo INNER JOIN
                         dbo.ro_cargo AS C ON Em.IdEmpresa = C.IdEmpresa AND Em.IdCargo = C.IdCargo AND Em.IdEmpresa = C.IdEmpresa AND Em.IdCargo = C.IdCargo INNER JOIN
                         dbo.ro_turno AS Turn ON Ma.IdEmpresa = Turn.IdEmpresa AND Ma.IdTurno = Turn.IdTurno INNER JOIN
                         dbo.ro_Departamento AS Dep ON Em.IdDepartamento = Dep.IdDepartamento AND Dep.IdEmpresa = Em.IdEmpresa ON dbo.ro_Division.IdDivision = Em.IdDivision AND dbo.ro_Division.IdEmpresa = Em.IdEmpresa INNER JOIN
                         dbo.ro_area ON Em.IdArea = dbo.ro_area.IdArea AND Em.IdEmpresa = dbo.ro_area.IdEmpresa LEFT OUTER JOIN
                         Fj_servindustrias.vwro_planificacion_x_ruta_x_empleado_det_x_rut_x_fuer_x_zon_x_disc_x_pla AS planifica ON ExN.IdEmpresa = planifica.IdEmpresa AND ExN.IdTipoNomina = planifica.IdNomina_Tipo AND 
                         ExN.IdEmpleado = planifica.IdEmpleado
						 WHERE Ma.IdEmpresa=@IdEmpresa
						 AND Ma.IdNomina_Tipo=@IdNomina_tipo
						 AND Ma.es_fecha_registro between @Fecha_Inicio and @Fecha_Fin
						 and  Em.IdEmpresa=@IdEmpresa
						 and ISNULL( IdPeriodo,@Idperiodo)=@Idperiodo
						  
END