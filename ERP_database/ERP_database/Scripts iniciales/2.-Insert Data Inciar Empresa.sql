/*
Plantilla de script posterior a la implementación							
--------------------------------------------------------------------------------------
 Este archivo contiene instrucciones de SQL que se anexarán al script de compilación.		
 Use la sintaxis de SQLCMD para incluir un archivo en el script posterior a la implementación.			
 Ejemplo:      :r .\miArchivo.sql								
 Use la sintaxis de SQLCMD para hacer referencia a una variable en el script posterior a la implementación.		
 Ejemplo:      :setvar TableName miTabla							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------


select * from tb_empresa

declare @IdEmpresa int
declare @nom_Empresa varchar(50)
set @IdEmpresa =1
set @nom_Empresa ='GLOBAL S.A'


if (@IdEmpresa=0 or @nom_Empresa='')
begin
	print 'no hay datos de empresa id y nombre'
	return 
end 


delete caj_parametro where IdEmpresa=@IdEmpresa
DELETE com_parametro WHERE IdEmpresa=@IdEmpresa
DELETE cp_parametros WHERE IdEmpresa=@IdEmpresa
delete Af_Parametros WHERE IdEmpresa=@IdEmpresa
delete fa_parametro WHERE IdEmpresa=@IdEmpresa
delete tb_sis_Documento_Tipo_x_Empresa WHERE IdEmpresa=@IdEmpresa
delete [tb_banco_procesos_bancarios_x_empresa]  WHERE IdEmpresa=@IdEmpresa

DELETE Af_Activo_fijo_tipo WHERE IdEmpresa=@IdEmpresa


delete com_Motivo_Orden_Compra WHERE IdEmpresa=@IdEmpresa

delete [dbo].[in_Marca] WHERE IdEmpresa=@IdEmpresa
delete [dbo].[in_Motivo_Inven] WHERE IdEmpresa=@IdEmpresa
delete [dbo].[in_presentacion] WHERE IdEmpresa=@IdEmpresa
delete [dbo].[in_ProductoTipo] WHERE IdEmpresa=@IdEmpresa


DELETE in_subgrupo WHERE IdEmpresa=@IdEmpresa
DELETE in_grupo WHERE IdEmpresa=@IdEmpresa
DELETE in_linea WHERE IdEmpresa=@IdEmpresa
DELETE in_categorias WHERE IdEmpresa=@IdEmpresa
DELETE in_Motivo_Inven WHERE IdEmpresa=@IdEmpresa



DELETE in_movi_inven_tipo WHERE IdEmpresa=@IdEmpresa

DELETE ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo WHERE IdEmpresa=@IdEmpresa
DELETE ba_tipo_nota WHERE IdEmpresa=@IdEmpresa
DELETE ba_TipoFlujo WHERE IdEmpresa=@IdEmpresa
delete ba_parametros WHERE IdEmpresa=@IdEmpresa


delete caj_Caja where IdEmpresa=@IdEmpresa



delete seg_Usuario_x_Empresa where IdEmpresa=@IdEmpresa
delete seg_Menu_x_Empresa_x_Usuario where IdEmpresa=@IdEmpresa
delete seg_Menu_x_Empresa where IdEmpresa=@IdEmpresa
--delete seg_usuario

DELETE ct_parametro where IdEmpresa=@IdEmpresa
delete ct_plancta_nivel where IdEmpresa=@IdEmpresa
delete ct_cbtecble_tipo where IdEmpresa=@IdEmpresa
delete ct_periodo where IdEmpresa=@IdEmpresa
delete ct_parametro where IdEmpresa=@IdEmpresa



delete cp_orden_pago_tipo_x_empresa where idempresa=@idempresa
delete cp_proveedor_clase where idempresa=@idempresa


delete fa_VendedorxSucursal where IdEmpresa=@IdEmpresa
delete fa_Vendedor where IdEmpresa=@IdEmpresa
delete fa_cliente_tipo where IdEmpresa=@IdEmpresa


delete tb_bodega where IdEmpresa=@IdEmpresa
delete tb_sucursal where IdEmpresa=@IdEmpresa
delete tb_empresa where IdEmpresa=@IdEmpresa

delete ro_nomina_tipo_liqui_orden where IdEmpresa=@IdEmpresa
delete ro_Nomina_Tipoliqui where IdEmpresa=@IdEmpresa
delete ro_Nomina_Tipo where IdEmpresa=@IdEmpresa
delete tb_sucursal where IdEmpresa=@IdEmpresa
delete ct_periodo where IdEmpresa=@IdEmpresa
delete tb_empresa where IdEmpresa=@IdEmpresa
delete ro_cargo where IdEmpresa=@IdEmpresa
INSERT INTO [dbo].[tb_empresa]
([IdEmpresa]	,[codigo]		,[em_nombre]	,[RazonSocial]		,[NombreComercial]		,[ContribuyenteEspecial]	,[ObligadoAllevarConta]
,[em_ruc]		,[em_gerente]	,[em_contador]  ,[em_rucContador]	,[em_telefonos]			,[em_fax]					,[em_notificacion]
,[em_direccion]	,[em_tel_int]	,[em_logo]		,[em_fondo]			,[em_fechaInicioContable],[Estado]					,[em_fechaInicioActividad])
VALUES
(@IdEmpresa				,'001'	,@nom_Empresa	,@nom_Empresa		,@nom_Empresa			,'N'						,'S'
,'0000000000000',''				,''				,'000000000000'		,''						,''							,''
,''				,''				,null			,null				,GETDATE()				,'A'						,GETDATE()
)						



INSERT INTO [dbo].[ba_tipo_nota]
		([IdEmpresa],[IdTipoNota],[Tipo],[Descripcion]	,[IdCtaCble],[IdCentroCosto],[Estado])
VALUES	(@IdEmpresa	,1			 ,'NDBA'	,'NO APLICA'	,NULL		,NULL			,'A')

INSERT INTO [dbo].[ba_tipo_nota]
		([IdEmpresa],[IdTipoNota],[Tipo],[Descripcion]	,[IdCtaCble],[IdCentroCosto],[Estado])
VALUES	(@IdEmpresa	,2			 ,'NCBA'	,'NO APLICA'	,NULL		,NULL			,'A')




---------------------------------


INSERT INTO [dbo].[tb_sucursal]
([IdEmpresa]			,[IdSucursal]	,[codigo]		,[Su_Descripcion]	,[Su_CodigoEstablecimiento],[Su_Ubicacion]		,[Su_Ruc] ,[Estado]
 ,[Su_JefeSucursal]		,[Su_Telefonos]	,[Su_Direccion] ,[IdUsuario]		,[Fecha_Transac]			,[IdUsuarioUltMod]	,[Fecha_UltMod]
 ,[IdUsuarioUltAnu]		 ,[Fecha_UltAnu],[nom_pc]       ,[ip]				,[MotiAnula]
 )
 values 
 (@IdEmpresa						,1				,'001'			,'MATRIZ'			,'001'						,''				,'0000000000000' ,'A'
 ,''					,''				,''				,''					,NULL						,NULL				,NULL
 ,NULL					,NULL			,NULL			,NULL				,NULL
 )


------------------------------------

 INSERT INTO [dbo].[tb_bodega]
([IdEmpresa]	,[IdSucursal]	,[IdBodega]							,[bo_Descripcion]	,[cod_punto_emision]	,[bo_manejaFacturacion]	,[bo_EsBodega]
,[IdUsuario]	,[Fecha_Transac],[IdUsuarioUltMod]					,[Fecha_UltMod]		,[IdUsuarioUltAnu]		,[Fecha_UltAnu]			,[nom_pc]
,[ip]			,[Estado]		,[IdEstadoAproba_x_Ing_Egr_Inven]   ,[IdCentroCosto]
)
values 
(
@IdEmpresa				,1				,1									,'Matriz'			,'001'					,'N'					,'S'
,null			,GETDATE()			,null								,null				,null					,null					,null
,null			,'A'			,NULL								,NULL
)

----------------------------- creacion de usuarios ------------------------------------------------------
---- se crea usuario admin



-----------------------------------------------------------------------------------------------------------




INSERT INTO [dbo].[seg_Menu_x_Empresa]
([IdEmpresa]	,[IdMenu]	,[Habilitado]	,[NombreAsambly_x_Emp]	,[NomFormulario_x_Emp])
SELECT        
@IdEmpresa		,IdMenu		,1				, nom_Asembly			,nom_Formulario
FROM            seg_Menu



----------------------------


INSERT INTO [dbo].[seg_Menu_x_Empresa_x_Usuario]
([IdEmpresa]	,[IdUsuario]	,[IdMenu]	,[Lectura]	,[Escritura]	,[Eliminacion])
SELECT        
@IdEmpresa		,'admin'		,IdMenu		,1			,1				,1
FROM            seg_Menu


---------------------------

INSERT INTO [dbo].[seg_Usuario_x_Empresa]
([IdUsuario],[IdEmpresa],[Observacion])
values
('admin'	,@IdEmpresa	,'')







----------------------------------------------------------------------------
----------------------------------------------------------------------------
-------------------------- BANCO ----------------------------------

INSERT INTO [dbo].[ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo]
([IdEmpresa]	,[CodTipoCbteBan]	,[IdTipoCbteCble]	,[IdTipoCbteCble_Anu]
,[IdCtaCble]	,[Tipo_DebCred]
)
SELECT        
@IdEmpresa		,CodTipoCbteBan		,1					,1
,NULL			,'D'
FROM            ba_Cbte_Ban_tipo

update ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo set IdTipoCbteCble=2 ,Tipo_DebCred ='C' ,IdTipoCbteCble_Anu=6 where CodTipoCbteBan='CHEQ'
update ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo set IdTipoCbteCble=3 ,Tipo_DebCred ='D' ,IdTipoCbteCble_Anu=6 where CodTipoCbteBan='DEPO'
update ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo set IdTipoCbteCble=4 ,Tipo_DebCred ='D' ,IdTipoCbteCble_Anu=6 where CodTipoCbteBan='NCBA'
update ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo set IdTipoCbteCble=5 ,Tipo_DebCred ='C' ,IdTipoCbteCble_Anu=6 where CodTipoCbteBan='NDBA'

--select * from ct_cbtecble_tipo


INSERT INTO [dbo].[ba_TipoFlujo]	
		([IdEmpresa]	,[IdTipoFlujo]	,[IdTipoFlujoPadre]	,[Descricion]	,[Estado])
VALUES	(@IdEmpresa		,1				,null				,'NO APLICA'	,'A')
           



INSERT INTO [dbo].[ba_parametros]
([IdEmpresa]	,[El_Diario_Contable_es_modificable]	,[CiudadDefaultParaCrearCheques],[IdUsuario])
VALUES
(@IdEmpresa		,1										,'09','sysadmin')



----------------------------------------------------------------------------
----------------------------------------------------------------------------
		   

---------------------------------------------------------------------
---------------------------------------------------------------------
------------------- parametros por contabilidad ---------------------


--tipo cbtecble
INSERT [dbo].[ct_cbtecble_tipo] (IdEmpresa, [IdTipoCbte], [CodTipoCbte], [tc_TipoCbte], [tc_Estado], [tc_Interno], [tc_Nemonico], [IdTipoCbte_Anul], [IdUsuario], [Fecha_Transac], [IdUsuarioUltMod], [Fecha_UltMod], [IdUsuarioUltAnu], [Fecha_UltAnu], [MotiAnula]) VALUES (@IdEmpresa ,1, N'CD        ', N'DIARIO CONTABLE                                   ', N'A', N'S', N'CD        ', 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[ct_cbtecble_tipo] (IdEmpresa,[IdTipoCbte], [CodTipoCbte], [tc_TipoCbte], [tc_Estado], [tc_Interno], [tc_Nemonico], [IdTipoCbte_Anul], [IdUsuario], [Fecha_Transac], [IdUsuarioUltMod], [Fecha_UltMod], [IdUsuarioUltAnu], [Fecha_UltAnu], [MotiAnula]) VALUES (@IdEmpresa ,2, N'CHE       ', N'CHEQUE                                            ', N'A', N'N', N'CH        ', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[ct_cbtecble_tipo] (IdEmpresa,[IdTipoCbte], [CodTipoCbte], [tc_TipoCbte], [tc_Estado], [tc_Interno], [tc_Nemonico], [IdTipoCbte_Anul], [IdUsuario], [Fecha_Transac], [IdUsuarioUltMod], [Fecha_UltMod], [IdUsuarioUltAnu], [Fecha_UltAnu], [MotiAnula]) VALUES (@IdEmpresa ,3, N'DEP       ', N'DEPOSITO                                          ', N'A', N'N', N'DEP       ', 3, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[ct_cbtecble_tipo] (IdEmpresa,[IdTipoCbte], [CodTipoCbte], [tc_TipoCbte], [tc_Estado], [tc_Interno], [tc_Nemonico], [IdTipoCbte_Anul], [IdUsuario], [Fecha_Transac], [IdUsuarioUltMod], [Fecha_UltMod], [IdUsuarioUltAnu], [Fecha_UltAnu], [MotiAnula]) VALUES (@IdEmpresa ,4, N'NCB       ', N'NOTA CREDITO BANCARIA                             ', N'A', N'N', N'NCB       ', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[ct_cbtecble_tipo] (IdEmpresa,[IdTipoCbte], [CodTipoCbte], [tc_TipoCbte], [tc_Estado], [tc_Interno], [tc_Nemonico], [IdTipoCbte_Anul], [IdUsuario], [Fecha_Transac], [IdUsuarioUltMod], [Fecha_UltMod], [IdUsuarioUltAnu], [Fecha_UltAnu], [MotiAnula]) VALUES (@IdEmpresa ,5, N'NDB       ', N'NOTA DEBITO BANCARIA                              ', N'A', N'N', N'NDB       ', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[ct_cbtecble_tipo] (IdEmpresa,[IdTipoCbte], [CodTipoCbte], [tc_TipoCbte], [tc_Estado], [tc_Interno], [tc_Nemonico], [IdTipoCbte_Anul], [IdUsuario], [Fecha_Transac], [IdUsuarioUltMod], [Fecha_UltMod], [IdUsuarioUltAnu], [Fecha_UltAnu], [MotiAnula]) VALUES (@IdEmpresa ,6, N'ABAN      ', N'ANULACIONES BANCARIAS                             ', N'A', N'N', N'ABA       ', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[ct_cbtecble_tipo] (IdEmpresa,[IdTipoCbte], [CodTipoCbte], [tc_TipoCbte], [tc_Estado], [tc_Interno], [tc_Nemonico], [IdTipoCbte_Anul], [IdUsuario], [Fecha_Transac], [IdUsuarioUltMod], [Fecha_UltMod], [IdUsuarioUltAnu], [Fecha_UltAnu], [MotiAnula]) VALUES (@IdEmpresa ,7, N'CTCXP     ', N'COMPROBANTE DE PROVEEDOR                          ', N'A', N'N', N'CCP       ', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[ct_cbtecble_tipo] (IdEmpresa,[IdTipoCbte], [CodTipoCbte], [tc_TipoCbte], [tc_Estado], [tc_Interno], [tc_Nemonico], [IdTipoCbte_Anul], [IdUsuario], [Fecha_Transac], [IdUsuarioUltMod], [Fecha_UltMod], [IdUsuarioUltAnu], [Fecha_UltAnu], [MotiAnula]) VALUES (@IdEmpresa ,8, N'ACTCXP    ', N'ANULACION  COMPROBANTE PROVEEDOR                  ', N'A', N'N', N'ACP       ', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[ct_cbtecble_tipo] (IdEmpresa,[IdTipoCbte], [CodTipoCbte], [tc_TipoCbte], [tc_Estado], [tc_Interno], [tc_Nemonico], [IdTipoCbte_Anul], [IdUsuario], [Fecha_Transac], [IdUsuarioUltMod], [Fecha_UltMod], [IdUsuarioUltAnu], [Fecha_UltAnu], [MotiAnula]) VALUES (@IdEmpresa ,9, N'NCCP      ', N'NOTA CREDITO POR PAGAR                            ', N'A', N'N', N'NCP       ', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[ct_cbtecble_tipo] (IdEmpresa,[IdTipoCbte], [CodTipoCbte], [tc_TipoCbte], [tc_Estado], [tc_Interno], [tc_Nemonico], [IdTipoCbte_Anul], [IdUsuario], [Fecha_Transac], [IdUsuarioUltMod], [Fecha_UltMod], [IdUsuarioUltAnu], [Fecha_UltAnu], [MotiAnula]) VALUES (@IdEmpresa ,10, N'NDCXP     ', N'NOTA DEBITO POR PAGAR                             ', N'A', N'N', N'NDP       ', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[ct_cbtecble_tipo] (IdEmpresa,[IdTipoCbte], [CodTipoCbte], [tc_TipoCbte], [tc_Estado], [tc_Interno], [tc_Nemonico], [IdTipoCbte_Anul], [IdUsuario], [Fecha_Transac], [IdUsuarioUltMod], [Fecha_UltMod], [IdUsuarioUltAnu], [Fecha_UltAnu], [MotiAnula]) VALUES (@IdEmpresa ,11, N'PFXP      ', N'PROVISION FACTURA X PAGAR                         ', N'A', N'N', N'PF        ', NULL, NULL, NULL, NULL, NULL, N'', CAST(N'2015-11-10 11:28:31.377' AS Date), N'')
INSERT [dbo].[ct_cbtecble_tipo] (IdEmpresa,[IdTipoCbte], [CodTipoCbte], [tc_TipoCbte], [tc_Estado], [tc_Interno], [tc_Nemonico], [IdTipoCbte_Anul], [IdUsuario], [Fecha_Transac], [IdUsuarioUltMod], [Fecha_UltMod], [IdUsuarioUltAnu], [Fecha_UltAnu], [MotiAnula]) VALUES (@IdEmpresa ,12, N'AJCXP     ', N'AJUSTE DE CTAS. X  PAGAR                          ', N'A', N'N', N'PP        ', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[ct_cbtecble_tipo] (IdEmpresa,[IdTipoCbte], [CodTipoCbte], [tc_TipoCbte], [tc_Estado], [tc_Interno], [tc_Nemonico], [IdTipoCbte_Anul], [IdUsuario], [Fecha_Transac], [IdUsuarioUltMod], [Fecha_UltMod], [IdUsuarioUltAnu], [Fecha_UltAnu], [MotiAnula]) VALUES (@IdEmpresa ,13, N'ANCCXP    ', N'ANULACION CXP  N/C N/D                            ', N'A', N'N', N'ANC       ', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[ct_cbtecble_tipo] (IdEmpresa,[IdTipoCbte], [CodTipoCbte], [tc_TipoCbte], [tc_Estado], [tc_Interno], [tc_Nemonico], [IdTipoCbte_Anul], [IdUsuario], [Fecha_Transac], [IdUsuarioUltMod], [Fecha_UltMod], [IdUsuarioUltAnu], [Fecha_UltAnu], [MotiAnula]) VALUES (@IdEmpresa ,14, N'RTXPRV    ', N'RETENCION POR PROVEEDOR                           ', N'A', N'N', N'RPV       ', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[ct_cbtecble_tipo] (IdEmpresa,[IdTipoCbte], [CodTipoCbte], [tc_TipoCbte], [tc_Estado], [tc_Interno], [tc_Nemonico], [IdTipoCbte_Anul], [IdUsuario], [Fecha_Transac], [IdUsuarioUltMod], [Fecha_UltMod], [IdUsuarioUltAnu], [Fecha_UltAnu], [MotiAnula]) VALUES (@IdEmpresa ,15, N'ARTXPR    ', N'ANULACION RETENCION POR PROVEEDOR                 ', N'A', N'N', N'ARP       ', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[ct_cbtecble_tipo] (IdEmpresa,[IdTipoCbte], [CodTipoCbte], [tc_TipoCbte], [tc_Estado], [tc_Interno], [tc_Nemonico], [IdTipoCbte_Anul], [IdUsuario], [Fecha_Transac], [IdUsuarioUltMod], [Fecha_UltMod], [IdUsuarioUltAnu], [Fecha_UltAnu], [MotiAnula]) VALUES (@IdEmpresa ,16, N'CPANT     ', N'CONCILIACION X CXP                                ', N'A', N'N', N'CANT      ', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[ct_cbtecble_tipo] (IdEmpresa,[IdTipoCbte], [CodTipoCbte], [tc_TipoCbte], [tc_Estado], [tc_Interno], [tc_Nemonico], [IdTipoCbte_Anul], [IdUsuario], [Fecha_Transac], [IdUsuarioUltMod], [Fecha_UltMod], [IdUsuarioUltAnu], [Fecha_UltAnu], [MotiAnula]) VALUES (@IdEmpresa ,17, N'CTOP      ', N'COMPROBANTE ORDEN DE PAGO                         ', N'A', N'N', N'COP       ', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[ct_cbtecble_tipo] (IdEmpresa,[IdTipoCbte], [CodTipoCbte], [tc_TipoCbte], [tc_Estado], [tc_Interno], [tc_Nemonico], [IdTipoCbte_Anul], [IdUsuario], [Fecha_Transac], [IdUsuarioUltMod], [Fecha_UltMod], [IdUsuarioUltAnu], [Fecha_UltAnu], [MotiAnula]) VALUES (@IdEmpresa ,18, N'ANUOP     ', N'ANULACION ORDEN PAGO                              ', N'A', N'N', N'AOP       ', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[ct_cbtecble_tipo] (IdEmpresa,[IdTipoCbte], [CodTipoCbte], [tc_TipoCbte], [tc_Estado], [tc_Interno], [tc_Nemonico], [IdTipoCbte_Anul], [IdUsuario], [Fecha_Transac], [IdUsuarioUltMod], [Fecha_UltMod], [IdUsuarioUltAnu], [Fecha_UltAnu], [MotiAnula]) VALUES (@IdEmpresa ,19, N'CVTA      ', N'COMPROBANTE DE VENTA X CLIENTE                    ', N'A', N'N', N'CV        ', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[ct_cbtecble_tipo] (IdEmpresa,[IdTipoCbte], [CodTipoCbte], [tc_TipoCbte], [tc_Estado], [tc_Interno], [tc_Nemonico], [IdTipoCbte_Anul], [IdUsuario], [Fecha_Transac], [IdUsuarioUltMod], [Fecha_UltMod], [IdUsuarioUltAnu], [Fecha_UltAnu], [MotiAnula]) VALUES (@IdEmpresa ,20, N'N/C       ', N'NOTAS DE CREDITO X CLIENTE                        ', N'A', N'N', N'N/C       ', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[ct_cbtecble_tipo] (IdEmpresa,[IdTipoCbte], [CodTipoCbte], [tc_TipoCbte], [tc_Estado], [tc_Interno], [tc_Nemonico], [IdTipoCbte_Anul], [IdUsuario], [Fecha_Transac], [IdUsuarioUltMod], [Fecha_UltMod], [IdUsuarioUltAnu], [Fecha_UltAnu], [MotiAnula]) VALUES (@IdEmpresa ,21, N'N/D       ', N'NOTAS DE DEBITO X CLIENTE                         ', N'A', N'N', N'N/D       ', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[ct_cbtecble_tipo] (IdEmpresa,[IdTipoCbte], [CodTipoCbte], [tc_TipoCbte], [tc_Estado], [tc_Interno], [tc_Nemonico], [IdTipoCbte_Anul], [IdUsuario], [Fecha_Transac], [IdUsuarioUltMod], [Fecha_UltMod], [IdUsuarioUltAnu], [Fecha_UltAnu], [MotiAnula]) VALUES (@IdEmpresa ,22, N'AVTANCD   ', N'ANULACION DE CBTES VTA/NC/ND CLIENTE              ', N'A', N'N', N'AN/D      ', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[ct_cbtecble_tipo] (IdEmpresa,[IdTipoCbte], [CodTipoCbte], [tc_TipoCbte], [tc_Estado], [tc_Interno], [tc_Nemonico], [IdTipoCbte_Anul], [IdUsuario], [Fecha_Transac], [IdUsuarioUltMod], [Fecha_UltMod], [IdUsuarioUltAnu], [Fecha_UltAnu], [MotiAnula]) VALUES (@IdEmpresa ,23, N'INGCAJ    ', N'INGRESO CAJA                                      ', N'A', N'N', N'ICJ       ', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[ct_cbtecble_tipo] (IdEmpresa,[IdTipoCbte], [CodTipoCbte], [tc_TipoCbte], [tc_Estado], [tc_Interno], [tc_Nemonico], [IdTipoCbte_Anul], [IdUsuario], [Fecha_Transac], [IdUsuarioUltMod], [Fecha_UltMod], [IdUsuarioUltAnu], [Fecha_UltAnu], [MotiAnula]) VALUES (@IdEmpresa ,24, N'EGRCAJ    ', N'EGRESO CAJA                                       ', N'A', N'N', N'ECJ       ', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[ct_cbtecble_tipo] (IdEmpresa,[IdTipoCbte], [CodTipoCbte], [tc_TipoCbte], [tc_Estado], [tc_Interno], [tc_Nemonico], [IdTipoCbte_Anul], [IdUsuario], [Fecha_Transac], [IdUsuarioUltMod], [Fecha_UltMod], [IdUsuarioUltAnu], [Fecha_UltAnu], [MotiAnula]) VALUES (@IdEmpresa ,25, N'AIECAJ    ', N'ANULACION ING/EGR CAJA                            ', N'A', N'N', N'ACJ       ', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[ct_cbtecble_tipo] (IdEmpresa,[IdTipoCbte], [CodTipoCbte], [tc_TipoCbte], [tc_Estado], [tc_Interno], [tc_Nemonico], [IdTipoCbte_Anul], [IdUsuario], [Fecha_Transac], [IdUsuarioUltMod], [Fecha_UltMod], [IdUsuarioUltAnu], [Fecha_UltAnu], [MotiAnula]) VALUES (@IdEmpresa ,26, N'IMP       ', N'IMPORTACIONES                                     ', N'A', N'N', N'IMP       ', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[ct_cbtecble_tipo] (IdEmpresa,[IdTipoCbte], [CodTipoCbte], [tc_TipoCbte], [tc_Estado], [tc_Interno], [tc_Nemonico], [IdTipoCbte_Anul], [IdUsuario], [Fecha_Transac], [IdUsuarioUltMod], [Fecha_UltMod], [IdUsuarioUltAnu], [Fecha_UltAnu], [MotiAnula]) VALUES (@IdEmpresa ,27, N'AIMP      ', N'ANULACION IMPORTACIONES                           ', N'A', N'N', N'AIM       ', 7, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[ct_cbtecble_tipo] (IdEmpresa,[IdTipoCbte], [CodTipoCbte], [tc_TipoCbte], [tc_Estado], [tc_Interno], [tc_Nemonico], [IdTipoCbte_Anul], [IdUsuario], [Fecha_Transac], [IdUsuarioUltMod], [Fecha_UltMod], [IdUsuarioUltAnu], [Fecha_UltAnu], [MotiAnula]) VALUES (@IdEmpresa ,28, N'COMPR     ', N'COMPRAS                                           ', N'A', N'N', N'CMP       ', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[ct_cbtecble_tipo] (IdEmpresa,[IdTipoCbte], [CodTipoCbte], [tc_TipoCbte], [tc_Estado], [tc_Interno], [tc_Nemonico], [IdTipoCbte_Anul], [IdUsuario], [Fecha_Transac], [IdUsuarioUltMod], [Fecha_UltMod], [IdUsuarioUltAnu], [Fecha_UltAnu], [MotiAnula]) VALUES (@IdEmpresa ,29, N'COMPR     ', N'ANULACION DE COMPRAS                              ', N'A', N'N', N'CMP       ', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[ct_cbtecble_tipo] (IdEmpresa,[IdTipoCbte], [CodTipoCbte], [tc_TipoCbte], [tc_Estado], [tc_Interno], [tc_Nemonico], [IdTipoCbte_Anul], [IdUsuario], [Fecha_Transac], [IdUsuarioUltMod], [Fecha_UltMod], [IdUsuarioUltAnu], [Fecha_UltAnu], [MotiAnula]) VALUES (@IdEmpresa ,30, N'SI        ', N'SALDO INICIAL                                     ', N'A', N'S', N'SIN       ', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[ct_cbtecble_tipo] (IdEmpresa,[IdTipoCbte], [CodTipoCbte], [tc_TipoCbte], [tc_Estado], [tc_Interno], [tc_Nemonico], [IdTipoCbte_Anul], [IdUsuario], [Fecha_Transac], [IdUsuarioUltMod], [Fecha_UltMod], [IdUsuarioUltAnu], [Fecha_UltAnu], [MotiAnula]) VALUES (@IdEmpresa ,31, N'CM        ', N'CIERRE DE MES                                     ', N'A', N'N', N'CM        ', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[ct_cbtecble_tipo] (IdEmpresa,[IdTipoCbte], [CodTipoCbte], [tc_TipoCbte], [tc_Estado], [tc_Interno], [tc_Nemonico], [IdTipoCbte_Anul], [IdUsuario], [Fecha_Transac], [IdUsuarioUltMod], [Fecha_UltMod], [IdUsuarioUltAnu], [Fecha_UltAnu], [MotiAnula]) VALUES (@IdEmpresa ,32, N'RP        ', N'ROL DE PAGOS                                      ', N'A', N'N', N'RP        ', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)





insert into ct_parametro
(IdEmpresa,IdTipoCbte_SaldoInicial,IdTipoCbte_AsientoCierre_Anual )
values
(@IdEmpresa,1,1)



----------------------------------------------------------------
----------------------------------------------------------------
--------------- Periodo POR CONTABILIDAD ---------------

declare @W_Count int
declare @IdAnio_Actual int
declare @w_fechaIni Date
declare @w_fechaFin Date
declare @w_IdPeriodo int

set @IdAnio_Actual =  DATEPART(year, GETDATE()) 
set @w_fechaIni=cast( '01-01-' + cast(@IdAnio_Actual as varchar(4)) as Date)
set @w_fechaFin= DATEADD(month,1, @w_fechaIni)
set @w_fechaFin= DATEADD(DAY,-1, @w_fechaFin)

set @W_Count =1
set @w_IdPeriodo = (@IdAnio_Actual * 100)+@W_Count



while (@W_Count<=12)
begin

	insert into ct_periodo 
	(IdEmpresa	,IdPeriodo		,IdanioFiscal	,pe_mes		,pe_FechaIni	,pe_FechaFin	,pe_cerrado		,pe_estado)
	values
	(@IdEmpresa		   , @w_IdPeriodo	,@IdAnio_Actual ,@W_Count	,@w_fechaIni	,@w_fechaFin	,'N'			,'A')
	
	set @W_Count=@W_Count+1

	set @w_fechaIni=DATEADD(month,1,@w_fechaIni)
	set @w_fechaFin= DATEADD(month,1, @w_fechaIni)
	set @w_fechaFin= DATEADD(DAY,-1, @w_fechaFin)
	set @w_IdPeriodo = (@IdAnio_Actual * 100)+@W_Count


end 



----------------------------------------------------------------
--------------------------PARAMETRIZACION inventario -----------------

INSERT INTO [dbo].[in_movi_inven_tipo]  
		([IdEmpresa],[IdMovi_inven_tipo] ,[Codigo],[tm_descripcion] ,[cm_tipo_movi] ,[cm_interno] ,[cm_descripcionCorta] ,[Estado]	,[IdTipoCbte]	)
values	(@IdEmpresa	,1					,1			,'INGRESOS'		,'+'			,'N'		,'ING'					,'A'		,1)
INSERT INTO [dbo].[in_movi_inven_tipo]  
		([IdEmpresa],[IdMovi_inven_tipo] ,[Codigo],[tm_descripcion] ,[cm_tipo_movi] ,[cm_interno] ,[cm_descripcionCorta] ,[Estado]	,[IdTipoCbte]	)
values	(@IdEmpresa	,2					,1			,'EGRESOS'		,'-'			,'N'		,'EGR'					,'A'		,1)


INSERT INTO [dbo].[in_movi_inven_tipo]  
		([IdEmpresa],[IdMovi_inven_tipo] ,[Codigo],[tm_descripcion] ,[cm_tipo_movi] ,[cm_interno] ,[cm_descripcionCorta] ,[Estado]	,[IdTipoCbte]	)
values	(@IdEmpresa	,3					,3			,'INGRESOS x DEV. EN VTA'		,'+'			,'N'		,'IDV'					,'A'		,1)

INSERT INTO [dbo].[in_movi_inven_tipo]  
		([IdEmpresa],[IdMovi_inven_tipo] ,[Codigo],[tm_descripcion] ,[cm_tipo_movi] ,[cm_interno] ,[cm_descripcionCorta] ,[Estado]	,[IdTipoCbte]	)
values	(@IdEmpresa	,4					,4			,'INGRESOS x ANU DE FACTURAS'		,'+'			,'N'		,'IANF'					,'A'		,1)

INSERT INTO [dbo].[in_movi_inven_tipo]  
		([IdEmpresa],[IdMovi_inven_tipo] ,[Codigo],[tm_descripcion] ,[cm_tipo_movi] ,[cm_interno] ,[cm_descripcionCorta] ,[Estado]	,[IdTipoCbte]	)
values	(@IdEmpresa	,5				,5			,'INGRESOS x TRANSFERENCIAS'		,'+'			,'N'		,'IXTR'					,'A'		,1)


INSERT INTO [dbo].[in_movi_inven_tipo]  
		([IdEmpresa],[IdMovi_inven_tipo] ,[Codigo],[tm_descripcion] ,[cm_tipo_movi] ,[cm_interno] ,[cm_descripcionCorta] ,[Estado]	,[IdTipoCbte]	)
values	(@IdEmpresa	,6				,6			,'ANULACION DE EGRESOS'		,'-'			,'N'		,'AEG'					,'A'		,1)


INSERT INTO [dbo].[in_movi_inven_tipo]  
		([IdEmpresa],[IdMovi_inven_tipo] ,[Codigo],[tm_descripcion] ,[cm_tipo_movi] ,[cm_interno] ,[cm_descripcionCorta] ,[Estado]	,[IdTipoCbte]	)
values	(@IdEmpresa	,7				,7			,'EGRESOS x TRANSFERENCIAS'		,'-'			,'N'		,'ETR'					,'A'		,1)


INSERT INTO [dbo].[in_movi_inven_tipo]  
		([IdEmpresa],[IdMovi_inven_tipo] ,[Codigo],[tm_descripcion] ,[cm_tipo_movi] ,[cm_interno] ,[cm_descripcionCorta] ,[Estado]	,[IdTipoCbte]	)
values	(@IdEmpresa	,8				,8			,'ANULACION DE INGRESOS'		,'-'			,'N'		,'AING'					,'A'		,1)



INSERT INTO [dbo].[in_movi_inven_tipo]  
		([IdEmpresa],[IdMovi_inven_tipo] ,[Codigo],[tm_descripcion] ,[cm_tipo_movi] ,[cm_interno] ,[cm_descripcionCorta] ,[Estado]	,[IdTipoCbte]	)
values	(@IdEmpresa	,9				,9			,'EGRESO X FACTURA'		,'-'			,'N'		,'AING'					,'A'		,1)




INSERT INTO in_categorias
([IdEmpresa]	,[IdCategoria]	,[ca_Categoria]	,[IdCategoriaPadre]	,[ca_Posicion]	,[ca_indexIcono]	,[Estado]	,[ca_nivel],[IdUsuario]	,[Fecha_Transac],RutaPadre)
values
(@IdEmpresa					,'001'				,'No Disponible',null				,1				,0					,'A'		,1			,'sysadmin'			,GETDATE(),'')




INSERT INTO in_linea
([IdEmpresa]	,[IdCategoria]	,[IdLinea]	,[cod_linea]	,[nom_linea]	,[abreviatura]	,[observacion]	,[Estado]	,[IdUsuario]	,[Fecha_Transac])
values
(@IdEmpresa					,'001'			,'001'		,''				,'No Disponible',''				,''				,'A'		,'sysadmin'		,GETDATE()   )           




INSERT INTO in_grupo
([IdEmpresa]	,[IdCategoria]	,[IdLinea]	,[IdGrupo]	,[cod_grupo]	,[nom_grupo]	,[Estado]	,[abreviatura]	,[observacion]	,[IdUsuario]	,[Fecha_Transac])
values
(@IdEmpresa					,'001'			,'001'		,'001'		,'001'			,'No Disponible','A'		,''				,''				,'sysAdmin'		,GETDATE())


INSERT INTO [dbo].[in_subgrupo]
([IdEmpresa],[IdCategoria],[IdLinea],[IdGrupo],[IdSubgrupo],[abreviatura],[cod_subgrupo],[nom_subgrupo],[observacion],[Estado] ,[IdUsuario] ,[Fecha_Transac])
values
(@IdEmpresa				,'001'			,'001'	,'001'		,'001'		,''			,'001'			,'No Disponible',''			  ,'A'		,'sysadmin'	,GETDATE())
           


INSERT INTO [dbo].[in_Marca]
([IdEmpresa]	,[IdMarca]	,[Descripcion]		,[Estado]	,[IdUsuario]	,[Fecha_Transac])
values
(@IdEmpresa				,1			,'No Disponible'	,'A'		,'sysadmin'		,GETDATE())





INSERT INTO [dbo].[in_Motivo_Inven]
([IdEmpresa]			,[IdMotivo_Inv]	,[Cod_Motivo_Inv]	,[Desc_mov_inv]	,[Genera_Movi_Inven]	,[Genera_CXP]
,[Exigir_Punto_Cargo]	,[estado]		,[Fecha_Transac]	,[IdUsuarioUltMod]
,es_Inven_o_Consumo, Tipo_Ing_Egr)
values
(@IdEmpresa				,1				,1					,'Inventario'	,'N'				,'N'
,'N'					,'A'			,GETDATE()			,'sysadmin'
,'TIC_INVEN'			,'ING'
)


INSERT INTO [dbo].[in_Motivo_Inven]
([IdEmpresa]			,[IdMotivo_Inv]	,[Cod_Motivo_Inv]	,[Desc_mov_inv]	,[Genera_Movi_Inven]	,[Genera_CXP]
,[Exigir_Punto_Cargo]	,[estado]		,[Fecha_Transac]	,[IdUsuarioUltMod]
,es_Inven_o_Consumo, Tipo_Ing_Egr)
values
(@IdEmpresa				,2				,2					,'Inventario'	,'N'				,'N'
,'N'					,'A'			,GETDATE()			,'sysadmin'
,'TIC_INVEN'			,'EGR'
)




INSERT INTO [dbo].[in_presentacion]
([IdEmpresa]	,[IdPresentacion]	,[nom_presentacion]	,[estado])
values
(@IdEmpresa		,1					,'No Disponible'	,'A')



INSERT INTO [dbo].[in_ProductoTipo]
([IdEmpresa]	,[IdProductoTipo]	,[tp_descripcion]	,[tp_EsCombo]	,[tp_ManejaInven]
,[IdUsuario]	,[Fecha_Transac]	,[Estado]			,[EsMateriaPrima],[EsProductoTerminado]
)
values
(@IdEmpresa				,1					,'Bien'				,'N'			,'S'
,'sysadmin'		,GETDATE()			,'A'				,'N'			,'N'
)



INSERT INTO [dbo].[in_ProductoTipo]
([IdEmpresa]	,[IdProductoTipo]	,[tp_descripcion]	,[tp_EsCombo]	,[tp_ManejaInven]
,[IdUsuario]	,[Fecha_Transac]	,[Estado]			,[EsMateriaPrima],[EsProductoTerminado]
)
values
(@IdEmpresa				,2					,'Servicios'				,'N'			,'S'
,'sysadmin'		,GETDATE()			,'A'				,'N'			,'N'
)

/*

INSERT INTO [dbo].[in_parametro]
([IdEmpresa]								,[IdCentroCosto_Padre_a_cargar]			,[LabelCentroCosto]							,[IdMovi_inven_tipo_egresoBodegaOrigen]
,[IdMovi_inven_tipo_ingresoBodegaDestino]	,[Maneja_Stock_Negativo]				,[Usuario_Escoge_Motivo]					,[IdMovi_inven_tipo_egresoAjuste]	
,[IdMovi_inven_tipo_ingresoAjuste]			,[Mostrar_CentroCosto_en_transacciones]	,[Rango_Busqueda_Transacciones]				,[pa_EstadoInicial_Pedido]		
,[IdCtaCble_Inven]							,[IdCtaCble_CostoInven]					,[IdTipoCbte_CostoInven]					,[IdBodegaSuministro]			
,[IdCentro_Costo_Inventario]				,[IdCentro_Costo_Costo]					,[IdTipoCbte_CostoInven_Reverso]			,[IdMovi_Inven_tipo_x_anu_Ing]
,[IdMovi_Inven_tipo_x_anu_Egr]				,[IdMovi_Inven_tipo_Ing_Ajust_fis_x_defa],[IdMovi_Inven_tipo_Egr_Ajust_fis_x_defa]	,[ApruebaAjusteFisicoAuto]
,[IdSucursal_Suministro]					,[IdEstadoAproba_x_Ing]					,[IdEstadoAproba_x_Egr]						,[IdMovi_Inven_tipo_x_Dev_Inv_x_Ing]
,[IdMovi_Inven_tipo_x_Dev_Inv_x_Erg]
)
values
(
1											,null									,''											,1
,1											,'N'									,'S'										,1
,1											,'S'									,
)
*/


