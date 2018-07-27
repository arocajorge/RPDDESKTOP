CREATE VIEW web.vwfa_factura_det
AS
SELECT        fa_factura_det.IdEmpresa, fa_factura_det.IdSucursal, fa_factura_det.IdBodega, fa_factura_det.IdCbteVta, fa_factura_det.Secuencia, fa_factura_det.IdProducto, fa_factura_det.vt_cantidad, fa_factura_det.vt_Precio, 
                         fa_factura_det.vt_PorDescUnitario, fa_factura_det.vt_DescUnitario, fa_factura_det.vt_PrecioFinal, fa_factura_det.vt_Subtotal, fa_factura_det.vt_iva, fa_factura_det.vt_total, fa_factura_det.vt_estado, 
                         fa_factura_det.vt_detallexItems, fa_factura_det.vt_por_iva, fa_factura_det.IdPunto_Cargo, fa_factura_det.IdPunto_cargo_grupo, fa_factura_det.IdCod_Impuesto_Iva, fa_factura_det.IdCod_Impuesto_Ice, 
                         fa_factura_det.IdCentroCosto, fa_factura_det.IdCentroCosto_sub_centro_costo, fa_factura_det.IdEmpresa_pf, fa_factura_det.IdSucursal_pf, fa_factura_det.IdProforma, fa_factura_det.Secuencia_pf, in_Producto.pr_descripcion, 
                         in_presentacion.nom_presentacion, in_Producto.lote_num_lote, in_Producto.lote_fecha_vcto
FROM            fa_factura_det INNER JOIN
                         in_Producto ON fa_factura_det.IdEmpresa = in_Producto.IdEmpresa AND fa_factura_det.IdProducto = in_Producto.IdProducto INNER JOIN
                         in_presentacion ON in_Producto.IdEmpresa = in_presentacion.IdEmpresa AND in_Producto.IdPresentacion = in_presentacion.IdPresentacion