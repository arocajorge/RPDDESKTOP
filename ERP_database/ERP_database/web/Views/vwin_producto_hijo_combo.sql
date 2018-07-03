CREATE VIEW web.vwin_producto_hijo_combo
AS
SELECT        pro.IdEmpresa, pro.IdProducto, ISNULL(pro.IdProducto_padre, 0) AS IdProducto_padre, pro.pr_descripcion, pre.nom_presentacion, ca.ca_Categoria, pro.lote_num_lote, pro.lote_fecha_vcto, pro.IdUnidadMedida
FROM            dbo.in_Producto AS pro INNER JOIN
                         dbo.in_categorias AS ca ON pro.IdEmpresa = ca.IdEmpresa AND pro.IdCategoria = ca.IdCategoria INNER JOIN
                         dbo.in_presentacion AS pre ON pro.IdEmpresa = pre.IdEmpresa AND pro.IdPresentacion = pre.IdPresentacion
WHERE        (NOT EXISTS
                             (SELECT        IdEmpresa
                               FROM            dbo.in_Producto AS p
                               WHERE        (IdEmpresa = pro.IdEmpresa) AND (IdProducto_padre = pro.IdProducto))) AND (pro.Estado = 'A')