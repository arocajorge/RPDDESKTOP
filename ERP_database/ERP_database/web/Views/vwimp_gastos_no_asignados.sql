SELECT        comp_det.IdEmpresa, comp_det.IdTipoCbte, comp_det.IdCbteCble, comp_det.secuencia, comp_det.IdCtaCble, CASE WHEN comp_det.dc_Valor < 0 THEN comp_det.dc_Valor * - 1 ELSE comp_det.dc_Valor END AS dc_Valor, 
                         comp_det.dc_Observacion, ct_cuentas.pc_Cuenta
FROM            dbo.ct_cbtecble_det AS comp_det INNER JOIN
                         dbo.ct_plancta AS ct_cuentas ON comp_det.IdEmpresa = ct_cuentas.IdEmpresa AND comp_det.IdCtaCble = ct_cuentas.IdCtaCble INNER JOIN
                         dbo.ct_cbtecble AS comp ON comp_det.IdEmpresa = comp.IdEmpresa AND comp_det.IdTipoCbte = comp.IdTipoCbte AND comp_det.IdCbteCble = comp.IdCbteCble
WHERE        (NOT EXISTS
                             (SELECT        IdEmpresa, IdOrdenCompra_ext, IdEmpresa_ct, IdTipoCbte, IdCbteCble, secuencia_ct, IdGasto_tipo
                               FROM            dbo.imp_orden_compra_ext_ct_cbteble_det_gastos AS imp
                               WHERE        (comp_det.IdEmpresa = IdEmpresa) AND (comp_det.IdTipoCbte = IdTipoCbte) AND (comp_det.IdCbteCble = IdCbteCble) AND (comp.cb_Estado = 'A') AND (comp.cb_Observacion NOT LIKE '%REVERSO%') AND 
                                                         (comp_det.dc_Observacion NOT LIKE '%REVERSO%'))) AND (NOT EXISTS
                             (SELECT        IdEmpresa, IdTipoCbte, IdCbteCble, IdEmpresa_Anu, IdTipoCbte_Anu, IdCbteCble_Anu, ip
                               FROM            dbo.ct_cbtecble_Reversado AS rev
                               WHERE        (comp_det.IdEmpresa = IdEmpresa) AND (comp_det.IdTipoCbte = IdTipoCbte) AND (comp_det.IdCbteCble = IdCbteCble) AND (comp.cb_Observacion NOT LIKE '%REVERSO%') AND 
                                                         (comp_det.dc_Observacion NOT LIKE '%REVERSO%'))) AND (NOT EXISTS
                             (SELECT        IdEmpresa
                               FROM            dbo.imp_liquidacion AS rev
                               WHERE        (comp_det.IdEmpresa = IdEmpresa) AND (comp_det.IdTipoCbte = IdTipoCbte_ct) AND (comp_det.IdCbteCble = IdCbteCble_ct) AND (comp.cb_Observacion NOT LIKE '%REVERSO%') AND 
                                                         (comp_det.dc_Observacion NOT LIKE '%REVERSO%')))