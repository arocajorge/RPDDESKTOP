CREATE TABLE [ats].[comprobantes_anulados](
	[IdEmpresa] [int] NOT NULL,
	[IdPeriodo] [int] NOT NULL,
	[Secuencia] [int] NOT NULL,
	[tipoComprobante] [varchar](2) NOT NULL,
	[Establecimiento] [varchar](3) NOT NULL,
	[puntoEmision] [varchar](3) NOT NULL,
	[secuencialInicio] [varchar](9) NOT NULL,
	[secuencialFin] [varchar](9) NOT NULL,
	[Autorización] [varchar](49) NOT NULL,
 CONSTRAINT [PK_comprobantes_anulados] PRIMARY KEY CLUSTERED 
(
	[IdEmpresa] ASC,
	[IdPeriodo] ASC,
	[Secuencia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
