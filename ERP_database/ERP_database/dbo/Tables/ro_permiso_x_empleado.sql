﻿CREATE TABLE [dbo].[ro_permiso_x_empleado] (
    [IdEmpresa]           INT           NOT NULL,
    [IdPermiso]           NUMERIC (18)  NOT NULL,
    [IdEmpleado]          NUMERIC (18)  NOT NULL,
    [IdEmpleadoAprueba]   NUMERIC (18)  NULL,
    [FechaInicio]         DATE          NOT NULL,
    [FechaFin]            DATE          NOT NULL,
    [HoraSalida]          TIME (7)      NULL,
    [HoraRegreso]         TIME (7)      NULL,
    [DescuentaVacaciones] BIT           NOT NULL,
    [Recuperable]         BIT           NOT NULL,
    [Asunto]              VARCHAR (MAX) NOT NULL,
    [Descripcion]         VARCHAR (MAX) NOT NULL,
    [TipoPermiso]         VARCHAR (50)  NOT NULL,
    [estado]              BIT           NOT NULL,
    [IdUsuario]           VARCHAR (20)  NULL,
    [Fecha_Transac]       DATETIME      NULL,
    [IdUsuarioUltMod]     VARCHAR (20)  NULL,
    [Fecha_UltMod]        DATETIME      NULL,
    [IdUsuarioUltAnu]     VARCHAR (20)  NULL,
    [Fecha_UltAnu]        DATETIME      NULL,
    [ip]                  VARCHAR (25)  NULL,
    [MotiAnula]           VARCHAR (200) NULL,
    CONSTRAINT [PK_ro_permiso_x_empleado] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdPermiso] ASC),
    CONSTRAINT [FK_ro_permiso_x_empleado_ro_empleado] FOREIGN KEY ([IdEmpresa], [IdEmpleado]) REFERENCES [dbo].[ro_empleado] ([IdEmpresa], [IdEmpleado]),
    CONSTRAINT [FK_ro_permiso_x_empleado_ro_empleado1] FOREIGN KEY ([IdEmpresa], [IdEmpleadoAprueba]) REFERENCES [dbo].[ro_empleado] ([IdEmpresa], [IdEmpleado])
);



