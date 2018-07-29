create view [web].[vwfa_notaCreDeb_det]
as
SELECT        dbo.fa_notaCreDeb_det.IdEmpresa, dbo.fa_notaCreDeb_det.IdSucursal, dbo.fa_notaCreDeb_det.IdBodega, dbo.fa_notaCreDeb_det.IdNota, dbo.fa_notaCreDeb_det.Secuencia, dbo.fa_notaCreDeb_det.IdProducto, 
                         dbo.fa_notaCreDeb_det.sc_cantidad, dbo.fa_notaCreDeb_det.sc_Precio, dbo.fa_notaCreDeb_det.sc_descUni, dbo.fa_notaCreDeb_det.sc_PordescUni, dbo.fa_notaCreDeb_det.sc_precioFinal, dbo.fa_notaCreDeb_det.sc_subtotal, 
                         dbo.fa_notaCreDeb_det.sc_iva, dbo.fa_notaCreDeb_det.sc_total, dbo.fa_notaCreDeb_det.sc_costo, dbo.fa_notaCreDeb_det.sc_observacion, dbo.fa_notaCreDeb_det.sc_estado, dbo.fa_notaCreDeb_det.vt_por_iva, 
                         dbo.fa_notaCreDeb_det.IdPunto_Cargo, dbo.fa_notaCreDeb_det.IdPunto_cargo_grupo, dbo.fa_notaCreDeb_det.IdCod_Impuesto_Iva, dbo.fa_notaCreDeb_det.IdCod_Impuesto_Ice, dbo.fa_notaCreDeb_det.IdCentroCosto, 
                         dbo.fa_notaCreDeb_det.IdCentroCosto_sub_centro_costo, dbo.in_Producto.pr_descripcion, dbo.in_presentacion.nom_presentacion, dbo.in_Producto.lote_fecha_vcto, dbo.in_Producto.lote_num_lote
FROM            dbo.in_presentacion INNER JOIN
                         dbo.in_Producto ON dbo.in_presentacion.IdEmpresa = dbo.in_Producto.IdEmpresa AND dbo.in_presentacion.IdPresentacion = dbo.in_Producto.IdPresentacion RIGHT OUTER JOIN
                         dbo.fa_notaCreDeb_det ON dbo.in_Producto.IdEmpresa = dbo.fa_notaCreDeb_det.IdEmpresa AND dbo.in_Producto.IdProducto = dbo.fa_notaCreDeb_det.IdProducto