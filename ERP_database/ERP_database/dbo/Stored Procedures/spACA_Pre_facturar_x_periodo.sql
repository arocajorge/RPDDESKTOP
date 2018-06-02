
CREATE PROCEDURE [dbo].[spACA_Pre_facturar_x_periodo]
 @i_IdEmpresa int,
 @i_IdInstitucion int,
 @i_Sede int,
 @i_Idanio_Lectivo int,  --SE ACTUALIZO DEBIDO A QUE EN LA TABLA Aca_Anio_Lectivo el id es varchar
 --@i_Idanio_Lectivo varchar(25),
 @i_IdPeriodo int,
 @i_IdGrupoFE int,
 @i_IdPrefacturacion numeric(18,0),
 @i_fecha date,
 @i_estado varchar(20),
 @i_Observacion varchar (500)
AS

/*
declare

 @i_IdEmpresa int,
 @i_IdInstitucion int,
 @i_Sede int,
 @i_Idanio_Lectivo int,
 @i_IdPeriodo int,
 @i_IdPrefacturacion numeric(18,0),
 @i_fecha date,
 @i_estado varchar(20),
 @i_Observacion varchar (500)

 set @i_IdEmpresa =1
 set @i_IdInstitucion =1
 set @i_Sede=1
 set @i_Idanio_Lectivo=2016
 set @i_IdPeriodo =201605
 set @i_IdPrefacturacion =0
 set @i_fecha ='01/05/2016'
 set @i_estado ='PEN'
 set @i_Observacion ='Generado por el sistema'
 */
BEGIN

declare @w_FechaIni datetime 
declare @w_FechaFin datetime 
declare @IdEmpresa_fact int
declare @IdSucursal_fact int
declare @IdBodega_fact int 
declare @IdPuntoVta_fact int
declare @IdCaja_fact int

select @w_FechaIni=pe_FechaIni,@w_FechaFin=pe_FechaFin  
from ct_periodo where IdEmpresa=@i_IdEmpresa
and IdPeriodo=@i_IdPeriodo



--  seteando parametros
select 
@IdEmpresa_fact= IdEmpresa, 
@i_IdInstitucion=IdInstitucion,
@IdSucursal_fact=IdSucursal_fact,
@IdBodega_fact=IdBodega_fact,
@IdPuntoVta_fact=IdPuntoVta_fact,
@IdCaja_fact=IdCaja_fact 
from Aca_Parametros where IdEmpresa=@i_IdEmpresa


IF (@i_IdPrefacturacion=0)
BEGIN --INSERT CABECERA
		SELECT @i_IdPrefacturacion = isnull(max(ID.IdPreFacturacion)+1,1) 
		from Aca_Pre_Facturacion as ID 
		where ID.IdInstitucion = @i_IdInstitucion
		
		INSERT INTO Aca_Pre_Facturacion
		(IdInstitucion			,IdPreFacturacion			,IdInstitucion_contrato			,Idperiodo			,fecha_prefacturacion			,IdEmpresa_fact
		,IdSucursal_fact		,IdBodega_fact				,IdCbteVta						,IdPtoVta_fact		,IdCaja_fact					,IdGrupoFE					
		,vt_fecha_fact
		,vt_plazo_fact			,vt_fech_venc				,observacion_fact				,Estado_Pre_factutacion_Cat	
		)
		values
		(
		@i_IdInstitucion		,@i_IdPrefacturacion		,@i_IdInstitucion				,@i_IdPeriodo		,@i_fecha						,@IdEmpresa_fact
		,@IdSucursal_fact		,@IdBodega_fact				,@IdPuntoVta_fact				,@IdCaja_fact		,@IdCaja_fact					,@i_IdGrupoFE					
		,@i_fecha
		,0						,@i_fecha					,@i_Observacion					,'PEN'					
		)

		END
ELSE
BEGIN --UPDATE CABECERA


			    UPDATE Aca_Pre_Facturacion
			    SET observacion_fact = @i_Observacion				 
			    WHERE IdInstitucion = @i_IdInstitucion
			    and Idperiodo = @i_IdPeriodo
END		

begin -- creando detalle de pre facturacion en base al contrato por estudiante y año lectivo

