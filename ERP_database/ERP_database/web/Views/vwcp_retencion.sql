CREATE VIEW web.vwcp_retencion
AS

SELECT        dbo.cp_retencion.IdEmpresa, dbo.cp_retencion.IdRetencion, dbo.cp_retencion.CodDocumentoTipo, dbo.cp_retencion.serie1, dbo.cp_retencion.serie2, dbo.cp_retencion.NumRetencion, dbo.cp_retencion.NAutorizacion, 
                         dbo.cp_retencion.Fecha_Autorizacion, dbo.cp_retencion.fecha, dbo.cp_retencion.observacion, dbo.cp_retencion.re_Tiene_RTiva, dbo.cp_orden_giro.co_serie, dbo.cp_orden_giro.co_factura, dbo.cp_orden_giro.co_subtotal_iva, 
                         dbo.cp_orden_giro.co_subtotal_siniva, dbo.cp_orden_giro.co_baseImponible, dbo.cp_orden_giro.co_valoriva, dbo.tb_persona.pe_apellido, dbo.tb_persona.pe_nombre, dbo.tb_persona.pe_razonSocial, 
                         dbo.cp_retencion.re_Tiene_RFuente, dbo.cp_retencion_x_ct_cbtecble.ct_IdTipoCbte, dbo.cp_retencion_x_ct_cbtecble.ct_IdCbteCble, dbo.cp_proveedor.IdProveedor, dbo.cp_retencion.Estado, 
                         dbo.tb_persona.pe_nombreCompleto
FROM            dbo.cp_retencion INNER JOIN
                         dbo.cp_orden_giro ON dbo.cp_retencion.IdEmpresa_Ogiro = dbo.cp_orden_giro.IdEmpresa AND dbo.cp_retencion.IdCbteCble_Ogiro = dbo.cp_orden_giro.IdCbteCble_Ogiro AND 
                         dbo.cp_retencion.IdTipoCbte_Ogiro = dbo.cp_orden_giro.IdTipoCbte_Ogiro INNER JOIN
                         dbo.cp_proveedor ON dbo.cp_orden_giro.IdEmpresa = dbo.cp_proveedor.IdEmpresa AND dbo.cp_orden_giro.IdProveedor = dbo.cp_proveedor.IdProveedor INNER JOIN
                         dbo.tb_persona ON dbo.cp_proveedor.IdPersona = dbo.tb_persona.IdPersona LEFT OUTER JOIN
                         dbo.cp_retencion_x_ct_cbtecble ON dbo.cp_retencion.IdEmpresa = dbo.cp_retencion_x_ct_cbtecble.rt_IdEmpresa AND dbo.cp_retencion.IdRetencion = dbo.cp_retencion_x_ct_cbtecble.rt_IdRetencion