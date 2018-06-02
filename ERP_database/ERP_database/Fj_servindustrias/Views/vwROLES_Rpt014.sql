CREATE VIEW [Fj_servindustrias].[vwROLES_Rpt014]
	AS 

	SELECT        dbo.ro_empleado.IdEmpresa, dbo.ro_empleado.IdEmpleado, dbo.ro_Nomina_Tipo.Descripcion, dbo.ro_cargo.ca_descripcion, dbo.ro_catalogo.ca_descripcion AS Asistencia
FROM            Fj_servindustrias.ro_marcaciones_x_empleado_x_incidentes_falt_Perm INNER JOIN
                         dbo.ro_empleado ON Fj_servindustrias.ro_marcaciones_x_empleado_x_incidentes_falt_Perm.IdEmpresa = dbo.ro_empleado.IdEmpresa AND 
                         Fj_servindustrias.ro_marcaciones_x_empleado_x_incidentes_falt_Perm.IdEmpleado = dbo.ro_empleado.IdEmpleado INNER JOIN
                         dbo.ro_cargo ON dbo.ro_empleado.IdEmpresa = dbo.ro_cargo.IdEmpresa AND dbo.ro_empleado.IdCargo = dbo.ro_cargo.IdCargo INNER JOIN
                         dbo.ro_catalogo ON Fj_servindustrias.ro_marcaciones_x_empleado_x_incidentes_falt_Perm.Id_catalogo_Cat = dbo.ro_catalogo.CodCatalogo AND 
                         Fj_servindustrias.ro_marcaciones_x_empleado_x_incidentes_falt_Perm.Id_catalogo_Cat = dbo.ro_catalogo.CodCatalogo INNER JOIN
                         dbo.ro_empleado_x_ro_tipoNomina ON dbo.ro_empleado.IdEmpresa = dbo.ro_empleado_x_ro_tipoNomina.IdEmpresa AND dbo.ro_empleado.IdEmpleado = dbo.ro_empleado_x_ro_tipoNomina.IdEmpleado INNER JOIN
                         dbo.ro_Nomina_Tipo ON dbo.ro_empleado_x_ro_tipoNomina.IdEmpresa = dbo.ro_Nomina_Tipo.IdEmpresa AND dbo.ro_empleado_x_ro_tipoNomina.IdTipoNomina = dbo.ro_Nomina_Tipo.IdNomina_Tipo