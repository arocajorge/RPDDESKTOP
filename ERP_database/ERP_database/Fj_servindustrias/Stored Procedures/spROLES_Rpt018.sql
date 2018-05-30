--exec [Fj_servindustrias].[spROLES_Rpt018] 1,'01/05/2017','30/05/2017'
CREATE PROCEDURE [Fj_servindustrias].[spROLES_Rpt018]  
	@IdEmpresa int,
	@FechaInicio date,
	@FechaFin date
	
	
AS
set @FechaInicio = cast (@FechaInicio as date)
set @FechaFin = cast (@FechaFin as date)

     select 
						(select COUNT(IdEmpleado) from VWRO_empleado where IdEmpresa=@IdEmpresa and IdTipoNomina=1 and em_status='EST_ACT' ) as EmpleadosActivos,
                        (select COUNT(IdEmpleado) from VWRO_empleado where IdEmpresa=@IdEmpresa and IdTipoNomina=1 and CAST( em_fechaSalida as date) between @FechaInicio and @FechaFin) as EmpleadosPasivos,
					    (select  COUNT(IdEmpleado) from VWRO_empleado where IdEmpresa=@IdEmpresa and IdTipoNomina=1 and em_status='EST_ACT' and CAST( em_fechaIngaRol as date) between @FechaInicio and @FechaFin) as EmpleadosNuevos,
						  (select  COUNT(IdEmpleado) from Fj_servindustrias.ro_marcaciones_x_empleado_x_incidentes_falt_Perm where IdEmpresa=@IdEmpresa and IdNomina_Tipo=1 and Id_catalogo_Cat='FAL' and CAST( es_fecha_registro as date) between @FechaInicio and @FechaFin) as Falta

from VWRO_empleado

where IdEmpresa=@IdEmpresa

--select * from VWRO_empleado where em_fechaSalida between '01/05/2017' and '31/05/2017'