CREATE VIEW [Fj_servindustrias].[vwROLES_Rpt021]
AS
SELECT        Fj_servindustrias.ro_descuento_no_planificados.IdEmpresa, Fj_servindustrias.ro_descuento_no_planificados.IdNomina_Tipo, Fj_servindustrias.ro_descuento_no_planificados.IdEmpleado, 
                         Fj_servindustrias.ro_descuento_no_planificados.IdDescuento, tb_persona.pe_apellido, tb_persona.pe_nombre, ro_cargo.ca_descripcion AS nom_cargo, ro_rubro_tipo.ru_descripcion AS nom_rubro, 
                         Fj_servindustrias.ro_descuento_no_planificados.Observacion, Fj_servindustrias.ro_descuento_no_planificados.Valor, Fj_servindustrias.ro_descuento_no_planificados.Fecha_Incidente, 
                         Fj_servindustrias.ro_descuento_no_planificados.Estado, tb_persona.pe_cedulaRuc, ro_Nomina_Tipo.Descripcion
FROM            Fj_servindustrias.ro_descuento_no_planificados INNER JOIN
                         ro_empleado ON Fj_servindustrias.ro_descuento_no_planificados.IdEmpresa = ro_empleado.IdEmpresa AND Fj_servindustrias.ro_descuento_no_planificados.IdEmpleado = ro_empleado.IdEmpleado INNER JOIN
                         ro_rubro_tipo ON Fj_servindustrias.ro_descuento_no_planificados.IdEmpresa = ro_rubro_tipo.IdEmpresa AND Fj_servindustrias.ro_descuento_no_planificados.IdRubro = ro_rubro_tipo.IdRubro INNER JOIN
                         tb_persona ON ro_empleado.IdPersona = tb_persona.IdPersona INNER JOIN
                         ro_cargo ON ro_empleado.IdEmpresa = ro_cargo.IdEmpresa AND ro_empleado.IdCargo = ro_cargo.IdCargo INNER JOIN
                         ro_empleado_x_ro_tipoNomina ON ro_empleado.IdEmpresa = ro_empleado_x_ro_tipoNomina.IdEmpresa AND ro_empleado.IdEmpleado = ro_empleado_x_ro_tipoNomina.IdEmpleado INNER JOIN
                         ro_Nomina_Tipo ON ro_empleado_x_ro_tipoNomina.IdEmpresa = ro_Nomina_Tipo.IdEmpresa AND ro_empleado_x_ro_tipoNomina.IdTipoNomina = ro_Nomina_Tipo.IdNomina_Tipo