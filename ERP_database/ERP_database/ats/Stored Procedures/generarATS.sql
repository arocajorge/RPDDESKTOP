
CREATE  PROCEDURE [ats].[generarATS]
@idempresa int,
@idPeriodo int
AS

--declare 
--@idempresa int,
--@idPeriodo int

BEGIN


--*****************************************************************************************************************************************************************++
--**************************************************************************compras*****************************************************************************+*****

declare
@fecha_inicio date,
@fecha_fin date

select @fecha_inicio=pe_FechaIni, @fecha_fin=pe_FechaFin from ct_periodo where IdEmpresa=@idempresa and IdPeriodo=@idPeriodo
delete ats.ventas where IdEmpresa=@idempresa and IdPeriodo=@idPeriodo
delete ats.compras where idempresa=@idempresa and idperiodo=@idPeriodo

insert into ats.compras
(
IdEmpresa,																					IdPeriodo,			
Secuencia,																					codSustento,
tpIdProv,																					idProv,				
tipoComprobante,																			parteRel,
tipoProv,																					denopr,	
fechaRegistro,																				establecimiento,
puntoEmision,																				secuencial,			
fechaEmision,																				autorizacion,
baseNoGraIva,																				baseImponible,		
baseImpGrav,																				baseImpExe,			
montoIce,																					montoIva,			
valRetBien10,																				valRetServ20,
valorRetBienes,																				valRetServ50,
valorRetServicios,																			valRetServ100,
pagoLocExt,																					denopago,			
paisEfecPago,																				formaPago
)

SELECT 

 @idempresa,																				@idPeriodo,				
 ISNULL(ROW_NUMBER()OVER (ORDER BY fac.IdEmpresa), 0)AS Secuencia,							fac.IdOrden_giro_Tipo,
 CASe when perso.IdTipoDocumento='CED' THEN '02' else '01' end  tpIdProv,					perso.pe_cedulaRuc,
 'NO' AS ParteRelacionada,																	'R' AS tipoProv, 
 00 tipoComprobante,																		perso.pe_nombreCompleto,			 
 fac.co_fechaOg,																			SUBSTRING(fac.co_serie, 0, 4) AS establecimiento, 
 SUBSTRING(fac.co_serie, 5, 4) AS puntoEmision,												fac.co_factura, 
 fac.co_FechaFactura,																		fac.Num_Autorizacion,																				 
 fac.BseImpNoObjDeIva,																		fac.co_subtotal_siniva, 
 fac.co_subtotal_iva,																		fac.BseImpNoObjDeIva,
 fac.co_Ice_valor,																			 fac.co_valoriva,																					
 ISNULL(CASE WHEN ret_det.re_Porcen_retencion = '10' THEN ret_det.re_valor_retencion END, 0) AS valRetBien10,ISNULL(CASE WHEN ret_det.re_Porcen_retencion = '20' THEN ret_det.re_valor_retencion END, 0) AS valRetServ20,
 ISNULL(CASE WHEN ret_det.re_Porcen_retencion = '30' THEN ret_det.re_valor_retencion END, 0) AS valorRetBienes, ISNULL(CASE WHEN ret_det.re_Porcen_retencion = '50' THEN ret_det.re_valor_retencion END, 0) AS valRetServ50, 
 ISNULL(CASE WHEN ret_det.re_Porcen_retencion = '70' THEN ret_det.re_valor_retencion END, 0) AS valorRetServicios, ISNULL(CASE WHEN ret_det.re_Porcen_retencion = '100' THEN ret_det.re_valor_retencion END, 0) AS valRetServ100,
 fac.PagoLocExt,																			 fac.PaisPago,  
 f_pago.formas_pago_sri,																	 f_pago.codigo_pago_sri
