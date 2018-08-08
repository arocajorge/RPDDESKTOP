CREATE VIEW web.VWINV_004
AS
SELECT dbo.in_Ing_Egr_Inven_det.IdEmpresa, dbo.in_Ing_Egr_Inven_det.IdSucursal, dbo.in_Ing_Egr_Inven_det.IdMovi_inven_tipo, dbo.in_Ing_Egr_Inven_det.IdNumMovi, dbo.in_Ing_Egr_Inven_det.Secuencia, 
                  dbo.in_movi_inve_detalle.mv_tipo_movi, dbo.in_movi_inven_tipo.tm_descripcion, dbo.in_Ing_Egr_Inven_det.IdProducto, dbo.in_Producto.pr_codigo, dbo.in_Producto.pr_descripcion, dbo.in_presentacion.nom_presentacion, 
                  dbo.in_Producto.lote_fecha_vcto, dbo.in_Producto.lote_num_lote, dbo.in_movi_inve.cm_fecha, dbo.in_movi_inve.cm_observacion, dbo.tb_sucursal.Su_Descripcion, dbo.tb_bodega.bo_Descripcion, dbo.in_movi_inve_detalle.dm_cantidad, 
                  dbo.in_movi_inve_detalle.mv_costo, dbo.in_movi_inve_detalle.IdUnidadMedida, dbo.in_UnidadMedida.Descripcion, dbo.in_Producto.IdCategoria, dbo.in_Producto.IdLinea, dbo.in_Producto.IdGrupo, dbo.in_Producto.IdSubGrupo, 
                  YEAR(dbo.in_movi_inve.cm_fecha) AS anio, MONTH(dbo.in_movi_inve.cm_fecha) AS mes, dbo.in_Producto.IdProducto_padre, in_Producto_padre.pr_descripcion AS pr_descripcion_padre, dbo.in_Ing_Egr_Inven_det.IdBodega
FROM     dbo.in_Ing_Egr_Inven_det INNER JOIN
                  dbo.in_movi_inve_detalle ON dbo.in_Ing_Egr_Inven_det.IdEmpresa_inv = dbo.in_movi_inve_detalle.IdEmpresa AND dbo.in_Ing_Egr_Inven_det.IdSucursal_inv = dbo.in_movi_inve_detalle.IdSucursal AND 
                  dbo.in_Ing_Egr_Inven_det.IdBodega_inv = dbo.in_movi_inve_detalle.IdBodega AND dbo.in_Ing_Egr_Inven_det.IdMovi_inven_tipo_inv = dbo.in_movi_inve_detalle.IdMovi_inven_tipo AND 
                  dbo.in_Ing_Egr_Inven_det.IdNumMovi_inv = dbo.in_movi_inve_detalle.IdNumMovi AND dbo.in_Ing_Egr_Inven_det.secuencia_inv = dbo.in_movi_inve_detalle.Secuencia INNER JOIN
                  dbo.in_movi_inve ON dbo.in_movi_inve_detalle.IdEmpresa = dbo.in_movi_inve.IdEmpresa AND dbo.in_movi_inve_detalle.IdSucursal = dbo.in_movi_inve.IdSucursal AND dbo.in_movi_inve_detalle.IdBodega = dbo.in_movi_inve.IdBodega AND 
                  dbo.in_movi_inve_detalle.IdMovi_inven_tipo = dbo.in_movi_inve.IdMovi_inven_tipo AND dbo.in_movi_inve_detalle.IdNumMovi = dbo.in_movi_inve.IdNumMovi INNER JOIN
                  dbo.in_Producto ON dbo.in_movi_inve_detalle.IdEmpresa = dbo.in_Producto.IdEmpresa AND dbo.in_movi_inve_detalle.IdProducto = dbo.in_Producto.IdProducto INNER JOIN
                  dbo.tb_bodega ON dbo.in_Ing_Egr_Inven_det.IdEmpresa = dbo.tb_bodega.IdEmpresa AND dbo.in_Ing_Egr_Inven_det.IdSucursal = dbo.tb_bodega.IdSucursal AND 
                  dbo.in_Ing_Egr_Inven_det.IdBodega = dbo.tb_bodega.IdBodega INNER JOIN
                  dbo.tb_sucursal ON dbo.in_Ing_Egr_Inven_det.IdEmpresa = dbo.tb_sucursal.IdEmpresa AND dbo.in_Ing_Egr_Inven_det.IdSucursal = dbo.tb_sucursal.IdSucursal INNER JOIN
                  dbo.in_movi_inven_tipo ON dbo.in_Ing_Egr_Inven_det.IdEmpresa = dbo.in_movi_inven_tipo.IdEmpresa AND dbo.in_Ing_Egr_Inven_det.IdMovi_inven_tipo = dbo.in_movi_inven_tipo.IdMovi_inven_tipo INNER JOIN
                  dbo.in_presentacion ON dbo.in_Producto.IdEmpresa = dbo.in_presentacion.IdEmpresa AND dbo.in_Producto.IdPresentacion = dbo.in_presentacion.IdPresentacion INNER JOIN
                  dbo.in_UnidadMedida ON dbo.in_movi_inve_detalle.IdUnidadMedida = dbo.in_UnidadMedida.IdUnidadMedida LEFT OUTER JOIN
                  dbo.in_Producto AS in_Producto_padre ON dbo.in_Producto.IdProducto_padre = in_Producto_padre.IdProducto AND dbo.in_Producto.IdEmpresa = in_Producto_padre.IdEmpresa

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
         Begin Table = "in_Ing_Egr_Inven_det"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 170
               Right = 357
            End
            DisplayFlags = 280
            TopColumn = 5
         End
         Begin Table = "in_movi_inve_detalle"
            Begin Extent = 
               Top = 175
               Left = 48
               Bottom = 338
               Right = 357
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "in_movi_inve"
            Begin Extent = 
               Top = 343
               Left = 48
               Bottom = 506
               Right = 357
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "in_Producto"
            Begin Extent = 
               Top = 511
               Left = 48
               Bottom = 674
               Right = 323
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tb_bodega"
            Begin Extent = 
               Top = 679
               Left = 48
               Bottom = 842
               Right = 360
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tb_sucursal"
            Begin Extent = 
               Top = 847
               Left = 48
               Bottom = 1010
               Right = 320
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "in_movi_inven_tipo"
            Begin Extent = 
               Top = 1015
               Left = 48
               Bottom = 1178
               Right = ', @level0type = N'SCHEMA', @level0name = N'web', @level1type = N'VIEW', @level1name = N'VWINV_004';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'303
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "in_presentacion"
            Begin Extent = 
               Top = 1183
               Left = 48
               Bottom = 1346
               Right = 264
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "in_UnidadMedida"
            Begin Extent = 
               Top = 1351
               Left = 48
               Bottom = 1514
               Right = 256
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "in_Producto_padre"
            Begin Extent = 
               Top = 1519
               Left = 48
               Bottom = 1682
               Right = 323
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
', @level0type = N'SCHEMA', @level0name = N'web', @level1type = N'VIEW', @level1name = N'VWINV_004';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'web', @level1type = N'VIEW', @level1name = N'VWINV_004';

