using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Facturacion_FJ
{
   public class fa_compensacion_x_ct_centro_costo_Info
   {
       public int IdEmpresa { get; set; }
       public int IdCompensacion { get; set; }
       public string IdCentroCosto { get; set; }
       public string IdCentroCosto_sub_centro_costo { get; set; }
       public string observacion { get; set; }
       public double valor_a_financiar { get; set; }
       public double num_cuotas_meses_x_centro_costo { get; set; }
       public double num_cuotas_meses_x_banco { get; set; }
       public double tasa_interes_anual_x_centro_costo { get; set; }
       public double tasa_interes_anual_x_banco { get; set; }
       public bool estado { get; set; }
       public string nom_Centro_costo { get; set; }
       public string nom_Centro_costo_sub_centro_costo { get; set; }
       public List<fa_compensacion_x_ct_centro_costo_det_Info> lista { get; set; }
    }
}
