
CREATE PROCEDURE  [Fj_servindustrias].[spROLES_Rpt002] 
	@IdEmpresa int,
	@IdNomina int,
	@IdEmpleado numeric,
	@IdPeriodo int,
	@Anio int,
	@Mes int

	
AS

BEGIN

	

	
--  RUBROS QUE AFECTAN A ROL INDIVIDUAL
/*
declare
@IdEmpresa int,
	@IdNomina int,
	@IdEmpleado numeric,
	@IdPeriodo int,
	@Anio int,
	@Mes int

	set @IdEmpresa =2
	set @IdNomina =2
	set @IdEmpleado =267
	set @IdPeriodo =201707
	set @Anio =2017
	set @Mes =07

	
	*/
	

 declare 
 @DiasTrabajados int ,
 @FindeMes float,
 @variable float,
 @FondoReserva float,
 @Quincena float
 -- dias efectivos
 select @DiasTrabajados= Valor from ro_rol_detalle D 
where 
D.IdEmpresa=@IdEmpresa 
and D.IdEmpleado=@IdEmpleado
and D.IdNominaTipo=@IdNomina
and  D.IdNominaTipoLiqui=2
and D.IdRubro=2
and D.IdPeriodo=@IdPeriodo

-- quincena
 select @Quincena= Valor from vwRo_Rol_Detalle D 
where 
D.IdEmpresa=@IdEmpresa 
and D.IdEmpleado=@IdEmpleado
and D.IdNominaTipo=@IdNomina
and  D.IdNominaTipoLiqui=1
and D.IdRubro=950
and D.pe_anio=@Anio
And D.pe_mes=@Mes

-- fin de mes
 select @FindeMes= Valor from ro_rol_detalle D 
where 
D.IdEmpresa=@IdEmpresa 
and D.IdEmpleado=@IdEmpleado
and D.IdNominaTipo=@IdNomina
and  D.IdNominaTipoLiqui=2
and D.IdRubro=950
and D.IdPeriodo=@IdPeriodo
-- variable
 select @variable= Valor from ro_rol_detalle D 
where 
D.IdEmpresa=@IdEmpresa 
and D.IdEmpleado=@IdEmpleado
and D.IdNominaTipo=@IdNomina
and  D.IdNominaTipoLiqui=3
and D.IdRubro=950
and D.IdPeriodo=@IdPeriodo
-- fondo de reserva

 select @FondoReserva=ISNULL( Valor,0) from ro_rol_detalle D 
where 
D.IdEmpresa=@IdEmpresa 
and D.IdEmpleado=@IdEmpleado
and D.IdNominaTipo=@IdNomina
and  D.IdNominaTipoLiqui=4
and D.IdRubro=950
and D.IdPeriodo=@IdPeriodo





--**************************************************************************************************************************************************************************************
--**********************************************************+OPERATIVOS******************************************************************************************************************






SELECT        dbo.ro_rol_detalle.IdEmpresa, dbo.ro_rol_detalle.IdNominaTipo, dbo.ro_periodo.pe_anio, dbo.ro_periodo.pe_mes, dbo.tb_persona.pe_cedulaRuc, 
                         dbo.tb_persona.pe_apellido + ' ' + dbo.tb_persona.pe_nombre AS Nombres, dbo.ro_rubro_tipo.ru_descripcion, dbo.ro_cargo.ca_descripcion, Fj_servindustrias.ro_zona.zo_descripcion, 
                         Fj_servindustrias.ro_fuerza.fu_descripcion, dbo.ro_rubro_tipo.ru_orden, case when ro_rol_detalle.IdRubro=994 then ( SUM(dbo.ro_rol_detalle.Valor) + SUM(dbo.ro_rol_detalle.Valor)*0.0945) else SUM(dbo.ro_rol_detalle.Valor) end  AS Expr1, dbo.ro_rol_detalle.IdEmpleado, dbo.ro_rubro_tipo.ru_tipo,
