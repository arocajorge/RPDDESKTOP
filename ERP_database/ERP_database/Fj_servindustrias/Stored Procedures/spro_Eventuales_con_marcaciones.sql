

CREATE PROCEDURE [Fj_servindustrias].[spro_Eventuales_con_marcaciones]
    @Idempres int,
	@IdNomina_Tipo int,
	@FechaDesde date,
	@FechaHasta date
AS

BEGIN

	/*
	declare 
	 @Idempres int,
	@IdNomina_Tipo int,
	@FechaDesde date,
	@FechaHasta date

	set @Idempres =2
	set @IdNomina_Tipo =2
	set @FechaDesde ='01/07/2017'
	*/
	--set @FechaHasta ='31/07/2017'
	


select IdEmpresa,IdNomina_Tipo,IdEmpleado,pe_apellido+' '+pe_nombre as NombreCompleto,ca_descripcion,IdGrupo,IdCargo from Fj_servindustrias.vwro_marcaciones_x_empleado_x_incidentes_falt_Perm

where IdEmpresa=@Idempres
and IdNomina_Tipo=@IdNomina_Tipo
and es_fecha_registro between @FechaDesde and @FechaHasta


group by IdEmpresa,IdNomina_Tipo,IdEmpleado,pe_apellido+' '+pe_nombre,ca_descripcion ,IdGrupo,IdCargo
END