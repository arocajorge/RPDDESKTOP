
CREATE PROCEDURE [Fj_servindustrias].[spro_mano_obra_servindustria]  
	@IdEmpresa int,	
	@Idperiodo int

AS
/*
declare
    @IdEmpresa int,
	@Idperiodo int
	

	set @IdEmpresa=1
	set @Idperiodo=201707
	
	*/
BEGIN


SELECT        empleado.IdEmpresa, empleado.IdEmpleado, emp_af.IdActivo_fijo, fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo.IdCentroCosto IdCentroCosto, fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo.IdCentroCosto_sub_centro_costo IdCentroCosto_sub_centro_costo, persona.pe_cedulaRuc, persona.pe_apellido+' '+ persona.pe_nombre Empleado, 
                         dbo.Af_Activo_fijo.Af_DescripcionCorta, cargo.ca_descripcion,
						 (select Valor from ro_rol_detalle R where R.IdEmpresa=empleado.IdEmpresa and R.IdEmpleado=empleado.IdEmpleado  and R.IdPeriodo=@Idperiodo and R.IdEmpresa=@IdEmpresa and R.IdRubro=24 and IdNominaTipoLiqui=2) as salario,
						 (select Valor from ro_rol_detalle R where R.IdEmpresa=empleado.IdEmpresa and R.IdEmpleado=empleado.IdEmpleado and R.IdPeriodo=@Idperiodo and R.IdEmpresa=@IdEmpresa and R.IdRubro=966 and IdNominaTipoLiqui=2) as horasExtras,
						 (select Valor from ro_rol_detalle R where R.IdEmpresa=empleado.IdEmpresa  and R.IdEmpleado=empleado.IdEmpleado and R.IdPeriodo=@Idperiodo and R.IdEmpresa=@IdEmpresa and R.IdRubro=74 and IdNominaTipoLiqui=2) as alimentacion,
						  (select Valor from ro_rol_detalle R where R.IdEmpresa=empleado.IdEmpresa and R.IdEmpleado=empleado.IdEmpleado and R.IdPeriodo=@Idperiodo and R.IdEmpresa=@IdEmpresa and R.IdRubro=4 and IdNominaTipoLiqui=2) as totalIngresos,
						  cargo.IdCargo,vwro_rol_detalle_agrupado_x_proceso. IdPeriodo, dbo.ct_centro_costo.Centro_costo, dbo.ct_centro_costo_sub_centro_costo.Centro_costo AS SubCentroCosto

FROM            dbo.ro_empleado AS empleado INNER JOIN
                         Fj_servindustrias.ro_empleado_x_Activo_Fijo AS emp_af ON empleado.IdEmpresa = emp_af.IdEmpresa AND empleado.IdEmpleado = emp_af.IdEmpleado INNER JOIN
                         dbo.ro_cargo AS cargo ON empleado.IdEmpresa = cargo.IdEmpresa AND empleado.IdCargo = cargo.IdCargo INNER JOIN
                         dbo.tb_persona AS persona ON empleado.IdPersona = persona.IdPersona INNER JOIN
                         dbo.Af_Activo_fijo ON emp_af.IdEmpresa = dbo.Af_Activo_fijo.IdEmpresa AND emp_af.IdActivo_fijo = dbo.Af_Activo_fijo.IdActivoFijo AND emp_af.IdEmpresa = dbo.Af_Activo_fijo.IdEmpresa AND 
                         emp_af.IdActivo_fijo = dbo.Af_Activo_fijo.IdActivoFijo AND emp_af.IdEmpresa = dbo.Af_Activo_fijo.IdEmpresa AND emp_af.IdActivo_fijo = dbo.Af_Activo_fijo.IdActivoFijo AND emp_af.IdEmpresa = dbo.Af_Activo_fijo.IdEmpresa AND
                          emp_af.IdActivo_fijo = dbo.Af_Activo_fijo.IdActivoFijo INNER JOIN
                         dbo.vwro_rol_detalle_agrupado_x_proceso ON empleado.IdEmpresa = dbo.vwro_rol_detalle_agrupado_x_proceso.IdEmpresa AND empleado.IdEmpleado = dbo.vwro_rol_detalle_agrupado_x_proceso.IdEmpleado INNER JOIN
                         dbo.ct_centro_costo INNER JOIN
                         dbo.ct_centro_costo_sub_centro_costo ON dbo.ct_centro_costo.IdEmpresa = dbo.ct_centro_costo_sub_centro_costo.IdEmpresa AND 
                         dbo.ct_centro_costo.IdCentroCosto = dbo.ct_centro_costo_sub_centro_costo.IdCentroCosto INNER JOIN
                         Fj_servindustrias.fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo ON 
                         dbo.ct_centro_costo_sub_centro_costo.IdCentroCosto_sub_centro_costo = Fj_servindustrias.fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo.IdCentroCosto_sub_centro_costo AND 
                         dbo.ct_centro_costo_sub_centro_costo.IdCentroCosto = Fj_servindustrias.fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo.IdCentroCosto AND 
                         dbo.ct_centro_costo_sub_centro_costo.IdEmpresa = Fj_servindustrias.fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo.IdEmpresa AND 
                         dbo.ct_centro_costo_sub_centro_costo.IdCentroCosto_sub_centro_costo = Fj_servindustrias.fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo.IdCentroCosto_sub_centro_costo AND 
                         dbo.ct_centro_costo_sub_centro_costo.IdCentroCosto = Fj_servindustrias.fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo.IdCentroCosto AND 
                         dbo.ct_centro_costo_sub_centro_costo.IdEmpresa = Fj_servindustrias.fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo.IdEmpresa AND 
                         dbo.ct_centro_costo_sub_centro_costo.IdCentroCosto_sub_centro_costo = Fj_servindustrias.fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo.IdCentroCosto_sub_centro_costo AND 
                         dbo.ct_centro_costo_sub_centro_costo.IdCentroCosto = Fj_servindustrias.fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo.IdCentroCosto AND 
                         dbo.ct_centro_costo_sub_centro_costo.IdEmpresa = Fj_servindustrias.fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo.IdEmpresa AND 
                         dbo.ct_centro_costo_sub_centro_costo.IdCentroCosto_sub_centro_costo = Fj_servindustrias.fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo.IdCentroCosto_sub_centro_costo AND 
                         dbo.ct_centro_costo_sub_centro_costo.IdCentroCosto = Fj_servindustrias.fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo.IdCentroCosto AND 
                         dbo.ct_centro_costo_sub_centro_costo.IdEmpresa = Fj_servindustrias.fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo.IdEmpresa AND 
                         dbo.ct_centro_costo_sub_centro_costo.IdCentroCosto_sub_centro_costo = Fj_servindustrias.fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo.IdCentroCosto_sub_centro_costo AND 
                         dbo.ct_centro_costo_sub_centro_costo.IdCentroCosto = Fj_servindustrias.fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo.IdCentroCosto AND 
                         dbo.ct_centro_costo_sub_centro_costo.IdEmpresa = Fj_servindustrias.fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo.IdEmpresa AND 
                         dbo.ct_centro_costo_sub_centro_costo.IdCentroCosto_sub_centro_costo = Fj_servindustrias.fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo.IdCentroCosto_sub_centro_costo AND 
                         dbo.ct_centro_costo_sub_centro_costo.IdCentroCosto = Fj_servindustrias.fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo.IdCentroCosto AND 
                         dbo.ct_centro_costo_sub_centro_costo.IdEmpresa = Fj_servindustrias.fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo.IdEmpresa ON 
                         emp_af.IdEmpresa = Fj_servindustrias.fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo.IdEmpresa AND emp_af.IdActivo_fijo = Fj_servindustrias.fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo.IdActivoFijo						
						 where vwro_rol_detalle_agrupado_x_proceso.IdPeriodo=@Idperiodo
						 and vwro_rol_detalle_agrupado_x_proceso.IdEmpresa=@idempresa
						 and vwro_rol_detalle_agrupado_x_proceso.IdNominaTipoLiqui=2
