CREATE VIEW web.vwfa_notaCreDeb_x_fa_factura_NotaDeb
AS
SELECT        not1.IdEmpresa_nt, not1.IdSucursal_nt, not1.IdBodega_nt, not1.IdNota_nt, not1.secuencia, not1.vt_tipoDoc, not1.IdSucursal_fac_nd_doc_mod, not1.IdBodega_fac_nd_doc_mod, not1.IdCbteVta_fac_nd_doc_mod, 
                         not1.Valor_Aplicado, not1.vt_tipoDoc + '-' + CAST(CAST(ISNULL(dbo.fa_factura.vt_NumFactura, dbo.fa_notaCreDeb.NumNota_Impresa) AS int) AS VARCHAR(20)) AS vt_NumFactura, ISNULL(dbo.fa_factura.vt_Observacion, 
                         dbo.fa_notaCreDeb.sc_observacion) AS vt_Observacion, ISNULL(dbo.fa_factura.CodCbteVta, dbo.fa_notaCreDeb.CodNota) AS CodDoc, ISNULL(SUM(dbo.fa_factura_det.vt_Subtotal), 0) 
                         + ISNULL(SUM(dbo.fa_notaCreDeb_det.sc_subtotal), 0) AS vt_Subtotal, ISNULL(SUM(dbo.fa_factura_det.vt_iva), 0) + ISNULL(SUM(dbo.fa_notaCreDeb_det.sc_iva), 0) AS vt_iva, ISNULL(SUM(dbo.fa_factura_det.vt_total), 0) 
                         + ISNULL(SUM(dbo.fa_notaCreDeb_det.sc_total), 0) AS vt_total, ISNULL(cobro.ValorCobrado, 0) AS ValorCobrado, ISNULL(SUM(dbo.fa_factura_det.vt_total), 0) + ISNULL(SUM(dbo.fa_notaCreDeb_det.sc_total), 0) 
                         - ISNULL(cobro.ValorCobrado, 0) AS saldo, ISNULL(SUM(dbo.fa_factura_det.vt_total), 0) + ISNULL(SUM(dbo.fa_notaCreDeb_det.sc_total), 0) - ISNULL(cobro.ValorCobrado, 0) + not1.Valor_Aplicado AS saldo_sin_cobro, 
                         ISNULL(dbo.fa_factura.vt_fecha, dbo.fa_notaCreDeb.no_fecha) AS vt_fecha, ISNULL(dbo.fa_factura.vt_fech_venc, dbo.fa_notaCreDeb.no_fecha_venc) AS vt_fech_venc, ISNULL(dbo.fa_factura.IdCliente, 
                         dbo.fa_notaCreDeb.IdCliente) AS IdCliente, ISNULL(dbo.fa_cliente_contactos.Nombres, dbo.tb_persona.pe_nombreCompleto) AS pe_nombreCompleto