----------------------------------------------------------------


----------------------------------------------------------------
--------------------------PARAMETRIZACION CAJA -----------------




insert into caj_parametro 
(IdEmpresa	,IdTipoCbteCble_MoviCaja_Ing,IdTipoCbteCble_MoviCaja_Ing_Anu,IdTipoCbteCble_MoviCaja_Egr,IdTipoCbteCble_MoviCaja_Egr_Anu)
values
(@IdEmpresa	,1							,1								,1							,1)



INSERT INTO [dbo].[caj_Caja]
([IdEmpresa]	,[IdCaja]	,[IdSucursal]	,[ca_Codigo]	,[ca_Descripcion]	,[ca_Moneda]	,[IdUsuario]	,[Fecha_Transac],[Estado])
values
(@IdEmpresa		,1			,1				,'1'			,'CAJA GENERAL'		,'US$ DOLLAR $ ','sysadmin'		,GETDATE(),'A')


INSERT INTO [dbo].[caj_Caja]
([IdEmpresa]	,[IdCaja]	,[IdSucursal]	,[ca_Codigo]	,[ca_Descripcion]	,[ca_Moneda]	,[IdUsuario]	,[Fecha_Transac],[Estado])
values
(@IdEmpresa		,2			,1				,'1'			,'CAJA CHICA'		,'US$ DOLLAR $ ','sysadmin'		,GETDATE(),'A')



