using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Roles
{
  public  class ro_Acta_Finiquito_Detalle_x_Decimos_Info
  {
      public int IdEmpresa { get; set; }
      public int IdNominatipo { get; set; }
      public decimal IdLiquidacion { get; set; }
      public decimal IdEmpleado { get; set; }
      public int Sec { get; set; }
      public int Anio { get; set; }
      public int Mes { get; set; }
      public double Total_Remuneracion { get; set; }
      public double Decimo { get; set; }
      public Nullable<int> DiasTrabajados { get; set; }
    }
}
