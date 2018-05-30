create view vwRo_nomina_x_horas_extras as
SELECT        dbo.ro_nomina_x_horas_extras.IdEmpresa, dbo.ro_nomina_x_horas_extras.IdNominaTipo, dbo.ro_nomina_x_horas_extras.IdNominaTipoLiqui, dbo.ro_nomina_x_horas_extras.IdPeriodo, dbo.ro_Nomina_Tipo.Descripcion, 
                         dbo.ro_Nomina_Tipoliqui.DescripcionProcesoNomina,CAST( CAST( dbo.ro_periodo.pe_FechaIni as date)as varchar(12)) +'  al  ' +CAST( CAST( dbo.ro_periodo.pe_FechaFin as date)as varchar(12)) as Periodo
FROM            dbo.ro_nomina_x_horas_extras INNER JOIN
                         dbo.ro_Nomina_Tipoliqui ON dbo.ro_nomina_x_horas_extras.IdEmpresa = dbo.ro_Nomina_Tipoliqui.IdEmpresa AND dbo.ro_nomina_x_horas_extras.IdNominaTipo = dbo.ro_Nomina_Tipoliqui.IdNomina_Tipo AND 
                         dbo.ro_nomina_x_horas_extras.IdNominaTipoLiqui = dbo.ro_Nomina_Tipoliqui.IdNomina_TipoLiqui INNER JOIN
                         dbo.ro_Nomina_Tipo ON dbo.ro_Nomina_Tipoliqui.IdEmpresa = dbo.ro_Nomina_Tipo.IdEmpresa AND dbo.ro_Nomina_Tipoliqui.IdNomina_Tipo = dbo.ro_Nomina_Tipo.IdNomina_Tipo INNER JOIN
                         dbo.ro_periodo ON dbo.ro_nomina_x_horas_extras.IdEmpresa = dbo.ro_periodo.IdEmpresa AND dbo.ro_nomina_x_horas_extras.IdPeriodo = dbo.ro_periodo.IdPeriodo
GROUP BY dbo.ro_nomina_x_horas_extras.IdEmpresa, dbo.ro_nomina_x_horas_extras.IdNominaTipo, dbo.ro_nomina_x_horas_extras.IdNominaTipoLiqui, dbo.ro_nomina_x_horas_extras.IdPeriodo, dbo.ro_Nomina_Tipo.Descripcion, 
                         dbo.ro_Nomina_Tipoliqui.DescripcionProcesoNomina, dbo.ro_periodo.pe_FechaIni, dbo.ro_periodo.pe_FechaFin