------------------------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------------------------

-------------------------------------- COMPRAS ------------------------------------------------------



INSERT INTO [dbo].[com_parametro]
([IdEmpresa]					,[IdEstadoAprobacion_OC]	,[IdMovi_inven_tipo_OC]	,[IdEstadoAnulacion_OC]	,[IdMovi_inven_tipo_dev_compra]	,[IdEstadoAprobacion_SolCompra]
,[IdSucursal_x_Aprob_x_SolComp]	,[IdEstado_cierre])
VALUES
(@IdEmpresa						,'xAPRO'					,1						,'ANULA'				,1								,'PEN_SOL'
,1								,'ABI')



INSERT INTO [dbo].[com_Motivo_Orden_Compra]
([IdEmpresa]	,[IdMotivo]	,[Cod_Motivo]	,[Descripcion]	,[estado]	,[Fecha_Transac]	,[IdUsuarioUltMod])
values
(@IdEmpresa				,1			,1				,'No Disponible','A'		,GETDATE()			,'sysadmin')



------------------------------------------------------------------------------------------------------------

-----------------------------  CUENTAS POR PAGAR ------------------------------------------------

--select * from [cp_parametros]

INSERT INTO [dbo].[cp_parametros]
([IdEmpresa]						,[pa_TipoCbte_OG]				,[pa_TipoCbte_OG_anulacion]		,[pa_ctacble_deudora]				,[pa_ctacble_iva]	
,[pa_ctacble_Proveedores_default]	,[pa_IdTipoCbte_x_Retencion]	,[pa_IdTipoCbte_x_Anu_Retencion],[IdTipoMoviCaja]					,[pa_TipoEgrMoviCaja_Conciliacion]	
,[IdUsuario]						
,[pa_TipoCbte_NC]					,[pa_TipoCbte_NC_anulacion]		,[pa_obligaOC]					,[pa_TipoCbte_ND]					,[pa_TipoCbte_ND_anulacion]
,[pa_xsd_de_atsSRI]					,[pa_Formulario103_104]			
,[pa_TipoCbte_para_conci_x_antcipo]	,[pa_ruta_descarga_xml_fac_elct]	,[pa_ctacble_x_RetIva_default]
,[pa_ctacble_x_RetFte_default]		
)
VALUES
(@IdEmpresa							,7								,8								,NULL								,NULL	
,NULL								,14								,15								,1									,1
,NULL
,9									,13								,'S'							,10									,13
,NULL								,NULL
,1									,'C:\\'							,NULL
,NULL
)




