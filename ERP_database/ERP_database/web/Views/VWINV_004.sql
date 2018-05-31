CREATE VIEW [web].[VWINV_004]
AS
SELECT in_Ing_Egr_Inven_det.IdEmpresa, in_Ing_Egr_Inven_det.IdSucursal, in_Ing_Egr_Inven_det.IdMovi_inven_tipo, in_Ing_Egr_Inven_det.IdNumMovi, in_Ing_Egr_Inven_det.Secuencia, in_movi_inve_detalle.mv_tipo_movi, 
                  in_movi_inven_tipo.tm_descripcion, in_Ing_Egr_Inven_det.IdProducto, in_Producto.pr_codigo, in_Producto.pr_descripcion, in_presentacion.nom_presentacion, in_Producto.lote_fecha_vcto, in_Producto.lote_num_lote, 
                  in_movi_inve.cm_fecha, in_movi_inve.cm_observacion, tb_sucursal.Su_Descripcion, tb_bodega.bo_Descripcion, in_movi_inve_detalle.dm_cantidad, in_movi_inve_detalle.mv_costo, in_movi_inve_detalle.IdUnidadMedida, 
                  in_UnidadMedida.Descripcion, in_Producto.IdCategoria, in_Producto.IdLinea, in_Producto.IdGrupo, in_Producto.IdSubGrupo, YEAR(in_movi_inve.cm_fecha) AS anio, MONTH(in_movi_inve.cm_fecha) AS mes, 
                  in_Producto.IdProducto_padre, in_Producto_padre.pr_descripcion pr_descripcion_padre
FROM     in_Ing_Egr_Inven_det INNER JOIN
                  in_movi_inve_detalle ON in_Ing_Egr_Inven_det.IdEmpresa_inv = in_movi_inve_detalle.IdEmpresa AND in_Ing_Egr_Inven_det.IdSucursal_inv = in_movi_inve_detalle.IdSucursal AND 
                  in_Ing_Egr_Inven_det.IdBodega_inv = in_movi_inve_detalle.IdBodega AND in_Ing_Egr_Inven_det.IdMovi_inven_tipo_inv = in_movi_inve_detalle.IdMovi_inven_tipo AND 
                  in_Ing_Egr_Inven_det.IdNumMovi_inv = in_movi_inve_detalle.IdNumMovi AND in_Ing_Egr_Inven_det.secuencia_inv = in_movi_inve_detalle.Secuencia INNER JOIN
                  in_movi_inve ON in_movi_inve_detalle.IdEmpresa = in_movi_inve.IdEmpresa AND in_movi_inve_detalle.IdSucursal = in_movi_inve.IdSucursal AND in_movi_inve_detalle.IdBodega = in_movi_inve.IdBodega AND 
                  in_movi_inve_detalle.IdMovi_inven_tipo = in_movi_inve.IdMovi_inven_tipo AND in_movi_inve_detalle.IdNumMovi = in_movi_inve.IdNumMovi INNER JOIN
                  in_Producto ON in_movi_inve_detalle.IdEmpresa = in_Producto.IdEmpresa AND in_movi_inve_detalle.IdProducto = in_Producto.IdProducto INNER JOIN
                  tb_bodega ON in_Ing_Egr_Inven_det.IdEmpresa = tb_bodega.IdEmpresa AND in_Ing_Egr_Inven_det.IdSucursal = tb_bodega.IdSucursal AND in_Ing_Egr_Inven_det.IdBodega = tb_bodega.IdBodega INNER JOIN
                  tb_sucursal ON in_Ing_Egr_Inven_det.IdEmpresa = tb_sucursal.IdEmpresa AND in_Ing_Egr_Inven_det.IdSucursal = tb_sucursal.IdSucursal INNER JOIN
                  in_movi_inven_tipo ON in_Ing_Egr_Inven_det.IdEmpresa = in_movi_inven_tipo.IdEmpresa AND in_Ing_Egr_Inven_det.IdMovi_inven_tipo = in_movi_inven_tipo.IdMovi_inven_tipo INNER JOIN
                  in_presentacion ON in_Producto.IdEmpresa = in_presentacion.IdEmpresa AND in_Producto.IdPresentacion = in_presentacion.IdPresentacion INNER JOIN
                  in_UnidadMedida ON in_movi_inve_detalle.IdUnidadMedida = in_UnidadMedida.IdUnidadMedida LEFT JOIN
                  in_Producto AS in_Producto_padre ON in_Producto.IdProducto_padre = in_Producto_padre.IdProducto AND in_Producto.IdEmpresa = in_Producto_padre.IdEmpresa