CREATE VIEW dbo.vwRo_Permiso_x_Empleado
AS
SELECT        A.IdEmpresa, A.IdPermiso, A.Fecha, A.IdEmpleado, A.MotivoAusencia, A.FormaRecuperacion, A.IdEmpleado_Soli, A.IdEstadoAprob, A.IdEmpleado_Apro, 
                         A.MotivoAproba, A.Observacion, A.Estado, d.pe_nombreCompleto AS NomEmpleado, dbo.tb_persona.pe_nombreCompleto AS NomEmpleado_Aprobo, 
                         A.IdTipoLicencia, A.EsLicencia, A.EsPermiso, A.FechaSalida, A.FechaEntrada, A.TiempoAusencia, A.HoraRegreso, A.HoraSalida, 
                         A.MotivoAnulacion, dbo.tb_persona.pe_cedulaRuc, dbo.ro_cargo.ca_descripcion, dbo.ro_Departamento.de_descripcion, dbo.tb_persona.pe_apellido, 
                         dbo.tb_persona.pe_nombre, c.em_codigo, A.Id_Forma_descuento_permiso_Cat, A.Dias_tomados, A.IdNomina_Tipo, A.IdNovedad
FROM            dbo.tb_persona INNER JOIN
                         dbo.ro_empleado AS B ON dbo.tb_persona.IdPersona = B.IdPersona INNER JOIN
                         dbo.ro_Departamento ON B.IdEmpresa = dbo.ro_Departamento.IdEmpresa AND B.IdDepartamento = dbo.ro_Departamento.IdDepartamento INNER JOIN
                         dbo.ro_cargo ON B.IdCargo = dbo.ro_cargo.IdCargo AND B.IdEmpresa = dbo.ro_cargo.IdEmpresa RIGHT OUTER JOIN
                         dbo.ro_permiso_x_empleado AS A INNER JOIN
                         dbo.ro_empleado AS c INNER JOIN
                         dbo.tb_persona AS d ON c.IdPersona = d.IdPersona ON A.IdEmpleado = c.IdEmpleado AND A.IdEmpresa = c.IdEmpresa ON B.IdEmpleado = A.IdEmpleado AND 
                         B.IdEmpresa = A.IdEmpresa