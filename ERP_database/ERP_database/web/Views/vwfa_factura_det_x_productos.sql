CREATE VIEW [web].[vwfa_factura_det_x_productos]
	AS 
	SELECT        dbo.fa_factura_det.IdEmpresa, dbo.fa_factura_det.IdSucursal, dbo.fa_factura_det.IdBodega, dbo.fa_factura_det.IdCbteVta, dbo.fa_factura_det.Secuencia, dbo.fa_factura_det.IdProducto, dbo.fa_factura_det.vt_cantidad, 
                         dbo.fa_factura_det.vt_Precio, dbo.fa_factura_det.vt_PorDescUnitario, dbo.fa_factura_det.vt_DescUnitario, dbo.fa_factura_det.vt_PrecioFinal, dbo.fa_factura_det.vt_Subtotal, dbo.fa_factura_det.vt_iva, dbo.fa_factura_det.vt_total, 
                         dbo.fa_factura_det.vt_estado, dbo.fa_factura_det.vt_detallexItems, dbo.fa_factura_det.vt_por_iva, dbo.fa_factura_det.IdPunto_cargo_grupo, dbo.fa_factura_det.IdCod_Impuesto_Iva, dbo.in_Producto.pr_descripcion, 
                         dbo.in_Producto.pr_descripcion_2, dbo.in_Producto.lote_fecha_fab, dbo.in_Producto.lote_fecha_vcto, dbo.in_Producto.lote_num_lote
FROM            dbo.fa_factura_det INNER JOIN
                         dbo.in_Producto ON dbo.fa_factura_det.IdEmpresa = dbo.in_Producto.IdEmpresa AND dbo.fa_factura_det.IdProducto = dbo.in_Producto.IdProducto
