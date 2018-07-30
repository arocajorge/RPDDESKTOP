CREATE TABLE [dbo].[fa_guia_remision](
	[IdEmpresa] [int] NOT NULL,
	[IdSucursal] [int] NOT NULL,
	[IdBodega] [int] NOT NULL,
	[IdGuiaRemision] [numeric](18, 0) NOT NULL,
	[CodGuiaRemision] [varchar](20) NOT NULL,
	[CodDocumentoTipo] [varchar](20) NULL,
	[Serie1] [varchar](3) NULL,
	[Serie2] [varchar](3) NULL,
	[NumGuia_Preimpresa] [varchar](20) NULL,
	[NUAutorizacion] [varchar](50) NULL,
	[Fecha_Autorizacion] [datetime] NULL,
	[IdCliente] [numeric](18, 0) NOT NULL,
	[IdTransportista] [numeric](18, 0) NOT NULL,
	[gi_fecha] [datetime] NOT NULL,
	[gi_plazo] [numeric](10, 0) NULL,
	[gi_fech_venc] [datetime] NULL,
	[gi_Observacion] [varchar](1000) NULL,
	[Impreso] [char](1) NULL,
	[gi_FechaFinTraslado] [date] NOT NULL,
	[gi_FechaInicioTraslado] [date] NOT NULL,
	[placa] [varchar](20) NOT NULL,
	[ruta] [varchar](300) NULL,
	[Direccion_Origen] [varchar](300) NOT NULL,
	[IdUsuario] [varchar](20) NOT NULL,
	[Fecha_Transac] [datetime] NOT NULL,
	[IdUsuarioUltMod] [varchar](20) NULL,
	[Fecha_UltMod] [datetime] NULL,
	[IdUsuarioUltAnu] [varchar](20) NULL,
	[Fecha_UltAnu] [datetime] NULL,
	[nom_pc] [varchar](50) NOT NULL,
	[ip] [varchar](25) NOT NULL,
	[Estado] [char](1) NOT NULL,
	[MotiAnula] [varchar](200) NULL,
	[Direccion_Destino] [varchar](300) NULL,
	[Num_declaracion_aduanera] [varchar](50) NULL,
	[IdCatalogo_traslado] [varchar](15) NULL,
 CONSTRAINT [PK_fa_guia_remision] PRIMARY KEY CLUSTERED 
(
	[IdEmpresa] ASC,
	[IdSucursal] ASC,
	[IdBodega] ASC,
	[IdGuiaRemision] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


GO

ALTER TABLE [dbo].[fa_guia_remision]  WITH CHECK ADD  CONSTRAINT [FK_fa_guia_remision_fa_catalogo] FOREIGN KEY([IdCatalogo_traslado])
REFERENCES [dbo].[fa_catalogo] ([IdCatalogo])
GO

ALTER TABLE [dbo].[fa_guia_remision] CHECK CONSTRAINT [FK_fa_guia_remision_fa_catalogo]
GO

ALTER TABLE [dbo].[fa_guia_remision]  WITH CHECK ADD  CONSTRAINT [FK_fa_guia_remision_fa_cliente] FOREIGN KEY([IdEmpresa], [IdCliente])
REFERENCES [dbo].[fa_cliente] ([IdEmpresa], [IdCliente])
GO

ALTER TABLE [dbo].[fa_guia_remision] CHECK CONSTRAINT [FK_fa_guia_remision_fa_cliente]
GO

ALTER TABLE [dbo].[fa_guia_remision]  WITH CHECK ADD  CONSTRAINT [FK_fa_guia_remision_tb_bodega] FOREIGN KEY([IdEmpresa], [IdSucursal], [IdBodega])
REFERENCES [dbo].[tb_bodega] ([IdEmpresa], [IdSucursal], [IdBodega])
GO

ALTER TABLE [dbo].[fa_guia_remision] CHECK CONSTRAINT [FK_fa_guia_remision_tb_bodega]
GO

ALTER TABLE [dbo].[fa_guia_remision]  WITH CHECK ADD  CONSTRAINT [FK_fa_guia_remision_tb_sis_Documento_Tipo_Talonario] FOREIGN KEY([IdEmpresa], [CodDocumentoTipo], [Serie2], [Serie1], [NumGuia_Preimpresa])
REFERENCES [dbo].[tb_sis_Documento_Tipo_Talonario] ([IdEmpresa], [CodDocumentoTipo], [PuntoEmision], [Establecimiento], [NumDocumento])
GO

ALTER TABLE [dbo].[fa_guia_remision] CHECK CONSTRAINT [FK_fa_guia_remision_tb_sis_Documento_Tipo_Talonario]
GO

ALTER TABLE [dbo].[fa_guia_remision]  WITH CHECK ADD  CONSTRAINT [FK_fa_guia_remision_tb_transportista] FOREIGN KEY([IdEmpresa], [IdTransportista])
REFERENCES [dbo].[tb_transportista] ([IdEmpresa], [IdTransportista])
GO

ALTER TABLE [dbo].[fa_guia_remision] CHECK CONSTRAINT [FK_fa_guia_remision_tb_transportista]
GO


