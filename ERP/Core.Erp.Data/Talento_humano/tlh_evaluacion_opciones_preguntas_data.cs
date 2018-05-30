using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Talento_humano;
using Core.Erp.Info.General;
using Core.Erp.Data.General;
namespace Core.Erp.Data.Talento_humano
{
  public  class tlh_evaluacion_opciones_preguntas_data
  {
     public  List<tlh_evaluacion_opciones_preguntas_info> get_list(int IdEmpresa)
      {
          try
          {
              List<tlh_evaluacion_opciones_preguntas_info> lista = new List<tlh_evaluacion_opciones_preguntas_info>();
              using (Entity_talento_humano db = new Entity_talento_humano())
              {
                  lista = (from q in db.tlh_evaluacion_opciones_preguntas
                                   where q.IdEmpresa == IdEmpresa
                           select new tlh_evaluacion_opciones_preguntas_info
                                   {
                                       IdEmpresa = q.IdEmpresa,
                                       IdPregunta = q.IdPregunta,
                                       IdOpciones = q.IdOpciones,
                                       Numero_opciones = q.Numero_opciones,
                                       Descripcion = q.Descripcion,
                                       estado = q.estado

                                   }).ToList();
              }

              return lista;
          }
          catch (Exception ex)
          {

              throw;
          }
      }
      public bool Guardar_DB(tlh_evaluacion_opciones_preguntas_info info, ref int IdPregunta)
      {
          try
          {
              using (Entity_talento_humano entity = new Entity_talento_humano())
              {
                  tlh_evaluacion_opciones_preguntas add = new tlh_evaluacion_opciones_preguntas();
                  add.IdEmpresa = info.IdEmpresa;
                  add.IdOpciones = info.IdOpciones;
                  add.IdPregunta =GetId(info.IdEmpresa);
                  add.Numero_opciones = info.Numero_opciones;
                  add.Descripcion = info.Descripcion;
                  add.estado = true;
                  entity.tlh_evaluacion_opciones_preguntas.Add(add);
                  entity.SaveChanges();
                  IdPregunta = add.IdPregunta;
                  return true;
              }
          }
          catch (Exception ex)
          {
              throw;
          }
      }
      public bool Modificar_DB(tlh_evaluacion_opciones_preguntas_info info)
      {
          try
          {
              using (Entity_talento_humano db = new Entity_talento_humano())
              {
                  var add = db.tlh_evaluacion_opciones_preguntas.FirstOrDefault(v => v.IdEmpresa == info.IdEmpresa && v.IdPregunta == info.IdPregunta);
                  add.IdOpciones = info.IdOpciones;
                  add.Descripcion = info.Descripcion;
                  db.SaveChanges();
                  return true;
              }
          }
          catch (Exception )
          {

              throw;
          }
      }
      public bool Anular_DB(tlh_evaluacion_opciones_preguntas_info info)
      {
          try
          {
              using (Entity_talento_humano db = new Entity_talento_humano())
              {
                  var add = db.tlh_evaluacion_opciones_preguntas.FirstOrDefault(v => v.IdEmpresa == info.IdEmpresa && v.IdPregunta == info.IdPregunta);
                  if (add == null)
                      return false;
                  add.estado = false;
                  db.SaveChanges();
                  return true;
              }
          }
          catch (Exception ex)
          {
              throw;

          }
      }
      private int GetId(int IdEmpresa)
      {
          try
          {
              int Secuencia = 0;

              using (Entity_talento_humano db = new Entity_talento_humano())
              {
                  var query = (from q in db.tlh_evaluacion_opciones_preguntas
                               where q.IdEmpresa==IdEmpresa
                               select q);

                  if (query.Count() == 0)
                  {
                      Secuencia = 1;
                  }
                  else
                  {
                      var query2 = (from q in db.tlh_evaluacion_opciones_preguntas
                                    where q.IdEmpresa == IdEmpresa
                                    select q.IdPregunta).Max() + 1;
                      Secuencia = Convert.ToInt32(query2.ToString());  
                  }

                  return Secuencia;
              }
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
              tlh_evaluacion_opciones_preguntas_det_data data_detalle = new tlh_evaluacion_opciones_preguntas_det_data();
              List<tlh_evaluacion_opciones_preguntas_info> lista = new List<tlh_evaluacion_opciones_preguntas_info>();
              using (Entity_talento_humano db = new Entity_talento_humano())
              {
                  lista = (from q in db.tlh_evaluacion_opciones_preguntas
                           where q.IdEmpresa == IdEmpresa
                           select new tlh_evaluacion_opciones_preguntas_info
                           {
                               IdEmpresa = q.IdEmpresa,
                               IdPregunta = q.IdPregunta,
                               IdOpciones = q.IdOpciones,
                               Numero_opciones = q.Numero_opciones,
                               Descripcion = q.Descripcion,
                               estado = q.estado,
                              
                           }).ToList();
              }

              foreach (var item in lista)
              {
                  item.detalle = new List<tlh_evaluacion_opciones_preguntas_det_info>();
                  item.detalle = data_detalle.get_list(item.IdEmpresa, item.IdPregunta);
              }
              return lista;
          }
          catch (Exception ex)
          {

              throw;
          }
      }
      public List<tlh_evaluacion_opciones_preguntas_info> get_list_pregunta_con_detalle(int IdEmpresa, int IdCalendario)
      {
          try
          {
              tlh_evaluacion_opciones_preguntas_det_data data_detalle = new tlh_evaluacion_opciones_preguntas_det_data();
              List<tlh_evaluacion_opciones_preguntas_info> lista = new List<tlh_evaluacion_opciones_preguntas_info>();
              using (Entity_talento_humano db = new Entity_talento_humano())
              {
                  lista = (from q in db.vwtlh_evaluacion_opciones_preguntas
                           where q.IdEmpresa == IdEmpresa
                           && q.IdCalendario==IdCalendario
                           select new tlh_evaluacion_opciones_preguntas_info
                           {
                               IdEmpresa = q.IdEmpresa,
                               IdPregunta = q.IdPregunta,
                               IdOpciones = q.IdOpciones,
                               Numero_opciones = q.Numero_opciones,
                               Descripcion = q.Descripcion,
                               eliminar=true,
                               check=true
                           }).ToList();
              }

              foreach (var item in lista)
              {
                  item.detalle = new List<tlh_evaluacion_opciones_preguntas_det_info>();
                  item.detalle = data_detalle.get_list(item.IdEmpresa, item.IdPregunta);
              }
              return lista;
          }
          catch (Exception ex)
          {

              throw;
          }
      }
   
    }
}
