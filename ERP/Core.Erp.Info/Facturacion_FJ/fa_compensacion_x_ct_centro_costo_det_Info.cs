using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Facturacion_FJ
{
   public class fa_compensacion_x_ct_centro_costo_det_Info
   {
       public int IdEmpresa { get; set; }
       public int IdCompensacion { get; set; }
       public int Secuencia { get; set; }
       public int num_mes { get; set; }
       public double capital_reducido { get; set; }
       public Nullable<double> valor_amortizacion { get; set; }
       public Nullable<double> valor_interes_banco { get; set; }
       public Nullable<double> valor_interes_centro_costo { get; set; }
       public Nullable<double> valor_interes_diferencia { get; set; }
       public Nullable<double> dividendo { get; set; }
       public Nullable<int> IdPeriodo { get; set; }
       public bool estado_cobro { get; set; }
    }
}
