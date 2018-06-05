﻿CREATE TABLE [dbo].[ro_Solicitud_Vacaciones_x_empleado] (
    [IdEmpresa]          INT           NOT NULL,
    [IdEmpleado]         NUMERIC (18)  NOT NULL,
    [IdSolicitud]        INT           NOT NULL,
    [IdVacacion]         INT           NOT NULL,
    [IdEmpleado_aprue]   NUMERIC (9)   NOT NULL,
    [IdEmpleado_remp]    NUMERIC (9)   NULL,
    [IdEstadoAprobacion] VARCHAR (10)  NOT NULL,
    [Fecha]              DATETIME      NOT NULL,
    [AnioServicio]       INT           NOT NULL,
    [Dias_q_Corresponde] INT           NOT NULL,
    [Dias_a_disfrutar]   INT           NOT NULL,
    [Dias_pendiente]     INT           NOT NULL,
    [Anio_Desde]         DATETIME      NOT NULL,
    [Anio_Hasta]         DATETIME      NOT NULL,
    [Fecha_Desde]        DATETIME      NOT NULL,
    [Fecha_Hasta]        DATETIME      NOT NULL,
    [Fecha_Retorno]      DATETIME      NOT NULL,
    [Observacion]        VARCHAR (250) NOT NULL,
    [IdUsuario]          VARCHAR (25)  NULL,
    [IdUsuario_Anu]      VARCHAR (25)  NULL,
    [FechaAnulacion]     DATETIME      NULL,
    [Fecha_Transac]      DATETIME      NULL,
    [Fecha_UltMod]       DATETIME      NULL,
    [IdUsuarioUltMod]    VARCHAR (25)  NULL,
    [Estado]             VARCHAR (1)   NULL,
    [MotivoAnulacion]    VARCHAR (250) NULL,
    [ip]                 VARCHAR (250) NULL,
    [nom_pc]             VARCHAR (250) NULL,
    [Gozadas_Pgadas]     BIT           NOT NULL,
    [Canceladas]         BIT           NOT NULL,
    CONSTRAINT [PK_ro_Solicitud_Vacaciones_x_empleado_1] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdEmpleado] ASC, [IdSolicitud] ASC),
    CONSTRAINT [FK_ro_Solicitud_Vacaciones_x_empleado_ro_empleado] FOREIGN KEY ([IdEmpresa], [IdEmpleado]) REFERENCES [dbo].[ro_empleado] ([IdEmpresa], [IdEmpleado]),
    CONSTRAINT [FK_ro_Solicitud_Vacaciones_x_empleado_ro_historico_vacaciones_x_empleado] FOREIGN KEY ([IdEmpresa], [IdEmpleado], [IdVacacion]) REFERENCES [dbo].[ro_historico_vacaciones_x_empleado] ([IdEmpresa], [IdEmpleado], [IdVacacion])
);





