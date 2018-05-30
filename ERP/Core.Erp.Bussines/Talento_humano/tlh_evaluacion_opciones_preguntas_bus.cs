using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Talento_humano;
using Core.Erp.Data.Talento_humano;
namespace Core.Erp.Business.Talento_humano
{
   public class tlh_evaluacion_opciones_preguntas_bus
   {
       tlh_evaluacion_opciones_preguntas_data data = new tlh_evaluacion_opciones_preguntas_data();
       tlh_evaluacion_opciones_preguntas_det_data bus_detalle = new tlh_evaluacion_opciones_preguntas_det_data();
       public List<tlh_evaluacion_opciones_preguntas_info> get_list(int IdEmpresa)
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
       public List<tlh_evaluacion_opciones_preguntas_info> get_list_pregunta_con_detalle(int IdEmpresa)
       {
           try
           {
               return data.get_list_pregunta_con_detalle(IdEmpresa);
           }
           catch (Exception ex)
           {
               throw;
           }
       }
       public bool Guardar_DB(tlh_evaluacion_opciones_preguntas_info info)
       {
           try
           {
               int IdPregunta=0;
               if (data.Guardar_DB(info, ref IdPregunta))
               {
                   foreach (var item in info.detalle)
                   {
                       item.IdPregunta = IdPregunta;
                       bus_detalle.Guardar_DB(item);
                   }
               }


                   return true; 
           }
           catch (Exception )
           {

               throw ;
           }
       }
       public bool Modificar_DB(tlh_evaluacion_opciones_preguntas_info info)
       {
           try
           {
               if (data.Modificar_DB(info))
               {
                   bus_detalle.EliminarDB_DB(info);
                   foreach (var item in info.detalle)
                   {
                       item.IdPregunta = info.IdPregunta;
                       bus_detalle.Guardar_DB(item);
                   }
               }

               return true;
           }
           catch (Exception)
           {
               throw ;
           }
       }
       public bool Anular_DB(tlh_evaluacion_opciones_preguntas_info info)
       {
           try
           {
            return data.Anular_DB(info);
           }
           catch (Exception ex)
           {         
               throw ;
           }
       }
       public List<tlh_evaluacion_opciones_preguntas_info> get_list_pregunta_con_detalle(int IdEmpresa, int IdCalendario)
       {
           try
           {
               return data.get_list_pregunta_con_detalle(IdEmpresa,  IdCalendario);
           }
           catch (Exception ex)
           {
               throw;
           }
       }
     
    }
}
