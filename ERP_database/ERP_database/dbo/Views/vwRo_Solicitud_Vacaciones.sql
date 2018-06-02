CREATE VIEW dbo.vwRo_Solicitud_Vacaciones
AS
SELECT        dbo.ro_Solicitud_Vacaciones_x_empleado.IdEmpresa,  dbo.ro_Solicitud_Vacaciones_x_empleado.IdSolicitud, dbo.ro_Solicitud_Vacaciones_x_empleado.Fecha, 
                         dbo.ro_Solicitud_Vacaciones_x_empleado.IdEmpleado, dbo.ro_Solicitud_Vacaciones_x_empleado.AnioServicio, dbo.ro_Solicitud_Vacaciones_x_empleado.Dias_q_Corresponde, 
                         dbo.ro_Solicitud_Vacaciones_x_empleado.Dias_a_disfrutar, dbo.ro_Solicitud_Vacaciones_x_empleado.Dias_pendiente, dbo.ro_Solicitud_Vacaciones_x_empleado.Anio_Desde, 
                         dbo.ro_Solicitud_Vacaciones_x_empleado.Anio_Hasta, dbo.ro_Solicitud_Vacaciones_x_empleado.Fecha_Desde, dbo.ro_Solicitud_Vacaciones_x_empleado.Fecha_Hasta, 
                         dbo.ro_Solicitud_Vacaciones_x_empleado.Fecha_Retorno, dbo.ro_Solicitud_Vacaciones_x_empleado.Observacion, dbo.ro_Solicitud_Vacaciones_x_empleado.IdUsuario, 
                         dbo.ro_Solicitud_Vacaciones_x_empleado.IdUsuario_Anu, dbo.ro_Solicitud_Vacaciones_x_empleado.FechaAnulacion, dbo.ro_Solicitud_Vacaciones_x_empleado.Fecha_Transac, 
                         dbo.ro_Solicitud_Vacaciones_x_empleado.Fecha_UltMod, dbo.ro_Solicitud_Vacaciones_x_empleado.IdUsuarioUltMod, dbo.ro_Solicitud_Vacaciones_x_empleado.Estado, 
                         dbo.ro_Solicitud_Vacaciones_x_empleado.MotivoAnulacion, dbo.ro_Solicitud_Vacaciones_x_empleado.ip, dbo.ro_Solicitud_Vacaciones_x_empleado.nom_pc, dbo.ro_Solicitud_Vacaciones_x_empleado.IdEstadoAprobacion, 
                         dbo.tb_persona.pe_apellido, dbo.tb_persona.pe_nombre, dbo.tb_persona.pe_nombreCompleto, dbo.ro_Solicitud_Vacaciones_x_empleado.IdEmpleado_aprue, dbo.ro_Solicitud_Vacaciones_x_empleado.IdEmpleado_remp, 
                         dbo.ro_Solicitud_Vacaciones_x_empleado.Gozadas_Pgadas, dbo.ro_Historico_Liquidacion_Vacaciones.IdOrdenPago, dbo.ro_Solicitud_Vacaciones_x_empleado.Canceladas, 
                         dbo.ro_Historico_Liquidacion_Vacaciones.ValorCancelado, dbo.ro_Historico_Liquidacion_Vacaciones.FechaPago, dbo.ro_Historico_Liquidacion_Vacaciones.Iess
FROM            dbo.ro_Solicitud_Vacaciones_x_empleado INNER JOIN
                         dbo.ro_empleado ON dbo.ro_Solicitud_Vacaciones_x_empleado.IdEmpresa = dbo.ro_empleado.IdEmpresa AND dbo.ro_Solicitud_Vacaciones_x_empleado.IdEmpleado = dbo.ro_empleado.IdEmpleado INNER JOIN
                         dbo.tb_persona ON dbo.ro_empleado.IdPersona = dbo.tb_persona.IdPersona LEFT OUTER JOIN
                         dbo.ro_Historico_Liquidacion_Vacaciones ON dbo.ro_Solicitud_Vacaciones_x_empleado.IdEmpresa = dbo.ro_Historico_Liquidacion_Vacaciones.IdEmpresa AND 
                         dbo.ro_Solicitud_Vacaciones_x_empleado.IdEmpleado = dbo.ro_Historico_Liquidacion_Vacaciones.IdEmpleado AND 
                         dbo.ro_Solicitud_Vacaciones_x_empleado.IdSolicitud = dbo.ro_Historico_Liquidacion_Vacaciones.IdLiquidacion


