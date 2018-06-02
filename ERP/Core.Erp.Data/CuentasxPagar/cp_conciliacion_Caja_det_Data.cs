using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.CuentasxPagar
{
   public class cp_conciliacion_Caja_det_Data
    {
       string mensaje = "";
       
       public int Get_Secuencia_det(int IdEmpresa,decimal IdConciliacion_Caja)
       {
           try
           {
               int Id;
               EntitiesCuentasxPagar ECXP = new EntitiesCuentasxPagar();

              
                   var select_ = (from t in ECXP.cp_conciliacion_Caja_det
                                  where t.IdEmpresa == IdEmpresa && t.IdConciliacion_Caja == IdConciliacion_Caja
                                  select t);

                   if (select_.Count() <= 0)
                       Id = 1;
                   else
                   {
                       Id = Convert.ToInt32(select_.Max(q => q.Secuencia)) + 1;
                   }
                   return Id;
               
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                    "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.ToString() + " " + ex.Message;
               throw new Exception(ex.ToString());
           }
       }
       
       public Boolean GrabarDB(List<cp_conciliacion_Caja_det_Info> lista, ref string mensaje)
       {
           Boolean res = true;
           try
           {

               foreach (var item in lista)
               {
                   using (EntitiesCuentasxPagar context = new EntitiesCuentasxPagar())
                   {
                       var lst = from q in context.cp_conciliacion_Caja_det
                                 where q.IdEmpresa == item.IdEmpresa
                                 && q.IdConciliacion_Caja == item.IdConciliacion_Caja
                                 && q.Secuencia == item.Secuencia
                                 select q;

                       if (lst.Count() == 0)
                       {
                           var lst_2 = from q in context.cp_conciliacion_Caja_det
                                       where q.IdEmpresa_OGiro == item.IdEmpresa_OGiro
                                       && q.IdTipoCbte_Ogiro == item.IdTipoCbte_Ogiro
                                       && q.IdCbteCble_Ogiro == item.IdCbteCble_Ogiro
                                       && q.IdConciliacion_Caja == item.IdConciliacion_Caja
                                       select q;

                           if (lst_2.Count() == 0)
                           {
                               cp_conciliacion_Caja_det address = new cp_conciliacion_Caja_det();
                               address.IdEmpresa = item.IdEmpresa;
                               address.IdConciliacion_Caja = item.IdConciliacion_Caja;
                               address.Secuencia = item.Secuencia;
                               address.IdEmpresa_OGiro = item.IdEmpresa_OGiro;
                               address.IdCbteCble_Ogiro = item.IdCbteCble_Ogiro;
                               address.IdTipoCbte_Ogiro = item.IdTipoCbte_Ogiro;
                               address.IdUsuario = item.IdUsuario;
                               address.Fecha_Transac = item.Fecha_Transac;
                               address.nom_pc = item.nom_pc;
                               address.ip = item.ip;
                               address.IdCentroCosto = item.IdCentroCosto;
                               address.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                               address.IdTipoMovi = item.IdTipoMovi;
                               address.Valor_a_aplicar = item.Valor_a_aplicar;
                               address.Tipo_documento = item.Tipo_documento;
                               address.IdOrdenPago_OP = item.IdOrdenPago_OP;
                               address.IdEmpresa_OP = item.IdEmpresa_OP;
                               context.cp_conciliacion_Caja_det.Add(address);
                               context.SaveChanges();
                           }                           
                       }                       
                   }
               }
               return res;    
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.ToString() + " " + ex.Message;
               throw new Exception(ex.ToString());
           }
       }

       public Boolean GrabarDB(cp_conciliacion_Caja_det_Info info, ref string mensaje)
       {
           try
           {
                   using (EntitiesCuentasxPagar context = new EntitiesCuentasxPagar())
                   {

                       var lst = from q in context.cp_conciliacion_Caja_det
                                 where q.IdEmpresa == info.IdEmpresa
                                 && q.IdConciliacion_Caja == info.IdConciliacion_Caja
                                 && q.Secuencia == info.Secuencia
                                 select q;

                       if (lst.Count()==0)
                       {
                           var lst_2 = from q in context.cp_conciliacion_Caja_det
                                       where q.IdEmpresa_OGiro == info.IdEmpresa_OGiro
                                       && q.IdTipoCbte_Ogiro == info.IdTipoCbte_Ogiro
                                       && q.IdCbteCble_Ogiro == info.IdCbteCble_Ogiro
                                       && q.IdConciliacion_Caja == info.IdConciliacion_Caja
                                       select q;

                           if (lst_2.Count() == 0)
                           {
                               cp_conciliacion_Caja_det address = new cp_conciliacion_Caja_det();
                               address.IdEmpresa = info.IdEmpresa;
                               address.IdConciliacion_Caja = info.IdConciliacion_Caja;
                               address.Secuencia = info.Secuencia;
                               address.IdEmpresa_OGiro = info.IdEmpresa_OGiro;
                               address.IdCbteCble_Ogiro = info.IdCbteCble_Ogiro;
                               address.IdTipoCbte_Ogiro = info.IdTipoCbte_Ogiro;
                               address.IdUsuario = info.IdUsuario;
                               address.Fecha_Transac = DateTime.Now;
                               address.nom_pc = info.nom_pc;
                               address.ip = info.ip;
                               address.IdCentroCosto = info.IdCentroCosto;
                               address.IdCentroCosto_sub_centro_costo = info.IdCentroCosto_sub_centro_costo;
                               address.IdTipoMovi = info.IdTipoMovi;
                               address.Valor_a_aplicar = info.Valor_a_aplicar;
                               address.Tipo_documento = info.Tipo_documento;
                               context.cp_conciliacion_Caja_det.Add(address);
                               context.SaveChanges();
                           }                           
                       }                      
                   }
                   return true;
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.ToString() + " " + ex.Message;
               throw new Exception(ex.ToString());
           }
       }

       public Boolean ModificarDB(cp_conciliacion_Caja_det_Info info, ref string mensaje)
       {
           try
           {
               using (EntitiesCuentasxPagar context = new EntitiesCuentasxPagar())
               {
                   cp_conciliacion_Caja_det address = context.cp_conciliacion_Caja_det.FirstOrDefault(q => q.IdEmpresa == info.IdEmpresa && q.IdConciliacion_Caja == info.IdConciliacion_Caja && q.IdEmpresa_OGiro == info.IdEmpresa_OGiro && q.IdTipoCbte_Ogiro == info.IdTipoCbte_Ogiro && q.IdCbteCble_Ogiro == info.IdCbteCble_Ogiro);
                   if (address!=null)
                   {   
                       address.Valor_a_aplicar = info.Valor_a_aplicar;
                       context.SaveChanges();    
                   }
               }
               return true;
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.ToString() + " " + ex.Message;
               throw new Exception(ex.ToString());
           }
       }

       public Boolean ModificarOP(int IdEmpresa_conci, decimal IdConci_caja, int IdEmpresa_FP_ND, decimal IdCbteCble_FP_ND, int IdTipoCbte_FP_ND, int IdEmpresa_OP, decimal IdOrdenPago_OP)
       {
           try
           {
               using (EntitiesCuentasxPagar context = new EntitiesCuentasxPagar())
               {
                   cp_conciliacion_Caja_det address = context.cp_conciliacion_Caja_det.FirstOrDefault(q => q.IdEmpresa == IdEmpresa_conci && q.IdConciliacion_Caja == IdConci_caja && q.IdEmpresa_OGiro == IdEmpresa_FP_ND && q.IdTipoCbte_Ogiro == IdTipoCbte_FP_ND && q.IdCbteCble_Ogiro == IdCbteCble_FP_ND);
                   if (address != null)
                   {
                       address.IdEmpresa_OP = IdEmpresa_OP;
                       address.IdOrdenPago_OP = IdOrdenPago_OP;
                       context.SaveChanges();
                   }
               }
               return true;
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.ToString() + " " + ex.Message;
               throw new Exception(ex.ToString());
           }
       }

       public List<cp_conciliacion_Caja_det_Info> Get_List_Conciliacion_Caja_Det(int IdEmpresa, decimal IdConciliacion_caja)
       {
           try
           {
               List<cp_conciliacion_Caja_det_Info> lM = new List<cp_conciliacion_Caja_det_Info>();
               using (EntitiesCuentasxPagar Base = new EntitiesCuentasxPagar())
               {
                   lM = (from T in Base.vwcp_Conciliacion_Caja_det
                         where T.IdEmpresa == IdEmpresa
                         && T.IdConciliacion_Caja == IdConciliacion_caja
                         select new cp_conciliacion_Caja_det_Info
                         {
                             IdEmpresa = T.IdEmpresa,
                             IdConciliacion_Caja = T.IdConciliacion_Caja,

                             Secuencia = T.Secuencia,

                             IdEmpresa_OGiro = T.IdEmpresa_OGiro,
                             IdCbteCble_Ogiro = T.IdCbteCble_Ogiro,
                             IdTipoCbte_Ogiro = T.IdTipoCbte_Ogiro,
                             pe_cedulaRuc = T.pe_cedulaRuc,
                             IdTipoMovi = T.IdTipoMovi,
                             IdCentroCosto = T.IdCentroCosto,
                             IdCentroCosto_sub_centro_costo = T.IdCentroCosto_sub_centro_costo,
                             Valor_a_aplicar = T.Valor_a_aplicar,
                             Tipo_documento = T.Tipo_documento,
                             IdEmpresa_OP = T.IdEmpresa_OP_conci,
                             IdOrdenPago_OP = T.IdOrdenPago_OP_Conci,
                             // datos de Orden Giro
                             Info_Orden_Giro = new cp_orden_giro_Info
                             {
                                 IdOrden_giro_Tipo = T.IdOrden_giro_Tipo,
                                 IdProveedor = T.IdProveedor,
                                 co_fechaOg = T.co_fechaOg,
                                 co_serie = T.co_serie,
                                 co_factura = T.co_factura,
                                 co_FechaFactura = T.co_FechaFactura,
                                 co_FechaFactura_vct = T.co_FechaFactura_vct,
                                 co_observacion = T.co_observacion,
                                 co_subtotal_iva = T.co_subtotal_iva,
                                 co_subtotal_siniva = T.co_subtotal_siniva,
                                 co_baseImponible = T.co_baseImponible,
                                 co_Por_iva = T.co_Por_iva,
                                 co_valoriva = T.co_valoriva,
                                 co_total = T.co_total,
                                 Valor_a_Pagar = T.co_valorpagar,
                                 IdIden_credito = T.IdIden_credito,
                                 IdTipoFlujo = T.IdTipoFlujo,
                                 IdCtaCble_Gasto = T.IdCtaCble_Gasto,
                                 Estado = T.Estado,
                                 IdCentroCosto = T.IdCentroCosto,
                                 Num_Autorizacion = T.Num_Autorizacion,
                                 Total_Retencion = T.Total_Retencion,
                                 IdRetencion = T.IdRetencion,
                                 IdTipoMovi = T.IdTipoMovi,
                             }
                         }).ToList();

                   
               }
               return (lM);
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.ToString() + " " + ex.Message;
               throw new Exception(ex.ToString());
           }
       }

       public bool desvincularDB(int IdEmpresa, int IdTipoCbte, decimal IdCbteCble, int IdEmpresa_conci, decimal IdConciliacion)
       {
           try
           {
               using (EntitiesCuentasxPagar Context = new EntitiesCuentasxPagar())
               {
                   Context.Database.ExecuteSqlCommand("DELETE cp_conciliacion_Caja_det WHERE IdEmpresa = "+IdEmpresa_conci+" and IdConciliacion_Caja = "+IdConciliacion+" and IdEmpresa_OGiro = "+IdEmpresa+" and IdTipoCbte_Ogiro = "+IdTipoCbte+" and IdCbteCble_Ogiro = "+IdCbteCble);
               }
               return true;
           }
           catch (Exception)
           {
               
               throw;
           }
       }

    }
}
