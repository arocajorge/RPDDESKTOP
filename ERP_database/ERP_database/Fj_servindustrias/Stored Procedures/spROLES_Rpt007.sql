
CREATE PROCEDURE [Fj_servindustrias].[spROLES_Rpt007]
	@IdEmpresa int,
	@IdNomina_Tipo int,
	@IdNomina_Tipo_Liq int,
	@IdPeriodo int,
	@Fecha_Inicio date,
	@Fecha_Fin date
	
AS
/*

declare
    @IdEmpresa int,
	@IdNomina_Tipo int,
	@IdNomina_Tipo_Liq int,
	@IdPeriodo int,
	@Fecha_Inicio date,
	@Fecha_Fin date

	set @IdEmpresa=2
	set @IdNomina_Tipo =1
	set @IdNomina_Tipo_Liq =2
	set @IdPeriodo=201708
	set @Fecha_Inicio='2017-08-01'
	set @Fecha_Fin='2017-08-31'
	
	*/
BEGIN


	SELECT       
	              Fj_servindustrias.ro_zona.zo_descripcion,
				  Fj_servindustrias.ro_fuerza.fu_descripcion,
	              ro_emp.em_fecha_ingreso, dbo.ro_periodo.pe_FechaIni,
				  dbo.ro_catalogo.ca_descripcion,
				  pers.pe_cedulaRuc, 
                  pers.pe_apellido,
				  pers.pe_nombre, 
				  dbo.ro_cargo.ca_descripcion AS Cargo,
				  suel_hist.SueldoActual,
				  ro_emp.IdCargo,
				  Fj_servindustrias.ro_fuerza.IdFuerza,
				  ro_emp.idempleado,
				
				  ro_planifi_x_ruta.IdNomina_Tipo,
				  Fj_servindustrias.ro_fuerza.IdCentroCosto,
				  Fj_servindustrias.ro_fuerza.IdSuccentroCosto,
				  (select isnull (sum(  R.Valor),0) from ro_rol_detalle as R where R.IdEmpresa=@IdEmpresa and R.IdNominaTipoLiqui=@IdNomina_Tipo_Liq and R.IdEmpleado=ro_emp.IdEmpleado and R.IdPeriodo=@IdPeriodo and IdRubro=2)  as Dias,
				  
				  (select COUNT( M.IdEmpleado) from Fj_servindustrias.ro_marcaciones_x_empleado_x_incidentes_falt_Perm as M where M.IdEmpresa=@IdEmpresa and M.IdEmpleado=ro_emp.IdEmpleado and M.Id_catalogo_Cat='FAL' AND m.es_fecha_registro BETWEEN @Fecha_Inicio AND @Fecha_Fin)  as Falta,
				  
				  (select ISNULL( sum(ISNULL( V.Dias_a_disfrutar,0)),0) from ro_Solicitud_Vacaciones_x_empleado as V where V.IdEmpresa=@IdEmpresa and V.IdEmpleado=ro_emp.IdEmpleado  AND V.Fecha_Desde BETWEEN @Fecha_Inicio AND @Fecha_Fin)  as Vacaciones,
				  
				  (select ISNULL(sum( datediff(day,ISNULL( P.FechaSalida,0),ISNULL( P.FechaEntrada,0))),0) from ro_permiso_x_empleado as P where P.IdEmpresa=@IdEmpresa and P.IdEmpleado=ro_emp.IdEmpleado  AND P.FechaSalida BETWEEN @Fecha_Inicio AND @Fecha_Fin)  as Permiso_IESS,
				 
				  (select SUM(  Valor) from ro_rol_detalle where IdEmpresa=@IdEmpresa and IdEmpleado=ro_emp.IdEmpleado and ro_rol_detalle.IdPeriodo=@IdPeriodo and ro_rol_detalle.IdNominaTipoLiqui= @IdNomina_Tipo_Liq and IdRubro=976)  as Dias_Efectivos,
				  
				  (select SUM(distinct(  Valor)) from ro_rol_detalle where IdEmpresa=@IdEmpresa and IdEmpleado=ro_emp.IdEmpleado and ro_rol_detalle.IdPeriodo=@IdPeriodo and IdRubro=24)  as [SUELDO X DIAS TRABAJADOS],

				   (select SUM(isnull(  Valor,0)) from ro_rol_detalle where IdEmpresa=@IdEmpresa and IdEmpleado=ro_emp.IdEmpleado and ro_rol_detalle.IdPeriodo=@IdPeriodo and IdRubro=7)  as [HORAS  25%],
				  
				   (select SUM(isnull(  Valor,0)) from ro_rol_detalle where IdEmpresa=@IdEmpresa and IdEmpleado=ro_emp.IdEmpleado and ro_rol_detalle.IdPeriodo=@IdPeriodo and IdRubro=8)  as [HORAS 50%],
				  
				   (select SUM(isnull(  Valor,0)) from ro_rol_detalle where IdEmpresa=@IdEmpresa and IdEmpleado=ro_emp.IdEmpleado and ro_rol_detalle.IdPeriodo=@IdPeriodo and IdRubro=9)  as [HORAS 100%],
				  
				   (select SUM(isnull(  Valor,0)) from ro_rol_detalle where IdEmpresa=@IdEmpresa and IdEmpleado=ro_emp.IdEmpleado and ro_rol_detalle.IdPeriodo=@IdPeriodo and IdRubro=68)  as [TRANSPORTE],
				  
				   (select SUM(isnull(  Valor,0)) from ro_rol_detalle where IdEmpresa=@IdEmpresa and IdEmpleado=ro_emp.IdEmpleado and ro_rol_detalle.IdPeriodo=@IdPeriodo and IdRubro=74)  as [ALIMENTACION],
				  
				   (select SUM(isnull(  Valor,0)) from ro_rol_detalle where IdEmpresa=@IdEmpresa and IdEmpleado=ro_emp.IdEmpleado and ro_rol_detalle.IdPeriodo=@IdPeriodo and IdRubro =994)  as [BONIFICACIÓN]
				  
