CREATE TABLE [Fj_servindustrias].[ro_fuerza] (
    [IdEmpresa]         INT           NOT NULL,
    [IdFuerza]          INT           NOT NULL,
    [fu_descripcion]    VARCHAR (100) NULL,
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
    [IdCentroCosto]     VARCHAR (20)  NULL,
    [IdSuccentroCosto]  VARCHAR (20)  NULL,
    [cedula_gasto]      VARCHAR (50)  NULL,
    [descripcion_gasto] VARCHAR (200) NULL,
    [valor_gasto]       FLOAT (53)    NULL,
    CONSTRAINT [PK_ro_fuerza] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdFuerza] ASC),
    CONSTRAINT [FK_ro_fuerza_ct_centro_costo_sub_centro_costo] FOREIGN KEY ([IdEmpresa], [IdCentroCosto], [IdSuccentroCosto]) REFERENCES [dbo].[ct_centro_costo_sub_centro_costo] ([IdEmpresa], [IdCentroCosto], [IdCentroCosto_sub_centro_costo])
);





