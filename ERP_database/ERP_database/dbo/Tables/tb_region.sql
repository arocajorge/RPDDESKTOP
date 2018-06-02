﻿CREATE TABLE [dbo].[tb_region] (
    [Cod_Region] VARCHAR (10)  NOT NULL,
    [Nom_region] VARCHAR (100) NOT NULL,
    [codigo]     VARCHAR (10)  NULL,
    [estado]     BIT           NOT NULL,
    CONSTRAINT [PK_tb_region] PRIMARY KEY CLUSTERED ([Cod_Region] ASC)
);



