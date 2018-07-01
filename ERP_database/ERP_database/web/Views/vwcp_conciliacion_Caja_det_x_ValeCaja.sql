CREATE VIEW web.vwcp_conciliacion_Caja_det_x_ValeCaja
AS
SELECT        cp_conciliacion_Caja_det_x_ValeCaja.IdEmpresa, cp_conciliacion_Caja_det_x_ValeCaja.IdConciliacion_Caja, cp_conciliacion_Caja_det_x_ValeCaja.Secuencia, cp_conciliacion_Caja_det_x_ValeCaja.IdEmpresa_movcaja, 
                         cp_conciliacion_Caja_det_x_ValeCaja.IdCbteCble_movcaja, cp_conciliacion_Caja_det_x_ValeCaja.IdTipocbte_movcaja, cp_conciliacion_Caja_det_x_ValeCaja.IdCtaCble, caj_Caja_Movimiento.cm_valor, 
                         caj_Caja_Movimiento_Tipo.IdTipoMovi, tb_persona.IdPersona, tb_persona.pe_nombreCompleto, caj_Caja_Movimiento.cm_fecha
FROM            cp_conciliacion_Caja_det_x_ValeCaja INNER JOIN
                         caj_Caja_Movimiento ON cp_conciliacion_Caja_det_x_ValeCaja.IdEmpresa_movcaja = caj_Caja_Movimiento.IdEmpresa AND cp_conciliacion_Caja_det_x_ValeCaja.IdCbteCble_movcaja = caj_Caja_Movimiento.IdCbteCble AND 
                         cp_conciliacion_Caja_det_x_ValeCaja.IdTipocbte_movcaja = caj_Caja_Movimiento.IdTipocbte INNER JOIN
                         tb_persona ON caj_Caja_Movimiento.IdPersona = tb_persona.IdPersona INNER JOIN
                         caj_Caja_Movimiento_Tipo ON caj_Caja_Movimiento.IdEmpresa = caj_Caja_Movimiento_Tipo.IdEmpresa AND caj_Caja_Movimiento.IdTipoMovi = caj_Caja_Movimiento_Tipo.IdTipoMovi