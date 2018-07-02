CREATE VIEW web.VWCXC_001
AS
SELECT cxc_cobro_det.IdEmpresa, cxc_cobro_det.IdSucursal, cxc_cobro_det.IdCobro, cxc_cobro_det.secuencial, cxc_cobro_det.IdBodega_Cbte, cxc_cobro_det.IdCbte_vta_nota, cxc_cobro_det.dc_TipoDocumento, cxc_cobro_det.dc_ValorPago, 
                  cxc_cobro_tipo.tc_descripcion, tb_persona.IdPersona, tb_persona.pe_nombreCompleto,fa_factura.vt_serie1 +'-'+ fa_factura.vt_serie2 +'-'+  fa_factura.vt_NumFactura vt_NumFactura, fa_factura.vt_fecha, fa_factura.vt_Observacion AS ObservacionFact, cxc_cobro.cr_observacion AS ObservacionCobro, 
                  cxc_cobro.cr_fecha, fa_cliente_contactos.Nombres AS NombreContacto, fa_cliente_contactos.Direccion, fa_cliente_contactos.Correo, tb_persona.pe_cedulaRuc, cxc_cobro.cr_estado, tb_sucursal.Su_Descripcion, 
                  tb_banco.ba_descripcion, cr_NumDocumento, cxc_cobro.cr_TotalCobro
FROM     fa_factura INNER JOIN
                  cxc_cobro_det INNER JOIN
                  cxc_cobro ON cxc_cobro_det.IdEmpresa = cxc_cobro.IdEmpresa AND cxc_cobro_det.IdSucursal = cxc_cobro.IdSucursal AND cxc_cobro_det.IdCobro = cxc_cobro.IdCobro INNER JOIN
                  cxc_cobro_tipo ON cxc_cobro.IdCobro_tipo = cxc_cobro_tipo.IdCobro_tipo INNER JOIN
                  fa_cliente ON cxc_cobro.IdEmpresa = fa_cliente.IdEmpresa AND cxc_cobro.IdCliente = fa_cliente.IdCliente INNER JOIN
                  tb_persona ON fa_cliente.IdPersona = tb_persona.IdPersona ON fa_factura.IdEmpresa = cxc_cobro_det.IdEmpresa AND fa_factura.IdSucursal = cxc_cobro_det.IdSucursal AND fa_factura.IdBodega = cxc_cobro_det.IdBodega_Cbte AND 
                  fa_factura.IdCbteVta = cxc_cobro_det.IdCbte_vta_nota AND fa_factura.vt_tipoDoc = cxc_cobro_det.dc_TipoDocumento INNER JOIN
                  fa_cliente_contactos ON fa_factura.IdContacto = fa_cliente_contactos.IdContacto AND fa_factura.IdCliente = fa_cliente_contactos.IdCliente AND fa_factura.IdEmpresa = fa_cliente_contactos.IdEmpresa INNER JOIN
                  tb_sucursal ON cxc_cobro.IdEmpresa = tb_sucursal.IdEmpresa AND cxc_cobro.IdSucursal = tb_sucursal.IdSucursal LEFT OUTER JOIN
                  tb_banco ON cxc_cobro.IdBanco = tb_banco.IdBanco