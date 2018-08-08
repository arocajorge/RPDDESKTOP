CREATE VIEW [dbo].[vwfa_proforma_det_por_facturar]
AS
SELECT        dbo.fa_proforma_det.IdEmpresa, dbo.fa_proforma_det.IdSucursal, dbo.fa_proforma_det.IdProforma, dbo.fa_proforma_det.Secuencia, dbo.fa_proforma_det.IdProducto, dbo.fa_proforma_det.pd_cantidad, 
                         dbo.fa_proforma_det.pd_precio, dbo.fa_proforma_det.pd_por_descuento_uni, dbo.fa_proforma_det.pd_descuento_uni, dbo.fa_proforma_det.pd_precio_final, dbo.fa_proforma_det.pd_subtotal, 
                         dbo.fa_proforma_det.IdCod_Impuesto, dbo.fa_proforma_det.pd_por_iva, dbo.fa_proforma_det.pd_iva, dbo.fa_proforma_det.pd_total, dbo.fa_proforma_det.anulado, dbo.in_Producto.pr_descripcion, 
                         dbo.in_presentacion.nom_presentacion, dbo.in_Producto.lote_num_lote, dbo.in_Producto.lote_fecha_vcto, dbo.fa_proforma.IdCliente
FROM            dbo.fa_proforma INNER JOIN
                         dbo.fa_proforma_det ON dbo.fa_proforma.IdEmpresa = dbo.fa_proforma_det.IdEmpresa AND dbo.fa_proforma.IdSucursal = dbo.fa_proforma_det.IdSucursal AND 
                         dbo.fa_proforma.IdProforma = dbo.fa_proforma_det.IdProforma LEFT OUTER JOIN
                         dbo.in_presentacion INNER JOIN
                         dbo.in_Producto ON dbo.in_presentacion.IdEmpresa = dbo.in_Producto.IdEmpresa AND dbo.in_presentacion.IdPresentacion = dbo.in_Producto.IdPresentacion ON 
                         dbo.fa_proforma_det.IdEmpresa = dbo.in_Producto.IdEmpresa AND dbo.fa_proforma_det.IdProducto = dbo.in_Producto.IdProducto
WHERE NOT EXISTS(
select f.IdEmpresa from fa_factura_det as f
where dbo.fa_proforma_det.IdEmpresa = f.IdEmpresa_pf
and dbo.fa_proforma_det.IdSucursal = f.IdSucursal_pf
and dbo.fa_proforma_det.IdProforma = f.IdProforma
and dbo.fa_proforma_det.Secuencia = f.Secuencia_pf
)
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[26] 4[36] 2[20] 3) )"
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
         Begin Table = "pro"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 170
               Right = 306
            End
            DisplayFlags = 280
            TopColumn = 10
         End
         Begin Table = "fa_proforma"
            Begin Extent = 
               Top = 18
               Left = 659
               Bottom = 181
               Right = 926
            End
            DisplayFlags = 280
            TopColumn = 15
         End
         Begin Table = "fac"
            Begin Extent = 
               Top = 343
               Left = 48
               Bottom = 506
               Right = 373
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
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 12
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwfa_proforma_det_por_facturar';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 1, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwfa_proforma_det_por_facturar';

