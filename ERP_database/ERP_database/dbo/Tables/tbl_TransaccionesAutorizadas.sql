CREATE TABLE [web].[tbl_TransaccionesAutorizadas](
	[IdEmpresa] [int] NOT NULL,
	[IdTransaccion] [decimal](18, 0) NOT NULL,
	[IdUsuarioLog] [varchar](50) NOT NULL,
	[IdUsuarioAut] [varchar](50) NOT NULL,
	[Observacion] [varchar](1000) NULL,
	[FechaTransaccion] [date] NOT NULL,
 CONSTRAINT [PK_tbl_TransaccionesAutorizadas] PRIMARY KEY CLUSTERED 
(
	[IdEmpresa] ASC,
	[IdTransaccion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]