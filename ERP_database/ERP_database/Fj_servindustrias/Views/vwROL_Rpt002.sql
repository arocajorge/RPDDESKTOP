CREATE VIEW [Fj_servindustrias].[vwROL_Rpt002]
	AS
SELECT        dbo.ro_rol_detalle.IdEmpresa, dbo.ro_rol_detalle.IdNominaTipo, dbo.ro_periodo.pe_anio, dbo.ro_periodo.pe_mes, dbo.tb_persona.pe_cedulaRuc, 
                         dbo.tb_persona.pe_apellido + ' ' + dbo.tb_persona.pe_nombre AS Nombres, dbo.ro_rubro_tipo.ru_descripcion, dbo.ro_cargo.ca_descripcion, Fj_servindustrias.ro_zona.zo_descripcion, 
                         Fj_servindustrias.ro_fuerza.fu_descripcion, dbo.ro_rubro_tipo.ru_orden, SUM(dbo.ro_rol_detalle.Valor) AS Expr1, dbo.ro_rol_detalle.IdEmpleado
FROM            dbo.ro_periodo_x_ro_Nomina_TipoLiqui INNER JOIN
                         dbo.ro_periodo ON dbo.ro_periodo_x_ro_Nomina_TipoLiqui.IdEmpresa = dbo.ro_periodo.IdEmpresa AND dbo.ro_periodo_x_ro_Nomina_TipoLiqui.IdPeriodo = dbo.ro_periodo.IdPeriodo INNER JOIN
                         dbo.ro_rol_detalle INNER JOIN
                         dbo.ro_empleado ON dbo.ro_rol_detalle.IdEmpresa = dbo.ro_empleado.IdEmpresa AND dbo.ro_rol_detalle.IdEmpleado = dbo.ro_empleado.IdEmpleado ON 
                         dbo.ro_periodo_x_ro_Nomina_TipoLiqui.IdEmpresa = dbo.ro_rol_detalle.IdEmpresa AND dbo.ro_periodo_x_ro_Nomina_TipoLiqui.IdNomina_Tipo = dbo.ro_rol_detalle.IdNominaTipo AND 
                         dbo.ro_periodo_x_ro_Nomina_TipoLiqui.IdNomina_TipoLiqui = dbo.ro_rol_detalle.IdNominaTipoLiqui AND dbo.ro_periodo_x_ro_Nomina_TipoLiqui.IdPeriodo = dbo.ro_rol_detalle.IdPeriodo INNER JOIN
                         dbo.ro_rubro_tipo ON dbo.ro_rol_detalle.IdEmpresa = dbo.ro_rubro_tipo.IdEmpresa AND dbo.ro_rol_detalle.IdRubro = dbo.ro_rubro_tipo.IdRubro INNER JOIN
                         dbo.ro_cargo ON dbo.ro_empleado.IdEmpresa = dbo.ro_cargo.IdEmpresa AND dbo.ro_empleado.IdCargo = dbo.ro_cargo.IdCargo INNER JOIN
                         Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det ON dbo.ro_empleado.IdEmpresa = Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdEmpresa AND 
                         dbo.ro_empleado.IdEmpleado = Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdEmpleado AND 
                         dbo.ro_empleado.IdEmpresa = Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdEmpresa AND 
                         dbo.ro_empleado.IdEmpleado = Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdEmpleado AND 
                         dbo.ro_empleado.IdEmpresa = Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdEmpresa AND 
                         dbo.ro_empleado.IdEmpleado = Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdEmpleado INNER JOIN
                         Fj_servindustrias.ro_fuerza ON Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdEmpresa = Fj_servindustrias.ro_fuerza.IdEmpresa AND 
                         Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdFuerza = Fj_servindustrias.ro_fuerza.IdFuerza AND 
                         Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdEmpresa = Fj_servindustrias.ro_fuerza.IdEmpresa AND 
                         Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdFuerza = Fj_servindustrias.ro_fuerza.IdFuerza AND 
                         Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdEmpresa = Fj_servindustrias.ro_fuerza.IdEmpresa AND 
                         Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdFuerza = Fj_servindustrias.ro_fuerza.IdFuerza AND 
                         Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdEmpresa = Fj_servindustrias.ro_fuerza.IdEmpresa AND 
                         Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdFuerza = Fj_servindustrias.ro_fuerza.IdFuerza AND 
                         Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdEmpresa = Fj_servindustrias.ro_fuerza.IdEmpresa AND 
                         Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdFuerza = Fj_servindustrias.ro_fuerza.IdFuerza INNER JOIN
                         Fj_servindustrias.ro_zona ON Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdEmpresa = Fj_servindustrias.ro_zona.IdEmpresa AND 
                         Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdZona = Fj_servindustrias.ro_zona.IdZona AND 
                         Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdEmpresa = Fj_servindustrias.ro_zona.IdEmpresa AND 
                         Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdZona = Fj_servindustrias.ro_zona.IdZona AND 
                         Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdEmpresa = Fj_servindustrias.ro_zona.IdEmpresa AND 
                         Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdZona = Fj_servindustrias.ro_zona.IdZona AND 
                         Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdEmpresa = Fj_servindustrias.ro_zona.IdEmpresa AND 
                         Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdZona = Fj_servindustrias.ro_zona.IdZona AND 
                         Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdEmpresa = Fj_servindustrias.ro_zona.IdEmpresa AND 
                         Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdZona = Fj_servindustrias.ro_zona.IdZona INNER JOIN
                         dbo.tb_persona ON dbo.ro_empleado.IdPersona = dbo.tb_persona.IdPersona AND dbo.ro_empleado.IdPersona = dbo.tb_persona.IdPersona AND dbo.ro_empleado.IdPersona = dbo.tb_persona.IdPersona AND 
                         dbo.ro_empleado.IdPersona = dbo.tb_persona.IdPersona AND dbo.ro_empleado.IdPersona = dbo.tb_persona.IdPersona
WHERE        (dbo.ro_rubro_tipo.ru_tipo IN ('I', 'E'))
GROUP BY dbo.ro_rol_detalle.IdEmpresa, dbo.ro_rol_detalle.IdNominaTipo, dbo.ro_periodo.pe_anio, dbo.ro_periodo.pe_mes, dbo.tb_persona.pe_cedulaRuc, dbo.tb_persona.pe_apellido + ' ' + dbo.tb_persona.pe_nombre, 
                         dbo.ro_rubro_tipo.ru_descripcion, dbo.ro_cargo.ca_descripcion, Fj_servindustrias.ro_zona.zo_descripcion, Fj_servindustrias.ro_fuerza.fu_descripcion, dbo.ro_rubro_tipo.ru_orden, dbo.ro_rol_detalle.IdEmpleado