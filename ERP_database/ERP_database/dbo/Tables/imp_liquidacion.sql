CREATE TABLE [dbo].[imp_liquidacion] (
    [IdEmpresa]            INT           NOT NULL,
    [IdLiquidacion]        NUMERIC (18)  NOT NULL,
    [li_num_documento]     VARCHAR (100) NOT NULL,
    [li_codigo]            VARCHAR (30)  NOT NULL,
    [li_num_DAU]           VARCHAR (50)  NOT NULL,
    [li_fecha]             DATETIME      NOT NULL,
    [li_observacion]       VARCHAR (500) NULL,
    [li_factor_conversion] FLOAT (53)    NOT NULL,
    [li_total_fob]         FLOAT (53)    NOT NULL,
    [li_total_gastos]      FLOAT (53)    NOT NULL,
    [li_total_bodega]      FLOAT (53)    NOT NULL,
    [li_factor_costo]      FLOAT (53)    NOT NULL,
    [estado]               BIT           NOT NULL,
    [cerrado]              BIT           NOT NULL,
    CONSTRAINT [PK_imp_liquidacion] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdLiquidacion] ASC)
);



