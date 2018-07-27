CREATE VIEW dbo.vwimp_orden_compra_ext
AS
SELECT        dbo.imp_orden_compra_ext.IdEmpresa, dbo.imp_orden_compra_ext.IdOrdenCompra_ext, dbo.imp_orden_compra_ext.IdProveedor, dbo.imp_orden_compra_ext.IdPais_origen, dbo.imp_orden_compra_ext.IdPais_embarque, 
                         dbo.imp_orden_compra_ext.IdCiudad_destino, dbo.imp_orden_compra_ext.IdCatalogo_via, dbo.imp_orden_compra_ext.oe_fecha, dbo.imp_orden_compra_ext.oe_fecha_llegada_est, 
                         dbo.imp_orden_compra_ext.oe_fecha_embarque_est, dbo.imp_orden_compra_ext.oe_fecha_desaduanizacion_est, dbo.imp_orden_compra_ext.IdCtaCble_importacion, dbo.imp_orden_compra_ext.oe_observacion, 
                         dbo.imp_orden_compra_ext.oe_codigo, dbo.imp_orden_compra_ext.estado, dbo.imp_orden_compra_ext.IdLiquidacion, dbo.imp_orden_compra_ext.oe_fecha_llegada, dbo.imp_orden_compra_ext.oe_fecha_embarque, 
                         dbo.imp_orden_compra_ext.oe_fecha_desaduanizacion, dbo.tb_persona.pe_nombreCompleto, dbo.tb_persona.pe_cedulaRuc, dbo.vwimp_orden_compra_ext_con_saldo.cantidad_x_recibir, 
                         dbo.vwimp_orden_compra_ext_con_saldo.cantidad_global, dbo.imp_orden_compra_ext.IdCatalogo_forma_pago, dbo.imp_orden_compra_ext.IdMoneda_origen, dbo.imp_orden_compra_ext.IdMoneda_destino
FROM            dbo.imp_orden_compra_ext INNER JOIN
                         dbo.cp_proveedor ON dbo.imp_orden_compra_ext.IdEmpresa = dbo.cp_proveedor.IdEmpresa AND dbo.imp_orden_compra_ext.IdProveedor = dbo.cp_proveedor.IdProveedor INNER JOIN
                         dbo.tb_persona ON dbo.cp_proveedor.IdPersona = dbo.tb_persona.IdPersona INNER JOIN
                         dbo.vwimp_orden_compra_ext_con_saldo ON dbo.imp_orden_compra_ext.IdEmpresa = dbo.vwimp_orden_compra_ext_con_saldo.IdEmpresa AND 
                         dbo.imp_orden_compra_ext.IdOrdenCompra_ext = dbo.vwimp_orden_compra_ext_con_saldo.IdOrdenCompra_ext