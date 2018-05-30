using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Roles
{
   public class ro_Historico_Liquidacion_Vacaciones_Det_DescNovedad_Info
   {
       public int IdEmpresa { get; set; }
       public int IdNomina_tipo { get; set; }
       public decimal IdEmpleado { get; set; }
       public int IdSolicitud_Vacaciones { get; set; }
       public decimal IdNovedad { get; set; }
       public int IdNomina_Tipo_Liq { get; set; }
       public string IdRubro { get; set; }
       public int Secuencia { get; set; }
       public double Valor { get; set; }
    }
}
