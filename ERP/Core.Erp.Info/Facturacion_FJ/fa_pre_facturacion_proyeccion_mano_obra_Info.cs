using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Facturacion_FJ
{
  public  class fa_pre_facturacion_proyeccion_mano_obra_Info
  {
      public int IdEmpresa { get; set; }
      public decimal IdPrefacturacion { get; set; }
      public int IdPeriodo { get; set; }
      public int IdCargo { get; set; }
      public string IdCentroCosto { get; set; }
      public string IdSubcentroCosto { get; set; }
      public Nullable<double> valor_proyectado { get; set; }
      public Nullable<double> ValorRealManoObra { get; set; }
      public Nullable<double> DiferenciaManoObra { get; set; }
      public string fu_descripcion { get; set; }
      public string ca_descripcion { get; set; }
      public Nullable<double> ValorModificadoManoObra { get; set; }

    }
}
