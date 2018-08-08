CREATE VIEW Fj_servindustrias.vwro_marcaciones_x_empleado_x_incidentes_falt_Perm
AS
SELECT        dbo.ro_empleado.IdEmpresa, dbo.ro_empleado.IdEmpleado, dbo.tb_persona.IdPersona, dbo.ro_cargo.IdCargo, dbo.ro_Departamento.IdDepartamento, 
                         Fj_servindustrias.ro_marcaciones_x_empleado_x_incidentes_falt_Perm.IdRegistro, Fj_servindustrias.ro_marcaciones_x_empleado_x_incidentes_falt_Perm.Id_catalogo_Cat, dbo.tb_persona.pe_cedulaRuc, 
                         dbo.tb_persona.pe_apellido, dbo.tb_persona.pe_nombre, dbo.ro_cargo.ca_descripcion, dbo.ro_Departamento.de_descripcion, Fj_servindustrias.ro_marcaciones_x_empleado_x_incidentes_falt_Perm.es_fecha_registro, 
                         Fj_servindustrias.ro_marcaciones_x_empleado_x_incidentes_falt_Perm.IdNomina_Tipo, dbo.ro_empleado.IdGrupo
FROM            dbo.ro_empleado INNER JOIN
                         Fj_servindustrias.ro_marcaciones_x_empleado_x_incidentes_falt_Perm ON dbo.ro_empleado.IdEmpresa = Fj_servindustrias.ro_marcaciones_x_empleado_x_incidentes_falt_Perm.IdEmpresa AND 
                         dbo.ro_empleado.IdEmpleado = Fj_servindustrias.ro_marcaciones_x_empleado_x_incidentes_falt_Perm.IdEmpleado INNER JOIN
                         dbo.tb_persona ON dbo.ro_empleado.IdPersona = dbo.tb_persona.IdPersona AND dbo.ro_empleado.IdPersona = dbo.tb_persona.IdPersona INNER JOIN
                         dbo.ro_Departamento ON dbo.ro_empleado.IdEmpresa = dbo.ro_Departamento.IdEmpresa AND dbo.ro_empleado.IdDepartamento = dbo.ro_Departamento.IdDepartamento AND 
                         dbo.ro_empleado.IdEmpresa = dbo.ro_Departamento.IdEmpresa AND dbo.ro_empleado.IdDepartamento = dbo.ro_Departamento.IdDepartamento INNER JOIN
                         dbo.ro_cargo ON dbo.ro_empleado.IdEmpresa = dbo.ro_cargo.IdEmpresa AND dbo.ro_empleado.IdCargo = dbo.ro_cargo.IdCargo AND dbo.ro_empleado.IdEmpresa = dbo.ro_cargo.IdEmpresa AND 
                         dbo.ro_empleado.IdCargo = dbo.ro_cargo.IdCargo
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[45] 4[5] 2[45] 3) )"
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
         Begin Table = "ro_empleado"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 327
            End
            DisplayFlags = 280
            TopColumn = 71
         End
         Begin Table = "ro_marcaciones_x_empleado_x_incidentes_falt_Perm (Fj_servindustrias)"
            Begin Extent = 
               Top = 47
               Left = 692
               Bottom = 177
               Right = 894
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tb_persona"
            Begin Extent = 
               Top = 270
               Left = 38
               Bottom = 400
               Right = 270
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ro_Departamento"
            Begin Extent = 
               Top = 402
               Left = 38
               Bottom = 532
               Right = 243
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ro_cargo"
            Begin Extent = 
               Top = 138
               Left = 278
               Bottom = 268
               Right = 459
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
   Begin C', @level0type = N'SCHEMA', @level0name = N'Fj_servindustrias', @level1type = N'VIEW', @level1name = N'vwro_marcaciones_x_empleado_x_incidentes_falt_Perm';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'riteriaPane = 
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
', @level0type = N'SCHEMA', @level0name = N'Fj_servindustrias', @level1type = N'VIEW', @level1name = N'vwro_marcaciones_x_empleado_x_incidentes_falt_Perm';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'Fj_servindustrias', @level1type = N'VIEW', @level1name = N'vwro_marcaciones_x_empleado_x_incidentes_falt_Perm';