delete Aca_Pre_Facturacion_det where IdAnioLectivo_Per=@i_Idanio_Lectivo
and IdPreFacturacion=@i_IdPrefacturacion
and IdPeriodo_Per=@i_IdPeriodo

insert into Aca_Pre_Facturacion_det
(IdInstitucion						,IdPreFacturacion						,Secuencia_Proce								,secuencia							
,IdInstitucion_contra				,IdContrato								,IdRubro										,IdInstitucion_Per
,IdAnioLectivo_Per					,IdPeriodo_Per							,IdGrupoFE										,IdProducto							
,vt_cantidad						,vt_Precio																				,vt_PorDescUnitario								
,vt_DescUnitario					,vt_PrecioFinal																			,vt_Subtotal							
,vt_iva_valor						,vt_total				
,IdCod_Impuesto_Iva					,observacion_det						
,IdEstudiante						,IdFamiliar								,IdParentesco_cat
)



 select 
@i_IdInstitucion					,@i_IdPrefacturacion					,1												,ROW_NUMBER() OVER (ORDER BY Cont_Det.IdInstitucion)
,Cont_Det.IdInstitucion				,Cont_Det.IdContrato					,Cont_Det.IdRubro								,Rub_x_Period.IdInstitucion_per
,Rub_x_Period.IdAnioLectivo			,Rub_x_Period.IdPeriodo					,R.IdGrupoFE /*@i_IdGrupoFE*/					,R.IdProducto_inv  --antes iva con Grup.IdProducto_inv				
,1									,Rub_x_Period.Valor * fam_x_estud.porcentaje_dual / 100 								,Rub_x_Period.Valor * fam_x_estud.porcentaje_dual / 100 								
,0									,Rub_x_Period.Valor * fam_x_estud.porcentaje_dual / 100 								,Rub_x_Period.Valor * fam_x_estud.porcentaje_dual / 100 					
,0									,Rub_x_Period.Valor * fam_x_estud.porcentaje_dual / 100		
,'IVA'								,R.Descripcion_rubro					
,fam_x_estud.IdEstudiante			,fam_x_estud.IdFamiliar					,fam_x_estud.IdParentesco_cat					

FROM     dbo.Aca_Rubro AS R INNER JOIN
                  dbo.Aca_Rubro_x_Aca_Periodo_Lectivo AS Rub_x_Period ON R.IdRubro = Rub_x_Period.IdRubro AND R.IdInstitucion = Rub_x_Period.IdInstitucion_rub INNER JOIN
                  dbo.Aca_Contrato_x_Estudiante_det AS Cont_Det ON Rub_x_Period.IdInstitucion_rub = Cont_Det.IdInstitucion AND Rub_x_Period.IdRubro = Cont_Det.IdRubro AND 
                  Rub_x_Period.IdInstitucion_per = Cont_Det.IdInstitucion_Per AND Rub_x_Period.IdAnioLectivo = Cont_Det.IdAnioLectivo_Per AND Rub_x_Period.IdPeriodo = Cont_Det.IdPeriodo_Per INNER JOIN
                  dbo.Aca_Contrato_x_Estudiante ON Cont_Det.IdInstitucion = dbo.Aca_Contrato_x_Estudiante.IdInstitucion AND Cont_Det.IdContrato = dbo.Aca_Contrato_x_Estudiante.IdContrato INNER JOIN
                  dbo.Aca_matricula AS Matricula ON dbo.Aca_Contrato_x_Estudiante.IdInstitucion = Matricula.IdInstitucion AND dbo.Aca_Contrato_x_Estudiante.IdMatricula = Matricula.IdMatricula AND 
                  dbo.Aca_Contrato_x_Estudiante.IdEstudiante = Matricula.IdEstudiante  INNER JOIN
                  dbo.Aca_estudiante ON Matricula.IdInstitucion = dbo.Aca_estudiante.IdInstitucion AND Matricula.IdEstudiante = dbo.Aca_estudiante.IdEstudiante INNER JOIN
                  dbo.Aca_Familiar_x_Estudiante AS fam_x_estud ON dbo.Aca_estudiante.IdInstitucion = fam_x_estud.IdInstitucion AND dbo.Aca_estudiante.IdEstudiante = fam_x_estud.IdEstudiante
				  AND (fam_x_estud.IdParentesco_cat = 'REP_ECO' OR
                  fam_x_estud.IdParentesco_cat = 'REP_ECO_DUAL')

						 and Cont_Det.IdInstitucion=@i_IdInstitucion
						 and Cont_Det.IdPeriodo_Per=@i_IdPeriodo
						 and Cont_Det.IdAnioLectivo_Per=@i_Idanio_Lectivo
						 and Matricula.IdSede=@i_Sede
						 and Cont_Det.estado=1
						 and dbo.Aca_Contrato_x_Estudiante.estado=1
						 and R.IdGrupoFE = @i_IdGrupoFE
				where not exists (
Select  pf2.IdInstitucion   
from Aca_Pre_Facturacion_det pf2 
where Cont_Det.IdInstitucion = pf2.IdInstitucion 
and Cont_Det.IdInstitucion_Per = pf2.IdInstitucion_Per 
and Cont_Det.IdAnioLectivo_Per = pf2.IdAnioLectivo_Per 
and Cont_Det.IdContrato = pf2.IdContrato 
and Cont_Det.IdPeriodo_Per = pf2.IdPeriodo_Per 
and cont_det.IdRubro = pf2.IdRubro)


