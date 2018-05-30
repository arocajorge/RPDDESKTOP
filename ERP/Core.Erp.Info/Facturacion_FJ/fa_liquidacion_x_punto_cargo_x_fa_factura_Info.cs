using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Facturacion_FJ
{
    public class fa_liquidacion_x_punto_cargo_x_fa_factura_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public string IdCentroCosto { get; set; }
        public decimal IdLiquidacion { get; set; }
        public int IdEmpresa_vta { get; set; }
        public int IdSucursal_vta { get; set; }
        public int IdBodega_vta { get; set; }
        public decimal IdCbteVta { get; set; }
        public double vta_subtotal { get; set; }
        public double vta_iva { get; set; }
        public double vta_total { get; set; }

        public string num_oc { get; set; }
        public string descripcion_fact { get; set; }
        public string Su_Descripcion { get; set; }
        public string bo_Descripcion { get; set; }
        public string vt_serie1 { get; set; }
        public string vt_serie2 { get; set; }
        public string vt_NumFactura { get; set; }
        public string pe_nombreCompleto { get; set; }
        public string ID { get; set; }
    }
}
