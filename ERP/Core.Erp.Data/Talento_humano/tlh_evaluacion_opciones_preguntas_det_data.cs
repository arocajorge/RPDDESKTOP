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
   public class tlh_evaluacion_opciones_preguntas_det_data
    {
        public bool Guardar_DB(tlh_evaluacion_opciones_preguntas_det_info info)
        {
            try
            {
                using (Entity_talento_humano entity = new Entity_talento_humano())
                {
                    tlh_evaluacion_opciones_preguntas_det add = new tlh_evaluacion_opciones_preguntas_det();
                    add.IdEmpresa = info.IdEmpresa;
                    add.IdPregunta = info.IdPregunta;
                    add.secuencia = info.secuencia;
                    add.Descripcion_opcion = info.Descripcion_opcion;
                    entity.tlh_evaluacion_opciones_preguntas_det.Add(add);
                    entity.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public bool EliminarDB_DB(tlh_evaluacion_opciones_preguntas_info info)
        {
            try
            {
                using (Entity_talento_humano db = new Entity_talento_humano())
                {
                    string Sql = "delete Talento_humano.tlh_evaluacion_opciones_preguntas_det where IdEmpresa='" + info.IdEmpresa + "' and IdPregunta='"+info.IdPregunta+"'";
                    db.Database.ExecuteSqlCommand(Sql);
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw;

            }
        }
        public List<tlh_evaluacion_opciones_preguntas_det_info> get_list(int IdEmpresa, int IdPregunta)
        {
            try
            {
                List<tlh_evaluacion_opciones_preguntas_det_info> lista = new List<tlh_evaluacion_opciones_preguntas_det_info>();
                using (Entity_talento_humano db = new Entity_talento_humano())
                {
                    lista = (from q in db.tlh_evaluacion_opciones_preguntas_det
                             where q.IdEmpresa == IdEmpresa
                             && q.IdPregunta==IdPregunta
                             select new tlh_evaluacion_opciones_preguntas_det_info
                             {
                                 IdEmpresa = q.IdEmpresa,
                                 IdPregunta = q.IdPregunta,
                                 Descripcion_opcion = q.Descripcion_opcion,
                                 secuencia = q.secuencia
                                
                             }).ToList();
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