INSERT INTO [dbo].[cp_proveedor_clase]
([IdEmpresa]	,[IdClaseProveedor]	,[cod_clase_proveedor]	,[descripcion_clas_prove]	,[Estado]	,[IdUsuario]	,[FechaTransac])
VALUES
(@IdEmpresa		,1					,1						,'Provedores Locales '      ,'A'		,'sysAdmin'				,GETDATE()
)


INSERT INTO [dbo].[cp_orden_pago_tipo_x_empresa]
([IdEmpresa]	,[IdTipo_op]	,[IdCtaCble]	,[IdCentroCosto]	,[IdTipoCbte_OP]	,[IdTipoCbte_OP_anulacion]	,[IdEstadoAprobacion]	,[Buscar_FactxPagar])
SELECT         
@IdEmpresa		,IdTipo_op		,null			,null				,17					,18							,'APRO'					,'N'
FROM            cp_orden_pago_tipo

UPDATE [cp_orden_pago_tipo_x_empresa] set Buscar_FactxPagar='S'  where [IdEmpresa]=@IdEmpresa and [IdTipo_op]='FACT_PROVEE'

------------------------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------------------------



------------------------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------------------------
---------------------------------------- FACTURACION ------------------------------------




INSERT INTO fa_cliente_tipo
([IdEmpresa]	,[Idtipo_cliente]	,[Cod_cliente_tipo]		,[Descripcion_tip_cliente]	,[estado]	,[IdUsuario]	,[Fecha_Transac])
values
(@IdEmpresa		,1					,'1'					,'Clientes Locales'			,'A'		,'sysIni'		,GETDATE())



INSERT INTO fa_Vendedor
([IdEmpresa]	,[IdVendedor]	,[IdEmpleado]	,[Codigo]	,[Ve_Vendedor]	,[ve_cedula]	,[Ve_Comision],[Estado]
,[IdUsuario]	,[Fecha_Transac])
values
(@IdEmpresa		,1				,0				,1			,'No Disponible','0000000000000',0			,'A'
,'sysAdmin'				,GETDATE() )



INSERT INTO fa_VendedorxSucursal  
([IdEmpresa]	,[IdVendedor]	,[IdSucursal])
values 
(@IdEmpresa		,1				,1)

-- select * from in_movi_inven_tipo
-- SELECT * FROM fa_tiponota
-- select * from ct_cbtecble_tipo

--este insert tiene errores, hay que revisarlo

INSERT INTO fa_parametro
([IdEmpresa]								,[IdMovi_inven_tipo_Factura]				,[pa_porc_max_total_item_x_despa_Guia]	,[IdMovi_inven_tipo_Dev_Vta]	
,[IdMovi_inven_tipo_Factura_Anulacion]		,[IdMovi_inven_tipo_Dev_Vta_Anulacion]		,[Tipo_NC_x_DevVta]						,[IdDepartamento_x_DevVta]
,[IdTipoCbteCble_Factura]					,[IdTipoCbteCble_Factura_Reverso]			,[IdTipoCbteCble_Factura_Costo_VTA]		,[IdTipoCbteCble_Factura_Costo_VTA_Reverso]
,[IdTipoCbteCble_NC]						,[IdTipoCbteCble_NC_Reverso]				,[IdTipoCbteCble_ND]					,[IdTipoCbteCble_ND_Reverso]
,[SeImprimiGuiaRemiAuto]					,[NumeroDeItemFact]							,[TipoCobroDafaultFactu]				,[IdCaja_Default_Factura]
,[IdCtaCble_x_anticipo_cliente]				,[pa_IdTipoNota_NC_x_Anulacion]				,[IdEstadoAprobacion]					,[pa_ruta_descarga_xml_fac_elct]
,[File_Reporte_FacturaDiseño]				,[File_Reporte_Nota_CRED_DEB]				,[IdCtaCble_IVA]						,[IdCtaCble_SubTotal_Vtas_x_Default]
,[IdCtaCble_CXC_Vtas_x_Default]				,[pa_X_Defecto_la_factura_es_cbte_elect]	,[pa_X_Defecto_la_guia_es_cbte_elect]	,[pa_X_Defecto_la_ND_es_cbte_elect]
,[pa_X_Defecto_la_NC_es_cbte_elect])	
VALUES
(@IdEmpresa									,9											,100									,3
,4											,2											,1										,1
,19											,22											,1									    ,22
,20											,22											,21										,22
,'S'										,10											,null									,1
,NULL										,NULL										,NULL									,'C:\\'
,NULL										,NULL										,NULL									,NULL
,NULL										,NULL										,NULL									,NULL
,NULL)




------------------------------------------------------------------------
------------------------------------------------------------------------
----------------- ACTIVO FIJO -----------------------------------------

INSERT INTO [dbo].[Af_Parametros]
([IdEmpresa]					,[IdTipoCbte]				,[IdTipoCbteMejora]			,[IdTipoCbteBaja]				,[IdTipoCbteVenta]				,[IdTipoCbteRetiro]				
,[IdCtaCble_Activo]				,[IdCtaCble_Dep_Acum]		,[IdCtaCble_Gastos_Depre]	,[FormaContabiliza]				,[IdTipoCbteMejora_Anulacion]	,[IdTipoCbteBaja_Anulacion]	
,[IdTipoCbteVenta_Anulacion]	,[IdTipoCbteRetiro_Anulacion],[IdTipoCbteDep_Acum_Anulacion]
)
VALUES
(
@IdEmpresa						,1							,1							,1								,1								,1
,NULL							,NULL						,NULL						,'S'							,1								,1
,1								,1							,1
)


INSERT INTO [dbo].[Af_Activo_fijo_tipo]
([IdEmpresa]	,[IdActijoFijoTipo]	,[CodActivoFijo]	,[Af_Descripcion]		,[Af_Porcentaje_depre]	,[Af_anio_depreciacion]
,[IdUsuario]	,[Fecha_Transac]	,[Estado])
VALUES
(@IdEmpresa				,1					,1					,'VEHICULOS Y CAMIONES'	,20						,5
,'sysadmin'		,GETDATE()			,'A')


INSERT INTO [dbo].[Af_Activo_fijo_tipo]
([IdEmpresa]	,[IdActijoFijoTipo]	,[CodActivoFijo]	,[Af_Descripcion]		,[Af_Porcentaje_depre]	,[Af_anio_depreciacion]
,[IdUsuario]	,[Fecha_Transac]	,[Estado])
VALUES
(@IdEmpresa				,2					,2					,'EDIFICIOS Y TERRENOS'	,4						,25
,'sysadmin'		,GETDATE()			,'A')


INSERT INTO [dbo].[Af_Activo_fijo_tipo]
([IdEmpresa]	,[IdActijoFijoTipo]	,[CodActivoFijo]	,[Af_Descripcion]		,[Af_Porcentaje_depre]	,[Af_anio_depreciacion]
,[IdUsuario]	,[Fecha_Transac]	,[Estado])
VALUES
(@IdEmpresa				,3				,3					,'MUEBLES & ENSERES'	,25					,4
,'sysadmin'		,GETDATE()			,'A')







-----------------------------------------------------------------------
-----------------------------------------------------------------------
-----------------------------------------------------------------------



-------------------------------------------------
/*

INSERT INTO [dbo].[cxc_Parametro]
([IdEmpresa]							,[pa_tipoND_x_CheqProtestado]		,[pa_IdCaja_x_cobros_x_CXC]	,[pa_IdTipoMoviCaja_x_Cobros_x_cliente]	
,[pa_IdTipoCbteCble_CxC]				,[pa_IdTipoCbteCble_CxC_ANU]		
,[pa_IdCaja_x_Default]					,[pa_IdTipoCbte_x_conciliacion]		,[pa_IdCobro_tipo_Comision_TC])
values
(1										,1									,null						,1	
,1										,1									
,1										,1									,1)

*/



INSERT INTO [dbo].[tb_sis_Documento_Tipo_x_Empresa]
([IdEmpresa]		,[codDocumentoTipo]	,[ApareceComboFac_TipoFact]	,[ApareceComboFac_Import]
,[ApareceTalonario]	,[Descripcion]		,[Posicion]					,[ApareceCombo_FileReporte])
Select 
@IdEmpresa 			,codDocumentoTipo	,'S'							,'S'
,'S'				,''					,0								,'S'
from [dbo].[tb_sis_Documento_Tipo]


INSERT [dbo].[ro_Nomina_Tipo] ([IdEmpresa], [IdNomina_Tipo], [Descripcion], [IdUsuario], [IdUsuarioAnu], [MotivoAnu], [IdUsuarioUltModi], [FechaAnu], [FechaTransac], [FechaUltModi], [Estado]) VALUES (@IdEmpresa, 1, N'Mensual', N'admin', NULL, NULL, NULL, NULL, CAST(N'2016-12-08 00:00:00.000' AS DateTime), NULL, N'A')

INSERT [dbo].[ro_Nomina_Tipoliqui] ([IdEmpresa], [IdNomina_Tipo], [IdNomina_TipoLiqui], [DescripcionProcesoNomina], [IdUsuario], [IdUsuarioAnu], [MotivoAnu], [IdUsuarioUltModi], [FechaAnu], [FechaTransac], [FechaUltModi], [Estado]) VALUES (@IdEmpresa, 1, 1, N'Pago primera quincena', N'admin', NULL, N'', N'muruchima', NULL, CAST(N'2016-06-20 00:00:00.000' AS DateTime), CAST(N'2017-07-15 12:15:17.650' AS DateTime), N'A')
INSERT [dbo].[ro_Nomina_Tipoliqui] ([IdEmpresa], [IdNomina_Tipo], [IdNomina_TipoLiqui], [DescripcionProcesoNomina], [IdUsuario], [IdUsuarioAnu], [MotivoAnu], [IdUsuarioUltModi], [FechaAnu], [FechaTransac], [FechaUltModi], [Estado]) VALUES (@IdEmpresa, 1, 2, N'Pago segunda quincena', N'admin', NULL, N'', N'muruchima', NULL, CAST(N'2016-06-20 00:00:00.000' AS DateTime), CAST(N'2017-10-31 15:22:06.987' AS DateTime), N'A')
INSERT [dbo].[ro_Nomina_Tipoliqui] ([IdEmpresa], [IdNomina_Tipo], [IdNomina_TipoLiqui], [DescripcionProcesoNomina], [IdUsuario], [IdUsuarioAnu], [MotivoAnu], [IdUsuarioUltModi], [FechaAnu], [FechaTransac], [FechaUltModi], [Estado]) VALUES (@IdEmpresa, 1, 3, N'Pago decimo tercero', N'admin', NULL, N'', N'admin', NULL, CAST(N'2016-09-20 00:00:00.000' AS DateTime), CAST(N'2017-06-27 12:53:26.747' AS DateTime), N'A')
INSERT [dbo].[ro_Nomina_Tipoliqui] ([IdEmpresa], [IdNomina_Tipo], [IdNomina_TipoLiqui], [DescripcionProcesoNomina], [IdUsuario], [IdUsuarioAnu], [MotivoAnu], [IdUsuarioUltModi], [FechaAnu], [FechaTransac], [FechaUltModi], [Estado]) VALUES (@IdEmpresa, 1, 4, N'Pago decimo Cuarto', N'admin', NULL, N'', N'admin', NULL, CAST(N'2016-12-01 00:00:00.000' AS DateTime), CAST(N'2017-06-23 15:27:06.340' AS DateTime), N'A')
INSERT [dbo].[ro_Nomina_Tipoliqui] ([IdEmpresa], [IdNomina_Tipo], [IdNomina_TipoLiqui], [DescripcionProcesoNomina], [IdUsuario], [IdUsuarioAnu], [MotivoAnu], [IdUsuarioUltModi], [FechaAnu], [FechaTransac], [FechaUltModi], [Estado]) VALUES (@IdEmpresa, 1, 5, N'Reparto Utilidades', N'admin', NULL, N'', N'admin', NULL, CAST(N'2017-06-22 12:08:02.173' AS DateTime), CAST(N'2017-06-29 12:58:24.593' AS DateTime), N'A')
INSERT [dbo].[ro_Nomina_Tipoliqui] ([IdEmpresa], [IdNomina_Tipo], [IdNomina_TipoLiqui], [DescripcionProcesoNomina], [IdUsuario], [IdUsuarioAnu], [MotivoAnu], [IdUsuarioUltModi], [FechaAnu], [FechaTransac], [FechaUltModi], [Estado]) VALUES (@IdEmpresa, 1, 8, N'Bonificación', N'muruchima', NULL, N'', N'muruchima', NULL, CAST(N'2017-06-27 15:44:40.190' AS DateTime), CAST(N'2017-08-31 13:17:19.877' AS DateTime), N'A')

