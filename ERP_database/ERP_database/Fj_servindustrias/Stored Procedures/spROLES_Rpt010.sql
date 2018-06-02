

CREATE procedure [Fj_servindustrias].[spROLES_Rpt010]
    @IdEmpresa int,
	@IdNomina_tipo int,
	@IdNomina_tipo_Liqui int,
	@IdPeriodo int,
	@Fecha_Inicio date,
	@Fecha_Fin date
	as
	/*
	
	declare 
	 @IdEmpresa int,
	@IdNomina_tipo int,
	@IdNomina_tipo_Liqui int,
	@IdPeriodo int,
	@Fecha_Inicio date,
	@Fecha_Fin date

	set @IdEmpresa =2
	set @IdNomina_tipo =2
	set @IdNomina_tipo_Liqui =5
	set @IdPeriodo =201706
	set @Fecha_Inicio= '01/06/2017'
	set @Fecha_Fin= '30/06/2017'
	*/
	

SELECT        emp.IdEmpresa, emp.IdEmpleado, person.pe_cedulaRuc, person.pe_apellido + ' ' + person.pe_nombre AS Empleado, cargo.ca_descripcion, grupo.Sueldo as SueldoActual, grupo.Valor_bono, marcacin.es_fecha_registro, 
                         dbo.vwro_empleado_x_nomina_x_periodo.IdNominaTipo, dbo.vwro_empleado_x_nomina_x_periodo.IdNominaTipoLiqui, dbo.vwro_empleado_x_nomina_x_periodo.IdPeriodo,
						 (select valor from ro_rol_detalle R where R.IdEmpresa=emp.idempresa 
						 and R.IdNominaTipo=dbo.vwro_empleado_x_nomina_x_periodo.IdNominaTipo
						 and R.IdNominaTipoLiqui=dbo.vwro_empleado_x_nomina_x_periodo.IdNominaTipoLiqui
						 and R.IdPeriodo=dbo.vwro_empleado_x_nomina_x_periodo.IdPeriodo
						 and R.IdEmpleado=emp.idempleado
						 and R.idrubro=24
						 )sueldo_x_dias_trabajados,

						  (select valor from ro_rol_detalle R where R.IdEmpresa=emp.idempresa 
						 and R.IdNominaTipo=dbo.vwro_empleado_x_nomina_x_periodo.IdNominaTipo
						 and R.IdNominaTipoLiqui=dbo.vwro_empleado_x_nomina_x_periodo.IdNominaTipoLiqui
						 and R.IdPeriodo=dbo.vwro_empleado_x_nomina_x_periodo.IdPeriodo
						 and R.IdEmpleado=emp.idempleado
						 and R.idrubro=74
						 )alimentacio,

						  (select valor from ro_rol_detalle R where R.IdEmpresa=emp.idempresa 
						 and R.IdNominaTipo=dbo.vwro_empleado_x_nomina_x_periodo.IdNominaTipo
						 and R.IdNominaTipoLiqui=dbo.vwro_empleado_x_nomina_x_periodo.IdNominaTipoLiqui
						 and R.IdPeriodo=dbo.vwro_empleado_x_nomina_x_periodo.IdPeriodo
						 and R.IdEmpleado=emp.idempleado
						 and R.idrubro=68
						 )transporte,

						 
						  (select valor from ro_rol_detalle R where R.IdEmpresa=emp.idempresa 
						 and R.IdNominaTipo=dbo.vwro_empleado_x_nomina_x_periodo.IdNominaTipo
						 and R.IdNominaTipoLiqui=dbo.vwro_empleado_x_nomina_x_periodo.IdNominaTipoLiqui
						 and R.IdPeriodo=dbo.vwro_empleado_x_nomina_x_periodo.IdPeriodo
						 and R.IdEmpleado=emp.idempleado
						 and R.idrubro=966
						 )HorasExtras,

						   (select valor from ro_rol_detalle R where R.IdEmpresa=emp.idempresa 
						 and R.IdNominaTipo=dbo.vwro_empleado_x_nomina_x_periodo.IdNominaTipo
						 and R.IdNominaTipoLiqui=dbo.vwro_empleado_x_nomina_x_periodo.IdNominaTipoLiqui
						 and R.IdPeriodo=dbo.vwro_empleado_x_nomina_x_periodo.IdPeriodo
						 and R.IdEmpleado=emp.idempleado
						 and R.idrubro=994
						 )variable,

						 
						   (select valor from ro_rol_detalle R where R.IdEmpresa=emp.idempresa 
						 and R.IdNominaTipo=dbo.vwro_empleado_x_nomina_x_periodo.IdNominaTipo
						 and R.IdNominaTipoLiqui=dbo.vwro_empleado_x_nomina_x_periodo.IdNominaTipoLiqui
						 and R.IdPeriodo=dbo.vwro_empleado_x_nomina_x_periodo.IdPeriodo
						 and R.IdEmpleado=emp.idempleado
						 and R.idrubro=6
						 )Iess,
						(select valor from ro_rol_detalle R where R.IdEmpresa=emp.idempresa 
						 and R.IdNominaTipo=dbo.vwro_empleado_x_nomina_x_periodo.IdNominaTipo
						 and R.IdNominaTipoLiqui=dbo.vwro_empleado_x_nomina_x_periodo.IdNominaTipoLiqui
						 and R.IdPeriodo=dbo.vwro_empleado_x_nomina_x_periodo.IdPeriodo
						 and R.IdEmpleado=emp.idempleado
						 and R.idrubro=2
						 )dias_trabajados,

						case when marcacin.Id_catalogo_Cat='ASIST' THEN 'X'
						 WHEN marcacin.Id_catalogo_Cat ='ATRA' THEN 'A'
						 WHEN marcacin.Id_catalogo_Cat ='VACA' THEN 'V'
						 WHEN marcacin.Id_catalogo_Cat ='PER' THEN 'P'
						 WHEN marcacin.Id_catalogo_Cat ='FAL' THEN 'F'
						
						 ELSE 'N' END aS TipoAsistencia,
						(select MIN(M.es_fecha_registro) from  Fj_servindustrias.ro_marcaciones_x_empleado_x_incidentes_falt_Perm M 
						where
						 M.IdEmpresa=emp.idempresa 						 
						 and M.IdEmpleado=emp.idempleado
						 and M.es_fecha_registro between @Fecha_Inicio and @Fecha_Fin
						 and M.IdNomina_Tipo=@IdNomina_tipo
						 group by M.IdEmpresa,M.idempleado
						 ) FechaInicio,

						 (select valor from ro_rol_detalle R where R.IdEmpresa=emp.idempresa 
						 and R.IdNominaTipo=dbo.vwro_empleado_x_nomina_x_periodo.IdNominaTipo
						 and R.IdNominaTipoLiqui=dbo.vwro_empleado_x_nomina_x_periodo.IdNominaTipoLiqui
						 and R.IdPeriodo=dbo.vwro_empleado_x_nomina_x_periodo.IdPeriodo
						 and R.IdEmpleado=emp.idempleado
						 and R.idrubro=950
						 )TotalPagar,

						 ro_fuerza.fu_descripcion




