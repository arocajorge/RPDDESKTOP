
CREATE TABLE [dbo].[ro_parametro_contable_x_Nomina_Tipoliqui_Sueldo_x_Pagar](
	[IdEmpresa] [int] NOT NULL,
	[IdNomina] [int] NOT NULL,
	[IdNominaTipo] [int] NOT NULL,
	[IdCtaCble] [varchar](20) NOT NULL,
	[Observacion] [varchar](100) NULL,
	[IdTipoFlujo] [numeric](18, 0) NULL,
 CONSTRAINT [PK_ro_parametro_contable_x_Nomina_Tipoliqui_Sueldo_x_Pagar] PRIMARY KEY CLUSTERED 
(
	[IdEmpresa] ASC,
	[IdNomina] ASC,
	[IdNominaTipo] ASC,
	[IdCtaCble] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO



ALTER TABLE [dbo].[ro_parametro_contable_x_Nomina_Tipoliqui_Sueldo_x_Pagar]  WITH CHECK ADD  CONSTRAINT [FK_ro_parametro_contable_x_Nomina_Tipoliqui_Sueldo_x_Pagar_ba_TipoFlujo] FOREIGN KEY([IdEmpresa], [IdTipoFlujo])
REFERENCES [dbo].[ba_TipoFlujo] ([IdEmpresa], [IdTipoFlujo])
GO

ALTER TABLE [dbo].[ro_parametro_contable_x_Nomina_Tipoliqui_Sueldo_x_Pagar] CHECK CONSTRAINT [FK_ro_parametro_contable_x_Nomina_Tipoliqui_Sueldo_x_Pagar_ba_TipoFlujo]
GO

ALTER TABLE [dbo].[ro_parametro_contable_x_Nomina_Tipoliqui_Sueldo_x_Pagar]  WITH CHECK ADD  CONSTRAINT [FK_ro_parametro_contable_x_Nomina_Tipoliqui_Sueldo_x_Pagar_ct_plancta] FOREIGN KEY([IdEmpresa], [IdCtaCble])
REFERENCES [dbo].[ct_plancta] ([IdEmpresa], [IdCtaCble])
GO

ALTER TABLE [dbo].[ro_parametro_contable_x_Nomina_Tipoliqui_Sueldo_x_Pagar] CHECK CONSTRAINT [FK_ro_parametro_contable_x_Nomina_Tipoliqui_Sueldo_x_Pagar_ct_plancta]
GO

ALTER TABLE [dbo].[ro_parametro_contable_x_Nomina_Tipoliqui_Sueldo_x_Pagar]  WITH CHECK ADD  CONSTRAINT [FK_ro_parametro_contable_x_Nomina_Tipoliqui_Sueldo_x_Pagar_ro_Nomina_Tipoliqui] FOREIGN KEY([IdEmpresa], [IdNomina], [IdNominaTipo])
REFERENCES [dbo].[ro_Nomina_Tipoliqui] ([IdEmpresa], [IdNomina_Tipo], [IdNomina_TipoLiqui])
GO

ALTER TABLE [dbo].[ro_parametro_contable_x_Nomina_Tipoliqui_Sueldo_x_Pagar] CHECK CONSTRAINT [FK_ro_parametro_contable_x_Nomina_Tipoliqui_Sueldo_x_Pagar_ro_Nomina_Tipoliqui]
GO


