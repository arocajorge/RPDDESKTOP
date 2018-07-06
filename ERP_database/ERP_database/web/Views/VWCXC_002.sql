CREATE VIEW web.VWCXC_002
AS
SELECT        cxc_cobro_det.IdEmpresa, cxc_cobro_det.IdSucursal, cxc_cobro_det.IdCobro, cxc_cobro_det.secuencial, cxc_cobro_det.dc_TipoDocumento, cxc_cobro_det.IdBodega_Cbte, cxc_cobro_det.IdCbte_vta_nota, 
                         cxc_cobro_tipo.tc_descripcion, cxc_cobro_det.dc_ValorPago, tb_sucursal.Su_Descripcion, ISNULL(fa_cliente_contactos.Nombres, tb_persona.pe_nombreCompleto) AS pe_nombreCompleto, cxc_cobro.cr_fecha, 
                         cxc_cobro.cr_TotalCobro, cxc_cobro.cr_observacion, cxc_cobro.cr_NumDocumento, 
						 CASE WHEN fa_factura.vt_NumFactura IS NULL THEN fa_notaCreDeb.CodDocumentoTipo + '-'+ isnull( fa_notaCreDeb.NumNota_Impresa,fa_notaCreDeb.CodNota) else fa_factura.vt_tipoDoc+'-'+ cast(cast(fa_factura.vt_NumFactura as numeric) as varchar(20)) end as vt_NumFactura,
						 isnull(fa_factura.vt_fecha, fa_notaCreDeb.no_fecha) as vt_fecha,
						 isnull(fd.vt_Subtotal,nd.vt_Subtotal) vt_Subtotal,
						 isnull(fd.vt_iva,nd.vt_iva) vt_iva,
						 isnull(fd.vt_total,nd.vt_total) vt_total
FROM            cxc_cobro INNER JOIN
                         cxc_cobro_det ON cxc_cobro.IdEmpresa = cxc_cobro_det.IdEmpresa AND cxc_cobro.IdSucursal = cxc_cobro_det.IdSucursal AND cxc_cobro.IdCobro = cxc_cobro_det.IdCobro INNER JOIN
                         cxc_cobro_tipo ON cxc_cobro_det.IdCobro_tipo = cxc_cobro_tipo.IdCobro_tipo INNER JOIN
                         tb_sucursal ON cxc_cobro_det.IdEmpresa = tb_sucursal.IdEmpresa AND cxc_cobro_det.IdSucursal = tb_sucursal.IdSucursal LEFT OUTER JOIN
                         fa_factura INNER JOIN
                         fa_cliente_contactos ON fa_factura.IdContacto = fa_cliente_contactos.IdContacto AND fa_factura.IdCliente = fa_cliente_contactos.IdCliente AND fa_factura.IdEmpresa = fa_cliente_contactos.IdEmpresa ON 
                         cxc_cobro_det.IdEmpresa = fa_factura.IdEmpresa AND cxc_cobro_det.IdSucursal = fa_factura.IdSucursal AND cxc_cobro_det.IdBodega_Cbte = fa_factura.IdBodega AND cxc_cobro_det.IdCbte_vta_nota = fa_factura.IdCbteVta AND
                          cxc_cobro_det.dc_TipoDocumento = fa_factura.vt_tipoDoc LEFT OUTER JOIN
                         fa_cliente INNER JOIN
                         fa_notaCreDeb ON fa_cliente.IdEmpresa = fa_notaCreDeb.IdEmpresa AND fa_cliente.IdCliente = fa_notaCreDeb.IdCliente INNER JOIN
                         tb_persona ON fa_cliente.IdPersona = tb_persona.IdPersona ON cxc_cobro_det.IdEmpresa = fa_notaCreDeb.IdEmpresa AND cxc_cobro_det.IdSucursal = fa_notaCreDeb.IdSucursal AND 
                         cxc_cobro_det.IdBodega_Cbte = fa_notaCreDeb.IdBodega AND cxc_cobro_det.IdCbte_vta_nota = fa_notaCreDeb.IdNota AND cxc_cobro_det.dc_TipoDocumento = fa_notaCreDeb.CodDocumentoTipo
						 inner join (
							SELECT IdEmpresa, IdSucursal, IdBodega, IdCbteVta, sum(vt_Subtotal) vt_Subtotal, sum(vt_iva) vt_iva, sum(vt_total) vt_total
							FROM fa_factura_det
							group by IdEmpresa, IdSucursal, IdBodega, IdCbteVta
						 ) as fd on fa_factura.IdEmpresa = fd.IdEmpresa and fa_factura.IdSucursal = fd.IdSucursal and fa_factura.IdBodega = fd.IdBodega and fa_factura.IdCbteVta = fd.IdCbteVta
						 inner join (
							SELECT IdEmpresa, IdSucursal, IdBodega, IdNota, sum(sc_subtotal) vt_Subtotal, sum(sc_iva) vt_iva, sum(sc_total) vt_total
							FROM fa_notaCreDeb_det
							group by IdEmpresa, IdSucursal, IdBodega, IdNota
						 ) as nd on fa_notaCreDeb.IdEmpresa = nd.IdEmpresa and fa_notaCreDeb.IdSucursal = nd.IdSucursal and fa_notaCreDeb.IdBodega = nd.IdBodega and fa_notaCreDeb.IdNota = nd.IdNota
WHERE        (cxc_cobro.IdCobro_tipo IS NULL)