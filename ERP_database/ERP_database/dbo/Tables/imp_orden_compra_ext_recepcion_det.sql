CREATE TABLE [dbo].[imp_orden_compra_ext_recepcion_det] (
    [IdEmpresa]         INT           NOT NULL,
    [IdRecepcion]       DECIMAL (18)  NOT NULL,
    [secuencia]         INT           NOT NULL,
    [IdProducto]        NUMERIC (18)  NOT NULL,
    [IdEmpresa_oc]      INT           NOT NULL,
    [IdOrdenCompra_ext] DECIMAL (18)  NOT NULL,
    [Secuencia_oc]      INT           NOT NULL,
    [cantidad]          INT           NOT NULL,
    [Observacion]       VARCHAR (500) NULL,
    CONSTRAINT [PK_imp_orden_compra_ext_recepcion_det] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdRecepcion] ASC, [secuencia] ASC),
    CONSTRAINT [FK_imp_orden_compra_ext_recepcion_det_imp_orden_compra_ext_det] FOREIGN KEY ([IdEmpresa_oc], [IdOrdenCompra_ext], [Secuencia_oc]) REFERENCES [dbo].[imp_orden_compra_ext_det] ([IdEmpresa], [IdOrdenCompra_ext], [Secuencia]),
    CONSTRAINT [FK_imp_orden_compra_ext_recepcion_det_imp_orden_compra_ext_recepcion] FOREIGN KEY ([IdEmpresa], [IdRecepcion]) REFERENCES [dbo].[imp_orden_compra_ext_recepcion] ([IdEmpresa], [IdRecepcion])
);

