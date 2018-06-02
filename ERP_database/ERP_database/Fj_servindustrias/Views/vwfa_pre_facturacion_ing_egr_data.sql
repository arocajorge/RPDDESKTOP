CREATE VIEW [Fj_servindustrias].[vwfa_pre_facturacion_ing_egr_data]
AS
SELECT in_Ing_Egr_Inven_det.IdEmpresa, in_Ing_Egr_Inven_det.IdSucursal, in_Ing_Egr_Inven_det.IdMovi_inven_tipo, in_Ing_Egr_Inven_det.IdNumMovi, in_Ing_Egr_Inven_det.Secuencia, in_Ing_Egr_Inven.signo, in_Ing_Egr_Inven.CodMoviInven, 
                  in_Ing_Egr_Inven.cm_fecha, in_Ing_Egr_Inven_det.IdProducto, in_Producto.pr_codigo, in_Producto.pr_descripcion, ISNULL(in_Ing_Egr_Inven_det.dm_cantidad, 0) dm_cantidad, ISNULL(in_Ing_Egr_Inven_det.mv_costo, 0) AS mv_costo, 
                  ISNULL(in_Ing_Egr_Inven_det.dm_cantidad * in_Ing_Egr_Inven_det.mv_costo, 0) AS subtotal, ct_punto_cargo.nom_punto_cargo, CASE WHEN tarifario.IdEmpresa IS NOT NULL 
                  THEN tarifario.IdCentroCosto ELSE in_Ing_Egr_Inven_det.IdCentroCosto END AS IdCentroCosto, CASE WHEN tarifario.IdEmpresa IS NOT NULL 
                  THEN tarifario.IdCentroCosto_sub_centro_costo ELSE in_Ing_Egr_Inven_det.IdCentroCosto_sub_centro_costo END AS IdCentroCosto_sub_centro_costo, in_Ing_Egr_Inven_det.IdPunto_cargo, 
                  in_Ing_Egr_Inven_det.IdPunto_cargo_grupo, cast(cast( cp_Aprobacion_Ing_Bod_x_OC.num_documento as numeric) as varchar(20)) num_documento, tb_persona.pe_nombreCompleto, cp_Aprobacion_Ing_Bod_x_OC.IdProveedor, 'ING_CON_DIR' AS Tipo, 
                  isnull(Fj_servindustrias.Af_Activo_fijo_x_ct_punto_cargo.IdActivoFijo_AF, 0) IdActivoFijo_AF, NULL AS eg_codigo