@DiasTrabajados DiasTraba,@Quincena Quincena,@FindeMes FindeMes,ISNULL(@variable,0) Variable,ISNULL( @FondoReserva,0) FondoReserva
FROM            dbo.tb_persona INNER JOIN
                         dbo.ro_periodo_x_ro_Nomina_TipoLiqui INNER JOIN
                         dbo.ro_periodo ON dbo.ro_periodo_x_ro_Nomina_TipoLiqui.IdEmpresa = dbo.ro_periodo.IdEmpresa AND dbo.ro_periodo_x_ro_Nomina_TipoLiqui.IdPeriodo = dbo.ro_periodo.IdPeriodo INNER JOIN
                         dbo.ro_rol_detalle INNER JOIN
                         dbo.ro_empleado ON dbo.ro_rol_detalle.IdEmpresa = dbo.ro_empleado.IdEmpresa AND dbo.ro_rol_detalle.IdEmpleado = dbo.ro_empleado.IdEmpleado ON 
                         dbo.ro_periodo_x_ro_Nomina_TipoLiqui.IdEmpresa = dbo.ro_rol_detalle.IdEmpresa AND dbo.ro_periodo_x_ro_Nomina_TipoLiqui.IdNomina_Tipo = dbo.ro_rol_detalle.IdNominaTipo AND 
                         dbo.ro_periodo_x_ro_Nomina_TipoLiqui.IdNomina_TipoLiqui = dbo.ro_rol_detalle.IdNominaTipoLiqui AND dbo.ro_periodo_x_ro_Nomina_TipoLiqui.IdPeriodo = dbo.ro_rol_detalle.IdPeriodo INNER JOIN
                         dbo.ro_rubro_tipo ON dbo.ro_rol_detalle.IdEmpresa = dbo.ro_rubro_tipo.IdEmpresa AND dbo.ro_rol_detalle.IdRubro = dbo.ro_rubro_tipo.IdRubro INNER JOIN
                         dbo.ro_cargo ON dbo.ro_empleado.IdEmpresa = dbo.ro_cargo.IdEmpresa AND dbo.ro_empleado.IdCargo = dbo.ro_cargo.IdCargo ON dbo.tb_persona.IdPersona = dbo.ro_empleado.IdPersona AND 
                         dbo.tb_persona.IdPersona = dbo.ro_empleado.IdPersona AND dbo.tb_persona.IdPersona = dbo.ro_empleado.IdPersona AND dbo.tb_persona.IdPersona = dbo.ro_empleado.IdPersona AND 
                         dbo.tb_persona.IdPersona = dbo.ro_empleado.IdPersona LEFT OUTER JOIN
                         Fj_servindustrias.ro_fuerza INNER JOIN
                         Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det ON Fj_servindustrias.ro_fuerza.IdEmpresa = Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdEmpresa AND 
                         Fj_servindustrias.ro_fuerza.IdFuerza = Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdFuerza AND 
                         Fj_servindustrias.ro_fuerza.IdEmpresa = Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdEmpresa AND 
                         Fj_servindustrias.ro_fuerza.IdFuerza = Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdFuerza AND 
                         Fj_servindustrias.ro_fuerza.IdEmpresa = Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdEmpresa AND 
                         Fj_servindustrias.ro_fuerza.IdFuerza = Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdFuerza AND 
                         Fj_servindustrias.ro_fuerza.IdEmpresa = Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdEmpresa AND 
                         Fj_servindustrias.ro_fuerza.IdFuerza = Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdFuerza AND 
                         Fj_servindustrias.ro_fuerza.IdEmpresa = Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdEmpresa AND 
                         Fj_servindustrias.ro_fuerza.IdFuerza = Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdFuerza INNER JOIN
                         Fj_servindustrias.ro_zona ON Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdEmpresa = Fj_servindustrias.ro_zona.IdEmpresa AND 
                         Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdZona = Fj_servindustrias.ro_zona.IdZona AND 
                         Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdEmpresa = Fj_servindustrias.ro_zona.IdEmpresa AND 
                         Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdZona = Fj_servindustrias.ro_zona.IdZona AND 
                         Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdEmpresa = Fj_servindustrias.ro_zona.IdEmpresa AND 
                         Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdZona = Fj_servindustrias.ro_zona.IdZona AND 
                         Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdEmpresa = Fj_servindustrias.ro_zona.IdEmpresa AND 
                         Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdZona = Fj_servindustrias.ro_zona.IdZona AND 
                         Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdEmpresa = Fj_servindustrias.ro_zona.IdEmpresa AND 
                         Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdZona = Fj_servindustrias.ro_zona.IdZona ON 
                         dbo.ro_empleado.IdEmpresa = Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdEmpresa AND 
                         dbo.ro_empleado.IdEmpleado = Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdEmpleado AND 
                         dbo.ro_empleado.IdEmpresa = Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdEmpresa AND 
                         dbo.ro_empleado.IdEmpleado = Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdEmpleado AND 
                         dbo.ro_empleado.IdEmpresa = Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdEmpresa AND 
                         dbo.ro_empleado.IdEmpleado = Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdEmpleado

