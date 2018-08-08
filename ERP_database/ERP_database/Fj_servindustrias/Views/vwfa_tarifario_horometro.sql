﻿CREATE VIEW Fj_servindustrias.vwfa_tarifario_horometro
AS
SELECT Fj_servindustrias.fa_tarifario_horometro.IdEmpresa, Fj_servindustrias.fa_tarifario_horometro.IdTarifario, Fj_servindustrias.fa_tarifario_horometro.IdCentroCosto, Fj_servindustrias.fa_tarifario_horometro.Observacion, 
                  Fj_servindustrias.fa_tarifario_horometro.estado, Fj_servindustrias.fa_tarifario_horometro.IdProducto_hora_regular, Fj_servindustrias.fa_tarifario_horometro.IdProducto_hora_extra, dbo.ct_centro_costo.Centro_costo, 
                  Fj_servindustrias.fa_tarifario_horometro.IdPeriodo_ini, Fj_servindustrias.fa_tarifario_horometro.IdPeriodo_fin, Fj_servindustrias.fa_tarifario_horometro.IdCod_Impuesto, Fj_servindustrias.fa_tarifario_horometro.porcentaje
FROM     Fj_servindustrias.fa_tarifario_horometro INNER JOIN
                  dbo.ct_centro_costo ON Fj_servindustrias.fa_tarifario_horometro.IdEmpresa = dbo.ct_centro_costo.IdEmpresa AND Fj_servindustrias.fa_tarifario_horometro.IdCentroCosto = dbo.ct_centro_costo.IdCentroCosto
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
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
         Begin Table = "fa_tarifario_horometro (Fj_servindustrias)"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 170
               Right = 305
            End
            DisplayFlags = 280
            TopColumn = 7
         End
         Begin Table = "ct_centro_costo"
            Begin Extent = 
               Top = 175
               Left = 48
               Bottom = 338
               Right = 276
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
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1176
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1356
         SortOrder = 1416
         GroupBy = 1350
         Filter = 1356
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
', @level0type = N'SCHEMA', @level0name = N'Fj_servindustrias', @level1type = N'VIEW', @level1name = N'vwfa_tarifario_horometro';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 1, @level0type = N'SCHEMA', @level0name = N'Fj_servindustrias', @level1type = N'VIEW', @level1name = N'vwfa_tarifario_horometro';

