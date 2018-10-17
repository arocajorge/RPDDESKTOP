﻿CREATE VIEW EntidadRegulatoria.vwfa_factura
AS
SELECT        factura.IdEmpresa, factura.IdSucursal, factura.IdBodega, factura.IdCbteVta, factura.vt_serie1, factura.vt_serie2, factura.vt_NumFactura, factura.vt_fecha, factura.pe_Naturaleza, factura.IdTipoDocumento, factura.pe_cedulaRuc, 
                         factura.Nombres, factura.Telefono, factura.Celular, factura.Correo, factura.Direccion, factura.RazonSocial, factura.NombreComercial, factura.ContribuyenteEspecial, factura.ObligadoAllevarConta, factura.em_ruc, 
                         factura.em_direccion, factura.nom_FormaPago, '20' AS IdFormaPago, factura.Dias_Vct, factura_detalle.Base_imponible, factura_detalle.impuesto, factura_detalle.totalDescuento, factura_detalle.total_sin_impuesto, 
                         factura_detalle.importeTotal, factura.Direccion AS Expr1, factura.em_direccion AS Expr2, factura.em_telefonos
FROM            (SELECT        fac.IdEmpresa, fac.IdSucursal, fac.IdBodega, fac.IdCbteVta, fac.vt_serie1, fac.vt_serie2, fac.vt_NumFactura, fac.vt_fecha, per.pe_Naturaleza, per.IdTipoDocumento, per.pe_cedulaRuc, cl_cont.Nombres, 
                                                    cl_cont.Telefono, cl_cont.Celular, cl_cont.Correo, cl_cont.Direccion, emp.RazonSocial, emp.NombreComercial, emp.ContribuyenteEspecial, emp.ObligadoAllevarConta, emp.em_ruc, emp.em_direccion, 
                                                    dbo.fa_formaPago.nom_FormaPago, dbo.fa_formaPago.IdFormaPago, dbo.fa_TerminoPago.Dias_Vct, emp.em_telefonos
                          FROM            dbo.fa_cliente_contactos AS cl_cont INNER JOIN
                                                    dbo.fa_factura AS fac ON cl_cont.IdEmpresa = fac.IdEmpresa AND cl_cont.IdCliente = fac.IdCliente AND cl_cont.IdContacto = fac.IdContacto INNER JOIN
                                                    dbo.tb_persona AS per INNER JOIN
                                                    dbo.fa_cliente AS cli ON per.IdPersona = cli.IdPersona ON cl_cont.IdEmpresa = cli.IdEmpresa AND cl_cont.IdCliente = cli.IdCliente INNER JOIN
                                                    dbo.tb_empresa AS emp ON cli.IdEmpresa = emp.IdEmpresa INNER JOIN
                                                    dbo.fa_factura_x_formaPago ON fac.IdEmpresa = dbo.fa_factura_x_formaPago.IdEmpresa AND fac.IdSucursal = dbo.fa_factura_x_formaPago.IdSucursal AND 
                                                    fac.IdBodega = dbo.fa_factura_x_formaPago.IdBodega AND fac.IdCbteVta = dbo.fa_factura_x_formaPago.IdCbteVta INNER JOIN
                                                    dbo.fa_formaPago ON dbo.fa_factura_x_formaPago.IdFormaPago = dbo.fa_formaPago.IdFormaPago INNER JOIN
                                                    dbo.fa_TerminoPago ON cli.IdTipoCredito = dbo.fa_TerminoPago.IdTerminoPago AND fac.Estado = 'A' AND fac.aprobada_enviar_sri = 1 AND NOT EXISTS
                                                        (SELECT        ID_REGISTRO
                                                          FROM            EntidadRegulatoria.fa_elec_registros_generados
                                                          WHERE        (ID_REGISTRO = SUBSTRING(emp.em_nombre, 0, 4) + '-' + '-' + 'FAC' + '-' + fac.vt_serie1 + '-' + fac.vt_serie2 + '-' + fac.vt_NumFactura))) AS factura INNER JOIN
                             (SELECT        IdEmpresa, IdSucursal, IdBodega, IdCbteVta, CAST(SUM(vt_Subtotal) AS numeric(10, 2)) AS Base_imponible, CAST(SUM(vt_iva) AS numeric(10, 2)) AS impuesto, CAST(SUM(vt_DescUnitario) AS numeric(10, 2)) 
                                                         AS totalDescuento, CAST(SUM(vt_Subtotal) AS numeric(10, 2)) AS total_sin_impuesto, CAST(SUM(vt_total) AS numeric(10, 2)) AS importeTotal
                               FROM            dbo.fa_factura_det
                               GROUP BY IdEmpresa, IdSucursal, IdBodega, IdCbteVta) AS factura_detalle ON factura.IdEmpresa = factura_detalle.IdEmpresa AND factura.IdSucursal = factura_detalle.IdSucursal AND 
                         factura.IdBodega = factura_detalle.IdBodega AND factura.IdCbteVta = factura_detalle.IdCbteVta
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 1, @level0type = N'SCHEMA', @level0name = N'EntidadRegulatoria', @level1type = N'VIEW', @level1name = N'vwfa_factura';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[8] 4[5] 2[62] 3) )"
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
         Begin Table = "factura_detalle"
            Begin Extent = 
               Top = 0
               Left = 664
               Bottom = 194
               Right = 852
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "factura"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 245
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
', @level0type = N'SCHEMA', @level0name = N'EntidadRegulatoria', @level1type = N'VIEW', @level1name = N'vwfa_factura';











