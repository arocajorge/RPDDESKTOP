CREATE VIEW dbo.vw_Aca_Rubro_x_Periodo_x_Rubro_x_Fa_Descuento
AS
SELECT rubper.IdInstitucion_per, rubper.IdAnioLectivo, rubper.IdInstitucion_rub, rubper.IdPeriodo, rubper.IdRubro, rubper.Valor AS ValorRubro, rubper.Valor * dbo.fa_descuento.de_porcentaje / 100 AS Valor_Descuento, 
                  rubdesc.IdEmpresa_fadesc, rubdesc.IdDescuento, dbo.fa_descuento.de_porcentaje, rubdesc.Estado AS estado_rubro_x_fa_descuento, (CASE WHEN rubdesc.IdDescuento IS NULL THEN 0 ELSE 1 END) 
                  AS tiene_descuento
FROM     dbo.Aca_Rubro_x_Aca_Periodo_Lectivo AS rubper LEFT OUTER JOIN
                  dbo.fa_descuento INNER JOIN
                      (SELECT IdInstitucion_rub, IdRubro, IdEmpresa_fadesc, IdDescuento, Estado
                       FROM      dbo.Aca_Rubro_x_fa_descuento
                       GROUP BY IdInstitucion_rub, IdRubro, IdEmpresa_fadesc, IdDescuento, Estado) AS rubdesc ON dbo.fa_descuento.IdDescuento = rubdesc.IdDescuento AND 
                  dbo.fa_descuento.IdEmpresa = rubdesc.IdEmpresa_fadesc ON rubper.IdInstitucion_rub = rubdesc.IdInstitucion_rub AND rubper.IdRubro = rubdesc.IdRubro
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 1, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vw_Aca_Rubro_x_Periodo_x_Rubro_x_Fa_Descuento';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[24] 4[31] 2[13] 3) )"
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
         Begin Table = "rubper"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 267
               Right = 292
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "fa_descuento"
            Begin Extent = 
               Top = 4
               Left = 1375
               Bottom = 167
               Right = 1619
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "rubdesc"
            Begin Extent = 
               Top = 0
               Left = 582
               Bottom = 163
               Right = 826
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
      Begin ColumnWidths = 15
         Width = 284
         Width = 1596
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1812
         Width = 2376
         Width = 1200
         Width = 1200
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vw_Aca_Rubro_x_Periodo_x_Rubro_x_Fa_Descuento';