FROM            dbo.ro_empleado_x_ro_tipoNomina INNER JOIN
                         dbo.tb_persona AS pers INNER JOIN
                         dbo.ro_empleado AS ro_emp ON pers.IdPersona = ro_emp.IdPersona INNER JOIN
                         dbo.ro_catalogo ON ro_emp.em_status = dbo.ro_catalogo.CodCatalogo INNER JOIN
                         dbo.ro_cargo ON ro_emp.IdEmpresa = dbo.ro_cargo.IdEmpresa AND ro_emp.IdCargo = dbo.ro_cargo.IdCargo AND ro_emp.IdEmpresa = dbo.ro_cargo.IdEmpresa AND ro_emp.IdCargo = dbo.ro_cargo.IdCargo AND 
                         ro_emp.IdEmpresa = dbo.ro_cargo.IdEmpresa AND ro_emp.IdCargo = dbo.ro_cargo.IdCargo INNER JOIN
                         dbo.vwro_sueldoActual AS suel_hist ON ro_emp.IdEmpresa = suel_hist.IdEmpresa AND ro_emp.IdEmpleado = suel_hist.IdEmpleado ON dbo.ro_empleado_x_ro_tipoNomina.IdEmpresa = ro_emp.IdEmpresa AND 
                         dbo.ro_empleado_x_ro_tipoNomina.IdEmpleado = ro_emp.IdEmpleado AND dbo.ro_empleado_x_ro_tipoNomina.IdEmpresa = ro_emp.IdEmpresa AND dbo.ro_empleado_x_ro_tipoNomina.IdEmpleado = ro_emp.IdEmpleado AND 
                         dbo.ro_empleado_x_ro_tipoNomina.IdEmpresa = ro_emp.IdEmpresa AND dbo.ro_empleado_x_ro_tipoNomina.IdEmpleado = ro_emp.IdEmpleado AND dbo.ro_empleado_x_ro_tipoNomina.IdEmpresa = ro_emp.IdEmpresa AND 
                         dbo.ro_empleado_x_ro_tipoNomina.IdEmpleado = ro_emp.IdEmpleado INNER JOIN
                         dbo.ro_periodo_x_ro_Nomina_TipoLiqui INNER JOIN
                         dbo.ro_periodo ON dbo.ro_periodo_x_ro_Nomina_TipoLiqui.IdEmpresa = dbo.ro_periodo.IdEmpresa AND dbo.ro_periodo_x_ro_Nomina_TipoLiqui.IdPeriodo = dbo.ro_periodo.IdPeriodo INNER JOIN
                         Fj_servindustrias.ro_fuerza INNER JOIN
                         Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det AS ro_planifi_x_ruta ON Fj_servindustrias.ro_fuerza.IdEmpresa = ro_planifi_x_ruta.IdEmpresa AND 
                         Fj_servindustrias.ro_fuerza.IdFuerza = ro_planifi_x_ruta.IdFuerza AND Fj_servindustrias.ro_fuerza.IdEmpresa = ro_planifi_x_ruta.IdEmpresa AND Fj_servindustrias.ro_fuerza.IdFuerza = ro_planifi_x_ruta.IdFuerza AND 
                         Fj_servindustrias.ro_fuerza.IdEmpresa = ro_planifi_x_ruta.IdEmpresa AND Fj_servindustrias.ro_fuerza.IdFuerza = ro_planifi_x_ruta.IdFuerza AND Fj_servindustrias.ro_fuerza.IdEmpresa = ro_planifi_x_ruta.IdEmpresa AND 
                         Fj_servindustrias.ro_fuerza.IdFuerza = ro_planifi_x_ruta.IdFuerza AND Fj_servindustrias.ro_fuerza.IdEmpresa = ro_planifi_x_ruta.IdEmpresa AND Fj_servindustrias.ro_fuerza.IdFuerza = ro_planifi_x_ruta.IdFuerza ON 
                         dbo.ro_periodo_x_ro_Nomina_TipoLiqui.IdEmpresa = ro_planifi_x_ruta.IdEmpresa AND dbo.ro_periodo_x_ro_Nomina_TipoLiqui.IdNomina_Tipo = ro_planifi_x_ruta.IdNomina_Tipo AND 
                         dbo.ro_periodo_x_ro_Nomina_TipoLiqui.IdNomina_TipoLiqui = ro_planifi_x_ruta.IdNomina_Tipo_Liq AND dbo.ro_periodo_x_ro_Nomina_TipoLiqui.IdPeriodo = ro_planifi_x_ruta.IdPeriodo INNER JOIN
                         Fj_servindustrias.ro_zona ON ro_planifi_x_ruta.IdEmpresa = Fj_servindustrias.ro_zona.IdEmpresa AND ro_planifi_x_ruta.IdZona = Fj_servindustrias.ro_zona.IdZona AND 
                         ro_planifi_x_ruta.IdEmpresa = Fj_servindustrias.ro_zona.IdEmpresa AND ro_planifi_x_ruta.IdZona = Fj_servindustrias.ro_zona.IdZona AND ro_planifi_x_ruta.IdEmpresa = Fj_servindustrias.ro_zona.IdEmpresa AND 
                         ro_planifi_x_ruta.IdZona = Fj_servindustrias.ro_zona.IdZona AND ro_planifi_x_ruta.IdEmpresa = Fj_servindustrias.ro_zona.IdEmpresa AND ro_planifi_x_ruta.IdZona = Fj_servindustrias.ro_zona.IdZona ON 
                         ro_emp.IdEmpresa = ro_planifi_x_ruta.IdEmpresa AND ro_emp.IdEmpleado = ro_planifi_x_ruta.IdEmpleado
						where ISNULL( ro_planifi_x_ruta.IdPeriodo, @IdPeriodo)=@IdPeriodo
						and isnull(ro_planifi_x_ruta.IdNomina_Tipo,@IdNomina_Tipo)=@IdNomina_Tipo
						and ISNULL( ro_planifi_x_ruta.IdEmpresa,@IdEmpresa)=@IdEmpresa
					    and dbo.ro_empleado_x_ro_tipoNomina.IdTipoNomina=1
					    and ro_emp.IdEmpresa=@IdEmpresa
					    AND ro_emp.em_status='EST_ACT'
						and ro_emp.IdDivision=2


					   UNION

					   
	SELECT       
	              Fj_servindustrias.ro_zona.zo_descripcion,
				  Fj_servindustrias.ro_fuerza.fu_descripcion,
	              ro_emp.em_fecha_ingreso, dbo.ro_periodo.pe_FechaIni,
				  dbo.ro_catalogo.ca_descripcion,
				  pers.pe_cedulaRuc, 
                  pers.pe_apellido,
				  pers.pe_nombre, 
				  dbo.ro_cargo.ca_descripcion AS Cargo,
				  suel_hist.SueldoActual,
				  ro_emp.IdCargo,
				  Fj_servindustrias.ro_fuerza.IdFuerza,
				  ro_emp.idempleado,
				  ro_planifi_x_ruta.IdNomina_Tipo,
				  Fj_servindustrias.ro_fuerza.IdCentroCosto,
				  Fj_servindustrias.ro_fuerza.IdSuccentroCosto,
				  (select isnull (sum(  R.Valor),0) from ro_rol_detalle as R where R.IdEmpresa=@IdEmpresa and R.IdNominaTipoLiqui=@IdNomina_Tipo_Liq and R.IdEmpleado=ro_emp.IdEmpleado and R.IdPeriodo=@IdPeriodo and IdRubro=2)  as Dias,
				  
				  (select COUNT( M.IdEmpleado) from Fj_servindustrias.ro_marcaciones_x_empleado_x_incidentes_falt_Perm as M where M.IdEmpresa=@IdEmpresa and M.IdEmpleado=ro_emp.IdEmpleado and M.Id_catalogo_Cat='FAL' AND m.es_fecha_registro BETWEEN @Fecha_Inicio AND @Fecha_Fin)  as Falta,
				  
				  (select ISNULL( sum(ISNULL( V.Dias_a_disfrutar,0)),0) from ro_Solicitud_Vacaciones_x_empleado as V where V.IdEmpresa=@IdEmpresa and V.IdEmpleado=ro_emp.IdEmpleado  AND V.Fecha_Desde BETWEEN @Fecha_Inicio AND @Fecha_Fin)  as Vacaciones,
				  
				  (select ISNULL(sum( datediff(day,ISNULL( P.FechaSalida,0),ISNULL( P.FechaEntrada,0))),0) from ro_permiso_x_empleado as P where P.IdEmpresa=@IdEmpresa and P.IdEmpleado=ro_emp.IdEmpleado  AND P.FechaSalida BETWEEN @Fecha_Inicio AND @Fecha_Fin)  as Permiso_IESS,
				 
				  (select SUM(  Valor) from ro_rol_detalle where IdEmpresa=@IdEmpresa and IdEmpleado=ro_emp.IdEmpleado and ro_rol_detalle.IdPeriodo=@IdPeriodo and ro_rol_detalle.IdNominaTipoLiqui=@IdNomina_Tipo_Liq and IdRubro=976)  as Dias_Efectivos,
				  
				  (select SUM(distinct(  Valor)) from ro_rol_detalle where IdEmpresa=@IdEmpresa and IdEmpleado=ro_emp.IdEmpleado and ro_rol_detalle.IdPeriodo=@IdPeriodo and IdRubro=24)  as [SUELDO X DIAS TRABAJADOS],

				   (select SUM(isnull(  Valor,0)) from ro_rol_detalle where IdEmpresa=@IdEmpresa and IdEmpleado=ro_emp.IdEmpleado and ro_rol_detalle.IdPeriodo=@IdPeriodo and IdRubro=7)  as [HORAS  25%],
				  
				   (select SUM(isnull(  Valor,0)) from ro_rol_detalle where IdEmpresa=@IdEmpresa and IdEmpleado=ro_emp.IdEmpleado and ro_rol_detalle.IdPeriodo=@IdPeriodo and IdRubro=8)  as [HORAS 50%],
				  
				   (select SUM(isnull(  Valor,0)) from ro_rol_detalle where IdEmpresa=@IdEmpresa and IdEmpleado=ro_emp.IdEmpleado and ro_rol_detalle.IdPeriodo=@IdPeriodo and IdRubro=9)  as [HORAS 100%],
				  
				   (select SUM(isnull(  Valor,0)) from ro_rol_detalle where IdEmpresa=@IdEmpresa and IdEmpleado=ro_emp.IdEmpleado and ro_rol_detalle.IdPeriodo=@IdPeriodo and IdRubro=68)  as [TRANSPORTE],
				  
				   (select SUM(isnull(  Valor,0)) from ro_rol_detalle where IdEmpresa=@IdEmpresa and IdEmpleado=ro_emp.IdEmpleado and ro_rol_detalle.IdPeriodo=@IdPeriodo and IdRubro=74)  as [ALIMENTACION],
				  
				   (select SUM(isnull(  Valor,0)) from ro_rol_detalle where IdEmpresa=@IdEmpresa and IdEmpleado=ro_emp.IdEmpleado and ro_rol_detalle.IdPeriodo=@IdPeriodo and IdRubro =994)  as [BONIFICACIÓN]
				  