FROM     Fj_servindustrias.Af_Activo_fijo_x_ct_punto_cargo INNER JOIN
                  in_Ing_Egr_Inven INNER JOIN
                  in_Motivo_Inven ON in_Ing_Egr_Inven.IdEmpresa = in_Motivo_Inven.IdEmpresa AND in_Ing_Egr_Inven.IdMotivo_Inv = in_Motivo_Inven.IdMotivo_Inv INNER JOIN
                  in_Ing_Egr_Inven_det ON in_Ing_Egr_Inven.IdEmpresa = in_Ing_Egr_Inven_det.IdEmpresa AND in_Ing_Egr_Inven.IdSucursal = in_Ing_Egr_Inven_det.IdSucursal AND 
                  in_Ing_Egr_Inven.IdMovi_inven_tipo = in_Ing_Egr_Inven_det.IdMovi_inven_tipo AND in_Ing_Egr_Inven.IdNumMovi = in_Ing_Egr_Inven_det.IdNumMovi INNER JOIN
                  in_Producto ON in_Ing_Egr_Inven_det.IdEmpresa = in_Producto.IdEmpresa AND in_Ing_Egr_Inven_det.IdProducto = in_Producto.IdProducto INNER JOIN
                  ct_punto_cargo ON in_Ing_Egr_Inven_det.IdEmpresa = ct_punto_cargo.IdEmpresa AND in_Ing_Egr_Inven_det.IdPunto_cargo = ct_punto_cargo.IdPunto_cargo ON 
                  Fj_servindustrias.Af_Activo_fijo_x_ct_punto_cargo.IdEmpresa_PC = ct_punto_cargo.IdEmpresa AND Fj_servindustrias.Af_Activo_fijo_x_ct_punto_cargo.IdPunto_cargo_PC = ct_punto_cargo.IdPunto_cargo LEFT OUTER JOIN
                  cp_Aprobacion_Ing_Bod_x_OC INNER JOIN
                  cp_Aprobacion_Ing_Bod_x_OC_det ON cp_Aprobacion_Ing_Bod_x_OC.IdEmpresa = cp_Aprobacion_Ing_Bod_x_OC_det.IdEmpresa AND 
                  cp_Aprobacion_Ing_Bod_x_OC.IdAprobacion = cp_Aprobacion_Ing_Bod_x_OC_det.IdAprobacion INNER JOIN
                  cp_proveedor ON cp_Aprobacion_Ing_Bod_x_OC.IdEmpresa = cp_proveedor.IdEmpresa AND cp_Aprobacion_Ing_Bod_x_OC.IdProveedor = cp_proveedor.IdProveedor INNER JOIN
                  tb_persona ON cp_proveedor.IdPersona = tb_persona.IdPersona ON in_Ing_Egr_Inven_det.IdEmpresa = cp_Aprobacion_Ing_Bod_x_OC_det.IdEmpresa_Ing_Egr_Inv AND 
                  in_Ing_Egr_Inven_det.IdSucursal = cp_Aprobacion_Ing_Bod_x_OC_det.IdSucursal_Ing_Egr_Inv AND in_Ing_Egr_Inven_det.IdMovi_inven_tipo = cp_Aprobacion_Ing_Bod_x_OC_det.IdMovi_inven_tipo_Ing_Egr_Inv AND 
                  in_Ing_Egr_Inven_det.IdNumMovi = cp_Aprobacion_Ing_Bod_x_OC_det.IdNumMovi_Ing_Egr_Inv AND in_Ing_Egr_Inven_det.Secuencia = cp_Aprobacion_Ing_Bod_x_OC_det.Secuencia_Ing_Egr_Inv LEFT JOIN
                      (SELECT IdEmpresa, IdActivoFijo, IdCentroCosto, IdCentroCosto_sub_centro_costo
                       FROM      Fj_servindustrias.fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo) tarifario ON Fj_servindustrias.Af_Activo_fijo_x_ct_punto_cargo.IdEmpresa_AF = tarifario.IdEmpresa AND 
                  Fj_servindustrias.Af_Activo_fijo_x_ct_punto_cargo.IdActivoFijo_AF = tarifario.IdActivoFijo
WHERE  (in_Ing_Egr_Inven.signo = '+') AND (in_Ing_Egr_Inven.Estado = 'A') AND (in_Motivo_Inven.Genera_Movi_Inven = 'N') AND (NOT EXISTS
                      (SELECT IdEmpresa
                       FROM      Fj_servindustrias.fa_pre_facturacion_det_ing_egr_inven AS fa
                       WHERE   (in_IdEmpresa = in_Ing_Egr_Inven_det.IdEmpresa) AND (in_IdSucursal = in_Ing_Egr_Inven_det.IdSucursal) AND (in_IdMovi_inven_tipo = in_Ing_Egr_Inven_det.IdMovi_inven_tipo) AND 
                                         (in_IdNumMovi = in_Ing_Egr_Inven_det.IdNumMovi) AND (in_Secuencia = in_Ing_Egr_Inven_det.Secuencia)))
UNION
SELECT in_Ing_Egr_Inven_det.IdEmpresa, in_Ing_Egr_Inven_det.IdSucursal, in_Ing_Egr_Inven_det.IdMovi_inven_tipo, in_Ing_Egr_Inven_det.IdNumMovi, in_Ing_Egr_Inven_det.Secuencia, in_Ing_Egr_Inven.signo, in_Ing_Egr_Inven.CodMoviInven, 
                  in_Ing_Egr_Inven.cm_fecha, in_Ing_Egr_Inven_det.IdProducto, in_Producto.pr_codigo, in_Producto.pr_descripcion, isnull(ABS(in_Ing_Egr_Inven_det.dm_cantidad) - ISNULL(movi.cantidad_procesada, 0) - isnull(dev.cant_devuelta, 0), 0) 
                  AS dm_cantidad, ISNULL(CAST(0 AS float), 0) AS costo, ISNULL(CAST(0 AS float), 0) AS subtotal, ct_punto_cargo.nom_punto_cargo, CASE WHEN tarifario.IdEmpresa IS NOT NULL 
                  THEN tarifario.IdCentroCosto ELSE in_Ing_Egr_Inven_det.IdCentroCosto END AS IdCentroCosto, CASE WHEN tarifario.IdEmpresa IS NOT NULL 
                  THEN tarifario.IdCentroCosto_sub_centro_costo ELSE in_Ing_Egr_Inven_det.IdCentroCosto_sub_centro_costo END AS IdCentroCosto_sub_centro_costo, in_Ing_Egr_Inven_det.IdPunto_cargo, 
                  in_Ing_Egr_Inven_det.IdPunto_cargo_grupo, NULL AS num_documento, NULL AS nom_proveedor, NULL AS IdProveedor, 'EGR_VARIOS' AS Expr1, isnull(Fj_servindustrias.Af_Activo_fijo_x_ct_punto_cargo.IdActivoFijo_AF, 0), 
                  in_Ing_Egr_Inven.CodMoviInven
