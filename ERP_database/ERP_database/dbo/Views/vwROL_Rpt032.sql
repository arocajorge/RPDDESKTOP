CREATE VIEW dbo.vwROL_Rpt032
AS
SELECT        dbo.ro_Acta_Finiquito.IdEmpresa, dbo.ro_Acta_Finiquito.IdActaFiniquito, dbo.ro_Acta_Finiquito.IdEmpleado, dbo.ro_Acta_Finiquito.FechaIngreso, dbo.ro_Acta_Finiquito.FechaSalida, dbo.ro_Acta_Finiquito.UltimaRemuneracion, 
                         dbo.ro_Acta_Finiquito.Observacion, dbo.ro_Acta_Finiquito.Ingresos, dbo.ro_Acta_Finiquito.Egresos, dbo.tb_persona.pe_cedulaRuc, dbo.tb_persona.pe_apellido, dbo.tb_persona.pe_nombre, dbo.ro_catalogo.ca_descripcion, 
                         dbo.ro_cargo.ca_descripcion AS Cargo, dbo.ro_Departamento.de_descripcion, dbo.vwro_Acta_Finiquito_det_Vac_dec.Sec, dbo.vwro_Acta_Finiquito_det_Vac_dec.Anio, dbo.vwro_Acta_Finiquito_det_Vac_dec.Mes, 
                         dbo.vwro_Acta_Finiquito_det_Vac_dec.Total_Remuneracion, dbo.vwro_Acta_Finiquito_det_Vac_dec.Decimo, dbo.vwro_Acta_Finiquito_det_Vac_dec.DiasTrabajados, dbo.vwro_Acta_Finiquito_det_Vac_dec.ob
FROM            dbo.tb_persona INNER JOIN
                         dbo.ro_empleado ON dbo.tb_persona.IdPersona = dbo.ro_empleado.IdPersona INNER JOIN
                         dbo.ro_Acta_Finiquito ON dbo.ro_empleado.IdEmpresa = dbo.ro_Acta_Finiquito.IdEmpresa AND dbo.ro_empleado.IdEmpleado = dbo.ro_Acta_Finiquito.IdEmpleado INNER JOIN
                         dbo.ro_cargo ON dbo.ro_empleado.IdEmpresa = dbo.ro_cargo.IdEmpresa AND dbo.ro_empleado.IdCargo = dbo.ro_cargo.IdCargo INNER JOIN
                         dbo.ro_Departamento ON dbo.ro_empleado.IdEmpresa = dbo.ro_Departamento.IdEmpresa AND dbo.ro_empleado.IdDepartamento = dbo.ro_Departamento.IdDepartamento INNER JOIN
                         dbo.ro_catalogo ON dbo.ro_Acta_Finiquito.IdCausaTerminacion = dbo.ro_catalogo.IdCatalogo INNER JOIN
                         dbo.vwro_Acta_Finiquito_det_Vac_dec ON dbo.ro_Acta_Finiquito.IdEmpresa = dbo.vwro_Acta_Finiquito_det_Vac_dec.IdEmpresa AND 
                         dbo.ro_Acta_Finiquito.IdActaFiniquito = dbo.vwro_Acta_Finiquito_det_Vac_dec.IdLiquidacion AND dbo.ro_Acta_Finiquito.IdEmpleado = dbo.vwro_Acta_Finiquito_det_Vac_dec.IdEmpleado
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwROL_Rpt032';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N' 1150
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
      Begin ColumnWidths = 10
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwROL_Rpt032';






GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[70] 4[5] 2[11] 3) )"
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
         Begin Table = "tb_persona"
            Begin Extent = 
               Top = 134
               Left = 721
               Bottom = 479
               Right = 953
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ro_empleado"
            Begin Extent = 
               Top = 0
               Left = 386
               Bottom = 377
               Right = 675
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ro_Acta_Finiquito"
            Begin Extent = 
               Top = 11
               Left = 515
               Bottom = 300
               Right = 772
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ro_cargo"
            Begin Extent = 
               Top = 146
               Left = 0
               Bottom = 276
               Right = 181
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ro_Departamento"
            Begin Extent = 
               Top = 24
               Left = 209
               Bottom = 154
               Right = 414
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ro_catalogo"
            Begin Extent = 
               Top = 310
               Left = 990
               Bottom = 578
               Right = 1161
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "vwro_Acta_Finiquito_det_Vac_dec"
            Begin Extent = 
               Top = 34
               Left = 952
               Bottom = 288
               Right =', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwROL_Rpt032';