end

--Actualizando Detalle de Prefacturacion con los valores de totales de beca y descuento
begin 


	UPDATE Aca_Pre_Facturacion_det  
	SET vt_DescUnitario  = descuentos.total_descuentos, vt_PorDescUnitario = descuentos.total_porcentajes_descuentos, vt_PrecioFinal = descuentos.Precio_Final
		,vt_Subtotal = descuentos.SubTotal, vt_iva_valor = descuentos.iva_valor, vt_total = descuentos.Total
	FROM 
	(
	SELECT dbo.Aca_Pre_Facturacion_det.IdInstitucion, dbo.Aca_Pre_Facturacion_det.IdPreFacturacion, dbo.Aca_Pre_Facturacion_det.Secuencia_Proce, dbo.Aca_Pre_Facturacion_det.secuencia, 
					  dbo.Aca_Pre_Facturacion_det.IdRubro, dbo.Aca_Pre_Facturacion_det.IdInstitucion_contra, dbo.Aca_Pre_Facturacion_det.IdEstudiante, dbo.Aca_Pre_Facturacion_det.IdFamiliar, 
					  dbo.Aca_Pre_Facturacion_det.IdParentesco_cat, dbo.Aca_Pre_Facturacion_det.IdContrato, dbo.Aca_Pre_Facturacion_det.IdInstitucion_Per, dbo.Aca_Pre_Facturacion_det.IdAnioLectivo_Per, 
					  dbo.Aca_Pre_Facturacion_det.IdPeriodo_Per, dbo.Aca_Pre_Facturacion_det.IdGrupoFE, dbo.Aca_Pre_Facturacion_det.vt_cantidad, dbo.Aca_Pre_Facturacion_det.vt_Precio, ISNULL(becas.total_beca, 0) 
					  + ISNULL(excepciones.total_excepcion, 0) AS total_descuentos, ISNULL(becas.total_porcentaje_beca, 0) + ISNULL(excepciones.total_porcentaje_excepcion, 0) AS total_porcentajes_descuentos, 
					  dbo.Aca_Pre_Facturacion_det.vt_Precio - (ISNULL(becas.total_beca, 0) + ISNULL(excepciones.total_excepcion, 0)) AS Precio_Final, (dbo.Aca_Pre_Facturacion_det.vt_Precio - (ISNULL(becas.total_beca, 0) 
					  + ISNULL(excepciones.total_excepcion, 0))) * dbo.Aca_Pre_Facturacion_det.vt_cantidad AS SubTotal, (dbo.Aca_Pre_Facturacion_det.vt_Precio - (ISNULL(becas.total_beca, 0) + ISNULL(excepciones.total_excepcion, 0))) 
					  * dbo.Aca_Pre_Facturacion_det.vt_cantidad * 0 AS iva_valor, (dbo.Aca_Pre_Facturacion_det.vt_Precio - (ISNULL(becas.total_beca, 0) + ISNULL(excepciones.total_excepcion, 0))) 
					  * dbo.Aca_Pre_Facturacion_det.vt_cantidad + (dbo.Aca_Pre_Facturacion_det.vt_Precio - (ISNULL(becas.total_beca, 0) + ISNULL(excepciones.total_excepcion, 0))) 
					  * dbo.Aca_Pre_Facturacion_det.vt_cantidad * 0 AS Total
	FROM     dbo.Aca_Pre_Facturacion_det INNER JOIN
						  (SELECT IdInstitucion, IdContrato, IdRubro, IdInstitucion_Per, IdAnioLectivo_Per, IdPeriodo_Per, SUM(ValorExepcion) AS total_excepcion, SUM(porcentaje_excepcion) AS total_porcentaje_excepcion
						   FROM      dbo.Aca_Contrato_x_Estudiante_det_Excepcion
						   GROUP BY IdInstitucion, IdContrato, IdInstitucion_Per, IdAnioLectivo_Per, IdPeriodo_Per, ValorExepcion, porcentaje_excepcion, IdRubro) AS excepciones ON 
					  dbo.Aca_Pre_Facturacion_det.IdInstitucion = excepciones.IdInstitucion AND dbo.Aca_Pre_Facturacion_det.IdContrato = excepciones.IdContrato AND dbo.Aca_Pre_Facturacion_det.IdRubro = excepciones.IdRubro AND 
					  dbo.Aca_Pre_Facturacion_det.IdInstitucion_Per = excepciones.IdInstitucion_Per AND dbo.Aca_Pre_Facturacion_det.IdAnioLectivo_Per = excepciones.IdAnioLectivo_Per AND 
					  dbo.Aca_Pre_Facturacion_det.IdPeriodo_Per = excepciones.IdPeriodo_Per LEFT OUTER JOIN
						  (SELECT IdInstitucion, IdContrato, IdRubro, IdInstitucion_Per, IdAnioLectivo_Per, IdPeriodo_Per, SUM(valor_beca) AS total_beca, SUM(porc_beca) AS total_porcentaje_beca
						   FROM      dbo.Aca_Contrato_x_Estudiante_det_Beca
						   GROUP BY IdInstitucion, IdContrato, IdRubro, IdInstitucion_Per, IdAnioLectivo_Per, IdPeriodo_Per, valor_beca, porc_beca) AS becas ON dbo.Aca_Pre_Facturacion_det.IdInstitucion = becas.IdInstitucion AND 
					  dbo.Aca_Pre_Facturacion_det.IdContrato = becas.IdContrato AND dbo.Aca_Pre_Facturacion_det.IdInstitucion_Per = becas.IdInstitucion_Per AND dbo.Aca_Pre_Facturacion_det.IdRubro = becas.IdRubro AND 
					  dbo.Aca_Pre_Facturacion_det.IdAnioLectivo_Per = becas.IdAnioLectivo_Per AND dbo.Aca_Pre_Facturacion_det.IdPeriodo_Per = becas.IdPeriodo_Per
	) descuentos
	WHERE Aca_Pre_Facturacion_det.IdInstitucion = descuentos.IdInstitucion and Aca_Pre_Facturacion_det.IdPreFacturacion = descuentos.IdPreFacturacion
			and Aca_Pre_Facturacion_det.Secuencia_Proce = descuentos.Secuencia_Proce and Aca_Pre_Facturacion_det.secuencia = descuentos.secuencia
			and Aca_Pre_Facturacion_det.IdRubro = descuentos.IdRubro and Aca_Pre_Facturacion_det.IdInstitucion_contra = descuentos.IdInstitucion_contra
			and Aca_Pre_Facturacion_det.IdContrato = descuentos.IdContrato and Aca_Pre_Facturacion_det.IdEstudiante = descuentos.IdEstudiante
			and Aca_Pre_Facturacion_det.IdFamiliar = descuentos.IdFamiliar and Aca_Pre_Facturacion_det.IdParentesco_cat = descuentos.IdParentesco_cat
			and Aca_Pre_Facturacion_det.IdInstitucion_Per = descuentos.IdInstitucion_Per and Aca_Pre_Facturacion_det.IdAnioLectivo_Per = descuentos.IdAnioLectivo_Per
			and Aca_Pre_Facturacion_det.IdPeriodo_Per = descuentos.IdPeriodo_Per and Aca_Pre_Facturacion_det.IdGrupoFE = descuentos.IdGrupoFE
			and Aca_Pre_Facturacion_det.IdInstitucion=@i_IdInstitucion
						 and Aca_Pre_Facturacion_det.IdPeriodo_Per=@i_IdPeriodo
						 and Aca_Pre_Facturacion_det.IdAnioLectivo_Per=@i_Idanio_Lectivo
						 --and Matricula.IdSede=@i_Sede
						 --and Cont_Det.estado=1
						 --and dbo.Aca_Contrato_x_Estudiante.estado=1
						 and Aca_Pre_Facturacion_det.IdGrupoFE = @i_IdGrupoFE
						  AND (Aca_Pre_Facturacion_det.IdParentesco_cat = 'REP_ECO' 
--				  --OR fam_x_estud.IdParentesco_cat = 'REP_ECO_DUAL'
				  )
	--table1.id = table2.id


