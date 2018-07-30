create view vwin_devolucion_inven_det
as
SELECT in_devolucion_inven_det.IdEmpresa, in_devolucion_inven_det.IdDev_Inven, in_devolucion_inven_det.secuencia, in_devolucion_inven_det.inv_IdEmpresa, in_devolucion_inven_det.inv_IdSucursal, 
                  in_devolucion_inven_det.inv_IdMovi_inven_tipo, in_devolucion_inven_det.inv_IdNumMovi, in_devolucion_inven_det.inv_Secuencia, in_devolucion_inven_det.cant_devuelta, in_Producto.pr_descripcion, in_presentacion.nom_presentacion, 
                  in_Ing_Egr_Inven_det.dm_cantidad_sinConversion, in_Producto.lote_fecha_vcto, in_Producto.lote_num_lote, in_Ing_Egr_Inven_det.IdBodega, in_UnidadMedida.Descripcion AS NomUnidad, 
                  in_Ing_Egr_Inven_det.mv_costo_sinConversion
FROM     in_UnidadMedida INNER JOIN
                  in_Ing_Egr_Inven_det ON in_UnidadMedida.IdUnidadMedida = in_Ing_Egr_Inven_det.IdUnidadMedida_sinConversion LEFT OUTER JOIN
                  in_Producto INNER JOIN
                  in_presentacion ON in_Producto.IdEmpresa = in_presentacion.IdEmpresa AND in_Producto.IdPresentacion = in_presentacion.IdPresentacion ON in_Ing_Egr_Inven_det.IdEmpresa = in_Producto.IdEmpresa AND 
                  in_Ing_Egr_Inven_det.IdProducto = in_Producto.IdProducto RIGHT OUTER JOIN
                  in_devolucion_inven_det ON in_Ing_Egr_Inven_det.IdEmpresa = in_devolucion_inven_det.inv_IdEmpresa AND in_Ing_Egr_Inven_det.IdSucursal = in_devolucion_inven_det.inv_IdSucursal AND 
                  in_Ing_Egr_Inven_det.IdMovi_inven_tipo = in_devolucion_inven_det.inv_IdMovi_inven_tipo AND in_Ing_Egr_Inven_det.IdNumMovi = in_devolucion_inven_det.inv_IdNumMovi AND 
                  in_Ing_Egr_Inven_det.Secuencia = in_devolucion_inven_det.inv_Secuencia