INSERT [dbo].[ro_nomina_tipo_liqui_orden] ([IdEmpresa], [IdNominaTipo], [IdNominaTipoLiqui], [Orden], [IdRubro], [Formula], [EsVisible], [Descripcion], [FechaIngresa], [UsuarioIngresa], [FechaModifica], [UsuarioModifica]) VALUES (@IdEmpresa, 1, 1, 0, N'1032', N'VALOR_VACACIONES()', 0, N'', CAST(N'2017-07-15 12:15:17.627' AS DateTime), N'muruchima', CAST(N'2017-07-15 12:15:17.630' AS DateTime), N'muruchima')
INSERT [dbo].[ro_nomina_tipo_liqui_orden] ([IdEmpresa], [IdNominaTipo], [IdNominaTipoLiqui], [Orden], [IdRubro], [Formula], [EsVisible], [Descripcion], [FechaIngresa], [UsuarioIngresa], [FechaModifica], [UsuarioModifica]) VALUES (@IdEmpresa, 1, 1, 1, N'100', N'DIAS_TRA_MENSUAL_RUBRO([XIV_SUELDO])', 0, N'', CAST(N'2017-07-15 12:15:17.630' AS DateTime), N'muruchima', CAST(N'2017-07-15 12:15:17.630' AS DateTime), N'muruchima')
INSERT [dbo].[ro_nomina_tipo_liqui_orden] ([IdEmpresa], [IdNominaTipo], [IdNominaTipoLiqui], [Orden], [IdRubro], [Formula], [EsVisible], [Descripcion], [FechaIngresa], [UsuarioIngresa], [FechaModifica], [UsuarioModifica]) VALUES (@IdEmpresa, 1, 1, 2, N'2', N'[DIAS_D14]', 1, N'', CAST(N'2017-07-15 12:15:17.630' AS DateTime), N'muruchima', CAST(N'2017-07-15 12:15:17.633' AS DateTime), N'muruchima')
INSERT [dbo].[ro_nomina_tipo_liqui_orden] ([IdEmpresa], [IdNominaTipo], [IdNominaTipoLiqui], [Orden], [IdRubro], [Formula], [EsVisible], [Descripcion], [FechaIngresa], [UsuarioIngresa], [FechaModifica], [UsuarioModifica]) VALUES (@IdEmpresa, 1, 1, 3, N'103', N'SUELDO_BASICO()', 1, N'', CAST(N'2017-07-15 12:15:17.633' AS DateTime), N'muruchima', CAST(N'2017-07-15 12:15:17.640' AS DateTime), N'muruchima')
INSERT [dbo].[ro_nomina_tipo_liqui_orden] ([IdEmpresa], [IdNominaTipo], [IdNominaTipoLiqui], [Orden], [IdRubro], [Formula], [EsVisible], [Descripcion], [FechaIngresa], [UsuarioIngresa], [FechaModifica], [UsuarioModifica]) VALUES (@IdEmpresa, 1, 1, 4, N'294', N'Round((([SUELDO_NETO]*0.5)/15*[DIASTRA]),2)', 1, N'', CAST(N'2017-07-15 12:15:17.643' AS DateTime), N'muruchima', CAST(N'2017-07-15 12:15:17.643' AS DateTime), N'muruchima')
INSERT [dbo].[ro_nomina_tipo_liqui_orden] ([IdEmpresa], [IdNominaTipo], [IdNominaTipoLiqui], [Orden], [IdRubro], [Formula], [EsVisible], [Descripcion], [FechaIngresa], [UsuarioIngresa], [FechaModifica], [UsuarioModifica]) VALUES (@IdEmpresa, 1, 1, 7, N'500', N'[ANT+]', 1, N'', CAST(N'2017-07-15 12:15:17.643' AS DateTime), N'muruchima', CAST(N'2017-07-15 12:15:17.647' AS DateTime), N'muruchima')
INSERT [dbo].[ro_nomina_tipo_liqui_orden] ([IdEmpresa], [IdNominaTipo], [IdNominaTipoLiqui], [Orden], [IdRubro], [Formula], [EsVisible], [Descripcion], [FechaIngresa], [UsuarioIngresa], [FechaModifica], [UsuarioModifica]) VALUES (@IdEmpresa, 1, 1, 50, N'1022', N'OBTENER_NOVEDAD()', 1, N'', CAST(N'2017-07-15 12:15:17.647' AS DateTime), N'muruchima', CAST(N'2017-07-15 12:15:17.647' AS DateTime), N'muruchima')
INSERT [dbo].[ro_nomina_tipo_liqui_orden] ([IdEmpresa], [IdNominaTipo], [IdNominaTipoLiqui], [Orden], [IdRubro], [Formula], [EsVisible], [Descripcion], [FechaIngresa], [UsuarioIngresa], [FechaModifica], [UsuarioModifica]) VALUES (@IdEmpresa, 1, 1, 100, N'900', N'[DANF]', 1, N'', CAST(N'2017-07-15 12:15:17.650' AS DateTime), N'muruchima', CAST(N'2017-07-15 12:15:17.650' AS DateTime), N'muruchima')
INSERT [dbo].[ro_nomina_tipo_liqui_orden] ([IdEmpresa], [IdNominaTipo], [IdNominaTipoLiqui], [Orden], [IdRubro], [Formula], [EsVisible], [Descripcion], [FechaIngresa], [UsuarioIngresa], [FechaModifica], [UsuarioModifica]) VALUES (@IdEmpresa, 1, 1, 300, N'950', N'[INGRESOS]-[EGRESOS]', 1, N'', CAST(N'2017-07-15 12:15:17.650' AS DateTime), N'muruchima', CAST(N'2017-07-15 12:15:17.650' AS DateTime), N'muruchima')
INSERT [dbo].[ro_nomina_tipo_liqui_orden] ([IdEmpresa], [IdNominaTipo], [IdNominaTipoLiqui], [Orden], [IdRubro], [Formula], [EsVisible], [Descripcion], [FechaIngresa], [UsuarioIngresa], [FechaModifica], [UsuarioModifica]) VALUES (@IdEmpresa, 1, 2, 0, N'1050', N'ESTADO_EMPLEADO()', 0, N'', CAST(N'2017-10-31 15:22:06.873' AS DateTime), N'muruchima', CAST(N'2017-10-31 15:22:06.873' AS DateTime), N'muruchima')
INSERT [dbo].[ro_nomina_tipo_liqui_orden] ([IdEmpresa], [IdNominaTipo], [IdNominaTipoLiqui], [Orden], [IdRubro], [Formula], [EsVisible], [Descripcion], [FechaIngresa], [UsuarioIngresa], [FechaModifica], [UsuarioModifica]) VALUES (@IdEmpresa, 1, 2, 1, N'103', N'SUELDO_BASICO()', 1, N'', CAST(N'2017-10-31 15:22:06.877' AS DateTime), N'muruchima', CAST(N'2017-10-31 15:22:06.877' AS DateTime), N'muruchima')
INSERT [dbo].[ro_nomina_tipo_liqui_orden] ([IdEmpresa], [IdNominaTipo], [IdNominaTipoLiqui], [Orden], [IdRubro], [Formula], [EsVisible], [Descripcion], [FechaIngresa], [UsuarioIngresa], [FechaModifica], [UsuarioModifica]) VALUES (@IdEmpresa, 1, 2, 2, N'976', N'DIAS_EFECTIVOS()', 1, N'', CAST(N'2017-10-31 15:22:06.877' AS DateTime), N'muruchima', CAST(N'2017-10-31 15:22:06.880' AS DateTime), N'muruchima')
INSERT [dbo].[ro_nomina_tipo_liqui_orden] ([IdEmpresa], [IdNominaTipo], [IdNominaTipoLiqui], [Orden], [IdRubro], [Formula], [EsVisible], [Descripcion], [FechaIngresa], [UsuarioIngresa], [FechaModifica], [UsuarioModifica]) VALUES (@IdEmpresa, 1, 2, 3, N'2', N'[DIAS_D14]', 1, N'', CAST(N'2017-10-31 15:22:06.880' AS DateTime), N'muruchima', CAST(N'2017-10-31 15:22:06.880' AS DateTime), N'muruchima')
INSERT [dbo].[ro_nomina_tipo_liqui_orden] ([IdEmpresa], [IdNominaTipo], [IdNominaTipoLiqui], [Orden], [IdRubro], [Formula], [EsVisible], [Descripcion], [FechaIngresa], [UsuarioIngresa], [FechaModifica], [UsuarioModifica]) VALUES (@IdEmpresa, 1, 2, 4, N'24', N'Round(  (Iif([DIAS_NOMI]>=28, ([SUELDO_NETO]/30)  * [DIASTRA]  , ([SUELDO_NETO]/30) *  [DIASTRA] )),2)', 1, N'', CAST(N'2017-10-31 15:22:06.880' AS DateTime), N'muruchima', CAST(N'2017-10-31 15:22:06.883' AS DateTime), N'muruchima')
INSERT [dbo].[ro_nomina_tipo_liqui_orden] ([IdEmpresa], [IdNominaTipo], [IdNominaTipoLiqui], [Orden], [IdRubro], [Formula], [EsVisible], [Descripcion], [FechaIngresa], [UsuarioIngresa], [FechaModifica], [UsuarioModifica]) VALUES (@IdEmpresa, 1, 2, 5, N'7', N'OBTENER_NOVEDAD()', 1, N'', CAST(N'2017-10-31 15:22:06.883' AS DateTime), N'muruchima', CAST(N'2017-10-31 15:22:06.883' AS DateTime), N'muruchima')
INSERT [dbo].[ro_nomina_tipo_liqui_orden] ([IdEmpresa], [IdNominaTipo], [IdNominaTipoLiqui], [Orden], [IdRubro], [Formula], [EsVisible], [Descripcion], [FechaIngresa], [UsuarioIngresa], [FechaModifica], [UsuarioModifica]) VALUES (@IdEmpresa, 1, 2, 6, N'8', N'OBTENER_NOVEDAD()', 1, N'', CAST(N'2017-10-31 15:22:06.883' AS DateTime), N'muruchima', CAST(N'2017-10-31 15:22:06.887' AS DateTime), N'muruchima')
INSERT [dbo].[ro_nomina_tipo_liqui_orden] ([IdEmpresa], [IdNominaTipo], [IdNominaTipoLiqui], [Orden], [IdRubro], [Formula], [EsVisible], [Descripcion], [FechaIngresa], [UsuarioIngresa], [FechaModifica], [UsuarioModifica]) VALUES (@IdEmpresa, 1, 2, 7, N'9', N'OBTENER_NOVEDAD()', 1, N'', CAST(N'2017-10-31 15:22:06.887' AS DateTime), N'muruchima', CAST(N'2017-10-31 15:22:06.887' AS DateTime), N'muruchima')
INSERT [dbo].[ro_nomina_tipo_liqui_orden] ([IdEmpresa], [IdNominaTipo], [IdNominaTipoLiqui], [Orden], [IdRubro], [Formula], [EsVisible], [Descripcion], [FechaIngresa], [UsuarioIngresa], [FechaModifica], [UsuarioModifica]) VALUES (@IdEmpresa, 1, 2, 8, N'966', N'[H_NOC_25] + [H_SOB_50] + [HSOBRE_100]', 1, N'', CAST(N'2017-10-31 15:22:06.890' AS DateTime), N'muruchima', CAST(N'2017-10-31 15:22:06.890' AS DateTime), N'muruchima')
INSERT [dbo].[ro_nomina_tipo_liqui_orden] ([IdEmpresa], [IdNominaTipo], [IdNominaTipoLiqui], [Orden], [IdRubro], [Formula], [EsVisible], [Descripcion], [FechaIngresa], [UsuarioIngresa], [FechaModifica], [UsuarioModifica]) VALUES (@IdEmpresa, 1, 2, 10, N'26', N'0.0945', 0, N'', CAST(N'2017-10-31 15:22:06.890' AS DateTime), N'muruchima', CAST(N'2017-10-31 15:22:06.890' AS DateTime), N'muruchima')
INSERT [dbo].[ro_nomina_tipo_liqui_orden] ([IdEmpresa], [IdNominaTipo], [IdNominaTipoLiqui], [Orden], [IdRubro], [Formula], [EsVisible], [Descripcion], [FechaIngresa], [UsuarioIngresa], [FechaModifica], [UsuarioModifica]) VALUES (@IdEmpresa, 1, 2, 11, N'970', N'0.1215', 0, N'', CAST(N'2017-10-31 15:22:06.893' AS DateTime), N'muruchima', CAST(N'2017-10-31 15:22:06.893' AS DateTime), N'muruchima')
INSERT [dbo].[ro_nomina_tipo_liqui_orden] ([IdEmpresa], [IdNominaTipo], [IdNominaTipoLiqui], [Orden], [IdRubro], [Formula], [EsVisible], [Descripcion], [FechaIngresa], [UsuarioIngresa], [FechaModifica], [UsuarioModifica]) VALUES (@IdEmpresa, 1, 2, 12, N'975', N'DIAS_VACACIONES()', 0, N'', CAST(N'2017-10-31 15:22:06.893' AS DateTime), N'muruchima', CAST(N'2017-10-31 15:22:06.897' AS DateTime), N'muruchima')
INSERT [dbo].[ro_nomina_tipo_liqui_orden] ([IdEmpresa], [IdNominaTipo], [IdNominaTipoLiqui], [Orden], [IdRubro], [Formula], [EsVisible], [Descripcion], [FechaIngresa], [UsuarioIngresa], [FechaModifica], [UsuarioModifica]) VALUES (@IdEmpresa, 1, 2, 14, N'963', N'375', 0, N'', CAST(N'2017-10-31 15:22:06.897' AS DateTime), N'muruchima', CAST(N'2017-10-31 15:22:06.897' AS DateTime), N'muruchima')
INSERT [dbo].[ro_nomina_tipo_liqui_orden] ([IdEmpresa], [IdNominaTipo], [IdNominaTipoLiqui], [Orden], [IdRubro], [Formula], [EsVisible], [Descripcion], [FechaIngresa], [UsuarioIngresa], [FechaModifica], [UsuarioModifica]) VALUES (@IdEmpresa, 1, 2, 15, N'57', N'PERMITE_ACUMULAR([FNDO_RSVA])', 0, N'', CAST(N'2017-10-31 15:22:06.897' AS DateTime), N'muruchima', CAST(N'2017-10-31 15:22:06.900' AS DateTime), N'muruchima')
INSERT [dbo].[ro_nomina_tipo_liqui_orden] ([IdEmpresa], [IdNominaTipo], [IdNominaTipoLiqui], [Orden], [IdRubro], [Formula], [EsVisible], [Descripcion], [FechaIngresa], [UsuarioIngresa], [FechaModifica], [UsuarioModifica]) VALUES (@IdEmpresa, 1, 2, 16, N'59', N'PERMITE_ACUMULAR([XIV_SUELDO])', 0, N'', CAST(N'2017-10-31 15:22:06.900' AS DateTime), N'muruchima', CAST(N'2017-10-31 15:22:06.900' AS DateTime), N'muruchima')
INSERT [dbo].[ro_nomina_tipo_liqui_orden] ([IdEmpresa], [IdNominaTipo], [IdNominaTipoLiqui], [Orden], [IdRubro], [Formula], [EsVisible], [Descripcion], [FechaIngresa], [UsuarioIngresa], [FechaModifica], [UsuarioModifica]) VALUES (@IdEmpresa, 1, 2, 17, N'58', N'PERMITE_ACUMULAR([XIII_SUELD])', 0, N'', CAST(N'2017-10-31 15:22:06.900' AS DateTime), N'muruchima', CAST(N'2017-10-31 15:22:06.903' AS DateTime), N'muruchima')
INSERT [dbo].[ro_nomina_tipo_liqui_orden] ([IdEmpresa], [IdNominaTipo], [IdNominaTipoLiqui], [Orden], [IdRubro], [Formula], [EsVisible], [Descripcion], [FechaIngresa], [UsuarioIngresa], [FechaModifica], [UsuarioModifica]) VALUES (@IdEmpresa, 1, 2, 18, N'102', N'DIAS_ANTIGUEDAD()', 0, N'', CAST(N'2017-10-31 15:22:06.903' AS DateTime), N'muruchima', CAST(N'2017-10-31 15:22:06.903' AS DateTime), N'muruchima')
INSERT [dbo].[ro_nomina_tipo_liqui_orden] ([IdEmpresa], [IdNominaTipo], [IdNominaTipoLiqui], [Orden], [IdRubro], [Formula], [EsVisible], [Descripcion], [FechaIngresa], [UsuarioIngresa], [FechaModifica], [UsuarioModifica]) VALUES (@IdEmpresa, 1, 2, 19, N'100', N'DIAS_TRA_MENSUAL_RUBRO([XIV_SUELDO])', 0, N'', CAST(N'2017-10-31 15:22:06.907' AS DateTime), N'muruchima', CAST(N'2017-10-31 15:22:06.907' AS DateTime), N'muruchima')
INSERT [dbo].[ro_nomina_tipo_liqui_orden] ([IdEmpresa], [IdNominaTipo], [IdNominaTipoLiqui], [Orden], [IdRubro], [Formula], [EsVisible], [Descripcion], [FechaIngresa], [UsuarioIngresa], [FechaModifica], [UsuarioModifica]) VALUES (@IdEmpresa, 1, 2, 20, N'101', N'DIAS_TRA_MENSUAL_RUBRO([XIII_SUELD])', 0, N'', CAST(N'2017-10-31 15:22:06.907' AS DateTime), N'muruchima', CAST(N'2017-10-31 15:22:06.910' AS DateTime), N'muruchima')
INSERT [dbo].[ro_nomina_tipo_liqui_orden] ([IdEmpresa], [IdNominaTipo], [IdNominaTipoLiqui], [Orden], [IdRubro], [Formula], [EsVisible], [Descripcion], [FechaIngresa], [UsuarioIngresa], [FechaModifica], [UsuarioModifica]) VALUES (@IdEmpresa, 1, 2, 25, N'20', N'DIAS_TRABAJADOS()', 0, N'', CAST(N'2017-10-31 15:22:06.910' AS DateTime), N'muruchima', CAST(N'2017-10-31 15:22:06.910' AS DateTime), N'muruchima')
INSERT [dbo].[ro_nomina_tipo_liqui_orden] ([IdEmpresa], [IdNominaTipo], [IdNominaTipoLiqui], [Orden], [IdRubro], [Formula], [EsVisible], [Descripcion], [FechaIngresa], [UsuarioIngresa], [FechaModifica], [UsuarioModifica]) VALUES (@IdEmpresa, 1, 2, 48, N'980', N'OBTENER_DIAS_PERMISO_VACACIONES()', 0, N'', CAST(N'2017-10-31 15:22:06.910' AS DateTime), N'muruchima', CAST(N'2017-10-31 15:22:06.913' AS DateTime), N'muruchima')
INSERT [dbo].[ro_nomina_tipo_liqui_orden] ([IdEmpresa], [IdNominaTipo], [IdNominaTipoLiqui], [Orden], [IdRubro], [Formula], [EsVisible], [Descripcion], [FechaIngresa], [UsuarioIngresa], [FechaModifica], [UsuarioModifica]) VALUES (@IdEmpresa, 1, 2, 53, N'296', N'Iif([ACUM_FR]=1 , 0  , (Iif([DIAS_ANT]>=360,[SUELDO]*0.0833  , 0 )) )', 1, N'', CAST(N'2017-10-31 15:22:06.913' AS DateTime), N'muruchima', CAST(N'2017-10-31 15:22:06.913' AS DateTime), N'muruchima')
INSERT [dbo].[ro_nomina_tipo_liqui_orden] ([IdEmpresa], [IdNominaTipo], [IdNominaTipoLiqui], [Orden], [IdRubro], [Formula], [EsVisible], [Descripcion], [FechaIngresa], [UsuarioIngresa], [FechaModifica], [UsuarioModifica]) VALUES (@IdEmpresa, 1, 2, 58, N'68', N'OBTENER_NOVEDAD()', 0, N'', CAST(N'2017-10-31 15:22:06.917' AS DateTime), N'muruchima', CAST(N'2017-10-31 15:22:06.917' AS DateTime), N'muruchima')
INSERT [dbo].[ro_nomina_tipo_liqui_orden] ([IdEmpresa], [IdNominaTipo], [IdNominaTipoLiqui], [Orden], [IdRubro], [Formula], [EsVisible], [Descripcion], [FechaIngresa], [UsuarioIngresa], [FechaModifica], [UsuarioModifica]) VALUES (@IdEmpresa, 1, 2, 59, N'74', N'OBTENER_NOVEDAD()', 1, N'', CAST(N'2017-10-31 15:22:06.917' AS DateTime), N'muruchima', CAST(N'2017-10-31 15:22:06.920' AS DateTime), N'muruchima')
INSERT [dbo].[ro_nomina_tipo_liqui_orden] ([IdEmpresa], [IdNominaTipo], [IdNominaTipoLiqui], [Orden], [IdRubro], [Formula], [EsVisible], [Descripcion], [FechaIngresa], [UsuarioIngresa], [FechaModifica], [UsuarioModifica]) VALUES (@IdEmpresa, 1, 2, 102, N'4', N'[SUELDO_BAS]+ [HORAEXTRAS]', 0, N'', CAST(N'2017-10-31 15:22:06.920' AS DateTime), N'muruchima', CAST(N'2017-10-31 15:22:06.920' AS DateTime), N'muruchima')
INSERT [dbo].[ro_nomina_tipo_liqui_orden] ([IdEmpresa], [IdNominaTipo], [IdNominaTipoLiqui], [Orden], [IdRubro], [Formula], [EsVisible], [Descripcion], [FechaIngresa], [UsuarioIngresa], [FechaModifica], [UsuarioModifica]) VALUES (@IdEmpresa, 1, 2, 107, N'290', N'Iif([ACUM_D13]=1 , 0  , ([SUELDO] /12)  )', 0, N'', CAST(N'2017-10-31 15:22:06.920' AS DateTime), N'muruchima', CAST(N'2017-10-31 15:22:06.923' AS DateTime), N'muruchima')
INSERT [dbo].[ro_nomina_tipo_liqui_orden] ([IdEmpresa], [IdNominaTipo], [IdNominaTipoLiqui], [Orden], [IdRubro], [Formula], [EsVisible], [Descripcion], [FechaIngresa], [UsuarioIngresa], [FechaModifica], [UsuarioModifica]) VALUES (@IdEmpresa, 1, 2, 108, N'289', N'Iif([ACUM_D14]=1 , 0 , ([SBU]/360) * ([DIAS_D14] - [NUM_DIAS_F]) )', 0, N'', CAST(N'2017-10-31 15:22:06.923' AS DateTime), N'muruchima', CAST(N'2017-10-31 15:22:06.923' AS DateTime), N'muruchima')
INSERT [dbo].[ro_nomina_tipo_liqui_orden] ([IdEmpresa], [IdNominaTipo], [IdNominaTipoLiqui], [Orden], [IdRubro], [Formula], [EsVisible], [Descripcion], [FechaIngresa], [UsuarioIngresa], [FechaModifica], [UsuarioModifica]) VALUES (@IdEmpresa, 1, 2, 199, N'500', N'[SUELDO] + [FNDO_RSVA] + [XIII_SUELD] + [XIV_SUELDO]+[TRANS+]+[ALIMENT+]', 1, N'', CAST(N'2017-10-31 15:22:06.927' AS DateTime), N'muruchima', CAST(N'2017-10-31 15:22:06.927' AS DateTime), N'muruchima')
INSERT [dbo].[ro_nomina_tipo_liqui_orden] ([IdEmpresa], [IdNominaTipo], [IdNominaTipoLiqui], [Orden], [IdRubro], [Formula], [EsVisible], [Descripcion], [FechaIngresa], [UsuarioIngresa], [FechaModifica], [UsuarioModifica]) VALUES (@IdEmpresa, 1, 2, 201, N'6', N'[IESS_PERS%] * [SUELDO]', 1, N'', CAST(N'2017-10-31 15:22:06.927' AS DateTime), N'muruchima', CAST(N'2017-10-31 15:22:06.930' AS DateTime), N'muruchima')
INSERT [dbo].[ro_nomina_tipo_liqui_orden] ([IdEmpresa], [IdNominaTipo], [IdNominaTipoLiqui], [Orden], [IdRubro], [Formula], [EsVisible], [Descripcion], [FechaIngresa], [UsuarioIngresa], [FechaModifica], [UsuarioModifica]) VALUES (@IdEmpresa, 1, 2, 202, N'277', N'OBTENER_NOVEDAD()', 1, N'', CAST(N'2017-10-31 15:22:06.930' AS DateTime), N'muruchima', CAST(N'2017-10-31 15:22:06.930' AS DateTime), N'muruchima')
INSERT [dbo].[ro_nomina_tipo_liqui_orden] ([IdEmpresa], [IdNominaTipo], [IdNominaTipoLiqui], [Orden], [IdRubro], [Formula], [EsVisible], [Descripcion], [FechaIngresa], [UsuarioIngresa], [FechaModifica], [UsuarioModifica]) VALUES (@IdEmpresa, 1, 2, 203, N'201', N'OBTENER_NOVEDAD()', 1, N'', CAST(N'2017-10-31 15:22:06.930' AS DateTime), N'muruchima', CAST(N'2017-10-31 15:22:06.933' AS DateTime), N'muruchima')
INSERT [dbo].[ro_nomina_tipo_liqui_orden] ([IdEmpresa], [IdNominaTipo], [IdNominaTipoLiqui], [Orden], [IdRubro], [Formula], [EsVisible], [Descripcion], [FechaIngresa], [UsuarioIngresa], [FechaModifica], [UsuarioModifica]) VALUES (@IdEmpresa, 1, 2, 204, N'1018', N'OBTENER_NOVEDAD()', 1, N'', CAST(N'2017-10-31 15:22:06.933' AS DateTime), N'muruchima', CAST(N'2017-10-31 15:22:06.933' AS DateTime), N'muruchima')
INSERT [dbo].[ro_nomina_tipo_liqui_orden] ([IdEmpresa], [IdNominaTipo], [IdNominaTipoLiqui], [Orden], [IdRubro], [Formula], [EsVisible], [Descripcion], [FechaIngresa], [UsuarioIngresa], [FechaModifica], [UsuarioModifica]) VALUES (@IdEmpresa, 1, 2, 205, N'214', N'OBTENER_NOVEDAD()', 1, N'', CAST(N'2017-10-31 15:22:06.933' AS DateTime), N'muruchima', CAST(N'2017-10-31 15:22:06.937' AS DateTime), N'muruchima')
INSERT [dbo].[ro_nomina_tipo_liqui_orden] ([IdEmpresa], [IdNominaTipo], [IdNominaTipoLiqui], [Orden], [IdRubro], [Formula], [EsVisible], [Descripcion], [FechaIngresa], [UsuarioIngresa], [FechaModifica], [UsuarioModifica]) VALUES (@IdEmpresa, 1, 2, 206, N'1035', N'ANTICIPO_QUINCENA()', 1, N'', CAST(N'2017-10-31 15:22:06.937' AS DateTime), N'muruchima', CAST(N'2017-10-31 15:22:06.937' AS DateTime), N'muruchima')
INSERT [dbo].[ro_nomina_tipo_liqui_orden] ([IdEmpresa], [IdNominaTipo], [IdNominaTipoLiqui], [Orden], [IdRubro], [Formula], [EsVisible], [Descripcion], [FechaIngresa], [UsuarioIngresa], [FechaModifica], [UsuarioModifica]) VALUES (@IdEmpresa, 1, 2, 207, N'1038', N'OBTENER_NOVEDAD()', 1, N'', CAST(N'2017-10-31 15:22:06.940' AS DateTime), N'muruchima', CAST(N'2017-10-31 15:22:06.940' AS DateTime), N'muruchima')
INSERT [dbo].[ro_nomina_tipo_liqui_orden] ([IdEmpresa], [IdNominaTipo], [IdNominaTipoLiqui], [Orden], [IdRubro], [Formula], [EsVisible], [Descripcion], [FechaIngresa], [UsuarioIngresa], [FechaModifica], [UsuarioModifica]) VALUES (@IdEmpresa, 1, 2, 208, N'1019', N'OBTENER_NOVEDAD()', 1, N'', CAST(N'2017-10-31 15:22:06.940' AS DateTime), N'muruchima', CAST(N'2017-10-31 15:22:06.940' AS DateTime), N'muruchima')
INSERT [dbo].[ro_nomina_tipo_liqui_orden] ([IdEmpresa], [IdNominaTipo], [IdNominaTipoLiqui], [Orden], [IdRubro], [Formula], [EsVisible], [Descripcion], [FechaIngresa], [UsuarioIngresa], [FechaModifica], [UsuarioModifica]) VALUES (@IdEmpresa, 1, 2, 209, N'978', N'OBTENER_NOVEDAD()', 1, N'', CAST(N'2017-10-31 15:22:06.943' AS DateTime), N'muruchima', CAST(N'2017-10-31 15:22:06.943' AS DateTime), N'muruchima')
INSERT [dbo].[ro_nomina_tipo_liqui_orden] ([IdEmpresa], [IdNominaTipo], [IdNominaTipoLiqui], [Orden], [IdRubro], [Formula], [EsVisible], [Descripcion], [FechaIngresa], [UsuarioIngresa], [FechaModifica], [UsuarioModifica]) VALUES (@IdEmpresa, 1, 2, 210, N'252', N'IMPUESTO_RENTA()', 1, N'', CAST(N'2017-10-31 15:22:06.943' AS DateTime), N'muruchima', CAST(N'2017-10-31 15:22:06.947' AS DateTime), N'muruchima')
INSERT [dbo].[ro_nomina_tipo_liqui_orden] ([IdEmpresa], [IdNominaTipo], [IdNominaTipoLiqui], [Orden], [IdRubro], [Formula], [EsVisible], [Descripcion], [FechaIngresa], [UsuarioIngresa], [FechaModifica], [UsuarioModifica]) VALUES (@IdEmpresa, 1, 2, 211, N'973', N'OBTENER_NOVEDAD()', 1, N'', CAST(N'2017-10-31 15:22:06.947' AS DateTime), N'muruchima', CAST(N'2017-10-31 15:22:06.947' AS DateTime), N'muruchima')
INSERT [dbo].[ro_nomina_tipo_liqui_orden] ([IdEmpresa], [IdNominaTipo], [IdNominaTipoLiqui], [Orden], [IdRubro], [Formula], [EsVisible], [Descripcion], [FechaIngresa], [UsuarioIngresa], [FechaModifica], [UsuarioModifica]) VALUES (@IdEmpresa, 1, 2, 212, N'998', N'([SUELDO_NETO]/30)*[SI_EM_VAC]', 1, N'', CAST(N'2017-10-31 15:22:06.947' AS DateTime), N'muruchima', CAST(N'2017-10-31 15:22:06.950' AS DateTime), N'muruchima')
INSERT [dbo].[ro_nomina_tipo_liqui_orden] ([IdEmpresa], [IdNominaTipo], [IdNominaTipoLiqui], [Orden], [IdRubro], [Formula], [EsVisible], [Descripcion], [FechaIngresa], [UsuarioIngresa], [FechaModifica], [UsuarioModifica]) VALUES (@IdEmpresa, 1, 2, 213, N'1023', N'OBTENER_NOVEDAD()', 1, N'', CAST(N'2017-10-31 15:22:06.950' AS DateTime), N'muruchima', CAST(N'2017-10-31 15:22:06.950' AS DateTime), N'muruchima')
INSERT [dbo].[ro_nomina_tipo_liqui_orden] ([IdEmpresa], [IdNominaTipo], [IdNominaTipoLiqui], [Orden], [IdRubro], [Formula], [EsVisible], [Descripcion], [FechaIngresa], [UsuarioIngresa], [FechaModifica], [UsuarioModifica]) VALUES (@IdEmpresa, 1, 2, 214, N'1036', N'OBTENER_NOVEDAD()', 1, N'', CAST(N'2017-10-31 15:22:06.950' AS DateTime), N'muruchima', CAST(N'2017-10-31 15:22:06.953' AS DateTime), N'muruchima')
INSERT [dbo].[ro_nomina_tipo_liqui_orden] ([IdEmpresa], [IdNominaTipo], [IdNominaTipoLiqui], [Orden], [IdRubro], [Formula], [EsVisible], [Descripcion], [FechaIngresa], [UsuarioIngresa], [FechaModifica], [UsuarioModifica]) VALUES (@IdEmpresa, 1, 2, 215, N'1022', N'OBTENER_NOVEDAD()', 1, N'', CAST(N'2017-10-31 15:22:06.953' AS DateTime), N'muruchima', CAST(N'2017-10-31 15:22:06.953' AS DateTime), N'muruchima')
INSERT [dbo].[ro_nomina_tipo_liqui_orden] ([IdEmpresa], [IdNominaTipo], [IdNominaTipoLiqui], [Orden], [IdRubro], [Formula], [EsVisible], [Descripcion], [FechaIngresa], [UsuarioIngresa], [FechaModifica], [UsuarioModifica]) VALUES (@IdEmpresa, 1, 2, 216, N'1037', N'OBTENER_NOVEDAD()', 1, N'', CAST(N'2017-10-31 15:22:06.957' AS DateTime), N'muruchima', CAST(N'2017-10-31 15:22:06.957' AS DateTime), N'muruchima')
INSERT [dbo].[ro_nomina_tipo_liqui_orden] ([IdEmpresa], [IdNominaTipo], [IdNominaTipoLiqui], [Orden], [IdRubro], [Formula], [EsVisible], [Descripcion], [FechaIngresa], [UsuarioIngresa], [FechaModifica], [UsuarioModifica]) VALUES (@IdEmpresa, 1, 2, 217, N'1039', N'OBTENER_NOVEDAD()', 1, N'', CAST(N'2017-10-31 15:22:06.957' AS DateTime), N'muruchima', CAST(N'2017-10-31 15:22:06.957' AS DateTime), N'muruchima')
INSERT [dbo].[ro_nomina_tipo_liqui_orden] ([IdEmpresa], [IdNominaTipo], [IdNominaTipoLiqui], [Orden], [IdRubro], [Formula], [EsVisible], [Descripcion], [FechaIngresa], [UsuarioIngresa], [FechaModifica], [UsuarioModifica]) VALUES (@IdEmpresa, 1, 2, 218, N'1', N'OBTENER_NOVEDAD()', 1, N'', CAST(N'2017-10-31 15:22:06.960' AS DateTime), N'muruchima', CAST(N'2017-10-31 15:22:06.960' AS DateTime), N'muruchima')
INSERT [dbo].[ro_nomina_tipo_liqui_orden] ([IdEmpresa], [IdNominaTipo], [IdNominaTipoLiqui], [Orden], [IdRubro], [Formula], [EsVisible], [Descripcion], [FechaIngresa], [UsuarioIngresa], [FechaModifica], [UsuarioModifica]) VALUES (@IdEmpresa, 1, 2, 219, N'1009', N'OBTENER_NOVEDAD()', 1, N'', CAST(N'2017-10-31 15:22:06.960' AS DateTime), N'muruchima', CAST(N'2017-10-31 15:22:06.960' AS DateTime), N'muruchima')
INSERT [dbo].[ro_nomina_tipo_liqui_orden] ([IdEmpresa], [IdNominaTipo], [IdNominaTipoLiqui], [Orden], [IdRubro], [Formula], [EsVisible], [Descripcion], [FechaIngresa], [UsuarioIngresa], [FechaModifica], [UsuarioModifica]) VALUES (@IdEmpresa, 1, 2, 220, N'1008', N'OBTENER_NOVEDAD()', 1, N'', CAST(N'2017-10-31 15:22:06.963' AS DateTime), N'muruchima', CAST(N'2017-10-31 15:22:06.963' AS DateTime), N'muruchima')
INSERT [dbo].[ro_nomina_tipo_liqui_orden] ([IdEmpresa], [IdNominaTipo], [IdNominaTipoLiqui], [Orden], [IdRubro], [Formula], [EsVisible], [Descripcion], [FechaIngresa], [UsuarioIngresa], [FechaModifica], [UsuarioModifica]) VALUES (@IdEmpresa, 1, 2, 221, N'1003', N'OBTENER_NOVEDAD()', 1, N'', CAST(N'2017-10-31 15:22:06.963' AS DateTime), N'muruchima', CAST(N'2017-10-31 15:22:06.963' AS DateTime), N'muruchima')
INSERT [dbo].[ro_nomina_tipo_liqui_orden] ([IdEmpresa], [IdNominaTipo], [IdNominaTipoLiqui], [Orden], [IdRubro], [Formula], [EsVisible], [Descripcion], [FechaIngresa], [UsuarioIngresa], [FechaModifica], [UsuarioModifica]) VALUES (@IdEmpresa, 1, 2, 222, N'1006', N'OBTENER_NOVEDAD()', 1, N'', CAST(N'2017-10-31 15:22:06.967' AS DateTime), N'muruchima', CAST(N'2017-10-31 15:22:06.967' AS DateTime), N'muruchima')
INSERT [dbo].[ro_nomina_tipo_liqui_orden] ([IdEmpresa], [IdNominaTipo], [IdNominaTipoLiqui], [Orden], [IdRubro], [Formula], [EsVisible], [Descripcion], [FechaIngresa], [UsuarioIngresa], [FechaModifica], [UsuarioModifica]) VALUES (@IdEmpresa, 1, 2, 223, N'1000', N'OBTENER_NOVEDAD()', 1, N'', CAST(N'2017-10-31 15:22:06.967' AS DateTime), N'muruchima', CAST(N'2017-10-31 15:22:06.970' AS DateTime), N'muruchima')
INSERT [dbo].[ro_nomina_tipo_liqui_orden] ([IdEmpresa], [IdNominaTipo], [IdNominaTipoLiqui], [Orden], [IdRubro], [Formula], [EsVisible], [Descripcion], [FechaIngresa], [UsuarioIngresa], [FechaModifica], [UsuarioModifica]) VALUES (@IdEmpresa, 1, 2, 224, N'1005', N'OBTENER_NOVEDAD()', 1, N'', CAST(N'2017-10-31 15:22:06.970' AS DateTime), N'muruchima', CAST(N'2017-10-31 15:22:06.970' AS DateTime), N'muruchima')
INSERT [dbo].[ro_nomina_tipo_liqui_orden] ([IdEmpresa], [IdNominaTipo], [IdNominaTipoLiqui], [Orden], [IdRubro], [Formula], [EsVisible], [Descripcion], [FechaIngresa], [UsuarioIngresa], [FechaModifica], [UsuarioModifica]) VALUES (@IdEmpresa, 1, 2, 298, N'900', N'[IESS_PERS]  + [PRES_PERS] + [PREST_QR] + [TRMEN] +[ANT-]+[NUM_DIAS_F]+[DIF_HORAS]+[EXT_SAL]+[ALIMENT-]+[PRE_HIP]+[VACA]+[COS_TRA]+[HORAS_REEM]+[DANF]+[PERD_HERRA]+[VAL_DIAS_FALT]+[SUBSIDIO]+[SI_DA_TE]+[SANCI]+[CAJA_ABI]+[BIATIC_NS]+[ROBO]+[DAÑO_FLO]', 1, N'', CAST(N'2017-10-31 15:22:06.970' AS DateTime), N'muruchima', CAST(N'2017-10-31 15:22:06.973' AS DateTime), N'muruchima')
INSERT [dbo].[ro_nomina_tipo_liqui_orden] ([IdEmpresa], [IdNominaTipo], [IdNominaTipoLiqui], [Orden], [IdRubro], [Formula], [EsVisible], [Descripcion], [FechaIngresa], [UsuarioIngresa], [FechaModifica], [UsuarioModifica]) VALUES (@IdEmpresa, 1, 2, 299, N'950', N'Iif([INGRESOS]>0, [INGRESOS] - [EGRESOS] ,0 )', 1, N'', CAST(N'2017-10-31 15:22:06.973' AS DateTime), N'muruchima', CAST(N'2017-10-31 15:22:06.973' AS DateTime), N'muruchima')
INSERT [dbo].[ro_nomina_tipo_liqui_orden] ([IdEmpresa], [IdNominaTipo], [IdNominaTipoLiqui], [Orden], [IdRubro], [Formula], [EsVisible], [Descripcion], [FechaIngresa], [UsuarioIngresa], [FechaModifica], [UsuarioModifica]) VALUES (@IdEmpresa, 1, 2, 300, N'199', N'Iif([ACUM_D13]=1 ,  ([SUELDO]  / 12)  , 0)', 0, N'', CAST(N'2017-10-31 15:22:06.973' AS DateTime), N'muruchima', CAST(N'2017-10-31 15:22:06.977' AS DateTime), N'muruchima')
INSERT [dbo].[ro_nomina_tipo_liqui_orden] ([IdEmpresa], [IdNominaTipo], [IdNominaTipoLiqui], [Orden], [IdRubro], [Formula], [EsVisible], [Descripcion], [FechaIngresa], [UsuarioIngresa], [FechaModifica], [UsuarioModifica]) VALUES (@IdEmpresa, 1, 2, 301, N'200', N'Iif([ACUM_D14]=1 ,([SBU]/360) *  [DIASTRA]  , 0 )', 0, N'', CAST(N'2017-10-31 15:22:06.977' AS DateTime), N'muruchima', CAST(N'2017-10-31 15:22:06.980' AS DateTime), N'muruchima')
INSERT [dbo].[ro_nomina_tipo_liqui_orden] ([IdEmpresa], [IdNominaTipo], [IdNominaTipoLiqui], [Orden], [IdRubro], [Formula], [EsVisible], [Descripcion], [FechaIngresa], [UsuarioIngresa], [FechaModifica], [UsuarioModifica]) VALUES (@IdEmpresa, 1, 2, 302, N'198', N'Iif([ACUM_FR]=1 , (Iif([DIAS_ANT]>=360,[SUELDO]*0.0833  , 0 )) , 0 )', 0, N'', CAST(N'2017-10-31 15:22:06.980' AS DateTime), N'muruchima', CAST(N'2017-10-31 15:22:06.980' AS DateTime), N'muruchima')
INSERT [dbo].[ro_nomina_tipo_liqui_orden] ([IdEmpresa], [IdNominaTipo], [IdNominaTipoLiqui], [Orden], [IdRubro], [Formula], [EsVisible], [Descripcion], [FechaIngresa], [UsuarioIngresa], [FechaModifica], [UsuarioModifica]) VALUES (@IdEmpresa, 1, 2, 303, N'493', N'[SUELDO] * [IESS_PATR%]', 0, N'', CAST(N'2017-10-31 15:22:06.980' AS DateTime), N'muruchima', CAST(N'2017-10-31 15:22:06.983' AS DateTime), N'muruchima')
INSERT [dbo].[ro_nomina_tipo_liqui_orden] ([IdEmpresa], [IdNominaTipo], [IdNominaTipoLiqui], [Orden], [IdRubro], [Formula], [EsVisible], [Descripcion], [FechaIngresa], [UsuarioIngresa], [FechaModifica], [UsuarioModifica]) VALUES (@IdEmpresa, 1, 2, 304, N'295', N'[SUELDO] / 24', 0, N'', CAST(N'2017-10-31 15:22:06.983' AS DateTime), N'muruchima', CAST(N'2017-10-31 15:22:06.983' AS DateTime), N'muruchima')
INSERT [dbo].[ro_nomina_tipo_liqui_orden] ([IdEmpresa], [IdNominaTipo], [IdNominaTipoLiqui], [Orden], [IdRubro], [Formula], [EsVisible], [Descripcion], [FechaIngresa], [UsuarioIngresa], [FechaModifica], [UsuarioModifica]) VALUES (@IdEmpresa, 1, 3, 0, N'1042', N'OBTENER_DECIMA_TERCERA()', 0, N'', CAST(N'2017-06-27 12:53:26.393' AS DateTime), N'admin', CAST(N'2017-06-27 12:53:26.423' AS DateTime), N'admin')
INSERT [dbo].[ro_nomina_tipo_liqui_orden] ([IdEmpresa], [IdNominaTipo], [IdNominaTipoLiqui], [Orden], [IdRubro], [Formula], [EsVisible], [Descripcion], [FechaIngresa], [UsuarioIngresa], [FechaModifica], [UsuarioModifica]) VALUES (@IdEmpresa, 1, 3, 1, N'290', N'DECIMOIII/12', 1, N'', CAST(N'2017-06-27 12:53:26.427' AS DateTime), N'admin', CAST(N'2017-06-27 12:53:26.427' AS DateTime), N'admin')
INSERT [dbo].[ro_nomina_tipo_liqui_orden] ([IdEmpresa], [IdNominaTipo], [IdNominaTipoLiqui], [Orden], [IdRubro], [Formula], [EsVisible], [Descripcion], [FechaIngresa], [UsuarioIngresa], [FechaModifica], [UsuarioModifica]) VALUES (@IdEmpresa, 1, 3, 50, N'1044', N'OBTENER_NOVEDAD()', 1, N'', CAST(N'2017-06-27 12:53:26.430' AS DateTime), N'admin', CAST(N'2017-06-27 12:53:26.430' AS DateTime), N'admin')
INSERT [dbo].[ro_nomina_tipo_liqui_orden] ([IdEmpresa], [IdNominaTipo], [IdNominaTipoLiqui], [Orden], [IdRubro], [Formula], [EsVisible], [Descripcion], [FechaIngresa], [UsuarioIngresa], [FechaModifica], [UsuarioModifica]) VALUES (@IdEmpresa, 1, 3, 100, N'500', N'[XIII_SUELD]+[HISTO_D3]', 1, N'', CAST(N'2017-06-27 12:53:26.430' AS DateTime), N'admin', CAST(N'2017-06-27 12:53:26.433' AS DateTime), N'admin')
INSERT [dbo].[ro_nomina_tipo_liqui_orden] ([IdEmpresa], [IdNominaTipo], [IdNominaTipoLiqui], [Orden], [IdRubro], [Formula], [EsVisible], [Descripcion], [FechaIngresa], [UsuarioIngresa], [FechaModifica], [UsuarioModifica]) VALUES (@IdEmpresa, 1, 3, 200, N'950', N'INGRESOS', 1, N'', CAST(N'2017-06-27 12:53:26.433' AS DateTime), N'admin', CAST(N'2017-06-27 12:53:26.437' AS DateTime), N'admin')
INSERT [dbo].[ro_nomina_tipo_liqui_orden] ([IdEmpresa], [IdNominaTipo], [IdNominaTipoLiqui], [Orden], [IdRubro], [Formula], [EsVisible], [Descripcion], [FechaIngresa], [UsuarioIngresa], [FechaModifica], [UsuarioModifica]) VALUES (@IdEmpresa, 1, 4, 0, N'1041', N'OBTENER_DECIMA_CUARTA()', 0, N'', CAST(N'2017-06-23 15:27:06.250' AS DateTime), N'admin', CAST(N'2017-06-23 15:27:06.260' AS DateTime), N'admin')
INSERT [dbo].[ro_nomina_tipo_liqui_orden] ([IdEmpresa], [IdNominaTipo], [IdNominaTipoLiqui], [Orden], [IdRubro], [Formula], [EsVisible], [Descripcion], [FechaIngresa], [UsuarioIngresa], [FechaModifica], [UsuarioModifica]) VALUES (@IdEmpresa, 1, 4, 1, N'289', N'DECIMOIV', 1, N'', CAST(N'2017-06-23 15:27:06.270' AS DateTime), N'admin', CAST(N'2017-06-23 15:27:06.277' AS DateTime), N'admin')
INSERT [dbo].[ro_nomina_tipo_liqui_orden] ([IdEmpresa], [IdNominaTipo], [IdNominaTipoLiqui], [Orden], [IdRubro], [Formula], [EsVisible], [Descripcion], [FechaIngresa], [UsuarioIngresa], [FechaModifica], [UsuarioModifica]) VALUES (@IdEmpresa, 1, 4, 50, N'1043', N'OBTENER_NOVEDAD()', 1, N'', CAST(N'2017-06-23 15:27:06.287' AS DateTime), N'admin', CAST(N'2017-06-23 15:27:06.293' AS DateTime), N'admin')
INSERT [dbo].[ro_nomina_tipo_liqui_orden] ([IdEmpresa], [IdNominaTipo], [IdNominaTipoLiqui], [Orden], [IdRubro], [Formula], [EsVisible], [Descripcion], [FechaIngresa], [UsuarioIngresa], [FechaModifica], [UsuarioModifica]) VALUES (@IdEmpresa, 1, 4, 100, N'500', N'[XIV_SUELDO] + [HISTO_D14]', 1, N'', CAST(N'2017-06-23 15:27:06.303' AS DateTime), N'admin', CAST(N'2017-06-23 15:27:06.310' AS DateTime), N'admin')
INSERT [dbo].[ro_nomina_tipo_liqui_orden] ([IdEmpresa], [IdNominaTipo], [IdNominaTipoLiqui], [Orden], [IdRubro], [Formula], [EsVisible], [Descripcion], [FechaIngresa], [UsuarioIngresa], [FechaModifica], [UsuarioModifica]) VALUES (@IdEmpresa, 1, 4, 200, N'950', N'INGRESOS', 1, N'', CAST(N'2017-06-23 15:27:06.320' AS DateTime), N'admin', CAST(N'2017-06-23 15:27:06.330' AS DateTime), N'admin')
INSERT [dbo].[ro_nomina_tipo_liqui_orden] ([IdEmpresa], [IdNominaTipo], [IdNominaTipoLiqui], [Orden], [IdRubro], [Formula], [EsVisible], [Descripcion], [FechaIngresa], [UsuarioIngresa], [FechaModifica], [UsuarioModifica]) VALUES (@IdEmpresa, 1, 5, 5, N'1048', N'UTILIDADES()', 1, N'', CAST(N'2017-06-29 12:58:24.493' AS DateTime), N'admin', CAST(N'2017-06-29 12:58:24.510' AS DateTime), N'admin')
INSERT [dbo].[ro_nomina_tipo_liqui_orden] ([IdEmpresa], [IdNominaTipo], [IdNominaTipoLiqui], [Orden], [IdRubro], [Formula], [EsVisible], [Descripcion], [FechaIngresa], [UsuarioIngresa], [FechaModifica], [UsuarioModifica]) VALUES (@IdEmpresa, 1, 5, 50, N'500', N'[UTILIDADES]', 1, N'', CAST(N'2017-06-29 12:58:24.527' AS DateTime), N'admin', CAST(N'2017-06-29 12:58:24.540' AS DateTime), N'admin')
INSERT [dbo].[ro_nomina_tipo_liqui_orden] ([IdEmpresa], [IdNominaTipo], [IdNominaTipoLiqui], [Orden], [IdRubro], [Formula], [EsVisible], [Descripcion], [FechaIngresa], [UsuarioIngresa], [FechaModifica], [UsuarioModifica]) VALUES (@IdEmpresa, 1, 5, 100, N'900', N'0', 1, N'', CAST(N'2017-06-29 12:58:24.553' AS DateTime), N'admin', CAST(N'2017-06-29 12:58:24.563' AS DateTime), N'admin')
INSERT [dbo].[ro_nomina_tipo_liqui_orden] ([IdEmpresa], [IdNominaTipo], [IdNominaTipoLiqui], [Orden], [IdRubro], [Formula], [EsVisible], [Descripcion], [FechaIngresa], [UsuarioIngresa], [FechaModifica], [UsuarioModifica]) VALUES (@IdEmpresa, 1, 5, 150, N'950', N'[INGRESOS] - [EGRESOS]', 1, N'', CAST(N'2017-06-29 12:58:24.573' AS DateTime), N'admin', CAST(N'2017-06-29 12:58:24.583' AS DateTime), N'admin')
INSERT [dbo].[ro_nomina_tipo_liqui_orden] ([IdEmpresa], [IdNominaTipo], [IdNominaTipoLiqui], [Orden], [IdRubro], [Formula], [EsVisible], [Descripcion], [FechaIngresa], [UsuarioIngresa], [FechaModifica], [UsuarioModifica]) VALUES (@IdEmpresa, 1, 8, 0, N'100', N'DIAS_TRA_MENSUAL_RUBRO([XIV_SUELDO])', 0, N'', CAST(N'2017-08-31 13:17:19.850' AS DateTime), N'muruchima', CAST(N'2017-08-31 13:17:19.853' AS DateTime), N'muruchima')
INSERT [dbo].[ro_nomina_tipo_liqui_orden] ([IdEmpresa], [IdNominaTipo], [IdNominaTipoLiqui], [Orden], [IdRubro], [Formula], [EsVisible], [Descripcion], [FechaIngresa], [UsuarioIngresa], [FechaModifica], [UsuarioModifica]) VALUES (@IdEmpresa, 1, 8, 1, N'2', N'[DIAS_D14]', 1, N'', CAST(N'2017-08-31 13:17:19.853' AS DateTime), N'muruchima', CAST(N'2017-08-31 13:17:19.857' AS DateTime), N'muruchima')
INSERT [dbo].[ro_nomina_tipo_liqui_orden] ([IdEmpresa], [IdNominaTipo], [IdNominaTipoLiqui], [Orden], [IdRubro], [Formula], [EsVisible], [Descripcion], [FechaIngresa], [UsuarioIngresa], [FechaModifica], [UsuarioModifica]) VALUES (@IdEmpresa, 1, 8, 51, N'1047', N'OBTENER_NOVEDAD()', 1, N'', CAST(N'2017-08-31 13:17:19.857' AS DateTime), N'muruchima', CAST(N'2017-08-31 13:17:19.860' AS DateTime), N'muruchima')
INSERT [dbo].[ro_nomina_tipo_liqui_orden] ([IdEmpresa], [IdNominaTipo], [IdNominaTipoLiqui], [Orden], [IdRubro], [Formula], [EsVisible], [Descripcion], [FechaIngresa], [UsuarioIngresa], [FechaModifica], [UsuarioModifica]) VALUES (@IdEmpresa, 1, 8, 52, N'1007', N'OBTENER_NOVEDAD()', 1, N'', CAST(N'2017-08-31 13:17:19.860' AS DateTime), N'muruchima', CAST(N'2017-08-31 13:17:19.860' AS DateTime), N'muruchima')
INSERT [dbo].[ro_nomina_tipo_liqui_orden] ([IdEmpresa], [IdNominaTipo], [IdNominaTipoLiqui], [Orden], [IdRubro], [Formula], [EsVisible], [Descripcion], [FechaIngresa], [UsuarioIngresa], [FechaModifica], [UsuarioModifica]) VALUES (@IdEmpresa, 1, 8, 53, N'1', N'OBTENER_NOVEDAD()', 1, N'', CAST(N'2017-08-31 13:17:19.863' AS DateTime), N'muruchima', CAST(N'2017-08-31 13:17:19.863' AS DateTime), N'muruchima')
INSERT [dbo].[ro_nomina_tipo_liqui_orden] ([IdEmpresa], [IdNominaTipo], [IdNominaTipoLiqui], [Orden], [IdRubro], [Formula], [EsVisible], [Descripcion], [FechaIngresa], [UsuarioIngresa], [FechaModifica], [UsuarioModifica]) VALUES (@IdEmpresa, 1, 8, 54, N'1022', N'OBTENER_NOVEDAD()', 1, N'', CAST(N'2017-08-31 13:17:19.873' AS DateTime), N'muruchima', CAST(N'2017-08-31 13:17:19.877' AS DateTime), N'muruchima')
INSERT [dbo].[ro_nomina_tipo_liqui_orden] ([IdEmpresa], [IdNominaTipo], [IdNominaTipoLiqui], [Orden], [IdRubro], [Formula], [EsVisible], [Descripcion], [FechaIngresa], [UsuarioIngresa], [FechaModifica], [UsuarioModifica]) VALUES (@IdEmpresa, 1, 8, 100, N'500', N'([BONIFICA]/30)*[DIASTRA]', 1, N'', CAST(N'2017-08-31 13:17:19.867' AS DateTime), N'muruchima', CAST(N'2017-08-31 13:17:19.867' AS DateTime), N'muruchima')
INSERT [dbo].[ro_nomina_tipo_liqui_orden] ([IdEmpresa], [IdNominaTipo], [IdNominaTipoLiqui], [Orden], [IdRubro], [Formula], [EsVisible], [Descripcion], [FechaIngresa], [UsuarioIngresa], [FechaModifica], [UsuarioModifica]) VALUES (@IdEmpresa, 1, 8, 200, N'900', N'[DIF_ROL]+[VAL_DIAS_FALT]+[DANF]', 1, N'', CAST(N'2017-08-31 13:17:19.867' AS DateTime), N'muruchima', CAST(N'2017-08-31 13:17:19.870' AS DateTime), N'muruchima')
INSERT [dbo].[ro_nomina_tipo_liqui_orden] ([IdEmpresa], [IdNominaTipo], [IdNominaTipoLiqui], [Orden], [IdRubro], [Formula], [EsVisible], [Descripcion], [FechaIngresa], [UsuarioIngresa], [FechaModifica], [UsuarioModifica]) VALUES (@IdEmpresa, 1, 8, 300, N'950', N'[INGRESOS] - [EGRESOS]', 1, N'', CAST(N'2017-08-31 13:17:19.870' AS DateTime), N'muruchima', CAST(N'2017-08-31 13:17:19.873' AS DateTime), N'muruchima')




