

CREATE procedure [Fj_servindustrias].[spROLES_Rpt011]
    @IdEmpresa int,
	@IdNomina_tipo int,
	@IdNomina_tipo_Liqui int,
	@IdPeriodo int,
	@Fecha_Inicio date,
	@Fecha_Fin date
	as
	/*
	
	declare 
	 @IdEmpresa int,
	@IdNomina_tipo int,
	@IdNomina_tipo_Liqui int,
	@IdPeriodo int,
	@Fecha_Inicio date,
	@Fecha_Fin date

	set @IdEmpresa =2
	set @IdNomina_tipo =1
	set @IdNomina_tipo_Liqui =3
	set @IdPeriodo =201706
	set @Fecha_Inicio= '01/06/2017'
	set @Fecha_Fin= '30/06/2017'
	


	*/
				

SELECT        emp.IdEmpresa, emp.IdEmpleado, person.pe_cedulaRuc, person.pe_apellido + ' ' + person.pe_nombre AS Empleado, cargo.ca_descripcion, Sueldo.SueldoActual, grupo.Valor_bono, zona.zo_descripcion, 
                         Fj_servindustrias.ro_ruta.ru_descripcion, emp.em_fechaIngaRol, emp.em_fechaSalida, emp.em_status, Fj_servindustrias.ro_fectividad_Entrega_x_Periodo_Empleado_Det.Efectividad_Entrega, 
                         Fj_servindustrias.ro_fectividad_Entrega_x_Periodo_Empleado_Det.Efectividad_Entrega_aplica, Fj_servindustrias.ro_fectividad_Entrega_x_Periodo_Empleado_Det.Efectividad_Volumen, 
                         Fj_servindustrias.ro_fectividad_Entrega_x_Periodo_Empleado_Det.Efectividad_Volumen_aplica, Fj_servindustrias.ro_fectividad_Entrega_x_Periodo_Empleado_Det.Recuperacion_cartera, 
                         Fj_servindustrias.ro_fectividad_Entrega_x_Periodo_Empleado_Det.Recuperacion_cartera_aplica, rol_det.Valor, rubro.ru_descripcion AS Rubro,
						  Fj_servindustrias.ro_fuerza.fu_descripcion,


						 
						   (select valor from ro_rol_detalle R where R.IdEmpresa=emp.idempresa 
						 and R.IdNominaTipo=rol_det.IdNominaTipo
						 and R.IdNominaTipoLiqui=rol_det.IdNominaTipoLiqui
						 and R.IdPeriodo=rol_det.IdPeriodo
						 and R.IdEmpleado=emp.idempleado
						 and R.idrubro=994
						 )variable,

						 
						   (select valor from ro_rol_detalle R where R.IdEmpresa=emp.idempresa 
						 and R.IdNominaTipo=rol_det.IdNominaTipo
						 and R.IdNominaTipoLiqui=rol_det.IdNominaTipoLiqui
						 and R.IdPeriodo=rol_det.IdPeriodo
						 and R.IdEmpleado=emp.idempleado
						 and R.idrubro=6
						 )Iess,
						 (select valor from ro_rol_detalle R where R.IdEmpresa=emp.idempresa 
						 and R.IdNominaTipo=rol_det.IdNominaTipo
						 and R.IdNominaTipoLiqui=rol_det.IdNominaTipoLiqui
						 and R.IdPeriodo=rol_det.IdPeriodo
						 and R.IdEmpleado=emp.idempleado
						 and R.idrubro=2
						 )dias_trabajados,

						 (select valor from ro_rol_detalle R where R.IdEmpresa=emp.idempresa 
						 and R.IdNominaTipo=rol_det.IdNominaTipo
						 and R.IdNominaTipoLiqui=rol_det.IdNominaTipoLiqui
						 and R.IdPeriodo=rol_det.IdPeriodo
						 and R.IdEmpleado=emp.idempleado
						 and R.idrubro=976
						 )dias_Efectivos