WHERE        (dbo.ro_rubro_tipo.ru_tipo !='A')
and ro_rubro_tipo.rub_noafecta =1
and ro_rol_detalle.IdEmpresa=@IdEmpresa
and ro_rol_detalle.IdNominaTipo=@IdNomina
and pe_anio=@Anio
and pe_mes=@Mes
and ro_rol_detalle.IdEmpresa=@IdEmpresa
and ro_rol_detalle.idempleado=@IdEmpleado
and Valor>0
and ro_rol_detalle.IdRubro!=24
and ro_rol_detalle.IdEmpleado=@IdEmpleado
and isnull(Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdPeriodo,@IdPeriodo)=@IdPeriodo

GROUP BY dbo.ro_rol_detalle.IdEmpresa, dbo.ro_rol_detalle.IdNominaTipo, dbo.ro_periodo.pe_anio, dbo.ro_periodo.pe_mes, dbo.tb_persona.pe_cedulaRuc, dbo.tb_persona.pe_apellido + ' ' + dbo.tb_persona.pe_nombre, 
                         dbo.ro_rubro_tipo.ru_descripcion, dbo.ro_cargo.ca_descripcion, Fj_servindustrias.ro_zona.zo_descripcion, Fj_servindustrias.ro_fuerza.fu_descripcion, dbo.ro_rubro_tipo.ru_orden, 
                         dbo.ro_rol_detalle.IdEmpleado, dbo.ro_rubro_tipo.ru_tipo,ro_rol_detalle.IdRubro

union


--  RUBROS QUE AFECTAN A ROL sueldo del fin de mes
SELECT        dbo.ro_rol_detalle.IdEmpresa, dbo.ro_rol_detalle.IdNominaTipo, dbo.ro_periodo.pe_anio, dbo.ro_periodo.pe_mes, dbo.tb_persona.pe_cedulaRuc, 
                         dbo.tb_persona.pe_apellido + ' ' + dbo.tb_persona.pe_nombre AS Nombres, dbo.ro_rubro_tipo.ru_descripcion, dbo.ro_cargo.ca_descripcion, Fj_servindustrias.ro_zona.zo_descripcion, 
                         Fj_servindustrias.ro_fuerza.fu_descripcion, '1', dbo.ro_rol_detalle.Valor Expr1, dbo.ro_rol_detalle.IdEmpleado, dbo.ro_rubro_tipo.ru_tipo,
