CREATE VIEW dbo.vwROL_Rpt030
AS
SELECT        dbo.ro_Solicitud_Vacaciones_x_empleado.IdEmpresa, dbo.ro_Solicitud_Vacaciones_x_empleado.IdNomina_Tipo, dbo.ro_Solicitud_Vacaciones_x_empleado.IdSolicitudVaca, 
                         dbo.ro_Solicitud_Vacaciones_x_empleado.IdEmpleado, dbo.tb_persona.pe_cedulaRuc, dbo.tb_persona.pe_apellido + ' ' + dbo.tb_persona.pe_nombre AS Nombre, dbo.ro_cargo.ca_descripcion, 
                         dbo.ro_Solicitud_Vacaciones_x_empleado.Anio_Desde, dbo.ro_Solicitud_Vacaciones_x_empleado.Anio_Hasta, dbo.ro_Solicitud_Vacaciones_x_empleado.AnioServicio, 
                         dbo.ro_Solicitud_Vacaciones_x_empleado.Dias_q_Corresponde, dbo.ro_Solicitud_Vacaciones_x_empleado.Dias_a_disfrutar, dbo.ro_Solicitud_Vacaciones_x_empleado.Dias_pendiente, 
                         dbo.ro_Solicitud_Vacaciones_x_empleado.Fecha_Desde, dbo.ro_Solicitud_Vacaciones_x_empleado.Fecha_Hasta, dbo.ro_Solicitud_Vacaciones_x_empleado.Fecha_Retorno, 
                         dbo.ro_Solicitud_Vacaciones_x_empleado.Observacion, dbo.ro_Solicitud_Vacaciones_x_empleado.Gozadas_Pgadas, dbo.ro_Historico_Liquidacion_Vacaciones.ValorCancelado, 
                         dbo.ro_Historico_Liquidacion_Vacaciones.FechaPago, dbo.ro_Historico_Liquidacion_Vacaciones.Iess
FROM            dbo.tb_persona INNER JOIN
                         dbo.ro_empleado ON dbo.tb_persona.IdPersona = dbo.ro_empleado.IdPersona INNER JOIN
                         dbo.ro_Solicitud_Vacaciones_x_empleado ON dbo.ro_empleado.IdEmpresa = dbo.ro_Solicitud_Vacaciones_x_empleado.IdEmpresa AND 
                         dbo.ro_empleado.IdEmpleado = dbo.ro_Solicitud_Vacaciones_x_empleado.IdEmpleado INNER JOIN
                         dbo.ro_Historico_Liquidacion_Vacaciones ON dbo.ro_Solicitud_Vacaciones_x_empleado.IdEmpresa = dbo.ro_Historico_Liquidacion_Vacaciones.IdEmpresa AND 
                         dbo.ro_Solicitud_Vacaciones_x_empleado.IdNomina_Tipo = dbo.ro_Historico_Liquidacion_Vacaciones.IdNomina_Tipo AND 
                         dbo.ro_Solicitud_Vacaciones_x_empleado.IdSolicitudVaca = dbo.ro_Historico_Liquidacion_Vacaciones.IdLiquidacion AND 
                         dbo.ro_Solicitud_Vacaciones_x_empleado.IdEmpleado = dbo.ro_Historico_Liquidacion_Vacaciones.IdEmpleado INNER JOIN
                         dbo.ro_cargo ON dbo.ro_empleado.IdEmpresa = dbo.ro_cargo.IdEmpresa AND dbo.ro_empleado.IdCargo = dbo.ro_cargo.IdCargo
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwROL_Rpt030';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'        Width = 1500
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwROL_Rpt030';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[36] 4[5] 2[5] 3) )"
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
               Top = 6
               Left = 38
               Bottom = 259
               Right = 270
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ro_Historico_Liquidacion_Vacaciones"
            Begin Extent = 
               Top = 0
               Left = 926
               Bottom = 400
               Right = 1227
            End
            DisplayFlags = 280
            TopColumn = 2
         End
         Begin Table = "ro_empleado"
            Begin Extent = 
               Top = 6
               Left = 308
               Bottom = 256
               Right = 597
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ro_Solicitud_Vacaciones_x_empleado"
            Begin Extent = 
               Top = 0
               Left = 645
               Bottom = 435
               Right = 841
            End
            DisplayFlags = 280
            TopColumn = 8
         End
         Begin Table = "ro_cargo"
            Begin Extent = 
               Top = 103
               Left = 349
               Bottom = 233
               Right = 530
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
      Begin ColumnWidths = 22
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
 ', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwROL_Rpt030';

