CREATE TABLE [dbo].[ro_Cuentas_contables_x_empleado] (
    [IdEmpresa]           INT          NOT NULL,
    [IdEmpleado]          NUMERIC (18) NOT NULL,
    [IdRubro]             VARCHAR (10) NOT NULL,
    [IdCtaCble]           VARCHAR (20) NOT NULL,
    [IdPunto_cargo]       INT          NULL,
    [IdPunto_cargo_grupo] INT          NULL,
    CONSTRAINT [PK_ro_Cuentas_contables_x_empleado] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdEmpleado] ASC, [IdRubro] ASC, [IdCtaCble] ASC),
    CONSTRAINT [FK_ro_Cuentas_contables_x_empleado_ct_punto_cargo] FOREIGN KEY ([IdEmpresa], [IdPunto_cargo]) REFERENCES [dbo].[ct_punto_cargo] ([IdEmpresa], [IdPunto_cargo]),
    CONSTRAINT [FK_ro_Cuentas_contables_x_empleado_ct_punto_cargo_grupo] FOREIGN KEY ([IdEmpresa], [IdPunto_cargo_grupo]) REFERENCES [dbo].[ct_punto_cargo_grupo] ([IdEmpresa], [IdPunto_cargo_grupo])
);

