﻿CREATE VIEW dbo.vwcaj_Caja_Movimiento_Tipo
AS
SELECT dbo.caj_Caja_Movimiento_Tipo.IdEmpresa, dbo.caj_Caja_Movimiento_Tipo.IdTipoMovi, dbo.caj_Caja_Movimiento_Tipo.tm_descripcion, dbo.caj_Caja_Movimiento_Tipo.Estado, dbo.caj_Caja_Movimiento_Tipo.tm_Signo, 
                  dbo.caj_Caja_Movimiento_Tipo.SeDeposita, dbo.caj_Caja_Movimiento_Tipo_x_CtaCble.IdCtaCble, dbo.ct_plancta.pc_Cuenta, dbo.ct_plancta.pc_clave_corta, dbo.caj_Caja_Movimiento_Tipo.IdTipoMovi_grupo
FROM     dbo.ct_plancta INNER JOIN
                  dbo.caj_Caja_Movimiento_Tipo_x_CtaCble ON dbo.ct_plancta.IdEmpresa = dbo.caj_Caja_Movimiento_Tipo_x_CtaCble.IdEmpresa AND dbo.ct_plancta.IdCtaCble = dbo.caj_Caja_Movimiento_Tipo_x_CtaCble.IdCtaCble RIGHT OUTER JOIN
                  dbo.caj_Caja_Movimiento_Tipo ON dbo.caj_Caja_Movimiento_Tipo_x_CtaCble.IdTipoMovi = dbo.caj_Caja_Movimiento_Tipo.IdTipoMovi AND dbo.caj_Caja_Movimiento_Tipo_x_CtaCble.IdEmpresa = dbo.caj_Caja_Movimiento_Tipo.IdEmpresa
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
         Top = -240
         Left = 0
      End
      Begin Tables = 
         Begin Table = "ct_plancta"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 170
               Right = 274
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "caj_Caja_Movimiento_Tipo_x_CtaCble"
            Begin Extent = 
               Top = 22
               Left = 506
               Bottom = 163
               Right = 700
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "caj_Caja_Movimiento_Tipo"
            Begin Extent = 
               Top = 322
               Left = 48
               Bottom = 485
               Right = 265
            End
            DisplayFlags = 280
            TopColumn = 12
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwcaj_Caja_Movimiento_Tipo';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 1, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwcaj_Caja_Movimiento_Tipo';

