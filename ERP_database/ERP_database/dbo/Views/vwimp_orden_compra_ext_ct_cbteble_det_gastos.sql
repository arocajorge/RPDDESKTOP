CREATE VIEW [dbo].[vwimp_orden_compra_ext_ct_cbteble_det_gastos]
AS
SELECT ISNULL(ROW_NUMBER() OVER (ORDER BY A.IdEmpresa), 0) AS IdRow, A.*
FROM     (SELECT imp_orden_compra_ext.IdEmpresa, imp_orden_compra_ext.IdOrdenCompra_ext, ct_cbtecble_det.IdEmpresa AS IdEmpresa_ct, ct_cbtecble_det.IdTipoCbte, ct_cbtecble_det.IdCbteCble, 
                                    ct_cbtecble_det.secuencia AS secuencia_ct, ct_cbtecble_det.IdCtaCble, ct_cbtecble.cb_Fecha, ct_cbtecble_det.dc_Valor, ct_cbtecble.cb_Observacion, NULL AS IdGasto_tipo, isnull(cast(0 as bit),0) seleccionado
                  FROM      imp_orden_compra_ext INNER JOIN
                                    ct_cbtecble_det ON imp_orden_compra_ext.IdCtaCble_importacion = ct_cbtecble_det.IdCtaCble AND imp_orden_compra_ext.IdEmpresa = ct_cbtecble_det.IdEmpresa INNER JOIN
                                    ct_cbtecble ON ct_cbtecble_det.IdEmpresa = ct_cbtecble.IdEmpresa AND ct_cbtecble_det.IdTipoCbte = ct_cbtecble.IdTipoCbte AND ct_cbtecble_det.IdCbteCble = ct_cbtecble.IdCbteCble
                  WHERE   NOT EXISTS
                                        (SELECT ig.IdEmpresa
                                         FROM      imp_orden_compra_ext_ct_cbteble_det_gastos ig
                                         WHERE   ct_cbtecble_det.IdEmpresa = ig.IdEmpresa_ct AND ct_cbtecble_det.IdTipoCbte = ig.IdTipoCbte AND ct_cbtecble_det.IdCbteCble = ig.IdCbteCble AND ct_cbtecble_det.secuencia = ig.secuencia_ct) AND 
                                    ct_cbtecble.cb_Estado = 'A' AND NOT EXISTS
                                        (SELECT rev.IdEmpresa
                                         FROM      ct_cbtecble_Reversado rev
                                         WHERE   ct_cbtecble.IdEmpresa = rev.IdEmpresa_Anu AND ct_cbtecble.IdTipoCbte = rev.IdTipoCbte_Anu AND ct_cbtecble.IdCbteCble = rev.IdCbteCble_Anu) AND ct_cbtecble_det.dc_Valor > 0
                  UNION ALL
                  SELECT imp_orden_compra_ext.IdEmpresa, imp_orden_compra_ext.IdOrdenCompra_ext, ct_cbtecble_det.IdEmpresa AS IdEmpresa_ct, ct_cbtecble_det.IdTipoCbte, ct_cbtecble_det.IdCbteCble, 
                                    ct_cbtecble_det.secuencia AS secuencia_ct, ct_cbtecble_det.IdCtaCble, ct_cbtecble.cb_Fecha, ct_cbtecble_det.dc_Valor, ct_cbtecble.cb_Observacion, imp_orden_compra_ext_ct_cbteble_det_gastos.IdGasto_tipo,
									isnull(cast(1 as bit),0) seleccionado
                  FROM     ct_cbtecble INNER JOIN
                                    ct_cbtecble_det ON ct_cbtecble.IdEmpresa = ct_cbtecble_det.IdEmpresa AND ct_cbtecble.IdTipoCbte = ct_cbtecble_det.IdTipoCbte AND ct_cbtecble.IdCbteCble = ct_cbtecble_det.IdCbteCble INNER JOIN
                                    imp_orden_compra_ext_ct_cbteble_det_gastos ON ct_cbtecble_det.IdEmpresa = imp_orden_compra_ext_ct_cbteble_det_gastos.IdEmpresa_ct AND 
                                    ct_cbtecble_det.IdTipoCbte = imp_orden_compra_ext_ct_cbteble_det_gastos.IdTipoCbte AND ct_cbtecble_det.IdCbteCble = imp_orden_compra_ext_ct_cbteble_det_gastos.IdCbteCble AND 
                                    ct_cbtecble_det.secuencia = imp_orden_compra_ext_ct_cbteble_det_gastos.secuencia_ct INNER JOIN
                                    imp_orden_compra_ext ON imp_orden_compra_ext_ct_cbteble_det_gastos.IdEmpresa = imp_orden_compra_ext.IdEmpresa AND 
                                    imp_orden_compra_ext_ct_cbteble_det_gastos.IdOrdenCompra_ext = imp_orden_compra_ext.IdOrdenCompra_ext
                  WHERE  NOT EXISTS
                                        (SELECT rev.IdEmpresa
                                         FROM      ct_cbtecble_Reversado rev
                                         WHERE   ct_cbtecble.IdEmpresa = rev.IdEmpresa_Anu AND ct_cbtecble.IdTipoCbte = rev.IdTipoCbte_Anu AND ct_cbtecble.IdCbteCble = rev.IdCbteCble_Anu) AND ct_cbtecble_det.dc_Valor > 0) A