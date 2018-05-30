using Core.Erp.Info.ActivoFijo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Facturacion_FJ
{
  public  class fa_tarifario_facturacion_x_cliente_Info
  {
      public int IdEmpresa { get; set; }
      public decimal IdTarifario { get; set; }
      public string codTarifario { get; set; }
      public string nom_tarifario { get; set; }
      public string observacion { get; set; }
      public System.DateTime fecha_inicio { get; set; }
      public System.DateTime fecha_fin { get; set; }
      public string IdUsuario { get; set; }
      public bool Estado { get; set; }
      public string nom_pc { get; set; }
      public string ip { get; set; }
      public string IdUsuarioUltMod { get; set; }
      public Nullable<System.DateTime> FechaUltMod { get; set; }
      public string IdUsuarioUltAnu { get; set; }
      public Nullable<System.DateTime> Fecha_UltAnu { get; set; }
      public string MotiAnula { get; set; }
      public string IdCentroCosto { get; set; }
      public double valor_minimo_movilizacion { get; set; }
      public double por_ganancia_inicial { get; set; }
      //Campo vista
      public string Centro_costo { get; set; }

      public List<fa_tarifario_facturacion_x_cliente_det_Info> lst_det { get; set; }
      public List<fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo_Info> lst_Act_x_tarifario { get; set; }

      public fa_tarifario_facturacion_x_cliente_Info()
      {
          lst_Act_x_tarifario = new List<fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo_Info>();
          lst_det = new List<fa_tarifario_facturacion_x_cliente_det_Info>();
      }
     

    }
}
