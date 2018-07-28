CREATE TABLE [dbo].[imp_orden_compra_ext_recepcion] (
    [IdEmpresa]              INT            NOT NULL,
    [IdRecepcion]            DECIMAL (18)   NOT NULL,
    [or_fecha]               DATETIME       NOT NULL,
    [or_observacion]         VARCHAR (1000) NULL,
    [IdEmpresa_oc]           INT            NULL,
    [IdOrdenCompraExt]       DECIMAL (18)   NOT NULL,
    [IdEmpresa_inv]          INT            NOT NULL,
    [IdBodega]               INT            NOT NULL,
    [IdSucursal_inv]         INT            NOT NULL,
    [IdMovi_inven_tipo_inv]  INT            NOT NULL,
    [IdNumMovi_inv]          NUMERIC (18)   NOT NULL,
    [estado]                 BIT            NOT NULL,
    [IdUsuario_creacion]     VARCHAR (20)   NULL,
    [fecha_creacion]         DATETIME       NULL,
    [IdUsuario_modificacion] VARCHAR (20)   NULL,
    [fecha_modificacion]     DATETIME       NULL,
    [IdUsuario_anulacion]    VARCHAR (20)   NULL,
    [fecha_anulacion]        DATETIME       NULL,
    CONSTRAINT [PK_imp_orden_compra_ext_recepcion] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdRecepcion] ASC),
    CONSTRAINT [FK_imp_orden_compra_ext_recepcion_imp_orden_compra_ext] FOREIGN KEY ([IdEmpresa_oc], [IdOrdenCompraExt]) REFERENCES [dbo].[imp_orden_compra_ext] ([IdEmpresa], [IdOrdenCompra_ext]),
    CONSTRAINT [FK_imp_orden_compra_ext_recepcion_in_Ing_Egr_Inven] FOREIGN KEY ([IdEmpresa_inv], [IdSucursal_inv], [IdMovi_inven_tipo_inv], [IdNumMovi_inv]) REFERENCES [dbo].[in_Ing_Egr_Inven] ([IdEmpresa], [IdSucursal], [IdMovi_inven_tipo], [IdNumMovi])
);





