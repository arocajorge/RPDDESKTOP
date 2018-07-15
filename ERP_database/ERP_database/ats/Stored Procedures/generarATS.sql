
create  PROCEDURE [ats].[generarATS]
@idempresa int,
@idPeriodo int
AS

--declare 
--@idempresa int,
--@idPeriodo int

--set @idperiodo=201806
--set @idempresa=1

BEGIN


--*****************************************************************************************************************************************************************++
--**************************************************************************compras*****************************************************************************+*****

declare
@fecha_inicio date,
@fecha_fin date

select @fecha_inicio=pe_FechaIni, @fecha_fin=pe_FechaFin from ct_periodo where IdEmpresa=@idempresa and IdPeriodo=@idPeriodo
delete ats.ventas where IdEmpresa=@idempresa and IdPeriodo=@idPeriodo
delete ats.compras where idempresa=@idempresa and idperiodo=@idPeriodo
delete ats.retenciones where idempresa=@idempresa and idperiodo=@idPeriodo
delete ats.comprobantes_anulados where idempresa=@idempresa and idperiodo=@idPeriodo

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
pagoLocExt,																					denopago,			
paisEfecPago,																				formaPago
)
SELECT 

 @idempresa,																				@idPeriodo,				
 ISNULL(ROW_NUMBER()OVER (ORDER BY fac.IdEmpresa), 0)AS Secuencia,							fac.IdOrden_giro_Tipo,
 CASe when perso.IdTipoDocumento='CED' THEN '02' else '01' end  tpIdProv,					perso.pe_cedulaRuc,
 00 tipoComprobante,																		'NO' AS ParteRelacionada,
CASe when perso.IdTipoDocumento='CED' THEN '01' else '02' end AS tipoProv,					perso.pe_nombreCompleto,			 
 cast(fac.co_fechaOg as date),																SUBSTRING(fac.co_serie, 0, 4) AS establecimiento, 
 SUBSTRING(fac.co_serie, 5, 4) AS puntoEmision,												fac.co_factura, 
 fac.co_FechaFactura,																		fac.Num_Autorizacion,																				 
 isnull(fac.BseImpNoObjDeIva,0.00),															fac.co_baseImponible, 
 fac.co_subtotal_iva,																		isnull(fac.BseImpNoObjDeIva,0.00),
 fac.co_Ice_valor,																			fac.co_valoriva,																					
 fac.PagoLocExt,																			f_pago.formas_pago_sri,  
 f_pago.codigo_pago_sri,																	f_pago.codigo_pago_sri
