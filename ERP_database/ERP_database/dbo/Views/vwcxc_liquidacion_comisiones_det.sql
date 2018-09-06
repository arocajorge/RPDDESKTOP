CREATE VIEW vwcxc_liquidacion_comisiones_det
AS
SELECT        cxc_liquidacion_comisiones.IdEmpresa, cxc_liquidacion_comisiones.IdLiquidacion, fa_factura.IdSucursal, fa_factura.IdBodega, fa_factura.IdCbteVta, fa_factura.vt_tipoDoc, fa_factura.vt_serie1, fa_factura.vt_serie2, 
                         fa_factura.vt_NumFactura, fa_cliente_contactos.Nombres, fa_Vendedor.Ve_Vendedor, fa_Vendedor.NomInterno, fa_TerminoPago.nom_TerminoPago, fa_factura.vt_fecha, fa_factura.vt_fech_venc, SUM(fa_factura_det.vt_Subtotal) 
                         AS vt_Subtotal, SUM(fa_factura_det.vt_iva) AS vt_iva, SUM(fa_factura_det.vt_total) AS vt_total, fa_Vendedor.IdVendedor, fa_Vendedor.PorComision, cxc_liquidacion_comisiones_det.SubtotalFactura, 
                         cxc_liquidacion_comisiones_det.IvaFactura, cxc_liquidacion_comisiones_det.TotalFactura, cxc_liquidacion_comisiones_det.TotalCobrado, cxc_liquidacion_comisiones_det.BaseComision, 
                         cxc_liquidacion_comisiones_det.PorcentajeComision, cxc_liquidacion_comisiones_det.TotalAComisionar, cxc_liquidacion_comisiones_det.TotalComisionado, cxc_liquidacion_comisiones_det.TotalLiquidacion, 
                         cxc_liquidacion_comisiones_det.NoComisiona
FROM            fa_factura INNER JOIN
                         fa_factura_det ON fa_factura.IdEmpresa = fa_factura_det.IdEmpresa AND fa_factura.IdSucursal = fa_factura_det.IdSucursal AND fa_factura.IdBodega = fa_factura_det.IdBodega AND 
                         fa_factura.IdCbteVta = fa_factura_det.IdCbteVta INNER JOIN
                         fa_cliente_contactos ON fa_factura.IdEmpresa = fa_cliente_contactos.IdEmpresa AND fa_factura.IdCliente = fa_cliente_contactos.IdCliente AND fa_factura.IdContacto = fa_cliente_contactos.IdContacto INNER JOIN
                         fa_TerminoPago ON fa_factura.vt_tipo_venta = fa_TerminoPago.IdTerminoPago RIGHT OUTER JOIN
                         cxc_liquidacion_comisiones_det INNER JOIN
                         fa_Vendedor ON cxc_liquidacion_comisiones_det.IdEmpresa = fa_Vendedor.IdEmpresa AND cxc_liquidacion_comisiones_det.IdVendedor = fa_Vendedor.IdVendedor INNER JOIN
                         cxc_liquidacion_comisiones ON cxc_liquidacion_comisiones_det.IdEmpresa = cxc_liquidacion_comisiones.IdEmpresa AND cxc_liquidacion_comisiones_det.IdLiquidacion = cxc_liquidacion_comisiones.IdLiquidacion ON 
                         fa_factura.IdEmpresa = cxc_liquidacion_comisiones_det.fa_IdEmpresa AND fa_factura.IdSucursal = cxc_liquidacion_comisiones_det.fa_IdSucursal AND fa_factura.IdBodega = cxc_liquidacion_comisiones_det.fa_IdBodega AND 
                         fa_factura.IdCbteVta = cxc_liquidacion_comisiones_det.fa_IdCbteVta
GROUP BY fa_factura.IdSucursal, fa_factura.IdBodega, fa_factura.IdCbteVta, fa_factura.vt_tipoDoc, fa_factura.vt_serie1, fa_factura.vt_serie2, fa_factura.vt_NumFactura, fa_cliente_contactos.Nombres, fa_factura.IdVendedor, 
                         fa_Vendedor.Ve_Vendedor, fa_Vendedor.NomInterno, fa_TerminoPago.nom_TerminoPago, fa_factura.vt_fecha, fa_factura.vt_fech_venc, fa_Vendedor.PorComision, fa_Vendedor.IdVendedor, 
                         cxc_liquidacion_comisiones.IdEmpresa, cxc_liquidacion_comisiones.IdLiquidacion, cxc_liquidacion_comisiones_det.SubtotalFactura, cxc_liquidacion_comisiones_det.IvaFactura, cxc_liquidacion_comisiones_det.TotalFactura, 
                         cxc_liquidacion_comisiones_det.TotalCobrado, cxc_liquidacion_comisiones_det.BaseComision, cxc_liquidacion_comisiones_det.PorcentajeComision, cxc_liquidacion_comisiones_det.TotalAComisionar, 
                         cxc_liquidacion_comisiones_det.TotalComisionado, cxc_liquidacion_comisiones_det.TotalLiquidacion, cxc_liquidacion_comisiones_det.NoComisiona