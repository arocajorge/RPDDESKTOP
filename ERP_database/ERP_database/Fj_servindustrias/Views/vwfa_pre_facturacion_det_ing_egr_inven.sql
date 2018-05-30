CREATE VIEW [Fj_servindustrias].[vwfa_pre_facturacion_det_ing_egr_inven]
AS
SELECT       ISNULL(ROW_NUMBER() OVER (ORDER BY Fj_servindustrias.fa_pre_facturacion_det_ing_egr_inven.IdEmpresa),0) AS IdRow,  Fj_servindustrias.fa_pre_facturacion_det_ing_egr_inven.IdEmpresa, Fj_servindustrias.fa_pre_facturacion_det_ing_egr_inven.IdPreFacturacion, Fj_servindustrias.fa_pre_facturacion_det_ing_egr_inven.Secuencia, 
                         Fj_servindustrias.fa_pre_facturacion_det_ing_egr_inven.eg_IdEmpresa, Fj_servindustrias.fa_pre_facturacion_det_ing_egr_inven.eg_IdSucursal, Fj_servindustrias.fa_pre_facturacion_det_ing_egr_inven.eg_IdMovi_inven_tipo, 
                         Fj_servindustrias.fa_pre_facturacion_det_ing_egr_inven.eg_IdNumMovi, Fj_servindustrias.fa_pre_facturacion_det_ing_egr_inven.eg_Secuencia, Fj_servindustrias.fa_pre_facturacion_det_ing_egr_inven.eg_cantidad, 
                         Fj_servindustrias.fa_pre_facturacion_det_ing_egr_inven.in_IdEmpresa, Fj_servindustrias.fa_pre_facturacion_det_ing_egr_inven.in_IdSucursal, Fj_servindustrias.fa_pre_facturacion_det_ing_egr_inven.in_IdMovi_inven_tipo, 
                         Fj_servindustrias.fa_pre_facturacion_det_ing_egr_inven.in_IdNumMovi, Fj_servindustrias.fa_pre_facturacion_det_ing_egr_inven.in_Secuencia, Fj_servindustrias.fa_pre_facturacion_det_ing_egr_inven.in_cantidad, 
                         Fj_servindustrias.fa_pre_facturacion_det_ing_egr_inven.IdProveedor, Fj_servindustrias.fa_pre_facturacion_det_ing_egr_inven.cp_fecha, Fj_servindustrias.fa_pre_facturacion_det_ing_egr_inven.cp_numero, 
                         Fj_servindustrias.fa_pre_facturacion_det_ing_egr_inven.IdActivoFijo, Fj_servindustrias.fa_pre_facturacion_det_ing_egr_inven.costo_uni, Fj_servindustrias.fa_pre_facturacion_det_ing_egr_inven.subtotal, 
                         Fj_servindustrias.fa_pre_facturacion_det_ing_egr_inven.IdProducto, Fj_servindustrias.Af_Activo_fijo_x_ct_punto_cargo.IdPunto_cargo_PC, Fj_servindustrias.fa_pre_facturacion_det_ing_egr_inven.IdCentroCosto, 
                         Fj_servindustrias.fa_pre_facturacion_det_ing_egr_inven.IdCentroCosto_sub_centro_costo, Fj_servindustrias.fa_pre_facturacion_det_ing_egr_inven.eg_fecha, 
                         Fj_servindustrias.fa_pre_facturacion_det_ing_egr_inven.eg_codigo
FROM            Fj_servindustrias.fa_pre_facturacion_det_ing_egr_inven INNER JOIN
                         Fj_servindustrias.Af_Activo_fijo_x_ct_punto_cargo ON Fj_servindustrias.fa_pre_facturacion_det_ing_egr_inven.IdActivoFijo = Fj_servindustrias.Af_Activo_fijo_x_ct_punto_cargo.IdActivoFijo_AF AND 
                         Fj_servindustrias.fa_pre_facturacion_det_ing_egr_inven.IdEmpresa = Fj_servindustrias.Af_Activo_fijo_x_ct_punto_cargo.IdEmpresa_AF
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 1, @level0type = N'SCHEMA', @level0name = N'Fj_servindustrias', @level1type = N'VIEW', @level1name = N'vwfa_pre_facturacion_det_ing_egr_inven';


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
         Begin Table = "fa_pre_facturacion_det_ing_egr_inven (Fj_servindustrias)"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 170
               Right = 357
            End
            DisplayFlags = 280
            TopColumn = 6
         End
         Begin Table = "Af_Activo_fijo_x_ct_punto_cargo (Fj_servindustrias)"
            Begin Extent = 
               Top = 0
               Left = 544
               Bottom = 163
               Right = 757
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
', @level0type = N'SCHEMA', @level0name = N'Fj_servindustrias', @level1type = N'VIEW', @level1name = N'vwfa_pre_facturacion_det_ing_egr_inven';



