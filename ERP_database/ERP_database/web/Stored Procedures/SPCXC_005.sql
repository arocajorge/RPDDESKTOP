﻿--exec [web].[SPCXC_005] 1,1,9999,1,9999,'2018/12/31',0
CREATE PROCEDURE [web].[SPCXC_005]
(
@IdEmpresa int,
@IdClienteIni numeric,
@IdClienteFin numeric,
@IdContactoIni int,
@IdContactoFin int,
@FechaCorte datetime,
@MostrarSaldo0 bit
)
AS
SELECT        c.IdEmpresa, c.IdSucursal, c.IdBodega, c.IdCbteVta, c.vt_tipoDoc, c.vt_NumFactura, c.IdCliente, c.IdContacto, RTRIM(LTRIM(tb_persona.pe_nombreCompleto)) AS NomCliente, tb_ciudad.Descripcion_Ciudad +' ' +fa_cliente_contactos.Direccion AS NomContacto,
 c.vt_fecha, c.vt_fech_venc, d.Subtotal, d.IVA, D.Total, isnull(cobro.ValorPago,0) as Cobrado, ISNULL(NC.ValorPago,0) as NotaCredito, ROUND(D.Total - ISNULL(NC.ValorPago,0) - ISNULL(cobro.ValorPago,0),2) AS Saldo
FROM            tb_ciudad RIGHT OUTER JOIN
                         fa_cliente_contactos ON tb_ciudad.IdCiudad = fa_cliente_contactos.IdCiudad RIGHT OUTER JOIN
                         fa_factura AS c INNER JOIN
                         fa_cliente ON c.IdEmpresa = fa_cliente.IdEmpresa AND c.IdCliente = fa_cliente.IdCliente INNER JOIN
                         tb_persona ON fa_cliente.IdPersona = tb_persona.IdPersona ON fa_cliente_contactos.IdEmpresa = c.IdEmpresa AND fa_cliente_contactos.IdCliente = c.IdCliente AND 
                         fa_cliente_contactos.IdContacto = c.IdContacto LEFT OUTER JOIN
                             (SELECT        IdEmpresa, IdSucursal, IdBodega, IdCbteVta, SUM(vt_Subtotal) AS Subtotal, SUM(vt_iva) AS IVA, SUM(vt_total) AS Total
                               FROM            fa_factura_det
                               GROUP BY IdEmpresa, IdSucursal, IdBodega, IdCbteVta) AS d ON c.IdEmpresa = d.IdEmpresa AND c.IdSucursal = d.IdSucursal AND c.IdBodega = d.IdBodega AND c.IdCbteVta = d.IdCbteVta

LEFT OUTER JOIN(
SELECT        cxc_cobro_det.IdEmpresa, cxc_cobro_det.IdSucursal, cxc_cobro_det.IdBodega_Cbte, cxc_cobro_det.IdCbte_vta_nota, cxc_cobro_det.dc_TipoDocumento, SUM(cxc_cobro_det.dc_ValorPago) AS ValorPago
FROM            cxc_cobro_det INNER JOIN
                         cxc_cobro ON cxc_cobro_det.IdEmpresa = cxc_cobro.IdEmpresa AND cxc_cobro_det.IdSucursal = cxc_cobro.IdSucursal AND cxc_cobro_det.IdCobro = cxc_cobro.IdCobro INNER JOIN
                         cxc_cobro_tipo ON cxc_cobro_det.IdCobro_tipo = cxc_cobro_tipo.IdCobro_tipo
WHERE        (cxc_cobro_det.estado = 'A') AND (cxc_cobro.cr_estado = N'A') AND (cxc_cobro.cr_fecha <= @FechaCorte) AND (cxc_cobro.IdEmpresa = @IdEmpresa)
and cxc_cobro_tipo.IdMotivo_tipo_cobro <> 'NTCR'
GROUP BY cxc_cobro_det.IdEmpresa, cxc_cobro_det.IdSucursal, cxc_cobro_det.IdBodega_Cbte, cxc_cobro_det.IdCbte_vta_nota, cxc_cobro_det.dc_TipoDocumento
) AS Cobro on c.IdEmpresa = Cobro.IdEmpresa AND c.IdSucursal = Cobro.IdSucursal AND c.IdBodega = Cobro.IdBodega_Cbte AND c.IdCbteVta = Cobro.IdCbte_vta_nota and cobro.dc_TipoDocumento = c.vt_tipoDoc 