FROM            dbo.cp_retencion_det AS ret_det INNER JOIN
                         dbo.cp_retencion AS ret ON ret_det.IdEmpresa = ret.IdEmpresa AND ret_det.IdRetencion = ret.IdRetencion RIGHT OUTER JOIN
                         dbo.cp_orden_giro AS fac INNER JOIN
                         dbo.cp_proveedor AS prov ON fac.IdEmpresa = prov.IdEmpresa AND fac.IdProveedor = prov.IdProveedor INNER JOIN
                         dbo.tb_persona AS perso ON prov.IdPersona = perso.IdPersona LEFT OUTER JOIN
                         dbo.cp_orden_giro_pagos_sri AS f_pago ON fac.IdEmpresa = f_pago.IdEmpresa AND fac.IdCbteCble_Ogiro = f_pago.IdCbteCble_Ogiro AND fac.IdTipoCbte_Ogiro = f_pago.IdTipoCbte_Ogiro ON 
                         ret.IdEmpresa_Ogiro = fac.IdEmpresa AND ret.IdCbteCble_Ogiro = fac.IdCbteCble_Ogiro AND ret.IdTipoCbte_Ogiro = fac.IdTipoCbte_Ogiro
						 where fac.IdEmpresa=@idempresa
						 and fac.co_fechaOg between @fecha_inicio and @fecha_fin
						 



--*****************************************************************************************************************************************************************++
--**************************************************************************VENTAS*****************************************************************************+*****

insert into ats.ventas
(IdEmpresa,									IdPeriodo,											Secuencia,															tpIdCliente,
idCliente,									parteRel,											tipoCliente,														DenoCli,									
tipoComprobante,							tipoEm,												numeroComprobantes,													baseNoGraIva,
baseImponible,								baseImpGrav,										montoIva,															montoIce,
valorRetIva,								valorRetRenta,										formaPago,															codEstab,
ventasEstab,								ivaComp)
select 

@idempresa,									@idPeriodo,											ROW_NUMBER()OVER (ORDER BY ventas.IdEmpresa),						ventas.tpIdCliente,
ventas.idCliente,							ventas.parteRel,									ventas.tipoCliente,													ventas.pe_nombreCompleto,
ventas.tipoEmtipoComprobante,				ventas.tipoEm,										count(ventas.IdCbteVta),											sum(ventas.baseNoGraIva),
sum(ventas.baseImponible),					sum(ventas.baseImpGrav),							SUM(ventas.montoIva),												sum(ventas.montoIce),
sum(cobros.valorRetIva),					sum(cobros.valorRetRenta),							ventas.IdFormaPago,													ventas.vt_serie1,
ventas.vt_serie2,							sum(ventas.montoIva)


