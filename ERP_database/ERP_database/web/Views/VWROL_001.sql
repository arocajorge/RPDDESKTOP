CREATE VIEW web. VWROL_001 AS
SELECT         dbo.ro_rol.IdEmpresa, dbo.ro_rol.IdNominaTipo, dbo.ro_rol.IdNominaTipoLiqui, dbo.ro_rol.Descripcion, dbo.ro_rol.Observacion, dbo.ro_rol.Cerrado, dbo.ro_Departamento.de_descripcion, 
                         dbo.ro_rol_detalle.IdEmpleado, dbo.ro_rol_detalle.IdRubro, dbo.ro_rol_detalle.Orden, dbo.ro_rol_detalle.rub_visible_reporte, dbo.tb_persona.pe_nombre, dbo.tb_persona.pe_nombreCompleto, dbo.tb_persona.pe_cedulaRuc, 
                         dbo.ro_empleado.em_codigo, dbo.ro_Departamento.IdDepartamento, dbo.ro_area.IdArea, dbo.ro_Division.IdDivision, dbo.ro_area.Descripcion AS Area, dbo.ro_Division.Descripcion AS Division, dbo.ro_periodo.pe_FechaIni, 
                         dbo.ro_periodo.pe_FechaFin, dbo.ro_periodo.pe_estado, dbo.ro_Nomina_Tipo.Descripcion AS Nomina, dbo.ro_rol.IdPeriodo, dbo.ro_rubro_tipo.ru_codRolGen, dbo.tb_persona.pe_apellido, dbo.ro_rubro_tipo.ru_descripcion, 
                         dbo.ro_rubro_tipo.NombreCorto, dbo.ro_Nomina_Tipoliqui.DescripcionProcesoNomina, dbo.ro_rol_detalle.Valor, dbo.tb_sucursal.Su_Descripcion, dbo.ro_empleado.em_fechaIngaRol,
						CONVERT( varchar(10),pe_FechaIni, 103)  +'  AL '+ CONVERT( varchar(10),pe_FechaFin, 103) +'      [ '+ CAST(dbo.ro_periodo.IdPeriodo AS VARCHAR)+']' Periodo
FROM            dbo.ro_area INNER JOIN
                         dbo.ro_periodo INNER JOIN
                         dbo.ro_rol INNER JOIN
                         dbo.ro_rol_detalle ON dbo.ro_rol.IdEmpresa = dbo.ro_rol_detalle.IdEmpresa AND dbo.ro_rol.IdNominaTipo = dbo.ro_rol_detalle.IdNominaTipo AND dbo.ro_rol.IdNominaTipoLiqui = dbo.ro_rol_detalle.IdNominaTipoLiqui AND 
                         dbo.ro_rol.IdPeriodo = dbo.ro_rol_detalle.IdPeriodo INNER JOIN
                         dbo.ro_empleado ON dbo.ro_rol_detalle.IdEmpresa = dbo.ro_empleado.IdEmpresa AND dbo.ro_rol_detalle.IdEmpleado = dbo.ro_empleado.IdEmpleado INNER JOIN
                         dbo.tb_persona ON dbo.ro_empleado.IdPersona = dbo.tb_persona.IdPersona INNER JOIN
                         dbo.ro_Departamento ON dbo.ro_empleado.IdEmpresa = dbo.ro_Departamento.IdEmpresa AND dbo.ro_empleado.IdDepartamento = dbo.ro_Departamento.IdDepartamento ON 
                         dbo.ro_periodo.IdEmpresa = dbo.ro_rol.IdEmpresa AND dbo.ro_periodo.IdPeriodo = dbo.ro_rol.IdPeriodo INNER JOIN
                         dbo.ro_Nomina_Tipo ON dbo.ro_rol.IdEmpresa = dbo.ro_Nomina_Tipo.IdEmpresa AND dbo.ro_rol_detalle.IdNominaTipo = dbo.ro_Nomina_Tipo.IdNomina_Tipo AND 
                         dbo.ro_rol.IdNominaTipo = dbo.ro_Nomina_Tipo.IdNomina_Tipo INNER JOIN
                         dbo.ro_rubro_tipo ON dbo.ro_rol_detalle.IdRubro = dbo.ro_rubro_tipo.IdRubro AND dbo.ro_rol_detalle.IdEmpresa = dbo.ro_rubro_tipo.IdEmpresa INNER JOIN
                         dbo.ro_Nomina_Tipoliqui ON dbo.ro_rol.IdEmpresa = dbo.ro_Nomina_Tipoliqui.IdEmpresa AND dbo.ro_rol.IdNominaTipo = dbo.ro_Nomina_Tipoliqui.IdNomina_Tipo AND 
                         dbo.ro_rol.IdNominaTipoLiqui = dbo.ro_Nomina_Tipoliqui.IdNomina_TipoLiqui AND dbo.ro_Nomina_Tipo.IdEmpresa = dbo.ro_Nomina_Tipoliqui.IdEmpresa AND 
                         dbo.ro_Nomina_Tipo.IdNomina_Tipo = dbo.ro_Nomina_Tipoliqui.IdNomina_Tipo INNER JOIN
                         dbo.tb_sucursal ON dbo.ro_empleado.IdEmpresa = dbo.tb_sucursal.IdEmpresa AND dbo.ro_empleado.IdSucursal = dbo.tb_sucursal.IdSucursal INNER JOIN
                         dbo.ro_Division ON dbo.ro_empleado.IdEmpresa = dbo.ro_Division.IdEmpresa AND dbo.ro_empleado.IdDivision = dbo.ro_Division.IdDivision ON dbo.ro_area.IdArea = dbo.ro_empleado.IdArea AND 
                         dbo.ro_area.IdEmpresa = dbo.ro_empleado.IdEmpresa
						 where rub_visible_reporte=1
GO



GO



GO


