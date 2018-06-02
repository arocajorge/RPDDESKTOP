CREATE TABLE [Fj_servindustrias].[ro_empleado_x_cargo_fuerza_grupo] (
    [IdEmpresa]   INT           NOT NULL,
    [IdNomina]    INT           NOT NULL,
    [IdEmpleado]  NUMERIC (18)  NOT NULL,
    [IdPeriodo]   INT           NOT NULL,
    [IdFuerza]    INT           NOT NULL,
    [IdGrupo]     INT           NOT NULL,
    [IdCargo]     INT           NOT NULL,
    [Observacion] VARCHAR (100) NULL,
    CONSTRAINT [PK_ro_empleado_x_cargo_fuerza_grupo] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdNomina] ASC, [IdEmpleado] ASC, [IdPeriodo] ASC),
    CONSTRAINT [FK_ro_empleado_x_cargo_fuerza_grupo_ro_cargo] FOREIGN KEY ([IdEmpresa], [IdCargo]) REFERENCES [dbo].[ro_cargo] ([IdEmpresa], [IdCargo]),
    CONSTRAINT [FK_ro_empleado_x_cargo_fuerza_grupo_ro_empleado] FOREIGN KEY ([IdEmpresa], [IdEmpleado]) REFERENCES [dbo].[ro_empleado] ([IdEmpresa], [IdEmpleado]),
    CONSTRAINT [FK_ro_empleado_x_cargo_fuerza_grupo_ro_fuerza] FOREIGN KEY ([IdEmpresa], [IdFuerza]) REFERENCES [Fj_servindustrias].[ro_fuerza] ([IdEmpresa], [IdFuerza]),
    CONSTRAINT [FK_ro_empleado_x_cargo_fuerza_grupo_ro_Grupo_empleado] FOREIGN KEY ([IdEmpresa], [IdGrupo]) REFERENCES [Fj_servindustrias].[ro_Grupo_empleado] ([IdEmpresa], [IdGrupo])
);

