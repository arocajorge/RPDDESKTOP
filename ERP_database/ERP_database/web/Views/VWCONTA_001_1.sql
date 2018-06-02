CREATE VIEW web.VWCONTA_001
AS
SELECT ct_cbtecble_det.IdEmpresa, ct_cbtecble_det.IdTipoCbte, ct_cbtecble_det.IdCbteCble, ct_cbtecble_det.secuencia, ct_cbtecble.cb_Fecha, ct_cbtecble.cb_Observacion, ct_cbtecble.cb_Estado, ct_cbtecble_det.IdCtaCble, 
                  ct_plancta.pc_Cuenta, ct_cbtecble_det.dc_Valor, CASE WHEN ct_cbtecble_det.dc_Valor > 0 THEN ABS(ct_cbtecble_det.dc_Valor) ELSE 0 END AS dc_Valor_Debe, 
                  CASE WHEN ct_cbtecble_det.dc_Valor < 0 THEN ABS(ct_cbtecble_det.dc_Valor) ELSE 0 END AS dc_Valor_Haber, ct_cbtecble_tipo.tc_TipoCbte, ct_cbtecble_det.dc_Observacion
FROM     ct_cbtecble INNER JOIN
                  ct_cbtecble_det ON ct_cbtecble.IdEmpresa = ct_cbtecble_det.IdEmpresa AND ct_cbtecble.IdTipoCbte = ct_cbtecble_det.IdTipoCbte AND ct_cbtecble.IdCbteCble = ct_cbtecble_det.IdCbteCble INNER JOIN
                  ct_plancta ON ct_cbtecble_det.IdEmpresa = ct_plancta.IdEmpresa AND ct_cbtecble_det.IdCtaCble = ct_plancta.IdCtaCble INNER JOIN
                  ct_cbtecble_tipo ON ct_cbtecble.IdEmpresa = ct_cbtecble_tipo.IdEmpresa AND ct_cbtecble.IdTipoCbte = ct_cbtecble_tipo.IdTipoCbte