FROM            dbo.ro_empleado AS emp INNER JOIN
                         dbo.tb_persona AS person ON emp.IdPersona = person.IdPersona INNER JOIN
                         dbo.ro_empleado_historial_Sueldo AS Sueldo ON emp.IdEmpresa = Sueldo.IdEmpresa AND emp.IdEmpleado = Sueldo.IdEmpleado INNER JOIN
                         Fj_servindustrias.ro_marcaciones_x_empleado_x_incidentes_falt_Perm AS marcacin ON emp.IdEmpresa = marcacin.IdEmpresa AND emp.IdEmpleado = marcacin.IdEmpleado INNER JOIN
                         dbo.vwro_empleado_x_nomina_x_periodo ON emp.IdEmpresa = dbo.vwro_empleado_x_nomina_x_periodo.IdEmpresa AND emp.IdEmpleado = dbo.vwro_empleado_x_nomina_x_periodo.IdEmpleado INNER JOIN
                         Fj_servindustrias.ro_empleado_x_cargo_fuerza_grupo ON emp.IdEmpresa = Fj_servindustrias.ro_empleado_x_cargo_fuerza_grupo.IdEmpresa AND 
                         emp.IdEmpleado = Fj_servindustrias.ro_empleado_x_cargo_fuerza_grupo.IdEmpleado INNER JOIN
                         dbo.ro_cargo AS cargo ON Fj_servindustrias.ro_empleado_x_cargo_fuerza_grupo.IdEmpresa = cargo.IdEmpresa AND Fj_servindustrias.ro_empleado_x_cargo_fuerza_grupo.IdCargo = cargo.IdCargo AND 
                         Fj_servindustrias.ro_empleado_x_cargo_fuerza_grupo.IdEmpresa = cargo.IdEmpresa AND Fj_servindustrias.ro_empleado_x_cargo_fuerza_grupo.IdCargo = cargo.IdCargo INNER JOIN
                         Fj_servindustrias.ro_Grupo_empleado AS grupo ON Fj_servindustrias.ro_empleado_x_cargo_fuerza_grupo.IdEmpresa = grupo.IdEmpresa AND 
                         Fj_servindustrias.ro_empleado_x_cargo_fuerza_grupo.IdGrupo = grupo.IdGrupo AND Fj_servindustrias.ro_empleado_x_cargo_fuerza_grupo.IdEmpresa = grupo.IdEmpresa AND 
                         Fj_servindustrias.ro_empleado_x_cargo_fuerza_grupo.IdGrupo = grupo.IdGrupo AND Fj_servindustrias.ro_empleado_x_cargo_fuerza_grupo.IdEmpresa = grupo.IdEmpresa AND 
                         Fj_servindustrias.ro_empleado_x_cargo_fuerza_grupo.IdGrupo = grupo.IdGrupo INNER JOIN
                         Fj_servindustrias.ro_fuerza ON Fj_servindustrias.ro_empleado_x_cargo_fuerza_grupo.IdEmpresa = Fj_servindustrias.ro_fuerza.IdEmpresa AND 
                         Fj_servindustrias.ro_empleado_x_cargo_fuerza_grupo.IdFuerza = Fj_servindustrias.ro_fuerza.IdFuerza AND Fj_servindustrias.ro_empleado_x_cargo_fuerza_grupo.IdEmpresa = Fj_servindustrias.ro_fuerza.IdEmpresa AND 
                         Fj_servindustrias.ro_empleado_x_cargo_fuerza_grupo.IdFuerza = Fj_servindustrias.ro_fuerza.IdFuerza AND Fj_servindustrias.ro_empleado_x_cargo_fuerza_grupo.IdEmpresa = Fj_servindustrias.ro_fuerza.IdEmpresa AND 
                         Fj_servindustrias.ro_empleado_x_cargo_fuerza_grupo.IdFuerza = Fj_servindustrias.ro_fuerza.IdFuerza
WHERE        (dbo.vwro_empleado_x_nomina_x_periodo.IdEmpresa = @idempresa) AND (dbo.vwro_empleado_x_nomina_x_periodo.IdNominaTipo = @IdNomina_tipo) AND 
                         (dbo.vwro_empleado_x_nomina_x_periodo.IdNominaTipoLiqui = @IdNomina_tipo_Liqui) AND (dbo.vwro_empleado_x_nomina_x_periodo.IdPeriodo = @idperiodo) AND (marcacin.es_fecha_registro BETWEEN @Fecha_Inicio AND
                          @Fecha_Fin)
						  and Fj_servindustrias.ro_empleado_x_cargo_fuerza_grupo.IdPeriodo=@IdPeriodo