using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Facturacion
{
  public  class fa_guia_remision_det_x_factura_Info
  {
      public int IdEmpresa_guia { get; set; }
      public int IdSucursal_guia { get; set; }
      public int IdBodega_guia { get; set; }
      public decimal IdGuiaRemision_guia { get; set; }
      public int Secuencia_guia { get; set; }
      public int IdEmpresa_fact { get; set; }
      public int IdSucursal_fact { get; set; }
      public int IdBodega_fact { get; set; }
      public decimal IdCbteVta_fact { get; set; }
      public int Secuencia_fact { get; set; }
      public string observacion { get; set; }



      public int IdEmpresa { get; set; }
      public decimal IdCliente { get; set; }
      public string pe_cedulaRuc { get; set; }
      public string pe_apellido { get; set; }
      public string pe_nombre { get; set; }
      public int IdSucursal { get; set; }
      public int IdBodega { get; set; }
      public decimal IdCbteVta { get; set; }
      public string vt_serie1 { get; set; }
      public string vt_serie2 { get; set; }
      public string vt_NumFactura { get; set; }
      public string vt_Observacion { get; set; }
      public System.DateTime vt_fecha { get; set; }
      public bool check { get; set; }
    }
}
