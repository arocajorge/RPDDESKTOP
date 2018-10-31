
﻿CREATE VIEW web.vwcom_ordencompra_local
AS
SELECT        dbo.com_ordencompra_local.IdEmpresa, dbo.com_ordencompra_local.IdSucursal, dbo.com_ordencompra_local.IdOrdenCompra, dbo.com_ordencompra_local.IdProveedor, dbo.com_ordencompra_local.oc_NumDocumento, 
                         dbo.com_ordencompra_local.IdTerminoPago, dbo.com_ordencompra_local.oc_plazo, dbo.com_ordencompra_local.oc_fecha, dbo.com_ordencompra_local.oc_observacion, dbo.com_ordencompra_local.Estado, 
                         dbo.com_ordencompra_local.IdEstadoAprobacion_cat, dbo.com_ordencompra_local.co_fecha_aprobacion, dbo.com_ordencompra_local.IdUsuario_Aprueba, dbo.com_ordencompra_local.IdUsuario_Reprue, 
                         dbo.com_ordencompra_local.co_fechaReproba, dbo.com_ordencompra_local.MotivoReprobacion, dbo.com_ordencompra_local.IdDepartamento, dbo.com_ordencompra_local.IdMotivo, 
                         dbo.com_ordencompra_local.oc_fechaVencimiento, dbo.com_ordencompra_local.IdEstado_cierre, dbo.com_ordencompra_local.IdComprador, dbo.cp_proveedor.pr_codigo, dbo.tb_persona.pe_cedulaRuc, 
                         dbo.tb_persona.pe_nombreCompleto, dbo.seg_usuario.Nombre
FROM            dbo.com_comprador INNER JOIN
                         dbo.com_ordencompra_local ON dbo.com_comprador.IdEmpresa = dbo.com_ordencompra_local.IdEmpresa AND dbo.com_comprador.IdComprador = dbo.com_ordencompra_local.IdComprador INNER JOIN
                         dbo.cp_proveedor ON dbo.com_ordencompra_local.IdEmpresa = dbo.cp_proveedor.IdEmpresa AND dbo.com_ordencompra_local.IdProveedor = dbo.cp_proveedor.IdProveedor INNER JOIN
                         dbo.tb_persona ON dbo.cp_proveedor.IdPersona = dbo.tb_persona.IdPersona INNER JOIN
                         dbo.seg_usuario ON dbo.com_comprador.IdUsuario_com = dbo.seg_usuario.IdUsuario
GO