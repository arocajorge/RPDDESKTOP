using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Talento_humano
{
   public class tlh_evaluacion_opciones_preguntas_respuesta_info
   {
       public int IdEmpresa { get; set; }
       public int IdCalendario { get; set; }
       public System.DateTime Fecha_evaluacion { get; set; }
       public int Numero_preguntas { get; set; }
       public string Observacion { get; set; }
       public bool estado { get; set; }
       public tlh_evaluacion_opciones_preguntas_info info_pregunta { get; set; }
       public List<tlh_evaluacion_opciones_preguntas_respuesta_det_info> detalle { get; set; }
       public tlh_evaluacion_opciones_preguntas_respuesta_info() { detalle = new List<tlh_evaluacion_opciones_preguntas_respuesta_det_info>(); info_pregunta = new tlh_evaluacion_opciones_preguntas_info(); }
    }
}