INSERT [dbo].[tb_banco_procesos_bancarios_x_empresa] ([IdEmpresa], [IdProceso_bancario_tipo], [IdBanco], [cod_banco], [Codigo_Empresa], [Secuencial_detalle_inicial], [IdTipoNota], [Se_contabiliza]) VALUES (@IdEmpresa, N'NCR', 4, N'17', N'BM5', NULL, 1, 1)
INSERT [dbo].[tb_banco_procesos_bancarios_x_empresa] ([IdEmpresa], [IdProceso_bancario_tipo], [IdBanco], [cod_banco], [Codigo_Empresa], [Secuencial_detalle_inicial], [IdTipoNota], [Se_contabiliza]) VALUES (@IdEmpresa, N'PAGOS_MULTICASH', 4, N'17', N'BM5', NULL, 1, 1)
INSERT [dbo].[tb_banco_procesos_bancarios_x_empresa] ([IdEmpresa], [IdProceso_bancario_tipo], [IdBanco], [cod_banco], [Codigo_Empresa], [Secuencial_detalle_inicial], [IdTipoNota], [Se_contabiliza]) VALUES (@IdEmpresa, N'ROL_ELECTRONICO_BG', 4, N'17', N'BM5', NULL, 1, 1)
INSERT [dbo].[tb_banco_procesos_bancarios_x_empresa] ([IdEmpresa], [IdProceso_bancario_tipo], [IdBanco], [cod_banco], [Codigo_Empresa], [Secuencial_detalle_inicial], [IdTipoNota], [Se_contabiliza]) VALUES (@IdEmpresa, N'TRANSF_BANCARIA_BP', 3, N'10', N'BM5', NULL, 1, 1)

*/