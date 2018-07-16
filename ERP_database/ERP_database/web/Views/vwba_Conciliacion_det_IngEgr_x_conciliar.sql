create view [web].[vwba_Conciliacion_det_IngEgr_x_conciliar]
as
SELECT        dbo.ct_cbtecble_det.IdEmpresa, dbo.ct_cbtecble_det.IdTipoCbte, dbo.ct_cbtecble_det.IdCbteCble, dbo.ct_cbtecble_det.secuencia, dbo.ba_Banco_Cuenta.IdBanco, dbo.ct_cbtecble_det.IdCtaCble, dbo.ct_cbtecble_det.dc_Valor, 
                         dbo.ba_Banco_Cuenta.ba_descripcion, dbo.ba_Cbte_Ban.cb_Fecha, dbo.ba_Cbte_Ban.cb_Observacion, dbo.ba_Cbte_Ban.cb_Cheque, dbo.ct_cbtecble_tipo.tc_TipoCbte
FROM            dbo.ba_Cbte_Ban INNER JOIN
                         dbo.ct_cbtecble_det ON dbo.ba_Cbte_Ban.IdEmpresa = dbo.ct_cbtecble_det.IdEmpresa AND dbo.ba_Cbte_Ban.IdTipocbte = dbo.ct_cbtecble_det.IdTipoCbte AND 
                         dbo.ba_Cbte_Ban.IdCbteCble = dbo.ct_cbtecble_det.IdCbteCble INNER JOIN
                         dbo.ba_Banco_Cuenta ON dbo.ba_Cbte_Ban.IdEmpresa = dbo.ba_Banco_Cuenta.IdEmpresa AND dbo.ba_Cbte_Ban.IdBanco = dbo.ba_Banco_Cuenta.IdBanco INNER JOIN
                         dbo.ct_cbtecble_tipo ON dbo.ba_Cbte_Ban.IdEmpresa = dbo.ct_cbtecble_tipo.IdEmpresa AND dbo.ba_Cbte_Ban.IdTipocbte = dbo.ct_cbtecble_tipo.IdTipoCbte
WHERE        (dbo.ct_cbtecble_det.dc_para_conciliar = 1) AND (dbo.ba_Cbte_Ban.Estado = 'A') AND (NOT EXISTS
                             (SELECT        IdEmpresa
                               FROM            dbo.ba_Conciliacion_det_IngEgr AS f
                               WHERE        (dbo.ct_cbtecble_det.IdEmpresa = IdEmpresa) AND (dbo.ct_cbtecble_det.IdTipoCbte = IdTipocbte) AND (dbo.ct_cbtecble_det.IdCbteCble = IdCbteCble) AND (dbo.ct_cbtecble_det.secuencia = SecuenciaCbteCble)))