FROM     in_Ing_Egr_Inven INNER JOIN
                  in_Ing_Egr_Inven_det ON in_Ing_Egr_Inven.IdEmpresa = in_Ing_Egr_Inven_det.IdEmpresa AND in_Ing_Egr_Inven.IdSucursal = in_Ing_Egr_Inven_det.IdSucursal AND 
                  in_Ing_Egr_Inven.IdMovi_inven_tipo = in_Ing_Egr_Inven_det.IdMovi_inven_tipo AND in_Ing_Egr_Inven.IdNumMovi = in_Ing_Egr_Inven_det.IdNumMovi INNER JOIN
                  in_Producto ON in_Ing_Egr_Inven_det.IdEmpresa = in_Producto.IdEmpresa AND in_Ing_Egr_Inven_det.IdProducto = in_Producto.IdProducto INNER JOIN
                  ct_punto_cargo ON in_Ing_Egr_Inven_det.IdEmpresa = ct_punto_cargo.IdEmpresa AND in_Ing_Egr_Inven_det.IdPunto_cargo = ct_punto_cargo.IdPunto_cargo LEFT OUTER JOIN
                  Fj_servindustrias.Af_Activo_fijo_x_ct_punto_cargo ON ct_punto_cargo.IdEmpresa = Fj_servindustrias.Af_Activo_fijo_x_ct_punto_cargo.IdEmpresa_PC AND 
                  ct_punto_cargo.IdPunto_cargo = Fj_servindustrias.Af_Activo_fijo_x_ct_punto_cargo.IdPunto_cargo_PC AND ct_punto_cargo.IdEmpresa = Fj_servindustrias.Af_Activo_fijo_x_ct_punto_cargo.IdEmpresa_PC AND 
                  ct_punto_cargo.IdPunto_cargo = Fj_servindustrias.Af_Activo_fijo_x_ct_punto_cargo.IdPunto_cargo_PC AND ct_punto_cargo.IdEmpresa = Fj_servindustrias.Af_Activo_fijo_x_ct_punto_cargo.IdEmpresa_PC AND 
                  ct_punto_cargo.IdPunto_cargo = Fj_servindustrias.Af_Activo_fijo_x_ct_punto_cargo.IdPunto_cargo_PC LEFT OUTER JOIN
                      (SELECT eg_IdEmpresa, eg_IdSucursal, eg_IdMovi_inven_tipo, eg_IdNumMovi, eg_Secuencia, SUM(eg_cantidad) AS cantidad_procesada
                       FROM      Fj_servindustrias.fa_pre_facturacion_det_ing_egr_inven AS det
                       GROUP BY eg_IdEmpresa, eg_IdSucursal, eg_IdMovi_inven_tipo, eg_IdNumMovi, eg_Secuencia) AS movi ON movi.eg_IdEmpresa = in_Ing_Egr_Inven_det.IdEmpresa AND movi.eg_IdSucursal = in_Ing_Egr_Inven_det.IdSucursal AND 
                  movi.eg_IdMovi_inven_tipo = in_Ing_Egr_Inven_det.IdMovi_inven_tipo AND movi.eg_IdNumMovi = in_Ing_Egr_Inven_det.IdNumMovi AND movi.eg_Secuencia = in_Ing_Egr_Inven_det.Secuencia LEFT JOIN
                      (SELECT egreso.IdEmpresa, egreso.IdSucursal, egreso.IdMovi_inven_tipo, egreso.IdNumMovi, egreso.Secuencia, SUM(devoluciones.dm_cantidad) AS cant_devuelta
                       FROM      in_movi_inve_detalle AS devoluciones INNER JOIN
                                         in_movi_inve_detalle AS egreso_apro ON devoluciones.IdEmpresa_dev = egreso_apro.IdEmpresa AND devoluciones.IdSucursal_dev = egreso_apro.IdSucursal AND devoluciones.IdBodega_dev = egreso_apro.IdBodega AND 
                                         devoluciones.IdMovi_inven_tipo_dev = egreso_apro.IdMovi_inven_tipo AND devoluciones.IdNumMovi_dev = egreso_apro.IdNumMovi AND devoluciones.Secuencia_dev = egreso_apro.Secuencia INNER JOIN
                                         in_Ing_Egr_Inven_det AS egreso ON egreso_apro.IdEmpresa = egreso.IdEmpresa_inv AND egreso_apro.IdSucursal = egreso.IdSucursal_inv AND egreso_apro.IdBodega = egreso.IdBodega_inv AND 
                                         egreso_apro.IdMovi_inven_tipo = egreso.IdMovi_inven_tipo_inv AND egreso_apro.IdNumMovi = egreso.IdNumMovi_inv AND egreso_apro.Secuencia = egreso.secuencia_inv
                       GROUP BY egreso.IdEmpresa, egreso.IdSucursal, egreso.IdMovi_inven_tipo, egreso.IdNumMovi, egreso.Secuencia) dev ON in_Ing_Egr_Inven_det.IdEmpresa = dev.IdEmpresa AND 
                  in_Ing_Egr_Inven_det.IdSucursal = dev.IdSucursal AND in_Ing_Egr_Inven_det.IdMovi_inven_tipo = dev.IdMovi_inven_tipo AND in_Ing_Egr_Inven_det.IdNumMovi = dev.IdNumMovi AND 
                  in_Ing_Egr_Inven_det.Secuencia = dev.Secuencia LEFT JOIN
                      (SELECT IdEmpresa, IdActivoFijo, IdCentroCosto, IdCentroCosto_sub_centro_costo
                       FROM      Fj_servindustrias.fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo) tarifario ON Fj_servindustrias.Af_Activo_fijo_x_ct_punto_cargo.IdEmpresa_AF = tarifario.IdEmpresa AND 
                  Fj_servindustrias.Af_Activo_fijo_x_ct_punto_cargo.IdActivoFijo_AF = tarifario.IdActivoFijo