from(
SELECT        
fac.IdEmpresa,
fac.IdSucursal,
fac.IdBodega,
fac.IdCbteVta,
fac.IdCliente,

 CASE WHEN per.IdTipoDocumento = 'CED' THEN '02' ELSE '01' END AS tpIdCliente,
 per.pe_cedulaRuc, 
 'NO' AS parteRel, 
 '01' AS tipoCliente, 
 per.pe_nombreCompleto, 
 '18' AS tipoEmtipoComprobante, 
 'F' AS tipoEm,
 0.00 as baseNoGraIva,
isnull(CASe when fac_det.vt_por_iva=0 then SUM( fac_det.vt_Subtotal)end,0.00) baseImponible,
isnull(CASe when fac_det.vt_por_iva>0 then SUM( fac_det.vt_Subtotal) end ,0.00)baseImpGrav,
sum(fac_det.vt_iva)montoIva,
0.00 montoIce,
fac.vt_serie1,
fac.vt_serie2,
fac.vt_NumFactura,
f_pago.IdFormaPago



FROM            dbo.fa_factura AS fac INNER JOIN
                         dbo.fa_factura_det AS fac_det ON fac.IdEmpresa = fac_det.IdEmpresa AND fac.IdSucursal = fac_det.IdSucursal AND fac.IdBodega = fac_det.IdBodega AND fac.IdCbteVta = fac_det.IdCbteVta INNER JOIN
                         dbo.fa_cliente AS cli ON fac.IdEmpresa = cli.IdEmpresa AND fac.IdCliente = cli.IdCliente INNER JOIN
                         dbo.tb_persona AS per ON cli.IdPersona = per.IdPersona INNER JOIN
                         dbo.fa_formaPago AS f_pago ON cli.FormaPago = f_pago.IdFormaPago
GROUP BY per.pe_cedulaRuc, per.pe_nombreCompleto,per.IdTipoDocumento, fac_det.vt_por_iva, fac.IdEmpresa,fac.IdCliente,
fac.IdSucursal,
fac.IdBodega,
fac.IdCbteVta,
fac.vt_serie1,
fac.vt_serie2,
fac.vt_NumFactura,
f_pago.IdFormaPago
) ventas
left join
(
select  cxc_cobro.idempresa,cxc_cobro.IdSucursal, IdBodega_Cbte,IdCbte_vta_nota, cxc_cobro.idCliente,
isnull( case when SUBSTRING( cxc_cobro_det.IdCobro_tipo,0,5)= 'RTFT'then sum(dc_ValorPago) end,0.00) valorRetRenta,
isnull(case when SUBSTRING( cxc_cobro_det.IdCobro_tipo,0,5)= 'RTIV'then sum(dc_ValorPago) end,0.00) valorRetIva
 from cxc_cobro_det, cxc_cobro_tipo, cxc_cobro
 where cxc_cobro_det.IdCobro_tipo=cxc_cobro_tipo.IdCobro_tipo
 and cxc_cobro_det.IdEmpresa=cxc_cobro.IdEmpresa
 and cxc_cobro_det.IdCobro=cxc_cobro.IdCobro
 and cxc_cobro_tipo.IdMotivo_tipo_cobro='RET'
 GROUP by cxc_cobro.idempresa,cxc_cobro.IdSucursal, IdBodega_Cbte,IdCbte_vta_nota,sUBSTRING( cxc_cobro_det.IdCobro_tipo,0,5),cxc_cobro.IdCliente
 ) as cobros
 on ventas.IdEmpresa=cobros.IdEmpresa
 and ventas.IdSucursal=cobros.IdSucursal
 and ventas.IdBodega=cobros.IdBodega_Cbte
 and ventas.IdCbteVta=cobros.IdCbte_vta_nota
 and ventas.idcliente=cobros.IdCliente

 group by ventas.IdEmpresa,ventas.tpIdCliente,ventas.parteRel,ventas.tipoCliente,ventas.tipoEmtipoComprobante,ventas.tipoEm,ventas.IdFormaPago,ventas.vt_serie1, ventas.vt_serie2, ventas.IdCliente, ventas.pe_nombreCompleto, ventas.pe_cedulaRuc

 
--*****************************************************************************************************************************************************************++
--**************************************************************************comprobantes anulados****************************************************************+*****
	insert into ats.comprobantes_anulados
	(
IdEmpresa,									IdPeriodo,								Secuencia,
tipoComprobante,							Establecimiento,						puntoEmision,
secuencialInicio,							secuencialFin,							Autorización
)



select  
@idempresa,									@idPeriodo,								ROW_NUMBER()OVER (ORDER BY fa_factura.IdEmpresa),
'01'tipoComprobante,						vt_serie1,								vt_serie2,
vt_NumFactura,								vt_NumFactura,							tb_sis_Documento_Tipo_Talonario.NumAutorizacion													
from fa_factura, tb_sis_Documento_Tipo_Talonario
 where fa_factura.Estado='I'
 and fa_factura.IdEmpresa=tb_sis_Documento_Tipo_Talonario.IdEmpresa
 and fa_factura.vt_serie1=tb_sis_Documento_Tipo_Talonario.Establecimiento
 and fa_factura.vt_serie2=tb_sis_Documento_Tipo_Talonario.PuntoEmision
 and fa_factura.vt_NumFactura=tb_sis_Documento_Tipo_Talonario.NumDocumento
 union
 select  
@idempresa,									@idPeriodo,								ROW_NUMBER()OVER (ORDER BY cp_retencion.IdEmpresa),
'01'tipoComprobante,						serie1,								serie2,
NumRetencion,								NumRetencion,							tb_sis_Documento_Tipo_Talonario.NumAutorizacion													
from cp_retencion, tb_sis_Documento_Tipo_Talonario
 where cp_retencion.Estado='I'
 and cp_retencion.IdEmpresa=tb_sis_Documento_Tipo_Talonario.IdEmpresa
 and cp_retencion.serie1=tb_sis_Documento_Tipo_Talonario.Establecimiento
 and cp_retencion.serie2=tb_sis_Documento_Tipo_Talonario.PuntoEmision
 and cp_retencion.NumRetencion=tb_sis_Documento_Tipo_Talonario.NumDocumento
END