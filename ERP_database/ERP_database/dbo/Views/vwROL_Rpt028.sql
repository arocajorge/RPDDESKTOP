CREATE VIEW dbo.vwROL_Rpt028
AS
SELECT        dbo.ro_empleado_x_ro_tipoNomina.IdEmpresa, dbo.ro_empleado_x_ro_tipoNomina.IdEmpleado, dbo.ro_empleado_x_ro_tipoNomina.IdTipoNomina, dbo.tb_persona.pe_cedulaRuc, 
                         dbo.tb_persona.pe_apellido + ' ' + dbo.tb_persona.pe_nombre AS Empleado, dbo.ro_catalogo.ca_descripcion AS Estado, dbo.ro_cargo.ca_descripcion, dbo.ro_empleado.em_fechaIngaRol, dbo.ro_empleado.em_fechaSalida, 
                         dbo.ro_Acta_Finiquito.Ingresos, dbo.ro_Acta_Finiquito.Egresos, ro_catalogo_1.ca_descripcion AS MotivoTerminacion
FROM            dbo.ro_Acta_Finiquito INNER JOIN
                         dbo.ro_empleado ON dbo.ro_Acta_Finiquito.IdEmpresa = dbo.ro_empleado.IdEmpresa AND dbo.ro_Acta_Finiquito.IdEmpleado = dbo.ro_empleado.IdEmpleado INNER JOIN
                         dbo.tb_persona ON dbo.ro_empleado.IdPersona = dbo.tb_persona.IdPersona INNER JOIN
                         dbo.ro_catalogo ON dbo.ro_empleado.em_status = dbo.ro_catalogo.CodCatalogo INNER JOIN
                         dbo.ro_empleado_x_ro_tipoNomina ON dbo.ro_empleado.IdEmpresa = dbo.ro_empleado_x_ro_tipoNomina.IdEmpresa AND dbo.ro_empleado.IdEmpleado = dbo.ro_empleado_x_ro_tipoNomina.IdEmpleado INNER JOIN
                         dbo.ro_cargo ON dbo.ro_Acta_Finiquito.IdEmpresa = dbo.ro_cargo.IdEmpresa AND dbo.ro_Acta_Finiquito.IdCargo = dbo.ro_cargo.IdCargo AND dbo.ro_empleado.IdEmpresa = dbo.ro_cargo.IdEmpresa AND 
                         dbo.ro_empleado.IdCargo = dbo.ro_cargo.IdCargo INNER JOIN
                         dbo.ro_catalogo AS ro_catalogo_1 ON dbo.ro_Acta_Finiquito.IdCausaTerminacion = ro_catalogo_1.IdCatalogo

GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[63] 4[5] 2[5] 3) )"
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
         Top = -96
         Left = 0
      End
      Begin Tables = 
         Begin Table = "ro_Acta_Finiquito"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 297
               Right = 295
            End
            DisplayFlags = 280
            TopColumn = 1
         End
         Begin Table = "ro_empleado"
            Begin Extent = 
               Top = 0
               Left = 664
               Bottom = 290
               Right = 953
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tb_persona"
            Begin Extent = 
               Top = 0
               Left = 882
               Bottom = 297
               Right = 1114
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ro_catalogo"
            Begin Extent = 
               Top = 26
               Left = 1115
               Bottom = 156
               Right = 1286
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ro_empleado_x_ro_tipoNomina"
            Begin Extent = 
               Top = 0
               Left = 685
               Bottom = 249
               Right = 855
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ro_cargo"
            Begin Extent = 
               Top = 115
               Left = 568
               Bottom = 245
               Right = 749
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ro_catalogo_1"
            Begin Extent = 
               Top = 0
               Left = 0
               Bottom = 254
               Right = 171
    ', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwROL_Rpt028';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'        End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ro_empleado_x_Activo_Fijo (Fj_servindustrias)"
            Begin Extent = 
               Top = 207
               Left = 323
               Bottom = 451
               Right = 507
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Af_Activo_fijo"
            Begin Extent = 
               Top = 187
               Left = 383
               Bottom = 458
               Right = 646
            End
            DisplayFlags = 280
            TopColumn = 26
         End
         Begin Table = "ct_centro_costo_sub_centro_costo"
            Begin Extent = 
               Top = 236
               Left = 699
               Bottom = 440
               Right = 962
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
         Width = 1935
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 2310
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwROL_Rpt028';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwROL_Rpt028';

