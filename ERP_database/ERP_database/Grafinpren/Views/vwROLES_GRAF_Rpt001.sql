CREATE VIEW Grafinpren.vwROLES_GRAF_Rpt001
AS
SELECT        dbo.ro_empleado.IdEmpresa, dbo.ro_empleado.IdEmpleado, dbo.ro_Historico_Liquidacion_Vacaciones.IdLiquidacion, dbo.ro_cargo.IdCargo, dbo.tb_persona.pe_cedulaRuc, 
                         dbo.tb_persona.pe_apellido + ' ' + dbo.tb_persona.pe_nombre AS Nombres
FROM            dbo.ro_empleado INNER JOIN
                         dbo.ro_Historico_Liquidacion_Vacaciones ON dbo.ro_empleado.IdEmpresa = dbo.ro_Historico_Liquidacion_Vacaciones.IdEmpresa AND 
                         dbo.ro_empleado.IdEmpleado = dbo.ro_Historico_Liquidacion_Vacaciones.IdEmpleado INNER JOIN
                         dbo.ro_Historico_Liquidacion_Vacaciones_Det ON dbo.ro_Historico_Liquidacion_Vacaciones.IdEmpresa = dbo.ro_Historico_Liquidacion_Vacaciones_Det.IdEmpresa AND 
                         dbo.ro_Historico_Liquidacion_Vacaciones.IdNomina_Tipo = dbo.ro_Historico_Liquidacion_Vacaciones_Det.IdNominatipo AND 
                         dbo.ro_Historico_Liquidacion_Vacaciones.IdLiquidacion = dbo.ro_Historico_Liquidacion_Vacaciones_Det.IdSolicitud_Vacaciones AND 
                         dbo.ro_Historico_Liquidacion_Vacaciones.IdEmpleado = dbo.ro_Historico_Liquidacion_Vacaciones_Det.IdEmpleado INNER JOIN
                         dbo.ro_Historico_Liquidacion_Vacaciones_Det_DescNovedad ON dbo.ro_Historico_Liquidacion_Vacaciones.IdEmpresa = dbo.ro_Historico_Liquidacion_Vacaciones_Det_DescNovedad.IdEmpresa AND 
                         dbo.ro_Historico_Liquidacion_Vacaciones.IdNomina_Tipo = dbo.ro_Historico_Liquidacion_Vacaciones_Det_DescNovedad.IdNomina_tipo AND 
                         dbo.ro_Historico_Liquidacion_Vacaciones.IdLiquidacion = dbo.ro_Historico_Liquidacion_Vacaciones_Det_DescNovedad.IdSolicitud_Vacaciones AND 
                         dbo.ro_Historico_Liquidacion_Vacaciones.IdEmpleado = dbo.ro_Historico_Liquidacion_Vacaciones_Det_DescNovedad.IdEmpleado INNER JOIN
                         dbo.ro_rubro_tipo ON dbo.ro_Historico_Liquidacion_Vacaciones_Det_DescNovedad.IdEmpresa = dbo.ro_rubro_tipo.IdEmpresa AND 
                         dbo.ro_Historico_Liquidacion_Vacaciones_Det_DescNovedad.IdRubro = dbo.ro_rubro_tipo.IdRubro INNER JOIN
                         dbo.ro_cargo ON dbo.ro_empleado.IdEmpresa = dbo.ro_cargo.IdEmpresa AND dbo.ro_empleado.IdCargo = dbo.ro_cargo.IdCargo INNER JOIN
                         dbo.tb_persona ON dbo.ro_empleado.IdPersona = dbo.tb_persona.IdPersona
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'Grafinpren', @level1type = N'VIEW', @level1name = N'vwROLES_GRAF_Rpt001';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'eft = 622
               Bottom = 450
               Right = 854
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
', @level0type = N'SCHEMA', @level0name = N'Grafinpren', @level1type = N'VIEW', @level1name = N'vwROLES_GRAF_Rpt001';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[73] 4[5] 2[16] 3) )"
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
         Begin Table = "ro_empleado"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 327
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ro_Historico_Liquidacion_Vacaciones"
            Begin Extent = 
               Top = 6
               Left = 365
               Bottom = 227
               Right = 574
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ro_Historico_Liquidacion_Vacaciones_Det"
            Begin Extent = 
               Top = 6
               Left = 612
               Bottom = 277
               Right = 821
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ro_Historico_Liquidacion_Vacaciones_Det_DescNovedad"
            Begin Extent = 
               Top = 138
               Left = 38
               Bottom = 408
               Right = 247
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ro_rubro_tipo"
            Begin Extent = 
               Top = 231
               Left = 289
               Bottom = 361
               Right = 542
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ro_cargo"
            Begin Extent = 
               Top = 237
               Left = 608
               Bottom = 367
               Right = 817
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tb_persona"
            Begin Extent = 
               Top = 141
               L', @level0type = N'SCHEMA', @level0name = N'Grafinpren', @level1type = N'VIEW', @level1name = N'vwROLES_GRAF_Rpt001';

