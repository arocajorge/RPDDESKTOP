﻿CREATE VIEW web.VWCXP_001
AS
SELECT dbo.cp_orden_giro.IdEmpresa, dbo.cp_orden_giro.IdCbteCble_Ogiro, dbo.cp_orden_giro.IdTipoCbte_Ogiro, dbo.cp_TipoDocumento.Codigo, dbo.cp_TipoDocumento.Descripcion, dbo.cp_codigo_SRI.codigoSRI, 
                  dbo.cp_codigo_SRI.co_descripcion, dbo.tb_empresa.em_nombre, dbo.tb_sucursal.Su_Descripcion, per.pe_nombreCompleto AS pr_nombre, dbo.ct_centro_costo.Centro_costo AS nom_CentroCosto, dbo.cp_orden_giro.IdIden_credito, 
                  dbo.cp_orden_giro.IdOrden_giro_Tipo, dbo.cp_orden_giro.IdProveedor, dbo.ct_centro_costo_sub_centro_costo.Centro_costo AS nom_CentroCosto_sub_centro_costo, dbo.cp_orden_giro.co_fechaOg, dbo.cp_orden_giro.co_serie, 
                  dbo.cp_orden_giro.co_factura, dbo.cp_orden_giro.co_FechaFactura, dbo.cp_orden_giro.co_FechaFactura_vct, dbo.cp_orden_giro.co_observacion, dbo.cp_orden_giro.co_subtotal_iva, dbo.cp_orden_giro.co_subtotal_siniva, 
                  dbo.cp_orden_giro.co_baseImponible, dbo.cp_orden_giro.co_total, dbo.cp_orden_giro.co_valorpagar, dbo.ct_cbtecble_det.secuencia, dbo.ct_cbtecble_det.IdCtaCble, dbo.ct_plancta.pc_Cuenta, 
                  ISNULL(dbo.ct_cbtecble_det.IdCentroCosto, '') AS idCentroCosto, ISNULL(dbo.ct_cbtecble_det.IdCentroCosto_sub_centro_costo, '') AS idCentroCosto_sub_centro_costo, dbo.ct_cbtecble_det.dc_Valor, 
                  CASE WHEN dbo.ct_cbtecble_det.dc_Valor > 0 THEN dbo.ct_cbtecble_det.dc_Valor ELSE 0 END AS dc_Valor_Debe, CASE WHEN dbo.ct_cbtecble_det.dc_Valor < 0 THEN ABS(dbo.ct_cbtecble_det.dc_Valor) ELSE 0 END AS dc_Valor_Haber, 
                  dbo.ct_cbtecble_det.dc_Observacion, dbo.ct_punto_cargo.IdPunto_cargo, dbo.ct_punto_cargo.nom_punto_cargo, dbo.ct_punto_cargo_grupo.IdPunto_cargo_grupo, dbo.ct_punto_cargo_grupo.nom_punto_cargo_grupo