FROM            dbo.ro_empleado_x_ro_tipoNomina INNER JOIN
                         dbo.tb_persona AS pers INNER JOIN
                         dbo.ro_empleado AS ro_emp ON pers.IdPersona = ro_emp.IdPersona INNER JOIN
                         dbo.ro_catalogo ON ro_emp.em_status = dbo.ro_catalogo.CodCatalogo INNER JOIN
                         dbo.ro_cargo ON ro_emp.IdEmpresa = dbo.ro_cargo.IdEmpresa AND ro_emp.IdCargo = dbo.ro_cargo.IdCargo AND ro_emp.IdEmpresa = dbo.ro_cargo.IdEmpresa AND ro_emp.IdCargo = dbo.ro_cargo.IdCargo AND 
                         ro_emp.IdEmpresa = dbo.ro_cargo.IdEmpresa AND ro_emp.IdCargo = dbo.ro_cargo.IdCargo INNER JOIN
                         dbo.vwro_sueldoActual AS suel_hist ON ro_emp.IdEmpresa = suel_hist.IdEmpresa AND ro_emp.IdEmpleado = suel_hist.IdEmpleado ON dbo.ro_empleado_x_ro_tipoNomina.IdEmpresa = ro_emp.IdEmpresa AND 
                         dbo.ro_empleado_x_ro_tipoNomina.IdEmpleado = ro_emp.IdEmpleado AND dbo.ro_empleado_x_ro_tipoNomina.IdEmpresa = ro_emp.IdEmpresa AND dbo.ro_empleado_x_ro_tipoNomina.IdEmpleado = ro_emp.IdEmpleado AND 
                         dbo.ro_empleado_x_ro_tipoNomina.IdEmpresa = ro_emp.IdEmpresa AND dbo.ro_empleado_x_ro_tipoNomina.IdEmpleado = ro_emp.IdEmpleado AND dbo.ro_empleado_x_ro_tipoNomina.IdEmpresa = ro_emp.IdEmpresa AND 
                         dbo.ro_empleado_x_ro_tipoNomina.IdEmpleado = ro_emp.IdEmpleado INNER JOIN
                         dbo.ro_periodo_x_ro_Nomina_TipoLiqui INNER JOIN
                         dbo.ro_periodo ON dbo.ro_periodo_x_ro_Nomina_TipoLiqui.IdEmpresa = dbo.ro_periodo.IdEmpresa AND dbo.ro_periodo_x_ro_Nomina_TipoLiqui.IdPeriodo = dbo.ro_periodo.IdPeriodo INNER JOIN
                         Fj_servindustrias.ro_fuerza INNER JOIN
                         Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det AS ro_planifi_x_ruta ON Fj_servindustrias.ro_fuerza.IdEmpresa = ro_planifi_x_ruta.IdEmpresa AND 
                         Fj_servindustrias.ro_fuerza.IdFuerza = ro_planifi_x_ruta.IdFuerza AND Fj_servindustrias.ro_fuerza.IdEmpresa = ro_planifi_x_ruta.IdEmpresa AND Fj_servindustrias.ro_fuerza.IdFuerza = ro_planifi_x_ruta.IdFuerza AND 
                         Fj_servindustrias.ro_fuerza.IdEmpresa = ro_planifi_x_ruta.IdEmpresa AND Fj_servindustrias.ro_fuerza.IdFuerza = ro_planifi_x_ruta.IdFuerza AND Fj_servindustrias.ro_fuerza.IdEmpresa = ro_planifi_x_ruta.IdEmpresa AND 
                         Fj_servindustrias.ro_fuerza.IdFuerza = ro_planifi_x_ruta.IdFuerza AND Fj_servindustrias.ro_fuerza.IdEmpresa = ro_planifi_x_ruta.IdEmpresa AND Fj_servindustrias.ro_fuerza.IdFuerza = ro_planifi_x_ruta.IdFuerza ON 
                         dbo.ro_periodo_x_ro_Nomina_TipoLiqui.IdEmpresa = ro_planifi_x_ruta.IdEmpresa AND dbo.ro_periodo_x_ro_Nomina_TipoLiqui.IdNomina_Tipo = ro_planifi_x_ruta.IdNomina_Tipo AND 
                         dbo.ro_periodo_x_ro_Nomina_TipoLiqui.IdNomina_TipoLiqui = ro_planifi_x_ruta.IdNomina_Tipo_Liq AND dbo.ro_periodo_x_ro_Nomina_TipoLiqui.IdPeriodo = ro_planifi_x_ruta.IdPeriodo INNER JOIN
                         Fj_servindustrias.ro_zona ON ro_planifi_x_ruta.IdEmpresa = Fj_servindustrias.ro_zona.IdEmpresa AND ro_planifi_x_ruta.IdZona = Fj_servindustrias.ro_zona.IdZona AND 
                         ro_planifi_x_ruta.IdEmpresa = Fj_servindustrias.ro_zona.IdEmpresa AND ro_planifi_x_ruta.IdZona = Fj_servindustrias.ro_zona.IdZona AND ro_planifi_x_ruta.IdEmpresa = Fj_servindustrias.ro_zona.IdEmpresa AND 
                         ro_planifi_x_ruta.IdZona = Fj_servindustrias.ro_zona.IdZona AND ro_planifi_x_ruta.IdEmpresa = Fj_servindustrias.ro_zona.IdEmpresa AND ro_planifi_x_ruta.IdZona = Fj_servindustrias.ro_zona.IdZona ON 
                         ro_emp.IdEmpresa = ro_planifi_x_ruta.IdEmpresa AND ro_emp.IdEmpleado = ro_planifi_x_ruta.IdEmpleado

						where ISNULL( ro_planifi_x_ruta.IdPeriodo, @IdPeriodo)=@IdPeriodo
						and isnull(ro_planifi_x_ruta.IdNomina_Tipo,@IdNomina_Tipo)=@IdNomina_Tipo
						and ISNULL( ro_planifi_x_ruta.IdEmpresa,@IdEmpresa)=@IdEmpresa
					    and dbo.ro_empleado_x_ro_tipoNomina.IdTipoNomina=1
					    and ro_emp.IdEmpresa=@IdEmpresa
					    and cast( isnull(ro_emp.em_fechaSalida,@Fecha_Inicio) as date) between @Fecha_Inicio and @Fecha_Fin
					    and ro_emp.IdDivision=2

		union			  
					 
	--************************************************************************************************************************************************************************
    --*******************************************************************************Administrativos*******************************************************************************
	SELECT       
	              '' zo_descripcion,
				  Fj_servindustrias.ro_fuerza.fu_descripcion,
	              ro_emp.em_fecha_ingreso, 
				   Fj_servindustrias.ro_empleado_x_parametro_x_pago_variable.Fecha_Transaccion pe_FechaIni,
				  dbo.ro_catalogo.ca_descripcion,
				  pers.pe_cedulaRuc, 
                  pers.pe_apellido,
				  pers.pe_nombre, 
				  dbo.ro_cargo.ca_descripcion AS Cargo,
				  suel_hist.SueldoActual,
				  ro_emp.IdCargo,
				  Fj_servindustrias.ro_fuerza.IdFuerza,
				  ro_emp.idempleado,
				
				   Fj_servindustrias.ro_empleado_x_parametro_x_pago_variable.IdNomina_Tipo,
				  Fj_servindustrias.ro_fuerza.IdCentroCosto,
				  Fj_servindustrias.ro_fuerza.IdSuccentroCosto,
				  (select isnull (sum(  R.Valor),0) from ro_rol_detalle as R where R.IdEmpresa=@IdEmpresa and R.IdNominaTipoLiqui=@IdNomina_Tipo_Liq and R.IdEmpleado=ro_emp.IdEmpleado and R.IdPeriodo=@IdPeriodo and IdRubro=2)  as Dias,
				  
				  (select COUNT( M.IdEmpleado) from Fj_servindustrias.ro_marcaciones_x_empleado_x_incidentes_falt_Perm as M where M.IdEmpresa=@IdEmpresa and M.IdEmpleado=ro_emp.IdEmpleado and M.Id_catalogo_Cat='FAL' AND m.es_fecha_registro BETWEEN @Fecha_Inicio AND @Fecha_Fin)  as Falta,
				  
				  (select ISNULL( sum(ISNULL( V.Dias_a_disfrutar,0)),0) from ro_Solicitud_Vacaciones_x_empleado as V where V.IdEmpresa=@IdEmpresa and V.IdEmpleado=ro_emp.IdEmpleado  AND V.Fecha_Desde BETWEEN @Fecha_Inicio AND @Fecha_Fin)  as Vacaciones,
				  
				  (select ISNULL(sum( datediff(day,ISNULL( P.FechaSalida,0),ISNULL( P.FechaEntrada,0))),0) from ro_permiso_x_empleado as P where P.IdEmpresa=@IdEmpresa and P.IdEmpleado=ro_emp.IdEmpleado  AND P.FechaSalida BETWEEN @Fecha_Inicio AND @Fecha_Fin)  as Permiso_IESS,
				 
				  (select SUM(  Valor) from ro_rol_detalle where IdEmpresa=@IdEmpresa and IdEmpleado=ro_emp.IdEmpleado and ro_rol_detalle.IdPeriodo=@IdPeriodo and ro_rol_detalle.IdNominaTipoLiqui= @IdNomina_Tipo_Liq and IdRubro=976)  as Dias_Efectivos,
				  
				  (select SUM(distinct(  Valor)) from ro_rol_detalle where IdEmpresa=@IdEmpresa and IdEmpleado=ro_emp.IdEmpleado and ro_rol_detalle.IdPeriodo=@IdPeriodo and IdRubro=24)  as [SUELDO X DIAS TRABAJADOS],

				   (select SUM(isnull(  Valor,0)) from ro_rol_detalle where IdEmpresa=@IdEmpresa and IdEmpleado=ro_emp.IdEmpleado and ro_rol_detalle.IdPeriodo=@IdPeriodo and IdRubro=7)  as [HORAS  25%],
				  
				   (select SUM(isnull(  Valor,0)) from ro_rol_detalle where IdEmpresa=@IdEmpresa and IdEmpleado=ro_emp.IdEmpleado and ro_rol_detalle.IdPeriodo=@IdPeriodo and IdRubro=8)  as [HORAS 50%],
				  
				   (select SUM(isnull(  Valor,0)) from ro_rol_detalle where IdEmpresa=@IdEmpresa and IdEmpleado=ro_emp.IdEmpleado and ro_rol_detalle.IdPeriodo=@IdPeriodo and IdRubro=9)  as [HORAS 100%],
				  
				   (select SUM(isnull(  Valor,0)) from ro_rol_detalle where IdEmpresa=@IdEmpresa and IdEmpleado=ro_emp.IdEmpleado and ro_rol_detalle.IdPeriodo=@IdPeriodo and IdRubro=68)  as [TRANSPORTE],
				  
				   (select SUM(isnull(  Valor,0)) from ro_rol_detalle where IdEmpresa=@IdEmpresa and IdEmpleado=ro_emp.IdEmpleado and ro_rol_detalle.IdPeriodo=@IdPeriodo and IdRubro=74)  as [ALIMENTACION],
				  
				   (select SUM(isnull(  Valor,0)) from ro_rol_detalle where IdEmpresa=@IdEmpresa and IdEmpleado=ro_emp.IdEmpleado and ro_rol_detalle.IdPeriodo=@IdPeriodo and IdRubro =994)  as [BONIFICACIÓN]
	  
				   
						
						FROM            dbo.ro_empleado_x_ro_tipoNomina INNER JOIN
                         dbo.tb_persona AS pers INNER JOIN
                         dbo.ro_empleado AS ro_emp ON pers.IdPersona = ro_emp.IdPersona INNER JOIN
                         dbo.ro_catalogo ON ro_emp.em_status = dbo.ro_catalogo.CodCatalogo INNER JOIN
                         dbo.ro_cargo ON ro_emp.IdEmpresa = dbo.ro_cargo.IdEmpresa AND ro_emp.IdCargo = dbo.ro_cargo.IdCargo AND ro_emp.IdEmpresa = dbo.ro_cargo.IdEmpresa AND ro_emp.IdCargo = dbo.ro_cargo.IdCargo AND 
                         ro_emp.IdEmpresa = dbo.ro_cargo.IdEmpresa AND ro_emp.IdCargo = dbo.ro_cargo.IdCargo INNER JOIN
                         dbo.vwro_sueldoActual AS suel_hist ON ro_emp.IdEmpresa = suel_hist.IdEmpresa AND ro_emp.IdEmpleado = suel_hist.IdEmpleado ON dbo.ro_empleado_x_ro_tipoNomina.IdEmpresa = ro_emp.IdEmpresa AND 
                         dbo.ro_empleado_x_ro_tipoNomina.IdEmpleado = ro_emp.IdEmpleado AND dbo.ro_empleado_x_ro_tipoNomina.IdEmpresa = ro_emp.IdEmpresa AND dbo.ro_empleado_x_ro_tipoNomina.IdEmpleado = ro_emp.IdEmpleado AND 
                         dbo.ro_empleado_x_ro_tipoNomina.IdEmpresa = ro_emp.IdEmpresa AND dbo.ro_empleado_x_ro_tipoNomina.IdEmpleado = ro_emp.IdEmpleado AND dbo.ro_empleado_x_ro_tipoNomina.IdEmpresa = ro_emp.IdEmpresa AND 
                         dbo.ro_empleado_x_ro_tipoNomina.IdEmpleado = ro_emp.IdEmpleado INNER JOIN
                         Fj_servindustrias.ro_empleado_x_parametro_x_pago_variable ON ro_emp.IdEmpresa = Fj_servindustrias.ro_empleado_x_parametro_x_pago_variable.IdEmpresa AND 
                         ro_emp.IdEmpleado = Fj_servindustrias.ro_empleado_x_parametro_x_pago_variable.IdEmpleado AND ro_emp.IdEmpresa = Fj_servindustrias.ro_empleado_x_parametro_x_pago_variable.IdEmpresa AND 
                         ro_emp.IdEmpleado = Fj_servindustrias.ro_empleado_x_parametro_x_pago_variable.IdEmpleado INNER JOIN
                         Fj_servindustrias.ro_fuerza ON Fj_servindustrias.ro_empleado_x_parametro_x_pago_variable.IdEmpresa = Fj_servindustrias.ro_fuerza.IdEmpresa AND 
                         Fj_servindustrias.ro_empleado_x_parametro_x_pago_variable.IdFuerza = Fj_servindustrias.ro_fuerza.IdFuerza AND 
                         Fj_servindustrias.ro_empleado_x_parametro_x_pago_variable.IdEmpresa = Fj_servindustrias.ro_fuerza.IdEmpresa AND 
                         Fj_servindustrias.ro_empleado_x_parametro_x_pago_variable.IdFuerza = Fj_servindustrias.ro_fuerza.IdFuerza AND 
                         Fj_servindustrias.ro_empleado_x_parametro_x_pago_variable.IdEmpresa = Fj_servindustrias.ro_fuerza.IdEmpresa AND 
                         Fj_servindustrias.ro_empleado_x_parametro_x_pago_variable.IdFuerza = Fj_servindustrias.ro_fuerza.IdFuerza AND 
                         Fj_servindustrias.ro_empleado_x_parametro_x_pago_variable.IdEmpresa = Fj_servindustrias.ro_fuerza.IdEmpresa AND 
                         Fj_servindustrias.ro_empleado_x_parametro_x_pago_variable.IdFuerza = Fj_servindustrias.ro_fuerza.IdFuerza AND 
                         Fj_servindustrias.ro_empleado_x_parametro_x_pago_variable.IdEmpresa = Fj_servindustrias.ro_fuerza.IdEmpresa AND 
                         Fj_servindustrias.ro_empleado_x_parametro_x_pago_variable.IdFuerza = Fj_servindustrias.ro_fuerza.IdFuerza AND 
                         Fj_servindustrias.ro_empleado_x_parametro_x_pago_variable.IdEmpresa = Fj_servindustrias.ro_fuerza.IdEmpresa AND 
                         Fj_servindustrias.ro_empleado_x_parametro_x_pago_variable.IdFuerza = Fj_servindustrias.ro_fuerza.IdFuerza
						 

						where 
					     dbo.ro_empleado_x_ro_tipoNomina.IdTipoNomina=1
					    and ro_emp.IdEmpresa=@IdEmpresa
					    and cast( isnull(ro_emp.em_fechaSalida,@Fecha_Inicio) as date) between @Fecha_Inicio and @Fecha_Fin
					    and ro_emp.IdDivision=1
						

