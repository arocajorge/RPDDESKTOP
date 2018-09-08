CREATE VIEW [web].[ro_empleado_x_Proyeccion_Gastos_Personales]
	AS
SELECT        dbo.ro_empleado_x_Proyeccion_Gastos_Personales.IdEmpresa, dbo.ro_empleado_x_Proyeccion_Gastos_Personales.IdEmpleado, dbo.ro_empleado_x_Proyeccion_Gastos_Personales.AnioFiscal, 
                         dbo.tb_persona.pe_cedulaRuc, dbo.tb_persona.pe_nombreCompleto
FROM            dbo.ro_empleado INNER JOIN
                         dbo.tb_persona ON dbo.ro_empleado.IdPersona = dbo.tb_persona.IdPersona INNER JOIN
                         dbo.ro_empleado_x_Proyeccion_Gastos_Personales ON dbo.ro_empleado.IdEmpresa = dbo.ro_empleado_x_Proyeccion_Gastos_Personales.IdEmpresa AND 
                         dbo.ro_empleado.IdEmpleado = dbo.ro_empleado_x_Proyeccion_Gastos_Personales.IdEmpleado
GROUP BY dbo.ro_empleado_x_Proyeccion_Gastos_Personales.IdEmpresa, dbo.ro_empleado_x_Proyeccion_Gastos_Personales.IdEmpleado, dbo.ro_empleado_x_Proyeccion_Gastos_Personales.AnioFiscal, 
                         dbo.tb_persona.pe_cedulaRuc, dbo.tb_persona.pe_nombreCompleto