end




--begin -- creando detalle de pre facturacion en base a las  becas por estudiante y año lectivo y por rubros


--insert into Aca_Pre_Facturacion_det
--(IdInstitucion						,IdPreFacturacion						,Secuencia_Proce								,secuencia							
--,IdInstitucion_contra				,IdContrato								,IdRubro										,IdInstitucion_Per
--,IdAnioLectivo_Per					,IdPeriodo_Per							,IdGrupoFE										,IdProducto							
--,vt_cantidad						,vt_Precio								,vt_PorDescUnitario								,vt_DescUnitario					
--,vt_PrecioFinal						,vt_Subtotal							,vt_iva_valor									,vt_total				
--,IdCod_Impuesto_Iva					,observacion_det						
--,IdEstudiante
--,IdFamiliar							,IdParentesco_cat						,tipo_descuento						
--)



-- select 
--@i_IdInstitucion					,@i_IdPrefacturacion					,2												,ROW_NUMBER() OVER (ORDER BY Cont_Beca.IdInstitucion)
--,Cont_Beca.IdInstitucion			,Cont_Beca.IdContrato					,Cont_Beca.IdRubro								,Rub_x_Period.IdInstitucion_per
--,Rub_x_Period.IdAnioLectivo			,Rub_x_Period.IdPeriodo					,R.IdGrupoFE /*@i_IdGrupoFE*/					,R.IdProducto_inv  --antes iva con Grup.IdProducto_inv				
--,1									,Cont_Beca.valor_beca*-1				,Cont_Beca.valor_beca*-1					   ,0
--,Cont_Beca.valor_beca				,Cont_Beca.valor_beca*-1				,0												,Cont_Beca.valor_beca*-1		
--,'IVA'								,+ Aca_Beca.nom_beca+' '+R.Descripcion_rubro
--,dbo.Aca_Contrato_x_Estudiante.IdEstudiante
--,fam_x_estud.IdFamiliar					,fam_x_estud.IdParentesco_cat		,'BECA'

