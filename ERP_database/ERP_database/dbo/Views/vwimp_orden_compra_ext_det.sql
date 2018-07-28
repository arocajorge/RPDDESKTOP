CREATE VIEW [dbo].[vwimp_orden_compra_ext_det]
	AS 

	SELECT        dbo.imp_orden_compra_ext_det.IdEmpresa, dbo.imp_orden_compra_ext_det.IdOrdenCompra_ext, dbo.imp_orden_compra_ext_det.Secuencia, dbo.imp_orden_compra_ext_det.IdProducto, 
                         dbo.imp_orden_compra_ext_det.IdUnidadMedida, dbo.imp_orden_compra_ext_det.od_cantidad, dbo.imp_orden_compra_ext_det.od_costo, dbo.imp_orden_compra_ext_det.od_por_descuento, 
                         dbo.imp_orden_compra_ext_det.od_descuento, dbo.imp_orden_compra_ext_det.od_costo_final, dbo.imp_orden_compra_ext_det.od_subtotal, dbo.imp_orden_compra_ext_det.od_cantidad_recepcion, 
                         dbo.imp_orden_compra_ext_det.od_costo_convertido, dbo.imp_orden_compra_ext_det.od_total_fob, dbo.imp_orden_compra_ext_det.od_factor_costo, dbo.imp_orden_compra_ext_det.od_costo_bodega, 
                         dbo.imp_orden_compra_ext_det.od_costo_total, dbo.in_Producto.pr_codigo2
FROM            dbo.imp_orden_compra_ext_det INNER JOIN
                         dbo.in_Producto ON dbo.imp_orden_compra_ext_det.IdEmpresa = dbo.in_Producto.IdEmpresa AND dbo.imp_orden_compra_ext_det.IdProducto = dbo.in_Producto.IdProducto
