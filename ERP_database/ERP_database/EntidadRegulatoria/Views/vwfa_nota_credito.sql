CREATE VIEW EntidadRegulatoria.vwfa_nota_credito
AS
SELECT        dbo.fa_notaCreDeb.IdEmpresa, dbo.fa_notaCreDeb.IdSucursal, dbo.fa_notaCreDeb.IdBodega, dbo.fa_notaCreDeb.IdNota, dbo.fa_notaCreDeb.dev_IdEmpresa, dbo.fa_notaCreDeb.dev_IdDev_Inven, dbo.fa_notaCreDeb.CodNota, 
                         dbo.fa_notaCreDeb.CreDeb, dbo.fa_notaCreDeb.CodDocumentoTipo, dbo.fa_notaCreDeb.Serie1, dbo.fa_notaCreDeb.Serie2, dbo.fa_notaCreDeb.NumNota_Impresa, dbo.fa_notaCreDeb.NumAutorizacion, 
                         dbo.fa_notaCreDeb.Fecha_Autorizacion, dbo.fa_cliente_contactos.Nombres, dbo.fa_cliente_contactos.Telefono, dbo.fa_cliente_contactos.Celular, dbo.fa_cliente_contactos.Correo, dbo.tb_persona.pe_Naturaleza, 
                         dbo.tb_persona.pe_cedulaRuc, dbo.tb_persona.IdTipoDocumento, dbo.tb_persona.pe_nombreCompleto, dbo.tb_persona.pe_razonSocial
FROM            dbo.fa_notaCreDeb INNER JOIN
                         dbo.fa_cliente_contactos ON dbo.fa_notaCreDeb.IdEmpresa = dbo.fa_cliente_contactos.IdEmpresa AND dbo.fa_notaCreDeb.IdCliente = dbo.fa_cliente_contactos.IdCliente AND 
                         dbo.fa_notaCreDeb.IdContacto = dbo.fa_cliente_contactos.IdContacto INNER JOIN
                         dbo.fa_cliente ON dbo.fa_cliente_contactos.IdEmpresa = dbo.fa_cliente.IdEmpresa AND dbo.fa_cliente_contactos.IdCliente = dbo.fa_cliente.IdCliente INNER JOIN
                         dbo.tb_persona ON dbo.fa_cliente.IdPersona = dbo.tb_persona.IdPersona
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'EntidadRegulatoria', @level1type = N'VIEW', @level1name = N'vwfa_nota_credito';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N' 1350
      End
   End
End
', @level0type = N'SCHEMA', @level0name = N'EntidadRegulatoria', @level1type = N'VIEW', @level1name = N'vwfa_nota_credito';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[45] 4[5] 2[5] 3) )"
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
         Begin Table = "fa_notaCreDeb"
            Begin Extent = 
               Top = 6
               Left = 0
               Bottom = 403
               Right = 198
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "fa_cliente"
            Begin Extent = 
               Top = 0
               Left = 540
               Bottom = 338
               Right = 756
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "fa_cliente_contactos"
            Begin Extent = 
               Top = 0
               Left = 283
               Bottom = 395
               Right = 453
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tb_persona"
            Begin Extent = 
               Top = 0
               Left = 803
               Bottom = 399
               Right = 1035
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
         Or =', @level0type = N'SCHEMA', @level0name = N'EntidadRegulatoria', @level1type = N'VIEW', @level1name = N'vwfa_nota_credito';

