CREATE TABLE [dbo].[imp_parametro] (
    [IdEmpresa]                  INT          NOT NULL,
    [IdCtaCble]                  VARCHAR (20) NOT NULL,
    [IdTipoCbte_liquidacion]     INT          NOT NULL,
    [IdTipoCbte_liquidacion_anu] INT          NOT NULL,
    CONSTRAINT [PK_imp_parametro] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC),
    CONSTRAINT [FK_imp_parametro_ct_cbtecble_tipo] FOREIGN KEY ([IdEmpresa], [IdTipoCbte_liquidacion]) REFERENCES [dbo].[ct_cbtecble_tipo] ([IdEmpresa], [IdTipoCbte]),
    CONSTRAINT [FK_imp_parametro_ct_cbtecble_tipo1] FOREIGN KEY ([IdEmpresa], [IdTipoCbte_liquidacion_anu]) REFERENCES [dbo].[ct_cbtecble_tipo] ([IdEmpresa], [IdTipoCbte]),
    CONSTRAINT [FK_imp_parametro_tb_empresa] FOREIGN KEY ([IdEmpresa]) REFERENCES [dbo].[tb_empresa] ([IdEmpresa])
);



