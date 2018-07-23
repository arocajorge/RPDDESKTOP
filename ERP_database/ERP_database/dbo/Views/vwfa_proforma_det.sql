CREATE VIEW vwfa_proforma_det
AS
SELECT        fa_proforma_det.IdEmpresa, fa_proforma_det.IdSucursal, fa_proforma_det.IdProforma, fa_proforma_det.Secuencia, fa_proforma_det.IdProducto, fa_proforma_det.pd_cantidad, fa_proforma_det.pd_precio, 
                         fa_proforma_det.pd_por_descuento_uni, fa_proforma_det.pd_descuento_uni, fa_proforma_det.pd_precio_final, fa_proforma_det.pd_subtotal, fa_proforma_det.IdCod_Impuesto, fa_proforma_det.pd_por_iva, 
                         fa_proforma_det.pd_iva, fa_proforma_det.pd_total, fa_proforma_det.anulado, in_Producto.pr_descripcion, in_presentacion.nom_presentacion, in_Producto.lote_num_lote, in_Producto.lote_fecha_vcto
FROM            fa_proforma_det INNER JOIN
                         in_Producto ON fa_proforma_det.IdEmpresa = in_Producto.IdEmpresa AND fa_proforma_det.IdProducto = in_Producto.IdProducto INNER JOIN
                         in_presentacion ON in_Producto.IdEmpresa = in_presentacion.IdEmpresa AND in_Producto.IdPresentacion = in_presentacion.IdPresentacion