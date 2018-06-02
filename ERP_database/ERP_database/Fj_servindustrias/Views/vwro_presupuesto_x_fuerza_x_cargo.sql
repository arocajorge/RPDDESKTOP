CREATE VIEW Fj_servindustrias.vwro_presupuesto_x_fuerza_x_cargo
AS
SELECT        Fj_servindustrias.ro_presupuesto_x_fuerza_x_cargo.IdEmpresa, Fj_servindustrias.ro_presupuesto_x_fuerza_x_cargo.IdNomina, Fj_servindustrias.ro_presupuesto_x_fuerza_x_cargo.IdFuerza, 
                         Fj_servindustrias.ro_presupuesto_x_fuerza_x_cargo.Anio, Fj_servindustrias.ro_presupuesto_x_fuerza_x_cargo.Mes, Fj_servindustrias.ro_presupuesto_x_fuerza_x_cargo.IdCargo, 
                         Fj_servindustrias.ro_presupuesto_x_fuerza_x_cargo.CantidadEmpleados, Fj_servindustrias.ro_presupuesto_x_fuerza_x_cargo.Presupuesto, Fj_servindustrias.ro_presupuesto_x_fuerza_x_cargo.Observacion, 
                         Fj_servindustrias.ro_presupuesto_x_fuerza_x_cargo.Dias_SyD_y_Feriado, Fj_servindustrias.ro_presupuesto_x_fuerza_x_cargo.diasEfectivos, Fj_servindustrias.ro_presupuesto_x_fuerza_x_cargo.BaseVariable, 
                         Fj_servindustrias.ro_fuerza.IdCentroCosto, Fj_servindustrias.ro_fuerza.IdSuccentroCosto
FROM            Fj_servindustrias.ro_presupuesto_x_fuerza_x_cargo INNER JOIN
                         Fj_servindustrias.ro_fuerza ON Fj_servindustrias.ro_presupuesto_x_fuerza_x_cargo.IdEmpresa = Fj_servindustrias.ro_fuerza.IdEmpresa AND 
                         Fj_servindustrias.ro_presupuesto_x_fuerza_x_cargo.IdFuerza = Fj_servindustrias.ro_fuerza.IdFuerza
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 1, @level0type = N'SCHEMA', @level0name = N'Fj_servindustrias', @level1type = N'VIEW', @level1name = N'vwro_presupuesto_x_fuerza_x_cargo';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[80] 4[5] 2[5] 3) )"
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
         Begin Table = "ro_presupuesto_x_fuerza_x_cargo (Fj_servindustrias)"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 357
               Right = 233
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ro_fuerza (Fj_servindustrias)"
            Begin Extent = 
               Top = 6
               Left = 271
               Bottom = 368
               Right = 460
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
', @level0type = N'SCHEMA', @level0name = N'Fj_servindustrias', @level1type = N'VIEW', @level1name = N'vwro_presupuesto_x_fuerza_x_cargo';

