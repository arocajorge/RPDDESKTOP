

CREATE PROCEDURE [Fj_servindustrias].[spROLES_Rpt014]  
	@IdEmpresa int,
	@FechaInicio date,
	@FechaFin date
	
	
AS
/*

declare
   @IdEmpresa int,
	@FechaInicio date,
	@FechaFin date

	set @IdEmpresa=2
	
	set @FechaInicio ='2017-07-01'
	set @FechaFin ='2017-07-31'
	*/
	
SELECT        dbo.ro_empleado.IdEmpresa, dbo.ro_Nomina_Tipo.Descripcion, dbo.ro_cargo.ca_descripcion, dbo.ro_catalogo.ca_descripcion AS Asistencia, 
                         COUNT(Fj_servindustrias.ro_marcaciones_x_empleado_x_incidentes_falt_Perm.es_fecha_registro) AS es_fecha_registro
FROM            dbo.ro_Nomina_Tipo INNER JOIN
                         Fj_servindustrias.ro_marcaciones_x_empleado_x_incidentes_falt_Perm INNER JOIN
                         dbo.ro_empleado ON Fj_servindustrias.ro_marcaciones_x_empleado_x_incidentes_falt_Perm.IdEmpresa = dbo.ro_empleado.IdEmpresa AND 
                         Fj_servindustrias.ro_marcaciones_x_empleado_x_incidentes_falt_Perm.IdEmpleado = dbo.ro_empleado.IdEmpleado INNER JOIN
                         dbo.ro_catalogo ON Fj_servindustrias.ro_marcaciones_x_empleado_x_incidentes_falt_Perm.Id_catalogo_Cat = dbo.ro_catalogo.CodCatalogo AND 
                         Fj_servindustrias.ro_marcaciones_x_empleado_x_incidentes_falt_Perm.Id_catalogo_Cat = dbo.ro_catalogo.CodCatalogo INNER JOIN
                         dbo.ro_cargo ON dbo.ro_empleado.IdEmpresa = dbo.ro_cargo.IdEmpresa AND dbo.ro_empleado.IdCargo = dbo.ro_cargo.IdCargo ON 
                         dbo.ro_Nomina_Tipo.IdEmpresa = Fj_servindustrias.ro_marcaciones_x_empleado_x_incidentes_falt_Perm.IdEmpresa AND 
                         dbo.ro_Nomina_Tipo.IdNomina_Tipo = Fj_servindustrias.ro_marcaciones_x_empleado_x_incidentes_falt_Perm.IdNomina_Tipo

where CAST( Fj_servindustrias.ro_marcaciones_x_empleado_x_incidentes_falt_Perm.es_fecha_registro as date) between @FechaInicio and @FechaFin
and  dbo.ro_empleado.IdDivision=2
--and dbo.ro_Nomina_Tipo.IdNomina_Tipo=2
GROUP BY dbo.ro_empleado.IdEmpresa,  dbo.ro_Nomina_Tipo.Descripcion, dbo.ro_cargo.ca_descripcion, dbo.ro_catalogo.ca_descripcion