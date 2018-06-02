using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Talento_humano;
using Core.Erp.Data.Talento_humano;

namespace Core.Erp.Business.Talento_humano
{
   public class tlh_evaluacion_opciones_preguntas_respuesta_bus
   {
       tlh_evaluacion_opciones_preguntas_respuesta_respuesta_data data = new tlh_evaluacion_opciones_preguntas_respuesta_respuesta_data();
       tlh_evaluacion_opciones_preguntas_respuesta_respuesta_det_data bus_detalle = new tlh_evaluacion_opciones_preguntas_respuesta_respuesta_det_data();
       public List<tlh_evaluacion_opciones_preguntas_respuesta_info> get_list(int IdEmpresa)
       {
           try
           {
               return data.get_list(IdEmpresa);
           }
           catch (Exception ex)
           {
               throw;
           }
       }
       public bool Guardar_DB(tlh_evaluacion_opciones_preguntas_respuesta_info info)
       {
           try
           {
               if (data.Guardar_DB(info))
               {
                   foreach (var item in info.detalle)
                   {
                       item.IdEmpresa = info.IdEmpresa;
                       item.IdPregunta = info.info_pregunta.IdPregunta;
                       item.IdCalendario = info.IdCalendario;
                       item.Respueta = true;
                       item.secuencia = get_num_opcion(item);
                       bus_detalle.Guardar_DB(item);

                   }
                  
               }


               return true;
           }
           catch (Exception)
           {

               throw;
           }
       }
       public bool Modificar_DB(tlh_evaluacion_opciones_preguntas_respuesta_info info)
       {
           try
           {
               if (data.Modificar_DB(info))
               {
                   foreach (var item in info.detalle)
                   {
                       item.IdPregunta = info.IdCalendario;
                       bus_detalle.Guardar_DB(item);
                   }
               }

               return true;
           }
           catch (Exception)
           {
               throw;
           }
       }
       public bool Anular_DB(tlh_evaluacion_opciones_preguntas_respuesta_info info)
       {
           try
           {
               return data.Anular_DB(info);
           }
           catch (Exception ex)
           {
               throw;
           }
       }
       private int get_num_opcion(tlh_evaluacion_opciones_preguntas_respuesta_det_info info)
       {
           try
           {
               int valorRetorna = 0;
               if (info.check1)
                   valorRetorna = 1;
               if (info.check2)
                   valorRetorna= 2;
               if (info.check3)
                   valorRetorna = 3;
               if (info.check4)
                   valorRetorna = 4;
               if (info.check5)
                   valorRetorna = 5;
               return valorRetorna;
           }
           catch (Exception )
           {
               
               throw;
           }
       }
    }
}
