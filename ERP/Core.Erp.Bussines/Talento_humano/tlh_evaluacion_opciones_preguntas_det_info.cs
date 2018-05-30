using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Talento_humano;
using Core.Erp.Data.Talento_humano;

namespace Core.Erp.Business.Talento_humano
{
    public class tlh_evaluacion_opciones_preguntas_det_bus
    {
        tlh_evaluacion_opciones_preguntas_det_data data = new tlh_evaluacion_opciones_preguntas_det_data();
        public bool Guardar_DB(tlh_evaluacion_opciones_preguntas_det_info info)
        {
            try
            {

                return data.Guardar_DB(info);
            }
            catch (Exception)
            {

                throw;
            }
        }
       
        public bool Anular_DB(tlh_evaluacion_opciones_preguntas_info info)
        {
            try
            {
                return data.EliminarDB_DB(info);
            }
            catch (Exception )
            {
                throw;
            }
        }
        public List<tlh_evaluacion_opciones_preguntas_det_info> get_list(int IdEmpresa, int IdPregunta)
        {
            try
            {
                return data.get_list(IdEmpresa,IdPregunta);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