--************************************************************************************************************************************************************************
--*******************************************************************************EVENTUALES*******************************************************************************



union


	SELECT       
	               'Eventuales' zo_descripcion,
				   Fj_servindustrias.ro_fuerza.fu_descripcion,
	              ro_emp.em_fecha_ingreso,
				  @Fecha_Inicio pe_FechaIni,
				  dbo.ro_catalogo.ca_descripcion,
				  pers.pe_cedulaRuc, 
                  pers.pe_apellido,
				  pers.pe_nombre, 
				  dbo.ro_cargo.ca_descripcion AS Cargo,
				  Sueldo,
				  ro_empleado_x_cargo_fuerza_grupo.IdCargo,
				  Fj_servindustrias.ro_empleado_x_cargo_fuerza_grupo.IdFuerza,
				  ro_emp.idempleado,
				  Fj_servindustrias.ro_empleado_x_cargo_fuerza_grupo.IdNomina,
				  Fj_servindustrias.ro_fuerza.IdCentroCosto,
				  Fj_servindustrias.ro_fuerza.IdSuccentroCosto,
				  (select isnull (sum(  R.Valor),0) from ro_rol_detalle as R where R.IdEmpresa=@IdEmpresa and IdNominaTipo=2 and R.IdNominaTipoLiqui=5 and R.IdEmpleado=ro_emp.IdEmpleado and R.IdPeriodo=@IdPeriodo and IdRubro=2)  as Dias,
				  
				 0 as Falta,
				  
				 0  as Vacaciones,
				  
				 0  as Permiso_IESS,
				 
				  (select SUM(  Valor) from ro_rol_detalle where IdEmpresa=@IdEmpresa and IdEmpleado=ro_emp.IdEmpleado and ro_rol_detalle.IdPeriodo=@IdPeriodo and IdRubro=976)  as Dias_Efectivos,
				  
				  (select SUM(distinct(  Valor)) from ro_rol_detalle where IdEmpresa=@IdEmpresa and IdNominaTipo=2 and IdNominaTipoLiqui=5 and IdEmpleado=ro_emp.IdEmpleado and ro_rol_detalle.IdPeriodo=@IdPeriodo and IdRubro=24)  as [SUELDO X DIAS TRABAJADOS],

				  0  as [HORAS  25%],
				  
				   0  as [HORAS 50%],
				  
				   (select SUM(distinct(  Valor)) from ro_rol_detalle where IdEmpresa=@IdEmpresa and IdNominaTipo=2 and IdNominaTipoLiqui=5 and IdEmpleado=ro_emp.IdEmpleado and ro_rol_detalle.IdPeriodo=@IdPeriodo and IdRubro=966)  as [HORAS 100%],
				  
				   (select SUM(isnull(  Valor,0)) from ro_rol_detalle where IdEmpresa=@IdEmpresa and IdNominaTipo=2 and IdEmpleado=ro_emp.IdEmpleado and ro_rol_detalle.IdPeriodo=@IdPeriodo and IdRubro=68)  as [TRANSPORTE],
				  
				   (select SUM(isnull(  Valor,0)) from ro_rol_detalle where IdEmpresa=@IdEmpresa and IdNominaTipo=2 and IdEmpleado=ro_emp.IdEmpleado and ro_rol_detalle.IdPeriodo=@IdPeriodo and IdRubro=74)  as [ALIMENTACION],
				  
				   (select SUM(isnull(  Valor,0)) from ro_rol_detalle where IdEmpresa=@IdEmpresa and IdNominaTipo=2 and IdEmpleado=ro_emp.IdEmpleado and ro_rol_detalle.IdPeriodo=@IdPeriodo and IdRubro =994)  as [BONIFICACIÓN]
				
           

