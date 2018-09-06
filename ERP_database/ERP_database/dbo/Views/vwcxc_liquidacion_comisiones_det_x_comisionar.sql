CREATE VIEW vwcxc_liquidacion_comisiones_det_x_comisionar
AS
SELECT      fa_factura.IdEmpresa, fa_factura.IdSucursal, fa_factura.IdBodega,  fa_factura.IdCbteVta, fa_factura.vt_tipoDoc, fa_factura.vt_serie1, fa_factura.vt_serie2, fa_factura.vt_NumFactura, fa_cliente_contactos.Nombres, fa_Vendedor.Ve_Vendedor, fa_Vendedor.NomInterno, 
                         fa_TerminoPago.nom_TerminoPago, fa_factura.vt_fecha, fa_factura.vt_fech_venc, SUM(fa_factura_det.vt_Subtotal) AS vt_Subtotal, SUM(fa_factura_det.vt_iva) AS vt_iva, SUM(fa_factura_det.vt_total) AS vt_total, ISNULL(cobro.dc_ValorPago, 0) 
                         AS valor_cobro, CASE WHEN round(SUM(fa_factura_det.vt_total), 2) - ISNULL(round(cobro.dc_ValorPago, 2), 0) = 0 THEN 'CANCELADA' ELSE 'PENDIENTE' END AS ESTADO_COBRO, round(SUM(fa_factura_det.vt_total) * (fa_Vendedor.PorComision/100), 2) as TotalAComisionar,
						 isnull(TotalLiquidacion,0) as TotalComisionado,
						  round(SUM(fa_factura_det.vt_total) * (fa_Vendedor.PorComision/100), 2) - isnull(TotalLiquidacion,0) as SaldoPorComisionar,fa_Vendedor.IdVendedor, fa_Vendedor.PorComision
FROM            fa_factura INNER JOIN
                         fa_factura_det ON fa_factura.IdEmpresa = fa_factura_det.IdEmpresa AND fa_factura.IdSucursal = fa_factura_det.IdSucursal AND fa_factura.IdBodega = fa_factura_det.IdBodega AND 
                         fa_factura.IdCbteVta = fa_factura_det.IdCbteVta INNER JOIN
                         fa_Vendedor ON fa_factura.IdEmpresa = fa_Vendedor.IdEmpresa AND fa_factura.IdVendedor = fa_Vendedor.IdVendedor INNER JOIN
                         fa_cliente_contactos ON fa_factura.IdEmpresa = fa_cliente_contactos.IdEmpresa AND fa_factura.IdCliente = fa_cliente_contactos.IdCliente AND fa_factura.IdContacto = fa_cliente_contactos.IdContacto INNER JOIN
                         fa_TerminoPago ON fa_factura.vt_tipo_venta = fa_TerminoPago.IdTerminoPago LEFT OUTER JOIN
                             (SELECT        IdEmpresa, IdSucursal, IdBodega_Cbte, IdCbte_vta_nota, dc_TipoDocumento, SUM(dc_ValorPago) AS dc_ValorPago
                               FROM            cxc_cobro_det
                               WHERE        (estado = 'A')
                               GROUP BY IdEmpresa, IdSucursal, IdBodega_Cbte, IdCbte_vta_nota, dc_TipoDocumento) AS cobro ON fa_factura.IdEmpresa = cobro.IdEmpresa AND fa_factura.IdSucursal = cobro.IdSucursal AND 
                         fa_factura.IdBodega = cobro.IdBodega_Cbte AND fa_factura.IdCbteVta = cobro.IdCbte_vta_nota
						 LEFT OUTER JOIN (
								SELECT        cxc_liquidacion_comisiones_det.fa_IdEmpresa, cxc_liquidacion_comisiones_det.fa_IdSucursal, cxc_liquidacion_comisiones_det.fa_IdBodega, cxc_liquidacion_comisiones_det.fa_IdCbteVta, 
								SUM(cxc_liquidacion_comisiones_det.TotalLiquidacion) AS TotalLiquidacion
								FROM            cxc_liquidacion_comisiones LEFT OUTER JOIN
								cxc_liquidacion_comisiones_det ON cxc_liquidacion_comisiones.IdEmpresa = cxc_liquidacion_comisiones_det.IdEmpresa AND 
								cxc_liquidacion_comisiones.IdLiquidacion = cxc_liquidacion_comisiones_det.IdLiquidacion
								WHERE        (cxc_liquidacion_comisiones.Estado = 1) 
								GROUP BY cxc_liquidacion_comisiones_det.fa_IdEmpresa, cxc_liquidacion_comisiones_det.fa_IdSucursal, cxc_liquidacion_comisiones_det.fa_IdBodega, cxc_liquidacion_comisiones_det.fa_IdCbteVta
						 ) AS comisiones on comisiones.fa_IdEmpresa = fa_factura.IdEmpresa and comisiones.fa_IdSucursal = fa_factura.IdSucursal and comisiones.fa_IdBodega = fa_factura.IdBodega 
						 and comisiones.fa_IdCbteVta = fa_factura.IdCbteVta
WHERE        (fa_factura.Estado = 'A') and fa_Vendedor.PorComision > 0 and not exists(
select f.IdEmpresa FROM            cxc_liquidacion_comisiones LEFT OUTER JOIN
								cxc_liquidacion_comisiones_det as f ON cxc_liquidacion_comisiones.IdEmpresa  = f.IdEmpresa AND 
								cxc_liquidacion_comisiones.IdLiquidacion = f.IdLiquidacion
where NoComisiona = 1 and f.fa_IdEmpresa = fa_factura.IdEmpresa and f.fa_IdSucursal = fa_factura.IdSucursal and f.fa_IdBodega = fa_factura.IdBodega 
and f.fa_IdCbteVta = fa_factura.IdCbteVta and cxc_liquidacion_comisiones.Estado = 1
)
GROUP BY fa_factura.IdEmpresa, fa_factura.IdSucursal, fa_factura.IdBodega, fa_factura.IdCbteVta, fa_factura.vt_tipoDoc, fa_factura.vt_serie1, fa_factura.vt_serie2, fa_factura.vt_NumFactura, fa_cliente_contactos.Nombres, fa_factura.IdVendedor, fa_Vendedor.Ve_Vendedor, fa_Vendedor.NomInterno, 
                         fa_TerminoPago.nom_TerminoPago, fa_factura.vt_fecha, fa_factura.vt_fech_venc, cobro.dc_ValorPago,fa_Vendedor.PorComision,TotalLiquidacion,fa_Vendedor.IdVendedor
having (round(SUM(fa_factura_det.vt_total) * (fa_Vendedor.PorComision/100), 2) - round(isnull(TotalLiquidacion,0),2)) > 0