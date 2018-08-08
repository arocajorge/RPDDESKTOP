CREATE VIEW Fj_servindustrias.vwro_empleado_x_cargo_fuerza_grupo
AS
SELECT        Fj_servindustrias.ro_Grupo_empleado.Nombre_Grupo, Fj_servindustrias.ro_Grupo_empleado.Calculo_Horas_extras_Sobre, Fj_servindustrias.ro_Grupo_empleado.Max_num_horas_sab_dom, 
                         Fj_servindustrias.ro_Grupo_empleado.IdRubro_Alim, Fj_servindustrias.ro_Grupo_empleado.IdRubro_Trans, Fj_servindustrias.ro_Grupo_empleado.Valor_Alimen, Fj_servindustrias.ro_Grupo_empleado.Valor_Transp, 
                         Fj_servindustrias.ro_Grupo_empleado.Valor_bono, Fj_servindustrias.ro_empleado_x_cargo_fuerza_grupo.IdEmpresa, Fj_servindustrias.ro_empleado_x_cargo_fuerza_grupo.IdNomina, 
                         Fj_servindustrias.ro_empleado_x_cargo_fuerza_grupo.IdEmpleado, Fj_servindustrias.ro_empleado_x_cargo_fuerza_grupo.IdPeriodo, Fj_servindustrias.ro_empleado_x_cargo_fuerza_grupo.IdFuerza, 
                         Fj_servindustrias.ro_empleado_x_cargo_fuerza_grupo.IdGrupo, Fj_servindustrias.ro_empleado_x_cargo_fuerza_grupo.IdCargo, Fj_servindustrias.ro_empleado_x_cargo_fuerza_grupo.Observacion
FROM            Fj_servindustrias.ro_empleado_x_cargo_fuerza_grupo INNER JOIN
                         Fj_servindustrias.ro_Grupo_empleado ON Fj_servindustrias.ro_empleado_x_cargo_fuerza_grupo.IdEmpresa = Fj_servindustrias.ro_Grupo_empleado.IdEmpresa AND 
                         Fj_servindustrias.ro_empleado_x_cargo_fuerza_grupo.IdGrupo = Fj_servindustrias.ro_Grupo_empleado.IdGrupo
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[79] 4[5] 2[5] 3) )"
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
         Begin Table = "ro_empleado_x_cargo_fuerza_grupo (Fj_servindustrias)"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 381
               Right = 390
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ro_Grupo_empleado (Fj_servindustrias)"
            Begin Extent = 
               Top = 5
               Left = 417
               Bottom = 372
               Right = 652
            End
            DisplayFlags = 280
            TopColumn = 3
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
', @level0type = N'SCHEMA', @level0name = N'Fj_servindustrias', @level1type = N'VIEW', @level1name = N'vwro_empleado_x_cargo_fuerza_grupo';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 1, @level0type = N'SCHEMA', @level0name = N'Fj_servindustrias', @level1type = N'VIEW', @level1name = N'vwro_empleado_x_cargo_fuerza_grupo';

