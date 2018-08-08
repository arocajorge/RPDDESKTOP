CREATE VIEW [dbo].[vwimp_liquidacion_det_x_imp_orden_compra_ext]
	AS 

	SELECT        dbo.imp_liquidacion_det_x_imp_orden_compra_ext.IdEmpresa, dbo.imp_liquidacion_det_x_imp_orden_compra_ext.IdLiquidacion, dbo.imp_liquidacion_det_x_imp_orden_compra_ext.IdEmpresa_oe, 
                         dbo.imp_liquidacion_det_x_imp_orden_compra_ext.IdOrdenCompra_ext, dbo.imp_liquidacion_det_x_imp_orden_compra_ext.observacion, dbo.imp_orden_compra_ext.oe_observacion, dbo.imp_orden_compra_ext.oe_fecha, 
                         dbo.tb_persona.pe_cedulaRuc, dbo.tb_persona.pe_nombreCompleto, dbo.imp_orden_compra_ext.IdMoneda_origen, dbo.imp_orden_compra_ext.IdMoneda_destino, dbo.imp_orden_compra_ext.Estado_cierre, 
                         dbo.imp_orden_compra_ext.IdPais_embarque, dbo.imp_orden_compra_ext.IdCiudad_destino, dbo.imp_orden_compra_ext.IdCatalogo_via, dbo.imp_orden_compra_ext.IdCatalogo_forma_pago
FROM            dbo.imp_orden_compra_ext INNER JOIN
                         dbo.imp_liquidacion_det_x_imp_orden_compra_ext ON dbo.imp_orden_compra_ext.IdEmpresa = dbo.imp_liquidacion_det_x_imp_orden_compra_ext.IdEmpresa_oe AND 
                         dbo.imp_orden_compra_ext.IdOrdenCompra_ext = dbo.imp_liquidacion_det_x_imp_orden_compra_ext.IdOrdenCompra_ext INNER JOIN
                         dbo.cp_proveedor ON dbo.imp_orden_compra_ext.IdEmpresa = dbo.cp_proveedor.IdEmpresa AND dbo.imp_orden_compra_ext.IdProveedor = dbo.cp_proveedor.IdProveedor INNER JOIN
                         dbo.tb_persona ON dbo.cp_proveedor.IdPersona = dbo.tb_persona.IdPersona