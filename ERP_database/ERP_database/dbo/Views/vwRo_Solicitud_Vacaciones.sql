CREATE VIEW dbo.vwRo_Solicitud_Vacaciones
AS
SELECT        dbo.ro_Solicitud_Vacaciones_x_empleado.IdEmpresa, dbo.ro_Solicitud_Vacaciones_x_empleado.IdNomina_Tipo, dbo.ro_Solicitud_Vacaciones_x_empleado.IdSolicitudVaca, dbo.ro_Solicitud_Vacaciones_x_empleado.Fecha, 
                         dbo.ro_Solicitud_Vacaciones_x_empleado.IdEmpleado, dbo.ro_Solicitud_Vacaciones_x_empleado.AnioServicio, dbo.ro_Solicitud_Vacaciones_x_empleado.Dias_q_Corresponde, 
                         dbo.ro_Solicitud_Vacaciones_x_empleado.Dias_a_disfrutar, dbo.ro_Solicitud_Vacaciones_x_empleado.Dias_pendiente, dbo.ro_Solicitud_Vacaciones_x_empleado.Anio_Desde, 
                         dbo.ro_Solicitud_Vacaciones_x_empleado.Anio_Hasta, dbo.ro_Solicitud_Vacaciones_x_empleado.Fecha_Desde, dbo.ro_Solicitud_Vacaciones_x_empleado.Fecha_Hasta, 
                         dbo.ro_Solicitud_Vacaciones_x_empleado.Fecha_Retorno, dbo.ro_Solicitud_Vacaciones_x_empleado.Observacion, dbo.ro_Solicitud_Vacaciones_x_empleado.IdUsuario, 
                         dbo.ro_Solicitud_Vacaciones_x_empleado.IdUsuario_Anu, dbo.ro_Solicitud_Vacaciones_x_empleado.FechaAnulacion, dbo.ro_Solicitud_Vacaciones_x_empleado.Fecha_Transac, 
                         dbo.ro_Solicitud_Vacaciones_x_empleado.Fecha_UltMod, dbo.ro_Solicitud_Vacaciones_x_empleado.IdUsuarioUltMod, dbo.ro_Solicitud_Vacaciones_x_empleado.Estado, 
                         dbo.ro_Solicitud_Vacaciones_x_empleado.MotivoAnulacion, dbo.ro_Solicitud_Vacaciones_x_empleado.ip, dbo.ro_Solicitud_Vacaciones_x_empleado.nom_pc, dbo.ro_Solicitud_Vacaciones_x_empleado.IdEstadoAprobacion, 
                         dbo.tb_persona.pe_apellido, dbo.tb_persona.pe_nombre, dbo.tb_persona.pe_nombreCompleto, dbo.ro_Solicitud_Vacaciones_x_empleado.IdEmpleado_aprue, dbo.ro_Solicitud_Vacaciones_x_empleado.IdEmpleado_remp, 
                         dbo.ro_Solicitud_Vacaciones_x_empleado.Gozadas_Pgadas, dbo.ro_Historico_Liquidacion_Vacaciones.IdOrdenPago, dbo.ro_Solicitud_Vacaciones_x_empleado.Canceladas, 
                         dbo.ro_Historico_Liquidacion_Vacaciones.IdSolicitud, dbo.ro_Historico_Liquidacion_Vacaciones.ValorCancelado, dbo.ro_Historico_Liquidacion_Vacaciones.FechaPago, dbo.ro_Historico_Liquidacion_Vacaciones.Iess
FROM            dbo.ro_Solicitud_Vacaciones_x_empleado INNER JOIN
                         dbo.ro_empleado ON dbo.ro_Solicitud_Vacaciones_x_empleado.IdEmpresa = dbo.ro_empleado.IdEmpresa AND dbo.ro_Solicitud_Vacaciones_x_empleado.IdEmpleado = dbo.ro_empleado.IdEmpleado INNER JOIN
                         dbo.tb_persona ON dbo.ro_empleado.IdPersona = dbo.tb_persona.IdPersona LEFT OUTER JOIN
                         dbo.ro_Historico_Liquidacion_Vacaciones ON dbo.ro_Solicitud_Vacaciones_x_empleado.IdEmpresa = dbo.ro_Historico_Liquidacion_Vacaciones.IdEmpresa AND 
                         dbo.ro_Solicitud_Vacaciones_x_empleado.IdNomina_Tipo = dbo.ro_Historico_Liquidacion_Vacaciones.IdNomina_Tipo AND 
                         dbo.ro_Solicitud_Vacaciones_x_empleado.IdEmpleado = dbo.ro_Historico_Liquidacion_Vacaciones.IdEmpleado AND 
                         dbo.ro_Solicitud_Vacaciones_x_empleado.IdSolicitudVaca = dbo.ro_Historico_Liquidacion_Vacaciones.IdLiquidacion
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwRo_Solicitud_Vacaciones';


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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwRo_Solicitud_Vacaciones';




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
         Begin Table = "ro_Solicitud_Vacaciones_x_empleado"
            Begin Extent = 
               Top = 0
               Left = 434
               Bottom = 238
               Right = 1003
            End
            DisplayFlags = 280
            TopColumn = 19
         End
         Begin Table = "ro_empleado"
            Begin Extent = 
               Top = 67
               Left = 709
               Bottom = 197
               Right = 998
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tb_persona"
            Begin Extent = 
               Top = 67
               Left = 980
               Bottom = 197
               Right = 1212
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ro_Historico_Liquidacion_Vacaciones"
            Begin Extent = 
               Top = 4
               Left = 0
               Bottom = 369
               Right = 253
            End
            DisplayFlags = 280
            TopColumn = 5
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 36
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
         ', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwRo_Solicitud_Vacaciones';