FROM            Fj_servindustrias.ro_empleado_x_cargo_fuerza_grupo INNER JOIN
                         Fj_servindustrias.ro_Grupo_empleado ON Fj_servindustrias.ro_empleado_x_cargo_fuerza_grupo.IdEmpresa = Fj_servindustrias.ro_Grupo_empleado.IdEmpresa AND 
                         Fj_servindustrias.ro_empleado_x_cargo_fuerza_grupo.IdGrupo = Fj_servindustrias.ro_Grupo_empleado.IdGrupo AND 
                         Fj_servindustrias.ro_empleado_x_cargo_fuerza_grupo.IdEmpresa = Fj_servindustrias.ro_Grupo_empleado.IdEmpresa AND 
                         Fj_servindustrias.ro_empleado_x_cargo_fuerza_grupo.IdGrupo = Fj_servindustrias.ro_Grupo_empleado.IdGrupo INNER JOIN
                         Fj_servindustrias.ro_fuerza ON Fj_servindustrias.ro_empleado_x_cargo_fuerza_grupo.IdEmpresa = Fj_servindustrias.ro_fuerza.IdEmpresa AND 
                         Fj_servindustrias.ro_empleado_x_cargo_fuerza_grupo.IdFuerza = Fj_servindustrias.ro_fuerza.IdFuerza AND Fj_servindustrias.ro_empleado_x_cargo_fuerza_grupo.IdEmpresa = Fj_servindustrias.ro_fuerza.IdEmpresa AND 
                         Fj_servindustrias.ro_empleado_x_cargo_fuerza_grupo.IdFuerza = Fj_servindustrias.ro_fuerza.IdFuerza AND Fj_servindustrias.ro_empleado_x_cargo_fuerza_grupo.IdEmpresa = Fj_servindustrias.ro_fuerza.IdEmpresa AND 
                         Fj_servindustrias.ro_empleado_x_cargo_fuerza_grupo.IdFuerza = Fj_servindustrias.ro_fuerza.IdFuerza INNER JOIN
                         dbo.tb_persona AS pers INNER JOIN
                         dbo.ro_empleado AS ro_emp ON pers.IdPersona = ro_emp.IdPersona INNER JOIN
                         dbo.ro_catalogo ON ro_emp.em_status = dbo.ro_catalogo.CodCatalogo INNER JOIN
                         dbo.ro_cargo ON ro_emp.IdEmpresa = dbo.ro_cargo.IdEmpresa AND ro_emp.IdCargo = dbo.ro_cargo.IdCargo AND ro_emp.IdEmpresa = dbo.ro_cargo.IdEmpresa AND ro_emp.IdCargo = dbo.ro_cargo.IdCargo AND 
                         ro_emp.IdEmpresa = dbo.ro_cargo.IdEmpresa AND ro_emp.IdCargo = dbo.ro_cargo.IdCargo INNER JOIN
                         dbo.ro_rol_detalle AS ro_rol_detalle ON ro_emp.IdEmpresa = ro_rol_detalle.IdEmpresa AND ro_emp.IdEmpleado = ro_rol_detalle.IdEmpleado AND ro_emp.IdEmpresa = ro_rol_detalle.IdEmpresa AND 
                         ro_emp.IdEmpleado = ro_rol_detalle.IdEmpleado AND ro_emp.IdEmpresa = ro_rol_detalle.IdEmpresa AND ro_emp.IdEmpleado = ro_rol_detalle.IdEmpleado AND ro_emp.IdEmpresa = ro_rol_detalle.IdEmpresa AND 
                         ro_emp.IdEmpleado = ro_rol_detalle.IdEmpleado ON Fj_servindustrias.ro_empleado_x_cargo_fuerza_grupo.IdEmpresa = ro_emp.IdEmpresa AND 
                         Fj_servindustrias.ro_empleado_x_cargo_fuerza_grupo.IdEmpleado = ro_emp.IdEmpleado LEFT OUTER JOIN
                         dbo.ro_empleado_x_centro_costo ON ro_emp.IdEmpresa = dbo.ro_empleado_x_centro_costo.IdEmpresa AND ro_emp.IdEmpleado = dbo.ro_empleado_x_centro_costo.IdEmpleado AND 
                         ro_emp.IdEmpresa = dbo.ro_empleado_x_centro_costo.IdEmpresa AND ro_emp.IdEmpleado = dbo.ro_empleado_x_centro_costo.IdEmpleado AND ro_emp.IdEmpresa = dbo.ro_empleado_x_centro_costo.IdEmpresa AND 
                         ro_emp.IdEmpleado = dbo.ro_empleado_x_centro_costo.IdEmpleado AND ro_emp.IdEmpresa = dbo.ro_empleado_x_centro_costo.IdEmpresa AND ro_emp.IdEmpleado = dbo.ro_empleado_x_centro_costo.IdEmpleado AND 
                         ro_emp.IdEmpresa = dbo.ro_empleado_x_centro_costo.IdEmpresa AND ro_emp.IdEmpleado = dbo.ro_empleado_x_centro_costo.IdEmpleado AND ro_emp.IdEmpresa = dbo.ro_empleado_x_centro_costo.IdEmpresa AND 
                         ro_emp.IdEmpleado = dbo.ro_empleado_x_centro_costo.IdEmpleado


						 where
						 ro_rol_detalle.IdEmpresa=@IdEmpresa
						 and ro_rol_detalle.IdPeriodo=@IdPeriodo
						 and ro_rol_detalle.IdNominaTipo=2
						 and ro_rol_detalle.IdRubro=950
						 and IdNominaTipoLiqui=5
						 and ro_rol_detalle.Valor>0
						 and  Fj_servindustrias.ro_empleado_x_cargo_fuerza_grupo.IdPeriodo=@IdPeriodo
