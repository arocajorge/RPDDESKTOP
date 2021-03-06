﻿CREATE TABLE [dbo].[ro_Acta_Finiquito_Detalle_x_Decimos] (
    [IdEmpresa]          INT          NOT NULL,
    [IdNominatipo]       INT          NOT NULL,
    [IdLiquidacion]      NUMERIC (18) NOT NULL,
    [IdEmpleado]         NUMERIC (18) NOT NULL,
    [Sec]                INT          NOT NULL,
    [Anio]               INT          NOT NULL,
    [Mes]                INT          NOT NULL,
    [Total_Remuneracion] FLOAT (53)   NOT NULL,
    [Decimo]             FLOAT (53)   NOT NULL,
    [DiasTrabajados]     INT          NULL,
    CONSTRAINT [PK_ro_Acta_Finiquito_Detalle_x_Decimos] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdNominatipo] ASC, [IdLiquidacion] ASC, [IdEmpleado] ASC, [Sec] ASC)
);