@DiasTrabajados,@Quincena,@FindeMes,ISNULL(@variable,0),ISNULL( @FondoReserva,0)
FROM            dbo.tb_persona INNER JOIN
                         dbo.ro_periodo_x_ro_Nomina_TipoLiqui INNER JOIN
                         dbo.ro_periodo ON dbo.ro_periodo_x_ro_Nomina_TipoLiqui.IdEmpresa = dbo.ro_periodo.IdEmpresa AND dbo.ro_periodo_x_ro_Nomina_TipoLiqui.IdPeriodo = dbo.ro_periodo.IdPeriodo INNER JOIN
                         dbo.ro_rol_detalle INNER JOIN
                         dbo.ro_empleado ON dbo.ro_rol_detalle.IdEmpresa = dbo.ro_empleado.IdEmpresa AND dbo.ro_rol_detalle.IdEmpleado = dbo.ro_empleado.IdEmpleado ON 
                         dbo.ro_periodo_x_ro_Nomina_TipoLiqui.IdEmpresa = dbo.ro_rol_detalle.IdEmpresa AND dbo.ro_periodo_x_ro_Nomina_TipoLiqui.IdNomina_Tipo = dbo.ro_rol_detalle.IdNominaTipo AND 
                         dbo.ro_periodo_x_ro_Nomina_TipoLiqui.IdNomina_TipoLiqui = dbo.ro_rol_detalle.IdNominaTipoLiqui AND dbo.ro_periodo_x_ro_Nomina_TipoLiqui.IdPeriodo = dbo.ro_rol_detalle.IdPeriodo INNER JOIN
                         dbo.ro_rubro_tipo ON dbo.ro_rol_detalle.IdEmpresa = dbo.ro_rubro_tipo.IdEmpresa AND dbo.ro_rol_detalle.IdRubro = dbo.ro_rubro_tipo.IdRubro INNER JOIN
                         dbo.ro_cargo ON dbo.ro_empleado.IdEmpresa = dbo.ro_cargo.IdEmpresa AND dbo.ro_empleado.IdCargo = dbo.ro_cargo.IdCargo ON dbo.tb_persona.IdPersona = dbo.ro_empleado.IdPersona AND 
                         dbo.tb_persona.IdPersona = dbo.ro_empleado.IdPersona AND dbo.tb_persona.IdPersona = dbo.ro_empleado.IdPersona AND dbo.tb_persona.IdPersona = dbo.ro_empleado.IdPersona AND 
                         dbo.tb_persona.IdPersona = dbo.ro_empleado.IdPersona LEFT OUTER JOIN
                         Fj_servindustrias.ro_fuerza INNER JOIN
                         Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det ON Fj_servindustrias.ro_fuerza.IdEmpresa = Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdEmpresa AND 
                         Fj_servindustrias.ro_fuerza.IdFuerza = Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdFuerza AND 
                         Fj_servindustrias.ro_fuerza.IdEmpresa = Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdEmpresa AND 
                         Fj_servindustrias.ro_fuerza.IdFuerza = Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdFuerza AND 
                         Fj_servindustrias.ro_fuerza.IdEmpresa = Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdEmpresa AND 
                         Fj_servindustrias.ro_fuerza.IdFuerza = Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdFuerza AND 
                         Fj_servindustrias.ro_fuerza.IdEmpresa = Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdEmpresa AND 
                         Fj_servindustrias.ro_fuerza.IdFuerza = Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdFuerza AND 
                         Fj_servindustrias.ro_fuerza.IdEmpresa = Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdEmpresa AND 
                         Fj_servindustrias.ro_fuerza.IdFuerza = Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdFuerza INNER JOIN
                         Fj_servindustrias.ro_zona ON Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdEmpresa = Fj_servindustrias.ro_zona.IdEmpresa AND 
                         Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdZona = Fj_servindustrias.ro_zona.IdZona AND 
                         Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdEmpresa = Fj_servindustrias.ro_zona.IdEmpresa AND 
                         Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdZona = Fj_servindustrias.ro_zona.IdZona AND 
                         Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdEmpresa = Fj_servindustrias.ro_zona.IdEmpresa AND 
                         Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdZona = Fj_servindustrias.ro_zona.IdZona AND 
                         Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdEmpresa = Fj_servindustrias.ro_zona.IdEmpresa AND 
                         Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdZona = Fj_servindustrias.ro_zona.IdZona AND 
                         Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdEmpresa = Fj_servindustrias.ro_zona.IdEmpresa AND 
                         Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdZona = Fj_servindustrias.ro_zona.IdZona ON 
                         dbo.ro_empleado.IdEmpresa = Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdEmpresa AND 
                         dbo.ro_empleado.IdEmpleado = Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdEmpleado AND 
                         dbo.ro_empleado.IdEmpresa = Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdEmpresa AND 
                         dbo.ro_empleado.IdEmpleado = Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdEmpleado AND 
                         dbo.ro_empleado.IdEmpresa = Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdEmpresa AND 
                         dbo.ro_empleado.IdEmpleado = Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdEmpleado

