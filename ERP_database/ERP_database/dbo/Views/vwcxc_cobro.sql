
CREATE VIEW [dbo].[vwcxc_cobro]
AS
SELECT     FC.IdPersona, C.IdEmpresa, C.IdSucursal, C.IdCobro, C.IdCobro_tipo, C.IdCliente, C.cr_TotalCobro, C.cr_fecha, C.cr_fechaCobro, C.cr_fechaDocu, C.cr_observacion, 
                      C.cr_Banco, C.cr_cuenta, C.cr_Tarjeta, C.cr_NumDocumento, C.cr_estado, C.cr_recibo, C.Fecha_Transac, C.IdUsuario, C.IdUsuarioUltMod, C.Fecha_UltMod, 
                      C.IdUsuarioUltAnu, C.Fecha_UltAnu, C.nom_pc, C.ip, S.Su_Descripcion AS nSucursal, P.pe_nombreCompleto AS nCliente, '' AS cr_NumCheque, 
                      1 AS IdVendedorCliente, C.cr_Codigo, C.IdTipoNotaCredito, C.cr_propietarioCta, C.IdBanco, C.IdCaja, C.cr_es_anticipo
FROM         dbo.tb_persona AS P INNER JOIN
                      dbo.tb_sucursal AS S INNER JOIN
                      dbo.cxc_cobro AS C ON S.IdEmpresa = C.IdEmpresa AND S.IdSucursal = C.IdSucursal INNER JOIN
                      dbo.fa_cliente AS FC ON C.IdCliente = FC.IdCliente AND C.IdEmpresa = FC.IdEmpresa ON P.IdPersona = FC.IdPersona
