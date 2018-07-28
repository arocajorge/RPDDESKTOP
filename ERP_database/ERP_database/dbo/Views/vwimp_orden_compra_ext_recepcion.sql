CREATE VIEW dbo.vwimp_orden_compra_ext_recepcion
AS
SELECT        dbo.imp_orden_compra_ext_recepcion.IdRecepcion, dbo.imp_orden_compra_ext_recepcion.or_fecha, dbo.imp_orden_compra_ext_recepcion.or_observacion, dbo.imp_orden_compra_ext_recepcion.IdEmpresa_oc, 
                         dbo.imp_orden_compra_ext_recepcion.IdOrdenCompraExt, dbo.imp_orden_compra_ext_recepcion.IdEmpresa_inv, dbo.imp_orden_compra_ext_recepcion.IdSucursal_inv, 
                         dbo.imp_orden_compra_ext_recepcion.IdMovi_inven_tipo_inv, dbo.imp_orden_compra_ext_recepcion.IdNumMovi_inv, dbo.imp_orden_compra_ext_recepcion.estado, dbo.tb_persona.pe_nombreCompleto, 
                         dbo.tb_persona.pe_cedulaRuc, dbo.imp_orden_compra_ext_recepcion.IdEmpresa, dbo.imp_orden_compra_ext_recepcion.IdBodega, dbo.imp_orden_compra_ext.IdCatalogo_via, dbo.imp_orden_compra_ext.IdCiudad_destino, 
                         dbo.imp_orden_compra_ext.IdCatalogo_forma_pago, dbo.imp_orden_compra_ext.oe_fecha, dbo.imp_orden_compra_ext.oe_fecha_llegada_est, dbo.imp_orden_compra_ext.oe_fecha_embarque_est, 
                         dbo.imp_orden_compra_ext_recepcion.IdMotivo_Inv
FROM            dbo.imp_orden_compra_ext_recepcion INNER JOIN
                         dbo.imp_orden_compra_ext ON dbo.imp_orden_compra_ext_recepcion.IdEmpresa_oc = dbo.imp_orden_compra_ext.IdEmpresa AND 
                         dbo.imp_orden_compra_ext_recepcion.IdOrdenCompraExt = dbo.imp_orden_compra_ext.IdOrdenCompra_ext INNER JOIN
                         dbo.cp_proveedor ON dbo.imp_orden_compra_ext.IdEmpresa = dbo.cp_proveedor.IdEmpresa AND dbo.imp_orden_compra_ext.IdProveedor = dbo.cp_proveedor.IdProveedor INNER JOIN
                         dbo.tb_persona ON dbo.cp_proveedor.IdPersona = dbo.tb_persona.IdPersona
