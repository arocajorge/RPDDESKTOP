using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Facturacion_FJ;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Facturacion_Fj
{
   public class fa_compensacion_x_ct_centro_costo_Data
   {
       string MensajeError = "";
       tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
       public bool Guardar_DB(fa_compensacion_x_ct_centro_costo_Info info, ref int IdCompensacion)
       {
           try
           {
               using (Entity_Facturacion_FJ db = new Entity_Facturacion_FJ())
               {
                   fa_compensacion_x_ct_centro_costo add = new fa_compensacion_x_ct_centro_costo();
                   add.IdEmpresa = info.IdEmpresa;
                   add.IdCompensacion = Get_Id(info.IdEmpresa);
                   add.IdCentroCosto = info.IdCentroCosto;
                   add.IdCentroCosto_sub_centro_costo = info.IdCentroCosto_sub_centro_costo;
                   add.num_cuotas_meses_x_banco = info.num_cuotas_meses_x_banco;
                   add.num_cuotas_meses_x_centro_costo = info.num_cuotas_meses_x_centro_costo;
                   add.tasa_interes_anual_x_banco = info.tasa_interes_anual_x_banco;
                   add.tasa_interes_anual_x_centro_costo = info.tasa_interes_anual_x_centro_costo;
                   add.valor_a_financiar = info.valor_a_financiar;
                   add.observacion = info.observacion;
                   db.fa_compensacion_x_ct_centro_costo.Add(add);
                   db.SaveChanges();
                   IdCompensacion = add.IdCompensacion;
                   return true;
               }
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
               MensajeError = ex.ToString();
               throw new Exception(ex.ToString());
           }
       }


       public bool Modificar_DB(fa_compensacion_x_ct_centro_costo_Info info)
       {
           try
           {
               using (Entity_Facturacion_FJ db = new Entity_Facturacion_FJ())
               {
                   var add = db.fa_compensacion_x_ct_centro_costo.FirstOrDefault(v => v.IdEmpresa == info.IdEmpresa && v.IdCompensacion == info.IdCompensacion );

                   add.IdCentroCosto = info.IdCentroCosto;
                   add.IdCentroCosto_sub_centro_costo = info.IdCentroCosto_sub_centro_costo;
                   add.num_cuotas_meses_x_banco = info.num_cuotas_meses_x_banco;
                   add.num_cuotas_meses_x_centro_costo = info.num_cuotas_meses_x_centro_costo;
                   add.tasa_interes_anual_x_banco = info.tasa_interes_anual_x_banco;
                   add.tasa_interes_anual_x_centro_costo = info.tasa_interes_anual_x_centro_costo;
                   add.valor_a_financiar = info.valor_a_financiar;
                   add.observacion = info.observacion;

                   db.SaveChanges();
                   return true;
               }
           }
           catch (Exception ex)
           {

               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
               MensajeError = ex.ToString();
               throw new Exception(ex.ToString());
           }
       }



       public bool Anular_DB(fa_compensacion_x_ct_centro_costo_Info info)
       {
           try
           {
               using (Entity_Facturacion_FJ db = new Entity_Facturacion_FJ())
               {
                   var add = db.fa_compensacion_x_ct_centro_costo.FirstOrDefault(v => v.IdEmpresa == info.IdEmpresa && v.IdCompensacion == info.IdCompensacion);

                   add.estado = false;
               
                   db.SaveChanges();
                   return true;
               }
           }
           catch (Exception ex)
           {

               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
               MensajeError = ex.ToString();
               throw new Exception(ex.ToString());
           }
       }




       public List<fa_compensacion_x_ct_centro_costo_Info> GetList(int IdEmpresa)
       {
           try
           {
               List<fa_compensacion_x_ct_centro_costo_Info> lista = new List<fa_compensacion_x_ct_centro_costo_Info>();
               using (Entity_Facturacion_FJ db = new Entity_Facturacion_FJ())
               {
                   var query = from q in db.vwfa_compensacion_x_ct_centro_costo
                               where
                               q.IdEmpresa == IdEmpresa
                               select q;

                   foreach (var item in query)
                   {
                       fa_compensacion_x_ct_centro_costo_Info add = new fa_compensacion_x_ct_centro_costo_Info();
                       add.IdEmpresa = item.IdEmpresa;
                       add.IdCompensacion = item.IdCompensacion;
                       add.IdCentroCosto = item.IdCentroCosto;
                       add.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                       add.num_cuotas_meses_x_banco = item.num_cuotas_meses_x_banco;
                       add.num_cuotas_meses_x_centro_costo = item.num_cuotas_meses_x_centro_costo;
                       add.tasa_interes_anual_x_banco = item.tasa_interes_anual_x_banco;
                       add.tasa_interes_anual_x_centro_costo = item.tasa_interes_anual_x_centro_costo;
                       add.valor_a_financiar = item.valor_a_financiar;
                       add.nom_Centro_costo = item.nom_Centro_costo;
                       add.nom_Centro_costo_sub_centro_costo = item.nom_Centro_costo_sub_centro_costo;
                       add.observacion = item.observacion;
                       add.observacion = item.observacion;
                       lista.Add(add);
                   }
               }

               return lista;
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
               MensajeError = ex.ToString();
               throw new Exception(ex.ToString());
           }
       }

       public int Get_Id(int IdEmpresa)
       {
           try
           {
               int Id;
               Entity_Facturacion_FJ db = new Entity_Facturacion_FJ();
               var selecte = db.fa_compensacion_x_ct_centro_costo.Count(q => q.IdEmpresa == IdEmpresa);
               if (selecte == 0)
               {
                   Id = 1;
               }
               else
               {
                   var select_em = (from q in db.fa_compensacion_x_ct_centro_costo
                                    where q.IdEmpresa == IdEmpresa
                                    select q.IdCompensacion).Max();
                   Id = Convert.ToInt32(select_em.ToString()) + 1;
               }
               return Id;
           }
           catch (Exception ex)
           {
              return 0;
           }
       }

     
       
    }
}
