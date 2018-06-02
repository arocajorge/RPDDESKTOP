﻿CREATE TABLE [Fj_servindustrias].[ro_descuento_no_planificados] (
    [IdEmpresa]         INT           NOT NULL,
    [IdNomina_Tipo]     INT           NOT NULL,
    [IdEmpleado]        NUMERIC (18)  NOT NULL,
    [IdDescuento]       INT           NOT NULL,
    [IdNovedad]         NUMERIC (18)  NULL,
    [IdRubro]           VARCHAR (50)  NOT NULL,
    [Observacion]       VARCHAR (200) NOT NULL,
    [Valor]             FLOAT (53)    NOT NULL,
    [Fecha_Incidente]   DATE          NOT NULL,
    [Estado]            BIT           NOT NULL,
    [IdUsuario]         VARCHAR (50)  NULL,
    [Fecha_Transaccion] DATETIME      NULL,
    [IdUsuarioUltModi]  VARCHAR (50)  NULL,
    [Fecha_UltMod]      DATETIME      NULL,
    [IdUsuarioUltAnu]   VARCHAR (50)  NULL,
    [Fecha_UltAnu]      DATETIME      NULL,
    [MotivoAnulacion]   VARCHAR (50)  NULL,
    [nom_pc]            VARCHAR (50)  NULL,
    [ip]                VARCHAR (50)  NULL,
    CONSTRAINT [PK_ro_descuento_no_planificados] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdNomina_Tipo] ASC, [IdEmpleado] ASC, [IdDescuento] ASC),
    CONSTRAINT [FK_ro_descuento_no_planificados_ro_empleado_Novedad] FOREIGN KEY ([IdEmpresa], [IdNovedad], [IdEmpleado]) REFERENCES [dbo].[ro_empleado_Novedad] ([IdEmpresa], [IdNovedad], [IdEmpleado])
);

