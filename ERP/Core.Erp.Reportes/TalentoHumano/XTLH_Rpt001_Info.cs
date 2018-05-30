using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.TalentoHumano
{
   public class XTLH_Rpt001_Info
   {
       public int IdEmpresa { get; set; }
       public int IdPregunta { get; set; }
       public string Descripcion { get; set; }
       public Nullable<int> IdCalendario { get; set; }
       public Nullable<System.DateTime> Fecha_evaluacion { get; set; }
       public Nullable<int> TotalRegistro_x_pregunta { get; set; }
       public string Descripcion_opcion { get; set; }
       public Nullable<int> TotalRegistro_x_pregunta_x_opcion { get; set; }
       public double porcentaje { get; set; }
    }
}
