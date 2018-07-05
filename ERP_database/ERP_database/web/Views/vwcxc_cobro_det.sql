CREATE VIEW WEB.vwcxc_cobro_det
AS
SELECT cxc_cobro_det.IdEmpresa, cxc_cobro_det.IdSucursal, cxc_cobro_det.IdCobro, cxc_cobro_det.secuencial, cxc_cobro_det.dc_TipoDocumento, cxc_cobro_det.IdBodega_Cbte, cxc_cobro_det.IdCbte_vta_nota, cxc_cobro_det.dc_ValorPago, 
                  cxc_cobro_det.IdCobro_tipo, cxc_cobro_det.dc_TipoDocumento + '-' + CAST(CAST(ISNULL(fa_factura.vt_NumFactura, fa_notaCreDeb.NumNota_Impresa) AS int) AS VARCHAR(20)) AS vt_NumFactura, ISNULL(fa_factura.vt_Observacion, 
                  fa_notaCreDeb.sc_observacion) AS vt_Observacion, ISNULL(fa_factura.CodCbteVta, fa_notaCreDeb.CodNota) AS CodDoc, 
				  isnull(SUM(fa_factura_det.vt_Subtotal),0) + isnull(sum(fa_notaCreDeb_det.sc_subtotal),0) AS vt_Subtotal, 
				  isnull(SUM(fa_factura_det.vt_iva),0) + isnull(sum(fa_notaCreDeb_det.sc_iva),0) AS vt_iva, 
                  isnull(SUM(fa_factura_det.vt_total),0) + isnull(sum(fa_notaCreDeb_det.sc_total),0) AS vt_total, 
				  isnull(ValorCobrado,0) as ValorCobrado,
				  isnull(SUM(fa_factura_det.vt_total),0) + isnull(sum(fa_notaCreDeb_det.sc_total),0) - isnull(ValorCobrado,0) as saldo,
				  isnull(SUM(fa_factura_det.vt_total),0) + isnull(sum(fa_notaCreDeb_det.sc_total),0) - isnull(ValorCobrado,0) + cxc_cobro_det.dc_ValorPago as saldo_sin_cobro,
				  isnull(fa_factura.vt_fecha,fa_notaCreDeb.no_fecha )vt_fecha, 
				  isnull(fa_factura.vt_fech_venc, fa_notaCreDeb.no_fecha_venc)vt_fech_venc, 
				  isnull(fa_factura.IdCliente,fa_notaCreDeb.IdCliente) IdCliente				  
FROM     cxc_cobro_det LEFT OUTER JOIN
                  fa_notaCreDeb_det INNER JOIN
                  fa_notaCreDeb ON fa_notaCreDeb_det.IdEmpresa = fa_notaCreDeb.IdEmpresa AND fa_notaCreDeb_det.IdSucursal = fa_notaCreDeb.IdSucursal AND fa_notaCreDeb_det.IdBodega = fa_notaCreDeb.IdBodega AND 
                  fa_notaCreDeb_det.IdNota = fa_notaCreDeb.IdNota ON cxc_cobro_det.IdEmpresa = fa_notaCreDeb.IdEmpresa AND cxc_cobro_det.IdSucursal = fa_notaCreDeb.IdSucursal AND 
                  cxc_cobro_det.IdBodega_Cbte = fa_notaCreDeb.IdBodega AND cxc_cobro_det.IdCbte_vta_nota = fa_notaCreDeb.IdNota AND cxc_cobro_det.dc_TipoDocumento = fa_notaCreDeb.CodDocumentoTipo LEFT OUTER JOIN
                  fa_factura INNER JOIN
                  fa_factura_det ON fa_factura.IdEmpresa = fa_factura_det.IdEmpresa AND fa_factura.IdSucursal = fa_factura_det.IdSucursal AND fa_factura.IdBodega = fa_factura_det.IdBodega AND fa_factura.IdCbteVta = fa_factura_det.IdCbteVta ON 
                  cxc_cobro_det.IdEmpresa = fa_factura.IdEmpresa AND cxc_cobro_det.IdSucursal = fa_factura.IdSucursal AND cxc_cobro_det.IdBodega_Cbte = fa_factura.IdBodega AND cxc_cobro_det.IdCbte_vta_nota = fa_factura.IdCbteVta AND 
                  cxc_cobro_det.dc_TipoDocumento = fa_factura.vt_tipoDoc left join (
				  select IdEmpresa, IdSucursal, IdBodega_Cbte, IdCbte_vta_nota, dc_TipoDocumento, sum(dc_ValorPago) ValorCobrado from cxc_cobro_det as det
				  where det.estado = 'A'
				  group by IdEmpresa, IdSucursal, IdBodega_Cbte, IdCbte_vta_nota, dc_TipoDocumento
				  ) AS cobro on cobro.IdEmpresa = cxc_cobro_det.IdEmpresa
				  and cobro.IdSucursal = cxc_cobro_det.IdSucursal
				  and cobro.IdBodega_Cbte = cxc_cobro_det.IdBodega_Cbte
				  and cobro.IdCbte_vta_nota = cxc_cobro_det.IdCbte_vta_nota
				  and cobro.dc_TipoDocumento = cxc_cobro_det.dc_TipoDocumento
GROUP BY cxc_cobro_det.IdEmpresa, cxc_cobro_det.IdSucursal, cxc_cobro_det.IdCobro, cxc_cobro_det.secuencial, cxc_cobro_det.dc_TipoDocumento, cxc_cobro_det.IdBodega_Cbte, cxc_cobro_det.IdCbte_vta_nota, 
                  cxc_cobro_det.dc_ValorPago, cxc_cobro_det.IdCobro_tipo, fa_factura.vt_NumFactura, fa_notaCreDeb.NumNota_Impresa, fa_factura.vt_Observacion, fa_notaCreDeb.sc_observacion, fa_factura.CodCbteVta, fa_notaCreDeb.CodNota, 
                  fa_factura.vt_fecha,fa_notaCreDeb.no_fecha, fa_factura.vt_fech_venc, fa_notaCreDeb.no_fecha_venc, fa_factura.IdCliente,fa_notaCreDeb.IdCliente,cxc_cobro_det.dc_ValorPago, ValorCobrado