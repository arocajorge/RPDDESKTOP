
CREATE TABLE [ats].[ventas](
	[IdEmpresa] [int] NOT NULL,
	[IdPeriodo] [int] NOT NULL,
	[Secuencia] [int] NOT NULL,
	[tpIdCliente] [varchar](2) NOT NULL,
	[idCliente] [varchar](13) NOT NULL,
	[parteRel] [varchar](2) NOT NULL,
	[tipoCliente] [varchar](2) NOT NULL,
	[DenoCli] [varchar](500) NOT NULL,
	[tipoComprobante] [varchar](3) NOT NULL,
	[tipoEm] [varchar](1) NOT NULL,
	[numeroComprobantes] [int] NOT NULL,
	[baseNoGraIva] [numeric](12, 2) NOT NULL,
	[baseImponible] [numeric](12, 2) NOT NULL,
	[baseImpGrav] [numeric](12, 2) NOT NULL,
	[montoIva] [numeric](12, 2) NOT NULL,
	[montoIce] [numeric](12, 2) NOT NULL,
	[valorRetIva] [numeric](12, 2) NOT NULL,
	[valorRetRenta] [numeric](12, 2) NOT NULL,
	[formaPago] [varchar](2) NULL,
	[codEstab] [varchar](3) NOT NULL,
	[ventasEstab] [numeric](12, 2) NOT NULL,
	[ivaComp] [numeric](12, 2) NOT NULL,
 CONSTRAINT [PK_ventas] PRIMARY KEY CLUSTERED 
(
	[IdEmpresa] ASC,
	[IdPeriodo] ASC,
	[Secuencia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]