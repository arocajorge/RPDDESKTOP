CREATE VIEW vwin_Ing_Egr_Inven_distribucion_x_distribuir
AS
SELECT in_Ing_Egr_Inven.IdEmpresa, in_Ing_Egr_Inven.IdSucursal, in_Ing_Egr_Inven.IdMovi_inven_tipo, in_Ing_Egr_Inven.IdNumMovi, in_Ing_Egr_Inven.signo, in_Producto.IdProducto_padre, in_Ing_Egr_Inven_det.IdProducto, 
                  in_Producto.pr_descripcion, in_Ing_Egr_Inven_det.IdUnidadMedida, ABS(in_Ing_Egr_Inven_det.dm_cantidad) AS can_total, abs(isnull(SUM(Dist.dm_cantidad),0)) AS can_distribuida,
				  isnull(ABS(in_Ing_Egr_Inven_det.dm_cantidad) - abs(isnull(SUM(Dist.dm_cantidad),0)),0) as can_x_distribuir
FROM     in_Ing_Egr_Inven INNER JOIN
                  in_Ing_Egr_Inven_det ON in_Ing_Egr_Inven.IdEmpresa = in_Ing_Egr_Inven_det.IdEmpresa AND in_Ing_Egr_Inven.IdSucursal = in_Ing_Egr_Inven_det.IdSucursal AND 
                  in_Ing_Egr_Inven.IdMovi_inven_tipo = in_Ing_Egr_Inven_det.IdMovi_inven_tipo AND in_Ing_Egr_Inven.IdNumMovi = in_Ing_Egr_Inven_det.IdNumMovi INNER JOIN
                  in_Producto ON in_Ing_Egr_Inven_det.IdEmpresa = in_Producto.IdEmpresa AND in_Ing_Egr_Inven_det.IdProducto = in_Producto.IdProducto LEFT OUTER JOIN
                      (SELECT distribucion.IdEmpresa, distribucion.IdSucursal, distribucion.IdMovi_inven_tipo, distribucion.IdNumMovi, det_mov.IdUnidadMedida, det_mov.IdProducto, det_mov.dm_cantidad, dis_pro.IdProducto_padre
                       FROM      in_Ing_Egr_Inven AS cab_mov INNER JOIN
                                         in_Ing_Egr_Inven_det AS det_mov ON cab_mov.IdEmpresa = det_mov.IdEmpresa AND cab_mov.IdSucursal = det_mov.IdSucursal AND cab_mov.IdMovi_inven_tipo = det_mov.IdMovi_inven_tipo AND 
                                         cab_mov.IdNumMovi = det_mov.IdNumMovi INNER JOIN
                                         in_Ing_Egr_Inven_distribucion AS distribucion ON cab_mov.IdEmpresa = distribucion.IdEmpresa_dis AND cab_mov.IdSucursal = distribucion.IdSucursal_dis AND 
                                         cab_mov.IdMovi_inven_tipo = distribucion.IdMovi_inven_tipo_dis AND cab_mov.IdNumMovi = distribucion.IdNumMovi_dis INNER JOIN
                                         in_Producto AS dis_pro ON det_mov.IdEmpresa = dis_pro.IdEmpresa AND det_mov.IdProducto = dis_pro.IdProducto
                       WHERE   (cab_mov.Estado = 'A') AND (ISNULL(dis_pro.se_distribuye, 0) = 0)) AS Dist ON in_Ing_Egr_Inven.IdEmpresa = Dist.IdEmpresa AND in_Ing_Egr_Inven.IdSucursal = Dist.IdSucursal AND 
                  in_Ing_Egr_Inven.IdMovi_inven_tipo = Dist.IdMovi_inven_tipo AND in_Ing_Egr_Inven.IdNumMovi = Dist.IdNumMovi AND in_Producto.IdProducto_padre = Dist.IdProducto_padre
WHERE  (in_Ing_Egr_Inven.Estado = 'A') AND (in_Producto.se_distribuye = 1)
GROUP BY in_Ing_Egr_Inven.IdEmpresa, in_Ing_Egr_Inven.IdSucursal, in_Ing_Egr_Inven.IdMovi_inven_tipo, in_Ing_Egr_Inven.IdNumMovi, in_Ing_Egr_Inven.signo, in_Producto.IdProducto_padre, in_Ing_Egr_Inven_det.IdProducto, 
                  in_Producto.pr_descripcion, in_Ing_Egr_Inven_det.IdUnidadMedida, ABS(in_Ing_Egr_Inven_det.dm_cantidad)