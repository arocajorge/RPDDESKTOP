CREATE VIEW [web].[vwro_rol_detalle_generar_op]
	AS 

	SELECT        dbo.ro_rol_detalle.IdEmpresa, dbo.ro_rol_detalle.IdNominaTipo, dbo.ro_rol_detalle.IdNominaTipoLiqui, dbo.ro_rol_detalle.IdPeriodo, dbo.ro_rol_detalle.IdEmpleado, dbo.ro_rol_detalle.IdRubro, dbo.ro_rol_detalle.Valor, 
                         dbo.ro_periodo.pe_FechaIni, dbo.ro_periodo.pe_FechaFin, dbo.tb_persona.IdPersona
FROM            dbo.ro_periodo_x_ro_Nomina_TipoLiqui INNER JOIN
                         dbo.ro_periodo ON dbo.ro_periodo_x_ro_Nomina_TipoLiqui.IdEmpresa = dbo.ro_periodo.IdEmpresa AND dbo.ro_periodo_x_ro_Nomina_TipoLiqui.IdPeriodo = dbo.ro_periodo.IdPeriodo INNER JOIN
                         dbo.ro_rol_detalle INNER JOIN
                         dbo.ro_empleado ON dbo.ro_rol_detalle.IdEmpresa = dbo.ro_empleado.IdEmpresa AND dbo.ro_rol_detalle.IdEmpleado = dbo.ro_empleado.IdEmpleado INNER JOIN
                         dbo.tb_persona ON dbo.ro_empleado.IdPersona = dbo.tb_persona.IdPersona ON dbo.ro_periodo_x_ro_Nomina_TipoLiqui.IdEmpresa = dbo.ro_rol_detalle.IdEmpresa AND 
                         dbo.ro_periodo_x_ro_Nomina_TipoLiqui.IdNomina_Tipo = dbo.ro_rol_detalle.IdNominaTipo AND dbo.ro_periodo_x_ro_Nomina_TipoLiqui.IdNomina_TipoLiqui = dbo.ro_rol_detalle.IdNominaTipoLiqui AND 
                         dbo.ro_periodo_x_ro_Nomina_TipoLiqui.IdPeriodo = dbo.ro_rol_detalle.IdPeriodo
WHERE        (dbo.ro_rol_detalle.IdRubro = '950') AND (dbo.ro_rol_detalle.Valor > 0)