--FROM            dbo.Aca_Rubro AS R INNER JOIN
--                         dbo.Aca_Rubro_x_Aca_Periodo_Lectivo AS Rub_x_Period ON R.IdRubro = Rub_x_Period.IdRubro AND R.IdInstitucion = Rub_x_Period.IdInstitucion_rub INNER JOIN
--                         dbo.Aca_Contrato_x_Estudiante_det_Beca AS Cont_Beca ON Rub_x_Period.IdInstitucion_rub = Cont_Beca.IdInstitucion AND Rub_x_Period.IdRubro = Cont_Beca.IdRubro AND 
--                         Rub_x_Period.IdInstitucion_per = Cont_Beca.IdInstitucion_Per AND Rub_x_Period.IdAnioLectivo = Cont_Beca.IdAnioLectivo_Per AND Rub_x_Period.IdPeriodo = Cont_Beca.IdPeriodo_Per INNER JOIN
--                         dbo.Aca_Contrato_x_Estudiante ON Cont_Beca.IdInstitucion = dbo.Aca_Contrato_x_Estudiante.IdInstitucion AND Cont_Beca.IdContrato = dbo.Aca_Contrato_x_Estudiante.IdContrato INNER JOIN
--                         dbo.Aca_Rubro_Grupo_FE AS Grup ON R.IdInstitucion = Grup.IdInstitucion AND R.IdGrupoFE = Grup.IdGrupoFE INNER JOIN
--                         dbo.Aca_Beca ON Cont_Beca.IdInstitucion = dbo.Aca_Beca.IdInstitucion AND Cont_Beca.IdBeca = dbo.Aca_Beca.IdBeca INNER JOIN
--                         dbo.Aca_matricula AS Matricula ON dbo.Aca_Contrato_x_Estudiante.IdInstitucion = Matricula.IdInstitucion AND dbo.Aca_Contrato_x_Estudiante.IdMatricula = Matricula.IdMatricula AND 
--                         dbo.Aca_Contrato_x_Estudiante.IdEstudiante = Matricula.IdEstudiante 
--						 INNER JOIN
--                  dbo.Aca_estudiante ON Matricula.IdInstitucion = dbo.Aca_estudiante.IdInstitucion AND Matricula.IdEstudiante = dbo.Aca_estudiante.IdEstudiante INNER JOIN
--                  dbo.Aca_Familiar_x_Estudiante AS fam_x_estud ON dbo.Aca_estudiante.IdInstitucion = fam_x_estud.IdInstitucion AND dbo.Aca_estudiante.IdEstudiante = fam_x_estud.IdEstudiante
--				  AND (fam_x_estud.IdParentesco_cat = 'REP_ECO' 
--				  --OR fam_x_estud.IdParentesco_cat = 'REP_ECO_DUAL'
--				  )
						
						
						
