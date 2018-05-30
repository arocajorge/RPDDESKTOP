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
  public  class tlh_evaluacion_opciones_preguntas_respuesta_respuesta_data
  {
      public List<tlh_evaluacion_opciones_preguntas_respuesta_info> get_list(int IdEmpresa)
      {
          try
          {
              List<tlh_evaluacion_opciones_preguntas_respuesta_info> lista = new List<tlh_evaluacion_opciones_preguntas_respuesta_info>();
              using (Entity_talento_humano db = new Entity_talento_humano())
              {
                  lista = (from q in db.tlh_evaluacion_opciones_preguntas_respuesta
                           where q.IdEmpresa == IdEmpresa
                           select new tlh_evaluacion_opciones_preguntas_respuesta_info
                           {
                               IdEmpresa = q.IdEmpresa,
                               IdCalendario = q.IdCalendario,
                               Observacion = q.Observacion,
                               Fecha_evaluacion = q.Fecha_evaluacion,
                               Numero_preguntas=q.Numero_preguntas,
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
      public bool Guardar_DB(tlh_evaluacion_opciones_preguntas_respuesta_info info)
      {
          try
          {
            if(  si_existe(info.IdEmpresa, info.IdCalendario))
              return true;
              using (Entity_talento_humano entity = new Entity_talento_humano())
              {
                  tlh_evaluacion_opciones_preguntas_respuesta add = new tlh_evaluacion_opciones_preguntas_respuesta();
                  add.IdEmpresa = info.IdEmpresa;
                  add.IdCalendario = info.IdCalendario;
                  add.Numero_preguntas = info.Numero_preguntas;
                  add.Fecha_evaluacion = info.Fecha_evaluacion;
                  add.Observacion = (info.Observacion == null) ? "Evaluacion de la preunta "+info.info_pregunta.Descripcion+" al " + info.Fecha_evaluacion .Date: info.Observacion;
                  add.estado = true;
                  entity.tlh_evaluacion_opciones_preguntas_respuesta.Add(add);
                  entity.SaveChanges();
                  return true;
              }
          }
          catch (Exception ex)
          {
              throw;
          }
      }
      public bool Modificar_DB(tlh_evaluacion_opciones_preguntas_respuesta_info info)
      {
          try
          {
              using (Entity_talento_humano db = new Entity_talento_humano())
              {
                  var add = db.tlh_evaluacion_opciones_preguntas_respuesta.FirstOrDefault(v => v.IdEmpresa == info.IdEmpresa && v.IdCalendario == info.IdCalendario);
                  add.Fecha_evaluacion = info.Fecha_evaluacion;
                  add.Numero_preguntas = info.Numero_preguntas;
                  add.Observacion = info.Observacion;
                  db.SaveChanges();
                  return true;
              }
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
              using (Entity_talento_humano db = new Entity_talento_humano())
              {
                  var add = db.tlh_evaluacion_opciones_preguntas_respuesta.FirstOrDefault(v => v.IdEmpresa == info.IdEmpresa && v.IdCalendario == info.IdCalendario);
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
      private bool si_existe(int IdEmpresa, int IdCalendario)
      {
          try
          {
              using (Entity_talento_humano db = new Entity_talento_humano())
              {
                  var query = (from q in db.tlh_evaluacion_opciones_preguntas_respuesta
                               where q.IdEmpresa == IdEmpresa
                               &&q.IdCalendario==IdCalendario
                               select q);
                  if (query.Count() == 0)
                  {
                      return false;
                  }
                  else
                      return true;
              }
          }
          catch (Exception ex)
          {

              throw;
          }
      }
    }
}
