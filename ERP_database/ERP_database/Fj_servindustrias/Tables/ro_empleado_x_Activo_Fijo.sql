CREATE TABLE [Fj_servindustrias].[ro_empleado_x_Activo_Fijo] (
    [IdEmpresa]                      INT          NOT NULL,
    [IdEmpleado]                     NUMERIC (18) NOT NULL,
    [IdNomina_tipo]                  INT          NULL,
    [IdPeriodo]                      INT          NULL,
    [IdActivo_fijo]                  INT          NOT NULL,
    [Fecha_Asignacion]               DATE         NOT NULL,
    [Fecha_Hasta]                    DATE         NOT NULL,
    [IdCentroCosto]                  VARCHAR (20) NULL,
    [IdCentroCosto_sub_centro_costo] VARCHAR (20) NULL,
    CONSTRAINT [PK_ro_empleado_x_Activo_Fijo_1] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdEmpleado] ASC),
    CONSTRAINT [FK_ro_empleado_x_Activo_Fijo_Af_Activo_fijo] FOREIGN KEY ([IdEmpresa], [IdActivo_fijo]) REFERENCES [dbo].[Af_Activo_fijo] ([IdEmpresa], [IdActivoFijo]),
    CONSTRAINT [FK_ro_empleado_x_Activo_Fijo_ro_empleado] FOREIGN KEY ([IdEmpresa], [IdEmpleado]) REFERENCES [dbo].[ro_empleado] ([IdEmpresa], [IdEmpleado])
);