WHERE        (dbo.ro_rubro_tipo.ru_tipo !='A')
--and ro_rol_detalle.idrubro!=1047
and ro_rubro_tipo.rub_noafecta =1
and ro_rol_detalle.IdEmpresa=@IdEmpresa
and ro_rol_detalle.IdNominaTipo=@IdNomina
and pe_anio=@Anio
and pe_mes=@Mes
and ro_rol_detalle.IdEmpresa=@IdEmpresa
and ro_rol_detalle.idempleado=@IdEmpleado
and Valor>0
and ro_rol_detalle.IdNominaTipoLiqui=2
and ro_rol_detalle.IdRubro=24
and ro_rol_detalle.IdEmpleado=@IdEmpleado
and isnull(Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdPeriodo,@IdPeriodo)=@IdPeriodo
--and IdDivision=2


UNION



SELECT        dbo.ro_rol_detalle.IdEmpresa, dbo.ro_rol_detalle.IdNominaTipo, dbo.ro_periodo.pe_anio, dbo.ro_periodo.pe_mes, dbo.tb_persona.pe_cedulaRuc, 
                         dbo.tb_persona.pe_apellido + ' ' + dbo.tb_persona.pe_nombre AS Nombres, 'PAGO DE VARIABLE', dbo.ro_cargo.ca_descripcion, Fj_servindustrias.ro_zona.zo_descripcion, 
                         Fj_servindustrias.ro_fuerza.fu_descripcion, dbo.ro_rubro_tipo.ru_orden, SUM(dbo.ro_rol_detalle.Valor) AS Expr1, dbo.ro_rol_detalle.IdEmpleado, 'I',
