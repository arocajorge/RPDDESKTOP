CREATE VIEW [Fj_servindustrias].[vwROLES_Rpt015]
	AS 

SELECT        Fj_servindustrias.ro_Remplazo_x_emplado.IdEmpresa, Fj_servindustrias.ro_Remplazo_x_emplado.IdEmpleado, Fj_servindustrias.ro_Remplazo_x_emplado.Id_remplazo, 
                         persona_remplazada.pe_cedulaRuc AS Cedula_empleado_Remplazado, persona_remplazada.pe_apellido + ' ' + persona_remplazada.pe_nombre AS empleado_remplazado, 
                         persona_remplaza.pe_cedulaRuc AS Cedula_remplazo, persona_remplaza.pe_apellido + ' ' + persona_remplaza.pe_nombre AS Remplazo, dbo.ro_cargo.ca_descripcion, 
                         Fj_servindustrias.ro_Remplazo_x_emplado.Valor_descuento_empleado, Fj_servindustrias.ro_Remplazo_x_emplado.Fecha_descuenta_rol, Fj_servindustrias.ro_Remplazo_x_emplado.valor_x_dia_remplazo, 
                         Fj_servindustrias.ro_Remplazo_x_emplado.Total_pagar_remplazo, Fj_servindustrias.ro_Remplazo_x_emplado.Descuenta_rol, Fj_servindustrias.ro_Remplazo_x_emplado.Fecha, 
                         Fj_servindustrias.ro_Remplazo_x_emplado.Fecha_Salida, Fj_servindustrias.ro_Remplazo_x_emplado.Fecha_Entrada, Fj_servindustrias.ro_Remplazo_x_emplado.Observacion, 
                         dbo.ro_catalogo.ca_descripcion AS MotivoAusencia, dbo.ro_Nomina_Tipoliqui.DescripcionProcesoNomina
FROM            dbo.ro_Nomina_Tipoliqui RIGHT OUTER JOIN
                         dbo.tb_persona AS persona_remplaza INNER JOIN
                         dbo.ro_empleado AS empleado_remplaza ON persona_remplaza.IdPersona = empleado_remplaza.IdPersona INNER JOIN
                         dbo.ro_empleado AS empleado_remplazado INNER JOIN
                         Fj_servindustrias.ro_Remplazo_x_emplado ON empleado_remplazado.IdEmpresa = Fj_servindustrias.ro_Remplazo_x_emplado.IdEmpresa AND 
                         empleado_remplazado.IdEmpleado = Fj_servindustrias.ro_Remplazo_x_emplado.IdEmpleado INNER JOIN
                         dbo.tb_persona AS persona_remplazada ON empleado_remplazado.IdPersona = persona_remplazada.IdPersona ON empleado_remplaza.IdEmpresa = Fj_servindustrias.ro_Remplazo_x_emplado.IdEmpresa AND 
                         empleado_remplaza.IdEmpleado = Fj_servindustrias.ro_Remplazo_x_emplado.IdEmpleado_Remplazo INNER JOIN
                         dbo.ro_cargo ON empleado_remplazado.IdEmpresa = dbo.ro_cargo.IdEmpresa AND empleado_remplazado.IdCargo = dbo.ro_cargo.IdCargo INNER JOIN
                         dbo.ro_catalogo ON Fj_servindustrias.ro_Remplazo_x_emplado.Id_Motivo_Ausencia_Cat = dbo.ro_catalogo.IdCatalogo ON dbo.ro_Nomina_Tipoliqui.IdEmpresa = Fj_servindustrias.ro_Remplazo_x_emplado.IdEmpresa AND 
                         dbo.ro_Nomina_Tipoliqui.IdNomina_Tipo = Fj_servindustrias.ro_Remplazo_x_emplado.IdNomina_Tipo AND dbo.ro_Nomina_Tipoliqui.IdNomina_TipoLiqui = Fj_servindustrias.ro_Remplazo_x_emplado.IdNomina_TipoLiqui
