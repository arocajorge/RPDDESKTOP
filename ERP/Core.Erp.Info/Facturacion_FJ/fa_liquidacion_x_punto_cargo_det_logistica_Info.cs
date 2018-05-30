using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Facturacion_FJ
{
    public class fa_liquidacion_x_punto_cargo_det_logistica_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public string IdCentroCosto { get; set; }
        public decimal IdLiquidacion { get; set; }
        public int lo_secuencia { get; set; }
        public decimal IdRuta { get; set; }
        public double lo_cantidad { get; set; }
        public double lo_kilometros { get; set; }
        public double lo_precio_uni_kilometro { get; set; }
        public double lo_por_ganancia { get; set; }
        public double lo_valor_ganancia { get; set; }
        public double lo_precio_total { get; set; }
    }
}
