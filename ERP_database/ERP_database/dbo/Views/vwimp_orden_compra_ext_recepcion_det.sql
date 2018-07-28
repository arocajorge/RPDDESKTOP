CREATE VIEW [dbo].[vwimp_orden_compra_ext_recepcion_det]
	AS 

SELECT        dbo.imp_orden_compra_ext_recepcion_det.IdEmpresa, dbo.imp_orden_compra_ext_recepcion_det.IdRecepcion, dbo.imp_orden_compra_ext_recepcion_det.secuencia, dbo.imp_orden_compra_ext_recepcion_det.IdProducto, 
                         dbo.imp_orden_compra_ext_recepcion_det.IdEmpresa_oc, dbo.imp_orden_compra_ext_recepcion_det.IdOrdenCompra_ext, dbo.imp_orden_compra_ext_recepcion_det.Secuencia_oc, 
                         dbo.imp_orden_compra_ext_recepcion_det.cantidad, dbo.imp_orden_compra_ext_recepcion_det.Observacion, dbo.imp_orden_compra_ext_det.od_cantidad, dbo.imp_orden_compra_ext_det.od_cantidad_recepcion, 
                         dbo.in_Producto.pr_descripcion, dbo.in_Producto.lote_fecha_fab, dbo.in_Producto.lote_fecha_vcto, dbo.in_Producto.lote_num_lote, dbo.imp_orden_compra_ext_det.IdUnidadMedida
FROM            dbo.imp_orden_compra_ext_recepcion_det INNER JOIN
                         dbo.imp_orden_compra_ext_det ON dbo.imp_orden_compra_ext_recepcion_det.IdEmpresa_oc = dbo.imp_orden_compra_ext_det.IdEmpresa AND 
                         dbo.imp_orden_compra_ext_recepcion_det.IdOrdenCompra_ext = dbo.imp_orden_compra_ext_det.IdOrdenCompra_ext AND 
                         dbo.imp_orden_compra_ext_recepcion_det.Secuencia_oc = dbo.imp_orden_compra_ext_det.Secuencia INNER JOIN
                         dbo.in_Producto ON dbo.imp_orden_compra_ext_det.IdEmpresa = dbo.in_Producto.IdEmpresa AND dbo.imp_orden_compra_ext_det.IdProducto = dbo.in_Producto.IdProducto