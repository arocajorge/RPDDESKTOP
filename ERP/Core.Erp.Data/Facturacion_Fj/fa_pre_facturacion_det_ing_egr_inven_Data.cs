using Core.Erp.Data.General;
using Core.Erp.Info.Facturacion_FJ;
using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Data.Facturacion_Fj
{
    public class fa_pre_facturacion_det_ing_egr_inven_Data
    {
        public List<fa_pre_facturacion_det_ing_egr_inven_Info> get_list(int IdEmpresa, decimal IdPrefacturacion)
        {
            try
            {
                List<fa_pre_facturacion_det_ing_egr_inven_Info> Lista;

                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    Lista = (from q in Context.vwfa_pre_facturacion_det_ing_egr_inven
                             where q.IdEmpresa == IdEmpresa && q.IdPreFacturacion == IdPrefacturacion
                             select new fa_pre_facturacion_det_ing_egr_inven_Info
                             {
                                 IdEmpresa = q.IdEmpresa,
                                 IdPreFacturacion = q.IdPreFacturacion,
                                 Secuencia = q.Secuencia,
                                 eg_IdEmpresa = q.eg_IdEmpresa,
                                 eg_IdSucursal = q.eg_IdSucursal,
                                 eg_IdMovi_inven_tipo = q.eg_IdMovi_inven_tipo,
                                 eg_IdNumMovi = q.eg_IdNumMovi,
                                 eg_Secuencia = q.eg_Secuencia,
                                 eg_cantidad = q.eg_cantidad,
                                 in_IdEmpresa = q.in_IdEmpresa,
                                 in_IdSucursal = q.in_IdSucursal,
                                 in_IdMovi_inven_tipo = q.in_IdMovi_inven_tipo,
                                 in_IdNumMovi = q.in_IdNumMovi,
                                 in_Secuencia = q.in_Secuencia,
                                 in_cantidad = q.in_cantidad,
                                 IdProveedor = q.IdProveedor,
                                 cp_fecha = q.cp_fecha,
                                 cp_numero = q.cp_numero,
                                 IdActivoFijo = q.IdActivoFijo,
                                 costo_uni = q.costo_uni,
                                 subtotal = q.subtotal,
                                 IdProducto = q.IdProducto,
                                 IdPunto_cargo = q.IdPunto_cargo_PC,
                                 IdCentroCosto = q.IdCentroCosto,
                                 IdCentroCosto_sub_centro_costo = q.IdCentroCosto_sub_centro_costo,
                                 eg_codigo = q.eg_codigo,
                                 eg_fecha = q.eg_fecha
                             }).ToList();
                }

                return Lista;
            }
            catch (Exception ex)
            {
                string MensajeError = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public bool guardarDB(List<fa_pre_facturacion_det_ing_egr_inven_Info> Lista)
        {
            try
            {
                int Secuencia = 1;
                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    foreach (var item in Lista)
                    {
                        fa_pre_facturacion_det_ing_egr_inven Entity = new fa_pre_facturacion_det_ing_egr_inven();
                        Entity.IdEmpresa = item.IdEmpresa;
                        Entity.IdPreFacturacion = item.IdPreFacturacion;
                        Entity.Secuencia = item.Secuencia = Secuencia;
                        Entity.eg_IdEmpresa = item.eg_IdEmpresa;
                        Entity.eg_IdSucursal = item.eg_IdSucursal;
                        Entity.eg_IdMovi_inven_tipo = item.eg_IdMovi_inven_tipo;
                        Entity.eg_IdNumMovi = item.eg_IdNumMovi;
                        Entity.eg_Secuencia = item.eg_Secuencia;
                        Entity.eg_cantidad = item.eg_cantidad;
                        Entity.in_IdEmpresa = item.in_IdEmpresa;
                        Entity.in_IdSucursal = item.in_IdSucursal;
                        Entity.in_IdMovi_inven_tipo = item.in_IdMovi_inven_tipo;
                        Entity.in_IdNumMovi = item.in_IdNumMovi;
                        Entity.in_Secuencia = item.in_Secuencia;
                        Entity.in_cantidad = item.in_cantidad;
                        Entity.IdProveedor = item.IdProveedor;
                        Entity.cp_fecha = item.cp_fecha;
                        Entity.cp_numero = item.cp_numero;
                        Entity.IdActivoFijo = item.IdActivoFijo;
                        Entity.costo_uni = item.costo_uni;
                        Entity.subtotal = item.subtotal;
                        Entity.IdProducto = item.IdProducto;
                        Entity.IdCentroCosto = item.IdCentroCosto;
                        Entity.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                        Entity.eg_codigo = item.eg_codigo;
                        Entity.eg_fecha = item.eg_fecha;
                        Context.fa_pre_facturacion_det_ing_egr_inven.Add(Entity);
                        Context.SaveChanges();
                        Secuencia++;
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                string MensajeError = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public bool guardarDB(fa_pre_facturacion_det_ing_egr_inven_Info item)
        {
            try
            {
                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                        fa_pre_facturacion_det_ing_egr_inven Entity = new fa_pre_facturacion_det_ing_egr_inven();
                        Entity.IdEmpresa = item.IdEmpresa;
                        Entity.IdPreFacturacion = item.IdPreFacturacion;
                        Entity.Secuencia = item.Secuencia = get_id(item.IdEmpresa,item.IdPreFacturacion);
                        Entity.eg_IdEmpresa = item.eg_IdEmpresa;
                        Entity.eg_IdSucursal = item.eg_IdSucursal;
                        Entity.eg_IdMovi_inven_tipo = item.eg_IdMovi_inven_tipo;
                        Entity.eg_IdNumMovi = item.eg_IdNumMovi;
                        Entity.eg_Secuencia = item.eg_Secuencia;
                        Entity.eg_cantidad = item.eg_cantidad;
                        Entity.in_IdEmpresa = item.in_IdEmpresa;
                        Entity.in_IdSucursal = item.in_IdSucursal;
                        Entity.in_IdMovi_inven_tipo = item.in_IdMovi_inven_tipo;
                        Entity.in_IdNumMovi = item.in_IdNumMovi;
                        Entity.in_Secuencia = item.in_Secuencia;
                        Entity.in_cantidad = item.in_cantidad;
                        Entity.IdProveedor = item.IdProveedor;
                        Entity.cp_fecha = item.cp_fecha;
                        Entity.cp_numero = item.cp_numero;
                        Entity.IdActivoFijo = item.IdActivoFijo;
                        Entity.costo_uni = item.costo_uni;
                        Entity.subtotal = item.subtotal;
                        Entity.IdProducto = item.IdProducto;                    
                        Entity.IdCentroCosto = item.IdCentroCosto;
                        Entity.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                        Entity.eg_codigo = item.eg_codigo;
                        Entity.eg_fecha = item.eg_fecha;
                        Context.fa_pre_facturacion_det_ing_egr_inven.Add(Entity);
                        Context.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                string MensajeError = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        private int get_id(int IdEmpresa, decimal IdPrefacturacion)
        {
            try
            {
                int ID = 1;

                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    var lst = from q in Context.fa_pre_facturacion_det_ing_egr_inven
                              where q.IdEmpresa == IdEmpresa
                              && q.IdPreFacturacion == IdPrefacturacion
                              select q;

                    if (lst.Count() > 0)
                        ID = lst.Max(q => q.Secuencia) + 1;
                }

                return ID;
            }            
            catch (Exception ex)
            {
                string MensajeError = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public bool eliminarDB(int IdEmpresa, decimal IdPrefacturacion)
        {
            try
            {
                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    Context.Database.ExecuteSqlCommand("delete Fj_servindustrias.fa_pre_facturacion_det_ing_egr_inven where IdEmpresa = "+IdEmpresa+" and IdPreFacturacion = "+IdPrefacturacion);
                }
                return true;
            }
            catch (Exception ex)
            {
                string MensajeError = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public bool eliminarDB(int IdEmpresa, decimal IdPrefacturacion, int Secuencia)
        {
            try
            {
                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    Context.Database.ExecuteSqlCommand("delete Fj_servindustrias.fa_pre_facturacion_det_ing_egr_inven where IdEmpresa = " + IdEmpresa + " and IdPreFacturacion = " + IdPrefacturacion + " and Secuencia = "+Secuencia);
                }
                return true;
            }
            catch (Exception ex)
            {
                string MensajeError = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public List<fa_pre_facturacion_det_ing_egr_inven_Info> get_list(int IdEmpresa, string IdCentroCosto, string TIPO, DateTime Fecha_ini, DateTime Fecha_fin, List<int> lst_IdMovi_inven_tipo)
        {
            try
            {
                List<fa_pre_facturacion_det_ing_egr_inven_Info> Lista;
                Fecha_ini = Fecha_ini.Date;
                Fecha_fin = Fecha_fin.Date;

                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    if (TIPO == "ING_CON_DIR")
                    {
                        Lista = (from q in Context.vwfa_pre_facturacion_ing_egr_data
                                 where q.IdEmpresa == IdEmpresa && q.IdCentroCosto == IdCentroCosto
                                 && q.Tipo == TIPO && Fecha_ini <= q.cm_fecha && q.cm_fecha <= Fecha_fin
                                 select new fa_pre_facturacion_det_ing_egr_inven_Info
                                 {
                                     IdEmpresa = q.IdEmpresa,

                                     in_IdEmpresa = q.IdEmpresa,
                                     in_IdSucursal = q.IdSucursal,
                                     in_IdMovi_inven_tipo = q.IdMovi_inven_tipo,
                                     in_IdNumMovi = q.IdNumMovi,
                                     in_Secuencia = q.Secuencia,
                                     in_cantidad = q.dm_cantidad,

                                     eg_IdEmpresa = q.IdEmpresa,
                                     eg_IdSucursal = q.IdSucursal,
                                     eg_IdMovi_inven_tipo = q.IdMovi_inven_tipo,
                                     eg_IdNumMovi = q.IdNumMovi,
                                     eg_Secuencia = q.Secuencia,
                                     eg_cantidad = q.dm_cantidad,
                                     eg_fecha = q.cm_fecha,
                                     costo_uni = q.mv_costo,
                                     IdProveedor = q.IdProveedor,
                                     cp_fecha = q.cm_fecha,
                                     cp_numero = q.num_documento,
                                     subtotal = q.subtotal,
                                     IdActivoFijo = q.IdActivoFijo_AF,
                                     IdProducto = q.IdProducto,
                                     IdPunto_cargo = q.IdPunto_cargo,
                                     IdCentroCosto = q.IdCentroCosto,
                                     IdCentroCosto_sub_centro_costo = q.IdCentroCosto_sub_centro_costo
                                 }).ToList();
                    }else
                        if(TIPO == "ING_VARIOS")
                            Lista = (from q in Context.vwfa_pre_facturacion_ing_egr_data
                                     where q.IdEmpresa == IdEmpresa 
                                     && q.Tipo == TIPO && Fecha_ini <= q.cm_fecha && q.cm_fecha <= Fecha_fin
                                     && lst_IdMovi_inven_tipo.Contains(q.IdMovi_inven_tipo)
                                     select new fa_pre_facturacion_det_ing_egr_inven_Info
                                     {
                                         IdEmpresa = q.IdEmpresa,

                                         in_IdEmpresa = q.IdEmpresa,
                                         in_IdSucursal = q.IdSucursal,
                                         in_IdMovi_inven_tipo = q.IdMovi_inven_tipo,
                                         in_IdNumMovi = q.IdNumMovi,
                                         in_Secuencia = q.Secuencia,
                                         in_cantidad = q.dm_cantidad,
                                         IdProducto = q.IdProducto,
                                         costo_uni = q.mv_costo,
                                         IdProveedor = q.IdProveedor,
                                         cp_fecha = q.cm_fecha,
                                         cp_numero = q.num_documento == null ? q.CodMoviInven : q.num_documento,
                                         subtotal = q.subtotal,
                                         saldo_aux = q.dm_cantidad
                                     }).ToList();
                    else
                            Lista = (from q in Context.vwfa_pre_facturacion_ing_egr_data
                                     where q.IdEmpresa == IdEmpresa && q.IdCentroCosto == IdCentroCosto
                                     && q.Tipo == TIPO && Fecha_ini <= q.cm_fecha && q.cm_fecha <= Fecha_fin
                                     && lst_IdMovi_inven_tipo.Contains(q.IdMovi_inven_tipo)
                                     && q.dm_cantidad >0
                                     select new fa_pre_facturacion_det_ing_egr_inven_Info
                                     {
                                         IdEmpresa = q.IdEmpresa,
                                         
                                         eg_IdEmpresa = q.IdEmpresa,
                                         eg_IdSucursal = q.IdSucursal,
                                         eg_IdMovi_inven_tipo = q.IdMovi_inven_tipo,
                                         eg_IdNumMovi = q.IdNumMovi,
                                         eg_Secuencia = q.Secuencia,
                                         eg_cantidad = q.dm_cantidad,
                                         cm_fecha = q.cm_fecha,
                                         eg_fecha = q.cm_fecha,
                                         eg_codigo = q.eg_codigo,
                                         IdActivoFijo = q.IdActivoFijo_AF,
                                         IdProducto = q.IdProducto,

                                         IdCentroCosto = q.IdCentroCosto,
                                         IdCentroCosto_sub_centro_costo = q.IdCentroCosto_sub_centro_costo,
                                         IdPunto_cargo = q.IdPunto_cargo,
                                         IdPunto_cargo_grupo = q.IdPunto_cargo_grupo,
                                     }).ToList();
                    
                }

                return Lista;
            }
            catch (Exception ex)
            {
                string MensajeError = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }
    }
}