FROM     dbo.cp_orden_giro INNER JOIN
                  dbo.tb_sucursal ON dbo.cp_orden_giro.IdEmpresa = dbo.tb_sucursal.IdEmpresa AND dbo.cp_orden_giro.IdSucursal = dbo.tb_sucursal.IdSucursal INNER JOIN
                  dbo.tb_empresa ON dbo.tb_sucursal.IdEmpresa = dbo.tb_empresa.IdEmpresa INNER JOIN
                  dbo.cp_proveedor ON dbo.cp_orden_giro.IdEmpresa = dbo.cp_proveedor.IdEmpresa AND dbo.cp_orden_giro.IdProveedor = dbo.cp_proveedor.IdProveedor INNER JOIN
                  dbo.cp_TipoDocumento ON dbo.cp_orden_giro.IdOrden_giro_Tipo = dbo.cp_TipoDocumento.CodTipoDocumento INNER JOIN
                  dbo.ct_cbtecble_det ON dbo.cp_orden_giro.IdEmpresa = dbo.ct_cbtecble_det.IdEmpresa AND dbo.cp_orden_giro.IdTipoCbte_Ogiro = dbo.ct_cbtecble_det.IdTipoCbte AND 
                  dbo.cp_orden_giro.IdCbteCble_Ogiro = dbo.ct_cbtecble_det.IdCbteCble INNER JOIN
                  dbo.ct_plancta ON dbo.ct_cbtecble_det.IdEmpresa = dbo.ct_plancta.IdEmpresa AND dbo.ct_cbtecble_det.IdCtaCble = dbo.ct_plancta.IdCtaCble INNER JOIN
                  dbo.tb_persona AS per ON dbo.cp_proveedor.IdPersona = per.IdPersona LEFT OUTER JOIN
                  dbo.cp_codigo_SRI ON dbo.cp_orden_giro.IdIden_credito = dbo.cp_codigo_SRI.IdCodigo_SRI LEFT OUTER JOIN
                  dbo.ct_punto_cargo_grupo ON dbo.ct_cbtecble_det.IdEmpresa = dbo.ct_punto_cargo_grupo.IdEmpresa AND dbo.ct_cbtecble_det.IdPunto_cargo_grupo = dbo.ct_punto_cargo_grupo.IdPunto_cargo_grupo LEFT OUTER JOIN
                  dbo.ct_punto_cargo ON dbo.ct_cbtecble_det.IdEmpresa = dbo.ct_punto_cargo.IdEmpresa AND dbo.ct_cbtecble_det.IdPunto_cargo = dbo.ct_punto_cargo.IdPunto_cargo LEFT OUTER JOIN
                  dbo.ct_centro_costo ON dbo.ct_cbtecble_det.IdEmpresa = dbo.ct_centro_costo.IdEmpresa AND dbo.ct_cbtecble_det.IdCentroCosto = dbo.ct_centro_costo.IdCentroCosto LEFT OUTER JOIN
                  dbo.ct_centro_costo_sub_centro_costo ON dbo.ct_cbtecble_det.IdEmpresa = dbo.ct_centro_costo_sub_centro_costo.IdEmpresa AND dbo.ct_cbtecble_det.IdCentroCosto = dbo.ct_centro_costo_sub_centro_costo.IdCentroCosto AND 
                  dbo.ct_cbtecble_det.IdCentroCosto_sub_centro_costo = dbo.ct_centro_costo_sub_centro_costo.IdCentroCosto_sub_centro_costo

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
         Top = -360
         Left = 0
      End
      Begin Tables = 
         Begin Table = "cp_orden_giro"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 170
               Right = 355
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tb_sucursal"
            Begin Extent = 
               Top = 63
               Left = 694
               Bottom = 226
               Right = 966
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tb_empresa"
            Begin Extent = 
               Top = 343
               Left = 48
               Bottom = 506
               Right = 305
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "cp_proveedor"
            Begin Extent = 
               Top = 511
               Left = 48
               Bottom = 674
               Right = 322
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "cp_TipoDocumento"
            Begin Extent = 
               Top = 687
               Left = 513
               Bottom = 850
               Right = 831
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ct_cbtecble_det"
            Begin Extent = 
               Top = 847
               Left = 48
               Bottom = 1010
               Right = 357
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "cp_codigo_SRI"
            Begin Extent = 
               Top = 578
               Left = 896
               Bottom = 741
               Right = 1116
  ', @level0type = N'SCHEMA', @level0name = N'web', @level1type = N'VIEW', @level1name = N'VWCXP_001';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'          End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ct_plancta"
            Begin Extent = 
               Top = 1183
               Left = 48
               Bottom = 1346
               Right = 259
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ct_punto_cargo_grupo"
            Begin Extent = 
               Top = 1351
               Left = 48
               Bottom = 1514
               Right = 308
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ct_punto_cargo"
            Begin Extent = 
               Top = 1519
               Left = 48
               Bottom = 1682
               Right = 284
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ct_centro_costo"
            Begin Extent = 
               Top = 1687
               Left = 48
               Bottom = 1850
               Right = 276
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ct_centro_costo_sub_centro_costo"
            Begin Extent = 
               Top = 1855
               Left = 48
               Bottom = 2018
               Right = 357
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "per"
            Begin Extent = 
               Top = 2023
               Left = 48
               Bottom = 2186
               Right = 322
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
      Begin ColumnWidths = 40
         Width = 284
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
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
', @level0type = N'SCHEMA', @level0name = N'web', @level1type = N'VIEW', @level1name = N'VWCXP_001';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'web', @level1type = N'VIEW', @level1name = N'VWCXP_001';

