create view web.vwimp_gastos_no_asignados as
SELECT        comp_det.IdEmpresa, comp_det.IdTipoCbte, comp_det.IdCbteCble, comp_det.secuencia, comp_det.IdCtaCble, case when  comp_det.dc_Valor<0 then  comp_det.dc_Valor*-1 else comp_det.dc_Valor end  dc_Valor, comp_det.dc_Observacion, ct_cuentas.pc_Cuenta
FROM            dbo.ct_cbtecble_det AS comp_det INNER JOIN
                         dbo.ct_plancta AS ct_cuentas ON comp_det.IdEmpresa = ct_cuentas.IdEmpresa AND comp_det.IdCtaCble = ct_cuentas.IdCtaCble INNER JOIN
                         dbo.ct_cbtecble AS comp ON comp_det.IdEmpresa = comp.IdEmpresa AND comp_det.IdTipoCbte = comp.IdTipoCbte AND comp_det.IdCbteCble = comp.IdCbteCble	
	where not exists
	(select * from imp_orden_compra_ext_ct_cbteble_det_gastos imp
	where comp_det.IdEmpresa=imp.IdEmpresa
	and comp_det.IdTipoCbte=imp.IdTipoCbte
	and comp_det.IdCbteCble=imp.IdCbteCble
	and comp.cb_Estado='A'
	and comp.cb_Observacion not like '%REVERSO%'
	and comp_det.dc_Observacion not like '%REVERSO%'
	)
	and not exists
	(select * from ct_cbtecble_Reversado rev
	where comp_det.IdEmpresa=rev.IdEmpresa
	and comp_det.IdTipoCbte=rev.IdTipoCbte
	and comp_det.IdCbteCble=rev.IdCbteCble
    and comp.cb_Observacion not like '%REVERSO%'
    and comp_det.dc_Observacion not like '%REVERSO%'
	)