LEFT OUTER JOIN(
SELECT        cxc_cobro_det.IdEmpresa, cxc_cobro_det.IdSucursal, cxc_cobro_det.IdBodega_Cbte, cxc_cobro_det.IdCbte_vta_nota, cxc_cobro_det.dc_TipoDocumento, SUM(cxc_cobro_det.dc_ValorPago) AS ValorPago
FROM            cxc_cobro_det INNER JOIN
                         cxc_cobro ON cxc_cobro_det.IdEmpresa = cxc_cobro.IdEmpresa AND cxc_cobro_det.IdSucursal = cxc_cobro.IdSucursal AND cxc_cobro_det.IdCobro = cxc_cobro.IdCobro INNER JOIN
                         cxc_cobro_tipo ON cxc_cobro_det.IdCobro_tipo = cxc_cobro_tipo.IdCobro_tipo
WHERE        (cxc_cobro_det.estado = 'A') AND (cxc_cobro.cr_estado = N'A') AND (cxc_cobro.cr_fecha <= @FechaCorte) AND (cxc_cobro.IdEmpresa = @IdEmpresa)
and cxc_cobro_tipo.IdMotivo_tipo_cobro = 'NTCR'
GROUP BY cxc_cobro_det.IdEmpresa, cxc_cobro_det.IdSucursal, cxc_cobro_det.IdBodega_Cbte, cxc_cobro_det.IdCbte_vta_nota, cxc_cobro_det.dc_TipoDocumento
) AS NC on c.IdEmpresa = NC.IdEmpresa AND c.IdSucursal = NC.IdSucursal AND c.IdBodega = NC.IdBodega_Cbte AND c.IdCbteVta = NC.IdCbte_vta_nota and NC.dc_TipoDocumento = c.vt_tipoDoc 

WHERE c.Estado = 'A' and c.IdEmpresa = @IdEmpresa and c.IdCliente between @IdClienteIni and @IdClienteFin and c.IdContacto between @IdContactoIni and @IdContactoFin and c.vt_fecha <= @FechaCorte
and ROUND(D.Total - ISNULL(cobro.ValorPago,0),2) > IIF(@MostrarSaldo0 = 1, -1, 0)
UNION ALL
SELECT        c.IdEmpresa, c.IdSucursal, c.IdBodega, c.IdNota, c.CodDocumentoTipo, ISNULL(c.NumNota_Impresa,'INT-'+CAST(C.IdNota AS VARCHAR(10))), c.IdCliente, c.IdContacto, tb_persona.pe_nombreCompleto AS NomCliente, tb_ciudad.Descripcion_Ciudad +' ' +fa_cliente_contactos.Direccion AS NomContacto,
 c.no_fecha, c.no_fecha_venc, d.Subtotal, d.IVA, D.Total, isnull(cobro.ValorPago,0) as Cobrado, ISNULL(NC.ValorPago,0) as NotaCredito, ROUND(D.Total - ISNULL(NC.ValorPago,0) -  ISNULL(cobro.ValorPago,0),2) AS Saldo
FROM            tb_ciudad RIGHT OUTER JOIN
                         fa_cliente_contactos ON tb_ciudad.IdCiudad = fa_cliente_contactos.IdCiudad RIGHT OUTER JOIN
                         fa_notaCreDeb AS c INNER JOIN
                         fa_cliente ON c.IdEmpresa = fa_cliente.IdEmpresa AND c.IdCliente = fa_cliente.IdCliente INNER JOIN
                         tb_persona ON fa_cliente.IdPersona = tb_persona.IdPersona ON fa_cliente_contactos.IdEmpresa = c.IdEmpresa AND fa_cliente_contactos.IdCliente = c.IdCliente AND 
                         fa_cliente_contactos.IdContacto = c.IdContacto LEFT OUTER JOIN
                             (SELECT        IdEmpresa, IdSucursal, IdBodega, IdNota, SUM(sc_subtotal) AS Subtotal, SUM(sc_iva) AS IVA, SUM(sc_total) AS Total
                               FROM            fa_notaCreDeb_det
                               GROUP BY IdEmpresa, IdSucursal, IdBodega, IdNota) AS d ON c.IdEmpresa = d.IdEmpresa AND c.IdSucursal = d.IdSucursal AND c.IdBodega = d.IdBodega AND c.IdNota = d.IdNota

