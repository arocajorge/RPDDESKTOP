using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.Roles
{
  public  class XROL_Rpt032_Info
  {
      public int IdEmpresa { get; set; }
      public decimal IdActaFiniquito { get; set; }
      public decimal IdEmpleado { get; set; }
      public System.DateTime FechaIngreso { get; set; }
      public System.DateTime FechaSalida { get; set; }
      public double UltimaRemuneracion { get; set; }
      public string Observacion { get; set; }
      public double Ingresos { get; set; }
      public double Egresos { get; set; }
      public string pe_cedulaRuc { get; set; }
      public string pe_apellido { get; set; }
      public string pe_nombre { get; set; }
      public string ca_descripcion { get; set; }
      public int Anio { get; set; }
      public int Mes { get; set; }
      public double Total_Remuneracion { get; set; }
      public double Total_Vacaciones { get; set; }
      public double Valor_Cancelar { get; set; }
      public Nullable<int> DiasTrabajados { get; set; }
      public string Cargo { get; set; }
      public string de_descripcion { get; set; }
      public string ob { get; set; }

    }
}
