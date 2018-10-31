
﻿CREATE VIEW dbo.vwro_permiso_x_empleado
AS
SELECT        dbo.ro_permiso_x_empleado.IdEmpresa, dbo.ro_permiso_x_empleado.IdPermiso, dbo.ro_permiso_x_empleado.IdEmpleado, dbo.ro_permiso_x_empleado.IdEmpleadoAprueba, dbo.ro_permiso_x_empleado.FechaInicio, 
                         dbo.ro_permiso_x_empleado.FechaFin, dbo.ro_permiso_x_empleado.HoraSalida, dbo.ro_permiso_x_empleado.HoraRegreso, dbo.ro_permiso_x_empleado.DescuentaVacaciones, dbo.ro_permiso_x_empleado.Recuperable, 
                         dbo.ro_permiso_x_empleado.Asunto, dbo.ro_permiso_x_empleado.Descripcion, dbo.ro_permiso_x_empleado.TipoPermiso, dbo.ro_permiso_x_empleado.estado, dbo.tb_persona.pe_cedulaRuc, 
                         dbo.tb_persona.pe_nombreCompleto
FROM            dbo.ro_empleado INNER JOIN
                         dbo.ro_permiso_x_empleado ON dbo.ro_empleado.IdEmpresa = dbo.ro_permiso_x_empleado.IdEmpresa AND dbo.ro_empleado.IdEmpresa = dbo.ro_permiso_x_empleado.IdEmpresa AND 
                         dbo.ro_empleado.IdEmpleado = dbo.ro_permiso_x_empleado.IdEmpleadoAprueba AND dbo.ro_empleado.IdEmpleado = dbo.ro_permiso_x_empleado.IdEmpleado INNER JOIN
                         dbo.tb_persona ON dbo.ro_empleado.IdPersona = dbo.tb_persona.IdPersona
GO