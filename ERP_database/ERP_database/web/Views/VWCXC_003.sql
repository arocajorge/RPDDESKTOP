CREATE VIEW web.VWCXC_003
AS
SELECT fa_factura.IdEmpresa, fa_factura.IdSucursal, fa_factura.IdBodega, fa_factura.IdCbteVta, fa_factura.vt_tipoDoc, fa_factura.vt_serie1+'-'+ fa_factura.vt_serie2+'-'+ fa_factura.vt_NumFactura vt_NumFactura, ltrim(rtrim(tb_persona.pe_nombreCompleto)) pe_nombreCompleto, fa_factura.IdCliente,fa_factura.vt_fecha, 
                  web.vwcxc_cobro_det_valor_retenciones.ValorRteFTE, web.vwcxc_cobro_det_valor_retenciones.ValorRteIVA, web.vwcxc_cobro_det_valor_retenciones.PorcentajeRetFTE, web.vwcxc_cobro_det_valor_retenciones.PorcentajeRetIVA, 
                   web.vwcxc_cobro_det_valor_retenciones.TotalRTE, web.vwcxc_cobro_det_valor_retenciones.cr_fecha
FROM     fa_factura INNER JOIN
                  fa_cliente ON fa_factura.IdEmpresa = fa_cliente.IdEmpresa AND fa_factura.IdCliente = fa_cliente.IdCliente INNER JOIN
                  tb_persona ON fa_cliente.IdPersona = tb_persona.IdPersona LEFT OUTER JOIN
                  web.vwcxc_cobro_det_valor_retenciones ON fa_factura.IdEmpresa = web.vwcxc_cobro_det_valor_retenciones.IdEmpresa AND fa_factura.IdSucursal = web.vwcxc_cobro_det_valor_retenciones.IdSucursal AND 
                  fa_factura.IdBodega = web.vwcxc_cobro_det_valor_retenciones.IdBodega_Cbte AND fa_factura.IdCbteVta = web.vwcxc_cobro_det_valor_retenciones.IdCbte_vta_nota AND 
                  fa_factura.vt_tipoDoc = web.vwcxc_cobro_det_valor_retenciones.dc_TipoDocumento