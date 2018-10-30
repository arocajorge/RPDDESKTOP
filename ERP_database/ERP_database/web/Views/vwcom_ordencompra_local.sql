CREATE VIEW web.vwcom_ordencompra_local
AS
SELECT        dbo.com_ordencompra_local.IdEmpresa, dbo.com_ordencompra_local.IdSucursal, dbo.com_ordencompra_local.IdOrdenCompra, dbo.com_ordencompra_local.IdProveedor, dbo.com_ordencompra_local.oc_NumDocumento, 
                         dbo.com_ordencompra_local.IdTerminoPago, dbo.com_ordencompra_local.oc_plazo, dbo.com_ordencompra_local.oc_fecha, dbo.com_ordencompra_local.oc_observacion, dbo.com_ordencompra_local.Estado, 
                         dbo.com_ordencompra_local.IdEstadoAprobacion_cat, dbo.com_ordencompra_local.co_fecha_aprobacion, dbo.com_ordencompra_local.IdUsuario_Aprueba, dbo.com_ordencompra_local.IdUsuario_Reprue, 
                         dbo.com_ordencompra_local.co_fechaReproba, dbo.com_ordencompra_local.MotivoReprobacion, dbo.com_ordencompra_local.IdDepartamento, dbo.com_ordencompra_local.IdMotivo, 
                         dbo.com_ordencompra_local.oc_fechaVencimiento, dbo.com_ordencompra_local.IdEstado_cierre, dbo.com_ordencompra_local.IdComprador, dbo.cp_proveedor.pr_codigo, dbo.tb_persona.pe_cedulaRuc, 
                         dbo.tb_persona.pe_nombreCompleto, dbo.seg_usuario.Nombre
FROM            dbo.com_comprador INNER JOIN
                         dbo.com_ordencompra_local ON dbo.com_comprador.IdEmpresa = dbo.com_ordencompra_local.IdEmpresa AND dbo.com_comprador.IdComprador = dbo.com_ordencompra_local.IdComprador INNER JOIN
                         dbo.cp_proveedor ON dbo.com_ordencompra_local.IdEmpresa = dbo.cp_proveedor.IdEmpresa AND dbo.com_ordencompra_local.IdProveedor = dbo.cp_proveedor.IdProveedor INNER JOIN
                         dbo.tb_persona ON dbo.cp_proveedor.IdPersona = dbo.tb_persona.IdPersona INNER JOIN
                         dbo.seg_usuario ON dbo.com_comprador.IdUsuario_com = dbo.seg_usuario.IdUsuario
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'web', @level1type = N'VIEW', @level1name = N'vwcom_ordencompra_local';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'Width = 1500
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
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
', @level0type = N'SCHEMA', @level0name = N'web', @level1type = N'VIEW', @level1name = N'vwcom_ordencompra_local';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[73] 4[5] 2[5] 3) )"
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
         Begin Table = "com_comprador"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 303
               Right = 217
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "com_ordencompra_local"
            Begin Extent = 
               Top = 8
               Left = 466
               Bottom = 362
               Right = 683
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "cp_proveedor"
            Begin Extent = 
               Top = 21
               Left = 586
               Bottom = 373
               Right = 818
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tb_persona"
            Begin Extent = 
               Top = 78
               Left = 749
               Bottom = 373
               Right = 981
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "seg_usuario"
            Begin Extent = 
               Top = 74
               Left = 200
               Bottom = 305
               Right = 448
            End
            DisplayFlags = 280
            TopColumn = 2
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 26
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
         ', @level0type = N'SCHEMA', @level0name = N'web', @level1type = N'VIEW', @level1name = N'vwcom_ordencompra_local';

