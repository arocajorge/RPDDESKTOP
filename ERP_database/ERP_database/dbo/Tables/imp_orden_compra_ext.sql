CREATE TABLE [dbo].[imp_orden_compra_ext] (
    [IdEmpresa]                    INT           NOT NULL,
    [IdOrdenCompra_ext]            DECIMAL (18)  NOT NULL,
    [IdProveedor]                  NUMERIC (18)  NOT NULL,
    [IdPais_origen]                VARCHAR (10)  NOT NULL,
    [IdPais_embarque]              VARCHAR (10)  NOT NULL,
    [IdCiudad_destino]             VARCHAR (25)  NOT NULL,
    [IdCatalogo_via]               INT           NOT NULL,
    [IdCatalogo_forma_pago]        INT           NOT NULL,
    [oe_fecha]                     DATETIME      NOT NULL,
    [oe_fecha_llegada_est]         DATETIME      NULL,
    [oe_fecha_embarque_est]        DATETIME      NULL,
    [oe_fecha_desaduanizacion_est] DATETIME      NULL,
    [IdCtaCble_importacion]        VARCHAR (20)  NOT NULL,
    [oe_observacion]               VARCHAR (100) NULL,
    [oe_codigo]                    VARCHAR (30)  NULL,
    [estado]                       BIT           NOT NULL,
    [IdUsuario_creacion]           VARCHAR (20)  NULL,
    [fecha_creacion]               DATETIME      NULL,
    [IdUsuario_modificacion]       VARCHAR (20)  NULL,
    [fecha_modificacion]           DATETIME      NULL,
    [IdUsuario_anulacion]          VARCHAR (20)  NULL,
    [fecha_anulacion]              DATETIME      NULL,
    [IdLiquidacion]                NUMERIC (18)  NULL,
    [oe_fecha_llegada]             DATETIME      NULL,
    [oe_fecha_embarque]            DATETIME      NULL,
    [oe_fecha_desaduanizacion]     DATETIME      NULL,
    [IdMoneda_origen]              INT           NULL,
    [IdMoneda_destino]             INT           NULL,
    [Estado_cierre]                BIT           NOT NULL,
    [IdEmpresa_inv]                INT           NULL,
    [IdSucursal_inv]               INT           NULL,
    [IdMovi_inven_tipo_inv]        INT           NULL,
    [IdNumMovi_inv]                NUMERIC (18)  NULL,
    [IdEmpresa_ct]                 INT           NULL,
    [IdTipoCbte_ct]                INT           NULL,
    [IdCbteCble_ct]                NUMERIC (18)  NULL,
    [IdBodega_inv]                 INT           NULL,
    CONSTRAINT [PK_imp_orden_compra_ext] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdOrdenCompra_ext] ASC),
    CONSTRAINT [FK_imp_orden_compra_ext_cp_proveedor1] FOREIGN KEY ([IdEmpresa], [IdProveedor]) REFERENCES [dbo].[cp_proveedor] ([IdEmpresa], [IdProveedor]),
    CONSTRAINT [FK_imp_orden_compra_ext_ct_cbtecble] FOREIGN KEY ([IdEmpresa], [IdTipoCbte_ct], [IdCbteCble_ct]) REFERENCES [dbo].[ct_cbtecble] ([IdEmpresa], [IdTipoCbte], [IdCbteCble]),
    CONSTRAINT [FK_imp_orden_compra_ext_ct_plancta1] FOREIGN KEY ([IdEmpresa], [IdCtaCble_importacion]) REFERENCES [dbo].[ct_plancta] ([IdEmpresa], [IdCtaCble]),
    CONSTRAINT [FK_imp_orden_compra_ext_imp_catalogo] FOREIGN KEY ([IdCatalogo_via]) REFERENCES [dbo].[imp_catalogo] ([IdCatalogo]),
    CONSTRAINT [FK_imp_orden_compra_ext_imp_catalogo1] FOREIGN KEY ([IdCatalogo_forma_pago]) REFERENCES [dbo].[imp_catalogo] ([IdCatalogo]),
    CONSTRAINT [FK_imp_orden_compra_ext_imp_liquidacion] FOREIGN KEY ([IdEmpresa], [IdLiquidacion]) REFERENCES [dbo].[imp_liquidacion] ([IdEmpresa], [IdLiquidacion]),
    CONSTRAINT [FK_imp_orden_compra_ext_in_Ing_Egr_Inven] FOREIGN KEY ([IdEmpresa_inv], [IdSucursal_inv], [IdMovi_inven_tipo_inv], [IdNumMovi_inv]) REFERENCES [dbo].[in_Ing_Egr_Inven] ([IdEmpresa], [IdSucursal], [IdMovi_inven_tipo], [IdNumMovi]),
    CONSTRAINT [FK_imp_orden_compra_ext_tb_ciudad] FOREIGN KEY ([IdCiudad_destino]) REFERENCES [dbo].[tb_ciudad] ([IdCiudad]),
    CONSTRAINT [FK_imp_orden_compra_ext_tb_moneda] FOREIGN KEY ([IdMoneda_origen]) REFERENCES [dbo].[tb_moneda] ([IdMoneda]),
    CONSTRAINT [FK_imp_orden_compra_ext_tb_moneda1] FOREIGN KEY ([IdMoneda_destino]) REFERENCES [dbo].[tb_moneda] ([IdMoneda]),
    CONSTRAINT [FK_imp_orden_compra_ext_tb_pais] FOREIGN KEY ([IdPais_origen]) REFERENCES [dbo].[tb_pais] ([IdPais]),
    CONSTRAINT [FK_imp_orden_compra_ext_tb_pais1] FOREIGN KEY ([IdPais_embarque]) REFERENCES [dbo].[tb_pais] ([IdPais])
);





GO



GO


GO


GO


GO


GO


GO


GO


GO


GO


GO


GO


GO


GO


GO


GO


GO


GO


GO


GO


GO