WHERE  (in_Ing_Egr_Inven.signo = '-') AND (in_Ing_Egr_Inven.Estado = 'A') AND (round(round(ABS(in_Ing_Egr_Inven_det.dm_cantidad), 2) - round(ISNULL(movi.cantidad_procesada, 0), 2), 2) > 0)
UNION
SELECT in_Ing_Egr_Inven_det.IdEmpresa, in_Ing_Egr_Inven_det.IdSucursal, in_Ing_Egr_Inven_det.IdMovi_inven_tipo, in_Ing_Egr_Inven_det.IdNumMovi, in_Ing_Egr_Inven_det.Secuencia, in_Ing_Egr_Inven.signo, in_Ing_Egr_Inven.CodMoviInven, 
                  in_Ing_Egr_Inven.cm_fecha, in_Ing_Egr_Inven_det.IdProducto, in_Producto.pr_codigo, in_Producto.pr_descripcion, isnull(in_Ing_Egr_Inven_det.dm_cantidad - isnull(movi.cantidad_procesada, 0), 0) AS dm_cantidad, 
                  ISNULL(in_Ing_Egr_Inven_det.mv_costo, 0) mv_costo, ISNULL(isnull(in_Ing_Egr_Inven_det.dm_cantidad - isnull(movi.cantidad_procesada, 0), 0) * in_Ing_Egr_Inven_det.mv_costo, 0) AS subtotal, NULL nom_punto_cargo, NULL 
                  IdCentroCosto, NULL IdCentroCosto_sub_centro_costo, NULL IdPunto_cargo, NULL IdPunto_cargo_grupo, cast(cast(cp_Aprobacion_Ing_Bod_x_OC.num_documento as numeric) as varchar(20)), tb_persona.pe_nombreCompleto, cp_Aprobacion_Ing_Bod_x_OC.IdProveedor, 
                  'ING_VARIOS' AS Tipo, isnull(0, 0) AS IdActivo, NULL AS eg_codigo