LEFT OUTER JOIN(
SELECT        cxc_cobro_det.IdEmpresa, cxc_cobro_det.IdSucursal, cxc_cobro_det.IdBodega_Cbte, cxc_cobro_det.IdCbte_vta_nota, cxc_cobro_det.dc_TipoDocumento, SUM(cxc_cobro_det.dc_ValorPago) AS ValorPago
FROM            cxc_cobro_det INNER JOIN
                         cxc_cobro ON cxc_cobro_det.IdEmpresa = cxc_cobro.IdEmpresa AND cxc_cobro_det.IdSucursal = cxc_cobro.IdSucursal AND cxc_cobro_det.IdCobro = cxc_cobro.IdCobro INNER JOIN
                         cxc_cobro_tipo ON cxc_cobro_det.IdCobro_tipo = cxc_cobro_tipo.IdCobro_tipo
WHERE        (cxc_cobro_det.estado = 'A') AND (cxc_cobro.cr_estado = N'A') AND (cxc_cobro.cr_fecha <= @FechaCorte) AND (cxc_cobro.IdEmpresa = @IdEmpresa)
and cxc_cobro_tipo.IdMotivo_tipo_cobro <> 'NTCR'
GROUP BY cxc_cobro_det.IdEmpresa, cxc_cobro_det.IdSucursal, cxc_cobro_det.IdBodega_Cbte, cxc_cobro_det.IdCbte_vta_nota, cxc_cobro_det.dc_TipoDocumento
) AS Cobro on c.IdEmpresa = Cobro.IdEmpresa AND c.IdSucursal = Cobro.IdSucursal AND c.IdBodega = Cobro.IdBodega_Cbte AND c.IdNota = Cobro.IdCbte_vta_nota and cobro.dc_TipoDocumento = c.CodDocumentoTipo 

LEFT OUTER JOIN(
SELECT        cxc_cobro_det.IdEmpresa, cxc_cobro_det.IdSucursal, cxc_cobro_det.IdBodega_Cbte, cxc_cobro_det.IdCbte_vta_nota, cxc_cobro_det.dc_TipoDocumento, SUM(cxc_cobro_det.dc_ValorPago) AS ValorPago
FROM            cxc_cobro_det INNER JOIN
                         cxc_cobro ON cxc_cobro_det.IdEmpresa = cxc_cobro.IdEmpresa AND cxc_cobro_det.IdSucursal = cxc_cobro.IdSucursal AND cxc_cobro_det.IdCobro = cxc_cobro.IdCobro INNER JOIN
                         cxc_cobro_tipo ON cxc_cobro_det.IdCobro_tipo = cxc_cobro_tipo.IdCobro_tipo
WHERE        (cxc_cobro_det.estado = 'A') AND (cxc_cobro.cr_estado = N'A') AND (cxc_cobro.cr_fecha <= @FechaCorte) AND (cxc_cobro.IdEmpresa = @IdEmpresa)
and cxc_cobro_tipo.IdMotivo_tipo_cobro = 'NTCR'
GROUP BY cxc_cobro_det.IdEmpresa, cxc_cobro_det.IdSucursal, cxc_cobro_det.IdBodega_Cbte, cxc_cobro_det.IdCbte_vta_nota, cxc_cobro_det.dc_TipoDocumento
) AS NC on c.IdEmpresa = NC.IdEmpresa AND c.IdSucursal = NC.IdSucursal AND c.IdBodega = NC.IdBodega_Cbte AND c.IdNota = NC.IdCbte_vta_nota and NC.dc_TipoDocumento = c.CodDocumentoTipo 
WHERE c.Estado = 'A' and c.CreDeb = 'D' and c.IdEmpresa = @IdEmpresa and c.IdCliente between @IdClienteIni and @IdClienteFin and c.IdContacto between @IdContactoIni and @IdContactoFin and c.no_fecha <= @FechaCorte
and ROUND(D.Total - ISNULL(cobro.ValorPago,0),2) > IIF(@MostrarSaldo0 = 1, -1, 0)