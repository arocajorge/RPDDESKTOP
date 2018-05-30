using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Roles_Fj
{
  public  class ro_presupuesto_x_fuerza_x_cargo_Info
  {
      public int IdEmpresa { get; set; }
      public int IdNomina { get; set; }
      public int IdFuerza { get; set; }
      public int Anio { get; set; }
      public int Mes { get; set; }
      public int IdCargo { get; set; }
      public decimal CantidadEmpleados { get; set; }
      public double Presupuesto { get; set; }
      public string Observacion { get; set; }
      public int Dias_SyD_y_Feriado { get; set; }
      public int diasEfectivos { get; set; }
      public Nullable<double> BaseVariable { get; set; }
      public string IdCentroCosto { get; set; }
      public string IdSuccentroCosto { get; set; }

       public double diferencia { get; set; }
       public double costoRealMO { get; set; }
      

    }
}
