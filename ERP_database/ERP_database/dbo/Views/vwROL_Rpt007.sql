CREATE VIEW dbo.vwROL_Rpt007
AS
SELECT        dbo.ro_Acta_Finiquito.IdEmpresa, dbo.ro_Acta_Finiquito.IdActaFiniquito, dbo.ro_Acta_Finiquito.IdEmpleado, dbo.ro_Acta_Finiquito.IdCausaTerminacion, dbo.ro_Acta_Finiquito.IdContrato, dbo.ro_Acta_Finiquito.FechaIngreso, 
                         dbo.ro_Acta_Finiquito.FechaSalida, dbo.ro_Acta_Finiquito.UltimaRemuneracion, dbo.ro_Acta_Finiquito.Observacion, dbo.ro_Acta_Finiquito.Ingresos, dbo.ro_Acta_Finiquito.Egresos, dbo.ro_Acta_Finiquito.EsMujerEmbarazada, 
                         dbo.ro_Acta_Finiquito.EsDirigenteSindical, dbo.ro_Acta_Finiquito.EsPorDiscapacidad, dbo.ro_Acta_Finiquito.EsPorEnfermedadNoProfesional, dbo.vwro_empleadoXdepXcargo.pe_cedulaRuc, 
                         dbo.vwro_empleadoXdepXcargo.NomCompleto, dbo.ro_Acta_Finiquito_Detalle.IdSecuencia, dbo.ro_Acta_Finiquito_Detalle.Observacion AS DescripcionDetalle, 
                         dbo.ro_Acta_Finiquito_Detalle.Valor, dbo.ro_Acta_Finiquito.IdCargo, dbo.ro_contrato.NumDocumento, dbo.vwro_empleadoXdepXcargo.em_codigo AS CodigoEmpleado, 
                         dbo.vwro_empleadoXdepXcargo.cargo AS ca_descripcion
FROM            dbo.ro_Acta_Finiquito INNER JOIN
                         dbo.ro_Acta_Finiquito_Detalle ON dbo.ro_Acta_Finiquito.IdEmpresa = dbo.ro_Acta_Finiquito_Detalle.IdEmpresa AND dbo.ro_Acta_Finiquito.IdActaFiniquito = dbo.ro_Acta_Finiquito_Detalle.IdActaFiniquito AND 
                         dbo.ro_Acta_Finiquito.IdActaFiniquito = dbo.ro_Acta_Finiquito_Detalle.IdActaFiniquito INNER JOIN
                         dbo.vwro_empleadoXdepXcargo ON dbo.ro_Acta_Finiquito.IdEmpresa = dbo.vwro_empleadoXdepXcargo.IdEmpresa AND dbo.ro_Acta_Finiquito.IdEmpleado = dbo.vwro_empleadoXdepXcargo.IdEmpleado INNER JOIN
                         dbo.ro_contrato ON dbo.ro_Acta_Finiquito.IdEmpresa = dbo.ro_contrato.IdEmpresa AND dbo.ro_Acta_Finiquito.IdEmpleado = dbo.ro_contrato.IdEmpleado AND dbo.ro_Acta_Finiquito.IdContrato = dbo.ro_contrato.IdContrato
