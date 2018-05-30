CREATE view fj_servindustrias.vwROLES_Rpt013 as

						SELECT        emp.IdEmpresa, emp.IdEmpleado, pers.pe_cedulaRuc, pers.pe_apellido + ' ' + pers.pe_nombre AS Empleado, emp.em_codigo, act_fin.Observacion, act_fin.Ingresos, act_fin.Egresos, act_fin.UltimaRemuneracion, 
                         CAST(act_fin.FechaSalida AS date) FechaSalida, act_fin.FechaIngreso, act_fin.IdCausaTerminacion, cat.ca_descripcion AS TipoTerminacion, dep.de_descripcion, carg.ca_descripcion, SUM(act_fin_det.Otros_valor) 
                         AS ValorDesaucio, DATEDIFF(DD, emp.em_fechaIngaRol, emp.em_fechaSalida) AS Antiguedad, dbo.ro_catalogo.ca_descripcion AS EstadoLiquidacion, cast(CASE WHEN IIF(emp.em_fechaSalida = NULL, datediff(dayofyear, 
                         emp.em_fechaSalida, emp.em_fechaIngaRol), datediff(dayofyear, emp.em_fechaIngaRol, getdate())) >= 360 THEN IIF(emp.em_fechaSalida = NULL, datediff(dayofyear, emp.em_fechaSalida, emp.em_fechaIngaRol), 
                         datediff(dayofyear, emp.em_fechaIngaRol, getdate())) / 360 ELSE 0 END AS varchar(20)) + ' año(s), ' + cast(CASE WHEN IIF(emp.em_fechaSalida = NULL, datediff(dayofyear, emp.em_fechaSalida, emp.em_fechaIngaRol), 
                         datediff(dayofyear, emp.em_fechaIngaRol, getdate())) >= 30 THEN (IIF(emp.em_fechaSalida = NULL, datediff(dayofyear, emp.em_fechaSalida, emp.em_fechaIngaRol), datediff(dayofyear, emp.em_fechaIngaRol, getdate())) / 30) 
                         - (CASE WHEN IIF(emp.em_fechaSalida = NULL, datediff(dayofyear, emp.em_fechaSalida, emp.em_fechaIngaRol), datediff(dayofyear, emp.em_fechaIngaRol, getdate())) >= 360 THEN IIF(emp.em_fechaSalida = NULL, 
                         datediff(dayofyear, emp.em_fechaSalida, emp.em_fechaIngaRol), datediff(dayofyear, emp.em_fechaIngaRol, getdate())) / 360 ELSE 0 END * 12) ELSE 0 END AS varchar(20)) + ' mes(es)' AS antiguedad_string
FROM            dbo.tb_persona AS pers INNER JOIN
                         dbo.ro_empleado AS emp ON pers.IdPersona = emp.IdPersona INNER JOIN
                         dbo.ro_Acta_Finiquito AS act_fin ON emp.IdEmpresa = act_fin.IdEmpresa AND emp.IdEmpleado = act_fin.IdEmpleado INNER JOIN
                         dbo.ro_Acta_Finiquito_Detalle AS act_fin_det ON act_fin.IdEmpresa = act_fin_det.IdEmpresa AND act_fin.IdActaFiniquito = act_fin_det.IdActaFiniquito AND act_fin.IdEmpleado = act_fin_det.IdEmpleado INNER JOIN
                         dbo.ro_cargo AS carg ON emp.IdEmpresa = carg.IdEmpresa AND emp.IdCargo = carg.IdCargo INNER JOIN
                         dbo.ro_Departamento AS dep ON emp.IdEmpresa = dep.IdEmpresa AND emp.IdDepartamento = dep.IdDepartamento INNER JOIN
                         dbo.ro_catalogo AS cat ON act_fin.IdCausaTerminacion = cat.IdCatalogo INNER JOIN
                         dbo.ro_catalogo ON emp.em_status = dbo.ro_catalogo.CodCatalogo
GROUP BY emp.IdEmpresa, emp.IdEmpleado, pers.pe_cedulaRuc, pers.pe_apellido + ' ' + pers.pe_nombre, emp.em_codigo, act_fin.Observacion, act_fin.Ingresos, act_fin.Egresos, act_fin.UltimaRemuneracion, act_fin.FechaSalida, 
                         act_fin.FechaIngreso, act_fin.IdCausaTerminacion, cat.ca_descripcion, dep.de_descripcion, carg.ca_descripcion, emp.em_fechaIngaRol, emp.em_fechaSalida, dbo.ro_catalogo.ca_descripcion
