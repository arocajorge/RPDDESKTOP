CREATE VIEW web.vwro_empleado_x_Proyeccion_Gastos_Personales
AS
SELECT        dbo.ro_empleado_proyeccion_gastos.IdEmpresa,dbo.ro_empleado_proyeccion_gastos.IdTransaccion, dbo.ro_empleado_proyeccion_gastos.IdEmpleado, dbo.ro_empleado_proyeccion_gastos.AnioFiscal, dbo.tb_persona.pe_cedulaRuc, dbo.tb_persona.pe_nombreCompleto, dbo.ro_empleado_proyeccion_gastos.estado
FROM            dbo.ro_empleado INNER JOIN
                         dbo.tb_persona ON dbo.ro_empleado.IdPersona = dbo.tb_persona.IdPersona INNER JOIN
                         dbo.ro_empleado_proyeccion_gastos ON dbo.ro_empleado.IdEmpresa = dbo.ro_empleado_proyeccion_gastos.IdEmpresa AND dbo.ro_empleado.IdEmpleado = dbo.ro_empleado_proyeccion_gastos.IdEmpleado
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 1, @level0type = N'SCHEMA', @level0name = N'web', @level1type = N'VIEW', @level1name = N'vwro_empleado_x_Proyeccion_Gastos_Personales';


