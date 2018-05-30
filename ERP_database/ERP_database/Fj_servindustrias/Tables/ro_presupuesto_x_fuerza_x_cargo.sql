CREATE TABLE [Fj_servindustrias].[ro_presupuesto_x_fuerza_x_cargo] (
    [IdEmpresa]          INT           NOT NULL,
    [IdNomina]           INT           NOT NULL,
    [IdFuerza]           INT           NOT NULL,
    [Anio]               INT           NOT NULL,
    [Mes]                INT           NOT NULL,
    [IdCargo]            INT           NOT NULL,
    [CantidadEmpleados]  NUMERIC (18)  NOT NULL,
    [Presupuesto]        FLOAT (53)    NOT NULL,
    [Observacion]        VARCHAR (100) NULL,
    [Dias_SyD_y_Feriado] INT           NOT NULL,
    [diasEfectivos]      INT           NOT NULL,
    [BaseVariable]       FLOAT (53)    NULL,
    CONSTRAINT [PK_ro_presupuesto_x_fuerza_x_cargo] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdNomina] ASC, [IdFuerza] ASC, [Anio] ASC, [Mes] ASC, [IdCargo] ASC),
    CONSTRAINT [FK_ro_presupuesto_x_fuerza_x_cargo_ro_Nomina_Tipo] FOREIGN KEY ([IdEmpresa], [IdNomina]) REFERENCES [dbo].[ro_Nomina_Tipo] ([IdEmpresa], [IdNomina_Tipo])
);



