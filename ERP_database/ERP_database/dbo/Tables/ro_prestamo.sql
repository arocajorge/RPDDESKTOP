CREATE TABLE [dbo].[ro_prestamo](
[IdEmpresa] [int] NOT NULL,
	[IdPrestamo] [numeric](18, 0) NOT NULL,
	[IdEmpleado] [numeric](18, 0) NOT NULL,
	[IdRubro] [varchar](50) NOT NULL,
	[IdEmpleado_Aprueba] [numeric](18, 0) NOT NULL,
	[descuento_mensual] [bit] NOT NULL,
	[descuento_quincena] [bit] NOT NULL,
	[descuento_men_quin] [bit] NOT NULL,
	[Estado] [char](1) NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[MontoSol] [float] NOT NULL,
	[TasaInteres] [float] NOT NULL,
	[TotalPrestamo] [float] NOT NULL,
	[NumCuotas] [int] NOT NULL,
	[Fecha_PriPago] [datetime] NOT NULL,
	[Observacion] [varchar](250) NOT NULL,
	[Tipo_Calculo] [varchar](1) NULL,
	[IdUsuario] [varchar](20) NOT NULL,
	[Fecha_Transac] [datetime] NOT NULL,
	[IdUsuarioUltMod] [varchar](20) NULL,
	[Fecha_UltMod] [datetime] NULL,
	[IdUsuarioUltAnu] [varchar](20) NULL,
	[Fecha_UltAnu] [datetime] NULL,
	[nom_pc] [varchar](50) NULL,
	[ip] [varchar](25) NULL,
	[MotiAnula] [varchar](200) NULL,
	[IdTipoCbte] [int] NULL,
	[IdCbteCble] [numeric](9, 0) NULL,
	[IdOrdenPago] [numeric](9, 0) NULL,
 CONSTRAINT [PK_ro_prestamo] PRIMARY KEY CLUSTERED 
(
	[IdEmpresa] ASC,
	[IdPrestamo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO



ALTER TABLE [dbo].[ro_prestamo]  WITH CHECK ADD  CONSTRAINT [FK_ro_prestamo_ro_empleado] FOREIGN KEY([IdEmpresa], [IdEmpleado])
REFERENCES [dbo].[ro_empleado] ([IdEmpresa], [IdEmpleado])
GO

ALTER TABLE [dbo].[ro_prestamo] CHECK CONSTRAINT [FK_ro_prestamo_ro_empleado]
GO


