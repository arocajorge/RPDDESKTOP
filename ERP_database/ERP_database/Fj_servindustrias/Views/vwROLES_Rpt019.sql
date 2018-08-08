CREATE VIEW Fj_servindustrias.vwROLES_Rpt019
AS
SELECT        Fj_servindustrias.ro_fectividad_x_empleado_Adm_x_periodo_Det.IdEmpresa, Fj_servindustrias.ro_fectividad_x_empleado_Adm_x_periodo_Det.IdNomina_Tipo, 
                         Fj_servindustrias.ro_fectividad_x_empleado_Adm_x_periodo_Det.IdNomina_Tipo_Liq, Fj_servindustrias.ro_fectividad_x_empleado_Adm_x_periodo_Det.IdPeriodo, 
                         Fj_servindustrias.ro_fectividad_x_empleado_Adm_x_periodo_Det.IdEmpleado, Fj_servindustrias.ro_fectividad_x_empleado_Adm_x_periodo_Det.cod_Pago_Variable, dbo.tb_persona.pe_cedulaRuc, 
                         dbo.tb_persona.pe_apellido + ' ' + dbo.tb_persona.pe_nombre AS Nombres, dbo.ro_cargo.ca_descripcion, Fj_servindustrias.ro_fectividad_x_empleado_Adm_x_periodo_Det.Meta, 
                         Fj_servindustrias.ro_fectividad_x_empleado_Adm_x_periodo_Det.Real, Fj_servindustrias.ro_fectividad_x_empleado_Adm_x_periodo_Det.Cumplimiento, 
                         Fj_servindustrias.ro_fectividad_x_empleado_Adm_x_periodo_Det.Variable_porcentaje_prorrateado, dbo.ro_empleado_novedad_det.Valor, dbo.ro_empleado_novedad_det.FechaPago, dbo.ro_rubro_tipo.ru_descripcion, 
                         Fj_servindustrias.ro_Grupo_empleado.Valor_bono
