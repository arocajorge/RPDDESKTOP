

CREATE TABLE [ats].[retenciones](
	[IdEmpresa] [int] NOT NULL,
	[IdPeriodo] [int] NOT NULL,
	[Secuencia] [int] NOT NULL,
	[co_serie] [varchar](10) NOT NULL,
	[co_factura] [varchar](12) NOT NULL,
	[Cedula_ruc] [varchar](13) NOT NULL,
	[valRetBien10] [numeric](12, 2) NULL,
	[valRetServ20] [numeric](12, 2) NULL,
	[valorRetBienes] [numeric](12, 2) NULL,
	[valRetServ50] [numeric](12, 2) NULL,
	[valorRetServicios] [numeric](12, 2) NULL,
	[valRetServ100] [numeric](12, 2) NULL,
	[codRetAir] [numeric](12, 2) NULL,
	[baseImpAir] [numeric](12, 2) NULL,
	[porcentajeAir] [numeric](12, 2) NULL,
	[valRetAir] [numeric](12, 2) NULL,
	[estabRetencion1] [varchar](3) NULL,
	[ptoEmiRetencion1] [varchar](3) NULL,
	[secRetencion1] [varchar](9) NULL,
	[autRetencion1] [varchar](49) NULL,
	[fechaEmiRet1] [date] NULL,
	[docModificado] [varchar](9) NULL,
	[estabModificado] [varchar](3) NULL,
	[ptoEmiModificado] [varchar](3) NULL,
	[secModificado] [varchar](9) NULL,
	[autModificado] [varchar](49) NULL,
 CONSTRAINT [PK_retenciones] PRIMARY KEY CLUSTERED 
(
	[IdEmpresa] ASC,
	[IdPeriodo] ASC,
	[Secuencia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