FROM            dbo.fa_cliente_contactos INNER JOIN
                         dbo.fa_factura INNER JOIN
                         dbo.fa_factura_det ON dbo.fa_factura.IdEmpresa = dbo.fa_factura_det.IdEmpresa AND dbo.fa_factura.IdSucursal = dbo.fa_factura_det.IdSucursal AND dbo.fa_factura.IdBodega = dbo.fa_factura_det.IdBodega AND 
                         dbo.fa_factura.IdCbteVta = dbo.fa_factura_det.IdCbteVta ON dbo.fa_cliente_contactos.IdEmpresa = dbo.fa_factura.IdEmpresa AND dbo.fa_cliente_contactos.IdCliente = dbo.fa_factura.IdCliente AND 
                         dbo.fa_cliente_contactos.IdContacto = dbo.fa_factura.IdContacto RIGHT OUTER JOIN
                         dbo.fa_notaCreDeb_x_fa_factura_NotaDeb AS not1 ON dbo.fa_factura.IdBodega = not1.IdBodega_fac_nd_doc_mod AND dbo.fa_factura.IdEmpresa = not1.IdEmpresa_fac_nd_doc_mod AND 
                         dbo.fa_factura.IdSucursal = not1.IdSucursal_fac_nd_doc_mod AND dbo.fa_factura.IdCbteVta = not1.IdCbteVta_fac_nd_doc_mod AND dbo.fa_factura.vt_tipoDoc = not1.vt_tipoDoc LEFT OUTER JOIN
                         dbo.tb_persona INNER JOIN
                         dbo.fa_notaCreDeb_det INNER JOIN
                         dbo.fa_notaCreDeb ON dbo.fa_notaCreDeb_det.IdEmpresa = dbo.fa_notaCreDeb.IdEmpresa AND dbo.fa_notaCreDeb_det.IdSucursal = dbo.fa_notaCreDeb.IdSucursal AND 
                         dbo.fa_notaCreDeb_det.IdBodega = dbo.fa_notaCreDeb.IdBodega AND dbo.fa_notaCreDeb_det.IdNota = dbo.fa_notaCreDeb.IdNota INNER JOIN
                         dbo.fa_cliente ON dbo.fa_notaCreDeb.IdEmpresa = dbo.fa_cliente.IdEmpresa AND dbo.fa_notaCreDeb.IdCliente = dbo.fa_cliente.IdCliente ON dbo.tb_persona.IdPersona = dbo.fa_cliente.IdPersona ON 
                         not1.IdEmpresa_fac_nd_doc_mod = dbo.fa_notaCreDeb.IdEmpresa AND not1.IdSucursal_fac_nd_doc_mod = dbo.fa_notaCreDeb.IdSucursal AND not1.IdBodega_fac_nd_doc_mod = dbo.fa_notaCreDeb.IdBodega AND 
                         not1.IdCbteVta_fac_nd_doc_mod = dbo.fa_notaCreDeb.IdNota AND not1.vt_tipoDoc = dbo.fa_notaCreDeb.CodDocumentoTipo LEFT OUTER JOIN
                             (SELECT        IdEmpresa, IdSucursal, IdBodega_Cbte, IdCbte_vta_nota, dc_TipoDocumento, SUM(dc_ValorPago) AS ValorCobrado
                               FROM            dbo.cxc_cobro_det AS det
                               WHERE        (estado = 'A')
                               GROUP BY IdEmpresa, IdSucursal, IdBodega_Cbte, IdCbte_vta_nota, dc_TipoDocumento) AS cobro ON cobro.IdEmpresa = not1.IdEmpresa_fac_nd_doc_mod AND cobro.IdSucursal = not1.IdSucursal_fac_nd_doc_mod AND 
                         cobro.IdBodega_Cbte = not1.IdBodega_fac_nd_doc_mod AND cobro.IdCbte_vta_nota = not1.IdCbteVta_fac_nd_doc_mod AND cobro.dc_TipoDocumento = not1.vt_tipoDoc
GROUP BY not1.IdEmpresa_nt, not1.IdSucursal_nt, not1.IdBodega_nt, not1.IdNota_nt, not1.secuencia, not1.vt_tipoDoc, not1.IdSucursal_fac_nd_doc_mod, not1.IdBodega_fac_nd_doc_mod, not1.IdCbteVta_fac_nd_doc_mod, 
                         not1.Valor_Aplicado, dbo.fa_factura.vt_NumFactura, dbo.fa_notaCreDeb.NumNota_Impresa, dbo.fa_factura.vt_Observacion, dbo.fa_notaCreDeb.sc_observacion, dbo.fa_factura.CodCbteVta, dbo.fa_notaCreDeb.CodNota, 
                         dbo.fa_factura.vt_fecha, dbo.fa_notaCreDeb.no_fecha, dbo.fa_factura.vt_fech_venc, dbo.fa_notaCreDeb.no_fecha_venc, dbo.fa_factura.IdCliente, dbo.fa_notaCreDeb.IdCliente, not1.Valor_Aplicado, cobro.ValorCobrado, 
                         dbo.fa_cliente_contactos.Nombres, dbo.tb_persona.pe_nombreCompleto