FROM            dbo.cp_orden_giro AS fac INNER JOIN
                         dbo.cp_proveedor AS prov ON fac.IdEmpresa = prov.IdEmpresa AND fac.IdProveedor = prov.IdProveedor INNER JOIN
                         dbo.tb_persona AS perso ON prov.IdPersona = perso.IdPersona LEFT OUTER JOIN
                         dbo.cp_orden_giro_pagos_sri AS f_pago ON fac.IdEmpresa = f_pago.IdEmpresa AND fac.IdCbteCble_Ogiro = f_pago.IdCbteCble_Ogiro AND fac.IdTipoCbte_Ogiro = f_pago.IdTipoCbte_Ogiro
						 
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
isnull(sum(cobros.valorRetIva),0.00),		isnull(sum(cobros.valorRetRenta),0.00),				ventas.IdFormaPago,													ventas.vt_serie1,
SUM(ventas.baseImponible+ventas.baseImpGrav),							isnull(sum(ventas.montoIva),0.00)


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
 CASe when per.IdTipoDocumento='CED' THEN '01' else '02' end AS tipoCliente, 
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
--**************************************************************************Retenciones****************************************************************+*****
insert into ats.retenciones(
IdEmpresa,																						IdPeriodo,
Secuencia,																						co_serie,
co_factura,																						Cedula_ruc,
valRetBien10,																					valRetServ20,
valorRetBienes,																					valRetServ50,
valorRetServicios,																				valRetServ100,
codRetAir,																						baseImpAir,
porcentajeAir,																					valRetAir,
estabRetencion1,																				ptoEmiRetencion1,
secRetencion1,																					autRetencion1,
fechaEmiRet1
)
SELECT
@idempresa,																						@idPeriodo,
ROW_NUMBER()OVER (ORDER BY fac.IdEmpresa),														fac.co_serie,
fac.co_factura,																					per.pe_cedulaRuc,
ISNULL(CASE WHEN ret_det.re_Porcen_retencion = '10' THEN ret_det.re_valor_retencion END, 0) AS valRetBien10,ISNULL(CASE WHEN ret_det.re_Porcen_retencion = '20' THEN ret_det.re_valor_retencion END, 0) AS valRetServ20,
ISNULL(CASE WHEN ret_det.re_Porcen_retencion = '30' THEN ret_det.re_valor_retencion END, 0) AS valorRetBienes, ISNULL(CASE WHEN ret_det.re_Porcen_retencion = '50' THEN ret_det.re_valor_retencion END, 0) AS valRetServ50, 
ISNULL(CASE WHEN ret_det.re_Porcen_retencion = '70' THEN ret_det.re_valor_retencion END, 0) AS valorRetServicios, ISNULL(CASE WHEN ret_det.re_Porcen_retencion = '100' THEN ret_det.re_valor_retencion END, 0) AS valRetServ100,
ret_det.IdCodigo_SRI,																			ret_det.re_baseRetencion,
ret_det.re_Porcen_retencion,																	ret_det.re_valor_retencion,
ret.serie1,																						ret.serie2,
ret.NumRetencion,																				ret.NAutorizacion,
cast(ret.fecha as date)																						
FROM            dbo.cp_orden_giro AS fac INNER JOIN
                         dbo.cp_retencion AS ret ON fac.IdEmpresa = ret.IdEmpresa_Ogiro AND fac.IdCbteCble_Ogiro = ret.IdCbteCble_Ogiro AND fac.IdTipoCbte_Ogiro = ret.IdTipoCbte_Ogiro INNER JOIN
                         dbo.cp_retencion_det AS ret_det ON ret.IdEmpresa = ret_det.IdEmpresa AND ret.IdRetencion = ret_det.IdRetencion INNER JOIN
                         dbo.cp_proveedor AS prov ON fac.IdEmpresa = prov.IdEmpresa AND fac.IdProveedor = prov.IdProveedor INNER JOIN
                         dbo.tb_persona AS per ON prov.IdPersona = per.IdPersona


--*****************************************************************************************************************************************************************++
--**************************************************************************comprobantes anulados****************************************************************+*****
	insert into ats.comprobantes_anulados
	(
IdEmpresa,									IdPeriodo,								Secuencia,
tipoComprobante,							Establecimiento,						puntoEmision,
secuencialInicio,							secuencialFin,							Autorización
)


select @idempresa,							@idPeriodo,								ROW_NUMBER()OVER (ORDER BY anulados.IdEmpresa),
anulados.tipoComprobante,					anulados.vt_serie1,						anulados.vt_serie2,
anulados.ini ,								anulados.fin,							anulados.NumAutorizacion
from(
select  
'01'tipoComprobante,						vt_serie1,								vt_serie2,
vt_NumFactura ini,								vt_NumFactura fin,							tb_sis_Documento_Tipo_Talonario.NumAutorizacion,fa_factura.IdEmpresa												
from fa_factura, tb_sis_Documento_Tipo_Talonario
 where fa_factura.Estado='I'
 and fa_factura.IdEmpresa=tb_sis_Documento_Tipo_Talonario.IdEmpresa
 and fa_factura.vt_serie1=tb_sis_Documento_Tipo_Talonario.Establecimiento
 and fa_factura.vt_serie2=tb_sis_Documento_Tipo_Talonario.PuntoEmision
 and fa_factura.vt_NumFactura=tb_sis_Documento_Tipo_Talonario.NumDocumento
 union
 select  
'07'tipoComprobante,						serie1,									serie2,
NumRetencion,								NumRetencion,							tb_sis_Documento_Tipo_Talonario.NumAutorizacion,cp_retencion.IdEmpresa												
from cp_retencion, tb_sis_Documento_Tipo_Talonario
 where cp_retencion.Estado='I'
 and cp_retencion.IdEmpresa=tb_sis_Documento_Tipo_Talonario.IdEmpresa
 and cp_retencion.serie1=tb_sis_Documento_Tipo_Talonario.Establecimiento
 and cp_retencion.serie2=tb_sis_Documento_Tipo_Talonario.PuntoEmision
 and cp_retencion.NumRetencion=tb_sis_Documento_Tipo_Talonario.NumDocumento

 )  anulados


 --select * from ats.ventas
 --select* from ats.compras
 --select * from ats.retenciones
END
