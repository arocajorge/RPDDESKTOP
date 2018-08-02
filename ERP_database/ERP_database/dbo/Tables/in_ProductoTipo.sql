﻿CREATE TABLE [dbo].[in_ProductoTipo] (
    [IdEmpresa]               INT           NOT NULL,
    [IdProductoTipo]          INT           NOT NULL,
    [tp_descripcion]          VARCHAR (50)  NOT NULL,
    [tp_EsCombo]              CHAR (1)      NULL,
    [tp_ManejaInven]          CHAR (1)      NULL,
    [tp_ManejaLote]           BIT           NOT NULL,
    [Estado]                  CHAR (1)      NOT NULL,
    [IdUsuario]               VARCHAR (20)  NULL,
    [Fecha_Transac]           DATETIME      NULL,
    [IdUsuarioUltMod]         VARCHAR (20)  NULL,
    [Fecha_UltMod]            DATETIME      NULL,
    [IdUsuarioUltAnu]         VARCHAR (20)  NULL,
    [Fecha_UltAnu]            DATETIME      NULL,
    [nom_pc]                  VARCHAR (50)  NULL,
    [ip]                      VARCHAR (25)  NULL,
    [MotivoAnulacion]         VARCHAR (200) NULL,
    [tp_es_lote]              BIT           NOT NULL,
    [Aparece_modu_Ventas]     BIT           NOT NULL,
    [Aparece_modu_Compras]    BIT           NOT NULL,
    [Aparece_modu_Inventario] BIT           NOT NULL,
    [Aparece_modu_Activo_F]   BIT           NOT NULL,
    CONSTRAINT [PK_in_productoTipo] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdProductoTipo] ASC)
);







