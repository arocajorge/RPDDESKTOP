

CREATE  VIEW Fj_servindustrias.vwro_empleado_x_rutas_asignadas_Det as

SELECT        Fj_servindustrias.ro_empleado_x_rutas_asignadas_Det.IdEmpresa, Fj_servindustrias.ro_empleado_x_rutas_asignadas_Det.IdNomina_Tipo, 
                         Fj_servindustrias.ro_empleado_x_rutas_asignadas_Det.IdEmpleado, Fj_servindustrias.ro_empleado_x_rutas_asignadas_Det.IdRuta, Fj_servindustrias.ro_empleado_x_rutas_asignadas_Det.secuencia, 
                         Fj_servindustrias.ro_zona.zo_descripcion
FROM            Fj_servindustrias.ro_empleado_x_rutas_asignadas_Det INNER JOIN
                         Fj_servindustrias.ro_zona ON Fj_servindustrias.ro_empleado_x_rutas_asignadas_Det.IdEmpresa = Fj_servindustrias.ro_zona.IdEmpresa AND 
                         Fj_servindustrias.ro_empleado_x_rutas_asignadas_Det.IdRuta = Fj_servindustrias.ro_zona.IdZona