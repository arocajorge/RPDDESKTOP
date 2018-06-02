CREATE VIEW dbo.vwROL_Rpt001
AS
SELECT        dbo.vwro_empleadoXdepXcargo.IdEmpresa, dbo.vwro_empleadoXdepXcargo.IdEmpleado, dbo.vwro_empleadoXdepXcargo.NomCompleto AS NombreCompleto, dbo.vwro_empleadoXdepXcargo.pe_cedulaRuc AS CedulaRuc, 
                         dbo.vwro_empleadoXdepXcargo.cargo, dbo.vwro_empleadoXdepXcargo.departamento, dbo.vwro_empleadoXdepXcargo.CodigoSectorialIESS, dbo.vwro_empleadoXdepXcargo.em_status AS StatusEmpleado, 
                         dbo.vwro_empleadoXdepXcargo.IdDivision, dbo.vwro_empleadoXdepXcargo.IdSucursal, dbo.vwro_empleadoXdepXcargo.Sucursal, dbo.ro_Division.Descripcion AS Division, 
                         dbo.vwro_empleadoXdepXcargo.em_estado AS EstadoEmpleado, dbo.vwro_empleadoXdepXcargo.em_fecha_ingreso, dbo.vwro_empleadoXdepXcargo.em_fechaIngaRol, dbo.vwro_empleadoXdepXcargo.em_foto, 
                         dbo.vwro_empleadoXdepXcargo.es_AcreditaHorasExtras, dbo.vwro_empleadoXdepXcargo.por_discapacidad, dbo.vwro_empleadoXdepXcargo.carnet_conadis, dbo.vwro_empleadoXdepXcargo.pe_sexo, 
                         dbo.vwro_empleadoXdepXcargo.em_empEspecial, dbo.vwro_empleadoXdepXcargo.pe_direccion, dbo.vwro_empleadoXdepXcargo.pe_telefonoCasa, dbo.vwro_empleadoXdepXcargo.pe_celular, 
                         dbo.vwro_empleadoXdepXcargo.IdEstadoCivil, dbo.vwro_empleadoXdepXcargo.em_codigo AS CodigoEmpleado, dbo.vwro_empleadoXdepXcargo.Apellido, dbo.vwro_empleadoXdepXcargo.Nombre,
                             (SELECT        MAX(SueldoActual) AS Expr1
                               FROM            dbo.ro_empleado_historial_Sueldo
                               WHERE        (IdEmpresa = dbo.vwro_empleadoXdepXcargo.IdEmpresa) AND (IdEmpleado = dbo.vwro_empleadoXdepXcargo.IdEmpleado)) AS Sueldo_Actual, dbo.ro_empleado_x_ro_tipoNomina.IdTipoNomina, 
                         dbo.vwro_empleadoXdepXcargo.IdDepartamento, dbo.vwro_empleadoXdepXcargo.IdCargo, dbo.ro_catalogo.ca_descripcion
FROM            dbo.vwro_empleadoXdepXcargo INNER JOIN
                         dbo.ro_Division ON dbo.vwro_empleadoXdepXcargo.IdDivision = dbo.ro_Division.IdDivision AND dbo.vwro_empleadoXdepXcargo.IdEmpresa = dbo.ro_Division.IdEmpresa INNER JOIN
                         dbo.ro_empleado_x_ro_tipoNomina ON dbo.vwro_empleadoXdepXcargo.IdEmpresa = dbo.ro_empleado_x_ro_tipoNomina.IdEmpresa AND 
                         dbo.vwro_empleadoXdepXcargo.IdEmpleado = dbo.ro_empleado_x_ro_tipoNomina.IdEmpleado INNER JOIN
                         dbo.ro_catalogo ON dbo.vwro_empleadoXdepXcargo.em_status = dbo.ro_catalogo.CodCatalogo
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwROL_Rpt001';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N' = 1350
         Or = 1350
      End
   End
End
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwROL_Rpt001';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[67] 4[8] 2[8] 3) )"
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
         Begin Table = "vwro_empleadoXdepXcargo"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 353
               Right = 327
            End
            DisplayFlags = 280
            TopColumn = 65
         End
         Begin Table = "ro_Division"
            Begin Extent = 
               Top = 138
               Left = 38
               Bottom = 268
               Right = 217
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ro_empleado_x_ro_tipoNomina"
            Begin Extent = 
               Top = 38
               Left = 518
               Bottom = 267
               Right = 688
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ro_catalogo"
            Begin Extent = 
               Top = 6
               Left = 726
               Bottom = 136
               Right = 897
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
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
         Or', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwROL_Rpt001';

