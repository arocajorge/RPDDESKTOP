﻿CREATE TABLE [dbo].[ba_Conciliacion] (
    [IdEmpresa]               INT           NOT NULL,
    [IdConciliacion]          NUMERIC (18)  NOT NULL,
    [IdBanco]                 INT           NOT NULL,
    [IdPeriodo]               INT           NOT NULL,
    [co_Fecha]                DATETIME      NOT NULL,
    [IdEstado_Concil_Cat]     VARCHAR (50)  NOT NULL,
    [co_SaldoContable_MesAnt] FLOAT (53)    NOT NULL,
    [co_totalIng]             FLOAT (53)    NOT NULL,
    [co_totalEgr]             FLOAT (53)    NOT NULL,
    [co_SaldoContable_MesAct] FLOAT (53)    NOT NULL,
    [co_SaldoBanco_EstCta]    FLOAT (53)    NOT NULL,
    [co_SaldoBanco_anterior]  FLOAT (53)    NOT NULL,
    [Estado]                  CHAR (1)      NOT NULL,
    [IdUsuario]               VARCHAR (50)  NULL,
    [IdUsuario_Anu]           VARCHAR (50)  NULL,
    [IdUsuarioUltMod]         VARCHAR (50)  NULL,
    [Fecha_Transac]           DATETIME      NULL,
    [Fecha_UltMod]            DATETIME      NULL,
    [FechaAnulacion]          DATETIME      NULL,
    [MotivoAnulacion]         VARCHAR (250) NULL,
    [co_Observacion]          VARCHAR (500) NULL,
    CONSTRAINT [PK_ba_ConciliacionBancaria] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdConciliacion] ASC),
    CONSTRAINT [FK_ba_Conciliacion_ba_Banco_Cuenta] FOREIGN KEY ([IdEmpresa], [IdBanco]) REFERENCES [dbo].[ba_Banco_Cuenta] ([IdEmpresa], [IdBanco]),
    CONSTRAINT [FK_ba_Conciliacion_ba_Catalogo] FOREIGN KEY ([IdEstado_Concil_Cat]) REFERENCES [dbo].[ba_Catalogo] ([IdCatalogo]),
    CONSTRAINT [FK_ba_Conciliacion_ct_periodo] FOREIGN KEY ([IdEmpresa], [IdPeriodo]) REFERENCES [dbo].[ct_periodo] ([IdEmpresa], [IdPeriodo])
);

