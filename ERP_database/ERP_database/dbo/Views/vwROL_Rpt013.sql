
CREATE VIEW [dbo].[vwROL_Rpt013] AS 
SELECT        dbo.tb_persona.pe_apellido, dbo.tb_persona.pe_nombre, dbo.tb_persona.pe_cedulaRuc, dbo.ro_empleado.IdEmpresa, dbo.ro_empleado.IdEmpleado, dbo.ro_Solicitud_Vacaciones_x_empleado.IdSolicitudVaca, 
                         tb_personaRemplaza.pe_apellido AS pe_apellido_remplazo, tb_personaRemplaza.pe_nombre AS pe_nombre_remplazo, dbo.ro_Solicitud_Vacaciones_x_empleado.Anio_Desde, 
                         dbo.ro_Solicitud_Vacaciones_x_empleado.Anio_Hasta, dbo.ro_Solicitud_Vacaciones_x_empleado.Dias_pendiente, dbo.ro_Solicitud_Vacaciones_x_empleado.Dias_a_disfrutar, 
                         dbo.ro_Solicitud_Vacaciones_x_empleado.Dias_q_Corresponde, dbo.ro_Solicitud_Vacaciones_x_empleado.AnioServicio, dbo.ro_Solicitud_Vacaciones_x_empleado.Fecha, 
                         dbo.ro_Solicitud_Vacaciones_x_empleado.Fecha_Desde, dbo.ro_Solicitud_Vacaciones_x_empleado.Fecha_Hasta, dbo.ro_Solicitud_Vacaciones_x_empleado.Fecha_Retorno, 
                         dbo.ro_Solicitud_Vacaciones_x_empleado.Observacion, dbo.ro_Departamento.de_descripcion, dbo.ro_Solicitud_Vacaciones_x_empleado.Canceladas, dbo.ro_Solicitud_Vacaciones_x_empleado.Gozadas_Pgadas, 
                         dbo.ro_empleado.em_fechaIngaRol, dbo.ro_cargo.ca_descripcion
FROM            dbo.ro_Solicitud_Vacaciones_x_empleado INNER JOIN
                         dbo.ro_empleado ON dbo.ro_Solicitud_Vacaciones_x_empleado.IdEmpresa = dbo.ro_empleado.IdEmpresa AND dbo.ro_Solicitud_Vacaciones_x_empleado.IdEmpleado = dbo.ro_empleado.IdEmpleado INNER JOIN
                         dbo.ro_Departamento ON dbo.ro_empleado.IdEmpresa = dbo.ro_Departamento.IdEmpresa AND dbo.ro_empleado.IdDepartamento = dbo.ro_Departamento.IdDepartamento INNER JOIN
                         dbo.tb_persona ON dbo.ro_empleado.IdPersona = dbo.tb_persona.IdPersona INNER JOIN
                         dbo.ro_cargo ON dbo.ro_empleado.IdEmpresa = dbo.ro_cargo.IdEmpresa AND dbo.ro_empleado.IdCargo = dbo.ro_cargo.IdCargo LEFT OUTER JOIN
                         dbo.ro_empleado AS ro_empleado_remplaza INNER JOIN
                         dbo.tb_persona AS tb_personaRemplaza ON ro_empleado_remplaza.IdPersona = tb_personaRemplaza.IdPersona ON dbo.ro_cargo.IdEmpresa = ro_empleado_remplaza.IdEmpresa AND 
                         dbo.ro_cargo.IdCargo = ro_empleado_remplaza.IdCargo AND dbo.ro_Solicitud_Vacaciones_x_empleado.IdEmpresa = ro_empleado_remplaza.IdEmpresa AND 
                         dbo.ro_Solicitud_Vacaciones_x_empleado.IdEmpleado_aprue = ro_empleado_remplaza.IdEmpleado