CREATE VIEW [web].[VWBAN_002]
AS
SELECT        ba_Cbte_Ban_tipo.CodTipoCbteBan, ba_Cbte_Ban.IdEmpresa, ba_Cbte_Ban.IdCbteCble, ba_Cbte_Ban.IdTipocbte, ba_Cbte_Ban.IdBanco, ba_Banco_Cuenta.ba_descripcion, ba_Cbte_Ban.cb_Fecha, 
                         ba_Cbte_Ban.cb_Observacion, ba_Cbte_Ban.Estado, ba_Cbte_Ban.IdTipoNota, ba_tipo_nota.Descripcion AS Descripcion_TipoNota, 'Ninguno' AS NomBeneficiario, ct_cbtecble_det.IdCtaCble, ct_plancta.pc_Cuenta, 
                         ct_cbtecble_det.dc_Valor, CASE WHEN ct_cbtecble_det.dc_Valor > 0 THEN ct_cbtecble_det.dc_Valor ELSE 0 END AS dc_Valor_Debe, CASE WHEN ct_cbtecble_det.dc_Valor < 0 THEN ABS(ct_cbtecble_det.dc_Valor) 
                         ELSE 0 END AS dc_Valor_Haber
FROM            ct_cbtecble_det INNER JOIN
                         ct_plancta ON ct_cbtecble_det.IdEmpresa = ct_plancta.IdEmpresa AND ct_cbtecble_det.IdCtaCble = ct_plancta.IdCtaCble INNER JOIN
                         ba_Cbte_Ban_tipo INNER JOIN
                         ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo ON ba_Cbte_Ban_tipo.CodTipoCbteBan = ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo.CodTipoCbteBan INNER JOIN
                         ba_Cbte_Ban ON ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo.IdEmpresa = ba_Cbte_Ban.IdEmpresa AND ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo.IdTipoCbteCble = ba_Cbte_Ban.IdTipocbte INNER JOIN
                         ba_Banco_Cuenta ON ba_Cbte_Ban.IdEmpresa = ba_Banco_Cuenta.IdEmpresa AND ba_Cbte_Ban.IdBanco = ba_Banco_Cuenta.IdBanco INNER JOIN
                         ba_tipo_nota ON ba_Cbte_Ban.IdEmpresa = ba_tipo_nota.IdEmpresa AND ba_Cbte_Ban.IdTipoNota = ba_tipo_nota.IdTipoNota ON ct_cbtecble_det.IdEmpresa = ba_Cbte_Ban.IdEmpresa AND 
                         ct_cbtecble_det.IdTipoCbte = ba_Cbte_Ban.IdTipocbte AND ct_cbtecble_det.IdCbteCble = ba_Cbte_Ban.IdCbteCble
where not exists(
select f.mba_IdEmpresa from ba_Caja_Movimiento_x_Cbte_Ban_x_Deposito as f
where ba_Cbte_Ban.IdEmpresa = f.mba_IdEmpresa
and ba_Cbte_Ban.IdTipocbte = f.mba_IdTipocbte
and ba_Cbte_Ban.IdCbteCble = f.mba_IdCbteCble
)
UNION ALL
SELECT        dbo.ba_Cbte_Ban_tipo.CodTipoCbteBan, dbo.ba_Cbte_Ban.IdEmpresa, dbo.ba_Cbte_Ban.IdCbteCble, dbo.ba_Cbte_Ban.IdTipocbte, dbo.ba_Cbte_Ban.IdBanco, dbo.ba_Banco_Cuenta.ba_descripcion, 
                         dbo.ba_Cbte_Ban.cb_Fecha, dbo.ba_Cbte_Ban.cb_Observacion, dbo.ba_Cbte_Ban.Estado, dbo.ba_Cbte_Ban.IdTipoNota, dbo.ba_tipo_nota.Descripcion AS Descripcion_TipoNota, tb_persona.pe_nombreCompleto AS NomBeneficiario, 
                         dbo.ct_cbtecble_det.IdCtaCble, dbo.ct_plancta.pc_Cuenta, dbo.ct_cbtecble_det.dc_Valor, CASE WHEN ct_cbtecble_det.dc_Valor > 0 THEN ct_cbtecble_det.dc_Valor ELSE 0 END AS dc_Valor_Debe, 
                         CASE WHEN ct_cbtecble_det.dc_Valor < 0 THEN ABS(ct_cbtecble_det.dc_Valor) ELSE 0 END AS dc_Valor_Haber
FROM            dbo.ct_cbtecble_det INNER JOIN
                         dbo.ct_plancta ON dbo.ct_cbtecble_det.IdEmpresa = dbo.ct_plancta.IdEmpresa AND dbo.ct_cbtecble_det.IdCtaCble = dbo.ct_plancta.IdCtaCble INNER JOIN
                         dbo.ba_Cbte_Ban_tipo INNER JOIN
                         dbo.ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo ON dbo.ba_Cbte_Ban_tipo.CodTipoCbteBan = dbo.ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo.CodTipoCbteBan INNER JOIN
                         dbo.ba_Cbte_Ban ON dbo.ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo.IdEmpresa = dbo.ba_Cbte_Ban.IdEmpresa AND dbo.ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo.IdTipoCbteCble = dbo.ba_Cbte_Ban.IdTipocbte INNER JOIN
                         dbo.ba_Banco_Cuenta ON dbo.ba_Cbte_Ban.IdEmpresa = dbo.ba_Banco_Cuenta.IdEmpresa AND dbo.ba_Cbte_Ban.IdBanco = dbo.ba_Banco_Cuenta.IdBanco INNER JOIN
                         dbo.ba_tipo_nota ON dbo.ba_Cbte_Ban.IdEmpresa = dbo.ba_tipo_nota.IdEmpresa AND dbo.ba_Cbte_Ban.IdTipoNota = dbo.ba_tipo_nota.IdTipoNota ON dbo.ct_cbtecble_det.IdEmpresa = dbo.ba_Cbte_Ban.IdEmpresa AND 
                         dbo.ct_cbtecble_det.IdTipoCbte = dbo.ba_Cbte_Ban.IdTipocbte AND dbo.ct_cbtecble_det.IdCbteCble = dbo.ba_Cbte_Ban.IdCbteCble INNER JOIN
                         dbo.ba_Caja_Movimiento_x_Cbte_Ban_x_Deposito ON dbo.ba_Cbte_Ban.IdEmpresa = dbo.ba_Caja_Movimiento_x_Cbte_Ban_x_Deposito.mba_IdEmpresa AND 
                         dbo.ba_Cbte_Ban.IdCbteCble = dbo.ba_Caja_Movimiento_x_Cbte_Ban_x_Deposito.mba_IdCbteCble AND dbo.ba_Cbte_Ban.IdTipocbte = dbo.ba_Caja_Movimiento_x_Cbte_Ban_x_Deposito.mba_IdTipocbte INNER JOIN
                         dbo.caj_Caja_Movimiento ON dbo.ba_Caja_Movimiento_x_Cbte_Ban_x_Deposito.mcj_IdEmpresa = dbo.caj_Caja_Movimiento.IdEmpresa AND 
                         dbo.ba_Caja_Movimiento_x_Cbte_Ban_x_Deposito.mcj_IdCbteCble = dbo.caj_Caja_Movimiento.IdCbteCble AND 
                         dbo.ba_Caja_Movimiento_x_Cbte_Ban_x_Deposito.mcj_IdTipocbte = dbo.caj_Caja_Movimiento.IdTipocbte INNER JOIN
                         dbo.tb_persona ON dbo.caj_Caja_Movimiento.IdPersona = dbo.tb_persona.IdPersona