--[dbo].[vwin_in_Producto_x_tb_bodega_x_UnidadMedida]
--[dbo].[vwin_producto]


CREATE VIEW [dbo].[vwin_Producto_a_Cortar_CusCider]
AS
SELECT        dbo.in_Producto.IdEmpresa, dbo.tb_sucursal.IdSucursal, dbo.in_movi_inve_detalle_x_Producto_CusCider.IdBodega, dbo.in_Producto.IdProducto, 
                         dbo.in_Producto.pr_codigo, dbo.in_Producto.pr_codigo_barra, dbo.in_Producto.IdProductoTipo, dbo.in_Producto.IdPresentacion, dbo.in_Producto.IdCategoria, 
                         dbo.in_Producto.pr_descripcion, dbo.in_Producto.pr_observacion, dbo.in_Producto.IdUnidadMedida, 0 pr_precio_publico, 
                         dbo.in_Producto.IdMarca,                          
                         0 pr_stock_minimo, 
                         dbo.in_Producto.IdSubGrupo, dbo.in_Producto.IdGrupo, dbo.in_Producto.IdLinea, 
                          
                         dbo.in_Producto.pr_descripcion_2, dbo.in_Producto.Estado, dbo.in_movi_inve_detalle_x_Producto_CusCider.IdMovi_inven_tipo, 
                         dbo.in_movi_inve_detalle_x_Producto_CusCider.IdNumMovi, dbo.in_movi_inve_detalle_x_Producto_CusCider.mv_Secuencia, 
                         dbo.in_movi_inve_detalle_x_Producto_CusCider.Secuencia, dbo.in_movi_inve_detalle_x_Producto_CusCider.CodigoBarra, 
                         dbo.in_movi_inve_detalle_x_Producto_CusCider.mv_tipo_movi, dbo.in_movi_inve_detalle_x_Producto_CusCider.dm_cantidad, 
                         dbo.in_movi_inve_detalle_x_Producto_CusCider.dm_observacion, dbo.in_movi_inve_detalle_x_Producto_CusCider.dm_precio, 
                         dbo.in_movi_inve_detalle_x_Producto_CusCider.mv_costo, dbo.in_categorias.ca_Categoria, dbo.tb_sucursal.Su_Descripcion, dbo.tb_bodega.bo_Descripcion, 
                         dbo.in_ProductoTipo.tp_descripcion, dbo.in_Marca.Descripcion, dbo.in_movi_inve_detalle_x_Producto_CusCider.ot_CodObra, 
                         dbo.in_movi_inve_detalle_x_Producto_CusCider.et_IdProcesoProductivo, dbo.in_movi_inve_detalle_x_Producto_CusCider.ot_IdOrdenTaller, 
                         dbo.in_Producto.IdUnidadMedida_Consumo
FROM            dbo.tb_sucursal INNER JOIN
                         dbo.tb_bodega ON dbo.tb_sucursal.IdEmpresa = dbo.tb_bodega.IdEmpresa AND dbo.tb_sucursal.IdSucursal = dbo.tb_bodega.IdSucursal INNER JOIN
                         dbo.in_Producto INNER JOIN
                         dbo.in_movi_inve_detalle_x_Producto_CusCider ON dbo.in_Producto.IdEmpresa = dbo.in_movi_inve_detalle_x_Producto_CusCider.IdEmpresa AND 
                         dbo.in_Producto.IdProducto = dbo.in_movi_inve_detalle_x_Producto_CusCider.IdProducto INNER JOIN
                         dbo.in_categorias ON dbo.in_Producto.IdEmpresa = dbo.in_categorias.IdEmpresa AND dbo.in_Producto.IdCategoria = dbo.in_categorias.IdCategoria INNER JOIN
                         dbo.in_ProductoTipo ON dbo.in_Producto.IdEmpresa = dbo.in_ProductoTipo.IdEmpresa AND 
                         dbo.in_Producto.IdProductoTipo = dbo.in_ProductoTipo.IdProductoTipo ON 
                         dbo.tb_bodega.IdEmpresa = dbo.in_movi_inve_detalle_x_Producto_CusCider.IdEmpresa AND 
                         dbo.tb_bodega.IdSucursal = dbo.in_movi_inve_detalle_x_Producto_CusCider.IdSucursal AND 
                         dbo.tb_bodega.IdBodega = dbo.in_movi_inve_detalle_x_Producto_CusCider.IdBodega INNER JOIN
                         dbo.in_Marca ON dbo.in_Producto.IdEmpresa = dbo.in_Marca.IdEmpresa AND dbo.in_Producto.IdMarca = dbo.in_Marca.IdMarca
WHERE        (dbo.in_movi_inve_detalle_x_Producto_CusCider.mv_tipo_movi = '-')