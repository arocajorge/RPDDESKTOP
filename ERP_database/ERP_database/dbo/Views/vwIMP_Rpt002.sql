CREATE VIEW [dbo].[vwIMP_Rpt002]
	AS 
	SELECT        dbo.imp_liquidacion.IdEmpresa, dbo.imp_liquidacion.IdLiquidacion, dbo.cp_proveedor.IdProveedor, dbo.cp_proveedor.pr_codigo, dbo.imp_orden_compra_ext.IdOrdenCompra_ext, dbo.imp_liquidacion.li_fecha, 
                         dbo.imp_orden_compra_ext.oe_fecha_llegada, dbo.imp_orden_compra_ext.oe_fecha_embarque, dbo.imp_orden_compra_ext.oe_fecha_desaduanizacion, dbo.imp_orden_compra_ext.fecha_modificacion, 
                         dbo.imp_liquidacion.li_observacion, dbo.imp_liquidacion.li_factor_conversion, dbo.imp_liquidacion.li_total_fob, dbo.imp_liquidacion.li_total_gastos, dbo.imp_liquidacion.li_total_bodega, dbo.imp_liquidacion.li_factor_costo, 
                         dbo.imp_liquidacion.estado, dbo.imp_liquidacion.cerrado, dbo.imp_orden_compra_ext_det.od_cantidad, dbo.imp_orden_compra_ext_det.od_costo, dbo.imp_orden_compra_ext_det.od_por_descuento, 
                         dbo.imp_orden_compra_ext_det.od_descuento, dbo.imp_orden_compra_ext_det.od_costo_final, dbo.imp_orden_compra_ext_det.od_subtotal, dbo.imp_orden_compra_ext_det.od_cantidad_recepcion, 
                         dbo.imp_orden_compra_ext_det.od_costo_convertido, dbo.imp_orden_compra_ext_det.od_total_fob, dbo.imp_orden_compra_ext_det.od_factor_costo, dbo.imp_orden_compra_ext_det.od_costo_bodega, 
                         dbo.imp_orden_compra_ext_det.od_costo_total,   dbo.imp_orden_compra_ext.oe_codigo, 
                         dbo.imp_orden_compra_ext.oe_fecha_llegada_est, dbo.imp_orden_compra_ext.oe_fecha_embarque_est, dbo.imp_orden_compra_ext.oe_fecha_desaduanizacion_est, dbo.imp_orden_compra_ext.oe_fecha, 
                         dbo.imp_catalogo.IdCatalogo
FROM            dbo.imp_gasto_x_ct_plancta INNER JOIN
                         dbo.imp_gasto ON dbo.imp_gasto_x_ct_plancta.IdGasto_tipo = dbo.imp_gasto.IdGasto_tipo CROSS JOIN
                         dbo.imp_orden_compra_ext INNER JOIN
                         dbo.imp_liquidacion_det_x_imp_orden_compra_ext INNER JOIN
                         dbo.imp_liquidacion ON dbo.imp_liquidacion_det_x_imp_orden_compra_ext.IdEmpresa = dbo.imp_liquidacion.IdEmpresa AND 
                         dbo.imp_liquidacion_det_x_imp_orden_compra_ext.IdLiquidacion = dbo.imp_liquidacion.IdLiquidacion ON dbo.imp_orden_compra_ext.IdEmpresa = dbo.imp_liquidacion_det_x_imp_orden_compra_ext.IdEmpresa_oe AND 
                         dbo.imp_orden_compra_ext.IdOrdenCompra_ext = dbo.imp_liquidacion_det_x_imp_orden_compra_ext.IdOrdenCompra_ext INNER JOIN
                         dbo.tb_persona INNER JOIN
                         dbo.cp_proveedor ON dbo.tb_persona.IdPersona = dbo.cp_proveedor.IdPersona ON dbo.imp_orden_compra_ext.IdEmpresa = dbo.cp_proveedor.IdEmpresa AND 
                         dbo.imp_orden_compra_ext.IdProveedor = dbo.cp_proveedor.IdProveedor INNER JOIN
                         dbo.imp_orden_compra_ext_det ON dbo.imp_orden_compra_ext.IdEmpresa = dbo.imp_orden_compra_ext_det.IdEmpresa AND 
                         dbo.imp_orden_compra_ext.IdOrdenCompra_ext = dbo.imp_orden_compra_ext_det.IdOrdenCompra_ext INNER JOIN
                         dbo.imp_catalogo ON dbo.imp_catalogo.IdCatalogo = dbo.imp_catalogo.IdCatalogo
