CREATE VIEW [web].[vwtb_comprobantes_no_autorizados]
	AS 

	SELECT        doc.IdEmpresa, 'FACT' Tipo_documento, doc.IdCbteVta, doc.vt_serie1, doc.vt_serie2, doc.vt_NumFactura DocumentoDoc, doc.vt_serie1 + '-' + doc.vt_serie2 + '' + doc.vt_NumFactura Documento, doc.vt_fecha, 
                         per.pe_nombreCompleto, doc.vt_Observacion
FROM            dbo.tb_persona AS per INNER JOIN
                         dbo.fa_cliente AS cont ON per.IdPersona = cont.IdPersona INNER JOIN
                         dbo.fa_factura AS doc ON cont.IdEmpresa = doc.IdEmpresa AND cont.IdCliente = doc.IdCliente AND doc.Estado = 'A' AND doc.esta_impresa = 0
UNION
SELECT        doc.IdEmpresa, 'RETEN', doc.IdRetencion, doc.serie1, doc.serie2, doc.NumRetencion Documento, doc.serie1 + '-' + doc.serie2 + '-' + doc.NumRetencion, doc.fecha, per.pe_nombreCompleto, doc.observacion
FROM            dbo.tb_persona AS per INNER JOIN
                         dbo.cp_proveedor AS cont ON per.IdPersona = cont.IdPersona INNER JOIN
                         dbo.cp_orden_giro AS fp ON cont.IdEmpresa = fp.IdEmpresa AND cont.IdProveedor = fp.IdProveedor INNER JOIN
                         dbo.cp_retencion AS doc ON fp.IdEmpresa = doc.IdEmpresa_Ogiro AND fp.IdCbteCble_Ogiro = doc.IdCbteCble_Ogiro AND fp.IdTipoCbte_Ogiro = doc.IdTipoCbte_Ogiro AND doc.Estado = 'A' AND doc.aprobada_enviar_sri = 1 AND 
                         doc.NumRetencion IS NOT NULL
UNION
SELECT        cont.IdEmpresa, 'NTCR', doc.IdNota, doc.Serie1, doc.Serie2, doc.NumNota_Impresa Documento, doc.Serie1 + '-' + doc.Serie2 + '-' + doc.NumNota_Impresa, doc.no_fecha, per.pe_nombreCompleto, doc.sc_observacion
FROM            dbo.tb_persona AS per INNER JOIN
                         dbo.fa_cliente AS cont ON per.IdPersona = cont.IdPersona INNER JOIN
                         dbo.fa_notaCreDeb AS doc ON cont.IdEmpresa = doc.IdEmpresa AND cont.IdCliente = doc.IdCliente AND doc.Estado = 'A' AND doc.aprobada_enviar_sri = 1 AND doc.NaturalezaNota = 'SRI'
UNION
SELECT        doc.IdEmpresa, 'GUIA', doc.IdGuiaRemision, doc.Serie1, doc.Serie2, doc.NumGuia_Preimpresa Documento, doc.Serie1 + '-' + doc.Serie2 + '' + doc.NumGuia_Preimpresa Documento, doc.gi_fecha, per.pe_nombreCompleto, 
                         doc.gi_Observacion
FROM            dbo.tb_persona AS per INNER JOIN
                         dbo.fa_cliente AS cont ON per.IdPersona = cont.IdPersona INNER JOIN
                         dbo.fa_guia_remision AS doc ON cont.IdEmpresa = doc.IdEmpresa AND cont.IdCliente = doc.IdCliente AND doc.Estado = 'A' AND doc.aprobada_enviar_sri = 1