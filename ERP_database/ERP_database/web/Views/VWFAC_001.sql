CREATE VIEW web.VWFAC_001
AS
SELECT        fa_factura_det.IdEmpresa, fa_factura_det.IdSucursal, fa_factura_det.IdBodega, fa_factura_det.IdCbteVta, fa_factura_det.Secuencia, fa_factura_det.IdProducto, ISNULL(in_Producto.IdProducto_padre, 0) AS IdProducto_padre, 
                         fa_factura.vt_NumFactura, fa_factura.IdCliente, fa_factura.IdContacto, fa_cliente_contactos.Nombres AS NombreContacto, fa_factura.IdVendedor, fa_Vendedor.Ve_Vendedor, tb_persona.pe_nombreCompleto AS NombreCliente, 
                         in_Producto.pr_descripcion, in_Producto.lote_fecha_vcto, in_Producto.lote_num_lote, fa_factura_det.vt_cantidad, fa_factura_det.vt_Precio, fa_factura_det.vt_PorDescUnitario, 
                         fa_factura_det.vt_cantidad * fa_factura_det.vt_DescUnitario AS vt_DesctTotal, fa_factura_det.vt_PrecioFinal, fa_factura_det.vt_Subtotal, fa_factura_det.vt_iva, fa_factura_det.vt_total, fa_factura.Estado, 
                         tb_sucursal.Su_Descripcion
FROM            fa_factura INNER JOIN
                         fa_factura_det ON fa_factura.IdEmpresa = fa_factura_det.IdEmpresa AND fa_factura.IdSucursal = fa_factura_det.IdSucursal AND fa_factura.IdBodega = fa_factura_det.IdBodega AND 
                         fa_factura.IdCbteVta = fa_factura_det.IdCbteVta INNER JOIN
                         in_Producto ON fa_factura_det.IdEmpresa = in_Producto.IdEmpresa AND fa_factura_det.IdProducto = in_Producto.IdProducto INNER JOIN
                         fa_cliente_contactos ON fa_factura.IdEmpresa = fa_cliente_contactos.IdEmpresa AND fa_factura.IdCliente = fa_cliente_contactos.IdCliente AND fa_factura.IdContacto = fa_cliente_contactos.IdContacto INNER JOIN
                         fa_Vendedor ON fa_factura.IdEmpresa = fa_Vendedor.IdEmpresa AND fa_factura.IdVendedor = fa_Vendedor.IdVendedor INNER JOIN
                         fa_cliente ON fa_factura.IdEmpresa = fa_cliente.IdEmpresa AND fa_factura.IdCliente = fa_cliente.IdCliente INNER JOIN
                         tb_persona ON fa_cliente.IdPersona = tb_persona.IdPersona INNER JOIN
                         tb_sucursal ON fa_factura_det.IdEmpresa = tb_sucursal.IdEmpresa AND fa_factura_det.IdSucursal = tb_sucursal.IdSucursal