CREATE VIEW WEB.VWBAN_002_cancelaciones
AS
SELECT        ba_Caja_Movimiento_x_Cbte_Ban_x_Deposito.mcj_IdEmpresa, ba_Caja_Movimiento_x_Cbte_Ban_x_Deposito.mcj_IdTipocbte, ba_Caja_Movimiento_x_Cbte_Ban_x_Deposito.mcj_IdCbteCble, 
                         ba_Caja_Movimiento_x_Cbte_Ban_x_Deposito.mba_IdEmpresa, ba_Caja_Movimiento_x_Cbte_Ban_x_Deposito.mba_IdCbteCble, ba_Caja_Movimiento_x_Cbte_Ban_x_Deposito.mba_IdTipocbte, 
                         CASE WHEN fa_factura.IdCbteVta IS NULL AND fa_notaCreDeb.IdNota IS NULL THEN 'ING ' + CAST(caj_Caja_Movimiento.IdCbteCble AS VARCHAR(20)) WHEN fa_factura.IdCbteVta IS NULL AND fa_notaCreDeb.IdNota IS NOT NULL
                          THEN 'NTDB ' + fa_notaCreDeb.CodNota ELSE 'FACT ' + fa_factura.vt_NumFactura END AS Referencia,
						  CASE WHEN fa_factura.IdCbteVta IS NULL AND fa_notaCreDeb.IdNota IS NULL THEN caj_Caja_Movimiento.cm_observacion WHEN fa_factura.IdCbteVta IS NULL AND fa_notaCreDeb.IdNota IS NOT NULL
                          THEN fa_notaCreDeb.sc_observacion ELSE fa_factura.vt_Observacion END AS Observacion
FROM            fa_notaCreDeb RIGHT OUTER JOIN
                         fa_factura RIGHT OUTER JOIN
                         cxc_cobro_x_caj_Caja_Movimiento INNER JOIN
                         cxc_cobro_det ON cxc_cobro_x_caj_Caja_Movimiento.cbr_IdEmpresa = cxc_cobro_det.IdEmpresa AND cxc_cobro_x_caj_Caja_Movimiento.cbr_IdSucursal = cxc_cobro_det.IdSucursal AND 
                         cxc_cobro_x_caj_Caja_Movimiento.cbr_IdCobro = cxc_cobro_det.IdCobro RIGHT OUTER JOIN
                         caj_Caja_Movimiento ON cxc_cobro_x_caj_Caja_Movimiento.mcj_IdEmpresa = caj_Caja_Movimiento.IdEmpresa AND cxc_cobro_x_caj_Caja_Movimiento.mcj_IdCbteCble = caj_Caja_Movimiento.IdCbteCble AND 
                         cxc_cobro_x_caj_Caja_Movimiento.mcj_IdTipocbte = caj_Caja_Movimiento.IdTipocbte RIGHT OUTER JOIN
                         ba_Caja_Movimiento_x_Cbte_Ban_x_Deposito ON caj_Caja_Movimiento.IdEmpresa = ba_Caja_Movimiento_x_Cbte_Ban_x_Deposito.mcj_IdEmpresa AND 
                         caj_Caja_Movimiento.IdCbteCble = ba_Caja_Movimiento_x_Cbte_Ban_x_Deposito.mcj_IdCbteCble AND caj_Caja_Movimiento.IdTipocbte = ba_Caja_Movimiento_x_Cbte_Ban_x_Deposito.mcj_IdTipocbte ON 
                         fa_factura.IdEmpresa = cxc_cobro_det.IdEmpresa AND fa_factura.IdSucursal = cxc_cobro_det.IdSucursal AND fa_factura.IdBodega = cxc_cobro_det.IdBodega_Cbte AND fa_factura.IdCbteVta = cxc_cobro_det.IdCbte_vta_nota AND
                          fa_factura.vt_tipoDoc = cxc_cobro_det.dc_TipoDocumento ON fa_notaCreDeb.IdEmpresa = cxc_cobro_det.IdEmpresa AND fa_notaCreDeb.IdSucursal = cxc_cobro_det.IdSucursal AND 
                         fa_notaCreDeb.IdBodega = cxc_cobro_det.IdBodega_Cbte AND fa_notaCreDeb.IdNota = cxc_cobro_det.IdCbte_vta_nota AND fa_notaCreDeb.CodDocumentoTipo = cxc_cobro_det.dc_TipoDocumento