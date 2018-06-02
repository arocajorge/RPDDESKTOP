create view Fj_servindustrias.vwROLES_Rpt020 as 

SELECT        dbo.in_Ing_Egr_Inven_det.IdEmpresa, dbo.in_Ing_Egr_Inven_det.IdSucursal, dbo.in_Ing_Egr_Inven_det.IdMovi_inven_tipo, dbo.in_Ing_Egr_Inven_det.IdNumMovi, dbo.in_Ing_Egr_Inven_det.Secuencia, 
                         dbo.in_Ing_Egr_Inven_det.IdProducto, dbo.in_Producto.pr_codigo, dbo.in_Producto.pr_descripcion, ABS(dbo.in_Ing_Egr_Inven_det.dm_cantidad) AS dm_cantidad, Fj_servindustrias.in_Ing_Egr_Inven_fj.IdEmpleado, 
                         dbo.tb_persona.pe_nombreCompleto, dbo.tb_persona.pe_cedulaRuc, dbo.ct_centro_costo.IdCentroCosto, dbo.ct_centro_costo.Centro_costo AS nom_Centro_costo, 
                         dbo.ct_centro_costo_sub_centro_costo.IdCentroCosto_sub_centro_costo, dbo.ct_centro_costo_sub_centro_costo.Centro_costo AS nom_Centro_costo_sub_centro_costo, dbo.ct_punto_cargo.IdPunto_cargo, 
                         dbo.ct_punto_cargo.nom_punto_cargo, dbo.in_Ing_Egr_Inven.cm_observacion, dbo.in_Ing_Egr_Inven.cm_fecha, dbo.in_Ing_Egr_Inven.CodMoviInven, dbo.ro_cargo.ca_descripcion, dbo.ro_Departamento.de_descripcion, 
                         dbo.tb_persona.pe_apellido, dbo.tb_persona.pe_nombre
