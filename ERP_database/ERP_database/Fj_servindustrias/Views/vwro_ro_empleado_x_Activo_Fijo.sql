CREATE VIEW [Fj_servindustrias].[vwro_ro_empleado_x_Activo_Fijo]
AS
SELECT Fj_servindustrias.ro_empleado_x_Activo_Fijo.IdEmpresa, Fj_servindustrias.ro_empleado_x_Activo_Fijo.IdActivo_fijo, Fj_servindustrias.ro_empleado_x_Activo_Fijo.IdEmpleado, 
                  Fj_servindustrias.ro_empleado_x_Activo_Fijo.Fecha_Asignacion, Fj_servindustrias.ro_empleado_x_Activo_Fijo.Fecha_Hasta, dbo.tb_persona.pe_cedulaRuc, dbo.tb_persona.pe_nombreCompleto, dbo.tb_persona.pe_apellido, 
                  dbo.tb_persona.pe_nombre, dbo.ro_Departamento.de_descripcion, dbo.ro_area.Descripcion, dbo.Af_Activo_fijo.Af_Nombre, dbo.Af_Activo_fijo.Af_DescripcionCorta, Fj_servindustrias.ro_empleado_x_Activo_Fijo.IdNomina_tipo, 
                  Fj_servindustrias.ro_empleado_x_Activo_Fijo.IdPeriodo, isnull(Fj_servindustrias.fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo.IdCentroCosto, Fj_servindustrias.ro_empleado_x_Activo_Fijo.IdCentroCosto)IdCentroCosto, 
                  isnull(Fj_servindustrias.fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo.IdCentroCosto_sub_centro_costo,Fj_servindustrias.ro_empleado_x_Activo_Fijo.IdCentroCosto_sub_centro_costo) IdCentroCosto_sub_centro_costo
FROM     dbo.ro_empleado INNER JOIN
                  dbo.tb_persona ON dbo.ro_empleado.IdPersona = dbo.tb_persona.IdPersona INNER JOIN
                  dbo.ro_area ON dbo.ro_empleado.IdEmpresa = dbo.ro_area.IdEmpresa AND dbo.ro_empleado.IdDivision = dbo.ro_area.IdDivision AND dbo.ro_empleado.IdArea = dbo.ro_area.IdArea INNER JOIN
                  dbo.ro_Departamento ON dbo.ro_empleado.IdEmpresa = dbo.ro_Departamento.IdEmpresa AND dbo.ro_empleado.IdDepartamento = dbo.ro_Departamento.IdDepartamento INNER JOIN
                  Fj_servindustrias.ro_empleado_x_Activo_Fijo ON dbo.ro_empleado.IdEmpresa = Fj_servindustrias.ro_empleado_x_Activo_Fijo.IdEmpresa AND 
                  dbo.ro_empleado.IdEmpleado = Fj_servindustrias.ro_empleado_x_Activo_Fijo.IdEmpleado INNER JOIN
                  dbo.Af_Activo_fijo ON Fj_servindustrias.ro_empleado_x_Activo_Fijo.IdEmpresa = dbo.Af_Activo_fijo.IdEmpresa AND Fj_servindustrias.ro_empleado_x_Activo_Fijo.IdActivo_fijo = dbo.Af_Activo_fijo.IdActivoFijo LEFT OUTER JOIN
                  Fj_servindustrias.fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo ON dbo.Af_Activo_fijo.IdEmpresa = Fj_servindustrias.fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo.IdEmpresa AND 
                  dbo.Af_Activo_fijo.IdActivoFijo = Fj_servindustrias.fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo.IdActivoFijo
WHERE  (dbo.ro_empleado.em_status <> 'EST_LIQ')
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'Fj_servindustrias', @level1type = N'VIEW', @level1name = N'vwro_ro_empleado_x_Activo_Fijo';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'              Left = 46
               Bottom = 964
               Right = 355
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
      Begin ColumnWidths = 9
         Width = 284
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
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
', @level0type = N'SCHEMA', @level0name = N'Fj_servindustrias', @level1type = N'VIEW', @level1name = N'vwro_ro_empleado_x_Activo_Fijo';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[70] 4[3] 2[8] 3) )"
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
         Top = -720
         Left = 0
      End
      Begin Tables = 
         Begin Table = "ro_empleado"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 170
               Right = 395
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tb_persona"
            Begin Extent = 
               Top = 53
               Left = 755
               Bottom = 216
               Right = 1029
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ro_area"
            Begin Extent = 
               Top = 47
               Left = 721
               Bottom = 210
               Right = 929
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ro_Departamento"
            Begin Extent = 
               Top = 304
               Left = 1017
               Bottom = 467
               Right = 1260
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ro_empleado_x_Activo_Fijo (Fj_servindustrias)"
            Begin Extent = 
               Top = 305
               Left = 543
               Bottom = 468
               Right = 852
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Af_Activo_fijo"
            Begin Extent = 
               Top = 836
               Left = 931
               Bottom = 999
               Right = 1240
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo (Fj_servindustrias)"
            Begin Extent = 
               Top = 801
 ', @level0type = N'SCHEMA', @level0name = N'Fj_servindustrias', @level1type = N'VIEW', @level1name = N'vwro_ro_empleado_x_Activo_Fijo';

