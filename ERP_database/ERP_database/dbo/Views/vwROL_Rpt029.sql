﻿CREATE VIEW dbo.vwROL_Rpt029
AS
SELECT        dbo.ro_empleado_x_ro_tipoNomina.IdEmpresa, dbo.ro_empleado_x_ro_tipoNomina.IdEmpleado, dbo.ro_empleado_x_ro_tipoNomina.IdTipoNomina, dbo.tb_persona.pe_cedulaRuc, 
                         dbo.tb_persona.pe_apellido + ' ' + dbo.tb_persona.pe_nombre AS Empleado, dbo.ro_empleado.em_fecha_ingreso,CAST( dbo.ro_empleado.em_fechaSalida as date)em_fechaSalida, dbo.ro_cargo.ca_descripcion, 
                         dbo.ro_catalogo.ca_descripcion AS EstadoEmpleado,  dbo.ro_empleado.IdDivision, dbo.ro_empleado.em_fechaIngaRol, cast(CASE WHEN IIF(em_fechaSalida = NULL, 
                         datediff(dayofyear, em_fechaSalida, em_fechaIngaRol), datediff(dayofyear, em_fechaIngaRol, getdate())) >= 360 THEN IIF(em_fechaSalida = NULL, datediff(dayofyear, em_fechaSalida, em_fechaIngaRol), datediff(dayofyear, 
                         em_fechaIngaRol, getdate())) / 360 ELSE 0 END AS varchar(20)) + ' año(s), ' + cast(CASE WHEN IIF(em_fechaSalida = NULL, datediff(dayofyear, em_fechaSalida, em_fechaIngaRol), datediff(dayofyear, em_fechaIngaRol, getdate()))
                          >= 30 THEN (IIF(em_fechaSalida = NULL, datediff(dayofyear, em_fechaSalida, em_fechaIngaRol), datediff(dayofyear, em_fechaIngaRol, getdate())) / 30) - (CASE WHEN IIF(em_fechaSalida = NULL, datediff(dayofyear, 
                         em_fechaSalida, em_fechaIngaRol), datediff(dayofyear, em_fechaIngaRol, getdate())) >= 360 THEN IIF(em_fechaSalida = NULL, datediff(dayofyear, em_fechaSalida, em_fechaIngaRol), datediff(dayofyear, em_fechaIngaRol, 
                         getdate())) / 360 ELSE 0 END * 12) ELSE 0 END AS varchar(20)) + ' mes(es)' AS antiguedad_string
FROM            dbo.ro_catalogo INNER JOIN
                         dbo.tb_persona INNER JOIN
                         dbo.ro_empleado ON dbo.tb_persona.IdPersona = dbo.ro_empleado.IdPersona INNER JOIN
                         dbo.ro_empleado_x_ro_tipoNomina ON dbo.ro_empleado.IdEmpresa = dbo.ro_empleado_x_ro_tipoNomina.IdEmpresa AND dbo.ro_empleado.IdEmpleado = dbo.ro_empleado_x_ro_tipoNomina.IdEmpleado INNER JOIN
                         dbo.ro_cargo ON dbo.ro_empleado.IdEmpresa = dbo.ro_cargo.IdEmpresa AND dbo.ro_empleado.IdCargo = dbo.ro_cargo.IdCargo ON dbo.ro_catalogo.CodCatalogo = dbo.ro_empleado.em_status
WHERE        (dbo.ro_empleado.em_estado = 'A')

GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[41] 4[2] 2[39] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwROL_Rpt029';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 1, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwROL_Rpt029';