--						 and Cont_Beca.IdInstitucion=@i_IdInstitucion
--						 and Cont_Beca.IdPeriodo_Per=@i_IdPeriodo
--						 and Cont_Beca.IdAnioLectivo_Per=@i_Idanio_Lectivo
--						 and Matricula.IdSede=@i_Sede
--						 and dbo.Aca_Contrato_x_Estudiante.estado=1
--						 and R.IdGrupoFE = @i_IdGrupoFE
--where 
--not exists (
--Select  pf2.IdInstitucion  
--from Aca_Pre_Facturacion_det pf2 
--where Cont_Beca.IdInstitucion = pf2.IdInstitucion 
--and Cont_Beca.IdInstitucion_Per = pf2.IdInstitucion_Per 
--and Cont_Beca.IdAnioLectivo_Per = pf2.IdAnioLectivo_Per 
--and Cont_Beca.IdContrato = pf2.IdContrato 
--and Cont_Beca.IdPeriodo_Per = pf2.IdPeriodo_Per 
--and Cont_Beca.IdRubro = pf2.IdRubro
--and pf2.tipo_descuento= 'BECA') 



--end


--begin -- creando detalle de pre facturacion en base a las  exepciones por estudiante y año lectivo

--insert into Aca_Pre_Facturacion_det
--(IdInstitucion						,IdPreFacturacion						,Secuencia_Proce								,secuencia							
--,IdInstitucion_contra				,IdContrato								,IdRubro										,IdInstitucion_Per
--,IdAnioLectivo_Per					,IdPeriodo_Per							,IdGrupoFE										,IdProducto							
--,vt_cantidad						,vt_Precio								,vt_PorDescUnitario								,vt_DescUnitario					
--,vt_PrecioFinal						,vt_Subtotal							,vt_iva_valor									,vt_total				
--,IdCod_Impuesto_Iva					,observacion_det						
--,IdEstudiante
--,IdFamiliar							,IdParentesco_cat						,tipo_descuento
--)



-- select 
--@i_IdInstitucion					,@i_IdPrefacturacion					,3												,ROW_NUMBER() OVER (ORDER BY Cont_Expc.IdInstitucion)
--,Cont_Expc.IdInstitucion			,Cont_Expc.IdContrato					,Cont_Expc.IdRubro								,Rub_x_Period.IdInstitucion_per
--,Rub_x_Period.IdAnioLectivo			,Rub_x_Period.IdPeriodo					,R.IdGrupoFE /*@i_IdGrupoFE*/									,R.IdProducto_inv  --antes iva con Grup.IdProducto_inv			
--,1									,Cont_Expc.ValorExepcion*-1				,Cont_Expc.ValorExepcion*-1						,0
--,Cont_Expc.ValorExepcion			,Cont_Expc.ValorExepcion*-1				,0												,Cont_Expc.ValorExepcion*-1	
--,'IVA'								,R.Descripcion_rubro+' Expeccion'		
--,dbo.Aca_Contrato_x_Estudiante.IdEstudiante
--,fam_x_estud.IdFamiliar					,fam_x_estud.IdParentesco_cat		,'EXCEP'