FROM            dbo.ro_empleado AS emp INNER JOIN
                         dbo.tb_persona AS person ON emp.IdPersona = person.IdPersona INNER JOIN
                         dbo.ro_cargo AS cargo ON emp.IdEmpresa = cargo.IdEmpresa AND emp.IdCargo = cargo.IdCargo INNER JOIN
                         dbo.vwro_sueldoActual AS Sueldo ON emp.IdEmpresa = Sueldo.IdEmpresa AND emp.IdEmpleado = Sueldo.IdEmpleado INNER JOIN
                         Fj_servindustrias.ro_Grupo_empleado AS grupo ON emp.IdEmpresa = grupo.IdEmpresa AND emp.IdGrupo = grupo.IdGrupo INNER JOIN
                         Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det AS Palnifica ON emp.IdEmpresa = Palnifica.IdEmpresa AND emp.IdEmpleado = Palnifica.IdEmpleado INNER JOIN
                         Fj_servindustrias.ro_ruta ON Palnifica.IdEmpresa = Fj_servindustrias.ro_ruta.IdEmpresa AND Palnifica.IdRuta = Fj_servindustrias.ro_ruta.IdRuta AND 
                         Palnifica.IdEmpresa = Fj_servindustrias.ro_ruta.IdEmpresa AND Palnifica.IdRuta = Fj_servindustrias.ro_ruta.IdRuta AND Palnifica.IdEmpresa = Fj_servindustrias.ro_ruta.IdEmpresa AND 
                         Palnifica.IdRuta = Fj_servindustrias.ro_ruta.IdRuta AND Palnifica.IdEmpresa = Fj_servindustrias.ro_ruta.IdEmpresa AND Palnifica.IdRuta = Fj_servindustrias.ro_ruta.IdRuta INNER JOIN
                         Fj_servindustrias.ro_zona AS zona ON Palnifica.IdEmpresa = zona.IdEmpresa AND Palnifica.IdZona = zona.IdZona AND Palnifica.IdEmpresa = zona.IdEmpresa AND Palnifica.IdZona = zona.IdZona AND 
                         Palnifica.IdEmpresa = zona.IdEmpresa AND Palnifica.IdZona = zona.IdZona AND Palnifica.IdEmpresa = zona.IdEmpresa AND Palnifica.IdZona = zona.IdZona INNER JOIN
                         Fj_servindustrias.ro_fectividad_Entrega_x_Periodo_Empleado_Det ON Palnifica.IdEmpresa = Fj_servindustrias.ro_fectividad_Entrega_x_Periodo_Empleado_Det.IdEmpresa AND 
                         Palnifica.IdNomina_Tipo = Fj_servindustrias.ro_fectividad_Entrega_x_Periodo_Empleado_Det.IdNomina_Tipo AND 
                         Palnifica.IdPeriodo = Fj_servindustrias.ro_fectividad_Entrega_x_Periodo_Empleado_Det.IdPeriodo AND 
                         Palnifica.IdEmpleado = Fj_servindustrias.ro_fectividad_Entrega_x_Periodo_Empleado_Det.IdEmpleado INNER JOIN
                         dbo.ro_rol_detalle AS rol_det ON emp.IdEmpresa = rol_det.IdEmpresa AND emp.IdEmpleado = rol_det.IdEmpleado AND 
                         Fj_servindustrias.ro_fectividad_Entrega_x_Periodo_Empleado_Det.IdEmpresa = rol_det.IdEmpresa AND 
                         Fj_servindustrias.ro_fectividad_Entrega_x_Periodo_Empleado_Det.IdNomina_Tipo = rol_det.IdNominaTipo AND 
                         Fj_servindustrias.ro_fectividad_Entrega_x_Periodo_Empleado_Det.IdNomina_tipo_Liq = rol_det.IdNominaTipoLiqui AND 
                         Fj_servindustrias.ro_fectividad_Entrega_x_Periodo_Empleado_Det.IdPeriodo = rol_det.IdPeriodo AND 
                         Fj_servindustrias.ro_fectividad_Entrega_x_Periodo_Empleado_Det.IdEmpleado = rol_det.IdEmpleado INNER JOIN
                         dbo.ro_rubro_tipo AS rubro ON rol_det.IdEmpresa = rubro.IdEmpresa AND rol_det.IdRubro = rubro.IdRubro AND rol_det.IdEmpresa = rubro.IdEmpresa AND rol_det.IdRubro = rubro.IdRubro AND 
                         rol_det.IdEmpresa = rubro.IdEmpresa AND rol_det.IdRubro = rubro.IdRubro AND rol_det.IdEmpresa = rubro.IdEmpresa AND rol_det.IdRubro = rubro.IdRubro AND rol_det.IdEmpresa = rubro.IdEmpresa AND 
                         rol_det.IdRubro = rubro.IdRubro AND rol_det.IdEmpresa = rubro.IdEmpresa AND rol_det.IdRubro = rubro.IdRubro INNER JOIN
                         Fj_servindustrias.ro_fuerza ON Palnifica.IdEmpresa = Fj_servindustrias.ro_fuerza.IdEmpresa AND Palnifica.IdFuerza = Fj_servindustrias.ro_fuerza.IdFuerza AND 
                         Palnifica.IdEmpresa = Fj_servindustrias.ro_fuerza.IdEmpresa AND Palnifica.IdFuerza = Fj_servindustrias.ro_fuerza.IdFuerza AND Palnifica.IdEmpresa = Fj_servindustrias.ro_fuerza.IdEmpresa AND 
                         Palnifica.IdFuerza = Fj_servindustrias.ro_fuerza.IdFuerza AND Palnifica.IdEmpresa = Fj_servindustrias.ro_fuerza.IdEmpresa AND Palnifica.IdFuerza = Fj_servindustrias.ro_fuerza.IdFuerza AND 
                         Palnifica.IdEmpresa = Fj_servindustrias.ro_fuerza.IdEmpresa AND Palnifica.IdFuerza = Fj_servindustrias.ro_fuerza.IdFuerza AND Palnifica.IdEmpresa = Fj_servindustrias.ro_fuerza.IdEmpresa AND 
                         Palnifica.IdFuerza = Fj_servindustrias.ro_fuerza.IdFuerza
						 where 

						rol_det.idempresa=@idempresa
						 and rol_det.IdNominaTipo=@IdNomina_tipo
						 and rol_det.IdNominaTipoLiqui=@IdNomina_tipo_Liqui
						 and rol_det.IdPeriodo=@idperiodo
						 and rol_det.Valor>0
						 and( Rubro.ru_tipo='E' or Rubro.IdRubro=950 or rubro.IdRubro=1048)