--************************************************************************************************************************************************************************
--*******************************************************************************GASTOS FIJO*******************************************************************************
union
	SELECT       
	               '' zo_descripcion,
				   Fj_servindustrias.ro_fuerza.fu_descripcion,
	              ''em_fecha_ingreso,
				  @Fecha_Inicio pe_FechaIni,
				 '' ca_descripcion,
				  ro_fuerza.cedula_gasto, 
                   ro_fuerza.descripcion_gasto,
				  ''pe_nombre, 
				  '' Cargo,
				  0 Sueldo,
				  0 IdCargo,
				  IdFuerza,
				  0 idempleado,
				  1 IdNomina,
				  IdCentroCosto IdCentroCosto,
				  IdSuccentroCosto IdSuccentroCosto,
				  0 Dias,
				  
				 0 as Falta,
				  
				 0  as Vacaciones,
				  
				 0  as Permiso_IESS,
				 
				 0 Dias_Efectivos,
				  
				  valor_gasto  as [SUELDO X DIAS TRABAJADOS],

				  0  as [HORAS  25%],
				  
				  0  as [HORAS 50%],
				  
				  0 [HORAS 100%],
				  
				   0[TRANSPORTE],
				  
				   0[ALIMENTACION],
				  
				   0[BONIFICACIÓN]
				
           FROM Fj_servindustrias.ro_fuerza
		   where IdEmpresa=@IdEmpresa

end