CREATE VIEW web.VWCXC_002_diario
AS
SELECT        cxc_cobro_det.IdEmpresa, cxc_cobro_det.IdSucursal, cxc_cobro_det.IdCobro, cxc_cobro_det.secuencial, cxc_cobro_det.dc_TipoDocumento, cxc_cobro_det.IdBodega_Cbte, cxc_cobro_det.IdCbte_vta_nota, 
                         cxc_cobro_det_x_ct_cbtecble_det.IdEmpresa_ct, cxc_cobro_det_x_ct_cbtecble_det.IdTipoCbte_ct, cxc_cobro_det_x_ct_cbtecble_det.IdCbteCble_ct, ct_cbtecble_det.IdCtaCble, ct_plancta.pc_Cuenta, 
                         ct_cbtecble_det.dc_Valor, CASE WHEN ct_cbtecble_det.dc_Valor > 0 THEN ct_cbtecble_det.dc_Valor ELSE 0 END AS dc_Valor_Debe,
						 CASE WHEN ct_cbtecble_det.dc_Valor < 0 THEN ABS(ct_cbtecble_det.dc_Valor) ELSE 0 END AS dc_Valor_Haber
FROM            ct_plancta INNER JOIN
                         ct_cbtecble_det ON ct_plancta.IdEmpresa = ct_cbtecble_det.IdEmpresa AND ct_plancta.IdCtaCble = ct_cbtecble_det.IdCtaCble INNER JOIN
                         cxc_cobro_det_x_ct_cbtecble_det ON ct_cbtecble_det.IdEmpresa = cxc_cobro_det_x_ct_cbtecble_det.IdEmpresa_ct AND ct_cbtecble_det.IdTipoCbte = cxc_cobro_det_x_ct_cbtecble_det.IdTipoCbte_ct AND 
                         ct_cbtecble_det.IdCbteCble = cxc_cobro_det_x_ct_cbtecble_det.IdCbteCble_ct INNER JOIN
                         cxc_cobro INNER JOIN
                         cxc_cobro_det ON cxc_cobro.IdEmpresa = cxc_cobro_det.IdEmpresa AND cxc_cobro.IdSucursal = cxc_cobro_det.IdSucursal AND cxc_cobro.IdCobro = cxc_cobro_det.IdCobro ON 
                         cxc_cobro_det_x_ct_cbtecble_det.IdEmpresa_cb = cxc_cobro_det.IdEmpresa AND cxc_cobro_det_x_ct_cbtecble_det.IdSucursal_cb = cxc_cobro_det.IdSucursal AND 
                         cxc_cobro_det_x_ct_cbtecble_det.IdCobro_cb = cxc_cobro_det.IdCobro
WHERE        (cxc_cobro.IdCobro_tipo IS NULL)