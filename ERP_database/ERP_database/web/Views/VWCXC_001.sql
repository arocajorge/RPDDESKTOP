CREATE VIEW web.VWCXC_001
AS
SELECT dbo.cxc_cobro_det.IdEmpresa, dbo.cxc_cobro_det.IdSucursal, dbo.cxc_cobro_det.IdCobro, dbo.cxc_cobro_det.secuencial, dbo.cxc_cobro_det.IdBodega_Cbte, dbo.cxc_cobro_det.IdCbte_vta_nota, dbo.cxc_cobro_det.dc_TipoDocumento, 
                  dbo.cxc_cobro_det.dc_ValorPago, dbo.cxc_cobro_tipo.tc_descripcion, dbo.tb_persona.IdPersona, dbo.tb_persona.pe_nombreCompleto, 
                  dbo.fa_factura.vt_serie1 + '-' + dbo.fa_factura.vt_serie2 + '-' + dbo.fa_factura.vt_NumFactura AS vt_NumFactura, dbo.fa_factura.vt_fecha, dbo.fa_factura.vt_Observacion AS ObservacionFact, 
                  dbo.cxc_cobro.cr_observacion AS ObservacionCobro, dbo.cxc_cobro.cr_fecha, dbo.fa_cliente_contactos.Nombres AS NombreContacto, dbo.fa_cliente_contactos.Direccion, dbo.fa_cliente_contactos.Correo, 
                  dbo.tb_persona.pe_cedulaRuc, dbo.cxc_cobro.cr_estado, dbo.tb_sucursal.Su_Descripcion, dbo.cxc_cobro.cr_Banco as ba_descripcion, dbo.cxc_cobro.cr_NumDocumento, dbo.cxc_cobro.cr_TotalCobro
FROM     dbo.fa_factura INNER JOIN
                  dbo.cxc_cobro_det INNER JOIN
                  dbo.cxc_cobro ON dbo.cxc_cobro_det.IdEmpresa = dbo.cxc_cobro.IdEmpresa AND dbo.cxc_cobro_det.IdSucursal = dbo.cxc_cobro.IdSucursal AND dbo.cxc_cobro_det.IdCobro = dbo.cxc_cobro.IdCobro INNER JOIN
                  dbo.cxc_cobro_tipo ON dbo.cxc_cobro.IdCobro_tipo = dbo.cxc_cobro_tipo.IdCobro_tipo INNER JOIN
                  dbo.fa_cliente ON dbo.cxc_cobro.IdEmpresa = dbo.fa_cliente.IdEmpresa AND dbo.cxc_cobro.IdCliente = dbo.fa_cliente.IdCliente INNER JOIN
                  dbo.tb_persona ON dbo.fa_cliente.IdPersona = dbo.tb_persona.IdPersona ON dbo.fa_factura.IdEmpresa = dbo.cxc_cobro_det.IdEmpresa AND dbo.fa_factura.IdSucursal = dbo.cxc_cobro_det.IdSucursal AND 
                  dbo.fa_factura.IdBodega = dbo.cxc_cobro_det.IdBodega_Cbte AND dbo.fa_factura.IdCbteVta = dbo.cxc_cobro_det.IdCbte_vta_nota AND dbo.fa_factura.vt_tipoDoc = dbo.cxc_cobro_det.dc_TipoDocumento INNER JOIN
                  dbo.fa_cliente_contactos ON dbo.fa_factura.IdContacto = dbo.fa_cliente_contactos.IdContacto AND dbo.fa_factura.IdCliente = dbo.fa_cliente_contactos.IdCliente AND 
                  dbo.fa_factura.IdEmpresa = dbo.fa_cliente_contactos.IdEmpresa INNER JOIN
                  dbo.tb_sucursal ON dbo.cxc_cobro.IdEmpresa = dbo.tb_sucursal.IdEmpresa AND dbo.cxc_cobro.IdSucursal = dbo.tb_sucursal.IdSucursal