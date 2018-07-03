CREATE VIEW [web].[vwcxc_cobro]
AS
SELECT dbo.cxc_cobro.IdEmpresa, dbo.cxc_cobro.IdSucursal, dbo.cxc_cobro.IdCobro, dbo.cxc_cobro.IdCliente, dbo.tb_persona.pe_nombreCompleto, dbo.cxc_cobro.IdCobro_tipo, dbo.cxc_cobro_tipo.tc_descripcion, dbo.cxc_cobro.cr_fecha, 
                  dbo.cxc_cobro.cr_TotalCobro, dbo.cxc_cobro.cr_estado, dbo.tb_sucursal.Su_Descripcion
FROM     dbo.cxc_cobro INNER JOIN
                  dbo.fa_cliente ON dbo.cxc_cobro.IdEmpresa = dbo.fa_cliente.IdEmpresa AND dbo.cxc_cobro.IdCliente = dbo.fa_cliente.IdCliente INNER JOIN
                  dbo.tb_persona ON dbo.fa_cliente.IdPersona = dbo.tb_persona.IdPersona INNER JOIN
                  dbo.tb_sucursal ON dbo.cxc_cobro.IdEmpresa = dbo.tb_sucursal.IdEmpresa AND dbo.cxc_cobro.IdSucursal = dbo.tb_sucursal.IdSucursal INNER JOIN
                  dbo.cxc_cobro_tipo ON dbo.cxc_cobro.IdCobro_tipo = dbo.cxc_cobro_tipo.IdCobro_tipo