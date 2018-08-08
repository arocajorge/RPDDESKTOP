CREATE VIEW dbo.vwRo_empleaco_x_activofijo_x_puntocargo
AS
SELECT        Fj_servindustrias.ro_empleado_x_Activo_Fijo.IdEmpresa, Fj_servindustrias.ro_empleado_x_Activo_Fijo.IdEmpleado, Fj_servindustrias.ro_empleado_x_Activo_Fijo.IdCentroCosto, 
                         Fj_servindustrias.ro_empleado_x_Activo_Fijo.IdCentroCosto_sub_centro_costo, Fj_servindustrias.Af_Activo_fijo_x_ct_punto_cargo.IdPunto_cargo_PC
FROM            Fj_servindustrias.ro_empleado_x_Activo_Fijo INNER JOIN
                         dbo.ct_centro_costo_sub_centro_costo ON Fj_servindustrias.ro_empleado_x_Activo_Fijo.IdEmpresa = dbo.ct_centro_costo_sub_centro_costo.IdEmpresa AND 
                         Fj_servindustrias.ro_empleado_x_Activo_Fijo.IdCentroCosto = dbo.ct_centro_costo_sub_centro_costo.IdCentroCosto AND 
                         Fj_servindustrias.ro_empleado_x_Activo_Fijo.IdCentroCosto_sub_centro_costo = dbo.ct_centro_costo_sub_centro_costo.IdCentroCosto_sub_centro_costo INNER JOIN
                         Fj_servindustrias.Af_Activo_fijo_x_ct_punto_cargo ON Fj_servindustrias.ro_empleado_x_Activo_Fijo.IdEmpresa = Fj_servindustrias.Af_Activo_fijo_x_ct_punto_cargo.IdEmpresa_AF AND 
                         Fj_servindustrias.ro_empleado_x_Activo_Fijo.IdActivo_fijo = Fj_servindustrias.Af_Activo_fijo_x_ct_punto_cargo.IdActivoFijo_AF
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[37] 4[5] 2[12] 3) )"
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
         Begin Table = "ro_empleado_x_Activo_Fijo (Fj_servindustrias)"
            Begin Extent = 
               Top = 0
               Left = 373
               Bottom = 283
               Right = 636
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ct_centro_costo_sub_centro_costo"
            Begin Extent = 
               Top = 7
               Left = 745
               Bottom = 229
               Right = 1008
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Af_Activo_fijo_x_ct_punto_cargo (Fj_servindustrias)"
            Begin Extent = 
               Top = 17
               Left = 117
               Bottom = 239
               Right = 303
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
         Or = 1350
         Or = 1350
      End
   End
End
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwRo_empleaco_x_activofijo_x_puntocargo';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 1, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwRo_empleaco_x_activofijo_x_puntocargo';

