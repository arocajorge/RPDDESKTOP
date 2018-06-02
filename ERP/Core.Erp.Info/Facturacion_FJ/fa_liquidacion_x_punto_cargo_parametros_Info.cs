using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Facturacion_FJ
{
    public class fa_liquidacion_x_punto_cargo_parametros_Info
    {
        public int IdEmpresa { get; set; }
        public Nullable<decimal> lo_IdProducto { get; set; }
        public Nullable<decimal> eg_IdProducto { get; set; }
        public Nullable<decimal> in_IdProducto { get; set; }
    }
}
