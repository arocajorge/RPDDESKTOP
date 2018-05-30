using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Facturacion_FJ
{
  public  class fa_pre_facturacion_mano_obra_servindustria_Info
  {
      public int IdEmpresa { get; set; }
      public decimal IdPrefacturacion { get; set; }
      public Nullable<int> IdActivoFijo { get; set; }
      public Nullable<decimal> IdEmpleado { get; set; }
      public Nullable<int> IdCargo { get; set; }
      public string IdCentroCosto { get; set; }
      public string IdCentroCosto_sub_centro_costo { get; set; }
      public int IdPeriodo { get; set; }
      public double Salario { get; set; }
      public double HorasExtras { get; set; }
      public double Alimentacion { get; set; }
      public double TotalIngresos { get; set; }
      public double Total_mas_Beneficios { get; set; }
      public double TotalManoObra { get; set; }
      public string Centro_costo { get; set; }
      public string SubcentroCosto { get; set; }
      public string pe_cedulaRuc { get; set; }
      public string pe_apellido { get; set; }
      public string pe_nombre { get; set; }
      public string Af_DescripcionCorta { get; set; }
      public string ca_descripcion { get; set; }
    }
}
