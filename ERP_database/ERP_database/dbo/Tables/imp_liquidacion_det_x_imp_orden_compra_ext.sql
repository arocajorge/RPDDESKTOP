CREATE TABLE [dbo].[imp_liquidacion_det_x_imp_orden_compra_ext] (
    [IdEmpresa]         INT          NOT NULL,
    [IdLiquidacion]     NUMERIC (18) NOT NULL,
    [IdEmpresa_oe]      INT          NOT NULL,
    [IdOrdenCompra_ext] DECIMAL (18) NOT NULL,
    [observacion]       VARCHAR (10) NULL,
    CONSTRAINT [PK_imp_liquidacion_det_x_imp_orden_compra_ext] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdLiquidacion] ASC, [IdEmpresa_oe] ASC, [IdOrdenCompra_ext] ASC),
    CONSTRAINT [FK_imp_liquidacion_det_x_imp_orden_compra_ext_imp_liquidacion] FOREIGN KEY ([IdEmpresa], [IdLiquidacion]) REFERENCES [dbo].[imp_liquidacion] ([IdEmpresa], [IdLiquidacion]),
    CONSTRAINT [FK_imp_liquidacion_det_x_imp_orden_compra_ext_imp_orden_compra_ext] FOREIGN KEY ([IdEmpresa_oe], [IdOrdenCompra_ext]) REFERENCES [dbo].[imp_orden_compra_ext] ([IdEmpresa], [IdOrdenCompra_ext])
);

