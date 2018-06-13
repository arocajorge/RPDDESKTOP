CREATE VIEW web.VWCXP_001
AS
SELECT dbo.cp_orden_giro.IdEmpresa, dbo.cp_orden_giro.IdCbteCble_Ogiro, dbo.cp_orden_giro.IdTipoCbte_Ogiro, dbo.cp_TipoDocumento.Codigo, dbo.cp_TipoDocumento.Descripcion, dbo.cp_codigo_SRI.codigoSRI, 
                  dbo.cp_codigo_SRI.co_descripcion, dbo.tb_empresa.em_nombre, dbo.tb_sucursal.Su_Descripcion, per.pe_nombreCompleto AS pr_nombre, dbo.ct_centro_costo.Centro_costo AS nom_CentroCosto, dbo.cp_orden_giro.IdIden_credito, 
                  dbo.cp_orden_giro.IdOrden_giro_Tipo, dbo.cp_orden_giro.IdProveedor, dbo.ct_centro_costo_sub_centro_costo.Centro_costo AS nom_CentroCosto_sub_centro_costo, dbo.cp_orden_giro.co_fechaOg, dbo.cp_orden_giro.co_serie, 
                  dbo.cp_orden_giro.co_factura, dbo.cp_orden_giro.co_FechaFactura, dbo.cp_orden_giro.co_FechaFactura_vct, dbo.cp_orden_giro.co_observacion, dbo.cp_orden_giro.co_subtotal_iva, dbo.cp_orden_giro.co_subtotal_siniva, 
                  dbo.cp_orden_giro.co_baseImponible, dbo.cp_orden_giro.co_total, dbo.cp_orden_giro.co_valorpagar, dbo.ct_cbtecble_det.secuencia, dbo.ct_cbtecble_det.IdCtaCble, dbo.ct_plancta.pc_Cuenta, 
                  ISNULL(dbo.ct_cbtecble_det.IdCentroCosto, '') AS idCentroCosto, ISNULL(dbo.ct_cbtecble_det.IdCentroCosto_sub_centro_costo, '') AS idCentroCosto_sub_centro_costo, dbo.ct_cbtecble_det.dc_Valor,
				  CASE WHEN dbo.ct_cbtecble_det.dc_Valor > 0 THEN dbo.ct_cbtecble_det.dc_Valor ELSE 0 END AS dc_Valor_Debe,  CASE WHEN dbo.ct_cbtecble_det.dc_Valor < 0 THEN ABS(dbo.ct_cbtecble_det.dc_Valor) ELSE 0 END AS dc_Valor_Haber,
                  dbo.ct_cbtecble_det.dc_Observacion, dbo.ct_punto_cargo.IdPunto_cargo, dbo.ct_punto_cargo.nom_punto_cargo, dbo.ct_punto_cargo_grupo.IdPunto_cargo_grupo, dbo.ct_punto_cargo_grupo.nom_punto_cargo_grupo
FROM     dbo.cp_orden_giro INNER JOIN
                  dbo.tb_sucursal ON dbo.cp_orden_giro.IdEmpresa = dbo.tb_sucursal.IdEmpresa AND dbo.cp_orden_giro.IdSucursal = dbo.tb_sucursal.IdSucursal INNER JOIN
                  dbo.tb_empresa ON dbo.tb_sucursal.IdEmpresa = dbo.tb_empresa.IdEmpresa INNER JOIN
                  dbo.cp_proveedor ON dbo.cp_orden_giro.IdEmpresa = dbo.cp_proveedor.IdEmpresa AND dbo.cp_orden_giro.IdProveedor = dbo.cp_proveedor.IdProveedor INNER JOIN
                  dbo.cp_TipoDocumento ON dbo.cp_orden_giro.IdOrden_giro_Tipo = dbo.cp_TipoDocumento.CodTipoDocumento INNER JOIN
                  dbo.ct_cbtecble_det ON dbo.cp_orden_giro.IdEmpresa = dbo.ct_cbtecble_det.IdEmpresa AND dbo.cp_orden_giro.IdTipoCbte_Ogiro = dbo.ct_cbtecble_det.IdTipoCbte AND 
                  dbo.cp_orden_giro.IdCbteCble_Ogiro = dbo.ct_cbtecble_det.IdCbteCble INNER JOIN
                  dbo.cp_codigo_SRI ON dbo.cp_orden_giro.IdIden_credito = dbo.cp_codigo_SRI.IdCodigo_SRI INNER JOIN
                  dbo.ct_plancta ON dbo.ct_cbtecble_det.IdEmpresa = dbo.ct_plancta.IdEmpresa AND dbo.ct_cbtecble_det.IdCtaCble = dbo.ct_plancta.IdCtaCble LEFT OUTER JOIN
                  dbo.ct_punto_cargo_grupo ON dbo.ct_cbtecble_det.IdEmpresa = dbo.ct_punto_cargo_grupo.IdEmpresa AND dbo.ct_cbtecble_det.IdPunto_cargo_grupo = dbo.ct_punto_cargo_grupo.IdPunto_cargo_grupo LEFT OUTER JOIN
                  dbo.ct_punto_cargo ON dbo.ct_cbtecble_det.IdEmpresa = dbo.ct_punto_cargo.IdEmpresa AND dbo.ct_cbtecble_det.IdPunto_cargo = dbo.ct_punto_cargo.IdPunto_cargo LEFT OUTER JOIN
                  dbo.ct_centro_costo ON dbo.ct_cbtecble_det.IdEmpresa = dbo.ct_centro_costo.IdEmpresa AND dbo.ct_cbtecble_det.IdCentroCosto = dbo.ct_centro_costo.IdCentroCosto LEFT OUTER JOIN
                  dbo.ct_centro_costo_sub_centro_costo ON dbo.ct_cbtecble_det.IdEmpresa = dbo.ct_centro_costo_sub_centro_costo.IdEmpresa AND dbo.ct_cbtecble_det.IdCentroCosto = dbo.ct_centro_costo_sub_centro_costo.IdCentroCosto AND 
                  dbo.ct_cbtecble_det.IdCentroCosto_sub_centro_costo = dbo.ct_centro_costo_sub_centro_costo.IdCentroCosto_sub_centro_costo INNER JOIN
                  dbo.tb_persona AS per ON dbo.cp_proveedor.IdPersona = per.IdPersona