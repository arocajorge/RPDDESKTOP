CREATE TABLE [dbo].[imp_orden_compra_ext_recepcion] (
    [IdEmpresa]         INT            NOT NULL,
    [IdOrdenCompra_ext] DECIMAL (18)   NOT NULL,
    [or_fecha]          DATETIME       NOT NULL,
    [or_observacion]    VARCHAR (1000) NULL,
    CONSTRAINT [PK_imp_orden_compra_ext_recepcion] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdOrdenCompra_ext] ASC)
);

