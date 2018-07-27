CREATE VIEW web.vwfa_factura
AS
SELECT        fa_factura.IdEmpresa, fa_factura.IdSucursal, fa_factura.IdBodega, fa_factura.IdCbteVta, fa_factura.vt_NumFactura, fa_factura.vt_fecha, fa_cliente_contactos.Nombres, fa_Vendedor.Ve_Vendedor, SUM(fa_factura_det.vt_Subtotal) 
                         AS vt_Subtotal, SUM(fa_factura_det.vt_iva) AS vt_iva, SUM(fa_factura_det.vt_total) AS vt_total, fa_factura.Estado, fa_factura.esta_impresa, fa_factura_x_in_Ing_Egr_Inven.IdEmpresa_in_eg_x_inv, 
                         fa_factura_x_in_Ing_Egr_Inven.IdSucursal_in_eg_x_inv, fa_factura_x_in_Ing_Egr_Inven.IdMovi_inven_tipo_in_eg_x_inv, fa_factura_x_in_Ing_Egr_Inven.IdNumMovi_in_eg_x_inv
FROM            fa_factura INNER JOIN
                         fa_Vendedor ON fa_factura.IdEmpresa = fa_Vendedor.IdEmpresa AND fa_factura.IdVendedor = fa_Vendedor.IdVendedor LEFT OUTER JOIN
                         fa_factura_det ON fa_factura.IdEmpresa = fa_factura_det.IdEmpresa AND fa_factura.IdSucursal = fa_factura_det.IdSucursal AND fa_factura.IdBodega = fa_factura_det.IdBodega AND 
                         fa_factura.IdCbteVta = fa_factura_det.IdCbteVta LEFT OUTER JOIN
                         fa_cliente_contactos ON fa_factura.IdEmpresa = fa_cliente_contactos.IdEmpresa AND fa_factura.IdCliente = fa_cliente_contactos.IdCliente AND fa_factura.IdContacto = fa_cliente_contactos.IdContacto LEFT OUTER JOIN
                         fa_factura_x_in_Ing_Egr_Inven ON fa_factura.IdEmpresa = fa_factura_x_in_Ing_Egr_Inven.IdEmpresa_fa AND fa_factura.IdSucursal = fa_factura_x_in_Ing_Egr_Inven.IdSucursal_fa AND 
                         fa_factura.IdBodega = fa_factura_x_in_Ing_Egr_Inven.IdBodega_fa AND fa_factura.IdCbteVta = fa_factura_x_in_Ing_Egr_Inven.IdCbteVta_fa
GROUP BY fa_factura.IdEmpresa, fa_factura.IdSucursal, fa_factura.IdBodega, fa_factura.IdCbteVta, fa_factura.vt_NumFactura, fa_factura.vt_fecha, fa_cliente_contactos.Nombres, fa_factura.Estado, fa_Vendedor.Ve_Vendedor, 
                         fa_factura.esta_impresa, fa_factura_x_in_Ing_Egr_Inven.IdEmpresa_in_eg_x_inv, fa_factura_x_in_Ing_Egr_Inven.IdSucursal_in_eg_x_inv, fa_factura_x_in_Ing_Egr_Inven.IdMovi_inven_tipo_in_eg_x_inv, 
                         fa_factura_x_in_Ing_Egr_Inven.IdNumMovi_in_eg_x_inv