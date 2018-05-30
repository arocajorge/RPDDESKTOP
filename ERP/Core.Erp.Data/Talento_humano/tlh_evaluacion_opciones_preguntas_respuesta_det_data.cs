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
   public class tlh_evaluacion_opciones_preguntas_respuesta_respuesta_det_data
   {
       public bool Guardar_DB(tlh_evaluacion_opciones_preguntas_respuesta_det_info info)
       {
           try
           {
               using (Entity_talento_humano entity = new Entity_talento_humano())
               {
                  if(!si_existe(info.IdEmpresa,info.IdCalendario,info.IdEmpleado,info.IdPregunta))

                  {
                   tlh_evaluacion_opciones_preguntas_respuesta_det add = new tlh_evaluacion_opciones_preguntas_respuesta_det();
                   add.IdEmpresa = info.IdEmpresa;
                   add.IdCalendario = info.IdCalendario;
                   add.IdEmpleado = info.IdEmpleado;
                   add.IdPregunta = info.IdPregunta;
                   add.secuencia = info.secuencia;
                   add.Respueta = info.Respueta;
                   add.Observacion = info.Observacion;
                   entity.tlh_evaluacion_opciones_preguntas_respuesta_det.Add(add);
                  }
                   else
                  {
                      var modifi = entity.tlh_evaluacion_opciones_preguntas_respuesta_det.FirstOrDefault(v => v.IdEmpresa == info.IdEmpresa 
                      && v.IdCalendario == info.IdCalendario
                      && v.IdCalendario==info.IdCalendario
                      && v.IdPregunta==info.IdPregunta
                      && v.IdEmpleado==info.IdEmpleado);               
                      modifi.secuencia = info.secuencia;
                  }
                      entity.SaveChanges();
                   return true;
               }
           }
           catch (Exception ex)
           {
               throw;
           }
       }
       public bool EliminarDB_DB(int IdEmpresa, int IdCalendario, int IdPregunta)
       {
           try
           {
               using (Entity_talento_humano db = new Entity_talento_humano())
               {
                   string Sql = "delete Talento_humano.tlh_evaluacion_opciones_preguntas_respuesta_det where IdEmpresa='" + IdEmpresa + "' and IdCalendario='" + IdCalendario + "' and IdPregunta='" + IdPregunta + "'";
                   db.Database.ExecuteSqlCommand(Sql);
                   return true;
               }
           }
           catch (Exception ex)
           {
               throw;

           }
       }
       public List<tlh_evaluacion_opciones_preguntas_respuesta_det_info> get_list(int IdEmpresa, int IdCalendario)
       {
           try
           {
               List<tlh_evaluacion_opciones_preguntas_respuesta_det_info> lista = new List<tlh_evaluacion_opciones_preguntas_respuesta_det_info>();
               using (Entity_talento_humano db = new Entity_talento_humano())
               {
                   lista = (from q in db.tlh_evaluacion_opciones_preguntas_respuesta_det
                            where q.IdEmpresa == IdEmpresa
                            && q.IdCalendario == IdCalendario
                            select new tlh_evaluacion_opciones_preguntas_respuesta_det_info
                            {
                                IdEmpresa = q.IdEmpresa,
                                IdCalendario = q.IdCalendario,
                                IdPregunta = q.IdPregunta,
                                secuencia = q.secuencia,
                                IdEmpleado = q.IdEmpleado,
                                Observacion = q.Observacion,
                                Respueta = q.Respueta,
                                eliminar=true
                            }).ToList();
               }

               return lista;
           }
           catch (Exception ex)
           {

               throw;
           }
       }
       public List<tlh_evaluacion_opciones_preguntas_respuesta_det_info> get_list_empleado_x_nomina(int IdEmpresa, int IdNomina)
       {
           try
           {
               List<tlh_evaluacion_opciones_preguntas_respuesta_det_info> lista = new List<tlh_evaluacion_opciones_preguntas_respuesta_det_info>();
               using (Entity_talento_humano db = new Entity_talento_humano())
               {
                   lista = (from q in db.vwtlh_evaluacion_opciones_preguntas_respuesta
                            where q.IdEmpresa == IdEmpresa
                            && q.IdTipoNomina == IdNomina
                            select new tlh_evaluacion_opciones_preguntas_respuesta_det_info
                            {
                                IdEmpresa = q.IdEmpresa,
                                IdTipoNomina = q.IdTipoNomina,
                                pe_apellido = q.pe_apellido+" "+q.pe_nombre,
                                pe_nombre = q.pe_nombre,
                                IdEmpleado = q.IdEmpleado,
                                pe_cedulaRuc = q.pe_cedulaRuc,
                                Respueta = false,
                                eliminar=true

                            }).ToList();
               }

               return lista;
           }
           catch (Exception ex)
           {

               throw;
           }
       }
       private bool si_existe(int IdEmpresa, int IdCalendario,decimal IdEmpleado, int IdPregunta)
       {
           try
           {
               using (Entity_talento_humano db = new Entity_talento_humano())
               {
                   var query = (from q in db.tlh_evaluacion_opciones_preguntas_respuesta_det
                                where q.IdEmpresa == IdEmpresa
                                && q.IdCalendario == IdCalendario
                                && q.IdEmpleado==IdEmpleado
                                && q.IdPregunta==IdPregunta
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
       public List<tlh_evaluacion_opciones_preguntas_respuesta_det_info> get_list_empleado_x_nomina(int IdEmpresa, int IdNomina, int IdCalendario, int IdPregunta)
       {
           try
           {
               List<tlh_evaluacion_opciones_preguntas_respuesta_det_info> lista = new List<tlh_evaluacion_opciones_preguntas_respuesta_det_info>();
               using (Entity_talento_humano db = new Entity_talento_humano())
               {
                  var query = (from q in db.vwtlh_evaluacion_opciones_preguntas_respuesta_det
                            where q.IdEmpresa == IdEmpresa
                            && q.IdCalendario == IdCalendario
                            && q.IdPregunta == IdPregunta

                            select q);

                  foreach (var item in query)
                  {
                      tlh_evaluacion_opciones_preguntas_respuesta_det_info info=new tlh_evaluacion_opciones_preguntas_respuesta_det_info();          
                      info.IdEmpresa = item.IdEmpresa;
                      info.IdTipoNomina = item.IdTipoNomina;
                      info.pe_apellido = item.pe_apellido + " " + item.pe_nombre;
                      info.pe_nombre = item.pe_nombre;
                      info.IdEmpleado = item.IdEmpleado;
                      info.pe_cedulaRuc = item.pe_cedulaRuc;
                      info.check = true;
                      if (item.secuencia == 1)
                          info.check1 = true;
                      if (item.secuencia == 2)
                          info.check2 = true;
                      if (item.secuencia == 3)
                          info.check3 = true;
                      if (item.secuencia == 4)
                          info.check4 = true;
                      if (item.secuencia == 5)
                          info.check5 = true;
                      info.eliminar = true;
                      lista.Add(info);
                  }

                          
               }

               return lista;
           }
           catch (Exception ex)
           {

               throw;
           }
       }
       public bool EliminarDB_DB(int IdEmpresa, int IdCalendario, int IdPregunta, decimal IdEmpleado)
       {
           try
           {
               using (Entity_talento_humano db = new Entity_talento_humano())
               {
                   string Sql = "delete Talento_humano.tlh_evaluacion_opciones_preguntas_respuesta_det where IdEmpresa='" + IdEmpresa + "' and IdCalendario='" + IdCalendario + "' and IdPregunta='" + IdPregunta + "' and IdEmpleado='"+IdEmpleado+"'";
                   db.Database.ExecuteSqlCommand(Sql);
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