FROM     cp_Aprobacion_Ing_Bod_x_OC INNER JOIN
                  cp_Aprobacion_Ing_Bod_x_OC_det ON cp_Aprobacion_Ing_Bod_x_OC.IdEmpresa = cp_Aprobacion_Ing_Bod_x_OC_det.IdEmpresa AND 
                  cp_Aprobacion_Ing_Bod_x_OC.IdAprobacion = cp_Aprobacion_Ing_Bod_x_OC_det.IdAprobacion INNER JOIN
                  cp_proveedor ON cp_Aprobacion_Ing_Bod_x_OC.IdEmpresa = cp_proveedor.IdEmpresa AND cp_Aprobacion_Ing_Bod_x_OC.IdProveedor = cp_proveedor.IdProveedor INNER JOIN
                  tb_persona ON cp_proveedor.IdPersona = tb_persona.IdPersona RIGHT OUTER JOIN
                  in_Ing_Egr_Inven INNER JOIN
                  in_Motivo_Inven ON in_Ing_Egr_Inven.IdEmpresa = in_Motivo_Inven.IdEmpresa AND in_Ing_Egr_Inven.IdMotivo_Inv = in_Motivo_Inven.IdMotivo_Inv INNER JOIN
                  in_Ing_Egr_Inven_det ON in_Ing_Egr_Inven.IdEmpresa = in_Ing_Egr_Inven_det.IdEmpresa AND in_Ing_Egr_Inven.IdSucursal = in_Ing_Egr_Inven_det.IdSucursal AND 
                  in_Ing_Egr_Inven.IdMovi_inven_tipo = in_Ing_Egr_Inven_det.IdMovi_inven_tipo AND in_Ing_Egr_Inven.IdNumMovi = in_Ing_Egr_Inven_det.IdNumMovi INNER JOIN
                  in_Producto ON in_Ing_Egr_Inven_det.IdEmpresa = in_Producto.IdEmpresa AND in_Ing_Egr_Inven_det.IdProducto = in_Producto.IdProducto ON 
                  cp_Aprobacion_Ing_Bod_x_OC_det.IdEmpresa_Ing_Egr_Inv = in_Ing_Egr_Inven_det.IdEmpresa AND cp_Aprobacion_Ing_Bod_x_OC_det.IdSucursal_Ing_Egr_Inv = in_Ing_Egr_Inven_det.IdSucursal AND 
                  cp_Aprobacion_Ing_Bod_x_OC_det.IdMovi_inven_tipo_Ing_Egr_Inv = in_Ing_Egr_Inven_det.IdMovi_inven_tipo AND cp_Aprobacion_Ing_Bod_x_OC_det.IdNumMovi_Ing_Egr_Inv = in_Ing_Egr_Inven_det.IdNumMovi AND 
                  cp_Aprobacion_Ing_Bod_x_OC_det.Secuencia_Ing_Egr_Inv = in_Ing_Egr_Inven_det.Secuencia LEFT JOIN
                      (SELECT det.in_IdEmpresa, det.in_IdSucursal, det.in_IdMovi_inven_tipo, det.in_IdNumMovi, det.in_Secuencia, sum(det.in_cantidad) cantidad_procesada
                       FROM      Fj_servindustrias.fa_pre_facturacion_det_ing_egr_inven det
                       GROUP BY det.in_IdEmpresa, det.in_IdSucursal, det.in_IdMovi_inven_tipo, det.in_IdNumMovi, det.in_Secuencia) movi ON movi.in_IdEmpresa = in_Ing_Egr_Inven_det.IdEmpresa AND 
                  movi.in_IdSucursal = in_Ing_Egr_Inven_det.IdSucursal AND movi.in_IdMovi_inven_tipo = in_Ing_Egr_Inven_det.IdMovi_inven_tipo AND movi.in_IdNumMovi = in_Ing_Egr_Inven_det.IdNumMovi AND 
                  movi.in_Secuencia = in_Ing_Egr_Inven_det.Secuencia
WHERE  (in_Ing_Egr_Inven.signo = '+') AND (in_Ing_Egr_Inven.Estado = 'A') AND (in_Motivo_Inven.Genera_Movi_Inven = 'S') AND (ABS(in_Ing_Egr_Inven_det.dm_cantidad) - ISNULL(movi.cantidad_procesada, 0) > 0)