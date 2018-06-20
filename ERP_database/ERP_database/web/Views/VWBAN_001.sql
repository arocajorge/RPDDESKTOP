CREATE VIEW web.VWBAN_001
AS
SELECT        ba_Cbte_Ban_tipo.CodTipoCbteBan, ba_Cbte_Ban.IdEmpresa, ba_Cbte_Ban.IdCbteCble, ba_Cbte_Ban.IdTipocbte, ba_Cbte_Ban.IdBanco, ba_Banco_Cuenta.ba_descripcion, ba_Cbte_Ban.cb_Fecha, 
                         ba_Cbte_Ban.cb_Observacion, ba_Cbte_Ban.Estado, ba_Cbte_Ban.IdTipoNota, ba_tipo_nota.Descripcion AS Descripcion_TipoNota, 'Ninguno' AS NomBeneficiario, ct_cbtecble_det.IdCtaCble, ct_plancta.pc_Cuenta, 
                         ct_cbtecble_det.dc_Valor, case when ct_cbtecble_det.dc_Valor > 0 then ct_cbtecble_det.dc_Valor else 0 end as dc_Valor_Debe, case when ct_cbtecble_det.dc_Valor < 0 then ABS(ct_cbtecble_det.dc_Valor) else 0 end as dc_Valor_Haber
FROM            ct_cbtecble_det INNER JOIN
                         ct_plancta ON ct_cbtecble_det.IdEmpresa = ct_plancta.IdEmpresa AND ct_cbtecble_det.IdCtaCble = ct_plancta.IdCtaCble INNER JOIN
                         ba_Cbte_Ban_tipo INNER JOIN
                         ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo ON ba_Cbte_Ban_tipo.CodTipoCbteBan = ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo.CodTipoCbteBan INNER JOIN
                         ba_Cbte_Ban ON ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo.IdEmpresa = ba_Cbte_Ban.IdEmpresa AND ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo.IdTipoCbteCble = ba_Cbte_Ban.IdTipocbte INNER JOIN
                         ba_Banco_Cuenta ON ba_Cbte_Ban.IdEmpresa = ba_Banco_Cuenta.IdEmpresa AND ba_Cbte_Ban.IdBanco = ba_Banco_Cuenta.IdBanco INNER JOIN
                         ba_tipo_nota ON ba_Cbte_Ban.IdEmpresa = ba_tipo_nota.IdEmpresa AND ba_Cbte_Ban.IdTipoNota = ba_tipo_nota.IdTipoNota ON ct_cbtecble_det.IdEmpresa = ba_Cbte_Ban.IdEmpresa AND 
                         ct_cbtecble_det.IdTipoCbte = ba_Cbte_Ban.IdTipocbte AND ct_cbtecble_det.IdCbteCble = ba_Cbte_Ban.IdCbteCble
WHERE        (NOT EXISTS
                             (SELECT        IdEmpresa, Idcancelacion, Secuencia, IdEmpresa_op, IdOrdenPago_op, Secuencia_op, IdEmpresa_op_padre, IdOrdenPago_op_padre, Secuencia_op_padre, IdEmpresa_cxp, IdTipoCbte_cxp, IdCbteCble_cxp, 
                                                         IdEmpresa_pago, IdTipoCbte_pago, IdCbteCble_pago, MontoAplicado, SaldoAnterior, SaldoActual, Observacion, fechaTransaccion
                               FROM            cp_orden_pago_cancelaciones AS f
                               WHERE        (IdEmpresa_pago = ba_Cbte_Ban.IdEmpresa) AND (IdTipoCbte_pago = ba_Cbte_Ban.IdTipocbte) AND (IdCbteCble_pago = ba_Cbte_Ban.IdCbteCble)))
UNION ALL
SELECT        ba_Cbte_Ban_tipo.CodTipoCbteBan, ba_Cbte_Ban.IdEmpresa, ba_Cbte_Ban.IdCbteCble, ba_Cbte_Ban.IdTipocbte, ba_Cbte_Ban.IdBanco, ba_Banco_Cuenta.ba_descripcion, ba_Cbte_Ban.cb_Fecha, 
                         ba_Cbte_Ban.cb_Observacion, ba_Cbte_Ban.Estado, ba_Cbte_Ban.IdTipoNota, ba_tipo_nota.Descripcion AS Descripcion_TipoNota, tb_persona.pe_nombreCompleto, ct_cbtecble_det.IdCtaCble, ct_plancta.pc_Cuenta, 
                         ct_cbtecble_det.dc_Valor, case when ct_cbtecble_det.dc_Valor > 0 then ct_cbtecble_det.dc_Valor else 0 end as dc_Valor_Debe, case when ct_cbtecble_det.dc_Valor < 0 then ABS(ct_cbtecble_det.dc_Valor) else 0 end as dc_Valor_Haber
FROM            tb_persona INNER JOIN
                         cp_orden_pago ON tb_persona.IdPersona = cp_orden_pago.IdPersona INNER JOIN
                         ba_Cbte_Ban_tipo INNER JOIN
                         ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo ON ba_Cbte_Ban_tipo.CodTipoCbteBan = ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo.CodTipoCbteBan INNER JOIN
                         ba_Cbte_Ban ON ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo.IdEmpresa = ba_Cbte_Ban.IdEmpresa AND ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo.IdTipoCbteCble = ba_Cbte_Ban.IdTipocbte INNER JOIN
                         ba_Banco_Cuenta ON ba_Cbte_Ban.IdEmpresa = ba_Banco_Cuenta.IdEmpresa AND ba_Cbte_Ban.IdBanco = ba_Banco_Cuenta.IdBanco INNER JOIN
                         ba_tipo_nota ON ba_Cbte_Ban.IdEmpresa = ba_tipo_nota.IdEmpresa AND ba_Cbte_Ban.IdTipoNota = ba_tipo_nota.IdTipoNota INNER JOIN
                         cp_orden_pago_cancelaciones ON ba_Cbte_Ban.IdEmpresa = cp_orden_pago_cancelaciones.IdEmpresa_pago AND ba_Cbte_Ban.IdCbteCble = cp_orden_pago_cancelaciones.IdCbteCble_pago AND 
                         ba_Cbte_Ban.IdTipocbte = cp_orden_pago_cancelaciones.IdTipoCbte_pago ON cp_orden_pago.IdEmpresa = cp_orden_pago_cancelaciones.IdEmpresa_op AND 
                         cp_orden_pago.IdOrdenPago = cp_orden_pago_cancelaciones.IdOrdenPago_op INNER JOIN
                         ct_cbtecble_det ON ba_Cbte_Ban.IdEmpresa = ct_cbtecble_det.IdEmpresa AND ba_Cbte_Ban.IdTipocbte = ct_cbtecble_det.IdTipoCbte AND ba_Cbte_Ban.IdCbteCble = ct_cbtecble_det.IdCbteCble INNER JOIN
                         ct_plancta ON ct_cbtecble_det.IdCtaCble = ct_plancta.IdCtaCble AND ct_cbtecble_det.IdEmpresa = ct_plancta.IdEmpresa