CREATE TABLE [Fj_servindustrias].[ro_empleado_x_rutas_asignadas_Det] (
    [IdEmpresa]     INT          NOT NULL,
    [IdNomina_Tipo] INT          NOT NULL,
    [IdEmpleado]    NUMERIC (18) NOT NULL,
    [IdRuta]        INT          NOT NULL,
    [secuencia]     INT          NOT NULL,
    CONSTRAINT [PK_ro_empleado_x_rutas_asignadas_Det] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdNomina_Tipo] ASC, [IdEmpleado] ASC, [IdRuta] ASC)
);

