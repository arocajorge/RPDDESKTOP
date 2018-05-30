CREATE view  Grafinpren.vwRo_Solicitud_Vacaciones_Graf as
SELECT        dbo.ro_Solicitud_Vacaciones_x_empleado.IdEmpresa, dbo.ro_Solicitud_Vacaciones_x_empleado.IdNomina_Tipo, 
                         dbo.ro_Solicitud_Vacaciones_x_empleado.IdEmpleado, dbo.tb_persona.pe_cedulaRuc, dbo.tb_persona.pe_apellido + ' ' + dbo.tb_persona.pe_nombre AS Nombres, 
                         dbo.ro_Historico_Liquidacion_Vacaciones.IdOrdenPago, dbo.ro_Solicitud_Vacaciones_x_empleado.Anio_Desde, 
                         dbo.ro_Solicitud_Vacaciones_x_empleado.Anio_Hasta, dbo.ro_cargo.ca_descripcion, dbo.ro_Departamento.de_descripcion, 
                         SUM(dbo.ro_Solicitud_Vacaciones_x_empleado.Dias_a_disfrutar) AS Dias_a_disfrutar, dbo.ro_Historico_Liquidacion_Vacaciones.IdLiquidacion
FROM            dbo.ro_Solicitud_Vacaciones_x_empleado INNER JOIN
                         dbo.ro_empleado ON dbo.ro_Solicitud_Vacaciones_x_empleado.IdEmpresa = dbo.ro_empleado.IdEmpresa AND 
                         dbo.ro_Solicitud_Vacaciones_x_empleado.IdEmpleado = dbo.ro_empleado.IdEmpleado INNER JOIN
                         dbo.tb_persona ON dbo.ro_empleado.IdPersona = dbo.tb_persona.IdPersona INNER JOIN
                         dbo.ro_cargo ON dbo.ro_empleado.IdEmpresa = dbo.ro_cargo.IdEmpresa AND dbo.ro_empleado.IdCargo = dbo.ro_cargo.IdCargo INNER JOIN
                         dbo.ro_Departamento ON dbo.ro_empleado.IdEmpresa = dbo.ro_Departamento.IdEmpresa AND 
                         dbo.ro_empleado.IdDepartamento = dbo.ro_Departamento.IdDepartamento LEFT OUTER JOIN
                         dbo.ro_Historico_Liquidacion_Vacaciones ON dbo.ro_Solicitud_Vacaciones_x_empleado.IdEmpresa = dbo.ro_Historico_Liquidacion_Vacaciones.IdEmpresa AND 
                         dbo.ro_Solicitud_Vacaciones_x_empleado.IdNomina_Tipo = dbo.ro_Historico_Liquidacion_Vacaciones.IdNomina_Tipo AND 
                         dbo.ro_Solicitud_Vacaciones_x_empleado.IdEmpleado = dbo.ro_Historico_Liquidacion_Vacaciones.IdEmpleado
GROUP BY dbo.ro_Solicitud_Vacaciones_x_empleado.IdEmpresa, dbo.ro_Solicitud_Vacaciones_x_empleado.IdNomina_Tipo, 
                         dbo.ro_Solicitud_Vacaciones_x_empleado.IdEmpleado, dbo.tb_persona.pe_cedulaRuc, dbo.tb_persona.pe_apellido + ' ' + dbo.tb_persona.pe_nombre, 
                         dbo.ro_Historico_Liquidacion_Vacaciones.IdOrdenPago, dbo.ro_Solicitud_Vacaciones_x_empleado.Anio_Desde, 
                         dbo.ro_Solicitud_Vacaciones_x_empleado.Anio_Hasta, dbo.ro_cargo.ca_descripcion, dbo.ro_Departamento.de_descripcion, 
                         dbo.ro_Historico_Liquidacion_Vacaciones.IdLiquidacion