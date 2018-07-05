CREATE VIEW web.vwcxc_cobro_para_retencion
AS
SELECT        fa_factura_det.IdEmpresa, fa_factura_det.IdSucursal, fa_factura_det.IdBodega, fa_factura_det.IdCbteVta, fa_factura.vt_tipoDoc, SUM(fa_factura_det.vt_Subtotal) AS vt_Subtotal, SUM(fa_factura_det.vt_iva) AS vt_iva, 
                         SUM(fa_factura_det.vt_total) AS vt_total, fa_cliente_contactos.Nombres, fa_factura.vt_fecha, fa_factura.vt_fech_venc, fa_factura.vt_Observacion,
						 fa_factura.vt_tipoDoc +'-'+ cast(cast(fa_factura.vt_NumFactura as numeric) as varchar(20)) vt_NumFactura
FROM            fa_factura INNER JOIN
                         fa_factura_det ON fa_factura.IdEmpresa = fa_factura_det.IdEmpresa AND fa_factura.IdSucursal = fa_factura_det.IdSucursal AND fa_factura.IdBodega = fa_factura_det.IdBodega AND 
                         fa_factura.IdCbteVta = fa_factura_det.IdCbteVta INNER JOIN
                         fa_cliente_contactos ON fa_factura.IdEmpresa = fa_cliente_contactos.IdEmpresa AND fa_factura.IdCliente = fa_cliente_contactos.IdCliente AND fa_factura.IdContacto = fa_cliente_contactos.IdContacto
WHERE fa_factura.Estado = 'A'
GROUP BY fa_factura_det.IdEmpresa, fa_factura_det.IdSucursal, fa_factura_det.IdBodega, fa_factura_det.IdCbteVta, fa_factura.vt_tipoDoc, fa_cliente_contactos.Nombres, fa_factura.vt_fecha, fa_factura.vt_fech_venc, 
                         fa_factura.vt_Observacion, fa_factura.vt_NumFactura
UNION ALL
SELECT        fa_notaCreDeb_det.IdEmpresa, fa_notaCreDeb_det.IdSucursal, fa_notaCreDeb_det.IdBodega, fa_notaCreDeb_det.IdNota, fa_notaCreDeb.CodDocumentoTipo, SUM(fa_notaCreDeb_det.sc_subtotal) AS sc_subtotal, 
                         SUM(fa_notaCreDeb_det.sc_iva) AS sc_iva, SUM(fa_notaCreDeb_det.sc_total) AS sc_total, tb_persona.pe_nombreCompleto, fa_notaCreDeb.no_fecha, fa_notaCreDeb.no_fecha_venc, fa_notaCreDeb.sc_observacion,
						 fa_notaCreDeb.CodDocumentoTipo + '-' + case when fa_notaCreDeb.NumNota_Impresa is null then fa_notaCreDeb.CodNota else cast(cast(fa_notaCreDeb.NumNota_Impresa as numeric) as varchar(20))end as vt_NumFactura
FROM            fa_notaCreDeb INNER JOIN
                         fa_notaCreDeb_det ON fa_notaCreDeb.IdEmpresa = fa_notaCreDeb_det.IdEmpresa AND fa_notaCreDeb.IdSucursal = fa_notaCreDeb_det.IdSucursal AND fa_notaCreDeb.IdBodega = fa_notaCreDeb_det.IdBodega AND 
                         fa_notaCreDeb.IdNota = fa_notaCreDeb_det.IdNota INNER JOIN
                         fa_cliente ON fa_notaCreDeb.IdEmpresa = fa_cliente.IdEmpresa AND fa_notaCreDeb.IdCliente = fa_cliente.IdCliente INNER JOIN
                         tb_persona ON fa_cliente.IdPersona = tb_persona.IdPersona
WHERE        (fa_notaCreDeb.CreDeb = 'D')
GROUP BY fa_notaCreDeb_det.IdEmpresa, fa_notaCreDeb_det.IdSucursal, fa_notaCreDeb_det.IdBodega, fa_notaCreDeb_det.IdNota, fa_notaCreDeb.CodDocumentoTipo, tb_persona.pe_nombreCompleto, fa_notaCreDeb.no_fecha, fa_notaCreDeb.no_fecha_venc,
fa_notaCreDeb.sc_observacion, fa_notaCreDeb.CodNota, fa_notaCreDeb.NumNota_Impresa