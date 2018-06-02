using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Talento_humano
{
   public class tlh_evaluacion_opciones_preguntas_info
   {
       public int IdEmpresa { get; set; }
       public int IdPregunta { get; set; }
       public int IdOpciones { get; set; }
       public int Numero_opciones { get; set; }
       public string Descripcion { get; set; }
       public bool estado { get; set; }
       public bool check { get; set; }
       public bool eliminar { get; set; }

       public List<tlh_evaluacion_opciones_preguntas_det_info> detalle { get; set; }
    }
}
