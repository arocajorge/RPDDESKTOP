CREATE TABLE [dbo].[ro_Historico_Liquidacion_Vacaciones_Det_DescNovedad] (
    [IdEmpresa]              INT          NOT NULL,
    [IdNomina_tipo]          INT          NOT NULL,
    [IdEmpleado]             NUMERIC (18) NOT NULL,
    [IdSolicitud_Vacaciones] INT          NOT NULL,
    [IdNovedad]              NUMERIC (18) NOT NULL,
    [IdNomina_Tipo_Liq]      INT          NOT NULL,
    [IdRubro]                VARCHAR (50) NOT NULL,
    [Secuencia]              INT          NOT NULL,
    [Valor]                  FLOAT (53)   NOT NULL,
    CONSTRAINT [PK_ro_Historico_Liquidacion_Vacaciones_Det_DescNovedad] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdNomina_tipo] ASC, [IdEmpleado] ASC, [IdSolicitud_Vacaciones] ASC),
    CONSTRAINT [FK_ro_Historico_Liquidacion_Vacaciones_Det_DescNovedad_ro_empleado_novedad_det] FOREIGN KEY ([IdEmpresa], [IdNovedad], [IdEmpleado], [Secuencia]) REFERENCES [dbo].[ro_empleado_novedad_det] ([IdEmpresa], [IdNovedad], [IdEmpleado], [Secuencia]),
    CONSTRAINT [FK_ro_Historico_Liquidacion_Vacaciones_Det_DescNovedad_ro_Historico_Liquidacion_Vacaciones] FOREIGN KEY ([IdEmpresa], [IdNomina_tipo], [IdSolicitud_Vacaciones], [IdEmpleado]) REFERENCES [dbo].[ro_Historico_Liquidacion_Vacaciones] ([IdEmpresa], [IdNomina_Tipo], [IdLiquidacion], [IdEmpleado])
);

