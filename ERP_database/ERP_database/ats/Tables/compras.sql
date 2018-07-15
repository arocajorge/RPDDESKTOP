

CREATE TABLE [ats].[compras](
	[IdEmpresa] [int] NOT NULL,
	[IdPeriodo] [int] NOT NULL,
	[Secuencia] [int] NOT NULL,
	[codSustento] [varchar](3) NOT NULL,
	[tpIdProv] [varchar](3) NOT NULL,
	[idProv] [varchar](15) NOT NULL,
	[tipoComprobante] [varchar](5) NOT NULL,
	[parteRel] [varchar](5) NOT NULL,
	[tipoProv] [varchar](5) NOT NULL,
	[denopr] [varchar](500) NOT NULL,
	[fechaRegistro] [date] NOT NULL,
	[establecimiento] [varchar](5) NOT NULL,
	[puntoEmision] [varchar](5) NOT NULL,
	[secuencial] [varchar](12) NOT NULL,
	[fechaEmision] [date] NOT NULL,
	[autorizacion] [varchar](60) NOT NULL,
	[baseNoGraIva] [numeric](12, 2) NOT NULL,
	[baseImponible] [numeric](12, 2) NOT NULL,
	[baseImpGrav] [numeric](12, 2) NOT NULL,
	[baseImpExe] [numeric](12, 2) NOT NULL,
	[montoIce] [numeric](12, 2) NOT NULL,
	[montoIva] [numeric](12, 2) NOT NULL,
	[pagoLocExt] [varchar](3) NOT NULL,
	[denopago] [varchar](500) NULL,
	[paisEfecPago] [varchar](5) NULL,
	[formaPago] [varchar](500) NULL,
	[docModificado] [varchar](5) NULL,
	[estabModificado] [varchar](5) NULL,
	[ptoEmiModificado] [varchar](5) NULL,
	[secModificado] [varchar](9) NULL,
	[autModificado] [varchar](60) NULL,
 CONSTRAINT [PK_compras] PRIMARY KEY CLUSTERED 
(
	[IdEmpresa] ASC,
	[IdPeriodo] ASC,
	[Secuencia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


