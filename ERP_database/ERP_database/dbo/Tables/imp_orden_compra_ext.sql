CREATE TABLE [dbo].[imp_orden_compra_ext](
	[IdEmpresa] [int] NOT NULL,
	[IdOrdenCompra_ext] [decimal](18, 0) NOT NULL,
	[IdProveedor] [numeric](18, 0) NOT NULL,
	[IdPais_origen] [varchar](10) NOT NULL,
	[IdPais_embarque] [varchar](10) NOT NULL,
	[IdCiudad_destino] [varchar](25) NOT NULL,
	[IdCatalogo_via] [int] NOT NULL,
	[IdCatalogo_forma_pago] [int] NOT NULL,
	[oe_fecha] [datetime] NOT NULL,
	[oe_fecha_llegada_est] [datetime] NULL,
	[oe_fecha_embarque_est] [datetime] NULL,
	[oe_fecha_desaduanizacion_est] [datetime] NULL,
	[IdCtaCble_importacion] [varchar](20) NOT NULL,
	[oe_observacion] [varchar](100) NULL,
	[oe_codigo] [varchar](30) NULL,
	[estado] [bit] NOT NULL,
	[IdUsuario_creacion] [varchar](20) NULL,
	[fecha_creacion] [datetime] NULL,
	[IdUsuario_modificacion] [varchar](20) NULL,
	[fecha_modificacion] [datetime] NULL,
	[IdUsuario_anulacion] [varchar](20) NULL,
	[fecha_anulacion] [datetime] NULL,
	[IdLiquidacion] [numeric](18, 0) NULL,
	[oe_fecha_llegada] [datetime] NULL,
	[oe_fecha_embarque] [datetime] NULL,
	[oe_fecha_desaduanizacion] [datetime] NULL,
	[IdMoneda_origen] [int] NULL,
	[IdMoneda_destino] [int] NULL,
 [Estado_cierre] BIT NOT NULL, 
    CONSTRAINT [PK_imp_orden_compra_ext] PRIMARY KEY CLUSTERED 
(
	[IdEmpresa] ASC,
	[IdOrdenCompra_ext] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


ALTER TABLE [dbo].[imp_orden_compra_ext]  WITH CHECK ADD  CONSTRAINT [FK_imp_orden_compra_ext_cp_proveedor1] FOREIGN KEY([IdEmpresa], [IdProveedor])
REFERENCES [dbo].[cp_proveedor] ([IdEmpresa], [IdProveedor])
GO

ALTER TABLE [dbo].[imp_orden_compra_ext] CHECK CONSTRAINT [FK_imp_orden_compra_ext_cp_proveedor1]
GO

ALTER TABLE [dbo].[imp_orden_compra_ext]  WITH CHECK ADD  CONSTRAINT [FK_imp_orden_compra_ext_ct_plancta1] FOREIGN KEY([IdEmpresa], [IdCtaCble_importacion])
REFERENCES [dbo].[ct_plancta] ([IdEmpresa], [IdCtaCble])
GO

ALTER TABLE [dbo].[imp_orden_compra_ext] CHECK CONSTRAINT [FK_imp_orden_compra_ext_ct_plancta1]
GO

ALTER TABLE [dbo].[imp_orden_compra_ext]  WITH CHECK ADD  CONSTRAINT [FK_imp_orden_compra_ext_imp_catalogo] FOREIGN KEY([IdCatalogo_via])
REFERENCES [dbo].[imp_catalogo] ([IdCatalogo])
GO

ALTER TABLE [dbo].[imp_orden_compra_ext] CHECK CONSTRAINT [FK_imp_orden_compra_ext_imp_catalogo]
GO

ALTER TABLE [dbo].[imp_orden_compra_ext]  WITH CHECK ADD  CONSTRAINT [FK_imp_orden_compra_ext_imp_catalogo1] FOREIGN KEY([IdCatalogo_forma_pago])
REFERENCES [dbo].[imp_catalogo] ([IdCatalogo])
GO

ALTER TABLE [dbo].[imp_orden_compra_ext] CHECK CONSTRAINT [FK_imp_orden_compra_ext_imp_catalogo1]
GO

ALTER TABLE [dbo].[imp_orden_compra_ext]  WITH CHECK ADD  CONSTRAINT [FK_imp_orden_compra_ext_imp_liquidacion] FOREIGN KEY([IdEmpresa], [IdLiquidacion])
REFERENCES [dbo].[imp_liquidacion] ([IdEmpresa], [IdLiquidacion])
GO

ALTER TABLE [dbo].[imp_orden_compra_ext] CHECK CONSTRAINT [FK_imp_orden_compra_ext_imp_liquidacion]
GO

ALTER TABLE [dbo].[imp_orden_compra_ext]  WITH CHECK ADD  CONSTRAINT [FK_imp_orden_compra_ext_tb_ciudad] FOREIGN KEY([IdCiudad_destino])
REFERENCES [dbo].[tb_ciudad] ([IdCiudad])
GO

ALTER TABLE [dbo].[imp_orden_compra_ext] CHECK CONSTRAINT [FK_imp_orden_compra_ext_tb_ciudad]
GO

ALTER TABLE [dbo].[imp_orden_compra_ext]  WITH CHECK ADD  CONSTRAINT [FK_imp_orden_compra_ext_tb_moneda] FOREIGN KEY([IdMoneda_origen])
REFERENCES [dbo].[tb_moneda] ([IdMoneda])
GO

ALTER TABLE [dbo].[imp_orden_compra_ext] CHECK CONSTRAINT [FK_imp_orden_compra_ext_tb_moneda]
GO

ALTER TABLE [dbo].[imp_orden_compra_ext]  WITH CHECK ADD  CONSTRAINT [FK_imp_orden_compra_ext_tb_moneda1] FOREIGN KEY([IdMoneda_destino])
REFERENCES [dbo].[tb_moneda] ([IdMoneda])
GO

ALTER TABLE [dbo].[imp_orden_compra_ext] CHECK CONSTRAINT [FK_imp_orden_compra_ext_tb_moneda1]
GO

ALTER TABLE [dbo].[imp_orden_compra_ext]  WITH CHECK ADD  CONSTRAINT [FK_imp_orden_compra_ext_tb_pais] FOREIGN KEY([IdPais_origen])
REFERENCES [dbo].[tb_pais] ([IdPais])
GO

ALTER TABLE [dbo].[imp_orden_compra_ext] CHECK CONSTRAINT [FK_imp_orden_compra_ext_tb_pais]
GO

ALTER TABLE [dbo].[imp_orden_compra_ext]  WITH CHECK ADD  CONSTRAINT [FK_imp_orden_compra_ext_tb_pais1] FOREIGN KEY([IdPais_embarque])
REFERENCES [dbo].[tb_pais] ([IdPais])
GO

ALTER TABLE [dbo].[imp_orden_compra_ext] CHECK CONSTRAINT [FK_imp_orden_compra_ext_tb_pais1]
GO


