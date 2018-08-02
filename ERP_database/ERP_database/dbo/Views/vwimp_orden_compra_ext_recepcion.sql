﻿CREATE VIEW dbo.vwimp_orden_compra_ext_recepcion
AS
SELECT        dbo.imp_orden_compra_ext_recepcion.IdRecepcion, dbo.imp_orden_compra_ext_recepcion.or_fecha, dbo.imp_orden_compra_ext_recepcion.or_observacion, dbo.imp_orden_compra_ext_recepcion.IdEmpresa_oc, 
                         dbo.imp_orden_compra_ext_recepcion.IdOrdenCompraExt, dbo.imp_orden_compra_ext_recepcion.estado, dbo.tb_persona.pe_nombreCompleto, dbo.tb_persona.pe_cedulaRuc, 
                         dbo.imp_orden_compra_ext_recepcion.IdEmpresa, dbo.imp_orden_compra_ext.IdCatalogo_via, dbo.imp_orden_compra_ext.IdCiudad_destino, dbo.imp_orden_compra_ext.IdCatalogo_forma_pago, 
                         dbo.imp_orden_compra_ext.oe_fecha, dbo.imp_orden_compra_ext.oe_fecha_llegada_est, dbo.imp_orden_compra_ext.oe_fecha_embarque_est, dbo.imp_orden_compra_ext.Estado_cierre, 
                         dbo.imp_orden_compra_ext.IdEmpresa_inv, dbo.imp_orden_compra_ext.IdSucursal_inv, dbo.imp_orden_compra_ext.IdMovi_inven_tipo_inv, dbo.imp_orden_compra_ext.IdNumMovi_inv, 
                         dbo.imp_orden_compra_ext.IdEmpresa_ct, dbo.imp_orden_compra_ext.IdTipoCbte_ct, dbo.imp_orden_compra_ext.IdCbteCble_ct, dbo.imp_orden_compra_ext.IdBodega_inv
FROM            dbo.imp_orden_compra_ext_recepcion INNER JOIN
                         dbo.imp_orden_compra_ext ON dbo.imp_orden_compra_ext_recepcion.IdEmpresa_oc = dbo.imp_orden_compra_ext.IdEmpresa AND 
                         dbo.imp_orden_compra_ext_recepcion.IdOrdenCompraExt = dbo.imp_orden_compra_ext.IdOrdenCompra_ext INNER JOIN
                         dbo.cp_proveedor ON dbo.imp_orden_compra_ext.IdEmpresa = dbo.cp_proveedor.IdEmpresa AND dbo.imp_orden_compra_ext.IdProveedor = dbo.cp_proveedor.IdProveedor INNER JOIN
                         dbo.tb_persona ON dbo.cp_proveedor.IdPersona = dbo.tb_persona.IdPersona

GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 1, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwimp_orden_compra_ext_recepcion';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[70] 4[5] 2[7] 3) )"
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
         Begin Table = "imp_orden_compra_ext_recepcion"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 252
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "imp_orden_compra_ext"
            Begin Extent = 
               Top = 0
               Left = 453
               Bottom = 328
               Right = 702
            End
            DisplayFlags = 280
            TopColumn = 22
         End
         Begin Table = "cp_proveedor"
            Begin Extent = 
               Top = 101
               Left = 829
               Bottom = 231
               Right = 1061
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tb_persona"
            Begin Extent = 
               Top = 291
               Left = 834
               Bottom = 421
               Right = 1066
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwimp_orden_compra_ext_recepcion';