--FROM            dbo.Aca_Rubro AS R INNER JOIN
--                         dbo.Aca_Rubro_x_Aca_Periodo_Lectivo AS Rub_x_Period ON R.IdRubro = Rub_x_Period.IdRubro AND R.IdInstitucion = Rub_x_Period.IdInstitucion_rub INNER JOIN
--                         dbo.Aca_Contrato_x_Estudiante_det_Excepcion AS Cont_Expc ON Rub_x_Period.IdInstitucion_rub = Cont_Expc.IdInstitucion AND Rub_x_Period.IdRubro = Cont_Expc.IdRubro AND 
--                         Rub_x_Period.IdInstitucion_per = Cont_Expc.IdInstitucion_Per AND Rub_x_Period.IdAnioLectivo = Cont_Expc.IdAnioLectivo_Per AND Rub_x_Period.IdPeriodo = Cont_Expc.IdPeriodo_Per INNER JOIN
--                         dbo.Aca_Contrato_x_Estudiante ON Cont_Expc.IdInstitucion = dbo.Aca_Contrato_x_Estudiante.IdInstitucion AND Cont_Expc.IdContrato = dbo.Aca_Contrato_x_Estudiante.IdContrato INNER JOIN
--                         dbo.Aca_Rubro_Grupo_FE AS Grup ON R.IdInstitucion = Grup.IdInstitucion AND R.IdGrupoFE = Grup.IdGrupoFE INNER JOIN
--                         dbo.Aca_matricula AS Matricula ON dbo.Aca_Contrato_x_Estudiante.IdInstitucion = Matricula.IdInstitucion AND dbo.Aca_Contrato_x_Estudiante.IdMatricula = Matricula.IdMatricula AND 
--                         dbo.Aca_Contrato_x_Estudiante.IdEstudiante = Matricula.IdEstudiante
--						  INNER JOIN
--                  dbo.Aca_estudiante ON Matricula.IdInstitucion = dbo.Aca_estudiante.IdInstitucion AND Matricula.IdEstudiante = dbo.Aca_estudiante.IdEstudiante INNER JOIN
--                  dbo.Aca_Familiar_x_Estudiante AS fam_x_estud ON dbo.Aca_estudiante.IdInstitucion = fam_x_estud.IdInstitucion AND dbo.Aca_estudiante.IdEstudiante = fam_x_estud.IdEstudiante
--				  AND (fam_x_estud.IdParentesco_cat = 'REP_ECO' 
--				  --OR fam_x_estud.IdParentesco_cat = 'REP_ECO_DUAL'
--				  )

--						 and Cont_Expc.IdInstitucion=@i_IdInstitucion
--						 and Cont_Expc.IdPeriodo_Per=@i_IdPeriodo
--						 and Cont_Expc.IdAnioLectivo_Per=@i_Idanio_Lectivo
--						 and Matricula.IdSede=@i_Sede
--						 and dbo.Aca_Contrato_x_Estudiante.estado=1
--						 and R.IdGrupoFE = @i_IdGrupoFE
--where 
--not exists (
--Select  pf2.IdInstitucion  
--from Aca_Pre_Facturacion_det pf2 
--where Cont_Expc.IdInstitucion = pf2.IdInstitucion 
--and Cont_Expc.IdInstitucion_Per = pf2.IdInstitucion_Per 
--and Cont_Expc.IdAnioLectivo_Per = pf2.IdAnioLectivo_Per 
--and Cont_Expc.IdContrato = pf2.IdContrato 
--and Cont_Expc.IdPeriodo_Per = pf2.IdPeriodo_Per 
--and Cont_Expc.IdRubro = pf2.IdRubro
--and pf2.tipo_descuento= 'EXCEP') 


--end

begin
Select pf.IdPreFacturacion from Aca_Pre_Facturacion pf where pf.IdPreFacturacion = @i_IdPrefacturacion
end

end