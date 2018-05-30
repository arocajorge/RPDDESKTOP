

CREATE TABLE [dbo].[fa_guia_remision_det](
	[IdEmpresa] [int] NOT NULL,
	[IdSucursal] [int] NOT NULL,
	[IdBodega] [int] NOT NULL,
	[IdGuiaRemision] [numeric](18, 0) NOT NULL,
	[Secuencia] [int] NOT NULL,
	[IdProducto] [numeric](18, 0) NOT NULL,
	[gi_cantidad] [float] NOT NULL,
	[gi_detallexItems] [nchar](250) NULL,
 CONSTRAINT [PK_fa_guia_remision_det] PRIMARY KEY CLUSTERED 
(
	[IdEmpresa] ASC,
	[IdSucursal] ASC,
	[IdBodega] ASC,
	[IdGuiaRemision] ASC,
	[Secuencia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[fa_guia_remision_det]  WITH CHECK ADD  CONSTRAINT [FK_fa_guia_remision_det_fa_guia_remision] FOREIGN KEY([IdEmpresa], [IdSucursal], [IdBodega], [IdGuiaRemision])
REFERENCES [dbo].[fa_guia_remision] ([IdEmpresa], [IdSucursal], [IdBodega], [IdGuiaRemision])
GO

ALTER TABLE [dbo].[fa_guia_remision_det] CHECK CONSTRAINT [FK_fa_guia_remision_det_fa_guia_remision]
GO

ALTER TABLE [dbo].[fa_guia_remision_det]  WITH CHECK ADD  CONSTRAINT [FK_fa_guia_remision_det_in_Producto] FOREIGN KEY([IdEmpresa], [IdProducto])
REFERENCES [dbo].[in_Producto] ([IdEmpresa], [IdProducto])
GO

ALTER TABLE [dbo].[fa_guia_remision_det] CHECK CONSTRAINT [FK_fa_guia_remision_det_in_Producto]
GO