/*
						 union

SELECT                 ta_x_cl_x_af.IdEmpresa, NULL Idempleado, NULL IdActivoFijo, ta_x_cl_x_af.IdCentroCosto,ta_x_cl_x_af.IdCentroCosto_sub_centro_costo, 'SUPERVISOR MECANICO 'Cedula,'SUPERVISOR 'Cedula, ''AfDesctipcionCprta,'' ca_descripcion, 0 salario,0 horasextras, 0 alimentacion, (( ValorFacturar/TotalEquipos)* COUNT(ta_x_cl_x_af.IdActivoFijo)) totalingresos,NULL idcargo,IdPeriodo, cc.Centro_costo ,sub_c.Centro_costo
FROM            Fj_servindustrias.fa_pre_facturacion AS pref INNER JOIN
                         Fj_servindustrias.fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo AS ta_x_cl_x_af ON pref.IdEmpresa = ta_x_cl_x_af.IdEmpresa AND pref.IdCentroCosto = ta_x_cl_x_af.IdCentroCosto INNER JOIN
                         dbo.ct_centro_costo_sub_centro_costo AS sub_c ON ta_x_cl_x_af.IdEmpresa = sub_c.IdEmpresa AND ta_x_cl_x_af.IdCentroCosto = sub_c.IdCentroCosto AND 
                         ta_x_cl_x_af.IdCentroCosto_sub_centro_costo = sub_c.IdCentroCosto_sub_centro_costo AND ta_x_cl_x_af.IdEmpresa = sub_c.IdEmpresa AND ta_x_cl_x_af.IdCentroCosto = sub_c.IdCentroCosto AND 
                         ta_x_cl_x_af.IdCentroCosto_sub_centro_costo = sub_c.IdCentroCosto_sub_centro_costo INNER JOIN
                         dbo.ct_centro_costo AS cc ON sub_c.IdEmpresa = cc.IdEmpresa AND sub_c.IdCentroCosto = cc.IdCentroCosto AND sub_c.IdEmpresa = cc.IdEmpresa AND sub_c.IdCentroCosto = cc.IdCentroCosto

where IdPeriodo=@Idperiodo
and ta_x_cl_x_af.IdEmpresa=@IdEmpresa
and ta_x_cl_x_af.IdActivoFijo in (select E.IdActivo_fijo from Fj_servindustrias.ro_empleado_x_Activo_Fijo E where E.IdEmpresa=ta_x_cl_x_af.IdEmpresa and E.IdActivo_fijo=ta_x_cl_x_af.IdActivoFijo)
GROUP BY ta_x_cl_x_af.IdEmpresa, ta_x_cl_x_af.IdCentroCosto, ta_x_cl_x_af.IdCentroCosto_sub_centro_costo, cc.Centro_costo, sub_c.Centro_costo, TotalEquipos, ValorFacturar, IdPeriodo
*/
END