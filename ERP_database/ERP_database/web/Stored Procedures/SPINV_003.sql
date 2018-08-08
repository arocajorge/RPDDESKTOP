--EXEC web.SPINV_003 1,1,9999,1,9999,1,999999,'',0,0,0,'2018/05/30',1
CREATE PROCEDURE [web].[SPINV_003]
(
@IdEmpresa int,
@IdSucursal_ini int,
@IdSucursal_fin int,
@IdBodega_ini int,
@IdBodega_fin int,
@IdProducto_ini numeric,
@IdProducto_fin numeric,
@IdCategoria varchar(20),
@IdLinea int,
@IdGrupo int,
@IdSubGrupo int,
@fecha_corte datetime,
@mostrar_stock_0 bit
)
AS
BEGIN

DELETE web.in_SPINV_003

BEGIN --INSERTO EN TABLA PK DE PRODUCTOS A MOSTRAR
	INSERT INTO web.in_SPINV_003
	SELECT in_producto_x_tb_bodega.IdEmpresa, in_producto_x_tb_bodega.IdSucursal, in_producto_x_tb_bodega.IdBodega, in_producto_x_tb_bodega.IdProducto, 0 AS Expr1, 0 AS Expr2, 0 AS Expr3, in_Producto.IdCategoria, in_Producto.IdLinea, 
		in_Producto.IdGrupo, in_Producto.IdSubGrupo
	FROM     in_producto_x_tb_bodega INNER JOIN
		in_Producto ON in_producto_x_tb_bodega.IdEmpresa = in_Producto.IdEmpresa AND in_producto_x_tb_bodega.IdProducto = in_Producto.IdProducto
	where in_producto_x_tb_bodega.IdEmpresa = @IdEmpresa
	AND IdSucursal between @IdSucursal_ini and @IdSucursal_fin
	AND IdBodega BETWEEN @IdBodega_ini and @IdBodega_fin
	and in_producto_x_tb_bodega.IdProducto between @IdProducto_ini and @IdProducto_fin
END

BEGIN --FILTRO POR CATEGORIZACION
	IF(@IdCategoria != '')
	BEGIN
		IF(@IdLinea != 0)
			BEGIN
				IF(@IdGrupo != 0)
					BEGIN
						IF(@IdSubGrupo != 0)
							BEGIN
								DELETE web.in_SPINV_003 
								WHERE IdCategoria !=  @IdCategoria
								AND IdLinea != @IdLinea
								AND IdGrupo != @IdGrupo
								AND IdSubGrupo != @IdSubGrupo
							END
						ELSE
							DELETE web.in_SPINV_003 
							WHERE IdCategoria !=  @IdCategoria
							AND IdLinea != @IdLinea
							AND IdGrupo != @IdGrupo

					END
				ELSE
					DELETE web.in_SPINV_003 
					WHERE IdCategoria != @IdCategoria
					AND IdLinea != @IdLinea
			END
		ELSE
			DELETE web.in_SPINV_003 
			WHERE IdCategoria <> @IdCategoria

	END
END

BEGIN --ACTUALIZO STOCK Y COSTO A LA FECHA
	UPDATE web.in_SPINV_003 SET Stock = ROUND(A.cantidad,2), Costo_total = ROUND(A.costo_total,2), Costo_promedio = IIF(ROUND(A.cantidad,2) = 0, 0 ,ROUND(A.costo_total / A.cantidad,2))
	FROM(
	SELECT det.IdEmpresa, det.IdSucursal, det.IdBodega, det.IdProducto, sum(dm_cantidad) cantidad, sum(dm_cantidad * mv_costo) costo_total
	FROM in_movi_inve cab inner join
	in_movi_inve_detalle det 
	on cab.IdEmpresa = det.IdEmpresa
	and cab.IdSucursal = det.IdSucursal
	and cab.IdBodega = det.IdBodega
	and cab.IdMovi_inven_tipo = det.IdMovi_inven_tipo
	and cab.IdNumMovi = det.IdNumMovi
	inner join web.in_SPINV_003 sp
	on sp.IdEmpresa = det.IdEmpresa
	and sp.IdSucursal = det.IdSucursal
	and sp.IdBodega = det.IdBodega
	and sp.IdProducto = det.IdProducto
	WHERE cab.cm_fecha <= @fecha_corte	
	group by det.IdEmpresa, det.IdSucursal, det.IdBodega, det.IdProducto
	) A
	WHERE web.in_SPINV_003.IdEmpresa = A.IdEmpresa
	AND web.in_SPINV_003.IdSucursal = A.IdSucursal
	AND web.in_SPINV_003.IdBodega = A.IdBodega
	and web.in_SPINV_003.IdProducto = A.IdProducto
END

IF(@mostrar_stock_0 = 0)--ELIMINO STOCK 0 SI EL PARAMETRO LO DICE
BEGIN
	DELETE web.in_SPINV_003 
	WHERE Stock = 0
END

SELECT sp.IdEmpresa, sp.IdSucursal, sp.IdBodega, sp.IdProducto, sp.Stock, sp.Costo_promedio, sp.Costo_total,
s.Su_Descripcion, b.bo_Descripcion, p.pr_codigo, p.pr_descripcion, p.lote_num_lote, p.lote_fecha_vcto,
c.IdCategoria, c.ca_Categoria, l.IdLinea, l.nom_linea, g.IdGrupo, g.nom_grupo, sg.IdSubgrupo, sg.nom_subgrupo, pr.IdPresentacion, pr.nom_presentacion
FROM web.in_SPINV_003 as sp
inner join in_Producto as p
on sp.IdEmpresa = p.IdEmpresa
and sp.IdProducto = p.IdProducto
inner join tb_sucursal as s
on sp.IdEmpresa = s.IdEmpresa
and sp.IdSucursal = s.IdSucursal
inner join tb_bodega as b
on sp.IdEmpresa = b.IdEmpresa
and sp.IdSucursal = b.IdSucursal
and sp.IdBodega = b.IdBodega
inner join in_categorias as c on c.IdEmpresa = p.IdEmpresa and c.IdCategoria = p.IdEmpresa
inner join in_linea as l on l.IdEmpresa = p.IdEmpresa and l.IdCategoria = p.IdCategoria and l.IdLinea = p.IdLinea
inner join in_grupo as g on g.IdEmpresa = p.IdEmpresa and g.IdCategoria = p.IdCategoria and g.IdLinea = p.IdLinea and g.IdGrupo = p.IdGrupo
inner join in_subgrupo as sg on sg.IdEmpresa = p.IdEmpresa and sg.IdCategoria = p.IdCategoria and sg.IdLinea = p.IdLinea and sg.IdGrupo = p.IdGrupo and sg.IdSubgrupo = p.IdSubGrupo
inner join in_presentacion as pr on pr.IdEmpresa = p.IdEmpresa and pr.IdPresentacion = p.IdPresentacion
END
