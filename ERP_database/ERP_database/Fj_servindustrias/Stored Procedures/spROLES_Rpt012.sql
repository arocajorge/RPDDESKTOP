--exec [Fj_servindustrias].[spROLES_Rpt012] 1,1,2017,9,201709

CREATE PROCEDURE [Fj_servindustrias].[spROLES_Rpt012]  
	@IdEmpresa int,
	@IdNomina_tipo int,
	@Anio int,
	@Mes int,
	@IdPeriodo int
	

AS
/*

declare
    @IdEmpresa int,
	@IdNomina_tipo int,
	@Anio int,
	@Mes int,
	@idempleado int,
    @idperiodo int
	set @IdEmpresa=2
	set @IdNomina_tipo=1
	set @Anio ='2017'
	set @Mes ='10'
	set @idempleado=37
	set @idperiodo=201709
	*/
	
	declare 
	@FechaI date,
	@FechaF date

	select @FechaI=pe_FechaIni, @FechaF=pe_FechaFin from ro_periodo where IdEmpresa=@IdEmpresa

	select * from(
SELECT        dbo.ro_rol_detalle.IdEmpresa, dbo.ro_rol_detalle.IdNominaTipo, dbo.ro_rol_detalle.IdNominaTipoLiqui, dbo.ro_rol_detalle.IdPeriodo, perio.pe_anio, perio.pe_mes, person.pe_cedulaRuc, 
                         Fj_servindustrias.ro_zona.zo_descripcion, Fj_servindustrias.ro_fuerza.fu_descripcion, Fj_servindustrias.ro_disco.Disco, Fj_servindustrias.ro_placa.Placa, Fj_servindustrias.ro_ruta.ru_descripcion, emp.em_fechaIngaRol, 
                         perio.pe_FechaIni, ISNULL(dbo.ro_catalogo.ca_descripcion, emp.em_fechaSalida) AS em_fechaSalida, person.pe_cedulaRuc AS Cedula, person.pe_apellido + ' ' + person.pe_nombre AS Nombres, cargo.ca_descripcion, 
                         ro_catalogo_1.ca_orden, ro_catalogo_1.ca_estado, ro_catalogo_1.ca_descripcion AS Catalogo, param_repo.Descripcion, dbo.ro_rol_detalle.Valor, param_repo.Orden,
						 (select  sum(Dias_a_disfrutar) from vwRo_Solicitud_Vacaciones vac where 
						 vac.IdEmpresa=@IdEmpresa
						 and vac.IdEmpleado=emp.IdEmpleado
						 and vac.Fecha_Desde between @FechaI and @FechaF
						 and vac.Fecha_Hasta  between @FechaI and @FechaF
						 ) Dias_vacaciones
FROM            dbo.ro_periodo AS perio INNER JOIN
                         Fj_servindustrias.ro_zona INNER JOIN
                         Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det ON Fj_servindustrias.ro_zona.IdEmpresa = Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdEmpresa AND 
                         Fj_servindustrias.ro_zona.IdZona = Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdZona AND Fj_servindustrias.ro_zona.IdEmpresa = Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdEmpresa AND 
                         Fj_servindustrias.ro_zona.IdZona = Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdZona AND Fj_servindustrias.ro_zona.IdEmpresa = Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdEmpresa AND 
                         Fj_servindustrias.ro_zona.IdZona = Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdZona AND Fj_servindustrias.ro_zona.IdEmpresa = Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdEmpresa AND 
                         Fj_servindustrias.ro_zona.IdZona = Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdZona AND Fj_servindustrias.ro_zona.IdEmpresa = Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdEmpresa AND 
                         Fj_servindustrias.ro_zona.IdZona = Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdZona AND Fj_servindustrias.ro_zona.IdEmpresa = Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdEmpresa AND 
                         Fj_servindustrias.ro_zona.IdZona = Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdZona AND Fj_servindustrias.ro_zona.IdEmpresa = Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdEmpresa AND 
                         Fj_servindustrias.ro_zona.IdZona = Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdZona INNER JOIN
                         Fj_servindustrias.ro_fuerza ON Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdEmpresa = Fj_servindustrias.ro_fuerza.IdEmpresa AND 
                         Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdFuerza = Fj_servindustrias.ro_fuerza.IdFuerza AND 
                         Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdEmpresa = Fj_servindustrias.ro_fuerza.IdEmpresa AND 
                         Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdFuerza = Fj_servindustrias.ro_fuerza.IdFuerza AND 
                         Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdEmpresa = Fj_servindustrias.ro_fuerza.IdEmpresa AND 
                         Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdFuerza = Fj_servindustrias.ro_fuerza.IdFuerza AND 
                         Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdEmpresa = Fj_servindustrias.ro_fuerza.IdEmpresa AND 
                         Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdFuerza = Fj_servindustrias.ro_fuerza.IdFuerza AND 
                         Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdEmpresa = Fj_servindustrias.ro_fuerza.IdEmpresa AND 
                         Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdFuerza = Fj_servindustrias.ro_fuerza.IdFuerza AND 
                         Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdEmpresa = Fj_servindustrias.ro_fuerza.IdEmpresa AND 
                         Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdFuerza = Fj_servindustrias.ro_fuerza.IdFuerza AND 
                         Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdEmpresa = Fj_servindustrias.ro_fuerza.IdEmpresa AND 
                         Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdFuerza = Fj_servindustrias.ro_fuerza.IdFuerza INNER JOIN
                         Fj_servindustrias.ro_disco ON Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdEmpresa = Fj_servindustrias.ro_disco.IdEmpresa AND 
                         Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdDisco = Fj_servindustrias.ro_disco.IdDisco AND Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdEmpresa = Fj_servindustrias.ro_disco.IdEmpresa AND
                          Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdDisco = Fj_servindustrias.ro_disco.IdDisco AND Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdEmpresa = Fj_servindustrias.ro_disco.IdEmpresa AND
                          Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdDisco = Fj_servindustrias.ro_disco.IdDisco AND Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdEmpresa = Fj_servindustrias.ro_disco.IdEmpresa AND
                          Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdDisco = Fj_servindustrias.ro_disco.IdDisco AND Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdEmpresa = Fj_servindustrias.ro_disco.IdEmpresa AND
                          Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdDisco = Fj_servindustrias.ro_disco.IdDisco AND Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdEmpresa = Fj_servindustrias.ro_disco.IdEmpresa AND
                          Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdDisco = Fj_servindustrias.ro_disco.IdDisco AND Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdEmpresa = Fj_servindustrias.ro_disco.IdEmpresa AND
                          Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdDisco = Fj_servindustrias.ro_disco.IdDisco INNER JOIN
                         Fj_servindustrias.ro_placa ON Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdEmpresa = Fj_servindustrias.ro_placa.IdEmpresa AND 
                         Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdPlaca = Fj_servindustrias.ro_placa.IdPlaca AND Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdEmpresa = Fj_servindustrias.ro_placa.IdEmpresa AND
                          Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdPlaca = Fj_servindustrias.ro_placa.IdPlaca AND Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdEmpresa = Fj_servindustrias.ro_placa.IdEmpresa AND
                          Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdPlaca = Fj_servindustrias.ro_placa.IdPlaca AND Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdEmpresa = Fj_servindustrias.ro_placa.IdEmpresa AND
                          Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdPlaca = Fj_servindustrias.ro_placa.IdPlaca AND Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdEmpresa = Fj_servindustrias.ro_placa.IdEmpresa AND
                          Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdPlaca = Fj_servindustrias.ro_placa.IdPlaca AND Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdEmpresa = Fj_servindustrias.ro_placa.IdEmpresa AND
                          Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdPlaca = Fj_servindustrias.ro_placa.IdPlaca AND Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdEmpresa = Fj_servindustrias.ro_placa.IdEmpresa AND
                          Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdPlaca = Fj_servindustrias.ro_placa.IdPlaca INNER JOIN
                         Fj_servindustrias.ro_ruta ON Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdEmpresa = Fj_servindustrias.ro_ruta.IdEmpresa AND 
                         Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdRuta = Fj_servindustrias.ro_ruta.IdRuta AND Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdEmpresa = Fj_servindustrias.ro_ruta.IdEmpresa AND 
                         Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdRuta = Fj_servindustrias.ro_ruta.IdRuta AND Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdEmpresa = Fj_servindustrias.ro_ruta.IdEmpresa AND 
                         Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdRuta = Fj_servindustrias.ro_ruta.IdRuta AND Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdEmpresa = Fj_servindustrias.ro_ruta.IdEmpresa AND 
                         Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdRuta = Fj_servindustrias.ro_ruta.IdRuta AND Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdEmpresa = Fj_servindustrias.ro_ruta.IdEmpresa AND 
                         Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdRuta = Fj_servindustrias.ro_ruta.IdRuta AND Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdEmpresa = Fj_servindustrias.ro_ruta.IdEmpresa AND 
                         Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdRuta = Fj_servindustrias.ro_ruta.IdRuta AND Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdEmpresa = Fj_servindustrias.ro_ruta.IdEmpresa AND 
                         Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdRuta = Fj_servindustrias.ro_ruta.IdRuta INNER JOIN
                         dbo.ro_catalogo AS ro_catalogo_1 INNER JOIN
                         Fj_servindustrias.ro_parametros_reporte AS param_repo ON ro_catalogo_1.CodCatalogo = param_repo.Id_Catalogo INNER JOIN
                         dbo.ro_rubro_tipo INNER JOIN
                         dbo.ro_rol_detalle INNER JOIN
                         dbo.ro_catalogo INNER JOIN
                         dbo.tb_persona AS person INNER JOIN
                         dbo.ro_empleado AS emp INNER JOIN
                         dbo.ro_cargo AS cargo ON emp.IdEmpresa = cargo.IdEmpresa AND emp.IdCargo = cargo.IdCargo AND emp.IdEmpresa = cargo.IdEmpresa AND emp.IdCargo = cargo.IdCargo AND emp.IdEmpresa = cargo.IdEmpresa AND 
                         emp.IdCargo = cargo.IdCargo AND emp.IdEmpresa = cargo.IdEmpresa AND emp.IdCargo = cargo.IdCargo AND emp.IdEmpresa = cargo.IdEmpresa AND emp.IdCargo = cargo.IdCargo AND emp.IdEmpresa = cargo.IdEmpresa AND 
                         emp.IdCargo = cargo.IdCargo AND emp.IdEmpresa = cargo.IdEmpresa AND emp.IdCargo = cargo.IdCargo AND emp.IdEmpresa = cargo.IdEmpresa AND emp.IdCargo = cargo.IdCargo ON person.IdPersona = emp.IdPersona ON 
                         dbo.ro_catalogo.CodCatalogo = emp.em_status ON dbo.ro_rol_detalle.IdEmpresa = emp.IdEmpresa AND dbo.ro_rol_detalle.IdEmpleado = emp.IdEmpleado AND dbo.ro_rol_detalle.IdEmpresa = emp.IdEmpresa AND 
                         dbo.ro_rol_detalle.IdEmpleado = emp.IdEmpleado ON dbo.ro_rubro_tipo.IdEmpresa = dbo.ro_rol_detalle.IdEmpresa AND dbo.ro_rubro_tipo.IdEmpresa = dbo.ro_rol_detalle.IdEmpresa AND 
                         dbo.ro_rubro_tipo.IdRubro = dbo.ro_rol_detalle.IdRubro ON param_repo.IdEmpresa = dbo.ro_rol_detalle.IdEmpresa AND param_repo.IdNomina_Tipo = dbo.ro_rol_detalle.IdNominaTipo AND 
                         param_repo.IdRubro = dbo.ro_rol_detalle.IdRubro AND param_repo.IdNomina_tipo_Liq = dbo.ro_rol_detalle.IdNominaTipoLiqui ON Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdEmpresa = emp.IdEmpresa AND 
                         Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdEmpleado = emp.IdEmpleado ON perio.IdEmpresa = dbo.ro_rol_detalle.IdEmpresa AND perio.IdPeriodo = dbo.ro_rol_detalle.IdPeriodo


					 WHERE          
param_repo.IdEmpresa=@IdEmpresa
and  perio.pe_anio=@Anio
and perio.pe_mes=@Mes
and emp.idempresa=@IdEmpresa
and dbo.ro_rol_detalle.IdEmpresa=@IdEmpresa 
and perio.IdEmpresa=@IdEmpresa
and ISNULL( Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdPeriodo,@idperiodo)=@IdPeriodo

--and  ro_rol_detalle.IdPeriodo=@idperiodo and ro_rol_detalle.IdEmpleado=@idempleado








						 union


-- eventuales

SELECT        dbo.ro_rol_detalle.IdEmpresa, dbo.ro_rol_detalle.IdNominaTipo, dbo.ro_rol_detalle.IdNominaTipoLiqui, dbo.ro_rol_detalle.IdPeriodo, perio.pe_anio, perio.pe_mes, person.pe_cedulaRuc, 'Eventual' AS zo_descripcion, 
                          Fj_servindustrias.ro_fuerza.fu_descripcion, '' AS Disco, '' AS Placa, '' AS ru_descripcion, emp.em_fechaIngaRol, perio.pe_FechaIni, ISNULL(dbo.ro_catalogo.ca_descripcion, emp.em_fechaSalida) AS em_fechaSalida, person.pe_cedulaRuc AS Cedula, 
                         person.pe_apellido + ' ' + person.pe_nombre AS Nombres, cargo.ca_descripcion, ro_catalogo_1.ca_orden, ro_catalogo_1.ca_estado, ro_catalogo_1.ca_descripcion AS Catalogo, param_repo.Descripcion, 
                         dbo.ro_rol_detalle.Valor, param_repo.Orden, 0 Dias_vacaciones
FROM            dbo.ro_catalogo AS ro_catalogo_1 INNER JOIN
                         Fj_servindustrias.ro_parametros_reporte AS param_repo ON ro_catalogo_1.CodCatalogo = param_repo.Id_Catalogo INNER JOIN
                         dbo.ro_periodo_x_ro_Nomina_TipoLiqui INNER JOIN
                         dbo.ro_periodo AS perio ON dbo.ro_periodo_x_ro_Nomina_TipoLiqui.IdEmpresa = perio.IdEmpresa AND dbo.ro_periodo_x_ro_Nomina_TipoLiqui.IdPeriodo = perio.IdPeriodo AND 
                         dbo.ro_periodo_x_ro_Nomina_TipoLiqui.IdEmpresa = perio.IdEmpresa AND dbo.ro_periodo_x_ro_Nomina_TipoLiqui.IdPeriodo = perio.IdPeriodo AND dbo.ro_periodo_x_ro_Nomina_TipoLiqui.IdEmpresa = perio.IdEmpresa AND 
                         dbo.ro_periodo_x_ro_Nomina_TipoLiqui.IdPeriodo = perio.IdPeriodo INNER JOIN
                         dbo.ro_rubro_tipo INNER JOIN
                         dbo.ro_rol_detalle INNER JOIN
                         dbo.ro_catalogo INNER JOIN
                         dbo.tb_persona AS person INNER JOIN
                         dbo.ro_empleado AS emp INNER JOIN
                         dbo.ro_cargo AS cargo ON emp.IdEmpresa = cargo.IdEmpresa AND emp.IdCargo = cargo.IdCargo AND emp.IdEmpresa = cargo.IdEmpresa AND emp.IdCargo = cargo.IdCargo AND emp.IdEmpresa = cargo.IdEmpresa AND 
                         emp.IdCargo = cargo.IdCargo AND emp.IdEmpresa = cargo.IdEmpresa AND emp.IdCargo = cargo.IdCargo AND emp.IdEmpresa = cargo.IdEmpresa AND emp.IdCargo = cargo.IdCargo AND emp.IdEmpresa = cargo.IdEmpresa AND 
                         emp.IdCargo = cargo.IdCargo AND emp.IdEmpresa = cargo.IdEmpresa AND emp.IdCargo = cargo.IdCargo AND emp.IdEmpresa = cargo.IdEmpresa AND emp.IdCargo = cargo.IdCargo ON person.IdPersona = emp.IdPersona ON 
                         dbo.ro_catalogo.CodCatalogo = emp.em_status ON dbo.ro_rol_detalle.IdEmpresa = emp.IdEmpresa AND dbo.ro_rol_detalle.IdEmpleado = emp.IdEmpleado AND dbo.ro_rol_detalle.IdEmpresa = emp.IdEmpresa AND 
                         dbo.ro_rol_detalle.IdEmpleado = emp.IdEmpleado ON dbo.ro_rubro_tipo.IdEmpresa = dbo.ro_rol_detalle.IdEmpresa AND dbo.ro_rubro_tipo.IdEmpresa = dbo.ro_rol_detalle.IdEmpresa AND 
                         dbo.ro_rubro_tipo.IdRubro = dbo.ro_rol_detalle.IdRubro ON dbo.ro_periodo_x_ro_Nomina_TipoLiqui.IdEmpresa = dbo.ro_rol_detalle.IdEmpresa AND 
                         dbo.ro_periodo_x_ro_Nomina_TipoLiqui.IdNomina_Tipo = dbo.ro_rol_detalle.IdNominaTipo AND dbo.ro_periodo_x_ro_Nomina_TipoLiqui.IdNomina_TipoLiqui = dbo.ro_rol_detalle.IdNominaTipoLiqui ON 
                         param_repo.IdEmpresa = dbo.ro_rol_detalle.IdEmpresa AND param_repo.IdRubro = dbo.ro_rol_detalle.IdRubro INNER JOIN
                         Fj_servindustrias.ro_empleado_x_cargo_fuerza_grupo ON emp.IdEmpresa = Fj_servindustrias.ro_empleado_x_cargo_fuerza_grupo.IdEmpresa AND 
                         emp.IdEmpleado = Fj_servindustrias.ro_empleado_x_cargo_fuerza_grupo.IdEmpleado AND emp.IdEmpresa = Fj_servindustrias.ro_empleado_x_cargo_fuerza_grupo.IdEmpresa AND 
                         emp.IdEmpleado = Fj_servindustrias.ro_empleado_x_cargo_fuerza_grupo.IdEmpleado AND emp.IdEmpresa = Fj_servindustrias.ro_empleado_x_cargo_fuerza_grupo.IdEmpresa AND 
                         emp.IdEmpleado = Fj_servindustrias.ro_empleado_x_cargo_fuerza_grupo.IdEmpleado AND emp.IdEmpresa = Fj_servindustrias.ro_empleado_x_cargo_fuerza_grupo.IdEmpresa AND 
                         emp.IdEmpleado = Fj_servindustrias.ro_empleado_x_cargo_fuerza_grupo.IdEmpleado AND emp.IdEmpresa = Fj_servindustrias.ro_empleado_x_cargo_fuerza_grupo.IdEmpresa AND 
                         emp.IdEmpleado = Fj_servindustrias.ro_empleado_x_cargo_fuerza_grupo.IdEmpleado AND emp.IdEmpresa = Fj_servindustrias.ro_empleado_x_cargo_fuerza_grupo.IdEmpresa AND 
                         emp.IdEmpleado = Fj_servindustrias.ro_empleado_x_cargo_fuerza_grupo.IdEmpleado INNER JOIN
                         Fj_servindustrias.ro_fuerza ON Fj_servindustrias.ro_empleado_x_cargo_fuerza_grupo.IdEmpresa = Fj_servindustrias.ro_fuerza.IdEmpresa AND 
                         Fj_servindustrias.ro_empleado_x_cargo_fuerza_grupo.IdFuerza = Fj_servindustrias.ro_fuerza.IdFuerza AND Fj_servindustrias.ro_empleado_x_cargo_fuerza_grupo.IdEmpresa = Fj_servindustrias.ro_fuerza.IdEmpresa AND 
                         Fj_servindustrias.ro_empleado_x_cargo_fuerza_grupo.IdFuerza = Fj_servindustrias.ro_fuerza.IdFuerza AND Fj_servindustrias.ro_empleado_x_cargo_fuerza_grupo.IdEmpresa = Fj_servindustrias.ro_fuerza.IdEmpresa AND 
                         Fj_servindustrias.ro_empleado_x_cargo_fuerza_grupo.IdFuerza = Fj_servindustrias.ro_fuerza.IdFuerza AND Fj_servindustrias.ro_empleado_x_cargo_fuerza_grupo.IdEmpresa = Fj_servindustrias.ro_fuerza.IdEmpresa AND 
                         Fj_servindustrias.ro_empleado_x_cargo_fuerza_grupo.IdFuerza = Fj_servindustrias.ro_fuerza.IdFuerza AND Fj_servindustrias.ro_empleado_x_cargo_fuerza_grupo.IdEmpresa = Fj_servindustrias.ro_fuerza.IdEmpresa AND 
                         Fj_servindustrias.ro_empleado_x_cargo_fuerza_grupo.IdFuerza = Fj_servindustrias.ro_fuerza.IdFuerza AND Fj_servindustrias.ro_empleado_x_cargo_fuerza_grupo.IdEmpresa = Fj_servindustrias.ro_fuerza.IdEmpresa AND 
                         Fj_servindustrias.ro_empleado_x_cargo_fuerza_grupo.IdFuerza = Fj_servindustrias.ro_fuerza.IdFuerza

						 WHERE          
param_repo.IdEmpresa=@IdEmpresa
and  perio.pe_anio=@Anio
and perio.pe_mes=@Mes
and emp.idempresa=@IdEmpresa
and dbo.ro_rol_detalle.IdEmpresa=@IdEmpresa 
and dbo.ro_rol_detalle.IdNominaTipo=2 
and dbo.ro_periodo_x_ro_Nomina_TipoLiqui.idempresa=@IdEmpresa
and ro_rol_detalle. IdPeriodo=@IdPeriodo
and ro_empleado_x_cargo_fuerza_grupo.IdPeriodo=@IdPeriodo


--and  ro_rol_detalle.IdPeriodo=@idperiodo and ro_rol_detalle.IdEmpleado=@idempleado


union


-- personal operativo

					SELECT        dbo.ro_rol_detalle.IdEmpresa, dbo.ro_rol_detalle.IdNominaTipo, dbo.ro_rol_detalle.IdNominaTipoLiqui, dbo.ro_rol_detalle.IdPeriodo, perio.pe_anio, perio.pe_mes, person.pe_cedulaRuc, 
                        '' zo_descripcion, ''fu_descripcion, ''Disco, ''Placa,''ru_descripcion, emp.em_fechaIngaRol, 
                         perio.pe_FechaIni, ISNULL(dbo.ro_catalogo.ca_descripcion, emp.em_fechaSalida) AS em_fechaSalida, person.pe_cedulaRuc AS Cedula, person.pe_apellido + ' ' + person.pe_nombre AS Nombres, cargo.ca_descripcion, 
                         ro_catalogo_1.ca_orden, ro_catalogo_1.ca_estado, ro_catalogo_1.ca_descripcion AS Catalogo, param_repo.Descripcion, dbo.ro_rol_detalle.Valor, param_repo.Orden,
						  (select Dias_a_disfrutar from vwRo_Solicitud_Vacaciones vac where 
						 vac.IdEmpresa=@IdEmpresa
						 and vac.IdEmpleado=emp.IdEmpleado
						 and vac.Fecha_Desde between @FechaI and @FechaF
						 and vac.Fecha_Hasta  between @FechaI and @FechaF
						 ) Dias_vacaciones

FROM            dbo.ro_catalogo AS ro_catalogo_1 INNER JOIN
                         Fj_servindustrias.ro_parametros_reporte AS param_repo ON ro_catalogo_1.CodCatalogo = param_repo.Id_Catalogo INNER JOIN
                         dbo.ro_periodo_x_ro_Nomina_TipoLiqui INNER JOIN
                         dbo.ro_periodo AS perio ON dbo.ro_periodo_x_ro_Nomina_TipoLiqui.IdEmpresa = perio.IdEmpresa AND dbo.ro_periodo_x_ro_Nomina_TipoLiqui.IdPeriodo = perio.IdPeriodo AND 
                         dbo.ro_periodo_x_ro_Nomina_TipoLiqui.IdEmpresa = perio.IdEmpresa AND dbo.ro_periodo_x_ro_Nomina_TipoLiqui.IdPeriodo = perio.IdPeriodo AND dbo.ro_periodo_x_ro_Nomina_TipoLiqui.IdEmpresa = perio.IdEmpresa AND 
                         dbo.ro_periodo_x_ro_Nomina_TipoLiqui.IdPeriodo = perio.IdPeriodo INNER JOIN
                         dbo.ro_rubro_tipo INNER JOIN
                         dbo.ro_rol_detalle INNER JOIN
                         dbo.ro_catalogo INNER JOIN
                         dbo.tb_persona AS person INNER JOIN
                         dbo.ro_empleado AS emp INNER JOIN
                         dbo.ro_cargo AS cargo ON emp.IdEmpresa = cargo.IdEmpresa AND emp.IdCargo = cargo.IdCargo AND emp.IdEmpresa = cargo.IdEmpresa AND emp.IdCargo = cargo.IdCargo AND emp.IdEmpresa = cargo.IdEmpresa AND 
                         emp.IdCargo = cargo.IdCargo AND emp.IdEmpresa = cargo.IdEmpresa AND emp.IdCargo = cargo.IdCargo AND emp.IdEmpresa = cargo.IdEmpresa AND emp.IdCargo = cargo.IdCargo AND emp.IdEmpresa = cargo.IdEmpresa AND 
                         emp.IdCargo = cargo.IdCargo AND emp.IdEmpresa = cargo.IdEmpresa AND emp.IdCargo = cargo.IdCargo AND emp.IdEmpresa = cargo.IdEmpresa AND emp.IdCargo = cargo.IdCargo ON person.IdPersona = emp.IdPersona ON 
                         dbo.ro_catalogo.CodCatalogo = emp.em_status ON dbo.ro_rol_detalle.IdEmpresa = emp.IdEmpresa AND dbo.ro_rol_detalle.IdEmpleado = emp.IdEmpleado AND dbo.ro_rol_detalle.IdEmpresa = emp.IdEmpresa AND 
                         dbo.ro_rol_detalle.IdEmpleado = emp.IdEmpleado ON dbo.ro_rubro_tipo.IdEmpresa = dbo.ro_rol_detalle.IdEmpresa AND dbo.ro_rubro_tipo.IdEmpresa = dbo.ro_rol_detalle.IdEmpresa AND 
                         dbo.ro_rubro_tipo.IdRubro = dbo.ro_rol_detalle.IdRubro ON dbo.ro_periodo_x_ro_Nomina_TipoLiqui.IdEmpresa = dbo.ro_rol_detalle.IdEmpresa AND 
                         dbo.ro_periodo_x_ro_Nomina_TipoLiqui.IdNomina_Tipo = dbo.ro_rol_detalle.IdNominaTipo AND dbo.ro_periodo_x_ro_Nomina_TipoLiqui.IdNomina_TipoLiqui = dbo.ro_rol_detalle.IdNominaTipoLiqui ON 
                         param_repo.IdEmpresa = dbo.ro_rol_detalle.IdEmpresa AND param_repo.IdNomina_Tipo = dbo.ro_rol_detalle.IdNominaTipo AND param_repo.IdNomina_tipo_Liq = dbo.ro_rol_detalle.IdNominaTipoLiqui AND 
                         param_repo.IdRubro = dbo.ro_rol_detalle.IdRubro
						 


						 WHERE          
param_repo.IdEmpresa=@IdEmpresa
and  perio.pe_anio=@Anio
and perio.pe_mes=@Mes
and emp.idempresa=@IdEmpresa
and dbo.ro_rol_detalle.IdEmpresa=@IdEmpresa 
and dbo.ro_rol_detalle.IdNominaTipo=1
and IdDivision=1
and dbo.ro_periodo_x_ro_Nomina_TipoLiqui.idempresa=@IdEmpresa
and dbo.ro_rol_detalle.IdPeriodo = @IdPeriodo


--and  ro_rol_detalle.IdPeriodo=@idperiodo and ro_rol_detalle.IdEmpleado=@idempleado









--
) a --where a.Cedula = '0914915749'
order by   a.ca_descripcion, a.Orden