@DiasTrabajados,@Quincena,@FindeMes,ISNULL(@variable,0),ISNULL( @FondoReserva,0)
FROM            dbo.tb_persona INNER JOIN
                         dbo.ro_periodo_x_ro_Nomina_TipoLiqui INNER JOIN
                         dbo.ro_periodo ON dbo.ro_periodo_x_ro_Nomina_TipoLiqui.IdEmpresa = dbo.ro_periodo.IdEmpresa AND dbo.ro_periodo_x_ro_Nomina_TipoLiqui.IdPeriodo = dbo.ro_periodo.IdPeriodo INNER JOIN
                         dbo.ro_rol_detalle INNER JOIN
                         dbo.ro_empleado ON dbo.ro_rol_detalle.IdEmpresa = dbo.ro_empleado.IdEmpresa AND dbo.ro_rol_detalle.IdEmpleado = dbo.ro_empleado.IdEmpleado ON 
                         dbo.ro_periodo_x_ro_Nomina_TipoLiqui.IdEmpresa = dbo.ro_rol_detalle.IdEmpresa AND dbo.ro_periodo_x_ro_Nomina_TipoLiqui.IdNomina_Tipo = dbo.ro_rol_detalle.IdNominaTipo AND 
                         dbo.ro_periodo_x_ro_Nomina_TipoLiqui.IdNomina_TipoLiqui = dbo.ro_rol_detalle.IdNominaTipoLiqui AND dbo.ro_periodo_x_ro_Nomina_TipoLiqui.IdPeriodo = dbo.ro_rol_detalle.IdPeriodo INNER JOIN
                         dbo.ro_rubro_tipo ON dbo.ro_rol_detalle.IdEmpresa = dbo.ro_rubro_tipo.IdEmpresa AND dbo.ro_rol_detalle.IdRubro = dbo.ro_rubro_tipo.IdRubro INNER JOIN
                         dbo.ro_cargo ON dbo.ro_empleado.IdEmpresa = dbo.ro_cargo.IdEmpresa AND dbo.ro_empleado.IdCargo = dbo.ro_cargo.IdCargo ON dbo.tb_persona.IdPersona = dbo.ro_empleado.IdPersona AND 
                         dbo.tb_persona.IdPersona = dbo.ro_empleado.IdPersona AND dbo.tb_persona.IdPersona = dbo.ro_empleado.IdPersona AND dbo.tb_persona.IdPersona = dbo.ro_empleado.IdPersona AND 
                         dbo.tb_persona.IdPersona = dbo.ro_empleado.IdPersona LEFT OUTER JOIN
                         Fj_servindustrias.ro_fuerza INNER JOIN
                         Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det ON Fj_servindustrias.ro_fuerza.IdEmpresa = Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdEmpresa AND 
                         Fj_servindustrias.ro_fuerza.IdFuerza = Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdFuerza AND 
                         Fj_servindustrias.ro_fuerza.IdEmpresa = Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdEmpresa AND 
                         Fj_servindustrias.ro_fuerza.IdFuerza = Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdFuerza AND 
                         Fj_servindustrias.ro_fuerza.IdEmpresa = Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdEmpresa AND 
                         Fj_servindustrias.ro_fuerza.IdFuerza = Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdFuerza AND 
                         Fj_servindustrias.ro_fuerza.IdEmpresa = Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdEmpresa AND 
                         Fj_servindustrias.ro_fuerza.IdFuerza = Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdFuerza AND 
                         Fj_servindustrias.ro_fuerza.IdEmpresa = Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdEmpresa AND 
                         Fj_servindustrias.ro_fuerza.IdFuerza = Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdFuerza INNER JOIN
                         Fj_servindustrias.ro_zona ON Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdEmpresa = Fj_servindustrias.ro_zona.IdEmpresa AND 
                         Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdZona = Fj_servindustrias.ro_zona.IdZona AND 
                         Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdEmpresa = Fj_servindustrias.ro_zona.IdEmpresa AND 
                         Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdZona = Fj_servindustrias.ro_zona.IdZona AND 
                         Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdEmpresa = Fj_servindustrias.ro_zona.IdEmpresa AND 
                         Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdZona = Fj_servindustrias.ro_zona.IdZona AND 
                         Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdEmpresa = Fj_servindustrias.ro_zona.IdEmpresa AND 
                         Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdZona = Fj_servindustrias.ro_zona.IdZona AND 
                         Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdEmpresa = Fj_servindustrias.ro_zona.IdEmpresa AND 
                         Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdZona = Fj_servindustrias.ro_zona.IdZona ON 
                         dbo.ro_empleado.IdEmpresa = Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdEmpresa AND 
                         dbo.ro_empleado.IdEmpleado = Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdEmpleado AND 
                         dbo.ro_empleado.IdEmpresa = Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdEmpresa AND 
                         dbo.ro_empleado.IdEmpleado = Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdEmpleado AND 
                         dbo.ro_empleado.IdEmpresa = Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdEmpresa AND 
                         dbo.ro_empleado.IdEmpleado = Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdEmpleado
WHERE       -- (dbo.ro_rol_detalle.IdRubro >= 983) AND (dbo.ro_rol_detalle.IdRubro <= 991) 

ro_rol_detalle.IdRubro=994
and dbo.ro_rol_detalle.Valor>0
and ro_rol_detalle.IdEmpresa=@IdEmpresa
and ro_rol_detalle.IdNominaTipo=@IdNomina
and pe_anio=@Anio
and pe_mes=@Mes
and ro_rol_detalle.IdEmpresa=@IdEmpresa
and ro_rol_detalle.idempleado=@IdEmpleado
and isnull(Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det.IdPeriodo,@IdPeriodo)=@IdPeriodo
and ro_rol_detalle.IdEmpleado=@IdEmpleado
--and IdDivision=2

GROUP BY dbo.ro_rol_detalle.IdEmpresa, dbo.ro_rol_detalle.IdNominaTipo, dbo.ro_periodo.pe_anio, dbo.ro_periodo.pe_mes, dbo.tb_persona.pe_cedulaRuc, dbo.tb_persona.pe_apellido + ' ' + dbo.tb_persona.pe_nombre, 
                         dbo.ro_cargo.ca_descripcion, Fj_servindustrias.ro_zona.zo_descripcion, Fj_servindustrias.ro_fuerza.fu_descripcion, dbo.ro_rubro_tipo.ru_orden, 
                         dbo.ro_rol_detalle.IdEmpleado, dbo.ro_rubro_tipo.ru_tipo






END