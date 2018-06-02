CREATE VIEW vwin_Producto_x_man_tipo_horas_facturacion
AS
SELECT        dbo.in_Producto.IdEmpresa, dbo.in_Producto.IdProducto, dbo.in_Producto.pr_codigo, dbo.in_Producto.pr_descripcion, dbo.in_Producto.pr_descripcion_2, dbo.in_Producto.IdProductoTipo, dbo.in_Producto.IdMarca, 
                         dbo.in_Producto.IdPresentacion, dbo.in_Producto.IdCategoria, dbo.in_Producto.IdLinea, dbo.in_Producto.IdGrupo, dbo.in_Producto.IdSubGrupo, dbo.in_Producto.IdUnidadMedida, dbo.in_Producto.IdUnidadMedida_Consumo, 
                         dbo.in_Producto.IdNaturaleza, dbo.in_Producto.IdMotivo_Vta, dbo.in_Producto.pr_codigo_barra, dbo.in_Producto.pr_observacion, dbo.in_Producto.pr_precio_publico, dbo.in_Producto.pr_precio_mayor, 
                         dbo.in_Producto.pr_precio_minimo, dbo.in_Producto.pr_precio_puerta, dbo.in_Producto.pr_ManejaIva, dbo.in_Producto.pr_ManejaSeries, dbo.in_Producto.pr_costo_fob, dbo.in_Producto.pr_costo_CIF, 
                         dbo.in_Producto.pr_costo_promedio, dbo.in_Producto.pr_DiasMaritimo, dbo.in_Producto.pr_DiasAereo, dbo.in_Producto.pr_DiasTerrestre, dbo.in_Producto.pr_largo, dbo.in_Producto.pr_alto, dbo.in_Producto.pr_profundidad, 
                         dbo.in_Producto.pr_peso, dbo.in_Producto.pr_imagenPeque, dbo.in_Producto.pr_imagen_Grande, dbo.in_Producto.pr_partidaArancel, dbo.in_Producto.pr_porcentajeArancel, dbo.in_Producto.pr_Por_descuento, 
                         dbo.in_Producto.pr_stock_maximo, dbo.in_Producto.pr_stock_minimo, dbo.in_Producto.IdUsuario, dbo.in_Producto.Fecha_Transac, dbo.in_Producto.IdUsuarioUltMod, dbo.in_Producto.Fecha_UltMod, 
                         dbo.in_Producto.IdUsuarioUltAnu, dbo.in_Producto.Fecha_UltAnu, dbo.in_Producto.pr_motivoAnulacion, dbo.in_Producto.nom_pc, dbo.in_Producto.ip, dbo.in_Producto.Estado, dbo.in_Producto.AnchoEspecifico, 
                         dbo.in_Producto.PesoEspecifico, dbo.in_Producto.ManejaKardex, dbo.in_Producto.IdCod_Impuesto_Iva, dbo.in_Producto.IdCod_Impuesto_Ice, dbo.in_Producto.Aparece_modu_Ventas, dbo.in_Producto.Aparece_modu_Compras, 
                         dbo.in_Producto.Aparece_modu_Inventario, dbo.in_Producto.Aparece_modu_Activo_F
FROM            dbo.in_Producto INNER JOIN
                         dbo.man_tipo_horas_facturacion ON dbo.in_Producto.IdEmpresa = dbo.man_tipo_horas_facturacion.IdEmpresa AND dbo.in_Producto.IdProducto = dbo.man_tipo_horas_facturacion.IdProducto