CREATE VIEW dbo.vwROL_Rpt030
AS
SELECT        dbo.ro_Solicitud_Vacaciones_x_empleado.IdEmpresa, dbo.ro_Solicitud_Vacaciones_x_empleado.IdSolicitud, 
                         dbo.ro_Solicitud_Vacaciones_x_empleado.IdEmpleado, dbo.tb_persona.pe_cedulaRuc, dbo.tb_persona.pe_apellido + ' ' + dbo.tb_persona.pe_nombre AS Nombre, dbo.ro_cargo.ca_descripcion, 
                         dbo.ro_Solicitud_Vacaciones_x_empleado.Anio_Desde, dbo.ro_Solicitud_Vacaciones_x_empleado.Anio_Hasta, dbo.ro_Solicitud_Vacaciones_x_empleado.AnioServicio, 
                         dbo.ro_Solicitud_Vacaciones_x_empleado.Dias_q_Corresponde, dbo.ro_Solicitud_Vacaciones_x_empleado.Dias_a_disfrutar, dbo.ro_Solicitud_Vacaciones_x_empleado.Dias_pendiente, 
                         dbo.ro_Solicitud_Vacaciones_x_empleado.Fecha_Desde, dbo.ro_Solicitud_Vacaciones_x_empleado.Fecha_Hasta, dbo.ro_Solicitud_Vacaciones_x_empleado.Fecha_Retorno, 
                         dbo.ro_Solicitud_Vacaciones_x_empleado.Observacion, dbo.ro_Solicitud_Vacaciones_x_empleado.Gozadas_Pgadas, dbo.ro_Historico_Liquidacion_Vacaciones.ValorCancelado, 
                         dbo.ro_Historico_Liquidacion_Vacaciones.FechaPago, dbo.ro_Historico_Liquidacion_Vacaciones.Iess
FROM            dbo.tb_persona INNER JOIN
                         dbo.ro_empleado ON dbo.tb_persona.IdPersona = dbo.ro_empleado.IdPersona INNER JOIN
                         dbo.ro_Solicitud_Vacaciones_x_empleado ON dbo.ro_empleado.IdEmpresa = dbo.ro_Solicitud_Vacaciones_x_empleado.IdEmpresa AND 
                         dbo.ro_empleado.IdEmpleado = dbo.ro_Solicitud_Vacaciones_x_empleado.IdEmpleado INNER JOIN
                         dbo.ro_Historico_Liquidacion_Vacaciones ON dbo.ro_Solicitud_Vacaciones_x_empleado.IdEmpresa = dbo.ro_Historico_Liquidacion_Vacaciones.IdEmpresa AND 
                         dbo.ro_Solicitud_Vacaciones_x_empleado.IdSolicitud = dbo.ro_Historico_Liquidacion_Vacaciones.IdLiquidacion AND 
                         dbo.ro_Solicitud_Vacaciones_x_empleado.IdEmpleado = dbo.ro_Historico_Liquidacion_Vacaciones.IdEmpleado INNER JOIN
                         dbo.ro_cargo ON dbo.ro_empleado.IdEmpresa = dbo.ro_cargo.IdEmpresa AND dbo.ro_empleado.IdCargo = dbo.ro_cargo.IdCargo