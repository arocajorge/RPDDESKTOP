using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Talento_humano
{
  public  class tlh_evaluacion_opciones_preguntas_respuesta_det_info
  {
      public int IdEmpresa { get; set; }
      public int IdCalendario { get; set; }
      public int IdPregunta { get; set; }
      public int secuencia { get; set; }
      public decimal IdEmpleado { get; set; }
      public string Observacion { get; set; }
      public bool Respueta { get; set; }

      public string pe_cedulaRuc { get; set; }
      public string pe_apellido { get; set; }
      public string pe_nombre { get; set; }
      public int IdTipoNomina { get; set; }
      public bool eliminar { get; set; }


      public bool check1 { get; set; }
      public bool check2 { get; set; }
      public bool check3 { get; set; }
      public bool check4 { get; set; }
      public bool check5 { get; set; }
      public bool check { get; set; }

    }
}