FROM            dbo.ro_empleado_x_ro_tipoNomina INNER JOIN
                         dbo.ro_empleado INNER JOIN
                         dbo.tb_persona ON dbo.ro_empleado.IdPersona = dbo.tb_persona.IdPersona ON dbo.ro_empleado_x_ro_tipoNomina.IdEmpresa = dbo.ro_empleado.IdEmpresa AND 
                         dbo.ro_empleado_x_ro_tipoNomina.IdEmpleado = dbo.ro_empleado.IdEmpleado AND dbo.ro_empleado_x_ro_tipoNomina.IdEmpresa = dbo.ro_empleado.IdEmpresa AND 
                         dbo.ro_empleado_x_ro_tipoNomina.IdEmpleado = dbo.ro_empleado.IdEmpleado INNER JOIN
                         Fj_servindustrias.ro_fectividad_x_empleado_Adm_x_periodo_Det INNER JOIN
                         Fj_servindustrias.ro_fectividad_x_empleado_Adm_x_periodo ON Fj_servindustrias.ro_fectividad_x_empleado_Adm_x_periodo_Det.IdEmpresa = Fj_servindustrias.ro_fectividad_x_empleado_Adm_x_periodo.IdEmpresa AND 
                         Fj_servindustrias.ro_fectividad_x_empleado_Adm_x_periodo_Det.IdNomina_Tipo = Fj_servindustrias.ro_fectividad_x_empleado_Adm_x_periodo.IdNomina_Tipo AND 
                         Fj_servindustrias.ro_fectividad_x_empleado_Adm_x_periodo_Det.IdNomina_Tipo_Liq = Fj_servindustrias.ro_fectividad_x_empleado_Adm_x_periodo.IdNomina_Tipo_Liq AND 
                         Fj_servindustrias.ro_fectividad_x_empleado_Adm_x_periodo_Det.IdPeriodo = Fj_servindustrias.ro_fectividad_x_empleado_Adm_x_periodo.IdPeriodo AND 
                         Fj_servindustrias.ro_fectividad_x_empleado_Adm_x_periodo_Det.IdEmpresa = Fj_servindustrias.ro_fectividad_x_empleado_Adm_x_periodo.IdEmpresa AND 
                         Fj_servindustrias.ro_fectividad_x_empleado_Adm_x_periodo_Det.IdNomina_Tipo = Fj_servindustrias.ro_fectividad_x_empleado_Adm_x_periodo.IdNomina_Tipo AND 
                         Fj_servindustrias.ro_fectividad_x_empleado_Adm_x_periodo_Det.IdNomina_Tipo_Liq = Fj_servindustrias.ro_fectividad_x_empleado_Adm_x_periodo.IdNomina_Tipo_Liq AND 
                         Fj_servindustrias.ro_fectividad_x_empleado_Adm_x_periodo_Det.IdPeriodo = Fj_servindustrias.ro_fectividad_x_empleado_Adm_x_periodo.IdPeriodo ON 
                         dbo.ro_empleado_x_ro_tipoNomina.IdEmpresa = Fj_servindustrias.ro_fectividad_x_empleado_Adm_x_periodo_Det.IdEmpresa AND 
                         dbo.ro_empleado_x_ro_tipoNomina.IdEmpleado = Fj_servindustrias.ro_fectividad_x_empleado_Adm_x_periodo_Det.IdEmpleado AND 
                         dbo.ro_empleado_x_ro_tipoNomina.IdTipoNomina = Fj_servindustrias.ro_fectividad_x_empleado_Adm_x_periodo_Det.IdNomina_Tipo INNER JOIN
                         Fj_servindustrias.ro_parametro_x_pago_variable_tipo ON Fj_servindustrias.ro_fectividad_x_empleado_Adm_x_periodo_Det.IdEmpresa = Fj_servindustrias.ro_parametro_x_pago_variable_tipo.IdEmpresa AND 
                         Fj_servindustrias.ro_fectividad_x_empleado_Adm_x_periodo_Det.cod_Pago_Variable = Fj_servindustrias.ro_parametro_x_pago_variable_tipo.cod_Pago_Variable AND 
                         Fj_servindustrias.ro_fectividad_x_empleado_Adm_x_periodo_Det.IdEmpresa = Fj_servindustrias.ro_parametro_x_pago_variable_tipo.IdEmpresa AND 
                         Fj_servindustrias.ro_fectividad_x_empleado_Adm_x_periodo_Det.cod_Pago_Variable = Fj_servindustrias.ro_parametro_x_pago_variable_tipo.cod_Pago_Variable AND 
                         Fj_servindustrias.ro_fectividad_x_empleado_Adm_x_periodo_Det.IdEmpresa = Fj_servindustrias.ro_parametro_x_pago_variable_tipo.IdEmpresa AND 
                         Fj_servindustrias.ro_fectividad_x_empleado_Adm_x_periodo_Det.cod_Pago_Variable = Fj_servindustrias.ro_parametro_x_pago_variable_tipo.cod_Pago_Variable INNER JOIN
                         dbo.ro_rubro_tipo ON Fj_servindustrias.ro_parametro_x_pago_variable_tipo.IdEmpresa = dbo.ro_rubro_tipo.IdEmpresa AND 
                         Fj_servindustrias.ro_parametro_x_pago_variable_tipo.IdRubro = dbo.ro_rubro_tipo.IdRubro INNER JOIN
                         dbo.ro_cargo ON dbo.ro_empleado.IdEmpresa = dbo.ro_cargo.IdEmpresa AND dbo.ro_empleado.IdCargo = dbo.ro_cargo.IdCargo AND dbo.ro_empleado.IdEmpresa = dbo.ro_cargo.IdEmpresa AND 
                         dbo.ro_empleado.IdCargo = dbo.ro_cargo.IdCargo AND dbo.ro_empleado.IdEmpresa = dbo.ro_cargo.IdEmpresa AND dbo.ro_empleado.IdCargo = dbo.ro_cargo.IdCargo AND 
                         dbo.ro_empleado.IdEmpresa = dbo.ro_cargo.IdEmpresa AND dbo.ro_empleado.IdCargo = dbo.ro_cargo.IdCargo AND dbo.ro_empleado.IdEmpresa = dbo.ro_cargo.IdEmpresa AND 
                         dbo.ro_empleado.IdCargo = dbo.ro_cargo.IdCargo INNER JOIN
                         dbo.ro_empleado_novedad_det ON dbo.ro_rubro_tipo.IdEmpresa = dbo.ro_empleado_novedad_det.IdEmpresa AND dbo.ro_rubro_tipo.IdRubro = dbo.ro_empleado_novedad_det.IdRubro AND 
                         dbo.ro_rubro_tipo.IdEmpresa = dbo.ro_empleado_novedad_det.IdEmpresa AND dbo.ro_rubro_tipo.IdRubro = dbo.ro_empleado_novedad_det.IdRubro AND 
                         dbo.ro_rubro_tipo.IdEmpresa = dbo.ro_empleado_novedad_det.IdEmpresa AND dbo.ro_rubro_tipo.IdRubro = dbo.ro_empleado_novedad_det.IdRubro AND 
                         dbo.ro_rubro_tipo.IdEmpresa = dbo.ro_empleado_novedad_det.IdEmpresa AND dbo.ro_rubro_tipo.IdRubro = dbo.ro_empleado_novedad_det.IdRubro AND 
                         Fj_servindustrias.ro_fectividad_x_empleado_Adm_x_periodo_Det.IdEmpleado = dbo.ro_empleado_novedad_det.IdEmpleado AND 
                         Fj_servindustrias.ro_fectividad_x_empleado_Adm_x_periodo_Det.IdEmpresa = dbo.ro_empleado_novedad_det.IdEmpresa INNER JOIN
                         Fj_servindustrias.ro_Grupo_empleado ON dbo.ro_empleado.IdEmpresa = Fj_servindustrias.ro_Grupo_empleado.IdEmpresa AND dbo.ro_empleado.IdGrupo = Fj_servindustrias.ro_Grupo_empleado.IdGrupo
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[14] 4[5] 2[50] 3) )"
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
         Begin Table = "ro_empleado_x_ro_tipoNomina"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ro_empleado"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 136
               Right = 535
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tb_persona"
            Begin Extent = 
               Top = 6
               Left = 573
               Bottom = 136
               Right = 805
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ro_fectividad_x_empleado_Adm_x_periodo_Det (Fj_servindustrias)"
            Begin Extent = 
               Top = 6
               Left = 827
               Bottom = 273
               Right = 1102
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ro_fectividad_x_empleado_Adm_x_periodo (Fj_servindustrias)"
            Begin Extent = 
               Top = 138
               Left = 38
               Bottom = 268
               Right = 230
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ro_parametro_x_pago_variable_tipo (Fj_servindustrias)"
            Begin Extent = 
               Top = 96
               Left = 303
               Bottom = 226
               Right = 496
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ro_rubro_tipo"
      ', @level0type = N'SCHEMA', @level0name = N'Fj_servindustrias', @level1type = N'VIEW', @level1name = N'vwROLES_Rpt019';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'      Begin Extent = 
               Top = 138
               Left = 499
               Bottom = 268
               Right = 752
            End
            DisplayFlags = 280
            TopColumn = 3
         End
         Begin Table = "ro_cargo"
            Begin Extent = 
               Top = 138
               Left = 790
               Bottom = 268
               Right = 971
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ro_empleado_novedad_det"
            Begin Extent = 
               Top = 138
               Left = 1009
               Bottom = 268
               Right = 1201
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ro_Grupo_empleado (Fj_servindustrias)"
            Begin Extent = 
               Top = 270
               Left = 38
               Bottom = 400
               Right = 273
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
      Begin ColumnWidths = 18
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
', @level0type = N'SCHEMA', @level0name = N'Fj_servindustrias', @level1type = N'VIEW', @level1name = N'vwROLES_Rpt019';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'Fj_servindustrias', @level1type = N'VIEW', @level1name = N'vwROLES_Rpt019';

