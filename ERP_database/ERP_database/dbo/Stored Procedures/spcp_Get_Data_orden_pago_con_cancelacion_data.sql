﻿--exec [dbo].[spcp_Get_Data_orden_pago_con_cancelacion_data] 1,1195,1195,'PROVEE',212,212,'APRO','admin',0
CREATE PROCEDURE [dbo].[spcp_Get_Data_orden_pago_con_cancelacion_data]
(
@IdEmpresa int,
@IdPersona_ini numeric,
@IdPersona_fin numeric,
@IdTipoPersona varchar(10),
@IdEntidad_ini numeric,
@IdEntidad_fin numeric,
@IdEstado_Aprobacion varchar(10),
@IdUsuario varchar(20),
@mostrar_saldo_0 bit
)
AS
BEGIN
delete cp_orden_pago_con_cancelacion_data where IdUsuario = @IdUsuario

INSERT INTO [dbo].[cp_orden_pago_con_cancelacion_data]
           ([IdUsuario]					           ,[IdEmpresa]					           ,[IdTipo_op]						       ,[Referencia]			           ,[Referencia2]
           ,[IdOrdenPago]				           ,[Secuencia_OP]				           ,[IdTipoPersona]						   ,[IdPersona]				           ,[IdEntidad]
           ,[Fecha_OP]					           ,[Fecha_Fa_Prov]				           ,[Fecha_Venc_Fac_Prov]			       ,[Observacion]			           ,[Nom_Beneficiario]
           ,[Girar_Cheque_a]			           ,[Valor_a_pagar]				           ,[Valor_estimado_a_pagar_OP]	           ,[Total_cancelado_OP]	           ,[Saldo_x_Pagar_OP]
           ,[IdEstadoAprobacion]		           ,[IdFormaPago]				           ,[Fecha_Pago]				           ,[IdCtaCble]				           ,[IdCentroCosto]
           ,[IdSubCentro_Costo]			           ,[Cbte_cxp]					           ,[Estado]					           ,[Nom_Beneficiario_2]	           ,[IdEmpresa_cxp]
           ,[IdTipoCbte_cxp]			           ,[IdCbteCble_cxp]			           ,[IdBanco])
select		@IdUsuario, cp_orden_pago.IdEmpresa, cp_orden_pago.IdTipo_op, cp_orden_pago_det.Referencia AS Expr1, cp_orden_pago_det.Referencia AS Expr2, cp_orden_pago.IdOrdenPago, cp_orden_pago_det.Secuencia, cp_orden_pago.IdTipo_Persona, cp_orden_pago.IdPersona, cp_orden_pago.IdEntidad, 
                  cp_orden_pago.Fecha, cp_orden_pago.Fecha AS Expr3, cp_orden_pago.Fecha AS Expr4, cp_orden_pago.Observacion, NULL AS Expr5, NULL AS Expr6, cp_orden_pago_det.Valor_a_pagar, cp_orden_pago_det.Valor_a_pagar AS valor_estimado_a_pagar, 
                  ISNULL(SUM(cp_orden_pago_cancelaciones.MontoAplicado),0) AS MontoAplicado, cp_orden_pago_det.Valor_a_pagar - ISNULL(SUM(cp_orden_pago_cancelaciones.MontoAplicado), 0) AS saldo, cp_orden_pago.IdEstadoAprobacion, 
                  cp_orden_pago.IdFormaPago, cp_orden_pago.Fecha_Pago, NULL AS IdCtaCble, NULL AS Expr7, NULL AS Expr8, NULL AS Expr10, cp_orden_pago.Estado, NULL AS Expr9, cp_orden_pago_det.IdEmpresa_cxp, 
                  cp_orden_pago_det.IdTipoCbte_cxp, cp_orden_pago_det.IdCbteCble_cxp, cp_orden_pago.IdBanco
FROM     cp_orden_pago INNER JOIN
                  cp_orden_pago_det ON cp_orden_pago.IdEmpresa = cp_orden_pago_det.IdEmpresa AND cp_orden_pago.IdOrdenPago = cp_orden_pago_det.IdOrdenPago LEFT JOIN
                  cp_orden_pago_cancelaciones ON cp_orden_pago_det.IdEmpresa = cp_orden_pago_cancelaciones.IdEmpresa_op AND cp_orden_pago_det.IdOrdenPago = cp_orden_pago_cancelaciones.IdOrdenPago_op AND 
                  cp_orden_pago_det.Secuencia = cp_orden_pago_cancelaciones.Secuencia_op
WHERE cp_orden_pago.IdEmpresa = @IdEmpresa and cp_orden_pago.IdTipo_Persona like '%'+@IdTipoPersona+'%' and cp_orden_pago.IdEntidad between @IdEntidad_ini and @IdEntidad_fin
and cp_orden_pago.IdEstadoAprobacion = @IdEstado_Aprobacion and cp_orden_pago.IdPersona between @IdPersona_ini and @IdPersona_fin AND cp_orden_pago.Estado = 'A'
GROUP BY cp_orden_pago.IdEmpresa, cp_orden_pago.IdTipo_op,cp_orden_pago_det.Referencia, cp_orden_pago.IdOrdenPago, cp_orden_pago_det.Secuencia, cp_orden_pago.IdTipo_Persona, cp_orden_pago.IdPersona, cp_orden_pago.IdEntidad, cp_orden_pago.Fecha, 
                  cp_orden_pago.Observacion, cp_orden_pago_det.Valor_a_pagar, cp_orden_pago.IdEstadoAprobacion, cp_orden_pago.IdFormaPago, cp_orden_pago.Fecha_Pago, cp_orden_pago_det.IdCbteCble_cxp, cp_orden_pago.Estado, 
                  cp_orden_pago_det.IdEmpresa_cxp, cp_orden_pago_det.IdTipoCbte_cxp, cp_orden_pago.IdBanco