FROM            dbo.in_Ing_Egr_Inven INNER JOIN
                         Fj_servindustrias.in_Ing_Egr_Inven_fj ON dbo.in_Ing_Egr_Inven.IdEmpresa = Fj_servindustrias.in_Ing_Egr_Inven_fj.IdEmpresa AND dbo.in_Ing_Egr_Inven.IdSucursal = Fj_servindustrias.in_Ing_Egr_Inven_fj.IdSucursal AND 
                         dbo.in_Ing_Egr_Inven.IdMovi_inven_tipo = Fj_servindustrias.in_Ing_Egr_Inven_fj.IdMovi_inven_tipo AND dbo.in_Ing_Egr_Inven.IdNumMovi = Fj_servindustrias.in_Ing_Egr_Inven_fj.IdNumMovi INNER JOIN
                         dbo.in_Ing_Egr_Inven_det ON dbo.in_Ing_Egr_Inven.IdEmpresa = dbo.in_Ing_Egr_Inven_det.IdEmpresa AND dbo.in_Ing_Egr_Inven.IdSucursal = dbo.in_Ing_Egr_Inven_det.IdSucursal AND 
                         dbo.in_Ing_Egr_Inven.IdMovi_inven_tipo = dbo.in_Ing_Egr_Inven_det.IdMovi_inven_tipo AND dbo.in_Ing_Egr_Inven.IdNumMovi = dbo.in_Ing_Egr_Inven_det.IdNumMovi INNER JOIN
                         dbo.in_Producto ON dbo.in_Ing_Egr_Inven_det.IdEmpresa = dbo.in_Producto.IdEmpresa AND dbo.in_Ing_Egr_Inven_det.IdProducto = dbo.in_Producto.IdProducto AND 
                         dbo.in_Ing_Egr_Inven_det.IdEmpresa = dbo.in_Producto.IdEmpresa AND dbo.in_Ing_Egr_Inven_det.IdProducto = dbo.in_Producto.IdProducto INNER JOIN
                         dbo.ro_empleado ON Fj_servindustrias.in_Ing_Egr_Inven_fj.IdEmpresa = dbo.ro_empleado.IdEmpresa AND Fj_servindustrias.in_Ing_Egr_Inven_fj.IdEmpleado = dbo.ro_empleado.IdEmpleado AND 
                         Fj_servindustrias.in_Ing_Egr_Inven_fj.IdEmpresa = dbo.ro_empleado.IdEmpresa AND Fj_servindustrias.in_Ing_Egr_Inven_fj.IdEmpleado = dbo.ro_empleado.IdEmpleado AND 
                         Fj_servindustrias.in_Ing_Egr_Inven_fj.IdEmpresa = dbo.ro_empleado.IdEmpresa AND Fj_servindustrias.in_Ing_Egr_Inven_fj.IdEmpleado = dbo.ro_empleado.IdEmpleado AND 
                         Fj_servindustrias.in_Ing_Egr_Inven_fj.IdEmpresa = dbo.ro_empleado.IdEmpresa AND Fj_servindustrias.in_Ing_Egr_Inven_fj.IdEmpleado = dbo.ro_empleado.IdEmpleado AND 
                         Fj_servindustrias.in_Ing_Egr_Inven_fj.IdEmpresa = dbo.ro_empleado.IdEmpresa AND Fj_servindustrias.in_Ing_Egr_Inven_fj.IdEmpleado = dbo.ro_empleado.IdEmpleado AND 
                         Fj_servindustrias.in_Ing_Egr_Inven_fj.IdEmpresa = dbo.ro_empleado.IdEmpresa AND Fj_servindustrias.in_Ing_Egr_Inven_fj.IdEmpleado = dbo.ro_empleado.IdEmpleado INNER JOIN
                         dbo.tb_persona ON dbo.ro_empleado.IdPersona = dbo.tb_persona.IdPersona AND dbo.ro_empleado.IdPersona = dbo.tb_persona.IdPersona INNER JOIN
                         dbo.ro_cargo ON dbo.ro_empleado.IdEmpresa = dbo.ro_cargo.IdEmpresa AND dbo.ro_empleado.IdCargo = dbo.ro_cargo.IdCargo AND dbo.ro_empleado.IdEmpresa = dbo.ro_cargo.IdEmpresa AND 
                         dbo.ro_empleado.IdCargo = dbo.ro_cargo.IdCargo INNER JOIN
                         dbo.ro_Departamento ON dbo.ro_empleado.IdEmpresa = dbo.ro_Departamento.IdEmpresa AND dbo.ro_empleado.IdDepartamento = dbo.ro_Departamento.IdDepartamento AND 
                         dbo.ro_empleado.IdEmpresa = dbo.ro_Departamento.IdEmpresa AND dbo.ro_empleado.IdDepartamento = dbo.ro_Departamento.IdDepartamento AND dbo.ro_empleado.IdEmpresa = dbo.ro_Departamento.IdEmpresa AND 
                         dbo.ro_empleado.IdDepartamento = dbo.ro_Departamento.IdDepartamento LEFT OUTER JOIN
                         dbo.ct_punto_cargo ON dbo.in_Ing_Egr_Inven_det.IdEmpresa = dbo.ct_punto_cargo.IdEmpresa AND dbo.in_Ing_Egr_Inven_det.IdPunto_cargo = dbo.ct_punto_cargo.IdPunto_cargo AND 
                         dbo.in_Ing_Egr_Inven_det.IdEmpresa = dbo.ct_punto_cargo.IdEmpresa AND dbo.in_Ing_Egr_Inven_det.IdPunto_cargo = dbo.ct_punto_cargo.IdPunto_cargo LEFT OUTER JOIN
                         dbo.ct_centro_costo_sub_centro_costo ON dbo.in_Ing_Egr_Inven_det.IdEmpresa = dbo.ct_centro_costo_sub_centro_costo.IdEmpresa AND 
                         dbo.in_Ing_Egr_Inven_det.IdCentroCosto = dbo.ct_centro_costo_sub_centro_costo.IdCentroCosto AND 
                         dbo.in_Ing_Egr_Inven_det.IdCentroCosto_sub_centro_costo = dbo.ct_centro_costo_sub_centro_costo.IdCentroCosto_sub_centro_costo AND 
                         dbo.in_Ing_Egr_Inven_det.IdEmpresa = dbo.ct_centro_costo_sub_centro_costo.IdEmpresa AND dbo.in_Ing_Egr_Inven_det.IdCentroCosto = dbo.ct_centro_costo_sub_centro_costo.IdCentroCosto AND 
                         dbo.in_Ing_Egr_Inven_det.IdCentroCosto_sub_centro_costo = dbo.ct_centro_costo_sub_centro_costo.IdCentroCosto_sub_centro_costo LEFT OUTER JOIN
                         dbo.ct_centro_costo ON dbo.in_Ing_Egr_Inven_det.IdEmpresa = dbo.ct_centro_costo.IdEmpresa AND dbo.in_Ing_Egr_Inven_det.IdCentroCosto = dbo.ct_centro_costo.IdCentroCosto AND 
                         dbo.in_Ing_Egr_Inven_det.IdEmpresa = dbo.ct_centro_costo.IdEmpresa AND dbo.in_Ing_Egr_Inven_det.IdCentroCosto = dbo.ct_centro_costo.IdCentroCosto
