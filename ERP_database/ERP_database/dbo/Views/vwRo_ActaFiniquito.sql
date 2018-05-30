
CREATE view [dbo].[vwRo_ActaFiniquito] as 

SELECT        dbo.tb_persona.pe_nombreCompleto AS NombreCompleto, dbo.tb_persona.pe_cedulaRuc AS Identificacion, dbo.tb_persona.IdTipoDocumento AS TipoIdentificacion, dbo.tb_persona.pe_fechaNacimiento AS FechaNcto, 
                         dbo.ro_Departamento.de_descripcion AS Departamento, dbo.ro_contrato.IdContrato_Tipo, dbo.ro_contrato.NumDocumento, dbo.ro_contrato.FechaInicio, dbo.ro_contrato.FechaFin, dbo.ro_contrato.Estado AS EstadoContrato, 
                         dbo.ro_contrato.Observacion AS ObservacionContrato, dbo.ro_Acta_Finiquito.IdEmpresa, dbo.ro_Acta_Finiquito.IdActaFiniquito, dbo.ro_Acta_Finiquito.IdEmpleado, dbo.ro_Acta_Finiquito.IdCausaTerminacion, 
                         dbo.ro_Acta_Finiquito.IdContrato, dbo.ro_Acta_Finiquito.IdCargo, dbo.ro_Acta_Finiquito.FechaIngreso, dbo.ro_Acta_Finiquito.FechaSalida, dbo.ro_Acta_Finiquito.UltimaRemuneracion, 
                         dbo.ro_Acta_Finiquito.Observacion AS ObservacionFiniquito, dbo.ro_Acta_Finiquito.Ingresos, dbo.ro_Acta_Finiquito.Egresos, dbo.ro_Acta_Finiquito.IdUsuario, dbo.ro_Acta_Finiquito.Fecha_Transac, 
                         dbo.ro_Acta_Finiquito.IdUsuarioUltMod, dbo.ro_Acta_Finiquito.Fecha_UltMod, dbo.ro_Acta_Finiquito.IdUsuarioUltAnu, dbo.ro_Acta_Finiquito.Fecha_UltAnu, dbo.ro_Acta_Finiquito.nom_pc, dbo.ro_Acta_Finiquito.ip, 
                         dbo.ro_Acta_Finiquito.Estado AS EstadoActa, dbo.ro_Acta_Finiquito.MotiAnula, dbo.ro_Acta_Finiquito.IdCodSectorial, dbo.ro_Acta_Finiquito.EsMujerEmbarazada, dbo.ro_Acta_Finiquito.EsDirigenteSindical, 
                         dbo.ro_Acta_Finiquito.EsPorDiscapacidad, dbo.ro_Acta_Finiquito.EsPorEnfermedadNoProfesional, dbo.tb_persona.pe_apellido, dbo.tb_persona.pe_nombre, dbo.ro_empleado.em_codigo
FROM            dbo.ro_Acta_Finiquito INNER JOIN
                         dbo.ro_empleado ON dbo.ro_Acta_Finiquito.IdEmpresa = dbo.ro_empleado.IdEmpresa AND dbo.ro_Acta_Finiquito.IdEmpleado = dbo.ro_empleado.IdEmpleado INNER JOIN
                         dbo.tb_persona ON dbo.ro_empleado.IdPersona = dbo.tb_persona.IdPersona INNER JOIN
                         dbo.ro_Departamento ON dbo.ro_empleado.IdEmpresa = dbo.ro_Departamento.IdEmpresa AND dbo.ro_empleado.IdDepartamento = dbo.ro_Departamento.IdDepartamento INNER JOIN
                         dbo.ro_contrato ON dbo.ro_Acta_Finiquito.IdEmpresa = dbo.ro_contrato.IdEmpresa AND dbo.ro_Acta_Finiquito.IdEmpleado = dbo.ro_contrato.IdEmpleado AND dbo.ro_Acta_Finiquito.IdContrato = dbo.ro_contrato.IdContrato