--HAVING ROUND(cp_orden_pago_det.Valor_a_pagar - ISNULL(SUM(cp_orden_pago_cancelaciones.MontoAplicado), 0),2) > 0

if(@mostrar_saldo_0 = 0)
BEGIN
	DELETE cp_orden_pago_con_cancelacion_data WHERE @IdUsuario = IdUsuario and Saldo_x_Pagar_OP = 0
END

update [cp_orden_pago_con_cancelacion_data] 
set 
 Nom_Beneficiario=ben.pe_apellido+' '+ben.pe_nombre
,Girar_Cheque_a=ben.pr_girar_cheque_a
,IdCtaCble=ben.IdCtaCble
,Nom_Beneficiario_2=ben.Nombre
FROM            cp_orden_pago_con_cancelacion_data AS data INNER JOIN
                         vwtb_persona_beneficiario AS ben ON data.IdEmpresa = ben.IdEmpresa AND data.IdTipoPersona = ben.IdTipo_Persona 
						 AND data.IdPersona = ben.IdPersona AND data.IdEntidad = ben.IdEntidad
where data.IdUsuario = @IdUsuario

update [cp_orden_pago_con_cancelacion_data] 
set Referencia=doc.Codigo+'#' + CAST( CAST( OG.co_factura AS NUMERIC)  AS VARCHAR(20))
,Referencia2=doc.Codigo+'#' + CAST( CAST(OG.co_factura AS NUMERIC) AS VARCHAR(20))
,Fecha_Fa_Prov=OG.co_FechaFactura
,Fecha_Venc_Fac_Prov=OG.co_FechaFactura_vct
FROM            [cp_orden_pago_con_cancelacion_data]  AS data INNER JOIN
                         cp_orden_giro AS OG ON data.IdEmpresa_cxp = OG.IdEmpresa AND data.IdTipoCbte_cxp = OG.IdTipoCbte_Ogiro AND data.IdCbteCble_cxp = OG.IdCbteCble_Ogiro INNER JOIN
                         cp_TipoDocumento AS doc ON OG.IdOrden_giro_Tipo = doc.CodTipoDocumento
where data.IdUsuario = @IdUsuario

update [cp_orden_pago_con_cancelacion_data]  
set Referencia=
CASE WHEN ND.cn_Nota is NULL  or ND.cn_Nota='' THEN  +'ND#:' + cast(ND.IdCbteCble_Nota as varchar(20)) 
else 'ND#' + ND.cn_Nota
END 
,Referencia2=CASE WHEN ND.cn_Nota is NULL  or ND.cn_Nota='' THEN  +'ND#:' + cast(ND.IdCbteCble_Nota as varchar(20)) 
else 'ND#' + ND.cn_Nota
END 

,Fecha_Fa_Prov=ND.cn_fecha
,Fecha_Venc_Fac_Prov=ND.cn_Fecha_vcto

FROM            [cp_orden_pago_con_cancelacion_data]  AS data INNER JOIN
                         cp_nota_DebCre AS ND ON data.IdEmpresa_cxp = ND.IdEmpresa AND data.IdCbteCble_cxp = ND.IdCbteCble_Nota AND data.IdTipoCbte_cxp = ND.IdTipoCbte_Nota
where data.IdUsuario = @IdUsuario

update [cp_orden_pago_con_cancelacion_data]  
set Referencia='OP#' + cast([cp_orden_pago_con_cancelacion_data] .IdOrdenPago as varchar(20))
,Referencia2='OP#' + cast([cp_orden_pago_con_cancelacion_data] .IdOrdenPago as varchar(20))
,fecha_fa_prov=fecha_op
,fecha_venc_fac_prov=fecha_op
WHERE Referencia is null and @IdUsuario = IdUsuario

SELECT ISNULL(ROW_NUMBER() OVER (ORDER BY IdUsuario),0) AS IdRow, IdUsuario, IdEmpresa, IdTipo_op, Referencia, Referencia2, IdOrdenPago, Secuencia_OP, IdTipoPersona, IdPersona, IdEntidad, Fecha_OP, Fecha_Fa_Prov, Fecha_Venc_Fac_Prov, Observacion, Nom_Beneficiario, Girar_Cheque_a, 
                  Valor_a_pagar, Valor_estimado_a_pagar_OP, Total_cancelado_OP, Saldo_x_Pagar_OP, IdEstadoAprobacion, IdFormaPago, Fecha_Pago, IdCtaCble, IdCentroCosto, IdSubCentro_Costo, Cbte_cxp, Estado, Nom_Beneficiario_2, 
                  IdEmpresa_cxp, IdTipoCbte_cxp, IdCbteCble_cxp, IdBanco
FROM     cp_orden_pago_con_cancelacion_data where IdUsuario = @IdUsuario
END