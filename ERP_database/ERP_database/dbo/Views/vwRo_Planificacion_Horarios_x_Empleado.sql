CREATE VIEW [dbo].[vwRo_Planificacion_Horarios_x_Empleado]
AS
SELECT        dbo.VWRO_empleado.pe_nombreCompleto, dbo.tb_Calendario.NombreCortoFecha, dbo.tb_Calendario.Inicial_del_Dia, dbo.ro_horario_planificacion_det.IdPlanificacion, 
                         dbo.ro_horario.Descripcion, dbo.tb_Calendario.fecha, dbo.ro_horario_planificacion_det.IdHorario, dbo.ro_horario_planificacion_det.IdEmpleado, 
                         dbo.ro_horario_planificacion_det.IdEmpresa, dbo.ro_horario_planificacion_det.Estado, dbo.tb_sucursal.Su_Descripcion, dbo.VWRO_empleado.IdSucursal, 
                         dbo.VWRO_empleado.Departamento, dbo.ro_cargo.ca_descripcion, dbo.ro_horario_planificacion_det.IdCalendario
FROM            dbo.tb_Calendario INNER JOIN
                         dbo.ro_horario_planificacion_det ON dbo.tb_Calendario.IdCalendario = dbo.ro_horario_planificacion_det.IdCalendario INNER JOIN
                         dbo.ro_horario ON dbo.ro_horario_planificacion_det.IdEmpresa = dbo.ro_horario.IdEmpresa AND 
                         dbo.ro_horario_planificacion_det.IdHorario = dbo.ro_horario.IdHorario INNER JOIN
                         dbo.VWRO_empleado ON dbo.ro_horario_planificacion_det.IdEmpresa = dbo.VWRO_empleado.IdEmpresa AND 
                         dbo.ro_horario_planificacion_det.IdEmpleado = dbo.VWRO_empleado.IdEmpleado INNER JOIN
                         dbo.tb_sucursal ON dbo.ro_horario_planificacion_det.IdEmpresa = dbo.tb_sucursal.IdEmpresa AND dbo.VWRO_empleado.IdSucursal = dbo.tb_sucursal.IdSucursal AND 
                         dbo.VWRO_empleado.IdEmpresa = dbo.tb_sucursal.IdEmpresa INNER JOIN
                         dbo.ro_cargo ON dbo.VWRO_empleado.IdCargo = dbo.ro_cargo.IdCargo AND dbo.VWRO_empleado.IdEmpresa = dbo.ro_cargo.IdEmpresa