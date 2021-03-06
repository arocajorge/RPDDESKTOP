﻿CREATE TABLE [web].[fa_SPFAC_010] (
    [IdEmpresa]       INT            NOT NULL,
    [IdProducto]      NUMERIC (18)   NOT NULL,
    [IdProductoTipo]  INT            NOT NULL,
    [IdMarca]         INT            NOT NULL,
    [IdCategoria]     VARCHAR (25)   NOT NULL,
    [IdLinea]         INT            NOT NULL,
    [IdGrupo]         INT            NOT NULL,
    [IdSubGrupo]      INT            NOT NULL,
    [IdPresentacion]  VARCHAR (25)   NOT NULL,
    [NomProducto]     NVARCHAR (500) NOT NULL,
    [NomPresentacion] VARCHAR (150)  NULL,
    [NomMarca]        VARCHAR (100)  NULL,
    [NomTipoProducto] VARCHAR (50)   NULL,
    [NomCategoria]    VARCHAR (100)  NULL,
    [NomLinea]        VARCHAR (150)  NULL,
    [NomGrupo]        VARCHAR (150)  NULL,
    [NomSubGrupo]     VARCHAR (150)  NULL,
    [PRECIO1]         FLOAT (53)     NOT NULL,
    [PRECIO2]         FLOAT (53)     NOT NULL,
    [PRECIO3]         FLOAT (53)     NOT NULL,
    [PRECIO4]         FLOAT (53)     NOT NULL,
    [PRECIO5]         FLOAT (53)     NOT NULL,
    [Estado]          CHAR (1)       NOT NULL,
    CONSTRAINT [PK_fa_SPFAC_010] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdProducto] ASC)
);

