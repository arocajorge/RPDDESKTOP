CREATE VIEW WEB.VWIMP_001 AS
SELECT        imp_orden_compra_ext.IdEmpresa, imp_orden_compra_ext.IdOrdenCompra_ext, imp_orden_compra_ext.IdProveedor, imp_orden_compra_ext.oe_fecha, imp_orden_compra_ext.oe_fecha_llegada_est, 
                         imp_orden_compra_ext.oe_fecha_embarque_est, imp_orden_compra_ext.oe_observacion, tb_moneda.im_descripcion AS NomMoneda, in_Producto.pr_codigo, in_Producto.pr_descripcion, 
                         imp_orden_compra_ext_det.od_cantidad, imp_orden_compra_ext_det.od_costo, imp_orden_compra_ext_det.od_por_descuento, imp_orden_compra_ext_det.od_descuento, imp_orden_compra_ext_det.od_costo_final, 
                         imp_orden_compra_ext_det.od_subtotal, tb_persona.pe_nombreCompleto, tb_pais.Nombre AS NomPais, in_presentacion.nom_presentacion, ViaEmbarque.ca_descripcion AS NomVia, 
                         FormaPago.ca_descripcion AS NomFormaPago, in_UnidadMedida.Descripcion AS NomUnidad
FROM            imp_orden_compra_ext INNER JOIN
                         imp_orden_compra_ext_det ON imp_orden_compra_ext.IdEmpresa = imp_orden_compra_ext_det.IdEmpresa AND imp_orden_compra_ext.IdOrdenCompra_ext = imp_orden_compra_ext_det.IdOrdenCompra_ext INNER JOIN
                         cp_proveedor ON imp_orden_compra_ext.IdEmpresa = cp_proveedor.IdEmpresa AND imp_orden_compra_ext.IdProveedor = cp_proveedor.IdProveedor INNER JOIN
                         tb_persona ON cp_proveedor.IdPersona = tb_persona.IdPersona INNER JOIN
                         tb_moneda ON imp_orden_compra_ext.IdMoneda_origen = tb_moneda.IdMoneda INNER JOIN
                         in_Producto ON imp_orden_compra_ext_det.IdEmpresa = in_Producto.IdEmpresa AND imp_orden_compra_ext_det.IdProducto = in_Producto.IdProducto INNER JOIN
                         tb_pais ON imp_orden_compra_ext.IdPais_embarque = tb_pais.IdPais INNER JOIN
                         in_presentacion ON in_Producto.IdEmpresa = in_presentacion.IdEmpresa AND in_Producto.IdPresentacion = in_presentacion.IdPresentacion INNER JOIN
                         imp_catalogo AS ViaEmbarque ON imp_orden_compra_ext.IdCatalogo_via = ViaEmbarque.IdCatalogo INNER JOIN
                         imp_catalogo AS FormaPago ON imp_orden_compra_ext.IdCatalogo_forma_pago = FormaPago.IdCatalogo INNER JOIN
                         in_UnidadMedida ON imp_orden_compra_ext_det.IdUnidadMedida = in_UnidadMedida.IdUnidadMedida