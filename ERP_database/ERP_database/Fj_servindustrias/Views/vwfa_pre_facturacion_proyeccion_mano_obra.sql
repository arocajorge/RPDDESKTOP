CREATE VIEW [Fj_servindustrias].[vwfa_pre_facturacion_proyeccion_mano_obra]
AS
SELECT  ISNULL(ROW_NUMBER() over(order by cargo.IdEmpresa),0) AS IdRow, ISNULL(cargo.IdEmpresa,0) AS IdEmpresa, proye_mo.IdPrefacturacion, proye_mo.IdPeriodo, ISNULL(proye_mo.IdCargo, cargo.IdCargo) AS IdCargo, ISNULL(proye_mo.IdCentroCosto, fuerza.IdCentroCosto) 
                  AS IdCentroCosto, ISNULL(proye_mo.IdSubcentroCosto, fuerza.IdSuccentroCosto) AS IdSubcentroCosto, proye_mo.valor_proyectado, proye_mo.ValorRealManoObra, proye_mo.DiferenciaManoObra, fuerza.fu_descripcion, 
                  CASE WHEN cargo.IdCargo != 34 THEN cargo.ca_descripcion ELSE 'Administracion' END AS ca_descripcion, proye_mo.ValorModificadoManoObra
FROM     dbo.ro_cargo AS cargo INNER JOIN
                  Fj_servindustrias.fa_pre_facturacion_proyeccion_mano_obra AS proye_mo ON cargo.IdEmpresa = proye_mo.IdEmpresa AND cargo.IdCargo = proye_mo.IdCargo AND cargo.IdEmpresa = proye_mo.IdEmpresa AND 
                  cargo.IdCargo = proye_mo.IdCargo AND cargo.IdEmpresa = proye_mo.IdEmpresa AND cargo.IdCargo = proye_mo.IdCargo INNER JOIN
                  dbo.ct_centro_costo_sub_centro_costo ON proye_mo.IdEmpresa = dbo.ct_centro_costo_sub_centro_costo.IdEmpresa AND proye_mo.IdCentroCosto = dbo.ct_centro_costo_sub_centro_costo.IdCentroCosto AND 
                  proye_mo.IdSubcentroCosto = dbo.ct_centro_costo_sub_centro_costo.IdCentroCosto_sub_centro_costo INNER JOIN
                  Fj_servindustrias.ro_fuerza AS fuerza ON dbo.ct_centro_costo_sub_centro_costo.IdEmpresa = fuerza.IdEmpresa AND dbo.ct_centro_costo_sub_centro_costo.IdCentroCosto = fuerza.IdCentroCosto AND 
                  dbo.ct_centro_costo_sub_centro_costo.IdCentroCosto_sub_centro_costo = fuerza.IdSuccentroCosto
WHERE  (cargo.IdEmpresa = 2) AND (fuerza.IdFuerza <> 0) AND (cargo.IdCargo = 41 OR
                  cargo.IdCargo = 42 OR
                  cargo.IdCargo = 34)
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[52] 4[5] 2[28] 3) )"
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
         Begin Table = "cargo"
            Begin Extent = 
               Top = 29
               Left = 31
               Bottom = 159
               Right = 212
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "fuerza"
            Begin Extent = 
               Top = 112
               Left = 922
               Bottom = 242
               Right = 1111
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "proye_mo"
            Begin Extent = 
               Top = 0
               Left = 300
               Bottom = 298
               Right = 534
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ct_centro_costo_sub_centro_costo"
            Begin Extent = 
               Top = 22
               Left = 562
               Bottom = 152
               Right = 825
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
      Begin ColumnWidths = 13
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
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
     ', @level0type = N'SCHEMA', @level0name = N'Fj_servindustrias', @level1type = N'VIEW', @level1name = N'vwfa_pre_facturacion_proyeccion_mano_obra';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'    GroupBy = 1350
         Filter = 3285
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
', @level0type = N'SCHEMA', @level0name = N'Fj_servindustrias', @level1type = N'VIEW', @level1name = N'vwfa_pre_facturacion_proyeccion_mano_obra';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'Fj_servindustrias', @level1type = N'VIEW', @level1name = N'vwfa_pre_facturacion_proyeccion_mano_obra';

